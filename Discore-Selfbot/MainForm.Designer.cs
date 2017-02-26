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
            this.GuildList = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.EmbedText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AGTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGName = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACID = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuildList
            // 
            this.GuildList.FormattingEnabled = true;
            this.GuildList.Location = new System.Drawing.Point(12, 12);
            this.GuildList.Name = "GuildList";
            this.GuildList.Size = new System.Drawing.Size(220, 21);
            this.GuildList.TabIndex = 0;
            this.GuildList.SelectedIndexChanged += new System.EventHandler(this.GuildList_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 172);
            this.textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(238, 12);
            this.treeView1.Name = "treeView1";
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
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode60,
            treeNode63,
            treeNode67,
            treeNode69});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(234, 251);
            this.treeView1.TabIndex = 2;
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Location = new System.Drawing.Point(12, 217);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(164, 20);
            this.EmbedTitle.TabIndex = 3;
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(12, 243);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(164, 20);
            this.EmbedText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Send to selected channel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AGTitle,
            this.AGName,
            this.AGID,
            this.ACTitle,
            this.ACName,
            this.ACID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Send to active channel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmbedText);
            this.Controls.Add(this.EmbedTitle);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GuildList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox GuildList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.TextBox EmbedText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AGTitle;
        public System.Windows.Forms.ToolStripStatusLabel AGName;
        public System.Windows.Forms.ToolStripStatusLabel AGID;
        private System.Windows.Forms.ToolStripStatusLabel ACTitle;
        public System.Windows.Forms.ToolStripStatusLabel ACName;
        public System.Windows.Forms.ToolStripStatusLabel ACID;
        private System.Windows.Forms.Button button3;
    }
}