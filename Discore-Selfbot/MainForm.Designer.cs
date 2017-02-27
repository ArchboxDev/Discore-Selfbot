namespace Discore_Selfbot
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("self test");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("self botinfo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("self afk");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("self lewd | self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("self form | self gui");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("self tag");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("self addtag");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("randomcat");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Coming Soon", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Sekusuikuto");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.ChannelList = new System.Windows.Forms.ComboBox();
            this.ChannelLogView = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.TreeView();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.EmbedText = new System.Windows.Forms.TextBox();
            this.EmbedColorSelect = new System.Windows.Forms.ColorDialog();
            this.OpenColorsButton = new System.Windows.Forms.Button();
            this.EmbedSelected = new System.Windows.Forms.Button();
            this.ActiveGuildStatus = new System.Windows.Forms.StatusStrip();
            this.AGTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGName = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACID = new System.Windows.Forms.ToolStripStatusLabel();
            this.EmbedActive = new System.Windows.Forms.Button();
            this.GuildList = new System.Windows.Forms.ToolStrip();
            this.MoreInfo = new System.Windows.Forms.TextBox();
            this.OtherInfo = new System.Windows.Forms.TextBox();
            this.ActiveGuildStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChannelList
            // 
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.Location = new System.Drawing.Point(12, 55);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(220, 21);
            this.ChannelList.TabIndex = 0;
            this.ChannelList.Visible = false;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelSelected);
            // 
            // ChannelLogView
            // 
            this.ChannelLogView.Location = new System.Drawing.Point(12, 82);
            this.ChannelLogView.Multiline = true;
            this.ChannelLogView.Name = "ChannelLogView";
            this.ChannelLogView.ReadOnly = true;
            this.ChannelLogView.Size = new System.Drawing.Size(220, 172);
            this.ChannelLogView.TabIndex = 1;
            this.ChannelLogView.Text = "Channel logs comming soon ;)";
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(238, 55);
            this.Information.Name = "Information";
            treeNode1.Name = "self test";
            treeNode1.Text = "self test";
            treeNode1.ToolTipText = "Test if the bot works";
            treeNode2.Name = "self info";
            treeNode2.Text = "self info";
            treeNode2.ToolTipText = "Get info about yourself such as the ammount of guilds";
            treeNode3.Name = "self botinfo";
            treeNode3.Text = "self botinfo";
            treeNode3.ToolTipText = "Get info about the bot";
            treeNode4.Name = "self afk";
            treeNode4.Text = "self afk";
            treeNode4.ToolTipText = "Toggle an AFK messsage in DMs only";
            treeNode5.Name = "self cleanembed";
            treeNode5.Text = "self cleanembed";
            treeNode5.ToolTipText = "Clean up your your embeds";
            treeNode6.Name = "self embed (Text)";
            treeNode6.Text = "self embed (Text)";
            treeNode6.ToolTipText = "Embed a message with text";
            treeNode7.Name = "self lenny";
            treeNode7.Text = "self lenny";
            treeNode7.ToolTipText = "Insert lenny face";
            treeNode8.Name = "self lewd | self lewd (Text)";
            treeNode8.Text = "self lewd | self lewd (Text)";
            treeNode8.ToolTipText = "You know what this is :3";
            treeNode9.Name = "self form | self gui";
            treeNode9.Text = "self form | self gui";
            treeNode9.ToolTipText = "Open the main form";
            treeNode10.Name = "Commands";
            treeNode10.Text = "Commands";
            treeNode11.Name = "self tag";
            treeNode11.Text = "self tag";
            treeNode11.ToolTipText = "Get a text tag";
            treeNode12.Name = "self addtag";
            treeNode12.Text = "self addtag";
            treeNode12.ToolTipText = "Save a message to a tag";
            treeNode13.Name = "randomcat";
            treeNode13.Text = "randomcat";
            treeNode13.ToolTipText = "Random cat image";
            treeNode14.Name = "Coming Soon";
            treeNode14.Text = "Coming Soon";
            treeNode15.Name = "PixelBot";
            treeNode15.Text = "PixelBot";
            treeNode15.ToolTipText = "A gamer featured bot with twitch streamer alerts";
            treeNode16.Name = "Minotaur";
            treeNode16.Text = "Minotaur";
            treeNode16.ToolTipText = "A guild moderation bot with modlog channel and full user/guild logs";
            treeNode17.Name = "My Bots";
            treeNode17.Text = "My Bots";
            treeNode17.ToolTipText = "Shameless promotions ik :P";
            treeNode18.Name = "Discord Cards";
            treeNode18.Text = "Discord Cards";
            treeNode18.ToolTipText = "A really cool bot made by Snazzah and other peeps which has a card collection sys" +
    "tem and daily money";
            treeNode19.Name = "Casino Bot";
            treeNode19.Text = "Casino Bot";
            treeNode19.ToolTipText = "Spin the wheel!";
            treeNode20.Name = "Discord RPG";
            treeNode20.Text = "Discord RPG";
            treeNode20.ToolTipText = "A really awesome RPG game bot";
            treeNode21.Name = "Fun Bots";
            treeNode21.Text = "Fun Bots";
            treeNode21.ToolTipText = "Bots that have a game or fun premise";
            treeNode22.Name = "Sekusuikuto";
            treeNode22.Text = "Sekusuikuto";
            treeNode22.ToolTipText = "Made by Bubbie which has some usefull random commands and modlogs";
            treeNode23.Name = "Other Bots";
            treeNode23.Text = "Other Bots";
            treeNode23.ToolTipText = "Other cool bots :)";
            this.Information.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode17,
            treeNode21,
            treeNode23});
            this.Information.ShowNodeToolTips = true;
            this.Information.Size = new System.Drawing.Size(234, 251);
            this.Information.TabIndex = 2;
            this.Information.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Information_AfterSelect);
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Location = new System.Drawing.Point(12, 260);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(164, 20);
            this.EmbedTitle.TabIndex = 3;
            this.EmbedTitle.Text = "Title";
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(12, 286);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(164, 20);
            this.EmbedText.TabIndex = 4;
            this.EmbedText.Text = "Text";
            // 
            // OpenColorsButton
            // 
            this.OpenColorsButton.Location = new System.Drawing.Point(182, 260);
            this.OpenColorsButton.Name = "OpenColorsButton";
            this.OpenColorsButton.Size = new System.Drawing.Size(50, 46);
            this.OpenColorsButton.TabIndex = 5;
            this.OpenColorsButton.Text = "Color";
            this.OpenColorsButton.UseVisualStyleBackColor = true;
            this.OpenColorsButton.Click += new System.EventHandler(this.OpenColorsButton_Click);
            // 
            // EmbedSelected
            // 
            this.EmbedSelected.Location = new System.Drawing.Point(12, 312);
            this.EmbedSelected.Name = "EmbedSelected";
            this.EmbedSelected.Size = new System.Drawing.Size(100, 39);
            this.EmbedSelected.TabIndex = 6;
            this.EmbedSelected.Text = "Send to selected channel";
            this.EmbedSelected.UseVisualStyleBackColor = true;
            this.EmbedSelected.Click += new System.EventHandler(this.SelectedChannelClick);
            // 
            // ActiveGuildStatus
            // 
            this.ActiveGuildStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AGTitle,
            this.AGName,
            this.AGID,
            this.ACTitle,
            this.ACName,
            this.ACID});
            this.ActiveGuildStatus.Location = new System.Drawing.Point(0, 439);
            this.ActiveGuildStatus.Name = "ActiveGuildStatus";
            this.ActiveGuildStatus.Size = new System.Drawing.Size(484, 22);
            this.ActiveGuildStatus.TabIndex = 7;
            this.ActiveGuildStatus.Text = "statusStrip1";
            // 
            // AGTitle
            // 
            this.AGTitle.Name = "AGTitle";
            this.AGTitle.Size = new System.Drawing.Size(54, 17);
            this.AGTitle.Text = "Active G:";
            // 
            // AGName
            // 
            this.AGName.AutoToolTip = true;
            this.AGName.Name = "AGName";
            this.AGName.Size = new System.Drawing.Size(35, 17);
            this.AGName.Text = "Guild";
            this.AGName.ToolTipText = "Guild Name";
            // 
            // AGID
            // 
            this.AGID.AutoToolTip = true;
            this.AGID.Name = "AGID";
            this.AGID.Size = new System.Drawing.Size(33, 17);
            this.AGID.Text = "(420)";
            this.AGID.ToolTipText = "Guild ID";
            // 
            // ACTitle
            // 
            this.ACTitle.Name = "ACTitle";
            this.ACTitle.Size = new System.Drawing.Size(18, 17);
            this.ACTitle.Text = "C:";
            // 
            // ACName
            // 
            this.ACName.AutoToolTip = true;
            this.ACName.Name = "ACName";
            this.ACName.Size = new System.Drawing.Size(51, 17);
            this.ACName.Text = "Channel";
            this.ACName.ToolTipText = "Channel Name";
            // 
            // ACID
            // 
            this.ACID.AutoToolTip = true;
            this.ACID.Name = "ACID";
            this.ACID.Size = new System.Drawing.Size(27, 17);
            this.ACID.Text = "(69)";
            this.ACID.ToolTipText = "Channel ID";
            // 
            // EmbedActive
            // 
            this.EmbedActive.Location = new System.Drawing.Point(132, 312);
            this.EmbedActive.Name = "EmbedActive";
            this.EmbedActive.Size = new System.Drawing.Size(100, 39);
            this.EmbedActive.TabIndex = 8;
            this.EmbedActive.Text = "Send to active channel";
            this.EmbedActive.UseVisualStyleBackColor = true;
            this.EmbedActive.Click += new System.EventHandler(this.EmbedActive_Click);
            // 
            // GuildList
            // 
            this.GuildList.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.GuildList.Location = new System.Drawing.Point(0, 0);
            this.GuildList.Name = "GuildList";
            this.GuildList.Size = new System.Drawing.Size(484, 25);
            this.GuildList.Stretch = true;
            this.GuildList.TabIndex = 9;
            this.GuildList.Text = "toolStrip1";
            this.GuildList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GuildList_Clicked);
            // 
            // MoreInfo
            // 
            this.MoreInfo.Location = new System.Drawing.Point(238, 312);
            this.MoreInfo.Multiline = true;
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.ReadOnly = true;
            this.MoreInfo.Size = new System.Drawing.Size(234, 124);
            this.MoreInfo.TabIndex = 10;
            this.MoreInfo.Visible = false;
            // 
            // OtherInfo
            // 
            this.OtherInfo.Location = new System.Drawing.Point(12, 357);
            this.OtherInfo.Multiline = true;
            this.OtherInfo.Name = "OtherInfo";
            this.OtherInfo.ReadOnly = true;
            this.OtherInfo.Size = new System.Drawing.Size(220, 79);
            this.OtherInfo.TabIndex = 11;
            this.OtherInfo.Text = "More features coming soon!\r\nI will also need to get an icon for this :/\r\n\r\nMy Gui" +
    "ld: WJTYdNb";
            this.OtherInfo.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.OtherInfo);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.GuildList);
            this.Controls.Add(this.EmbedActive);
            this.Controls.Add(this.ActiveGuildStatus);
            this.Controls.Add(this.EmbedSelected);
            this.Controls.Add(this.OpenColorsButton);
            this.Controls.Add(this.EmbedText);
            this.Controls.Add(this.EmbedTitle);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.ChannelLogView);
            this.Controls.Add(this.ChannelList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ActiveGuildStatus.ResumeLayout(false);
            this.ActiveGuildStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ChannelList;
        private System.Windows.Forms.TextBox ChannelLogView;
        private System.Windows.Forms.TreeView Information;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.TextBox EmbedText;
        private System.Windows.Forms.ColorDialog EmbedColorSelect;
        private System.Windows.Forms.Button OpenColorsButton;
        private System.Windows.Forms.Button EmbedSelected;
        private System.Windows.Forms.StatusStrip ActiveGuildStatus;
        private System.Windows.Forms.ToolStripStatusLabel AGTitle;
        public System.Windows.Forms.ToolStripStatusLabel AGName;
        public System.Windows.Forms.ToolStripStatusLabel AGID;
        private System.Windows.Forms.ToolStripStatusLabel ACTitle;
        public System.Windows.Forms.ToolStripStatusLabel ACName;
        public System.Windows.Forms.ToolStripStatusLabel ACID;
        private System.Windows.Forms.Button EmbedActive;
        public System.Windows.Forms.ToolStrip GuildList;
        private System.Windows.Forms.TextBox MoreInfo;
        private System.Windows.Forms.TextBox OtherInfo;
    }
}