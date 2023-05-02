namespace BildschirmKoordinaten
{
    partial class win
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win));
            this.lblKoordinaten = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lblKoordinaten
            // 
            this.lblKoordinaten.AutoSize = true;
            this.lblKoordinaten.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblKoordinaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKoordinaten.Location = new System.Drawing.Point(136, 130);
            this.lblKoordinaten.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKoordinaten.Name = "lblKoordinaten";
            this.lblKoordinaten.Size = new System.Drawing.Size(36, 25);
            this.lblKoordinaten.TabIndex = 0;
            this.lblKoordinaten.Text = "---";
            this.lblKoordinaten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(325, 298);
            this.Controls.Add(this.lblKoordinaten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.win_FormClosing);
            this.Load += new System.EventHandler(this.win_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.win_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.win_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.win_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.win_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKoordinaten;
        public NotifyIcon notifyIcon1;
    }
}