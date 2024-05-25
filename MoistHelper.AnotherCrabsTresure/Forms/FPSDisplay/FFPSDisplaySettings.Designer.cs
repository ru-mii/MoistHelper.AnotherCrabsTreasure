
namespace MoistHelper.AnotherCrabsTresure.Forms.FPSDisplay
{
    partial class FFPSDisplaySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFPSDisplaySettings));
            this.label4 = new System.Windows.Forms.Label();
            this.UButtonText_MinimizeForm = new System.Windows.Forms.Label();
            this.UButton_MinimizeForm = new System.Windows.Forms.Label();
            this.UButtonText_CloseForm = new System.Windows.Forms.Label();
            this.UButton_CloseForm = new System.Windows.Forms.Label();
            this.timer_Hitbox = new System.Windows.Forms.Timer(this.components);
            this.checkBox_BlackBackgroundBox = new System.Windows.Forms.CheckBox();
            this.UButton_ColorPalette = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "FPS Display";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
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
            this.UButtonText_MinimizeForm.TabIndex = 50;
            this.UButtonText_MinimizeForm.Text = "--";
            // 
            // UButton_MinimizeForm
            // 
            this.UButton_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_MinimizeForm.Location = new System.Drawing.Point(238, 0);
            this.UButton_MinimizeForm.Name = "UButton_MinimizeForm";
            this.UButton_MinimizeForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_MinimizeForm.TabIndex = 49;
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
            this.UButtonText_CloseForm.TabIndex = 48;
            this.UButtonText_CloseForm.Text = "x";
            // 
            // UButton_CloseForm
            // 
            this.UButton_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_CloseForm.Location = new System.Drawing.Point(271, 0);
            this.UButton_CloseForm.Name = "UButton_CloseForm";
            this.UButton_CloseForm.Size = new System.Drawing.Size(33, 22);
            this.UButton_CloseForm.TabIndex = 47;
            // 
            // timer_Hitbox
            // 
            this.timer_Hitbox.Enabled = true;
            this.timer_Hitbox.Interval = 5;
            this.timer_Hitbox.Tick += new System.EventHandler(this.timer_Hitbox_Tick);
            // 
            // checkBox_BlackBackgroundBox
            // 
            this.checkBox_BlackBackgroundBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BlackBackgroundBox.Checked = true;
            this.checkBox_BlackBackgroundBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_BlackBackgroundBox.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.checkBox_BlackBackgroundBox.ForeColor = System.Drawing.Color.White;
            this.checkBox_BlackBackgroundBox.Location = new System.Drawing.Point(12, 110);
            this.checkBox_BlackBackgroundBox.Name = "checkBox_BlackBackgroundBox";
            this.checkBox_BlackBackgroundBox.Size = new System.Drawing.Size(200, 24);
            this.checkBox_BlackBackgroundBox.TabIndex = 52;
            this.checkBox_BlackBackgroundBox.Text = "Black Background Box";
            this.checkBox_BlackBackgroundBox.UseVisualStyleBackColor = true;
            this.checkBox_BlackBackgroundBox.CheckedChanged += new System.EventHandler(this.checkBox_BlackBackgroundBox_CheckedChanged);
            // 
            // UButton_ColorPalette
            // 
            this.UButton_ColorPalette.BackColor = System.Drawing.Color.White;
            this.UButton_ColorPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UButton_ColorPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UButton_ColorPalette.Location = new System.Drawing.Point(12, 75);
            this.UButton_ColorPalette.Name = "UButton_ColorPalette";
            this.UButton_ColorPalette.Size = new System.Drawing.Size(280, 23);
            this.UButton_ColorPalette.TabIndex = 54;
            this.UButton_ColorPalette.Click += new System.EventHandler(this.UButton_ColorPalette_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Text Color";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // FFPSDisplaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(304, 144);
            this.Controls.Add(this.UButton_ColorPalette);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_BlackBackgroundBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UButtonText_MinimizeForm);
            this.Controls.Add(this.UButton_MinimizeForm);
            this.Controls.Add(this.UButtonText_CloseForm);
            this.Controls.Add(this.UButton_CloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FFPSDisplaySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFPSDisplaySettings";
            this.Load += new System.EventHandler(this.FFPSDisplaySettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UButtonText_MinimizeForm;
        private System.Windows.Forms.Label UButton_MinimizeForm;
        private System.Windows.Forms.Label UButtonText_CloseForm;
        private System.Windows.Forms.Label UButton_CloseForm;
        private System.Windows.Forms.Timer timer_Hitbox;
        private System.Windows.Forms.CheckBox checkBox_BlackBackgroundBox;
        private System.Windows.Forms.Label UButton_ColorPalette;
        private System.Windows.Forms.Label label1;
    }
}