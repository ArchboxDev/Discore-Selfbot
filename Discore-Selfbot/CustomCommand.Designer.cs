namespace Discore_Selfbot
{
    partial class CustomCommand
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
            this.CC_NavMain = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.CC_NavMessagePage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_NavMessage = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.CC_NavMessageTextPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_MessageContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.CC_MessageTextDone = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CC_MessageErrors = new System.Windows.Forms.ListBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CC_NavMessageEmbedPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_NavGalleryPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_NavWebhookPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_NavWebhook = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.CC_NavWebhookText = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CC_NavWebhookEmbedPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMain)).BeginInit();
            this.CC_NavMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessagePage)).BeginInit();
            this.CC_NavMessagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessage)).BeginInit();
            this.CC_NavMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessageTextPage)).BeginInit();
            this.CC_NavMessageTextPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer.Panel1)).BeginInit();
            this.CC_MessageContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer.Panel2)).BeginInit();
            this.CC_MessageContainer.Panel2.SuspendLayout();
            this.CC_MessageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessageEmbedPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavGalleryPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookPage)).BeginInit();
            this.CC_NavWebhookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhook)).BeginInit();
            this.CC_NavWebhook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookEmbedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // CC_NavMain
            // 
            this.CC_NavMain.AllowPageReorder = false;
            this.CC_NavMain.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.CC_NavMain.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.CC_NavMain.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.CC_NavMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CC_NavMain.Location = new System.Drawing.Point(0, 0);
            this.CC_NavMain.Name = "CC_NavMain";
            this.CC_NavMain.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.CC_NavMessagePage,
            this.CC_NavGalleryPage,
            this.CC_NavWebhookPage});
            this.CC_NavMain.SelectedIndex = 0;
            this.CC_NavMain.Size = new System.Drawing.Size(284, 261);
            this.CC_NavMain.TabIndex = 0;
            this.CC_NavMain.Text = "kryptonNavigator1";
            // 
            // CC_NavMessagePage
            // 
            this.CC_NavMessagePage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavMessagePage.Controls.Add(this.CC_NavMessage);
            this.CC_NavMessagePage.Flags = 65534;
            this.CC_NavMessagePage.LastVisibleSet = true;
            this.CC_NavMessagePage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavMessagePage.Name = "CC_NavMessagePage";
            this.CC_NavMessagePage.Size = new System.Drawing.Size(282, 234);
            this.CC_NavMessagePage.Text = "message";
            this.CC_NavMessagePage.ToolTipTitle = "Page ToolTip";
            this.CC_NavMessagePage.UniqueName = "5C69C86FE7904920B6A22D339191F31C";
            // 
            // CC_NavMessage
            // 
            this.CC_NavMessage.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.CC_NavMessage.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidth;
            this.CC_NavMessage.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.CC_NavMessage.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.CC_NavMessage.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.CC_NavMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CC_NavMessage.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.CC_NavMessage.Location = new System.Drawing.Point(0, 0);
            this.CC_NavMessage.Name = "CC_NavMessage";
            this.CC_NavMessage.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            this.CC_NavMessage.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.CC_NavMessageTextPage,
            this.CC_NavMessageEmbedPage});
            this.CC_NavMessage.SelectedIndex = 0;
            this.CC_NavMessage.Size = new System.Drawing.Size(282, 234);
            this.CC_NavMessage.TabIndex = 9;
            this.CC_NavMessage.Text = "kryptonNavigator1";
            // 
            // CC_NavMessageTextPage
            // 
            this.CC_NavMessageTextPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavMessageTextPage.Controls.Add(this.CC_MessageContainer);
            this.CC_NavMessageTextPage.Controls.Add(this.kryptonLabel2);
            this.CC_NavMessageTextPage.Controls.Add(this.kryptonTextBox1);
            this.CC_NavMessageTextPage.Controls.Add(this.kryptonHeader1);
            this.CC_NavMessageTextPage.Controls.Add(this.kryptonLabel1);
            this.CC_NavMessageTextPage.Flags = 65534;
            this.CC_NavMessageTextPage.LastVisibleSet = true;
            this.CC_NavMessageTextPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavMessageTextPage.Name = "CC_NavMessageTextPage";
            this.CC_NavMessageTextPage.Size = new System.Drawing.Size(280, 208);
            this.CC_NavMessageTextPage.Text = "Text";
            this.CC_NavMessageTextPage.ToolTipTitle = "Page ToolTip";
            this.CC_NavMessageTextPage.UniqueName = "1635D269C129459CCC8871C0CAB66A63";
            // 
            // CC_MessageContainer
            // 
            this.CC_MessageContainer.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.CC_MessageContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CC_MessageContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CC_MessageContainer.Location = new System.Drawing.Point(0, 81);
            this.CC_MessageContainer.Name = "CC_MessageContainer";
            // 
            // CC_MessageContainer.Panel1
            // 
            this.CC_MessageContainer.Panel1.Controls.Add(this.kryptonRichTextBox1);
            this.CC_MessageContainer.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            // 
            // CC_MessageContainer.Panel2
            // 
            this.CC_MessageContainer.Panel2.Controls.Add(this.CC_MessageTextDone);
            this.CC_MessageContainer.Panel2.Controls.Add(this.CC_MessageErrors);
            this.CC_MessageContainer.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.CC_MessageContainer.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.CC_MessageContainer.Size = new System.Drawing.Size(280, 127);
            this.CC_MessageContainer.SplitterDistance = 161;
            this.CC_MessageContainer.TabIndex = 4;
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(155, 122);
            this.kryptonRichTextBox1.TabIndex = 0;
            this.kryptonRichTextBox1.Text = "";
            this.kryptonRichTextBox1.TextChanged += new System.EventHandler(this.kryptonRichTextBox1_TextChanged);
            // 
            // CC_MessageTextDone
            // 
            this.CC_MessageTextDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CC_MessageTextDone.Location = new System.Drawing.Point(0, 87);
            this.CC_MessageTextDone.Name = "CC_MessageTextDone";
            this.CC_MessageTextDone.Size = new System.Drawing.Size(114, 40);
            this.CC_MessageTextDone.TabIndex = 0;
            this.CC_MessageTextDone.Values.Text = "Done";
            this.CC_MessageTextDone.Click += new System.EventHandler(this.CC_MessageTextDone_Click);
            // 
            // CC_MessageErrors
            // 
            this.CC_MessageErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CC_MessageErrors.FormattingEnabled = true;
            this.CC_MessageErrors.Location = new System.Drawing.Point(0, 0);
            this.CC_MessageErrors.Name = "CC_MessageErrors";
            this.CC_MessageErrors.Size = new System.Drawing.Size(114, 127);
            this.CC_MessageErrors.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(83, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(33, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "self";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(122, 6);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(148, 23);
            this.kryptonTextBox1.TabIndex = 2;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.AutoSize = false;
            this.kryptonHeader1.Location = new System.Drawing.Point(10, 32);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(260, 44);
            this.kryptonHeader1.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Message";
            this.kryptonHeader1.Values.Image = null;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Command";
            // 
            // CC_NavMessageEmbedPage
            // 
            this.CC_NavMessageEmbedPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavMessageEmbedPage.Flags = 65534;
            this.CC_NavMessageEmbedPage.LastVisibleSet = true;
            this.CC_NavMessageEmbedPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavMessageEmbedPage.Name = "CC_NavMessageEmbedPage";
            this.CC_NavMessageEmbedPage.Size = new System.Drawing.Size(280, 209);
            this.CC_NavMessageEmbedPage.Text = "Embed";
            this.CC_NavMessageEmbedPage.ToolTipTitle = "Page ToolTip";
            this.CC_NavMessageEmbedPage.UniqueName = "E1FF2C7914C34B417AA8BFF17BFB6E40";
            // 
            // CC_NavGalleryPage
            // 
            this.CC_NavGalleryPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavGalleryPage.Flags = 65534;
            this.CC_NavGalleryPage.LastVisibleSet = true;
            this.CC_NavGalleryPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavGalleryPage.Name = "CC_NavGalleryPage";
            this.CC_NavGalleryPage.Size = new System.Drawing.Size(282, 235);
            this.CC_NavGalleryPage.Text = "gallery";
            this.CC_NavGalleryPage.ToolTipTitle = "Page ToolTip";
            this.CC_NavGalleryPage.UniqueName = "6EED020CFCA34548DEADBB367FFEF3E4";
            // 
            // CC_NavWebhookPage
            // 
            this.CC_NavWebhookPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavWebhookPage.Controls.Add(this.CC_NavWebhook);
            this.CC_NavWebhookPage.Flags = 65534;
            this.CC_NavWebhookPage.LastVisibleSet = true;
            this.CC_NavWebhookPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavWebhookPage.Name = "CC_NavWebhookPage";
            this.CC_NavWebhookPage.Size = new System.Drawing.Size(282, 235);
            this.CC_NavWebhookPage.Text = "webhook";
            this.CC_NavWebhookPage.ToolTipTitle = "Page ToolTip";
            this.CC_NavWebhookPage.UniqueName = "2FE9A08E0DA745845C86B620B96BD1D3";
            // 
            // CC_NavWebhook
            // 
            this.CC_NavWebhook.Bar.CheckButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.CC_NavWebhook.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidth;
            this.CC_NavWebhook.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.CC_NavWebhook.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.CC_NavWebhook.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.CC_NavWebhook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CC_NavWebhook.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.CC_NavWebhook.Location = new System.Drawing.Point(0, 0);
            this.CC_NavWebhook.Name = "CC_NavWebhook";
            this.CC_NavWebhook.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarCheckButtonGroupOutside;
            this.CC_NavWebhook.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.CC_NavWebhookText,
            this.CC_NavWebhookEmbedPage});
            this.CC_NavWebhook.SelectedIndex = 0;
            this.CC_NavWebhook.Size = new System.Drawing.Size(282, 235);
            this.CC_NavWebhook.TabIndex = 10;
            this.CC_NavWebhook.Text = "kryptonNavigator1";
            // 
            // CC_NavWebhookText
            // 
            this.CC_NavWebhookText.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavWebhookText.Flags = 65534;
            this.CC_NavWebhookText.LastVisibleSet = true;
            this.CC_NavWebhookText.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavWebhookText.Name = "CC_NavWebhookText";
            this.CC_NavWebhookText.Size = new System.Drawing.Size(280, 209);
            this.CC_NavWebhookText.Text = "Text";
            this.CC_NavWebhookText.ToolTipTitle = "Page ToolTip";
            this.CC_NavWebhookText.UniqueName = "1635D269C129459CCC8871C0CAB66A63";
            // 
            // CC_NavWebhookEmbedPage
            // 
            this.CC_NavWebhookEmbedPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.CC_NavWebhookEmbedPage.Flags = 65534;
            this.CC_NavWebhookEmbedPage.LastVisibleSet = true;
            this.CC_NavWebhookEmbedPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.CC_NavWebhookEmbedPage.Name = "CC_NavWebhookEmbedPage";
            this.CC_NavWebhookEmbedPage.Size = new System.Drawing.Size(280, 209);
            this.CC_NavWebhookEmbedPage.Text = "Embed";
            this.CC_NavWebhookEmbedPage.ToolTipTitle = "Page ToolTip";
            this.CC_NavWebhookEmbedPage.UniqueName = "E1FF2C7914C34B417AA8BFF17BFB6E40";
            // 
            // CustomCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CC_NavMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomCommand";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Custom Command";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomCommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMain)).EndInit();
            this.CC_NavMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessagePage)).EndInit();
            this.CC_NavMessagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessage)).EndInit();
            this.CC_NavMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessageTextPage)).EndInit();
            this.CC_NavMessageTextPage.ResumeLayout(false);
            this.CC_NavMessageTextPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer.Panel1)).EndInit();
            this.CC_MessageContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer.Panel2)).EndInit();
            this.CC_MessageContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_MessageContainer)).EndInit();
            this.CC_MessageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavMessageEmbedPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavGalleryPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookPage)).EndInit();
            this.CC_NavWebhookPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhook)).EndInit();
            this.CC_NavWebhook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_NavWebhookEmbedPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator CC_NavMain;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavMessagePage;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavGalleryPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavWebhookPage;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator CC_NavMessage;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavMessageTextPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavMessageEmbedPage;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator CC_NavWebhook;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavWebhookText;
        private ComponentFactory.Krypton.Navigator.KryptonPage CC_NavWebhookEmbedPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer CC_MessageContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CC_MessageTextDone;
        private System.Windows.Forms.ListBox CC_MessageErrors;
    }
}