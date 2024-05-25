
namespace MoistHelper.AnotherCrabsTresure.Forms.ManifestSelect
{
    partial class FManifestSelect
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UButtonText_MinimizeForm = new System.Windows.Forms.Label();
            this.UButton_MinimizeForm = new System.Windows.Forms.Label();
            this.UButtonText_CloseForm = new System.Windows.Forms.Label();
            this.UButton_CloseForm = new System.Windows.Forms.Label();
            this.timer_Hitbox = new System.Windows.Forms.Timer(this.components);
            this.UButton_CopyDepotCommand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "",
            " 1.0.102.4a (17 May 2024)     7794119491796787415",
            " 1.0.102.5 (16 May 2024)      4728245539429933934",
            " 1.0.102.4 (15 May 2024)      6794101123455558986",
            " 1.0.102.3 (10 May 2024)      7658685294987384385",
            " 1.0.102.2 (9 May 2024)       4203276684159284202",
            " 1.0.102.1 (7 May 2024)       1732548446016186143",
            " 1.0.102.0 (7 May 2024)       2699032172598868660",
            " 1.0.101.2 (6 May 2024)       5863143986415932389",
            " 1.0.101.1 (4 May 2024)       9028734776910317609",
            " 1.0.101.1 (1 May 2024)       5646133299167900604",
            " 1.0.101.0 (1 May 2024)       1265004100187659655",
            " 1.0.100.8 (30 April 2024)    8660113306761323918",
            " 1.0.100.7b (28 April 2024)   6304678135197002112",
            " 1.0.100.7a (28 April 2024)   8603642691594655105",
            " 1.0.100.6 (27 April 2024)    38264701123475085",
            " 1.0.100.5 (25 April 2024)    5464213323450739080"});
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 270);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Get Manifest";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // UButtonText_MinimizeForm
            // 
            this.UButtonText_MinimizeForm.AutoSize = true;
            this.UButtonText_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButtonText_MinimizeForm.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButtonText_MinimizeForm.ForeColor = System.Drawing.Color.DarkGray;
            this.UButtonText_MinimizeForm.Location = new System.Drawing.Point(334, -1);
            this.UButtonText_MinimizeForm.Name = "UButtonText_MinimizeForm";
            this.UButtonText_MinimizeForm.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.UButtonText_MinimizeForm.Size = new System.Drawing.Size(19, 23);
            this.UButtonText_MinimizeForm.TabIndex = 50;
            this.UButtonText_MinimizeForm.Text = "--";
            // 
            // UButton_MinimizeForm
            // 
            this.UButton_MinimizeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_MinimizeForm.Location = new System.Drawing.Point(326, 0);
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
            this.UButtonText_CloseForm.Location = new System.Drawing.Point(368, 2);
            this.UButtonText_CloseForm.Name = "UButtonText_CloseForm";
            this.UButtonText_CloseForm.Size = new System.Drawing.Size(17, 20);
            this.UButtonText_CloseForm.TabIndex = 48;
            this.UButtonText_CloseForm.Text = "x";
            // 
            // UButton_CloseForm
            // 
            this.UButton_CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UButton_CloseForm.Location = new System.Drawing.Point(359, 0);
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
            // UButton_CopyDepotCommand
            // 
            this.UButton_CopyDepotCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.UButton_CopyDepotCommand.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton_CopyDepotCommand.Location = new System.Drawing.Point(16, 332);
            this.UButton_CopyDepotCommand.Name = "UButton_CopyDepotCommand";
            this.UButton_CopyDepotCommand.Size = new System.Drawing.Size(364, 17);
            this.UButton_CopyDepotCommand.TabIndex = 52;
            this.UButton_CopyDepotCommand.Text = "Copy download_depot command to clipboard";
            this.UButton_CopyDepotCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 8F);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(250, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Select one of the versions";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            // 
            // FManifestSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(392, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UButton_CopyDepotCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UButtonText_MinimizeForm);
            this.Controls.Add(this.UButton_MinimizeForm);
            this.Controls.Add(this.UButtonText_CloseForm);
            this.Controls.Add(this.UButton_CloseForm);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FManifestSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManifestSelect";
            this.Load += new System.EventHandler(this.FManifestSelect_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseFormMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UButtonText_MinimizeForm;
        private System.Windows.Forms.Label UButton_MinimizeForm;
        private System.Windows.Forms.Label UButtonText_CloseForm;
        private System.Windows.Forms.Label UButton_CloseForm;
        private System.Windows.Forms.Timer timer_Hitbox;
        private System.Windows.Forms.Label UButton_CopyDepotCommand;
        private System.Windows.Forms.Label label1;
    }
}