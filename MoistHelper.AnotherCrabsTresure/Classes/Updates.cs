using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure
{
    internal class Updates
    {
        // build version, adding new line because github adds it to their file
        // and the version is being compared with one written in github file in repo
        internal static string softwareVersion = "6" + "\n";

        // create client, read string with version from my server and then when read
        // it will run the event function "versionReadComplete" and will have the read version
        // it's doing it like this with events so it could run in the background
        // and not freeze the app if server dies or user's internet dies
        internal static void CheckForUpdates()
        {
            // using "try" in case connection drops and exception gets thrown
            try
            {
                // enabling TLS as it's required for connection with github
                //ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

                WebClient webCl = new WebClient();
                webCl.DownloadStringCompleted += new DownloadStringCompletedEventHandler(VersionReadComplete);
                webCl.DownloadStringAsync(new Uri("https://raw.githubusercontent.com/ru-mii/MoistHelper.AnotherCrabsTreasure/main/VERSION"));
            }
            catch { }
        }

        // this launches when version number is finally read from the server
        static void VersionReadComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            Label updateStatus = null; int sleepLength = 0;
            FMain formWrapper = Application.OpenForms["FMain"] as FMain;

            // using "try" in case connection drops and exception gets thrown
            try
            {
                // if current version is not the latest version
                formWrapper.Invoke((MethodInvoker)delegate
                {
                    foreach (Control control in formWrapper.Controls)
                    {
                        if (control.Name == "label_UpdateStatus")
                        {
                            updateStatus = control as Label;
                            break;
                        }
                    }

                    if (updateStatus != null)
                    {
                        if (e.Result != softwareVersion)
                        {
                            if (e.Result.Length > 0)
                            {
                                updateStatus.ForeColor = Color.Red;
                                updateStatus.Text = "Update available!";
                                sleepLength = 5000;
                            }
                        }
                        else
                        {
                            updateStatus.ForeColor = Color.LimeGreen;
                            updateStatus.Text = "Program up to date!";
                            sleepLength = 2000;
                        }
                    }

                });

                Thread.Sleep(sleepLength);

                formWrapper.Invoke((MethodInvoker)delegate
                {
                    if (updateStatus != null)
                        updateStatus.Text = "";
                });
            }
            catch
            {
                formWrapper.Invoke((MethodInvoker)delegate
                {
                    updateStatus.Text = "";
                });
            }
        }
    }
}
