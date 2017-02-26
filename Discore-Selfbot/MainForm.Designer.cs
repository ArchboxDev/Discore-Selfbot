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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("selft test");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("self botinfo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("self game (Game)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("self afk");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("self cleanme");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Commands", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("self tag");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("self addtag");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Coming Soon", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Sekusuikuto");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.GuildList = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            treeNode1.Name = "self test";
            treeNode1.Text = "selft test";
            treeNode1.ToolTipText = "Test if the bot works";
            treeNode2.Name = "self info";
            treeNode2.Text = "self info";
            treeNode2.ToolTipText = "Get info about yourself such as the ammount of guilds";
            treeNode3.Name = "self botinfo";
            treeNode3.Text = "self botinfo";
            treeNode3.ToolTipText = "Get info about the bot";
            treeNode4.Name = "self game (Game)";
            treeNode4.Text = "self game (Game)";
            treeNode4.ToolTipText = "Set your game status";
            treeNode5.Name = "self afk";
            treeNode5.Text = "self afk";
            treeNode5.ToolTipText = "Set yourself as afk";
            treeNode6.Name = "self cleanme";
            treeNode6.Text = "self cleanme";
            treeNode6.ToolTipText = "Clean up your messages";
            treeNode7.Name = "self embed (Text)";
            treeNode7.Text = "self embed (Text)";
            treeNode7.ToolTipText = "Embed a message with text";
            treeNode8.Name = "self lenny";
            treeNode8.Text = "self lenny";
            treeNode8.ToolTipText = "Insert lenny face";
            treeNode9.Name = "Commands";
            treeNode9.Text = "Commands";
            treeNode10.Name = "self tag";
            treeNode10.Text = "self tag";
            treeNode10.ToolTipText = "Get a tag you made";
            treeNode11.Name = "self addtag";
            treeNode11.Text = "self addtag";
            treeNode11.ToolTipText = "Add text to a tag which you can use later";
            treeNode12.Name = "Coming Soon";
            treeNode12.Text = "Coming Soon";
            treeNode13.Name = "PixelBot";
            treeNode13.Text = "PixelBot";
            treeNode13.ToolTipText = "A gamer featured bot with twitch streamer alerts";
            treeNode14.Name = "Minotaur";
            treeNode14.Text = "Minotaur";
            treeNode14.ToolTipText = "A guild moderation bot with modlog channel and full user/guild logs";
            treeNode15.Name = "My Bots";
            treeNode15.Text = "My Bots";
            treeNode15.ToolTipText = "Shameless promotions ik :P";
            treeNode16.Name = "Discord Cards";
            treeNode16.Text = "Discord Cards";
            treeNode16.ToolTipText = "A really cool bot made by Snazzah and other peeps which has a card collection sys" +
    "tem and daily money";
            treeNode17.Name = "Casino Bot";
            treeNode17.Text = "Casino Bot";
            treeNode17.ToolTipText = "Spin the wheel!";
            treeNode18.Name = "Discord RPG";
            treeNode18.Text = "Discord RPG";
            treeNode18.ToolTipText = "A really awesome RPG game bot";
            treeNode19.Name = "Fun Bots";
            treeNode19.Text = "Fun Bots";
            treeNode19.ToolTipText = "Bots that have a game or fun premise";
            treeNode20.Name = "Sekusuikuto";
            treeNode20.Text = "Sekusuikuto";
            treeNode20.ToolTipText = "Made by Bubbie which has some usefull random commands and modlogs";
            treeNode21.Name = "Other Bots";
            treeNode21.Text = "Other Bots";
            treeNode21.ToolTipText = "Other cool bots :)";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode15,
            treeNode19,
            treeNode21});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(234, 199);
            this.treeView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GuildList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox GuildList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}