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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("self test");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("self ping");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("self ping (IP)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("self uptime");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("self form");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("self bot");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("self user (User ID)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("self user @Mention");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("self find (User ID)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Text)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Message ID)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("self tag (Tag)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("self tags");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("self deltag (Tag)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("self an bind");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("self an add (Nickname)");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("self an del (Nickname)");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("self an list");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("self guild");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("self neko");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Sekobot");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode33});
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
            this.TextEmbedColor = new System.Windows.Forms.TextBox();
            this.BtnSendActive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnSendSelected = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedFooter = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnEmbedColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge7 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
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
            this.TextCommandInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ViewCommandsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonBorderEdge5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavChangelogPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextChangelog = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkGuild = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkGithub = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonBorderEdge6 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfoThemes = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfoBots = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextBotInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkBotInvite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkBotWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.ViewBotsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfoSettings = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonHeader4 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.TextFavColor = new System.Windows.Forms.TextBox();
            this.BtnAN5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN10 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TextAutoNickname = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnFavColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAFNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TextAutoForm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnAFYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCMDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TextCommandMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnCMEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavCustomPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextCustom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.GuildList = new System.Windows.Forms.ToolStrip();
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
            ((System.ComponentModel.ISupportInitialize)(this.NavCustomPage)).BeginInit();
            this.NavCustomPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusActive
            // 
            this.StatusActive.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.StatusActive.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusActive.Size = new System.Drawing.Size(484, 22);
            this.StatusActive.SizingGrip = false;
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
            this.ChannelLogging.Location = new System.Drawing.Point(12, 67);
            this.ChannelLogging.Multiline = true;
            this.ChannelLogging.Name = "ChannelLogging";
            this.ChannelLogging.ReadOnly = true;
            this.ChannelLogging.Size = new System.Drawing.Size(220, 186);
            this.ChannelLogging.TabIndex = 20;
            this.ChannelLogging.Text = "Channel logs comming soon ;)";
            // 
            // ChannelList
            // 
            this.ChannelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChannelList.Enabled = false;
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.Location = new System.Drawing.Point(12, 40);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(220, 21);
            this.ChannelList.TabIndex = 22;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormMain;
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
            this.NavEmbedPage.Controls.Add(this.kryptonBorderEdge7);
            this.NavEmbedPage.Flags = 65534;
            this.NavEmbedPage.LastVisibleSet = true;
            this.NavEmbedPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavEmbedPage.Name = "NavEmbedPage";
            this.NavEmbedPage.Size = new System.Drawing.Size(218, 149);
            this.NavEmbedPage.Text = "Embed";
            this.NavEmbedPage.ToolTipTitle = "Page ToolTip";
            this.NavEmbedPage.UniqueName = "D0784325A0CE45D21CA18507410A4550";
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
            // BtnSendActive
            // 
            this.BtnSendActive.Enabled = false;
            this.BtnSendActive.Location = new System.Drawing.Point(118, 90);
            this.BtnSendActive.Name = "BtnSendActive";
            this.BtnSendActive.Size = new System.Drawing.Size(97, 56);
            this.BtnSendActive.TabIndex = 6;
            this.BtnSendActive.Values.Text = "Active";
            this.BtnSendActive.Click += new System.EventHandler(this.BtnSendActive_Click);
            // 
            // BtnSendSelected
            // 
            this.BtnSendSelected.Enabled = false;
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
            this.EmbedFooter.TextChanged += new System.EventHandler(this.EmbedFooter_TextChanged);
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(3, 32);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(156, 23);
            this.EmbedText.TabIndex = 3;
            this.EmbedText.Text = "Text";
            this.EmbedText.TextChanged += new System.EventHandler(this.EmbedText_TextChanged);
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
            this.EmbedTitle.TextChanged += new System.EventHandler(this.EmbedTitle_TextChanged);
            // 
            // kryptonBorderEdge7
            // 
            this.kryptonBorderEdge7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge7.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge7.Name = "kryptonBorderEdge7";
            this.kryptonBorderEdge7.Size = new System.Drawing.Size(218, 149);
            this.kryptonBorderEdge7.Text = "kryptonBorderEdge7";
            // 
            // NavGuildInfoPage
            // 
            this.NavGuildInfoPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavGuildInfoPage.Controls.Add(this.TextGuildInfo);
            this.NavGuildInfoPage.Flags = 65534;
            this.NavGuildInfoPage.LastVisibleSet = true;
            this.NavGuildInfoPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavGuildInfoPage.Name = "NavGuildInfoPage";
            this.NavGuildInfoPage.Size = new System.Drawing.Size(218, 149);
            this.NavGuildInfoPage.Text = "G Info";
            this.NavGuildInfoPage.ToolTipTitle = "Page ToolTip";
            this.NavGuildInfoPage.UniqueName = "15405AE8C3F64B0DFA9BB3419545B5E6";
            // 
            // TextGuildInfo
            // 
            this.TextGuildInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildInfo.Location = new System.Drawing.Point(0, 0);
            this.TextGuildInfo.Name = "TextGuildInfo";
            this.TextGuildInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextGuildInfo.Size = new System.Drawing.Size(218, 149);
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
            this.NavRolesPage.Size = new System.Drawing.Size(218, 149);
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
            this.TextGuildRoles.Size = new System.Drawing.Size(218, 149);
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
            this.NavPageEmoji.Size = new System.Drawing.Size(218, 149);
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
            this.TextGuildEmojis.Size = new System.Drawing.Size(218, 149);
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
            this.NavInfoSettings,
            this.NavCustomPage});
            this.NavInfo.SelectedIndex = 0;
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
            this.NavInfoInfo.Controls.Add(this.kryptonBorderEdge6);
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
            this.NavMoreInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NavMoreInfo.Location = new System.Drawing.Point(0, 30);
            this.NavMoreInfo.Name = "NavMoreInfo";
            this.NavMoreInfo.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.NavMoreInfo.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavCommandsPage,
            this.NavChangelogPage});
            this.NavMoreInfo.SelectedIndex = 1;
            this.NavMoreInfo.Size = new System.Drawing.Size(232, 339);
            this.NavMoreInfo.TabIndex = 7;
            this.NavMoreInfo.Text = "kryptonNavigator1";
            // 
            // NavCommandsPage
            // 
            this.NavCommandsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavCommandsPage.Controls.Add(this.TextCommandInfo);
            this.NavCommandsPage.Controls.Add(this.ViewCommandsList);
            this.NavCommandsPage.Controls.Add(this.kryptonBorderEdge5);
            this.NavCommandsPage.Flags = 65534;
            this.NavCommandsPage.LastVisibleSet = true;
            this.NavCommandsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavCommandsPage.Name = "NavCommandsPage";
            this.NavCommandsPage.Size = new System.Drawing.Size(230, 310);
            this.NavCommandsPage.Text = "Commands";
            this.NavCommandsPage.ToolTipTitle = "Page ToolTip";
            this.NavCommandsPage.UniqueName = "E1FF2C7914C34B417AA8BFF17BFB6E40";
            // 
            // TextCommandInfo
            // 
            this.TextCommandInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextCommandInfo.Location = new System.Drawing.Point(0, 280);
            this.TextCommandInfo.Multiline = true;
            this.TextCommandInfo.Name = "TextCommandInfo";
            this.TextCommandInfo.ReadOnly = true;
            this.TextCommandInfo.Size = new System.Drawing.Size(230, 30);
            this.TextCommandInfo.TabIndex = 2;
            this.TextCommandInfo.Text = "Select a command";
            // 
            // ViewCommandsList
            // 
            this.ViewCommandsList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.ViewCommandsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewCommandsList.HotTracking = true;
            this.ViewCommandsList.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.ViewCommandsList.Location = new System.Drawing.Point(0, 0);
            this.ViewCommandsList.Name = "ViewCommandsList";
            treeNode1.Name = "self test";
            treeNode1.Text = "self test";
            treeNode1.ToolTipText = "Test if selfbot is working";
            treeNode2.Name = "self ping";
            treeNode2.Text = "self ping";
            treeNode2.ToolTipText = "Ping the network and discord";
            treeNode3.Name = "self ping (IP)";
            treeNode3.Text = "self ping (IP)";
            treeNode3.ToolTipText = "Ping another IP address";
            treeNode4.Name = "self uptime";
            treeNode4.Text = "self uptime";
            treeNode4.ToolTipText = "Get the uptime of the bot";
            treeNode5.Name = "self info";
            treeNode5.Text = "self info";
            treeNode5.ToolTipText = "Get info about yourself";
            treeNode6.Name = "self cleanembed";
            treeNode6.Text = "self cleanembed";
            treeNode6.ToolTipText = "Cleanup all your embeds";
            treeNode7.Name = "self form";
            treeNode7.Text = "self form";
            treeNode7.ToolTipText = "Open the GUI form";
            treeNode8.Name = "self embed (Text)";
            treeNode8.Text = "self embed (Text)";
            treeNode8.ToolTipText = "Turn text into an embed";
            treeNode9.Name = "self bot";
            treeNode9.Text = "self bot";
            treeNode9.ToolTipText = "Get info about the bot origins";
            treeNode10.Name = "self lenny";
            treeNode10.Text = "self lenny";
            treeNode10.ToolTipText = "Lenny face";
            treeNode11.Name = "self lewd (Text)";
            treeNode11.Text = "self lewd (Text)";
            treeNode11.ToolTipText = "You are lewd";
            treeNode12.Name = "self user (User ID)";
            treeNode12.Text = "self user (User ID)";
            treeNode12.ToolTipText = "Get info about a user";
            treeNode13.Name = "self user @Mention";
            treeNode13.Text = "self user @Mention";
            treeNode13.ToolTipText = "Get info about a user";
            treeNode14.Name = "self find (User ID)";
            treeNode14.Text = "self find (User ID)";
            treeNode14.ToolTipText = "Usefull in finding DM advertisers";
            treeNode15.Name = "self addtag (Tag) (Text)";
            treeNode15.Text = "self addtag (Tag) (Text)";
            treeNode15.ToolTipText = "Add text to a tag";
            treeNode16.Name = "self addtag (Tag) (Message ID)";
            treeNode16.Text = "self addtag (Tag) (Message ID)";
            treeNode16.ToolTipText = "Add another users message as a tag";
            treeNode17.Name = "self tag (Tag)";
            treeNode17.Text = "self tag (Tag)";
            treeNode17.ToolTipText = "Get the created tag";
            treeNode18.Name = "self tags";
            treeNode18.Text = "self tags";
            treeNode18.ToolTipText = "Get a list of tags";
            treeNode19.Name = "self deltag (Tag)";
            treeNode19.Text = "self deltag (Tag)";
            treeNode19.ToolTipText = "Broken right now";
            treeNode20.Name = "self an bind";
            treeNode20.Text = "self an bind";
            treeNode20.ToolTipText = "Add the guild to the autonickname";
            treeNode21.Name = "self an add (Nickname)";
            treeNode21.Text = "self an add (Nickname)";
            treeNode21.ToolTipText = "Add a per guild nickname";
            treeNode22.Name = "self an del (Nickname)";
            treeNode22.Text = "self an del (Nickname)";
            treeNode22.ToolTipText = "Delete a per guild nickname";
            treeNode23.Name = "self an list";
            treeNode23.Text = "self an list";
            treeNode23.ToolTipText = "List all per guild nicknames";
            treeNode24.Name = "self guild";
            treeNode24.Text = "self guild";
            treeNode24.ToolTipText = "Get info about the guild";
            treeNode25.Name = "self neko";
            treeNode25.Text = "self neko";
            treeNode25.ToolTipText = "Post a random neko image in embed form";
            this.ViewCommandsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            this.ViewCommandsList.Size = new System.Drawing.Size(230, 274);
            this.ViewCommandsList.TabIndex = 1;
            this.ViewCommandsList.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.CommandInfoHover);
            // 
            // kryptonBorderEdge5
            // 
            this.kryptonBorderEdge5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge5.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            this.kryptonBorderEdge5.Size = new System.Drawing.Size(230, 310);
            this.kryptonBorderEdge5.Text = "kryptonBorderEdge5";
            // 
            // NavChangelogPage
            // 
            this.NavChangelogPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavChangelogPage.Controls.Add(this.TextChangelog);
            this.NavChangelogPage.Flags = 65534;
            this.NavChangelogPage.LastVisibleSet = true;
            this.NavChangelogPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavChangelogPage.Name = "NavChangelogPage";
            this.NavChangelogPage.Size = new System.Drawing.Size(230, 310);
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
            this.TextChangelog.Size = new System.Drawing.Size(230, 310);
            this.TextChangelog.TabIndex = 0;
            this.TextChangelog.Text = resources.GetString("TextChangelog.Text");
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
            // kryptonBorderEdge6
            // 
            this.kryptonBorderEdge6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge6.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge6.Name = "kryptonBorderEdge6";
            this.kryptonBorderEdge6.Size = new System.Drawing.Size(232, 369);
            this.kryptonBorderEdge6.Text = "kryptonBorderEdge6";
            // 
            // NavInfoThemes
            // 
            this.NavInfoThemes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoThemes.Controls.Add(this.kryptonButton3);
            this.NavInfoThemes.Controls.Add(this.kryptonButton2);
            this.NavInfoThemes.Controls.Add(this.kryptonButton1);
            this.NavInfoThemes.Controls.Add(this.kryptonBorderEdge4);
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
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(232, 369);
            this.kryptonBorderEdge4.Text = "kryptonBorderEdge4";
            // 
            // NavInfoBots
            // 
            this.NavInfoBots.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoBots.Controls.Add(this.TextBotInfo);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotInvite);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotWebsite);
            this.NavInfoBots.Controls.Add(this.ViewBotsList);
            this.NavInfoBots.Controls.Add(this.kryptonBorderEdge2);
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
            this.TextBotInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBotInfo.Location = new System.Drawing.Point(0, 290);
            this.TextBotInfo.Multiline = true;
            this.TextBotInfo.Name = "TextBotInfo";
            this.TextBotInfo.ReadOnly = true;
            this.TextBotInfo.Size = new System.Drawing.Size(232, 79);
            this.TextBotInfo.TabIndex = 7;
            this.TextBotInfo.Text = "Select a bot above";
            // 
            // HyperlinkBotInvite
            // 
            this.HyperlinkBotInvite.Location = new System.Drawing.Point(160, 264);
            this.HyperlinkBotInvite.Name = "HyperlinkBotInvite";
            this.HyperlinkBotInvite.Size = new System.Drawing.Size(66, 20);
            this.HyperlinkBotInvite.TabIndex = 6;
            this.HyperlinkBotInvite.Values.Text = "Invite Link";
            this.HyperlinkBotInvite.Visible = false;
            this.HyperlinkBotInvite.LinkClicked += new System.EventHandler(this.HyperlinkBotInvite_LinkClicked);
            // 
            // HyperlinkBotWebsite
            // 
            this.HyperlinkBotWebsite.Location = new System.Drawing.Point(7, 264);
            this.HyperlinkBotWebsite.Name = "HyperlinkBotWebsite";
            this.HyperlinkBotWebsite.Size = new System.Drawing.Size(55, 20);
            this.HyperlinkBotWebsite.TabIndex = 5;
            this.HyperlinkBotWebsite.Values.Text = "Website";
            this.HyperlinkBotWebsite.Visible = false;
            this.HyperlinkBotWebsite.LinkClicked += new System.EventHandler(this.HyperlinkBotWebsite_LinkClicked);
            // 
            // ViewBotsList
            // 
            this.ViewBotsList.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.ViewBotsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewBotsList.Location = new System.Drawing.Point(0, 0);
            this.ViewBotsList.Name = "ViewBotsList";
            treeNode26.Name = "PixelBot";
            treeNode26.Text = "PixelBot";
            treeNode27.Name = "Minotaur";
            treeNode27.Text = "Minotaur";
            treeNode28.Name = "My Bots";
            treeNode28.Text = "My Bots";
            treeNode29.Name = "Discord Cards";
            treeNode29.Text = "Discord Cards";
            treeNode30.Name = "Casino Bot";
            treeNode30.Text = "Casino Bot";
            treeNode31.Name = "Discord RPG";
            treeNode31.Text = "Discord RPG";
            treeNode32.Name = "Fun Bots";
            treeNode32.Text = "Fun Bots";
            treeNode33.Name = "Sekoboto";
            treeNode33.Text = "Sekobot";
            treeNode34.Name = "Other Bots";
            treeNode34.Text = "Other Bots";
            this.ViewBotsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode32,
            treeNode34});
            this.ViewBotsList.Size = new System.Drawing.Size(232, 258);
            this.ViewBotsList.TabIndex = 1;
            this.ViewBotsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewBotsList_AfterSelect);
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(232, 369);
            this.kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // NavInfoSettings
            // 
            this.NavInfoSettings.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoSettings.Controls.Add(this.kryptonHeader4);
            this.NavInfoSettings.Controls.Add(this.kryptonHeader3);
            this.NavInfoSettings.Controls.Add(this.kryptonHeader2);
            this.NavInfoSettings.Controls.Add(this.kryptonHeader1);
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
            this.NavInfoSettings.Controls.Add(this.kryptonBorderEdge3);
            this.NavInfoSettings.Flags = 65534;
            this.NavInfoSettings.LastVisibleSet = true;
            this.NavInfoSettings.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoSettings.Name = "NavInfoSettings";
            this.NavInfoSettings.Size = new System.Drawing.Size(232, 369);
            this.NavInfoSettings.Text = "Settings";
            this.NavInfoSettings.ToolTipTitle = "Page ToolTip";
            this.NavInfoSettings.UniqueName = "49ED9FB7DC7E4E4A978BC06114B986B4";
            // 
            // kryptonHeader4
            // 
            this.kryptonHeader4.AutoSize = false;
            this.kryptonHeader4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader4.Location = new System.Drawing.Point(3, 225);
            this.kryptonHeader4.Name = "kryptonHeader4";
            this.kryptonHeader4.Size = new System.Drawing.Size(226, 22);
            this.kryptonHeader4.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeader4.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeader4.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonHeader4.TabIndex = 114;
            this.kryptonHeader4.Values.Description = "";
            this.kryptonHeader4.Values.Heading = "Auto Nickname Timer";
            this.kryptonHeader4.Values.Image = null;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.AutoSize = false;
            this.kryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader3.Location = new System.Drawing.Point(3, 151);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(226, 22);
            this.kryptonHeader3.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeader3.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeader3.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonHeader3.TabIndex = 114;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Favorite Color";
            this.kryptonHeader3.Values.Image = null;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.AutoSize = false;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 77);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(226, 22);
            this.kryptonHeader2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeader2.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeader2.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonHeader2.TabIndex = 114;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Open Form On Startup";
            this.kryptonHeader2.Values.Image = null;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.AutoSize = false;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 3);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(226, 22);
            this.kryptonHeader1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeader1.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonHeader1.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonHeader1.TabIndex = 114;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Command Message";
            this.kryptonHeader1.Values.Image = null;
            // 
            // TextFavColor
            // 
            this.TextFavColor.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TextFavColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextFavColor.Location = new System.Drawing.Point(148, 193);
            this.TextFavColor.Name = "TextFavColor";
            this.TextFavColor.ReadOnly = true;
            this.TextFavColor.Size = new System.Drawing.Size(50, 20);
            this.TextFavColor.TabIndex = 112;
            this.TextFavColor.Visible = false;
            // 
            // BtnAN5
            // 
            this.BtnAN5.Location = new System.Drawing.Point(68, 253);
            this.BtnAN5.Name = "BtnAN5";
            this.BtnAN5.Size = new System.Drawing.Size(50, 40);
            this.BtnAN5.TabIndex = 111;
            this.BtnAN5.Values.Text = "5 Min";
            this.BtnAN5.Click += new System.EventHandler(this.BtnAN5_Click);
            // 
            // BtnAN10
            // 
            this.BtnAN10.Location = new System.Drawing.Point(133, 253);
            this.BtnAN10.Name = "BtnAN10";
            this.BtnAN10.Size = new System.Drawing.Size(50, 40);
            this.BtnAN10.TabIndex = 110;
            this.BtnAN10.Values.Text = "10 Min\r\n";
            this.BtnAN10.Click += new System.EventHandler(this.BtnAN10_Click);
            // 
            // BtnAN1
            // 
            this.BtnAN1.Location = new System.Drawing.Point(3, 253);
            this.BtnAN1.Name = "BtnAN1";
            this.BtnAN1.Size = new System.Drawing.Size(50, 40);
            this.BtnAN1.TabIndex = 109;
            this.BtnAN1.Values.Text = "1 Min";
            this.BtnAN1.Click += new System.EventHandler(this.BtnAN1_Click);
            // 
            // TextAutoNickname
            // 
            this.TextAutoNickname.AutoSize = false;
            this.TextAutoNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "ANTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoNickname.Location = new System.Drawing.Point(189, 253);
            this.TextAutoNickname.Name = "TextAutoNickname";
            this.TextAutoNickname.Size = new System.Drawing.Size(40, 40);
            this.TextAutoNickname.TabIndex = 108;
            this.TextAutoNickname.Text = global::Discore_Selfbot.Properties.Settings.Default.ANTimer;
            this.TextAutoNickname.Values.Text = "1";
            // 
            // BtnFavColor
            // 
            this.BtnFavColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnFavColor.Location = new System.Drawing.Point(72, 179);
            this.BtnFavColor.Name = "BtnFavColor";
            this.BtnFavColor.Size = new System.Drawing.Size(70, 40);
            this.BtnFavColor.TabIndex = 107;
            this.BtnFavColor.Values.Text = "Color";
            this.BtnFavColor.Click += new System.EventHandler(this.BtnFavColor_Click);
            // 
            // BtnAFNo
            // 
            this.BtnAFNo.Location = new System.Drawing.Point(105, 105);
            this.BtnAFNo.Name = "BtnAFNo";
            this.BtnAFNo.Size = new System.Drawing.Size(70, 40);
            this.BtnAFNo.TabIndex = 106;
            this.BtnAFNo.Values.Text = "No";
            this.BtnAFNo.Click += new System.EventHandler(this.BtnAFNo_Click);
            // 
            // TextAutoForm
            // 
            this.TextAutoForm.AutoSize = false;
            this.TextAutoForm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "AutoForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoForm.Location = new System.Drawing.Point(181, 105);
            this.TextAutoForm.Name = "TextAutoForm";
            this.TextAutoForm.Size = new System.Drawing.Size(48, 40);
            this.TextAutoForm.TabIndex = 105;
            this.TextAutoForm.Text = global::Discore_Selfbot.Properties.Settings.Default.AutoForm;
            this.TextAutoForm.Values.Text = "Yes";
            // 
            // BtnAFYes
            // 
            this.BtnAFYes.Location = new System.Drawing.Point(3, 105);
            this.BtnAFYes.Name = "BtnAFYes";
            this.BtnAFYes.Size = new System.Drawing.Size(70, 40);
            this.BtnAFYes.TabIndex = 104;
            this.BtnAFYes.Values.Text = "Yes";
            this.BtnAFYes.Click += new System.EventHandler(this.BtnAFYes_Click);
            // 
            // BtnCMDelete
            // 
            this.BtnCMDelete.Location = new System.Drawing.Point(105, 31);
            this.BtnCMDelete.Name = "BtnCMDelete";
            this.BtnCMDelete.Size = new System.Drawing.Size(70, 40);
            this.BtnCMDelete.TabIndex = 103;
            this.BtnCMDelete.Values.Text = "Delete";
            this.BtnCMDelete.Click += new System.EventHandler(this.BtnCMDelete_Click);
            // 
            // TextCommandMessage
            // 
            this.TextCommandMessage.AutoSize = false;
            this.TextCommandMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "SendAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextCommandMessage.Location = new System.Drawing.Point(181, 31);
            this.TextCommandMessage.Name = "TextCommandMessage";
            this.TextCommandMessage.Size = new System.Drawing.Size(48, 40);
            this.TextCommandMessage.TabIndex = 102;
            this.TextCommandMessage.Text = global::Discore_Selfbot.Properties.Settings.Default.SendAction;
            this.TextCommandMessage.Values.Text = "Edit";
            // 
            // BtnCMEdit
            // 
            this.BtnCMEdit.Location = new System.Drawing.Point(3, 31);
            this.BtnCMEdit.Name = "BtnCMEdit";
            this.BtnCMEdit.Size = new System.Drawing.Size(70, 40);
            this.BtnCMEdit.TabIndex = 101;
            this.BtnCMEdit.Values.Text = "Edit";
            this.BtnCMEdit.Click += new System.EventHandler(this.BtnCMEdit_Click);
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(232, 369);
            this.kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // NavCustomPage
            // 
            this.NavCustomPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavCustomPage.Controls.Add(this.TextCustom);
            this.NavCustomPage.Flags = 65534;
            this.NavCustomPage.LastVisibleSet = true;
            this.NavCustomPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavCustomPage.Name = "NavCustomPage";
            this.NavCustomPage.Size = new System.Drawing.Size(232, 369);
            this.NavCustomPage.Text = "Custom";
            this.NavCustomPage.ToolTipTitle = "Page ToolTip";
            this.NavCustomPage.UniqueName = "73E3D7DECE594F89C78B9DB7BB8B0A07";
            // 
            // TextCustom
            // 
            this.TextCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextCustom.Location = new System.Drawing.Point(0, 0);
            this.TextCustom.Multiline = true;
            this.TextCustom.Name = "TextCustom";
            this.TextCustom.ReadOnly = true;
            this.TextCustom.Size = new System.Drawing.Size(232, 369);
            this.TextCustom.TabIndex = 0;
            this.TextCustom.Text = "I wonder what goes here :D";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalAllowFormChrome = false;
            // 
            // GuildList
            // 
            this.GuildList.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.GuildList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuildList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GuildList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GuildList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GuildList.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.GuildList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.GuildList.Location = new System.Drawing.Point(0, 0);
            this.GuildList.Name = "GuildList";
            this.GuildList.Padding = new System.Windows.Forms.Padding(0);
            this.GuildList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.GuildList.Size = new System.Drawing.Size(484, 25);
            this.GuildList.Stretch = true;
            this.GuildList.TabIndex = 17;
            this.GuildList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GuildList_ItemClicked);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "GUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
            this.NavCommandsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavChangelogPage)).EndInit();
            this.NavChangelogPage.ResumeLayout(false);
            this.NavChangelogPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoThemes)).EndInit();
            this.NavInfoThemes.ResumeLayout(false);
            this.NavInfoThemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoBots)).EndInit();
            this.NavInfoBots.ResumeLayout(false);
            this.NavInfoBots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoSettings)).EndInit();
            this.NavInfoSettings.ResumeLayout(false);
            this.NavInfoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCustomPage)).EndInit();
            this.NavCustomPage.ResumeLayout(false);
            this.NavCustomPage.PerformLayout();
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
        private System.Windows.Forms.ColorDialog OpenFavoriteColor;
        private System.Windows.Forms.ColorDialog OpenEmbedColor;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendActive;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendSelected;
        public System.Windows.Forms.ComboBox ChannelList;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.TextBox TextEmbedColor;
        private System.Windows.Forms.TextBox TextFavColor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextCommandInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge7;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge6;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavCustomPage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextCustom;
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader4;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
    }
}