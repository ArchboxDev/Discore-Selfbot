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
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("selft test");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("self botinfo");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("self game (Game)");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("self afk");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("self lewd | self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("self form | self gui");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("self tag");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("self addtag");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Coming Soon", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Sekusuikuto");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode68});
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
            this.ChannelLogView.Size = new System.Drawing.Size(220, 172);
            this.ChannelLogView.TabIndex = 1;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(238, 82);
            this.Information.Name = "Information";
            treeNode47.Name = "self test";
            treeNode47.Text = "selft test";
            treeNode47.ToolTipText = "Test if the bot works";
            treeNode48.Name = "self info";
            treeNode48.Text = "self info";
            treeNode48.ToolTipText = "Get info about yourself such as the ammount of guilds";
            treeNode49.Name = "self botinfo";
            treeNode49.Text = "self botinfo";
            treeNode49.ToolTipText = "Get info about the bot";
            treeNode50.Name = "self game (Game)";
            treeNode50.Text = "self game (Game)";
            treeNode50.ToolTipText = "Set your game status";
            treeNode51.Name = "self afk";
            treeNode51.Text = "self afk";
            treeNode51.ToolTipText = "Set yourself as afk";
            treeNode52.Name = "self cleanembed";
            treeNode52.Text = "self cleanembed";
            treeNode52.ToolTipText = "Clean up your your embeds";
            treeNode53.Name = "self embed (Text)";
            treeNode53.Text = "self embed (Text)";
            treeNode53.ToolTipText = "Embed a message with text";
            treeNode54.Name = "self lenny";
            treeNode54.Text = "self lenny";
            treeNode54.ToolTipText = "Insert lenny face";
            treeNode55.Name = "self lewd | self lewd (Text)";
            treeNode55.Text = "self lewd | self lewd (Text)";
            treeNode55.ToolTipText = "You know what this is :3";
            treeNode56.Name = "self form | self gui";
            treeNode56.Text = "self form | self gui";
            treeNode56.ToolTipText = "Open the main form";
            treeNode57.Name = "Commands";
            treeNode57.Text = "Commands";
            treeNode58.Name = "self tag";
            treeNode58.Text = "self tag";
            treeNode58.ToolTipText = "Get a tag you made";
            treeNode59.Name = "self addtag";
            treeNode59.Text = "self addtag";
            treeNode59.ToolTipText = "Add text to a tag which you can use later";
            treeNode60.Name = "Coming Soon";
            treeNode60.Text = "Coming Soon";
            treeNode61.Name = "PixelBot";
            treeNode61.Text = "PixelBot";
            treeNode61.ToolTipText = "A gamer featured bot with twitch streamer alerts";
            treeNode62.Name = "Minotaur";
            treeNode62.Text = "Minotaur";
            treeNode62.ToolTipText = "A guild moderation bot with modlog channel and full user/guild logs";
            treeNode63.Name = "My Bots";
            treeNode63.Text = "My Bots";
            treeNode63.ToolTipText = "Shameless promotions ik :P";
            treeNode64.Name = "Discord Cards";
            treeNode64.Text = "Discord Cards";
            treeNode64.ToolTipText = "A really cool bot made by Snazzah and other peeps which has a card collection sys" +
    "tem and daily money";
            treeNode65.Name = "Casino Bot";
            treeNode65.Text = "Casino Bot";
            treeNode65.ToolTipText = "Spin the wheel!";
            treeNode66.Name = "Discord RPG";
            treeNode66.Text = "Discord RPG";
            treeNode66.ToolTipText = "A really awesome RPG game bot";
            treeNode67.Name = "Fun Bots";
            treeNode67.Text = "Fun Bots";
            treeNode67.ToolTipText = "Bots that have a game or fun premise";
            treeNode68.Name = "Sekusuikuto";
            treeNode68.Text = "Sekusuikuto";
            treeNode68.ToolTipText = "Made by Bubbie which has some usefull random commands and modlogs";
            treeNode69.Name = "Other Bots";
            treeNode69.Text = "Other Bots";
            treeNode69.ToolTipText = "Other cool bots :)";
            this.Information.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode60,
            treeNode63,
            treeNode67,
            treeNode69});
            this.Information.ShowNodeToolTips = true;
            this.Information.Size = new System.Drawing.Size(234, 251);
            this.Information.TabIndex = 2;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
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
    }
}