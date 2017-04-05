namespace Discore_Selfbot
{
    partial class EmbedPopup
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.EmbedText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedFooter = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedColorStrip = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EmbedPaint = new System.Windows.Forms.ToolStripButton();
            this.EmbedClear = new System.Windows.Forms.ToolStripButton();
            this.EmbedSend = new System.Windows.Forms.ToolStripButton();
            this.BtnEmbedColor = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.ActiveStatus = new System.Windows.Forms.ToolStrip();
            this.ActiveTitleG = new System.Windows.Forms.ToolStripLabel();
            this.ActiveGuild = new System.Windows.Forms.ToolStripLabel();
            this.ActiveSep = new System.Windows.Forms.ToolStripSeparator();
            this.ActiveTitleC = new System.Windows.Forms.ToolStripLabel();
            this.ActiveChannel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ActiveStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.EmbedText);
            this.kryptonPanel1.Controls.Add(this.EmbedTitle);
            this.kryptonPanel1.Controls.Add(this.EmbedFooter);
            this.kryptonPanel1.Controls.Add(this.EmbedColorStrip);
            this.kryptonPanel1.Controls.Add(this.toolStrip1);
            this.kryptonPanel1.Controls.Add(this.BtnEmbedColor);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(214, 139);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // EmbedText
            // 
            this.EmbedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmbedText.Location = new System.Drawing.Point(10, 48);
            this.EmbedText.Multiline = true;
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(204, 68);
            this.EmbedText.TabIndex = 39;
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmbedTitle.Location = new System.Drawing.Point(10, 25);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(204, 23);
            this.EmbedTitle.TabIndex = 38;
            // 
            // EmbedFooter
            // 
            this.EmbedFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmbedFooter.Location = new System.Drawing.Point(10, 116);
            this.EmbedFooter.Name = "EmbedFooter";
            this.EmbedFooter.Size = new System.Drawing.Size(204, 23);
            this.EmbedFooter.TabIndex = 40;
            // 
            // EmbedColorStrip
            // 
            this.EmbedColorStrip.BackColor = System.Drawing.Color.White;
            this.EmbedColorStrip.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EmbedColorStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmbedColorStrip.Location = new System.Drawing.Point(0, 25);
            this.EmbedColorStrip.Multiline = true;
            this.EmbedColorStrip.Name = "EmbedColorStrip";
            this.EmbedColorStrip.ReadOnly = true;
            this.EmbedColorStrip.Size = new System.Drawing.Size(10, 114);
            this.EmbedColorStrip.TabIndex = 42;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmbedPaint,
            this.toolStripSeparator1,
            this.EmbedClear,
            this.toolStripSeparator2,
            this.EmbedSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(214, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "ToolstripEmbedCreator";
            // 
            // EmbedPaint
            // 
            this.EmbedPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmbedPaint.Name = "EmbedPaint";
            this.EmbedPaint.Size = new System.Drawing.Size(40, 22);
            this.EmbedPaint.Text = "Color";
            this.EmbedPaint.Click += new System.EventHandler(this.EmbedPaint_Click);
            // 
            // EmbedClear
            // 
            this.EmbedClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmbedClear.Name = "EmbedClear";
            this.EmbedClear.Size = new System.Drawing.Size(38, 22);
            this.EmbedClear.Text = "Clear";
            this.EmbedClear.Click += new System.EventHandler(this.EmbedClear_Click);
            // 
            // EmbedSend
            // 
            this.EmbedSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmbedSend.Name = "EmbedSend";
            this.EmbedSend.Size = new System.Drawing.Size(77, 22);
            this.EmbedSend.Text = "Send Embed";
            this.EmbedSend.Click += new System.EventHandler(this.EmbedSend_Click);
            // 
            // BtnEmbedColor
            // 
            this.BtnEmbedColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEmbedColor.DropDownOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.BtnEmbedColor.DropDownPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.BtnEmbedColor.Location = new System.Drawing.Point(174, 25);
            this.BtnEmbedColor.Name = "BtnEmbedColor";
            this.BtnEmbedColor.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch25;
            this.BtnEmbedColor.SelectedColor = System.Drawing.Color.Empty;
            this.BtnEmbedColor.Size = new System.Drawing.Size(40, 81);
            this.BtnEmbedColor.Splitter = false;
            this.BtnEmbedColor.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch25;
            this.BtnEmbedColor.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.BtnEmbedColor.StatePressed.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.BtnEmbedColor.StateTracking.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.BtnEmbedColor.TabIndex = 24;
            this.BtnEmbedColor.Values.Text = "Embed\r\nColor\r\n";
            this.BtnEmbedColor.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.BtnEmbedColor_SelectedColorChanged);
            // 
            // ActiveStatus
            // 
            this.ActiveStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActiveStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ActiveStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ActiveStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActiveTitleG,
            this.ActiveGuild,
            this.ActiveSep,
            this.ActiveTitleC,
            this.ActiveChannel});
            this.ActiveStatus.Location = new System.Drawing.Point(0, 136);
            this.ActiveStatus.Name = "ActiveStatus";
            this.ActiveStatus.Size = new System.Drawing.Size(214, 25);
            this.ActiveStatus.TabIndex = 52;
            // 
            // ActiveTitleG
            // 
            this.ActiveTitleG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ActiveTitleG.Name = "ActiveTitleG";
            this.ActiveTitleG.Size = new System.Drawing.Size(19, 22);
            this.ActiveTitleG.Text = "G:";
            // 
            // ActiveGuild
            // 
            this.ActiveGuild.Name = "ActiveGuild";
            this.ActiveGuild.Size = new System.Drawing.Size(52, 22);
            this.ActiveGuild.Text = "MyGuild";
            // 
            // ActiveSep
            // 
            this.ActiveSep.Name = "ActiveSep";
            this.ActiveSep.Size = new System.Drawing.Size(6, 25);
            // 
            // ActiveTitleC
            // 
            this.ActiveTitleC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ActiveTitleC.Name = "ActiveTitleC";
            this.ActiveTitleC.Size = new System.Drawing.Size(17, 22);
            this.ActiveTitleC.Text = "C:";
            // 
            // ActiveChannel
            // 
            this.ActiveChannel.Name = "ActiveChannel";
            this.ActiveChannel.Size = new System.Drawing.Size(52, 22);
            this.ActiveChannel.Text = "MyChan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EmbedPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 161);
            this.Controls.Add(this.ActiveStatus);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "EmbedPopup";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Embed Popup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ActiveStatus.ResumeLayout(false);
            this.ActiveStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton EmbedPaint;
        private System.Windows.Forms.ToolStripButton EmbedClear;
        private System.Windows.Forms.TextBox EmbedColorStrip;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedText;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedFooter;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton BtnEmbedColor;
        private System.Windows.Forms.ToolStripButton EmbedSend;
        private System.Windows.Forms.ToolStrip ActiveStatus;
        private System.Windows.Forms.ToolStripLabel ActiveTitleG;
        public System.Windows.Forms.ToolStripLabel ActiveGuild;
        private System.Windows.Forms.ToolStripSeparator ActiveSep;
        private System.Windows.Forms.ToolStripLabel ActiveTitleC;
        public System.Windows.Forms.ToolStripLabel ActiveChannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}