﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure.Forms.ManifestSelect
{
    public partial class FManifestSelect : Form
    {
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        Color Color_Button_Click = Color.FromArgb(255, 255, 255);
        Color Color_Button_Hover = Color.FromArgb(225, 225, 225);
        Color Color_Button_Default = Color.FromArgb(195, 195, 195);

        Color Color_ButtonHeader_Click = Color.FromArgb(62, 62, 62);
        Color Color_ButtonHeader_Hover = Color.FromArgb(40, 40, 40);
        Color Color_ButtonHeader_Default = Color.FromArgb(24, 24, 24);

        bool ___CloseForm = false;
        bool ___MinimizeForm = false;
        bool ___CopyDepotCommand = false;

        private void timer_Hitbox_Tick(object sender, EventArgs e)
        {
            #region BUTTON - MINIMIZE FORM
            if (IsCursorInBounds(UButton_MinimizeForm.Bounds))
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    ___MinimizeForm = true;
                    UButton_MinimizeForm.BackColor = Color_ButtonHeader_Click;
                    UButtonText_MinimizeForm.BackColor = Color_ButtonHeader_Click;
                }
                else
                {
                    if (___MinimizeForm) WindowState = FormWindowState.Minimized;

                    ___MinimizeForm = false;
                    UButton_MinimizeForm.BackColor = Color_ButtonHeader_Hover;
                    UButtonText_MinimizeForm.BackColor = Color_ButtonHeader_Hover;
                }
            }
            else
            {
                ___MinimizeForm = false;
                UButton_MinimizeForm.BackColor = Color_ButtonHeader_Default;
                UButtonText_MinimizeForm.BackColor = Color_ButtonHeader_Default;
            }
            #endregion BUTTON - MINIMIZE FORM
            #region BUTTON - CLOSE FORM
            if (IsCursorInBounds(UButton_CloseForm.Bounds))
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    ___CloseForm = true;
                    UButton_CloseForm.BackColor = Color_ButtonHeader_Click;
                    UButtonText_CloseForm.BackColor = Color_ButtonHeader_Click;
                }
                else
                {
                    if (___CloseForm)
                    {
                        ___CloseForm = false;
                        Close();
                        return;
                    }
                    UButton_CloseForm.BackColor = Color_ButtonHeader_Hover;
                    UButtonText_CloseForm.BackColor = Color_ButtonHeader_Hover;
                }
            }
            else
            {
                ___CloseForm = false;
                UButton_CloseForm.BackColor = Color_ButtonHeader_Default;
                UButtonText_CloseForm.BackColor = Color_ButtonHeader_Default;
            }
            #endregion BUTTON - CLOSE FORM

            #region BUTTON - COPY DEPOT COMMAND
            if (IsCursorInBounds(UButton_CopyDepotCommand.Bounds))
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    UButton_CopyDepotCommand.BackColor = Color_Button_Click;
                    ___CopyDepotCommand = true;
                }
                else
                {
                    if (___CopyDepotCommand)
                    {
                        ___CopyDepotCommand = false;

                        if (listBox1.Text.Contains("."))
                        {
                            string text = listBox1.Text;
                            text = text.Substring(text.LastIndexOf(" "));
                            text = "download_depot 1887840 1887841" + text;
                            Clipboard.SetText(text);
                        }
                        else ProgramUtils.ShowError("You need to select one of the versions on the list first.");
                    }

                    UButton_CopyDepotCommand.BackColor = Color_Button_Hover;
                }
            }
            else
            {
                ___CopyDepotCommand = false;
                UButton_CopyDepotCommand.BackColor = Color_Button_Default;
            }
            #endregion BUTTON - COPY DEPOT COMMAND
        }

        private bool IsCursorInBounds(Rectangle rectangle)
        {
            Point cursor = PointToClient(Cursor.Position);
            return cursor.X >= rectangle.X && cursor.X <= rectangle.X + rectangle.Width &&
                cursor.Y >= rectangle.Y && cursor.Y <= rectangle.Y + rectangle.Height;
        }


        private void MouseFormMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}