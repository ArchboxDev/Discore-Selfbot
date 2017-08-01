namespace Discore_Selfbot
{
    partial class NotifyMenu
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
            this.BtnHideConsole = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnShowConsole = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnOpenGUI = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // BtnHideConsole
            // 
            this.BtnHideConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHideConsole.Location = new System.Drawing.Point(0, 0);
            this.BtnHideConsole.Name = "BtnHideConsole";
            this.BtnHideConsole.Size = new System.Drawing.Size(184, 50);
            this.BtnHideConsole.TabIndex = 1;
            this.BtnHideConsole.Values.Text = "Hide Console";
            this.BtnHideConsole.Click += new System.EventHandler(this.BtnHideConsole_Click);
            // 
            // BtnShowConsole
            // 
            this.BtnShowConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShowConsole.Location = new System.Drawing.Point(0, 50);
            this.BtnShowConsole.Name = "BtnShowConsole";
            this.BtnShowConsole.Size = new System.Drawing.Size(184, 50);
            this.BtnShowConsole.TabIndex = 2;
            this.BtnShowConsole.Values.Text = "Show Console";
            this.BtnShowConsole.Click += new System.EventHandler(this.BtnShowConsole_Click);
            // 
            // BtnOpenGUI
            // 
            this.BtnOpenGUI.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpenGUI.Location = new System.Drawing.Point(0, 100);
            this.BtnOpenGUI.Name = "BtnOpenGUI";
            this.BtnOpenGUI.Size = new System.Drawing.Size(184, 50);
            this.BtnOpenGUI.TabIndex = 3;
            this.BtnOpenGUI.Values.Text = "Open GUI";
            this.BtnOpenGUI.Click += new System.EventHandler(this.BtnOpenGUI_Click);
            // 
            // NotifyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 151);
            this.Controls.Add(this.BtnOpenGUI);
            this.Controls.Add(this.BtnShowConsole);
            this.Controls.Add(this.BtnHideConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "NotifyMenu";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Discore-Selfbot Menu";
            this.TextExtra = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotifyMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnHideConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnShowConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnOpenGUI;
    }
}