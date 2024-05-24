
namespace MoistHelper.AnotherCrabsTresure
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.label_Game = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UButton_ExternalInputOverlay_Start = new System.Windows.Forms.Label();
            this.UButton_ExternalInputOverlay_Settings = new System.Windows.Forms.Label();
            this.UButton_ExternalInputOverlay_AddToOBS = new System.Windows.Forms.Label();
            this.timer_Hitbox = new System.Windows.Forms.Timer(this.components);
            this.UButtonText_CloseForm = new System.Windows.Forms.Label();
            this.UButton_CloseForm = new System.Windows.Forms.Label();
            this.UButton_MinimizeForm = new System.Windows.Forms.Label();
            this.UButtonText_MinimizeForm = new System.Windows.Forms.Label();
            this.backgroundWorker_CheckForUpdates = new System.ComponentModel.BackgroundWorker();
            this.label_UpdateStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UButton_ControllerInputOverlay_AddToOBS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UButton_FPSDisplayEnable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UButton_LockFPSEnable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UButton_PracticeMod_Inject = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UButton_FPSDisplay_Settings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UButton_SteamConsoleOpen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.UButton_SteamConsoleGetManifest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Game
            // 
            this.label_Game.AutoSize = true;
            this.label_Game.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label_Game.ForeColor = System.Drawing.Color.White;
            this.label_Game.Location = new System.Drawing.Point(61, 38);
            this.label_Game.Name = "label_Game";
            this.label_Game.Size = new System.Drawing.Size(206, 17);
            this.label_Game.TabIndex = 15;
            this.label_Game.Text = "Game: Another Crab\'s Treasure";
            this.label_Game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label_Version
            // 
            this.label_Version.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label_Version.ForeColor = System.Drawing.Color.White;
            this.label_Version.Location = new System.Drawing.Point(224, 5);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(244, 23);
            this.label_Version.TabIndex = 16;
            this.label_Version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial Nova Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(57, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(161, 33);
            this.label_Title.TabIndex = 14;
            this.label_Title.Text = "Moist Helper";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(43, 43);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 17;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 2);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "External Input Overlay";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButton_ExternalInputOverlay_Start
            // 
            this.UButton_ExternalInputOverlay_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_ExternalInputOverlay_Start.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_ExternalInputOverlay_Start.Location = new System.Drawing.Point(17, 95);
            this.UButton_ExternalInputOverlay_Start.Name = "UButton_ExternalInputOverlay_Start";
            this.UButton_ExternalInputOverlay_Start.Size = new System.Drawing.Size(80, 17);
            this.UButton_ExternalInputOverlay_Start.TabIndex = 21;
            this.UButton_ExternalInputOverlay_Start.Text = "Start";
            this.UButton_ExternalInputOverlay_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UButton_ExternalInputOverlay_Settings
            // 
            this.UButton_ExternalInputOverlay_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_ExternalInputOverlay_Settings.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_ExternalInputOverlay_Settings.Location = new System.Drawing.Point(103, 95);
            this.UButton_ExternalInputOverlay_Settings.Name = "UButton_ExternalInputOverlay_Settings";
            this.UButton_ExternalInputOverlay_Settings.Size = new System.Drawing.Size(80, 17);
            this.UButton_ExternalInputOverlay_Settings.TabIndex = 22;
            this.UButton_ExternalInputOverlay_Settings.Text = "Settings";
            this.UButton_ExternalInputOverlay_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UButton_ExternalInputOverlay_AddToOBS
            // 
            this.UButton_ExternalInputOverlay_AddToOBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_ExternalInputOverlay_AddToOBS.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_ExternalInputOverlay_AddToOBS.Location = new System.Drawing.Point(189, 95);
            this.UButton_ExternalInputOverlay_AddToOBS.Name = "UButton_ExternalInputOverlay_AddToOBS";
            this.UButton_ExternalInputOverlay_AddToOBS.Size = new System.Drawing.Size(80, 17);
            this.UButton_ExternalInputOverlay_AddToOBS.TabIndex = 23;
            this.UButton_ExternalInputOverlay_AddToOBS.Text = "Add to OBS";
            this.UButton_ExternalInputOverlay_AddToOBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Hitbox
            // 
            this.timer_Hitbox.Enabled = true;
            this.timer_Hitbox.Interval = 5;
            this.timer_Hitbox.Tick += new System.EventHandler(this.timer_Hitbox_Tick);
            // 
            // UButtonText_CloseForm
            // 
            this.UButtonText_CloseForm.AutoSize = true;
            this.UButtonText_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UButtonText_CloseForm.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButtonText_CloseForm.ForeColor = System.Drawing.Color.DarkGray;
            this.UButtonText_CloseForm.Location = new System.Drawing.Point(640, 2);
            this.UButtonText_CloseForm.Name = "UButtonText_CloseForm";
            this.UButtonText_CloseForm.Size = new System.Drawing.Size(17, 20);
            this.UButtonText_CloseForm.TabIndex = 33;
            this.UButtonText_CloseForm.Text = "x";
            // 
            // UButton_CloseForm
            // 
            this.UButton_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UButton_CloseForm.Location = new System.Drawing.Point(631, 0);
            this.UButton_CloseForm.Name = "UButton_CloseForm";
            this.UButton_CloseForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_CloseForm.TabIndex = 32;
            // 
            // UButton_MinimizeForm
            // 
            this.UButton_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UButton_MinimizeForm.Location = new System.Drawing.Point(598, 0);
            this.UButton_MinimizeForm.Name = "UButton_MinimizeForm";
            this.UButton_MinimizeForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_MinimizeForm.TabIndex = 34;
            // 
            // UButtonText_MinimizeForm
            // 
            this.UButtonText_MinimizeForm.AutoSize = true;
            this.UButtonText_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UButtonText_MinimizeForm.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButtonText_MinimizeForm.ForeColor = System.Drawing.Color.DarkGray;
            this.UButtonText_MinimizeForm.Location = new System.Drawing.Point(606, -1);
            this.UButtonText_MinimizeForm.Name = "UButtonText_MinimizeForm";
            this.UButtonText_MinimizeForm.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.UButtonText_MinimizeForm.Size = new System.Drawing.Size(19, 23);
            this.UButtonText_MinimizeForm.TabIndex = 35;
            this.UButtonText_MinimizeForm.Text = "--";
            // 
            // backgroundWorker_CheckForUpdates
            // 
            this.backgroundWorker_CheckForUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_CheckForUpdates_DoWork);
            // 
            // label_UpdateStatus
            // 
            this.label_UpdateStatus.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label_UpdateStatus.ForeColor = System.Drawing.Color.Red;
            this.label_UpdateStatus.Location = new System.Drawing.Point(360, 326);
            this.label_UpdateStatus.Name = "label_UpdateStatus";
            this.label_UpdateStatus.Size = new System.Drawing.Size(297, 38);
            this.label_UpdateStatus.TabIndex = 36;
            this.label_UpdateStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(155, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(489, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "Reads your key configuration game\'s config file and uses it for the input overlay" +
    " (mouse and keyboard only)";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Controller Input Overlay";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButton_ControllerInputOverlay_AddToOBS
            // 
            this.UButton_ControllerInputOverlay_AddToOBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_ControllerInputOverlay_AddToOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_ControllerInputOverlay_AddToOBS.Location = new System.Drawing.Point(17, 145);
            this.UButton_ControllerInputOverlay_AddToOBS.Name = "UButton_ControllerInputOverlay_AddToOBS";
            this.UButton_ControllerInputOverlay_AddToOBS.Size = new System.Drawing.Size(80, 17);
            this.UButton_ControllerInputOverlay_AddToOBS.TabIndex = 39;
            this.UButton_ControllerInputOverlay_AddToOBS.Text = "Add to OBS";
            this.UButton_ControllerInputOverlay_AddToOBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(167, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 12);
            this.label6.TabIndex = 40;
            this.label6.Text = "Default full range controller overlay for OBS, if showing as red press any contro" +
    "ller button to activate it";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(92, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "Installs a \"mod\" that shows current FPS in game in the top right corner";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButton_FPSDisplayEnable
            // 
            this.UButton_FPSDisplayEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_FPSDisplayEnable.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_FPSDisplayEnable.Location = new System.Drawing.Point(17, 195);
            this.UButton_FPSDisplayEnable.Name = "UButton_FPSDisplayEnable";
            this.UButton_FPSDisplayEnable.Size = new System.Drawing.Size(80, 17);
            this.UButton_FPSDisplayEnable.TabIndex = 42;
            this.UButton_FPSDisplayEnable.Text = "Enable";
            this.UButton_FPSDisplayEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "FPS Display";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(113, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "Installs a \"mod\" that locks the in-game fps to 60";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButton_LockFPSEnable
            // 
            this.UButton_LockFPSEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_LockFPSEnable.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_LockFPSEnable.Location = new System.Drawing.Point(17, 245);
            this.UButton_LockFPSEnable.Name = "UButton_LockFPSEnable";
            this.UButton_LockFPSEnable.Size = new System.Drawing.Size(80, 17);
            this.UButton_LockFPSEnable.TabIndex = 45;
            this.UButton_LockFPSEnable.Text = "Enable";
            this.UButton_LockFPSEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Lock FPS to 60";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(104, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(464, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Injects a tool mod at a runtime, enables debug panel in pause menu and adds savin" +
    "g/loading position,\r\nopen with Insert/Menu/Gamepad Start";
            // 
            // UButton_PracticeMod_Inject
            // 
            this.UButton_PracticeMod_Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_PracticeMod_Inject.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_PracticeMod_Inject.Location = new System.Drawing.Point(17, 295);
            this.UButton_PracticeMod_Inject.Name = "UButton_PracticeMod_Inject";
            this.UButton_PracticeMod_Inject.Size = new System.Drawing.Size(80, 17);
            this.UButton_PracticeMod_Inject.TabIndex = 48;
            this.UButton_PracticeMod_Inject.Text = "Inject";
            this.UButton_PracticeMod_Inject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "Practice Mod";
            // 
            // UButton_FPSDisplay_Settings
            // 
            this.UButton_FPSDisplay_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_FPSDisplay_Settings.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_FPSDisplay_Settings.Location = new System.Drawing.Point(103, 195);
            this.UButton_FPSDisplay_Settings.Name = "UButton_FPSDisplay_Settings";
            this.UButton_FPSDisplay_Settings.Size = new System.Drawing.Size(80, 17);
            this.UButton_FPSDisplay_Settings.TabIndex = 50;
            this.UButton_FPSDisplay_Settings.Text = "Settings";
            this.UButton_FPSDisplay_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Nova", 7F);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(113, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 12);
            this.label7.TabIndex = 53;
            this.label7.Text = "Steam console used for downpatching the game";
            // 
            // UButton_SteamConsoleOpen
            // 
            this.UButton_SteamConsoleOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_SteamConsoleOpen.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_SteamConsoleOpen.Location = new System.Drawing.Point(17, 345);
            this.UButton_SteamConsoleOpen.Name = "UButton_SteamConsoleOpen";
            this.UButton_SteamConsoleOpen.Size = new System.Drawing.Size(80, 17);
            this.UButton_SteamConsoleOpen.TabIndex = 52;
            this.UButton_SteamConsoleOpen.Text = "Open";
            this.UButton_SteamConsoleOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Steam Console";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Magenta;
            this.label16.Location = new System.Drawing.Point(273, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "made by rumii";
            // 
            // UButton_SteamConsoleGetManifest
            // 
            this.UButton_SteamConsoleGetManifest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_SteamConsoleGetManifest.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_SteamConsoleGetManifest.Location = new System.Drawing.Point(103, 345);
            this.UButton_SteamConsoleGetManifest.Name = "UButton_SteamConsoleGetManifest";
            this.UButton_SteamConsoleGetManifest.Size = new System.Drawing.Size(80, 17);
            this.UButton_SteamConsoleGetManifest.TabIndex = 56;
            this.UButton_SteamConsoleGetManifest.Text = "Get Manifest";
            this.UButton_SteamConsoleGetManifest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(664, 375);
            this.Controls.Add(this.UButton_SteamConsoleGetManifest);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UButton_SteamConsoleOpen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UButton_FPSDisplay_Settings);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UButton_PracticeMod_Inject);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UButton_LockFPSEnable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UButton_FPSDisplayEnable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UButton_ControllerInputOverlay_AddToOBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_UpdateStatus);
            this.Controls.Add(this.UButtonText_MinimizeForm);
            this.Controls.Add(this.UButton_MinimizeForm);
            this.Controls.Add(this.UButtonText_CloseForm);
            this.Controls.Add(this.UButton_CloseForm);
            this.Controls.Add(this.UButton_ExternalInputOverlay_AddToOBS);
            this.Controls.Add(this.UButton_ExternalInputOverlay_Settings);
            this.Controls.Add(this.UButton_ExternalInputOverlay_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.label_Game);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoistHelper.AnotherCrabsTreasure";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Game;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UButton_ExternalInputOverlay_Start;
        private System.Windows.Forms.Label UButton_ExternalInputOverlay_Settings;
        private System.Windows.Forms.Label UButton_ExternalInputOverlay_AddToOBS;
        private System.Windows.Forms.Timer timer_Hitbox;
        private System.Windows.Forms.Label UButtonText_CloseForm;
        private System.Windows.Forms.Label UButton_CloseForm;
        private System.Windows.Forms.Label UButton_MinimizeForm;
        private System.Windows.Forms.Label UButtonText_MinimizeForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker_CheckForUpdates;
        private System.Windows.Forms.Label label_UpdateStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UButton_ControllerInputOverlay_AddToOBS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UButton_FPSDisplayEnable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UButton_LockFPSEnable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label UButton_PracticeMod_Inject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label UButton_FPSDisplay_Settings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UButton_SteamConsoleOpen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label UButton_SteamConsoleGetManifest;
    }
}

