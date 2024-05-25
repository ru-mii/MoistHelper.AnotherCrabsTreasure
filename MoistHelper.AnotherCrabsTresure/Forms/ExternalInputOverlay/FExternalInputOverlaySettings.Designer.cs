
namespace MoistHelper.AnotherCrabsTresure.Forms.ExternalInputOverlay
{
    partial class FExternalInputOverlaySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExternalInputOverlaySettings));
            this.UButtonText_MinimizeForm = new System.Windows.Forms.Label();
            this.UButton_MinimizeForm = new System.Windows.Forms.Label();
            this.UButtonText_CloseForm = new System.Windows.Forms.Label();
            this.UButton_CloseForm = new System.Windows.Forms.Label();
            this.timer_Hitbox = new System.Windows.Forms.Timer(this.components);
            this.comboBox_Preset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UButton_ColorPalette = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_WindowAlwaysOnTop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UButtonText_MinimizeForm
            // 
            this.UButtonText_MinimizeForm.AutoSize = true;
            this.UButtonText_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButtonText_MinimizeForm.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButtonText_MinimizeForm.ForeColor = System.Drawing.Color.DarkGray;
            this.UButtonText_MinimizeForm.Location = new System.Drawing.Point(246, -1);
            this.UButtonText_MinimizeForm.Name = "UButtonText_MinimizeForm";
            this.UButtonText_MinimizeForm.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.UButtonText_MinimizeForm.Size = new System.Drawing.Size(19, 23);
            this.UButtonText_MinimizeForm.TabIndex = 39;
            this.UButtonText_MinimizeForm.Text = "--";
            // 
            // UButton_MinimizeForm
            // 
            this.UButton_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_MinimizeForm.Location = new System.Drawing.Point(238, 0);
            this.UButton_MinimizeForm.Name = "UButton_MinimizeForm";
            this.UButton_MinimizeForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_MinimizeForm.TabIndex = 38;
            // 
            // UButtonText_CloseForm
            // 
            this.UButtonText_CloseForm.AutoSize = true;
            this.UButtonText_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButtonText_CloseForm.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButtonText_CloseForm.ForeColor = System.Drawing.Color.DarkGray;
            this.UButtonText_CloseForm.Location = new System.Drawing.Point(280, 2);
            this.UButtonText_CloseForm.Name = "UButtonText_CloseForm";
            this.UButtonText_CloseForm.Size = new System.Drawing.Size(17, 20);
            this.UButtonText_CloseForm.TabIndex = 37;
            this.UButtonText_CloseForm.Text = "x";
            // 
            // UButton_CloseForm
            // 
            this.UButton_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_CloseForm.Location = new System.Drawing.Point(271, 0);
            this.UButton_CloseForm.Name = "UButton_CloseForm";
            this.UButton_CloseForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_CloseForm.TabIndex = 36;
            // 
            // timer_Hitbox
            // 
            this.timer_Hitbox.Enabled = true;
            this.timer_Hitbox.Interval = 5;
            this.timer_Hitbox.Tick += new System.EventHandler(this.timer_Hitbox_Tick);
            // 
            // comboBox_Preset
            // 
            this.comboBox_Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Preset.Location = new System.Drawing.Point(12, 72);
            this.comboBox_Preset.Name = "comboBox_Preset";
            this.comboBox_Preset.Size = new System.Drawing.Size(280, 21);
            this.comboBox_Preset.TabIndex = 40;
            this.comboBox_Preset.SelectedIndexChanged += new System.EventHandler(this.comboBox_Preset_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Key Preset";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Window Background Color";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButton_ColorPalette
            // 
            this.UButton_ColorPalette.BackColor = System.Drawing.Color.LimeGreen;
            this.UButton_ColorPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UButton_ColorPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UButton_ColorPalette.Location = new System.Drawing.Point(12, 127);
            this.UButton_ColorPalette.Name = "UButton_ColorPalette";
            this.UButton_ColorPalette.Size = new System.Drawing.Size(280, 23);
            this.UButton_ColorPalette.TabIndex = 43;
            this.UButton_ColorPalette.Click += new System.EventHandler(this.UButton_ColorPalette_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Window Always On Top";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // comboBox_WindowAlwaysOnTop
            // 
            this.comboBox_WindowAlwaysOnTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_WindowAlwaysOnTop.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_WindowAlwaysOnTop.Location = new System.Drawing.Point(12, 187);
            this.comboBox_WindowAlwaysOnTop.Name = "comboBox_WindowAlwaysOnTop";
            this.comboBox_WindowAlwaysOnTop.Size = new System.Drawing.Size(280, 21);
            this.comboBox_WindowAlwaysOnTop.TabIndex = 44;
            this.comboBox_WindowAlwaysOnTop.SelectedIndexChanged += new System.EventHandler(this.comboBox_WindowAlwaysOnTop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "External Input Overlay";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // FExternalInputOverlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(304, 225);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_WindowAlwaysOnTop);
            this.Controls.Add(this.UButton_ColorPalette);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Preset);
            this.Controls.Add(this.UButtonText_MinimizeForm);
            this.Controls.Add(this.UButton_MinimizeForm);
            this.Controls.Add(this.UButtonText_CloseForm);
            this.Controls.Add(this.UButton_CloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FExternalInputOverlaySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FExternalInputOverlaySettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FExternalInputOverlaySettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UButtonText_MinimizeForm;
        private System.Windows.Forms.Label UButton_MinimizeForm;
        private System.Windows.Forms.Label UButtonText_CloseForm;
        private System.Windows.Forms.Label UButton_CloseForm;
        private System.Windows.Forms.Timer timer_Hitbox;
        private System.Windows.Forms.ComboBox comboBox_Preset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UButton_ColorPalette;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_WindowAlwaysOnTop;
        private System.Windows.Forms.Label label4;
    }
}