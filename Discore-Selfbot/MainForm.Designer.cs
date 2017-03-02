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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("self lewd");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("self gui");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Sekusuikuto");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.ListChannel = new System.Windows.Forms.ComboBox();
            this.TextChannelLog = new System.Windows.Forms.TextBox();
            this.ViewCommands = new System.Windows.Forms.TreeView();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.EmbedText = new System.Windows.Forms.TextBox();
            this.EmbedColorSelect = new System.Windows.Forms.ColorDialog();
            this.OpenColorsButton = new System.Windows.Forms.Button();
            this.EmbedSelected = new System.Windows.Forms.Button();
            this.EmbedActive = new System.Windows.Forms.Button();
            this.ListGuild = new System.Windows.Forms.ToolStrip();
            this.TabsInfo = new System.Windows.Forms.TabControl();
            this.TabsInfoPage = new System.Windows.Forms.TabPage();
            this.TitleCommands = new System.Windows.Forms.TextBox();
            this.TextAboutBot = new System.Windows.Forms.RichTextBox();
            this.TabsBotPage = new System.Windows.Forms.TabPage();
            this.TextBotInfo = new System.Windows.Forms.RichTextBox();
            this.ButtonBotInvite = new System.Windows.Forms.Button();
            this.ButtonBotWebsite = new System.Windows.Forms.Button();
            this.ViewBots = new System.Windows.Forms.TreeView();
            this.TabsThemePage = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TabsSettingPage = new System.Windows.Forms.TabPage();
            this.BtnSetDelete = new System.Windows.Forms.Button();
            this.BtnSetEdit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TabsGuild = new System.Windows.Forms.TabControl();
            this.TabsEmbedPage = new System.Windows.Forms.TabPage();
            this.TitleSendto = new System.Windows.Forms.TextBox();
            this.TabsRolePage = new System.Windows.Forms.TabPage();
            this.TabsEmojiPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StatusActive = new System.Windows.Forms.StatusStrip();
            this.ATitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGName = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACID = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BtnSetFormYes = new System.Windows.Forms.Button();
            this.BtnSetFormNo = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ViewRoles = new System.Windows.Forms.TextBox();
            this.TabsGuildInfoPage = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TabsInfo.SuspendLayout();
            this.TabsInfoPage.SuspendLayout();
            this.TabsBotPage.SuspendLayout();
            this.TabsThemePage.SuspendLayout();
            this.TabsSettingPage.SuspendLayout();
            this.TabsGuild.SuspendLayout();
            this.TabsEmbedPage.SuspendLayout();
            this.TabsRolePage.SuspendLayout();
            this.TabsEmojiPage.SuspendLayout();
            this.StatusActive.SuspendLayout();
            this.TabsGuildInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListChannel
            // 
            this.ListChannel.FormattingEnabled = true;
            this.ListChannel.Location = new System.Drawing.Point(12, 40);
            this.ListChannel.Name = "ListChannel";
            this.ListChannel.Size = new System.Drawing.Size(220, 21);
            this.ListChannel.TabIndex = 0;
            this.ListChannel.Text = "Channels";
            this.ListChannel.Visible = false;
            this.ListChannel.SelectedIndexChanged += new System.EventHandler(this.ChannelSelected);
            // 
            // TextChannelLog
            // 
            this.TextChannelLog.Location = new System.Drawing.Point(12, 67);
            this.TextChannelLog.Multiline = true;
            this.TextChannelLog.Name = "TextChannelLog";
            this.TextChannelLog.ReadOnly = true;
            this.TextChannelLog.Size = new System.Drawing.Size(220, 187);
            this.TextChannelLog.TabIndex = 1;
            this.TextChannelLog.Text = "Channel logs comming soon ;)";
            // 
            // ViewCommands
            // 
            this.ViewCommands.Location = new System.Drawing.Point(6, 96);
            this.ViewCommands.Name = "ViewCommands";
            treeNode1.Name = "self test";
            treeNode1.Text = "self test";
            treeNode1.ToolTipText = "Test if the bot works";
            treeNode2.Name = "self info";
            treeNode2.Text = "self info";
            treeNode2.ToolTipText = "Get info about yourself such as the ammount of guilds";
            treeNode3.Name = "self botinfo";
            treeNode3.Text = "self botinfo";
            treeNode3.ToolTipText = "Get info about the bot";
            treeNode4.Name = "self cleanembed";
            treeNode4.Text = "self cleanembed";
            treeNode4.ToolTipText = "Clean up your your embeds";
            treeNode5.Name = "self embed (Text)";
            treeNode5.Text = "self embed (Text)";
            treeNode5.ToolTipText = "Embed a message with text";
            treeNode6.Name = "self lenny";
            treeNode6.Text = "self lenny";
            treeNode6.ToolTipText = "Insert lenny face";
            treeNode7.Name = "self lewd";
            treeNode7.Text = "self lewd";
            treeNode7.ToolTipText = "You know what this is :3";
            treeNode8.Name = "self lewd (Text)";
            treeNode8.Text = "self lewd (Text)";
            treeNode8.ToolTipText = "You know what this is :3";
            treeNode9.Name = "self gui";
            treeNode9.Text = "self gui";
            treeNode9.ToolTipText = "Open this form";
            this.ViewCommands.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.ViewCommands.ShowLines = false;
            this.ViewCommands.ShowNodeToolTips = true;
            this.ViewCommands.Size = new System.Drawing.Size(214, 253);
            this.ViewCommands.TabIndex = 2;
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Location = new System.Drawing.Point(6, 6);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(144, 20);
            this.EmbedTitle.TabIndex = 3;
            this.EmbedTitle.Text = "Title";
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(6, 32);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(144, 20);
            this.EmbedText.TabIndex = 4;
            this.EmbedText.Text = "Text";
            // 
            // OpenColorsButton
            // 
            this.OpenColorsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OpenColorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenColorsButton.Location = new System.Drawing.Point(156, 6);
            this.OpenColorsButton.Name = "OpenColorsButton";
            this.OpenColorsButton.Size = new System.Drawing.Size(50, 46);
            this.OpenColorsButton.TabIndex = 5;
            this.OpenColorsButton.Text = "Color";
            this.OpenColorsButton.UseVisualStyleBackColor = false;
            this.OpenColorsButton.Click += new System.EventHandler(this.OpenColorsButton_Click);
            // 
            // EmbedSelected
            // 
            this.EmbedSelected.Location = new System.Drawing.Point(6, 84);
            this.EmbedSelected.Name = "EmbedSelected";
            this.EmbedSelected.Size = new System.Drawing.Size(90, 60);
            this.EmbedSelected.TabIndex = 6;
            this.EmbedSelected.Text = "Selected";
            this.EmbedSelected.UseVisualStyleBackColor = true;
            this.EmbedSelected.Click += new System.EventHandler(this.SelectedChannelClick);
            // 
            // EmbedActive
            // 
            this.EmbedActive.Location = new System.Drawing.Point(116, 84);
            this.EmbedActive.Name = "EmbedActive";
            this.EmbedActive.Size = new System.Drawing.Size(90, 60);
            this.EmbedActive.TabIndex = 8;
            this.EmbedActive.Text = "Active";
            this.EmbedActive.UseVisualStyleBackColor = true;
            this.EmbedActive.Click += new System.EventHandler(this.EmbedActive_Click);
            // 
            // ListGuild
            // 
            this.ListGuild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListGuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ListGuild.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ListGuild.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ListGuild.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ListGuild.Location = new System.Drawing.Point(0, 0);
            this.ListGuild.Name = "ListGuild";
            this.ListGuild.Padding = new System.Windows.Forms.Padding(0);
            this.ListGuild.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ListGuild.Size = new System.Drawing.Size(484, 25);
            this.ListGuild.Stretch = true;
            this.ListGuild.TabIndex = 9;
            this.ListGuild.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GuildList_Clicked);
            // 
            // TabsInfo
            // 
            this.TabsInfo.Controls.Add(this.TabsInfoPage);
            this.TabsInfo.Controls.Add(this.TabsBotPage);
            this.TabsInfo.Controls.Add(this.TabsThemePage);
            this.TabsInfo.Controls.Add(this.TabsSettingPage);
            this.TabsInfo.Location = new System.Drawing.Point(238, 40);
            this.TabsInfo.Name = "TabsInfo";
            this.TabsInfo.SelectedIndex = 0;
            this.TabsInfo.Size = new System.Drawing.Size(234, 396);
            this.TabsInfo.TabIndex = 12;
            // 
            // TabsInfoPage
            // 
            this.TabsInfoPage.Controls.Add(this.TitleCommands);
            this.TabsInfoPage.Controls.Add(this.TextAboutBot);
            this.TabsInfoPage.Controls.Add(this.ViewCommands);
            this.TabsInfoPage.Location = new System.Drawing.Point(4, 22);
            this.TabsInfoPage.Name = "TabsInfoPage";
            this.TabsInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsInfoPage.Size = new System.Drawing.Size(226, 355);
            this.TabsInfoPage.TabIndex = 0;
            this.TabsInfoPage.Text = "Information";
            this.TabsInfoPage.UseVisualStyleBackColor = true;
            // 
            // TitleCommands
            // 
            this.TitleCommands.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleCommands.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCommands.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TitleCommands.Location = new System.Drawing.Point(6, 70);
            this.TitleCommands.Name = "TitleCommands";
            this.TitleCommands.ReadOnly = true;
            this.TitleCommands.Size = new System.Drawing.Size(214, 20);
            this.TitleCommands.TabIndex = 73;
            this.TitleCommands.TabStop = false;
            this.TitleCommands.Text = "Commands";
            this.TitleCommands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextAboutBot
            // 
            this.TextAboutBot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAboutBot.Location = new System.Drawing.Point(6, 6);
            this.TextAboutBot.Name = "TextAboutBot";
            this.TextAboutBot.ReadOnly = true;
            this.TextAboutBot.Size = new System.Drawing.Size(214, 58);
            this.TextAboutBot.TabIndex = 0;
            this.TextAboutBot.Text = "More features coming soon!\nI will also need to get an icon for this :/\n\nMy Guild:" +
    " WJTYdNb";
            // 
            // TabsBotPage
            // 
            this.TabsBotPage.Controls.Add(this.TextBotInfo);
            this.TabsBotPage.Controls.Add(this.ButtonBotInvite);
            this.TabsBotPage.Controls.Add(this.ButtonBotWebsite);
            this.TabsBotPage.Controls.Add(this.ViewBots);
            this.TabsBotPage.Location = new System.Drawing.Point(4, 22);
            this.TabsBotPage.Name = "TabsBotPage";
            this.TabsBotPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsBotPage.Size = new System.Drawing.Size(226, 370);
            this.TabsBotPage.TabIndex = 1;
            this.TabsBotPage.Text = "Bots";
            this.TabsBotPage.UseVisualStyleBackColor = true;
            // 
            // TextBotInfo
            // 
            this.TextBotInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBotInfo.Location = new System.Drawing.Point(6, 260);
            this.TextBotInfo.Name = "TextBotInfo";
            this.TextBotInfo.ReadOnly = true;
            this.TextBotInfo.Size = new System.Drawing.Size(214, 58);
            this.TextBotInfo.TabIndex = 6;
            this.TextBotInfo.Text = "Click an item above to get information about the bot";
            // 
            // ButtonBotInvite
            // 
            this.ButtonBotInvite.Location = new System.Drawing.Point(120, 324);
            this.ButtonBotInvite.Name = "ButtonBotInvite";
            this.ButtonBotInvite.Size = new System.Drawing.Size(100, 40);
            this.ButtonBotInvite.TabIndex = 5;
            this.ButtonBotInvite.Text = "Invite Link";
            this.ButtonBotInvite.UseVisualStyleBackColor = true;
            this.ButtonBotInvite.Visible = false;
            this.ButtonBotInvite.Click += new System.EventHandler(this.ButtonBotInvite_Click);
            // 
            // ButtonBotWebsite
            // 
            this.ButtonBotWebsite.Location = new System.Drawing.Point(6, 324);
            this.ButtonBotWebsite.Name = "ButtonBotWebsite";
            this.ButtonBotWebsite.Size = new System.Drawing.Size(100, 40);
            this.ButtonBotWebsite.TabIndex = 4;
            this.ButtonBotWebsite.Text = "Website";
            this.ButtonBotWebsite.UseVisualStyleBackColor = true;
            this.ButtonBotWebsite.Visible = false;
            this.ButtonBotWebsite.Click += new System.EventHandler(this.ButtonBotWebsite_Click);
            // 
            // ViewBots
            // 
            this.ViewBots.Location = new System.Drawing.Point(6, 5);
            this.ViewBots.Name = "ViewBots";
            treeNode10.Name = "PixelBot";
            treeNode10.Text = "PixelBot";
            treeNode10.ToolTipText = "A gamer featured bot with twitch streamer alerts";
            treeNode11.Name = "Minotaur";
            treeNode11.Text = "Minotaur";
            treeNode11.ToolTipText = "A guild moderation bot with modlog channel and full user/guild logs";
            treeNode12.Name = "My Bots";
            treeNode12.Text = "My Bots";
            treeNode12.ToolTipText = "Shameless promotions ik :P";
            treeNode13.Name = "Discord Cards";
            treeNode13.Text = "Discord Cards";
            treeNode13.ToolTipText = "A really cool bot made by Snazzah and other peeps which has a card collection sys" +
    "tem and daily money";
            treeNode14.Name = "Casino Bot";
            treeNode14.Text = "Casino Bot";
            treeNode14.ToolTipText = "Spin the wheel!";
            treeNode15.Name = "Discord RPG";
            treeNode15.Text = "Discord RPG";
            treeNode15.ToolTipText = "A really awesome RPG game bot";
            treeNode16.Name = "Fun Bots";
            treeNode16.Text = "Fun Bots";
            treeNode16.ToolTipText = "Bots that have a game or fun premise";
            treeNode17.Name = "Sekusuikuto";
            treeNode17.Text = "Sekusuikuto";
            treeNode17.ToolTipText = "Made by Bubbie which has some usefull random commands and modlogs";
            treeNode18.Name = "Other Bots";
            treeNode18.Text = "Other Bots";
            treeNode18.ToolTipText = "Other cool bots :)";
            this.ViewBots.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode16,
            treeNode18});
            this.ViewBots.ShowNodeToolTips = true;
            this.ViewBots.Size = new System.Drawing.Size(214, 249);
            this.ViewBots.TabIndex = 3;
            this.ViewBots.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewBots_AfterSelect);
            // 
            // TabsThemePage
            // 
            this.TabsThemePage.Controls.Add(this.textBox2);
            this.TabsThemePage.Location = new System.Drawing.Point(4, 22);
            this.TabsThemePage.Name = "TabsThemePage";
            this.TabsThemePage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsThemePage.Size = new System.Drawing.Size(226, 355);
            this.TabsThemePage.TabIndex = 2;
            this.TabsThemePage.Text = "Themes";
            this.TabsThemePage.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 74;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Coming Soon";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabsSettingPage
            // 
            this.TabsSettingPage.Controls.Add(this.textBox6);
            this.TabsSettingPage.Controls.Add(this.BtnSetFormNo);
            this.TabsSettingPage.Controls.Add(this.BtnSetFormYes);
            this.TabsSettingPage.Controls.Add(this.textBox5);
            this.TabsSettingPage.Controls.Add(this.textBox4);
            this.TabsSettingPage.Controls.Add(this.BtnSetDelete);
            this.TabsSettingPage.Controls.Add(this.BtnSetEdit);
            this.TabsSettingPage.Controls.Add(this.textBox3);
            this.TabsSettingPage.Location = new System.Drawing.Point(4, 22);
            this.TabsSettingPage.Name = "TabsSettingPage";
            this.TabsSettingPage.Size = new System.Drawing.Size(226, 355);
            this.TabsSettingPage.TabIndex = 3;
            this.TabsSettingPage.Text = "Settings";
            this.TabsSettingPage.UseVisualStyleBackColor = true;
            // 
            // BtnSetDelete
            // 
            this.BtnSetDelete.Location = new System.Drawing.Point(69, 31);
            this.BtnSetDelete.Name = "BtnSetDelete";
            this.BtnSetDelete.Size = new System.Drawing.Size(60, 40);
            this.BtnSetDelete.TabIndex = 77;
            this.BtnSetDelete.Text = "Delete";
            this.BtnSetDelete.UseVisualStyleBackColor = true;
            this.BtnSetDelete.Click += new System.EventHandler(this.BtnSetDelete_Click);
            // 
            // BtnSetEdit
            // 
            this.BtnSetEdit.Location = new System.Drawing.Point(3, 31);
            this.BtnSetEdit.Name = "BtnSetEdit";
            this.BtnSetEdit.Size = new System.Drawing.Size(60, 40);
            this.BtnSetEdit.TabIndex = 76;
            this.BtnSetEdit.Text = "Edit";
            this.BtnSetEdit.UseVisualStyleBackColor = true;
            this.BtnSetEdit.Click += new System.EventHandler(this.BtnSetEdit_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(3, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 75;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Command Message";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabsGuild
            // 
            this.TabsGuild.Controls.Add(this.TabsEmbedPage);
            this.TabsGuild.Controls.Add(this.TabsRolePage);
            this.TabsGuild.Controls.Add(this.TabsEmojiPage);
            this.TabsGuild.Controls.Add(this.TabsGuildInfoPage);
            this.TabsGuild.Location = new System.Drawing.Point(12, 260);
            this.TabsGuild.Name = "TabsGuild";
            this.TabsGuild.SelectedIndex = 0;
            this.TabsGuild.Size = new System.Drawing.Size(220, 176);
            this.TabsGuild.TabIndex = 13;
            // 
            // TabsEmbedPage
            // 
            this.TabsEmbedPage.Controls.Add(this.TitleSendto);
            this.TabsEmbedPage.Controls.Add(this.EmbedTitle);
            this.TabsEmbedPage.Controls.Add(this.EmbedText);
            this.TabsEmbedPage.Controls.Add(this.OpenColorsButton);
            this.TabsEmbedPage.Controls.Add(this.EmbedSelected);
            this.TabsEmbedPage.Controls.Add(this.EmbedActive);
            this.TabsEmbedPage.Location = new System.Drawing.Point(4, 22);
            this.TabsEmbedPage.Name = "TabsEmbedPage";
            this.TabsEmbedPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsEmbedPage.Size = new System.Drawing.Size(212, 150);
            this.TabsEmbedPage.TabIndex = 0;
            this.TabsEmbedPage.Text = "Embed";
            this.TabsEmbedPage.UseVisualStyleBackColor = true;
            // 
            // TitleSendto
            // 
            this.TitleSendto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleSendto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleSendto.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleSendto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSendto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TitleSendto.Location = new System.Drawing.Point(6, 58);
            this.TitleSendto.Name = "TitleSendto";
            this.TitleSendto.ReadOnly = true;
            this.TitleSendto.Size = new System.Drawing.Size(200, 20);
            this.TitleSendto.TabIndex = 74;
            this.TitleSendto.TabStop = false;
            this.TitleSendto.Text = "Send To";
            this.TitleSendto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabsRolePage
            // 
            this.TabsRolePage.Controls.Add(this.ViewRoles);
            this.TabsRolePage.Location = new System.Drawing.Point(4, 22);
            this.TabsRolePage.Name = "TabsRolePage";
            this.TabsRolePage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsRolePage.Size = new System.Drawing.Size(212, 150);
            this.TabsRolePage.TabIndex = 1;
            this.TabsRolePage.Text = "Roles";
            this.TabsRolePage.UseVisualStyleBackColor = true;
            // 
            // TabsEmojiPage
            // 
            this.TabsEmojiPage.Controls.Add(this.textBox1);
            this.TabsEmojiPage.Location = new System.Drawing.Point(4, 22);
            this.TabsEmojiPage.Name = "TabsEmojiPage";
            this.TabsEmojiPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsEmojiPage.Size = new System.Drawing.Size(212, 150);
            this.TabsEmojiPage.TabIndex = 2;
            this.TabsEmojiPage.Text = "Emoji";
            this.TabsEmojiPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 75;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Coming Soon";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusActive
            // 
            this.StatusActive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATitle,
            this.AGTitle,
            this.AGName,
            this.AGID,
            this.ACTitle,
            this.ACName,
            this.ACID});
            this.StatusActive.Location = new System.Drawing.Point(0, 439);
            this.StatusActive.Name = "StatusActive";
            this.StatusActive.Size = new System.Drawing.Size(484, 22);
            this.StatusActive.TabIndex = 14;
            this.StatusActive.Text = "Active";
            // 
            // ATitle
            // 
            this.ATitle.ForeColor = System.Drawing.Color.Green;
            this.ATitle.Name = "ATitle";
            this.ATitle.Size = new System.Drawing.Size(40, 17);
            this.ATitle.Text = "Active";
            // 
            // AGTitle
            // 
            this.AGTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AGTitle.Name = "AGTitle";
            this.AGTitle.Size = new System.Drawing.Size(39, 17);
            this.AGTitle.Text = "Guild:";
            // 
            // AGName
            // 
            this.AGName.Name = "AGName";
            this.AGName.Size = new System.Drawing.Size(35, 17);
            this.AGName.Text = "Guild";
            // 
            // AGID
            // 
            this.AGID.Name = "AGID";
            this.AGID.Size = new System.Drawing.Size(33, 17);
            this.AGID.Text = "(420)";
            // 
            // ACTitle
            // 
            this.ACTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ACTitle.Name = "ACTitle";
            this.ACTitle.Size = new System.Drawing.Size(54, 17);
            this.ACTitle.Text = "Channel:";
            // 
            // ACName
            // 
            this.ACName.Name = "ACName";
            this.ACName.Size = new System.Drawing.Size(51, 17);
            this.ACName.Text = "Channel";
            // 
            // ACID
            // 
            this.ACID.Name = "ACID";
            this.ACID.Size = new System.Drawing.Size(27, 17);
            this.ACID.Text = "(69)";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(3, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(214, 20);
            this.textBox5.TabIndex = 79;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Open Form On Startup";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSetFormYes
            // 
            this.BtnSetFormYes.Location = new System.Drawing.Point(3, 103);
            this.BtnSetFormYes.Name = "BtnSetFormYes";
            this.BtnSetFormYes.Size = new System.Drawing.Size(60, 40);
            this.BtnSetFormYes.TabIndex = 80;
            this.BtnSetFormYes.Text = "Yes";
            this.BtnSetFormYes.UseVisualStyleBackColor = true;
            this.BtnSetFormYes.Click += new System.EventHandler(this.BtnSetFormYes_Click);
            // 
            // BtnSetFormNo
            // 
            this.BtnSetFormNo.Location = new System.Drawing.Point(69, 103);
            this.BtnSetFormNo.Name = "BtnSetFormNo";
            this.BtnSetFormNo.Size = new System.Drawing.Size(60, 40);
            this.BtnSetFormNo.TabIndex = 81;
            this.BtnSetFormNo.Text = "No";
            this.BtnSetFormNo.UseVisualStyleBackColor = true;
            this.BtnSetFormNo.Click += new System.EventHandler(this.BtnSetFormNo_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "AutoForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Location = new System.Drawing.Point(135, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 82;
            this.textBox6.TabStop = false;
            this.textBox6.Text = global::Discore_Selfbot.Properties.Settings.Default.AutoForm;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "SendAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(135, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 78;
            this.textBox4.TabStop = false;
            this.textBox4.Text = global::Discore_Selfbot.Properties.Settings.Default.SendAction;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewRoles
            // 
            this.ViewRoles.Location = new System.Drawing.Point(6, 6);
            this.ViewRoles.Multiline = true;
            this.ViewRoles.Name = "ViewRoles";
            this.ViewRoles.ReadOnly = true;
            this.ViewRoles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ViewRoles.Size = new System.Drawing.Size(200, 138);
            this.ViewRoles.TabIndex = 15;
            // 
            // TabsGuildInfoPage
            // 
            this.TabsGuildInfoPage.Controls.Add(this.textBox7);
            this.TabsGuildInfoPage.Location = new System.Drawing.Point(4, 22);
            this.TabsGuildInfoPage.Name = "TabsGuildInfoPage";
            this.TabsGuildInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabsGuildInfoPage.Size = new System.Drawing.Size(212, 150);
            this.TabsGuildInfoPage.TabIndex = 3;
            this.TabsGuildInfoPage.Text = "Guild Info";
            this.TabsGuildInfoPage.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.Location = new System.Drawing.Point(6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 76;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Coming Soon";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.StatusActive);
            this.Controls.Add(this.TabsGuild);
            this.Controls.Add(this.TabsInfo);
            this.Controls.Add(this.ListGuild);
            this.Controls.Add(this.TextChannelLog);
            this.Controls.Add(this.ListChannel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabsInfo.ResumeLayout(false);
            this.TabsInfoPage.ResumeLayout(false);
            this.TabsInfoPage.PerformLayout();
            this.TabsBotPage.ResumeLayout(false);
            this.TabsThemePage.ResumeLayout(false);
            this.TabsThemePage.PerformLayout();
            this.TabsSettingPage.ResumeLayout(false);
            this.TabsSettingPage.PerformLayout();
            this.TabsGuild.ResumeLayout(false);
            this.TabsEmbedPage.ResumeLayout(false);
            this.TabsEmbedPage.PerformLayout();
            this.TabsRolePage.ResumeLayout(false);
            this.TabsRolePage.PerformLayout();
            this.TabsEmojiPage.ResumeLayout(false);
            this.TabsEmojiPage.PerformLayout();
            this.StatusActive.ResumeLayout(false);
            this.StatusActive.PerformLayout();
            this.TabsGuildInfoPage.ResumeLayout(false);
            this.TabsGuildInfoPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ListChannel;
        private System.Windows.Forms.TextBox TextChannelLog;
        private System.Windows.Forms.TreeView ViewCommands;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.TextBox EmbedText;
        private System.Windows.Forms.ColorDialog EmbedColorSelect;
        private System.Windows.Forms.Button OpenColorsButton;
        private System.Windows.Forms.Button EmbedSelected;
        private System.Windows.Forms.Button EmbedActive;
        public System.Windows.Forms.ToolStrip ListGuild;
        private System.Windows.Forms.TabControl TabsInfo;
        private System.Windows.Forms.TabPage TabsInfoPage;
        internal System.Windows.Forms.TextBox TitleCommands;
        private System.Windows.Forms.RichTextBox TextAboutBot;
        private System.Windows.Forms.TabPage TabsBotPage;
        private System.Windows.Forms.TreeView ViewBots;
        private System.Windows.Forms.TabControl TabsGuild;
        private System.Windows.Forms.TabPage TabsEmbedPage;
        private System.Windows.Forms.TabPage TabsRolePage;
        internal System.Windows.Forms.TextBox TitleSendto;
        private System.Windows.Forms.RichTextBox TextBotInfo;
        private System.Windows.Forms.Button ButtonBotInvite;
        private System.Windows.Forms.Button ButtonBotWebsite;
        private System.Windows.Forms.TabPage TabsEmojiPage;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TabsThemePage;
        private System.Windows.Forms.StatusStrip StatusActive;
        private System.Windows.Forms.ToolStripStatusLabel AGTitle;
        private System.Windows.Forms.ToolStripStatusLabel ACTitle;
        public System.Windows.Forms.ToolStripStatusLabel AGName;
        public System.Windows.Forms.ToolStripStatusLabel AGID;
        public System.Windows.Forms.ToolStripStatusLabel ACName;
        public System.Windows.Forms.ToolStripStatusLabel ACID;
        private System.Windows.Forms.TabPage TabsSettingPage;
        private System.Windows.Forms.ToolStripStatusLabel ATitle;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BtnSetDelete;
        private System.Windows.Forms.Button BtnSetEdit;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button BtnSetFormNo;
        private System.Windows.Forms.Button BtnSetFormYes;
        private System.Windows.Forms.TextBox ViewRoles;
        private System.Windows.Forms.TabPage TabsGuildInfoPage;
        internal System.Windows.Forms.TextBox textBox7;
    }
}