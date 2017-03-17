namespace Discore_Selfbot
{
    partial class GUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("self test");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("self ping");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("self ping (IP)");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("self uptime");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("self form");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("self bot");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("self user (User ID)");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("self user @Mention");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("self find (User ID)");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Text)");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Message ID)");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("self tag (Tag)");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("self tags");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("self deltag (Tag)");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("self an bind");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("self an add (Nickname)");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("self an del (Nickname)");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("self an list");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Sekobot");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            this.StatusActive = new System.Windows.Forms.StatusStrip();
            this.ATitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGName = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ChannelLogging = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.OpenFavoriteColor = new System.Windows.Forms.ColorDialog();
            this.OpenEmbedColor = new System.Windows.Forms.ColorDialog();
            this.ChannelList = new System.Windows.Forms.ComboBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavGuild = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavEmbedPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BtnSendActive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnSendSelected = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedFooter = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnEmbedColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.NavGuildInfoPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildInfo = new System.Windows.Forms.RichTextBox();
            this.NavRolesPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildRoles = new System.Windows.Forms.RichTextBox();
            this.NavPageEmoji = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildEmojis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.NavInfo = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavInfoInfo = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.NavMoreInfo = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavCommandsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.ViewCommandsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.NavChangelogPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextChangelog = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkGuild = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkGithub = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.NavInfoThemes = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NavInfoBots = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextBotInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkBotInvite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkBotWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.ViewBotsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.NavInfoSettings = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BtnAN5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN10 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnFavColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAFNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAFYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCMDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCMEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.Towergame_Communism = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.GuildList = new System.Windows.Forms.ToolStrip();
            this.TextAutoNickname = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextAutoForm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextCommandMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TitleCommandMessage = new System.Windows.Forms.TextBox();
            this.TitleStartupForm = new System.Windows.Forms.TextBox();
            this.TitleFavoriteColor = new System.Windows.Forms.TextBox();
            this.TitleAutoNicknameTimer = new System.Windows.Forms.TextBox();
            this.TextEmbedColor = new System.Windows.Forms.TextBox();
            this.TextFavColor = new System.Windows.Forms.TextBox();
            this.StatusActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuild)).BeginInit();
            this.NavGuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavEmbedPage)).BeginInit();
            this.NavEmbedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuildInfoPage)).BeginInit();
            this.NavGuildInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavRolesPage)).BeginInit();
            this.NavRolesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavPageEmoji)).BeginInit();
            this.NavPageEmoji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfo)).BeginInit();
            this.NavInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoInfo)).BeginInit();
            this.NavInfoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavMoreInfo)).BeginInit();
            this.NavMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCommandsPage)).BeginInit();
            this.NavCommandsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavChangelogPage)).BeginInit();
            this.NavChangelogPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoThemes)).BeginInit();
            this.NavInfoThemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoBots)).BeginInit();
            this.NavInfoBots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoSettings)).BeginInit();
            this.NavInfoSettings.SuspendLayout();
            this.SuspendLayout();
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
            this.StatusActive.TabIndex = 18;
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
            this.AGTitle.Size = new System.Drawing.Size(19, 17);
            this.AGTitle.Text = "G:";
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
            this.ACTitle.Size = new System.Drawing.Size(17, 17);
            this.ACTitle.Text = "C:";
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
            // ChannelLogging
            // 
            this.ChannelLogging.Location = new System.Drawing.Point(12, 73);
            this.ChannelLogging.Multiline = true;
            this.ChannelLogging.Name = "ChannelLogging";
            this.ChannelLogging.ReadOnly = true;
            this.ChannelLogging.Size = new System.Drawing.Size(220, 180);
            this.ChannelLogging.TabIndex = 20;
            this.ChannelLogging.Text = "Channel logs comming soon ;)";
            // 
            // ChannelList
            // 
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.Location = new System.Drawing.Point(12, 46);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(220, 21);
            this.ChannelList.TabIndex = 22;
            this.ChannelList.Visible = false;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(484, 461);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // NavGuild
            // 
            this.NavGuild.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavGuild.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavGuild.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavGuild.Location = new System.Drawing.Point(12, 259);
            this.NavGuild.Name = "NavGuild";
            this.NavGuild.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavEmbedPage,
            this.NavGuildInfoPage,
            this.NavRolesPage,
            this.NavPageEmoji});
            this.NavGuild.SelectedIndex = 0;
            this.NavGuild.Size = new System.Drawing.Size(220, 176);
            this.NavGuild.TabIndex = 21;
            this.NavGuild.Text = "kryptonNavigator1";
            // 
            // NavEmbedPage
            // 
            this.NavEmbedPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavEmbedPage.Controls.Add(this.TextEmbedColor);
            this.NavEmbedPage.Controls.Add(this.BtnSendActive);
            this.NavEmbedPage.Controls.Add(this.BtnSendSelected);
            this.NavEmbedPage.Controls.Add(this.EmbedFooter);
            this.NavEmbedPage.Controls.Add(this.EmbedText);
            this.NavEmbedPage.Controls.Add(this.BtnEmbedColor);
            this.NavEmbedPage.Controls.Add(this.EmbedTitle);
            this.NavEmbedPage.Flags = 65534;
            this.NavEmbedPage.LastVisibleSet = true;
            this.NavEmbedPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavEmbedPage.Name = "NavEmbedPage";
            this.NavEmbedPage.Size = new System.Drawing.Size(218, 149);
            this.NavEmbedPage.Text = "Embed";
            this.NavEmbedPage.ToolTipTitle = "Page ToolTip";
            this.NavEmbedPage.UniqueName = "D0784325A0CE45D21CA18507410A4550";
            // 
            // BtnSendActive
            // 
            this.BtnSendActive.Location = new System.Drawing.Point(118, 90);
            this.BtnSendActive.Name = "BtnSendActive";
            this.BtnSendActive.Size = new System.Drawing.Size(97, 56);
            this.BtnSendActive.TabIndex = 6;
            this.BtnSendActive.Values.Text = "Active";
            this.BtnSendActive.Click += new System.EventHandler(this.BtnSendActive_Click);
            // 
            // BtnSendSelected
            // 
            this.BtnSendSelected.Location = new System.Drawing.Point(3, 90);
            this.BtnSendSelected.Name = "BtnSendSelected";
            this.BtnSendSelected.Size = new System.Drawing.Size(97, 56);
            this.BtnSendSelected.TabIndex = 5;
            this.BtnSendSelected.Values.Text = "Selected";
            this.BtnSendSelected.Click += new System.EventHandler(this.BtnSendSelected_Click);
            // 
            // EmbedFooter
            // 
            this.EmbedFooter.Location = new System.Drawing.Point(3, 61);
            this.EmbedFooter.Name = "EmbedFooter";
            this.EmbedFooter.Size = new System.Drawing.Size(156, 23);
            this.EmbedFooter.TabIndex = 4;
            this.EmbedFooter.Text = "Footer";
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(3, 32);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(156, 23);
            this.EmbedText.TabIndex = 3;
            this.EmbedText.Text = "Text";
            // 
            // BtnEmbedColor
            // 
            this.BtnEmbedColor.Location = new System.Drawing.Point(165, 32);
            this.BtnEmbedColor.Name = "BtnEmbedColor";
            this.BtnEmbedColor.Size = new System.Drawing.Size(50, 52);
            this.BtnEmbedColor.TabIndex = 1;
            this.BtnEmbedColor.Values.Text = "Color";
            this.BtnEmbedColor.Click += new System.EventHandler(this.BtnEmbedColor_Click);
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Location = new System.Drawing.Point(3, 3);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(156, 23);
            this.EmbedTitle.TabIndex = 0;
            this.EmbedTitle.Text = "Title";
            // 
            // NavGuildInfoPage
            // 
            this.NavGuildInfoPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavGuildInfoPage.Controls.Add(this.TextGuildInfo);
            this.NavGuildInfoPage.Flags = 65534;
            this.NavGuildInfoPage.LastVisibleSet = true;
            this.NavGuildInfoPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavGuildInfoPage.Name = "NavGuildInfoPage";
            this.NavGuildInfoPage.Size = new System.Drawing.Size(218, 150);
            this.NavGuildInfoPage.Text = "G Info";
            this.NavGuildInfoPage.ToolTipTitle = "Page ToolTip";
            this.NavGuildInfoPage.UniqueName = "15405AE8C3F64B0DFA9BB3419545B5E6";
            // 
            // TextGuildInfo
            // 
            this.TextGuildInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildInfo.Location = new System.Drawing.Point(0, 0);
            this.TextGuildInfo.Name = "TextGuildInfo";
            this.TextGuildInfo.Size = new System.Drawing.Size(218, 150);
            this.TextGuildInfo.TabIndex = 0;
            this.TextGuildInfo.Text = "";
            // 
            // NavRolesPage
            // 
            this.NavRolesPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavRolesPage.Controls.Add(this.TextGuildRoles);
            this.NavRolesPage.Flags = 65534;
            this.NavRolesPage.LastVisibleSet = true;
            this.NavRolesPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavRolesPage.Name = "NavRolesPage";
            this.NavRolesPage.Size = new System.Drawing.Size(218, 150);
            this.NavRolesPage.Text = "Roles";
            this.NavRolesPage.ToolTipTitle = "Page ToolTip";
            this.NavRolesPage.UniqueName = "21AAC88369604DAAF087F3A82510D49D";
            // 
            // TextGuildRoles
            // 
            this.TextGuildRoles.BackColor = System.Drawing.Color.Black;
            this.TextGuildRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildRoles.ForeColor = System.Drawing.Color.White;
            this.TextGuildRoles.Location = new System.Drawing.Point(0, 0);
            this.TextGuildRoles.Name = "TextGuildRoles";
            this.TextGuildRoles.Size = new System.Drawing.Size(218, 150);
            this.TextGuildRoles.TabIndex = 1;
            this.TextGuildRoles.Text = "";
            // 
            // NavPageEmoji
            // 
            this.NavPageEmoji.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavPageEmoji.Controls.Add(this.TextGuildEmojis);
            this.NavPageEmoji.Flags = 65534;
            this.NavPageEmoji.LastVisibleSet = true;
            this.NavPageEmoji.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavPageEmoji.Name = "NavPageEmoji";
            this.NavPageEmoji.Size = new System.Drawing.Size(218, 150);
            this.NavPageEmoji.Text = "Emoji";
            this.NavPageEmoji.ToolTipTitle = "Page ToolTip";
            this.NavPageEmoji.UniqueName = "14F93E3889E740C4CA8379603DCB6820";
            // 
            // TextGuildEmojis
            // 
            this.TextGuildEmojis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildEmojis.Location = new System.Drawing.Point(0, 0);
            this.TextGuildEmojis.Multiline = true;
            this.TextGuildEmojis.Name = "TextGuildEmojis";
            this.TextGuildEmojis.ReadOnly = true;
            this.TextGuildEmojis.Size = new System.Drawing.Size(218, 150);
            this.TextGuildEmojis.TabIndex = 0;
            // 
            // NavInfo
            // 
            this.NavInfo.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavInfo.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavInfo.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavInfo.Location = new System.Drawing.Point(238, 40);
            this.NavInfo.Name = "NavInfo";
            this.NavInfo.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavInfoInfo,
            this.NavInfoThemes,
            this.NavInfoBots,
            this.NavInfoSettings});
            this.NavInfo.SelectedIndex = 3;
            this.NavInfo.Size = new System.Drawing.Size(234, 396);
            this.NavInfo.TabIndex = 16;
            this.NavInfo.Text = "kryptonNavigator1";
            // 
            // NavInfoInfo
            // 
            this.NavInfoInfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoInfo.Controls.Add(this.NavMoreInfo);
            this.NavInfoInfo.Controls.Add(this.HyperlinkGuild);
            this.NavInfoInfo.Controls.Add(this.HyperlinkWebsite);
            this.NavInfoInfo.Controls.Add(this.HyperlinkGithub);
            this.NavInfoInfo.Flags = 65534;
            this.NavInfoInfo.LastVisibleSet = true;
            this.NavInfoInfo.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoInfo.Name = "NavInfoInfo";
            this.NavInfoInfo.Size = new System.Drawing.Size(232, 369);
            this.NavInfoInfo.Text = "Info";
            this.NavInfoInfo.ToolTipTitle = "Page ToolTip";
            this.NavInfoInfo.UniqueName = "478032B78A96411C7996B476B5C7B4F2";
            // 
            // NavMoreInfo
            // 
            this.NavMoreInfo.Bar.ItemAlignment = ComponentFactory.Krypton.Toolkit.RelativePositionAlign.Center;
            this.NavMoreInfo.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavMoreInfo.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavMoreInfo.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavMoreInfo.Location = new System.Drawing.Point(3, 29);
            this.NavMoreInfo.Name = "NavMoreInfo";
            this.NavMoreInfo.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.NavMoreInfo.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavCommandsPage,
            this.NavChangelogPage});
            this.NavMoreInfo.SelectedIndex = 1;
            this.NavMoreInfo.Size = new System.Drawing.Size(226, 339);
            this.NavMoreInfo.TabIndex = 7;
            this.NavMoreInfo.Text = "kryptonNavigator1";
            // 
            // NavCommandsPage
            // 
            this.NavCommandsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavCommandsPage.Controls.Add(this.ViewCommandsList);
            this.NavCommandsPage.Flags = 65534;
            this.NavCommandsPage.LastVisibleSet = true;
            this.NavCommandsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavCommandsPage.Name = "NavCommandsPage";
            this.NavCommandsPage.Size = new System.Drawing.Size(224, 310);
            this.NavCommandsPage.Text = "Commands";
            this.NavCommandsPage.ToolTipTitle = "Page ToolTip";
            this.NavCommandsPage.UniqueName = "E1FF2C7914C34B417AA8BFF17BFB6E40";
            // 
            // ViewCommandsList
            // 
            this.ViewCommandsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewCommandsList.HotTracking = true;
            this.ViewCommandsList.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.ViewCommandsList.Location = new System.Drawing.Point(0, 0);
            this.ViewCommandsList.Name = "ViewCommandsList";
            treeNode33.Name = "self test";
            treeNode33.Text = "self test";
            treeNode33.ToolTipText = "Test if selfbot is working";
            treeNode34.Name = "self ping";
            treeNode34.Text = "self ping";
            treeNode34.ToolTipText = "Ping the network and discord";
            treeNode35.Name = "self ping (IP)";
            treeNode35.Text = "self ping (IP)";
            treeNode35.ToolTipText = "Ping another IP address";
            treeNode36.Name = "self uptime";
            treeNode36.Text = "self uptime";
            treeNode36.ToolTipText = "Get the uptime of the bot";
            treeNode37.Name = "self info";
            treeNode37.Text = "self info";
            treeNode37.ToolTipText = "Get info about yourself";
            treeNode38.Name = "self cleanembed";
            treeNode38.Text = "self cleanembed";
            treeNode38.ToolTipText = "Cleanup all your embeds";
            treeNode39.Name = "self form";
            treeNode39.Text = "self form";
            treeNode39.ToolTipText = "Open the GUI form";
            treeNode40.Name = "self embed (Text)";
            treeNode40.Text = "self embed (Text)";
            treeNode40.ToolTipText = "Turn text into an embed";
            treeNode41.Name = "self bot";
            treeNode41.Text = "self bot";
            treeNode41.ToolTipText = "Get info about the bot origins";
            treeNode42.Name = "self lenny";
            treeNode42.Text = "self lenny";
            treeNode42.ToolTipText = "Lenny face";
            treeNode43.Name = "self lewd (Text)";
            treeNode43.Text = "self lewd (Text)";
            treeNode43.ToolTipText = "You are lewd";
            treeNode44.Name = "self user (User ID)";
            treeNode44.Text = "self user (User ID)";
            treeNode44.ToolTipText = "Get info about a user";
            treeNode45.Name = "self user @Mention";
            treeNode45.Text = "self user @Mention";
            treeNode45.ToolTipText = "Get info about a user";
            treeNode46.Name = "self find (User ID)";
            treeNode46.Text = "self find (User ID)";
            treeNode46.ToolTipText = "Usefull in finding DM advertisers";
            treeNode47.Name = "self addtag (Tag) (Text)";
            treeNode47.Text = "self addtag (Tag) (Text)";
            treeNode47.ToolTipText = "Add text to a tag";
            treeNode48.Name = "self addtag (Tag) (Message ID)";
            treeNode48.Text = "self addtag (Tag) (Message ID)";
            treeNode48.ToolTipText = "Add another users message as a tag";
            treeNode49.Name = "self tag (Tag)";
            treeNode49.Text = "self tag (Tag)";
            treeNode49.ToolTipText = "Get the created tag";
            treeNode50.Name = "self tags";
            treeNode50.Text = "self tags";
            treeNode50.ToolTipText = "Get a list of tags";
            treeNode51.Name = "self deltag (Tag)";
            treeNode51.Text = "self deltag (Tag)";
            treeNode51.ToolTipText = "Broken right now";
            treeNode52.Name = "self an bind";
            treeNode52.Text = "self an bind";
            treeNode52.ToolTipText = "Add the guild to the autonickname";
            treeNode53.Name = "self an add (Nickname)";
            treeNode53.Text = "self an add (Nickname)";
            treeNode53.ToolTipText = "Add a per guild nickname";
            treeNode54.Name = "self an del (Nickname)";
            treeNode54.Text = "self an del (Nickname)";
            treeNode54.ToolTipText = "Delete a per guild nickname";
            treeNode55.Name = "self an list";
            treeNode55.Text = "self an list";
            treeNode55.ToolTipText = "List all per guild nicknames";
            this.ViewCommandsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            this.ViewCommandsList.Size = new System.Drawing.Size(224, 310);
            this.ViewCommandsList.TabIndex = 1;
            // 
            // NavChangelogPage
            // 
            this.NavChangelogPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavChangelogPage.Controls.Add(this.TextChangelog);
            this.NavChangelogPage.Flags = 65534;
            this.NavChangelogPage.LastVisibleSet = true;
            this.NavChangelogPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavChangelogPage.Name = "NavChangelogPage";
            this.NavChangelogPage.Size = new System.Drawing.Size(224, 310);
            this.NavChangelogPage.Text = "Changelog";
            this.NavChangelogPage.ToolTipTitle = "Page ToolTip";
            this.NavChangelogPage.UniqueName = "3A74029FC7CF4436139DF09E44727F94";
            // 
            // TextChangelog
            // 
            this.TextChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextChangelog.Location = new System.Drawing.Point(0, 0);
            this.TextChangelog.Multiline = true;
            this.TextChangelog.Name = "TextChangelog";
            this.TextChangelog.ReadOnly = true;
            this.TextChangelog.Size = new System.Drawing.Size(224, 310);
            this.TextChangelog.TabIndex = 0;
            this.TextChangelog.Text = "Fixed showing embed color and favorite color\r\n\r\nCustom themes added\r\n\r\nMajor over" +
    "haul of the GUI\r\n";
            // 
            // HyperlinkGuild
            // 
            this.HyperlinkGuild.Location = new System.Drawing.Point(168, 3);
            this.HyperlinkGuild.Name = "HyperlinkGuild";
            this.HyperlinkGuild.Size = new System.Drawing.Size(60, 20);
            this.HyperlinkGuild.TabIndex = 6;
            this.HyperlinkGuild.Values.Text = "My Guild";
            this.HyperlinkGuild.LinkClicked += new System.EventHandler(this.HyperlinkGuild_LinkClicked);
            // 
            // HyperlinkWebsite
            // 
            this.HyperlinkWebsite.Location = new System.Drawing.Point(87, 3);
            this.HyperlinkWebsite.Name = "HyperlinkWebsite";
            this.HyperlinkWebsite.Size = new System.Drawing.Size(55, 20);
            this.HyperlinkWebsite.TabIndex = 5;
            this.HyperlinkWebsite.Values.Text = "Website";
            this.HyperlinkWebsite.LinkClicked += new System.EventHandler(this.HyperlinkWebsite_LinkClicked);
            // 
            // HyperlinkGithub
            // 
            this.HyperlinkGithub.Location = new System.Drawing.Point(3, 3);
            this.HyperlinkGithub.Name = "HyperlinkGithub";
            this.HyperlinkGithub.Size = new System.Drawing.Size(47, 20);
            this.HyperlinkGithub.TabIndex = 4;
            this.HyperlinkGithub.Values.Text = "Github";
            this.HyperlinkGithub.LinkClicked += new System.EventHandler(this.HyperlinkGithub_LinkClicked);
            // 
            // NavInfoThemes
            // 
            this.NavInfoThemes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoThemes.Controls.Add(this.kryptonButton3);
            this.NavInfoThemes.Controls.Add(this.kryptonButton2);
            this.NavInfoThemes.Controls.Add(this.kryptonButton1);
            this.NavInfoThemes.Flags = 65534;
            this.NavInfoThemes.LastVisibleSet = true;
            this.NavInfoThemes.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoThemes.Name = "NavInfoThemes";
            this.NavInfoThemes.Size = new System.Drawing.Size(232, 369);
            this.NavInfoThemes.Text = "Themes";
            this.NavInfoThemes.ToolTipTitle = "Page ToolTip";
            this.NavInfoThemes.UniqueName = "D9CF7C7E665A4C5EF0A5F9ED2C3255A3";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(7, 119);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton3.Size = new System.Drawing.Size(214, 50);
            this.kryptonButton3.TabIndex = 2;
            this.kryptonButton3.Values.Text = "Dark Sparkle";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(7, 63);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonButton2.Size = new System.Drawing.Size(214, 50);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "Dark Theme";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(7, 7);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonButton1.Size = new System.Drawing.Size(214, 50);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Default Theme";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // NavInfoBots
            // 
            this.NavInfoBots.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoBots.Controls.Add(this.TextBotInfo);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotInvite);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotWebsite);
            this.NavInfoBots.Controls.Add(this.ViewBotsList);
            this.NavInfoBots.Flags = 65534;
            this.NavInfoBots.LastVisibleSet = true;
            this.NavInfoBots.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoBots.Name = "NavInfoBots";
            this.NavInfoBots.Size = new System.Drawing.Size(232, 369);
            this.NavInfoBots.Text = "Bots";
            this.NavInfoBots.ToolTipTitle = "Page ToolTip";
            this.NavInfoBots.UniqueName = "BB6C782F33E64B9FB49FF924F7F68668";
            // 
            // TextBotInfo
            // 
            this.TextBotInfo.Location = new System.Drawing.Point(7, 286);
            this.TextBotInfo.Multiline = true;
            this.TextBotInfo.Name = "TextBotInfo";
            this.TextBotInfo.ReadOnly = true;
            this.TextBotInfo.Size = new System.Drawing.Size(218, 79);
            this.TextBotInfo.TabIndex = 7;
            this.TextBotInfo.Text = "Select a bot above";
            // 
            // HyperlinkBotInvite
            // 
            this.HyperlinkBotInvite.Location = new System.Drawing.Point(159, 260);
            this.HyperlinkBotInvite.Name = "HyperlinkBotInvite";
            this.HyperlinkBotInvite.Size = new System.Drawing.Size(66, 20);
            this.HyperlinkBotInvite.TabIndex = 6;
            this.HyperlinkBotInvite.Values.Text = "Invite Link";
            this.HyperlinkBotInvite.Visible = false;
            this.HyperlinkBotInvite.LinkClicked += new System.EventHandler(this.HyperlinkBotInvite_LinkClicked);
            // 
            // HyperlinkBotWebsite
            // 
            this.HyperlinkBotWebsite.Location = new System.Drawing.Point(7, 260);
            this.HyperlinkBotWebsite.Name = "HyperlinkBotWebsite";
            this.HyperlinkBotWebsite.Size = new System.Drawing.Size(55, 20);
            this.HyperlinkBotWebsite.TabIndex = 5;
            this.HyperlinkBotWebsite.Values.Text = "Website";
            this.HyperlinkBotWebsite.Visible = false;
            this.HyperlinkBotWebsite.LinkClicked += new System.EventHandler(this.HyperlinkBotWebsite_LinkClicked);
            // 
            // ViewBotsList
            // 
            this.ViewBotsList.Location = new System.Drawing.Point(3, 3);
            this.ViewBotsList.Name = "ViewBotsList";
            treeNode56.Name = "PixelBot";
            treeNode56.Text = "PixelBot";
            treeNode57.Name = "Minotaur";
            treeNode57.Text = "Minotaur";
            treeNode58.Name = "My Bots";
            treeNode58.Text = "My Bots";
            treeNode59.Name = "Discord Cards";
            treeNode59.Text = "Discord Cards";
            treeNode60.Name = "Casino Bot";
            treeNode60.Text = "Casino Bot";
            treeNode61.Name = "Discord RPG";
            treeNode61.Text = "Discord RPG";
            treeNode62.Name = "Fun Bots";
            treeNode62.Text = "Fun Bots";
            treeNode63.Name = "Sekoboto";
            treeNode63.Text = "Sekobot";
            treeNode64.Name = "Other Bots";
            treeNode64.Text = "Other Bots";
            this.ViewBotsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode62,
            treeNode64});
            this.ViewBotsList.Size = new System.Drawing.Size(227, 252);
            this.ViewBotsList.TabIndex = 1;
            this.ViewBotsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewBotsList_AfterSelect);
            // 
            // NavInfoSettings
            // 
            this.NavInfoSettings.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoSettings.Controls.Add(this.TextFavColor);
            this.NavInfoSettings.Controls.Add(this.BtnAN5);
            this.NavInfoSettings.Controls.Add(this.BtnAN10);
            this.NavInfoSettings.Controls.Add(this.BtnAN1);
            this.NavInfoSettings.Controls.Add(this.TextAutoNickname);
            this.NavInfoSettings.Controls.Add(this.BtnFavColor);
            this.NavInfoSettings.Controls.Add(this.BtnAFNo);
            this.NavInfoSettings.Controls.Add(this.TextAutoForm);
            this.NavInfoSettings.Controls.Add(this.BtnAFYes);
            this.NavInfoSettings.Controls.Add(this.BtnCMDelete);
            this.NavInfoSettings.Controls.Add(this.TextCommandMessage);
            this.NavInfoSettings.Controls.Add(this.BtnCMEdit);
            this.NavInfoSettings.Controls.Add(this.TitleCommandMessage);
            this.NavInfoSettings.Controls.Add(this.TitleStartupForm);
            this.NavInfoSettings.Controls.Add(this.TitleFavoriteColor);
            this.NavInfoSettings.Controls.Add(this.TitleAutoNicknameTimer);
            this.NavInfoSettings.Flags = 65534;
            this.NavInfoSettings.LastVisibleSet = true;
            this.NavInfoSettings.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoSettings.Name = "NavInfoSettings";
            this.NavInfoSettings.Size = new System.Drawing.Size(232, 369);
            this.NavInfoSettings.Text = "Settings";
            this.NavInfoSettings.ToolTipTitle = "Page ToolTip";
            this.NavInfoSettings.UniqueName = "49ED9FB7DC7E4E4A978BC06114B986B4";
            // 
            // BtnAN5
            // 
            this.BtnAN5.Location = new System.Drawing.Point(65, 245);
            this.BtnAN5.Name = "BtnAN5";
            this.BtnAN5.Size = new System.Drawing.Size(50, 40);
            this.BtnAN5.TabIndex = 111;
            this.BtnAN5.Values.Text = "5 Min";
            this.BtnAN5.Click += new System.EventHandler(this.BtnAN5_Click);
            // 
            // BtnAN10
            // 
            this.BtnAN10.Location = new System.Drawing.Point(121, 245);
            this.BtnAN10.Name = "BtnAN10";
            this.BtnAN10.Size = new System.Drawing.Size(50, 40);
            this.BtnAN10.TabIndex = 110;
            this.BtnAN10.Values.Text = "10 Min\r\n";
            this.BtnAN10.Click += new System.EventHandler(this.BtnAN10_Click);
            // 
            // BtnAN1
            // 
            this.BtnAN1.Location = new System.Drawing.Point(9, 245);
            this.BtnAN1.Name = "BtnAN1";
            this.BtnAN1.Size = new System.Drawing.Size(50, 40);
            this.BtnAN1.TabIndex = 109;
            this.BtnAN1.Values.Text = "1 Min";
            this.BtnAN1.Click += new System.EventHandler(this.BtnAN1_Click);
            // 
            // BtnFavColor
            // 
            this.BtnFavColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnFavColor.Location = new System.Drawing.Point(72, 173);
            this.BtnFavColor.Name = "BtnFavColor";
            this.BtnFavColor.Size = new System.Drawing.Size(70, 40);
            this.BtnFavColor.TabIndex = 107;
            this.BtnFavColor.Values.Text = "Color";
            this.BtnFavColor.Click += new System.EventHandler(this.BtnFavColor_Click);
            // 
            // BtnAFNo
            // 
            this.BtnAFNo.Location = new System.Drawing.Point(97, 101);
            this.BtnAFNo.Name = "BtnAFNo";
            this.BtnAFNo.Size = new System.Drawing.Size(70, 40);
            this.BtnAFNo.TabIndex = 106;
            this.BtnAFNo.Values.Text = "No";
            this.BtnAFNo.Click += new System.EventHandler(this.BtnAFNo_Click);
            // 
            // BtnAFYes
            // 
            this.BtnAFYes.Location = new System.Drawing.Point(9, 101);
            this.BtnAFYes.Name = "BtnAFYes";
            this.BtnAFYes.Size = new System.Drawing.Size(70, 40);
            this.BtnAFYes.TabIndex = 104;
            this.BtnAFYes.Values.Text = "Yes";
            this.BtnAFYes.Click += new System.EventHandler(this.BtnAFYes_Click);
            // 
            // BtnCMDelete
            // 
            this.BtnCMDelete.Location = new System.Drawing.Point(97, 29);
            this.BtnCMDelete.Name = "BtnCMDelete";
            this.BtnCMDelete.Size = new System.Drawing.Size(70, 40);
            this.BtnCMDelete.TabIndex = 103;
            this.BtnCMDelete.Values.Text = "Delete";
            this.BtnCMDelete.Click += new System.EventHandler(this.BtnCMDelete_Click);
            // 
            // BtnCMEdit
            // 
            this.BtnCMEdit.Location = new System.Drawing.Point(9, 29);
            this.BtnCMEdit.Name = "BtnCMEdit";
            this.BtnCMEdit.Size = new System.Drawing.Size(70, 40);
            this.BtnCMEdit.TabIndex = 101;
            this.BtnCMEdit.Values.Text = "Edit";
            this.BtnCMEdit.Click += new System.EventHandler(this.BtnCMEdit_Click);
            // 
            // Towergame_Communism
            // 
            this.Towergame_Communism.AllowFormChrome = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.Towergame_Communism.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            // 
            // GuildList
            // 
            this.GuildList.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.GuildList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuildList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GuildList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GuildList.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.GuildList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.GuildList.Location = new System.Drawing.Point(0, 0);
            this.GuildList.Name = "GuildList";
            this.GuildList.Padding = new System.Windows.Forms.Padding(0);
            this.GuildList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuildList.Size = new System.Drawing.Size(484, 25);
            this.GuildList.Stretch = true;
            this.GuildList.TabIndex = 17;
            this.GuildList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GuildList_ItemClicked);
            // 
            // TextAutoNickname
            // 
            this.TextAutoNickname.AutoSize = false;
            this.TextAutoNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "ANTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoNickname.Location = new System.Drawing.Point(181, 245);
            this.TextAutoNickname.Name = "TextAutoNickname";
            this.TextAutoNickname.Size = new System.Drawing.Size(40, 40);
            this.TextAutoNickname.TabIndex = 108;
            this.TextAutoNickname.Text = global::Discore_Selfbot.Properties.Settings.Default.ANTimer;
            this.TextAutoNickname.Values.Text = "1";
            // 
            // TextAutoForm
            // 
            this.TextAutoForm.AutoSize = false;
            this.TextAutoForm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "AutoForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoForm.Location = new System.Drawing.Point(173, 101);
            this.TextAutoForm.Name = "TextAutoForm";
            this.TextAutoForm.Size = new System.Drawing.Size(48, 40);
            this.TextAutoForm.TabIndex = 105;
            this.TextAutoForm.Text = global::Discore_Selfbot.Properties.Settings.Default.AutoForm;
            this.TextAutoForm.Values.Text = "Yes";
            // 
            // TextCommandMessage
            // 
            this.TextCommandMessage.AutoSize = false;
            this.TextCommandMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "SendAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextCommandMessage.Location = new System.Drawing.Point(173, 29);
            this.TextCommandMessage.Name = "TextCommandMessage";
            this.TextCommandMessage.Size = new System.Drawing.Size(48, 40);
            this.TextCommandMessage.TabIndex = 102;
            this.TextCommandMessage.Text = global::Discore_Selfbot.Properties.Settings.Default.SendAction;
            this.TextCommandMessage.Values.Text = "Edit";
            // 
            // TitleCommandMessage
            // 
            this.TitleCommandMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleCommandMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleCommandMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleCommandMessage.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleCommandMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCommandMessage.ForeColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TitleCommandMessage.Location = new System.Drawing.Point(7, 3);
            this.TitleCommandMessage.Name = "TitleCommandMessage";
            this.TitleCommandMessage.ReadOnly = true;
            this.TitleCommandMessage.Size = new System.Drawing.Size(214, 20);
            this.TitleCommandMessage.TabIndex = 97;
            this.TitleCommandMessage.TabStop = false;
            this.TitleCommandMessage.Text = "Command Message";
            this.TitleCommandMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleStartupForm
            // 
            this.TitleStartupForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleStartupForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleStartupForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleStartupForm.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleStartupForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleStartupForm.ForeColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TitleStartupForm.Location = new System.Drawing.Point(7, 75);
            this.TitleStartupForm.Name = "TitleStartupForm";
            this.TitleStartupForm.ReadOnly = true;
            this.TitleStartupForm.Size = new System.Drawing.Size(214, 20);
            this.TitleStartupForm.TabIndex = 98;
            this.TitleStartupForm.TabStop = false;
            this.TitleStartupForm.Text = "Open Form On Startup";
            this.TitleStartupForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleFavoriteColor
            // 
            this.TitleFavoriteColor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleFavoriteColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleFavoriteColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleFavoriteColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleFavoriteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleFavoriteColor.ForeColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TitleFavoriteColor.Location = new System.Drawing.Point(7, 147);
            this.TitleFavoriteColor.Name = "TitleFavoriteColor";
            this.TitleFavoriteColor.ReadOnly = true;
            this.TitleFavoriteColor.Size = new System.Drawing.Size(214, 20);
            this.TitleFavoriteColor.TabIndex = 99;
            this.TitleFavoriteColor.TabStop = false;
            this.TitleFavoriteColor.Text = "Favorite Color";
            this.TitleFavoriteColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleAutoNicknameTimer
            // 
            this.TitleAutoNicknameTimer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleAutoNicknameTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleAutoNicknameTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleAutoNicknameTimer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleAutoNicknameTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAutoNicknameTimer.ForeColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TitleAutoNicknameTimer.Location = new System.Drawing.Point(7, 219);
            this.TitleAutoNicknameTimer.Name = "TitleAutoNicknameTimer";
            this.TitleAutoNicknameTimer.ReadOnly = true;
            this.TitleAutoNicknameTimer.Size = new System.Drawing.Size(214, 20);
            this.TitleAutoNicknameTimer.TabIndex = 100;
            this.TitleAutoNicknameTimer.TabStop = false;
            this.TitleAutoNicknameTimer.Text = "Auto Nickname Timer";
            this.TitleAutoNicknameTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextEmbedColor
            // 
            this.TextEmbedColor.Location = new System.Drawing.Point(165, 3);
            this.TextEmbedColor.Name = "TextEmbedColor";
            this.TextEmbedColor.ReadOnly = true;
            this.TextEmbedColor.Size = new System.Drawing.Size(50, 20);
            this.TextEmbedColor.TabIndex = 7;
            this.TextEmbedColor.Visible = false;
            // 
            // TextFavColor
            // 
            this.TextFavColor.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TextFavColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextFavColor.Location = new System.Drawing.Point(148, 184);
            this.TextFavColor.Name = "TextFavColor";
            this.TextFavColor.ReadOnly = true;
            this.TextFavColor.Size = new System.Drawing.Size(50, 20);
            this.TextFavColor.TabIndex = 112;
            this.TextFavColor.Visible = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ChannelList);
            this.Controls.Add(this.NavGuild);
            this.Controls.Add(this.ChannelLogging);
            this.Controls.Add(this.StatusActive);
            this.Controls.Add(this.GuildList);
            this.Controls.Add(this.NavInfo);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.StatusActive.ResumeLayout(false);
            this.StatusActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuild)).EndInit();
            this.NavGuild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavEmbedPage)).EndInit();
            this.NavEmbedPage.ResumeLayout(false);
            this.NavEmbedPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuildInfoPage)).EndInit();
            this.NavGuildInfoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavRolesPage)).EndInit();
            this.NavRolesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavPageEmoji)).EndInit();
            this.NavPageEmoji.ResumeLayout(false);
            this.NavPageEmoji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfo)).EndInit();
            this.NavInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoInfo)).EndInit();
            this.NavInfoInfo.ResumeLayout(false);
            this.NavInfoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavMoreInfo)).EndInit();
            this.NavMoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavCommandsPage)).EndInit();
            this.NavCommandsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavChangelogPage)).EndInit();
            this.NavChangelogPage.ResumeLayout(false);
            this.NavChangelogPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoThemes)).EndInit();
            this.NavInfoThemes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoBots)).EndInit();
            this.NavInfoBots.ResumeLayout(false);
            this.NavInfoBots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoSettings)).EndInit();
            this.NavInfoSettings.ResumeLayout(false);
            this.NavInfoSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavInfo;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoInfo;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoBots;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoThemes;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoSettings;
        public System.Windows.Forms.ToolStrip GuildList;
        private System.Windows.Forms.StatusStrip StatusActive;
        private System.Windows.Forms.ToolStripStatusLabel ATitle;
        private System.Windows.Forms.ToolStripStatusLabel AGTitle;
        public System.Windows.Forms.ToolStripStatusLabel AGName;
        public System.Windows.Forms.ToolStripStatusLabel AGID;
        private System.Windows.Forms.ToolStripStatusLabel ACTitle;
        public System.Windows.Forms.ToolStripStatusLabel ACName;
        public System.Windows.Forms.ToolStripStatusLabel ACID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ChannelLogging;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavGuild;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavEmbedPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavGuildInfoPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavRolesPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavPageEmoji;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedFooter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedText;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEmbedColor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedTitle;
        private System.Windows.Forms.RichTextBox TextGuildInfo;
        private System.Windows.Forms.RichTextBox TextGuildRoles;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextGuildEmojis;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ViewBotsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkBotInvite;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkBotWebsite;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBotInfo;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavMoreInfo;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavCommandsPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavChangelogPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkGuild;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkWebsite;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkGithub;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ViewCommandsList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextChangelog;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextAutoNickname;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnFavColor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAFNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextAutoForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAFYes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCMDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextCommandMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCMEdit;
        internal System.Windows.Forms.TextBox TitleCommandMessage;
        internal System.Windows.Forms.TextBox TitleStartupForm;
        internal System.Windows.Forms.TextBox TitleFavoriteColor;
        internal System.Windows.Forms.TextBox TitleAutoNicknameTimer;
        private System.Windows.Forms.ColorDialog OpenFavoriteColor;
        private System.Windows.Forms.ColorDialog OpenEmbedColor;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendActive;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendSelected;
        public System.Windows.Forms.ComboBox ChannelList;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette Towergame_Communism;
        private System.Windows.Forms.TextBox TextEmbedColor;
        private System.Windows.Forms.TextBox TextFavColor;
    }
}