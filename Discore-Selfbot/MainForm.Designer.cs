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
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("selft test");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("self botinfo");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("self game (Game)");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("self afk");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("self lewd | self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("self form | self gui");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("self tag");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("self addtag");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Coming Soon", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode88,
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Sekusuikuto");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode91});
            this.ChannelList = new System.Windows.Forms.ComboBox();
            this.ChannelLog = new System.Windows.Forms.TextBox();
            this.BotInformation = new System.Windows.Forms.TreeView();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.EmbedText = new System.Windows.Forms.TextBox();
            this.EmbedColorSelect = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
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
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.GuildList_SelectedIndexChanged);
            // 
            // ChannelLog
            // 
            this.ChannelLog.Location = new System.Drawing.Point(12, 82);
            this.ChannelLog.Multiline = true;
            this.ChannelLog.Name = "ChannelLog";
            this.ChannelLog.Size = new System.Drawing.Size(220, 172);
            this.ChannelLog.TabIndex = 1;
            // 
            // BotInformation
            // 
            this.BotInformation.Location = new System.Drawing.Point(238, 82);
            this.BotInformation.Name = "BotInformation";
            treeNode70.Name = "self test";
            treeNode70.Text = "selft test";
            treeNode70.ToolTipText = "Test if the bot works";
            treeNode71.Name = "self info";
            treeNode71.Text = "self info";
            treeNode71.ToolTipText = "Get info about yourself such as the ammount of guilds";
            treeNode72.Name = "self botinfo";
            treeNode72.Text = "self botinfo";
            treeNode72.ToolTipText = "Get info about the bot";
            treeNode73.Name = "self game (Game)";
            treeNode73.Text = "self game (Game)";
            treeNode73.ToolTipText = "Set your game status";
            treeNode74.Name = "self afk";
            treeNode74.Text = "self afk";
            treeNode74.ToolTipText = "Set yourself as afk";
            treeNode75.Name = "self cleanembed";
            treeNode75.Text = "self cleanembed";
            treeNode75.ToolTipText = "Clean up your your embeds";
            treeNode76.Name = "self embed (Text)";
            treeNode76.Text = "self embed (Text)";
            treeNode76.ToolTipText = "Embed a message with text";
            treeNode77.Name = "self lenny";
            treeNode77.Text = "self lenny";
            treeNode77.ToolTipText = "Insert lenny face";
            treeNode78.Name = "self lewd | self lewd (Text)";
            treeNode78.Text = "self lewd | self lewd (Text)";
            treeNode78.ToolTipText = "You know what this is :3";
            treeNode79.Name = "self form | self gui";
            treeNode79.Text = "self form | self gui";
            treeNode79.ToolTipText = "Open the main form";
            treeNode80.Name = "Commands";
            treeNode80.Text = "Commands";
            treeNode81.Name = "self tag";
            treeNode81.Text = "self tag";
            treeNode81.ToolTipText = "Get a tag you made";
            treeNode82.Name = "self addtag";
            treeNode82.Text = "self addtag";
            treeNode82.ToolTipText = "Add text to a tag which you can use later";
            treeNode83.Name = "Coming Soon";
            treeNode83.Text = "Coming Soon";
            treeNode84.Name = "PixelBot";
            treeNode84.Text = "PixelBot";
            treeNode84.ToolTipText = "A gamer featured bot with twitch streamer alerts";
            treeNode85.Name = "Minotaur";
            treeNode85.Text = "Minotaur";
            treeNode85.ToolTipText = "A guild moderation bot with modlog channel and full user/guild logs";
            treeNode86.Name = "My Bots";
            treeNode86.Text = "My Bots";
            treeNode86.ToolTipText = "Shameless promotions ik :P";
            treeNode87.Name = "Discord Cards";
            treeNode87.Text = "Discord Cards";
            treeNode87.ToolTipText = "A really cool bot made by Snazzah and other peeps which has a card collection sys" +
    "tem and daily money";
            treeNode88.Name = "Casino Bot";
            treeNode88.Text = "Casino Bot";
            treeNode88.ToolTipText = "Spin the wheel!";
            treeNode89.Name = "Discord RPG";
            treeNode89.Text = "Discord RPG";
            treeNode89.ToolTipText = "A really awesome RPG game bot";
            treeNode90.Name = "Fun Bots";
            treeNode90.Text = "Fun Bots";
            treeNode90.ToolTipText = "Bots that have a game or fun premise";
            treeNode91.Name = "Sekusuikuto";
            treeNode91.Text = "Sekusuikuto";
            treeNode91.ToolTipText = "Made by Bubbie which has some usefull random commands and modlogs";
            treeNode92.Name = "Other Bots";
            treeNode92.Text = "Other Bots";
            treeNode92.ToolTipText = "Other cool bots :)";
            this.BotInformation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode83,
            treeNode86,
            treeNode90,
            treeNode92});
            this.BotInformation.ShowNodeToolTips = true;
            this.BotInformation.Size = new System.Drawing.Size(234, 251);
            this.BotInformation.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.GuildList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmbedText);
            this.Controls.Add(this.EmbedTitle);
            this.Controls.Add(this.BotInformation);
            this.Controls.Add(this.ChannelLog);
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
        private System.Windows.Forms.TextBox ChannelLog;
        private System.Windows.Forms.TreeView BotInformation;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.TextBox EmbedText;
        private System.Windows.Forms.ColorDialog EmbedColorSelect;
        private System.Windows.Forms.Button button1;
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