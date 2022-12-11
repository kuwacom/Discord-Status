namespace discord_status
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.button1 = new System.Windows.Forms.Button();
            this.applicationIdText = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.applicationIdLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定をエクスポートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定をインポートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リセットrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsText = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.colon = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.sutatusLabel = new System.Windows.Forms.Label();
            this.partyMaxLabel = new System.Windows.Forms.Label();
            this.partyMaxText = new System.Windows.Forms.TextBox();
            this.partySizeText = new System.Windows.Forms.TextBox();
            this.partySizeLabel = new System.Windows.Forms.Label();
            this.largeImageTextText = new System.Windows.Forms.TextBox();
            this.largeImageTextLabel = new System.Windows.Forms.Label();
            this.largeImageKeyText = new System.Windows.Forms.TextBox();
            this.largeImageKeyLabel = new System.Windows.Forms.Label();
            this.smallImageTextText = new System.Windows.Forms.TextBox();
            this.smallImageTextLabel = new System.Windows.Forms.Label();
            this.smallImageKeyText = new System.Windows.Forms.TextBox();
            this.smallImageKeyLabel = new System.Windows.Forms.Label();
            this.timeStampEndLabel = new System.Windows.Forms.Label();
            this.timeStampStartLabel = new System.Windows.Forms.Label();
            this.partyGroupLabel = new System.Windows.Forms.GroupBox();
            this.largeImageGroup = new System.Windows.Forms.GroupBox();
            this.smallImageGroup = new System.Windows.Forms.GroupBox();
            this.timeStampGroup = new System.Windows.Forms.GroupBox();
            this.timeStampEndCheck = new System.Windows.Forms.CheckBox();
            this.timeStampEndText = new System.Windows.Forms.DateTimePicker();
            this.timeStampStartCheck = new System.Windows.Forms.CheckBox();
            this.timeStampStartText = new System.Windows.Forms.DateTimePicker();
            this.buttonGroup = new System.Windows.Forms.GroupBox();
            this.button2Group = new System.Windows.Forms.GroupBox();
            this.button2Colon = new System.Windows.Forms.Label();
            this.button2LabelText = new System.Windows.Forms.TextBox();
            this.button2URLLabel = new System.Windows.Forms.Label();
            this.button2URLText = new System.Windows.Forms.TextBox();
            this.button2LabelLabel = new System.Windows.Forms.Label();
            this.button1Group = new System.Windows.Forms.GroupBox();
            this.button1Colon = new System.Windows.Forms.Label();
            this.button1URLLabel = new System.Windows.Forms.Label();
            this.button1LabelLabel = new System.Windows.Forms.Label();
            this.button1URLText = new System.Windows.Forms.TextBox();
            this.button1LabelText = new System.Windows.Forms.TextBox();
            this.consoleLogLabel = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.kuwacom = new System.Windows.Forms.LinkLabel();
            this.kuwa_network = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.partyGroupLabel.SuspendLayout();
            this.largeImageGroup.SuspendLayout();
            this.smallImageGroup.SuspendLayout();
            this.timeStampGroup.SuspendLayout();
            this.buttonGroup.SuspendLayout();
            this.button2Group.SuspendLayout();
            this.button1Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(423, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ログイン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loginButton);
            // 
            // applicationIdText
            // 
            this.applicationIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationIdText.Location = new System.Drawing.Point(120, 27);
            this.applicationIdText.Name = "applicationIdText";
            this.applicationIdText.Size = new System.Drawing.Size(297, 23);
            this.applicationIdText.TabIndex = 1;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.CausesValidation = false;
            this.logBox.Location = new System.Drawing.Point(12, 669);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(481, 59);
            this.logBox.TabIndex = 2;
            // 
            // applicationIdLabel
            // 
            this.applicationIdLabel.AutoSize = true;
            this.applicationIdLabel.Location = new System.Drawing.Point(12, 31);
            this.applicationIdLabel.Name = "applicationIdLabel";
            this.applicationIdLabel.Size = new System.Drawing.Size(82, 15);
            this.applicationIdLabel.TabIndex = 3;
            this.applicationIdLabel.Text = "Application ID";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(481, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "変更";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.setButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.保存ToolStripMenuItem1,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(205, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.設定をエクスポートToolStripMenuItem,
            this.設定をインポートToolStripMenuItem,
            this.リセットrToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&f)";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.保存ToolStripMenuItem.Text = "保存(&s)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.saveSetting);
            // 
            // 設定をエクスポートToolStripMenuItem
            // 
            this.設定をエクスポートToolStripMenuItem.Name = "設定をエクスポートToolStripMenuItem";
            this.設定をエクスポートToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.設定をエクスポートToolStripMenuItem.Text = "設定をエクスポート(&e)...";
            this.設定をエクスポートToolStripMenuItem.Click += new System.EventHandler(this.exportSetting);
            // 
            // 設定をインポートToolStripMenuItem
            // 
            this.設定をインポートToolStripMenuItem.Name = "設定をインポートToolStripMenuItem";
            this.設定をインポートToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.設定をインポートToolStripMenuItem.Text = "設定をインポート(&i)...";
            this.設定をインポートToolStripMenuItem.Click += new System.EventHandler(this.importSetting);
            // 
            // リセットrToolStripMenuItem
            // 
            this.リセットrToolStripMenuItem.Name = "リセットrToolStripMenuItem";
            this.リセットrToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.リセットrToolStripMenuItem.Text = "リセット(&r)";
            this.リセットrToolStripMenuItem.Click += new System.EventHandler(this.resetSetting);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.保存ToolStripMenuItem1.Text = "設定(&s)";
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ((&h)...";
            // 
            // detailsText
            // 
            this.detailsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsText.Location = new System.Drawing.Point(120, 56);
            this.detailsText.Name = "detailsText";
            this.detailsText.Size = new System.Drawing.Size(373, 23);
            this.detailsText.TabIndex = 7;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(12, 59);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(31, 15);
            this.detailsLabel.TabIndex = 8;
            this.detailsLabel.Text = "詳細";
            // 
            // colon
            // 
            this.colon.AutoSize = true;
            this.colon.Location = new System.Drawing.Point(100, 31);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(10, 75);
            this.colon.TabIndex = 10;
            this.colon.Text = ":\r\n\r\n:\r\n\r\n:";
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.Location = new System.Drawing.Point(120, 85);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(373, 23);
            this.statusText.TabIndex = 11;
            // 
            // sutatusLabel
            // 
            this.sutatusLabel.AutoSize = true;
            this.sutatusLabel.Location = new System.Drawing.Point(12, 88);
            this.sutatusLabel.Name = "sutatusLabel";
            this.sutatusLabel.Size = new System.Drawing.Size(51, 15);
            this.sutatusLabel.TabIndex = 12;
            this.sutatusLabel.Text = "ステータス";
            // 
            // partyMaxLabel
            // 
            this.partyMaxLabel.AutoSize = true;
            this.partyMaxLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partyMaxLabel.Location = new System.Drawing.Point(6, 25);
            this.partyMaxLabel.Name = "partyMaxLabel";
            this.partyMaxLabel.Size = new System.Drawing.Size(39, 15);
            this.partyMaxLabel.TabIndex = 15;
            this.partyMaxLabel.Text = "Max : ";
            // 
            // partyMaxText
            // 
            this.partyMaxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partyMaxText.Location = new System.Drawing.Point(51, 22);
            this.partyMaxText.Name = "partyMaxText";
            this.partyMaxText.Size = new System.Drawing.Size(186, 23);
            this.partyMaxText.TabIndex = 16;
            // 
            // partySizeText
            // 
            this.partySizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partySizeText.Location = new System.Drawing.Point(289, 22);
            this.partySizeText.Name = "partySizeText";
            this.partySizeText.Size = new System.Drawing.Size(186, 23);
            this.partySizeText.TabIndex = 18;
            // 
            // partySizeLabel
            // 
            this.partySizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partySizeLabel.AutoSize = true;
            this.partySizeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partySizeLabel.Location = new System.Drawing.Point(247, 25);
            this.partySizeLabel.Name = "partySizeLabel";
            this.partySizeLabel.Size = new System.Drawing.Size(36, 15);
            this.partySizeLabel.TabIndex = 17;
            this.partySizeLabel.Text = "Size : ";
            // 
            // largeImageTextText
            // 
            this.largeImageTextText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.largeImageTextText.Location = new System.Drawing.Point(289, 22);
            this.largeImageTextText.Name = "largeImageTextText";
            this.largeImageTextText.Size = new System.Drawing.Size(186, 23);
            this.largeImageTextText.TabIndex = 24;
            // 
            // largeImageTextLabel
            // 
            this.largeImageTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.largeImageTextLabel.AutoSize = true;
            this.largeImageTextLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeImageTextLabel.Location = new System.Drawing.Point(246, 25);
            this.largeImageTextLabel.Name = "largeImageTextLabel";
            this.largeImageTextLabel.Size = new System.Drawing.Size(37, 15);
            this.largeImageTextLabel.TabIndex = 23;
            this.largeImageTextLabel.Text = "Text : ";
            // 
            // largeImageKeyText
            // 
            this.largeImageKeyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.largeImageKeyText.Location = new System.Drawing.Point(51, 22);
            this.largeImageKeyText.Name = "largeImageKeyText";
            this.largeImageKeyText.Size = new System.Drawing.Size(186, 23);
            this.largeImageKeyText.TabIndex = 22;
            // 
            // largeImageKeyLabel
            // 
            this.largeImageKeyLabel.AutoSize = true;
            this.largeImageKeyLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeImageKeyLabel.Location = new System.Drawing.Point(6, 25);
            this.largeImageKeyLabel.Name = "largeImageKeyLabel";
            this.largeImageKeyLabel.Size = new System.Drawing.Size(35, 15);
            this.largeImageKeyLabel.TabIndex = 21;
            this.largeImageKeyLabel.Text = "Key : ";
            // 
            // smallImageTextText
            // 
            this.smallImageTextText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smallImageTextText.Location = new System.Drawing.Point(289, 22);
            this.smallImageTextText.Name = "smallImageTextText";
            this.smallImageTextText.Size = new System.Drawing.Size(186, 23);
            this.smallImageTextText.TabIndex = 30;
            // 
            // smallImageTextLabel
            // 
            this.smallImageTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smallImageTextLabel.AutoSize = true;
            this.smallImageTextLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallImageTextLabel.Location = new System.Drawing.Point(246, 25);
            this.smallImageTextLabel.Name = "smallImageTextLabel";
            this.smallImageTextLabel.Size = new System.Drawing.Size(37, 15);
            this.smallImageTextLabel.TabIndex = 29;
            this.smallImageTextLabel.Text = "Text : ";
            // 
            // smallImageKeyText
            // 
            this.smallImageKeyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smallImageKeyText.Location = new System.Drawing.Point(51, 22);
            this.smallImageKeyText.Name = "smallImageKeyText";
            this.smallImageKeyText.Size = new System.Drawing.Size(186, 23);
            this.smallImageKeyText.TabIndex = 28;
            // 
            // smallImageKeyLabel
            // 
            this.smallImageKeyLabel.AutoSize = true;
            this.smallImageKeyLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallImageKeyLabel.Location = new System.Drawing.Point(6, 25);
            this.smallImageKeyLabel.Name = "smallImageKeyLabel";
            this.smallImageKeyLabel.Size = new System.Drawing.Size(35, 15);
            this.smallImageKeyLabel.TabIndex = 27;
            this.smallImageKeyLabel.Text = "Key : ";
            // 
            // timeStampEndLabel
            // 
            this.timeStampEndLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStampEndLabel.AutoSize = true;
            this.timeStampEndLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeStampEndLabel.Location = new System.Drawing.Point(247, 25);
            this.timeStampEndLabel.Name = "timeStampEndLabel";
            this.timeStampEndLabel.Size = new System.Drawing.Size(36, 15);
            this.timeStampEndLabel.TabIndex = 35;
            this.timeStampEndLabel.Text = "End : ";
            this.timeStampEndLabel.UseMnemonic = false;
            // 
            // timeStampStartLabel
            // 
            this.timeStampStartLabel.AutoSize = true;
            this.timeStampStartLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeStampStartLabel.Location = new System.Drawing.Point(6, 25);
            this.timeStampStartLabel.Name = "timeStampStartLabel";
            this.timeStampStartLabel.Size = new System.Drawing.Size(40, 15);
            this.timeStampStartLabel.TabIndex = 33;
            this.timeStampStartLabel.Text = "Start : ";
            // 
            // partyGroupLabel
            // 
            this.partyGroupLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partyGroupLabel.Controls.Add(this.partySizeText);
            this.partyGroupLabel.Controls.Add(this.partyMaxLabel);
            this.partyGroupLabel.Controls.Add(this.partyMaxText);
            this.partyGroupLabel.Controls.Add(this.partySizeLabel);
            this.partyGroupLabel.Location = new System.Drawing.Point(12, 114);
            this.partyGroupLabel.Name = "partyGroupLabel";
            this.partyGroupLabel.Size = new System.Drawing.Size(481, 59);
            this.partyGroupLabel.TabIndex = 44;
            this.partyGroupLabel.TabStop = false;
            this.partyGroupLabel.Text = "パーティー";
            // 
            // largeImageGroup
            // 
            this.largeImageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.largeImageGroup.Controls.Add(this.largeImageTextText);
            this.largeImageGroup.Controls.Add(this.largeImageKeyLabel);
            this.largeImageGroup.Controls.Add(this.largeImageKeyText);
            this.largeImageGroup.Controls.Add(this.largeImageTextLabel);
            this.largeImageGroup.Location = new System.Drawing.Point(12, 179);
            this.largeImageGroup.Name = "largeImageGroup";
            this.largeImageGroup.Size = new System.Drawing.Size(481, 59);
            this.largeImageGroup.TabIndex = 45;
            this.largeImageGroup.TabStop = false;
            this.largeImageGroup.Text = "ラージイメージ";
            // 
            // smallImageGroup
            // 
            this.smallImageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smallImageGroup.Controls.Add(this.smallImageTextText);
            this.smallImageGroup.Controls.Add(this.smallImageKeyLabel);
            this.smallImageGroup.Controls.Add(this.smallImageKeyText);
            this.smallImageGroup.Controls.Add(this.smallImageTextLabel);
            this.smallImageGroup.Location = new System.Drawing.Point(12, 244);
            this.smallImageGroup.Name = "smallImageGroup";
            this.smallImageGroup.Size = new System.Drawing.Size(481, 59);
            this.smallImageGroup.TabIndex = 46;
            this.smallImageGroup.TabStop = false;
            this.smallImageGroup.Text = "スモールイメージ";
            // 
            // timeStampGroup
            // 
            this.timeStampGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStampGroup.Controls.Add(this.timeStampEndCheck);
            this.timeStampGroup.Controls.Add(this.timeStampEndText);
            this.timeStampGroup.Controls.Add(this.timeStampStartCheck);
            this.timeStampGroup.Controls.Add(this.timeStampStartText);
            this.timeStampGroup.Controls.Add(this.timeStampStartLabel);
            this.timeStampGroup.Controls.Add(this.timeStampEndLabel);
            this.timeStampGroup.Location = new System.Drawing.Point(12, 309);
            this.timeStampGroup.Name = "timeStampGroup";
            this.timeStampGroup.Size = new System.Drawing.Size(481, 59);
            this.timeStampGroup.TabIndex = 47;
            this.timeStampGroup.TabStop = false;
            this.timeStampGroup.Text = "タイムスタンプ";
            // 
            // timeStampEndCheck
            // 
            this.timeStampEndCheck.AutoSize = true;
            this.timeStampEndCheck.Location = new System.Drawing.Point(289, 26);
            this.timeStampEndCheck.Name = "timeStampEndCheck";
            this.timeStampEndCheck.Size = new System.Drawing.Size(15, 14);
            this.timeStampEndCheck.TabIndex = 51;
            this.timeStampEndCheck.UseVisualStyleBackColor = true;
            this.timeStampEndCheck.Click += new System.EventHandler(this.timeStampEndCheckChanged);
            // 
            // timeStampEndText
            // 
            this.timeStampEndText.Checked = false;
            this.timeStampEndText.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.timeStampEndText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStampEndText.Location = new System.Drawing.Point(310, 22);
            this.timeStampEndText.Name = "timeStampEndText";
            this.timeStampEndText.ShowUpDown = true;
            this.timeStampEndText.Size = new System.Drawing.Size(165, 23);
            this.timeStampEndText.TabIndex = 50;
            // 
            // timeStampStartCheck
            // 
            this.timeStampStartCheck.AutoSize = true;
            this.timeStampStartCheck.Location = new System.Drawing.Point(51, 26);
            this.timeStampStartCheck.Name = "timeStampStartCheck";
            this.timeStampStartCheck.Size = new System.Drawing.Size(15, 14);
            this.timeStampStartCheck.TabIndex = 48;
            this.timeStampStartCheck.UseVisualStyleBackColor = true;
            this.timeStampStartCheck.Click += new System.EventHandler(this.timeStampStartCheckChanged);
            // 
            // timeStampStartText
            // 
            this.timeStampStartText.Checked = false;
            this.timeStampStartText.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.timeStampStartText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStampStartText.Location = new System.Drawing.Point(72, 22);
            this.timeStampStartText.Name = "timeStampStartText";
            this.timeStampStartText.ShowUpDown = true;
            this.timeStampStartText.Size = new System.Drawing.Size(165, 23);
            this.timeStampStartText.TabIndex = 49;
            // 
            // buttonGroup
            // 
            this.buttonGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGroup.Controls.Add(this.button2Group);
            this.buttonGroup.Controls.Add(this.button1Group);
            this.buttonGroup.Location = new System.Drawing.Point(12, 374);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(481, 217);
            this.buttonGroup.TabIndex = 52;
            this.buttonGroup.TabStop = false;
            this.buttonGroup.Text = "ボタン";
            // 
            // button2Group
            // 
            this.button2Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2Group.Controls.Add(this.button2Colon);
            this.button2Group.Controls.Add(this.button2LabelText);
            this.button2Group.Controls.Add(this.button2URLLabel);
            this.button2Group.Controls.Add(this.button2URLText);
            this.button2Group.Controls.Add(this.button2LabelLabel);
            this.button2Group.Location = new System.Drawing.Point(6, 117);
            this.button2Group.Name = "button2Group";
            this.button2Group.Size = new System.Drawing.Size(469, 89);
            this.button2Group.TabIndex = 54;
            this.button2Group.TabStop = false;
            this.button2Group.Text = "ボタン2";
            // 
            // button2Colon
            // 
            this.button2Colon.AutoSize = true;
            this.button2Colon.Location = new System.Drawing.Point(47, 25);
            this.button2Colon.Name = "button2Colon";
            this.button2Colon.Size = new System.Drawing.Size(10, 45);
            this.button2Colon.TabIndex = 57;
            this.button2Colon.Text = ":\r\n\r\n:";
            // 
            // button2LabelText
            // 
            this.button2LabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2LabelText.Location = new System.Drawing.Point(63, 22);
            this.button2LabelText.Name = "button2LabelText";
            this.button2LabelText.Size = new System.Drawing.Size(400, 23);
            this.button2LabelText.TabIndex = 54;
            // 
            // button2URLLabel
            // 
            this.button2URLLabel.AutoSize = true;
            this.button2URLLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2URLLabel.Location = new System.Drawing.Point(6, 54);
            this.button2URLLabel.Name = "button2URLLabel";
            this.button2URLLabel.Size = new System.Drawing.Size(28, 15);
            this.button2URLLabel.TabIndex = 58;
            this.button2URLLabel.Text = "URL";
            // 
            // button2URLText
            // 
            this.button2URLText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2URLText.Location = new System.Drawing.Point(63, 51);
            this.button2URLText.Name = "button2URLText";
            this.button2URLText.Size = new System.Drawing.Size(400, 23);
            this.button2URLText.TabIndex = 55;
            // 
            // button2LabelLabel
            // 
            this.button2LabelLabel.AutoSize = true;
            this.button2LabelLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2LabelLabel.Location = new System.Drawing.Point(6, 25);
            this.button2LabelLabel.Name = "button2LabelLabel";
            this.button2LabelLabel.Size = new System.Drawing.Size(35, 15);
            this.button2LabelLabel.TabIndex = 56;
            this.button2LabelLabel.Text = "Label";
            // 
            // button1Group
            // 
            this.button1Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Group.Controls.Add(this.button1Colon);
            this.button1Group.Controls.Add(this.button1URLLabel);
            this.button1Group.Controls.Add(this.button1LabelLabel);
            this.button1Group.Controls.Add(this.button1URLText);
            this.button1Group.Controls.Add(this.button1LabelText);
            this.button1Group.Location = new System.Drawing.Point(6, 22);
            this.button1Group.Name = "button1Group";
            this.button1Group.Size = new System.Drawing.Size(469, 89);
            this.button1Group.TabIndex = 53;
            this.button1Group.TabStop = false;
            this.button1Group.Text = "ボタン1";
            // 
            // button1Colon
            // 
            this.button1Colon.AutoSize = true;
            this.button1Colon.Location = new System.Drawing.Point(47, 25);
            this.button1Colon.Name = "button1Colon";
            this.button1Colon.Size = new System.Drawing.Size(10, 45);
            this.button1Colon.TabIndex = 53;
            this.button1Colon.Text = ":\r\n\r\n:";
            // 
            // button1URLLabel
            // 
            this.button1URLLabel.AutoSize = true;
            this.button1URLLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1URLLabel.Location = new System.Drawing.Point(6, 54);
            this.button1URLLabel.Name = "button1URLLabel";
            this.button1URLLabel.Size = new System.Drawing.Size(28, 15);
            this.button1URLLabel.TabIndex = 53;
            this.button1URLLabel.Text = "URL";
            // 
            // button1LabelLabel
            // 
            this.button1LabelLabel.AutoSize = true;
            this.button1LabelLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1LabelLabel.Location = new System.Drawing.Point(6, 25);
            this.button1LabelLabel.Name = "button1LabelLabel";
            this.button1LabelLabel.Size = new System.Drawing.Size(35, 15);
            this.button1LabelLabel.TabIndex = 52;
            this.button1LabelLabel.Text = "Label";
            // 
            // button1URLText
            // 
            this.button1URLText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1URLText.Location = new System.Drawing.Point(63, 51);
            this.button1URLText.Name = "button1URLText";
            this.button1URLText.Size = new System.Drawing.Size(400, 23);
            this.button1URLText.TabIndex = 32;
            // 
            // button1LabelText
            // 
            this.button1LabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1LabelText.Location = new System.Drawing.Point(63, 22);
            this.button1LabelText.Name = "button1LabelText";
            this.button1LabelText.Size = new System.Drawing.Size(400, 23);
            this.button1LabelText.TabIndex = 31;
            // 
            // consoleLogLabel
            // 
            this.consoleLogLabel.AutoSize = true;
            this.consoleLogLabel.Location = new System.Drawing.Point(12, 651);
            this.consoleLogLabel.Name = "consoleLogLabel";
            this.consoleLogLabel.Size = new System.Drawing.Size(72, 15);
            this.consoleLogLabel.TabIndex = 59;
            this.consoleLogLabel.Text = "Console Log";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(292, 9);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(201, 15);
            this.credit.TabIndex = 60;
            this.credit.Text = "Made BY kuwacom of kuwa-network";
            // 
            // kuwacom
            // 
            this.kuwacom.AutoSize = true;
            this.kuwacom.Location = new System.Drawing.Point(342, 9);
            this.kuwacom.Name = "kuwacom";
            this.kuwacom.Size = new System.Drawing.Size(58, 15);
            this.kuwacom.TabIndex = 61;
            this.kuwacom.TabStop = true;
            this.kuwacom.Text = "kuwacom";
            this.kuwacom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kuwacom_LinkClicked);
            // 
            // kuwa_network
            // 
            this.kuwa_network.AutoSize = true;
            this.kuwa_network.Location = new System.Drawing.Point(413, 9);
            this.kuwa_network.Name = "kuwa_network";
            this.kuwa_network.Size = new System.Drawing.Size(83, 15);
            this.kuwa_network.TabIndex = 62;
            this.kuwa_network.TabStop = true;
            this.kuwa_network.Text = "kuwa-network";
            this.kuwa_network.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kuwa_network_LinkClicked);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 740);
            this.Controls.Add(this.kuwa_network);
            this.Controls.Add(this.kuwacom);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.consoleLogLabel);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.timeStampGroup);
            this.Controls.Add(this.smallImageGroup);
            this.Controls.Add(this.largeImageGroup);
            this.Controls.Add(this.partyGroupLabel);
            this.Controls.Add(this.sutatusLabel);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.colon);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.detailsText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.applicationIdLabel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.applicationIdText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(521, 567);
            this.Name = "window";
            this.Text = "Discord Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.partyGroupLabel.ResumeLayout(false);
            this.partyGroupLabel.PerformLayout();
            this.largeImageGroup.ResumeLayout(false);
            this.largeImageGroup.PerformLayout();
            this.smallImageGroup.ResumeLayout(false);
            this.smallImageGroup.PerformLayout();
            this.timeStampGroup.ResumeLayout(false);
            this.timeStampGroup.PerformLayout();
            this.buttonGroup.ResumeLayout(false);
            this.button2Group.ResumeLayout(false);
            this.button2Group.PerformLayout();
            this.button1Group.ResumeLayout(false);
            this.button1Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox applicationIdText;
        private TextBox logBox;
        private Label applicationIdLabel;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 設定をエクスポートToolStripMenuItem;
        private ToolStripMenuItem 設定をインポートToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem1;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private TextBox detailsText;
        private Label detailsLabel;
        private Label colon;
        private TextBox statusText;
        private Label sutatusLabel;
        private Label partyMaxLabel;
        private TextBox partyMaxText;
        private TextBox partySizeText;
        private Label partySizeLabel;
        private TextBox largeImageTextText;
        private Label largeImageTextLabel;
        private TextBox largeImageKeyText;
        private Label largeImageKeyLabel;
        private TextBox smallImageTextText;
        private Label smallImageTextLabel;
        private TextBox smallImageKeyText;
        private Label smallImageKeyLabel;
        private Label timeStampEndLabel;
        private Label timeStampStartLabel;
        private GroupBox partyGroupLabel;
        private GroupBox largeImageGroup;
        private GroupBox smallImageGroup;
        private GroupBox timeStampGroup;
        private DateTimePicker timeStampStartText;
        private CheckBox timeStampEndCheck;
        private DateTimePicker timeStampEndText;
        private CheckBox timeStampStartCheck;
        private GroupBox buttonGroup;
        private GroupBox button2Group;
        private Label button2Colon;
        private TextBox button2LabelText;
        private Label button2URLLabel;
        private TextBox button2URLText;
        private Label button2LabelLabel;
        private GroupBox button1Group;
        private Label button1Colon;
        private Label button1URLLabel;
        private Label button1LabelLabel;
        private TextBox button1URLText;
        private TextBox button1LabelText;
        private Label consoleLogLabel;
        private ToolStripMenuItem リセットrToolStripMenuItem;
        private Label credit;
        private LinkLabel kuwacom;
        private LinkLabel kuwa_network;
    }
}