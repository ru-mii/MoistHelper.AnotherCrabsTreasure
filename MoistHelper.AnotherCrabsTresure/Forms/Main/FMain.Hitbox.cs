
using MoistHelper.AnotherCrabsTresure.ExternalInputOverlay;
using MoistHelper.AnotherCrabsTresure.Forms.ExternalInputOverlay;
using MoistHelper.AnotherCrabsTresure.Forms.FPSDisplay;
using MoistHelper.AnotherCrabsTresure.Forms.ManifestSelect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure
{
    public partial class FMain : Form
    {
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        private bool hitboxEnabled = true;

        Color Color_Button_Click = Color.FromArgb(255, 255, 255);
        Color Color_Button_Hover = Color.FromArgb(225, 225, 225);
        Color Color_Button_Default = Color.FromArgb(195, 195, 195);

        Color Color_ButtonHeader_Click = Color.FromArgb(56, 56, 56);
        Color Color_ButtonHeader_Hover = Color.FromArgb(34, 34, 34);
        Color Color_ButtonHeader_Default = Color.FromArgb(18, 18, 18);

        //UButton_FPSDisplay_Settings

        private void MouseFormMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        bool ___ExternalInputOverlay = false;
        bool ___ExternalInputOverlaySettings = false;
        bool ___ExternalInputOverlayAddToObs = false;
        bool ___ControllerInputOverlayAddToObs = false;
        bool ___FPSDisplayEnable = false;
        bool ___FPSLockEnable = false;
        bool ___FPSDisplaySettings = false;
        bool ___PracticeModInject = false;
        bool ___SteamConsoleOpen = false;
        bool ___SteamConsoleGetManifest = false;
        bool ___CloseForm = false;
        bool ___MinimizeForm = false;
        private void timer_Hitbox_Tick(object sender, EventArgs e)
        {
            if (hitboxEnabled)
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
                        if (___CloseForm) Environment.Exit(0);
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

                #region BUTTON - EXTERNAL INPUT OVERLAY
                if (IsCursorInBounds(UButton_ExternalInputOverlay_Start.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_ExternalInputOverlay_Start.BackColor = Color_Button_Click;
                        ___ExternalInputOverlay = true;
                    }
                    else
                    {
                        if (___ExternalInputOverlay)
                        {
                            ___ExternalInputOverlay = false;

                            if (!ProgramUtils.IsFormOpen("FExternalInputOverlay"))
                            {
                                FExternalInputOverlay externalInputOverlay = new FExternalInputOverlay();
                                externalInputOverlay.Show();
                            }
                        }

                        UButton_ExternalInputOverlay_Start.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___ExternalInputOverlay = false;
                    UButton_ExternalInputOverlay_Start.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - EXTERNAL INPUT OVERLAY
                #region BUTTON - EXTERNAL INPUT OVERLAY SETTINGS
                if (IsCursorInBounds(UButton_ExternalInputOverlay_Settings.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_ExternalInputOverlay_Settings.BackColor = Color_Button_Click;
                        ___ExternalInputOverlaySettings = true;
                    }
                    else
                    {
                        if (___ExternalInputOverlaySettings)
                        {
                            ___ExternalInputOverlaySettings = false;

                            if (!ProgramUtils.IsFormOpen("FExternalInputOverlaySettings"))
                            {
                                FExternalInputOverlaySettings externalInputOverlaySettings = new FExternalInputOverlaySettings();
                                externalInputOverlaySettings.Show();
                            }
                        }

                        UButton_ExternalInputOverlay_Settings.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___ExternalInputOverlaySettings = false;
                    UButton_ExternalInputOverlay_Settings.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - EXTERNAL INPUT OVERLAY SETTINGS
                #region BUTTON - EXTERNAL INPUT OVERLAY ADD TO OBS
                if (IsCursorInBounds(UButton_ExternalInputOverlay_AddToOBS.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_ExternalInputOverlay_AddToOBS.BackColor = Color_Button_Click;
                        ___ExternalInputOverlayAddToObs = true;
                    }
                    else
                    {
                        if (___ExternalInputOverlayAddToObs)
                        {
                            ___ExternalInputOverlayAddToObs = false;

                            OBSOperations.AddExternalInputWindow();
                        }

                        UButton_ExternalInputOverlay_AddToOBS.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___ExternalInputOverlayAddToObs = false;
                    UButton_ExternalInputOverlay_AddToOBS.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - EXTERNAL INPUT OVERLAY ADD TO OBS

                #region BUTTON - CONTROLLER INPUT OVERLAY ADD TO OBS
                if (IsCursorInBounds(UButton_ControllerInputOverlay_AddToOBS.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_ControllerInputOverlay_AddToOBS.BackColor = Color_Button_Click;
                        ___ControllerInputOverlayAddToObs = true;
                    }
                    else
                    {
                        if (___ControllerInputOverlayAddToObs)
                        {
                            ___ControllerInputOverlayAddToObs = false;

                            OBSOperations.AddControllerInputOverlay();
                        }

                        UButton_ControllerInputOverlay_AddToOBS.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___ControllerInputOverlayAddToObs = false;
                    UButton_ControllerInputOverlay_AddToOBS.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - CONTROLLER INPUT OVERLAY ADD TO OBS

                #region BUTTON - FPS DISPLAY SETTINGS
                if (IsCursorInBounds(UButton_FPSDisplay_Settings.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_FPSDisplay_Settings.BackColor = Color_Button_Click;
                        ___FPSDisplaySettings = true;
                    }
                    else
                    {
                        if (___FPSDisplaySettings)
                        {
                            ___FPSDisplaySettings = false;

                            if (!ProgramUtils.IsFormOpen("FFPSDisplaySettings"))
                            {
                                FFPSDisplaySettings externalInputOverlaySettings = new FFPSDisplaySettings();
                                externalInputOverlaySettings.Show();
                            }
                        }

                        UButton_FPSDisplay_Settings.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___FPSDisplaySettings = false;
                    UButton_FPSDisplay_Settings.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - FPS DISPLAY SETTINGS
                #region BUTTON - FPS DISPLAY ENABLE
                if (IsCursorInBounds(UButton_FPSDisplayEnable.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_FPSDisplayEnable.BackColor = Color_Button_Click;
                        ___FPSDisplayEnable = true;
                    }
                    else
                    {
                        if (___FPSDisplayEnable)
                        {
                            ___FPSDisplayEnable = false;

                            if (UButton_FPSDisplayEnable.Text == "Enable")
                            {
                                if (ModManager.InstallMod())
                                {
                                    FPSManager.ShowFPS(true);
                                    ProgramUtils.ShowInfo("Success!");
                                    UButton_FPSDisplayEnable.Text = "Disable";
                                }
                            }
                            else
                            {
                                FPSManager.ShowFPS(false);
                                UButton_FPSDisplayEnable.Text = "Enable";
                            }
                        }

                        UButton_FPSDisplayEnable.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___FPSDisplayEnable = false;
                    UButton_FPSDisplayEnable.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - FPS DISPLAY ENABLE
                #region BUTTON - FPS LOCK ENABLE
                if (IsCursorInBounds(UButton_LockFPSEnable.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_LockFPSEnable.BackColor = Color_Button_Click;
                        ___FPSLockEnable = true;
                    }
                    else
                    {
                        if (___FPSLockEnable)
                        {
                            ___FPSLockEnable = false;

                            if (UButton_LockFPSEnable.Text == "Enable")
                            {
                                if (ModManager.InstallMod())
                                {
                                    FPSManager.LockFPS(true);
                                    ProgramUtils.ShowInfo("Success!");
                                    UButton_LockFPSEnable.Text = "Disable";
                                }
                            }
                            else
                            {
                                FPSManager.LockFPS(false);
                                UButton_LockFPSEnable.Text = "Enable";
                            }
                        }

                        UButton_LockFPSEnable.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___FPSLockEnable = false;
                    UButton_LockFPSEnable.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - FPS LOCK ENABLE

                #region BUTTON - PRACTICE MOD INJECT
                if (IsCursorInBounds(UButton_PracticeMod_Inject.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_PracticeMod_Inject.BackColor = Color_Button_Click;
                        ___PracticeModInject = true;
                    }
                    else
                    {
                        if (___PracticeModInject)
                        {
                            ___PracticeModInject = false;

                            ModManager.InjectPracticeMod();
                        }

                        UButton_PracticeMod_Inject.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___PracticeModInject = false;
                    UButton_PracticeMod_Inject.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - PRACTICE MOD INJECT

                #region BUTTON - STEAM CONSOLE OPEN
                if (IsCursorInBounds(UButton_SteamConsoleOpen.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_SteamConsoleOpen.BackColor = Color_Button_Click;
                        ___SteamConsoleOpen = true;
                    }
                    else
                    {
                        if (___SteamConsoleOpen)
                        {
                            ___SteamConsoleOpen = false;

                            Process.Start("steam://open/console");
                        }

                        UButton_SteamConsoleOpen.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___SteamConsoleOpen = false;
                    UButton_SteamConsoleOpen.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - STEAM CONSOLE OPEN
                #region BUTTON - GET MANIFEST
                if (IsCursorInBounds(UButton_SteamConsoleGetManifest.Bounds))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        UButton_SteamConsoleGetManifest.BackColor = Color_Button_Click;
                        ___SteamConsoleGetManifest = true;
                    }
                    else
                    {
                        if (___SteamConsoleGetManifest)
                        {
                            ___SteamConsoleGetManifest = false;

                            if (!ProgramUtils.IsFormOpen("FManifestSelect"))
                            {
                                FManifestSelect manifestSelect = new FManifestSelect();
                                manifestSelect.Show();
                            }
                        }

                        UButton_SteamConsoleGetManifest.BackColor = Color_Button_Hover;
                    }
                }
                else
                {
                    ___SteamConsoleGetManifest = false;
                    UButton_SteamConsoleGetManifest.BackColor = Color_Button_Default;
                }
                #endregion BUTTON - GET MANIFEST
            }

            hitboxEnabled = this == ActiveForm;
        }

        private bool IsCursorInBounds(Rectangle rectangle)
        {
            Point cursor = PointToClient(Cursor.Position);
            return cursor.X >= rectangle.X && cursor.X <= rectangle.X + rectangle.Width &&
                cursor.Y >= rectangle.Y && cursor.Y <= rectangle.Y + rectangle.Height;
        }
    }
}
