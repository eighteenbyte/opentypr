namespace opentypr
{
    partial class fileInfo_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileInfo_window));
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.topMenu = new System.Windows.Forms.Panel();
            this.highlight_img = new System.Windows.Forms.PictureBox();
            this.settings_btn = new opentypr.Modules.CustomButtons();
            this.statistics_btn = new opentypr.Modules.CustomButtons();
            this.general_btn = new opentypr.Modules.CustomButtons();
            this.title_lbl = new System.Windows.Forms.Label();
            this.close_btn = new opentypr.Modules.CustomButtons();
            this.anim_timer = new System.Windows.Forms.Timer(this.components);
            this.fileicon2_img = new System.Windows.Forms.PictureBox();
            this.filename2_lbl = new System.Windows.Forms.Label();
            this.generalMenu = new System.Windows.Forms.Panel();
            this.plainorrichtext_lbl = new System.Windows.Forms.Label();
            this.template_lbl = new System.Windows.Forms.Label();
            this.filelocation_lbl = new System.Windows.Forms.Label();
            this.size_lbl = new System.Windows.Forms.Label();
            this.fileextension_lbl = new System.Windows.Forms.Label();
            this.filetype_lbl = new System.Windows.Forms.Label();
            this.general_lbl = new System.Windows.Forms.Label();
            this.statisticsMenu = new System.Windows.Forms.Panel();
            this.characters_lbl = new System.Windows.Forms.Label();
            this.words_lbl = new System.Windows.Forms.Label();
            this.lines_lbl = new System.Windows.Forms.Label();
            this.pages_lbl = new System.Windows.Forms.Label();
            this.statistics_lbl = new System.Windows.Forms.Label();
            this.fileicon_img = new System.Windows.Forms.PictureBox();
            this.filename_lbl = new System.Windows.Forms.Label();
            this.settingsMenu = new System.Windows.Forms.Panel();
            this.filename_txt = new System.Windows.Forms.TextBox();
            this.plainorrichtext_cmb = new System.Windows.Forms.ComboBox();
            this.help_btn = new opentypr.Modules.CustomButtons();
            this.settings_lbl = new System.Windows.Forms.Label();
            this.fileicon3_lbl = new System.Windows.Forms.PictureBox();
            this.filename3_lbl = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highlight_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon2_img)).BeginInit();
            this.generalMenu.SuspendLayout();
            this.statisticsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon_img)).BeginInit();
            this.settingsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon3_lbl)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_img
            // 
            this.logo_img.Image = ((System.Drawing.Image)(resources.GetObject("logo_img.Image")));
            this.logo_img.Location = new System.Drawing.Point(-25, 6);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(194, 50);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 1;
            this.logo_img.TabStop = false;
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.topMenu.Controls.Add(this.highlight_img);
            this.topMenu.Controls.Add(this.settings_btn);
            this.topMenu.Controls.Add(this.statistics_btn);
            this.topMenu.Controls.Add(this.general_btn);
            this.topMenu.Controls.Add(this.title_lbl);
            this.topMenu.Controls.Add(this.close_btn);
            this.topMenu.Controls.Add(this.logo_img);
            this.topMenu.Location = new System.Drawing.Point(-1, -2);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(807, 107);
            this.topMenu.TabIndex = 2;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            // 
            // highlight_img
            // 
            this.highlight_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highlight_img.BackgroundImage")));
            this.highlight_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highlight_img.Location = new System.Drawing.Point(2, 98);
            this.highlight_img.Name = "highlight_img";
            this.highlight_img.Size = new System.Drawing.Size(80, 3);
            this.highlight_img.TabIndex = 4;
            this.highlight_img.TabStop = false;
            // 
            // settings_btn
            // 
            this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.settings_btn.BorderColor = System.Drawing.Color.White;
            this.settings_btn.BorderRadius = 10;
            this.settings_btn.BorderSize = 0;
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_btn.ForeColor = System.Drawing.Color.White;
            this.settings_btn.Location = new System.Drawing.Point(328, 61);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(150, 40);
            this.settings_btn.TabIndex = 13;
            this.settings_btn.Text = "Ayarlar";
            this.settings_btn.UseVisualStyleBackColor = false;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // statistics_btn
            // 
            this.statistics_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.statistics_btn.BorderColor = System.Drawing.Color.White;
            this.statistics_btn.BorderRadius = 10;
            this.statistics_btn.BorderSize = 0;
            this.statistics_btn.FlatAppearance.BorderSize = 0;
            this.statistics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statistics_btn.ForeColor = System.Drawing.Color.White;
            this.statistics_btn.Location = new System.Drawing.Point(172, 61);
            this.statistics_btn.Name = "statistics_btn";
            this.statistics_btn.Size = new System.Drawing.Size(150, 40);
            this.statistics_btn.TabIndex = 12;
            this.statistics_btn.Text = "İstatistikler";
            this.statistics_btn.UseVisualStyleBackColor = false;
            this.statistics_btn.Click += new System.EventHandler(this.statistics_btn_Click);
            // 
            // general_btn
            // 
            this.general_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.general_btn.BorderColor = System.Drawing.Color.White;
            this.general_btn.BorderRadius = 10;
            this.general_btn.BorderSize = 0;
            this.general_btn.FlatAppearance.BorderSize = 0;
            this.general_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.general_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.general_btn.ForeColor = System.Drawing.Color.White;
            this.general_btn.Location = new System.Drawing.Point(7, 61);
            this.general_btn.Name = "general_btn";
            this.general_btn.Size = new System.Drawing.Size(150, 40);
            this.general_btn.TabIndex = 11;
            this.general_btn.Text = "Genel";
            this.general_btn.UseVisualStyleBackColor = false;
            this.general_btn.Click += new System.EventHandler(this.general_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title_lbl.Location = new System.Drawing.Point(133, 21);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(151, 20);
            this.title_lbl.TabIndex = 10;
            this.title_lbl.Text = "| Dosya Özellikleri";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btn.BackgroundImage")));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.BorderColor = System.Drawing.Color.White;
            this.close_btn.BorderRadius = 6;
            this.close_btn.BorderSize = 0;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(754, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 30);
            this.close_btn.TabIndex = 9;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // anim_timer
            // 
            this.anim_timer.Interval = 1;
            this.anim_timer.Tick += new System.EventHandler(this.anim_timer_Tick);
            // 
            // fileicon2_img
            // 
            this.fileicon2_img.Image = ((System.Drawing.Image)(resources.GetObject("fileicon2_img.Image")));
            this.fileicon2_img.Location = new System.Drawing.Point(5, 15);
            this.fileicon2_img.Name = "fileicon2_img";
            this.fileicon2_img.Size = new System.Drawing.Size(50, 34);
            this.fileicon2_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileicon2_img.TabIndex = 3;
            this.fileicon2_img.TabStop = false;
            // 
            // filename2_lbl
            // 
            this.filename2_lbl.AutoSize = true;
            this.filename2_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename2_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filename2_lbl.Location = new System.Drawing.Point(55, 22);
            this.filename2_lbl.Name = "filename2_lbl";
            this.filename2_lbl.Size = new System.Drawing.Size(108, 21);
            this.filename2_lbl.TabIndex = 11;
            this.filename2_lbl.Text = "Adsız Belge";
            // 
            // generalMenu
            // 
            this.generalMenu.Controls.Add(this.plainorrichtext_lbl);
            this.generalMenu.Controls.Add(this.template_lbl);
            this.generalMenu.Controls.Add(this.filelocation_lbl);
            this.generalMenu.Controls.Add(this.size_lbl);
            this.generalMenu.Controls.Add(this.fileextension_lbl);
            this.generalMenu.Controls.Add(this.filetype_lbl);
            this.generalMenu.Controls.Add(this.general_lbl);
            this.generalMenu.Controls.Add(this.fileicon2_img);
            this.generalMenu.Controls.Add(this.filename2_lbl);
            this.generalMenu.Location = new System.Drawing.Point(11, 111);
            this.generalMenu.Name = "generalMenu";
            this.generalMenu.Size = new System.Drawing.Size(774, 342);
            this.generalMenu.TabIndex = 12;
            // 
            // plainorrichtext_lbl
            // 
            this.plainorrichtext_lbl.AutoSize = true;
            this.plainorrichtext_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plainorrichtext_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plainorrichtext_lbl.Location = new System.Drawing.Point(274, 300);
            this.plainorrichtext_lbl.Name = "plainorrichtext_lbl";
            this.plainorrichtext_lbl.Size = new System.Drawing.Size(78, 20);
            this.plainorrichtext_lbl.TabIndex = 18;
            this.plainorrichtext_lbl.Text = "RichText";
            this.plainorrichtext_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // template_lbl
            // 
            this.template_lbl.AutoSize = true;
            this.template_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.template_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.template_lbl.Location = new System.Drawing.Point(274, 252);
            this.template_lbl.Name = "template_lbl";
            this.template_lbl.Size = new System.Drawing.Size(38, 20);
            this.template_lbl.TabIndex = 17;
            this.template_lbl.Text = "Yok";
            this.template_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // filelocation_lbl
            // 
            this.filelocation_lbl.AutoSize = true;
            this.filelocation_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filelocation_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filelocation_lbl.Location = new System.Drawing.Point(274, 203);
            this.filelocation_lbl.Name = "filelocation_lbl";
            this.filelocation_lbl.Size = new System.Drawing.Size(88, 20);
            this.filelocation_lbl.TabIndex = 16;
            this.filelocation_lbl.Text = "Bilinmiyor";
            this.filelocation_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // size_lbl
            // 
            this.size_lbl.AutoSize = true;
            this.size_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.size_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.size_lbl.Location = new System.Drawing.Point(274, 155);
            this.size_lbl.Name = "size_lbl";
            this.size_lbl.Size = new System.Drawing.Size(88, 20);
            this.size_lbl.TabIndex = 15;
            this.size_lbl.Text = "Bilinmiyor";
            this.size_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fileextension_lbl
            // 
            this.fileextension_lbl.AutoSize = true;
            this.fileextension_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileextension_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileextension_lbl.Location = new System.Drawing.Point(274, 111);
            this.fileextension_lbl.Name = "fileextension_lbl";
            this.fileextension_lbl.Size = new System.Drawing.Size(35, 20);
            this.fileextension_lbl.TabIndex = 14;
            this.fileextension_lbl.Text = ".rtf";
            this.fileextension_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // filetype_lbl
            // 
            this.filetype_lbl.AutoSize = true;
            this.filetype_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filetype_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filetype_lbl.Location = new System.Drawing.Point(274, 68);
            this.filetype_lbl.Name = "filetype_lbl";
            this.filetype_lbl.Size = new System.Drawing.Size(177, 20);
            this.filetype_lbl.TabIndex = 13;
            this.filetype_lbl.Text = "Zengin Metin Belgesi\r\n";
            this.filetype_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // general_lbl
            // 
            this.general_lbl.AutoSize = true;
            this.general_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.general_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.general_lbl.Location = new System.Drawing.Point(9, 63);
            this.general_lbl.Name = "general_lbl";
            this.general_lbl.Size = new System.Drawing.Size(128, 220);
            this.general_lbl.TabIndex = 12;
            this.general_lbl.Text = "Tür:\r\n\r\nDosya Uzantısı:\r\n\r\nBoyut:\r\n\r\nKonum:\r\n\r\nŞablon:\r\n\r\nKodlama Türü:";
            // 
            // statisticsMenu
            // 
            this.statisticsMenu.Controls.Add(this.characters_lbl);
            this.statisticsMenu.Controls.Add(this.words_lbl);
            this.statisticsMenu.Controls.Add(this.lines_lbl);
            this.statisticsMenu.Controls.Add(this.pages_lbl);
            this.statisticsMenu.Controls.Add(this.statistics_lbl);
            this.statisticsMenu.Controls.Add(this.fileicon_img);
            this.statisticsMenu.Controls.Add(this.filename_lbl);
            this.statisticsMenu.Location = new System.Drawing.Point(11, 112);
            this.statisticsMenu.Name = "statisticsMenu";
            this.statisticsMenu.Size = new System.Drawing.Size(774, 342);
            this.statisticsMenu.TabIndex = 14;
            // 
            // characters_lbl
            // 
            this.characters_lbl.AutoSize = true;
            this.characters_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.characters_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.characters_lbl.Location = new System.Drawing.Point(212, 186);
            this.characters_lbl.Name = "characters_lbl";
            this.characters_lbl.Size = new System.Drawing.Size(22, 21);
            this.characters_lbl.TabIndex = 16;
            this.characters_lbl.Text = "0";
            this.characters_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // words_lbl
            // 
            this.words_lbl.AutoSize = true;
            this.words_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.words_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.words_lbl.Location = new System.Drawing.Point(213, 145);
            this.words_lbl.Name = "words_lbl";
            this.words_lbl.Size = new System.Drawing.Size(22, 21);
            this.words_lbl.TabIndex = 15;
            this.words_lbl.Text = "0";
            this.words_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lines_lbl
            // 
            this.lines_lbl.AutoSize = true;
            this.lines_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lines_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lines_lbl.Location = new System.Drawing.Point(213, 103);
            this.lines_lbl.Name = "lines_lbl";
            this.lines_lbl.Size = new System.Drawing.Size(22, 21);
            this.lines_lbl.TabIndex = 14;
            this.lines_lbl.Text = "0";
            this.lines_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pages_lbl
            // 
            this.pages_lbl.AutoSize = true;
            this.pages_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pages_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pages_lbl.Location = new System.Drawing.Point(213, 65);
            this.pages_lbl.Name = "pages_lbl";
            this.pages_lbl.Size = new System.Drawing.Size(22, 21);
            this.pages_lbl.TabIndex = 13;
            this.pages_lbl.Text = "0";
            this.pages_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statistics_lbl
            // 
            this.statistics_lbl.AutoSize = true;
            this.statistics_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statistics_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statistics_lbl.Location = new System.Drawing.Point(9, 63);
            this.statistics_lbl.Name = "statistics_lbl";
            this.statistics_lbl.Size = new System.Drawing.Size(99, 140);
            this.statistics_lbl.TabIndex = 12;
            this.statistics_lbl.Text = "Sayfalar:\r\n\r\nSatırlar:\r\n\r\nKelimeler:\r\n\r\nKarakterler:";
            // 
            // fileicon_img
            // 
            this.fileicon_img.Image = ((System.Drawing.Image)(resources.GetObject("fileicon_img.Image")));
            this.fileicon_img.Location = new System.Drawing.Point(5, 15);
            this.fileicon_img.Name = "fileicon_img";
            this.fileicon_img.Size = new System.Drawing.Size(50, 34);
            this.fileicon_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileicon_img.TabIndex = 3;
            this.fileicon_img.TabStop = false;
            // 
            // filename_lbl
            // 
            this.filename_lbl.AutoSize = true;
            this.filename_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filename_lbl.Location = new System.Drawing.Point(55, 22);
            this.filename_lbl.Name = "filename_lbl";
            this.filename_lbl.Size = new System.Drawing.Size(108, 21);
            this.filename_lbl.TabIndex = 11;
            this.filename_lbl.Text = "Adsız Belge";
            // 
            // settingsMenu
            // 
            this.settingsMenu.Controls.Add(this.filename_txt);
            this.settingsMenu.Controls.Add(this.plainorrichtext_cmb);
            this.settingsMenu.Controls.Add(this.help_btn);
            this.settingsMenu.Controls.Add(this.settings_lbl);
            this.settingsMenu.Controls.Add(this.fileicon3_lbl);
            this.settingsMenu.Controls.Add(this.filename3_lbl);
            this.settingsMenu.Location = new System.Drawing.Point(11, 111);
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(774, 342);
            this.settingsMenu.TabIndex = 15;
            // 
            // filename_txt
            // 
            this.filename_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.filename_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filename_txt.Font = new System.Drawing.Font("Wanted Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename_txt.ForeColor = System.Drawing.Color.White;
            this.filename_txt.Location = new System.Drawing.Point(423, 116);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.Size = new System.Drawing.Size(189, 22);
            this.filename_txt.TabIndex = 14;
            this.filename_txt.Text = "Adsız Belge";
            this.filename_txt.TextChanged += new System.EventHandler(this.filename_txt_TextChanged);
            // 
            // plainorrichtext_cmb
            // 
            this.plainorrichtext_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.plainorrichtext_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plainorrichtext_cmb.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plainorrichtext_cmb.ForeColor = System.Drawing.Color.White;
            this.plainorrichtext_cmb.FormattingEnabled = true;
            this.plainorrichtext_cmb.Items.AddRange(new object[] {
            "RichText",
            "PlainText",
            "UnicodeText"});
            this.plainorrichtext_cmb.Location = new System.Drawing.Point(445, 59);
            this.plainorrichtext_cmb.Name = "plainorrichtext_cmb";
            this.plainorrichtext_cmb.Size = new System.Drawing.Size(167, 28);
            this.plainorrichtext_cmb.TabIndex = 13;
            this.plainorrichtext_cmb.Text = "RichText";
            this.plainorrichtext_cmb.SelectedIndexChanged += new System.EventHandler(this.plainorrichtext_cmb_SelectedIndexChanged);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.help_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.help_btn.BorderRadius = 10;
            this.help_btn.BorderSize = 0;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(5, 155);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(158, 40);
            this.help_btn.TabIndex = 11;
            this.help_btn.Text = "Yardım";
            this.help_btn.UseVisualStyleBackColor = false;
            // 
            // settings_lbl
            // 
            this.settings_lbl.AutoSize = true;
            this.settings_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_lbl.Location = new System.Drawing.Point(9, 63);
            this.settings_lbl.Name = "settings_lbl";
            this.settings_lbl.Size = new System.Drawing.Size(321, 60);
            this.settings_lbl.TabIndex = 12;
            this.settings_lbl.Text = "Kaydedilirken Kullanılacak Kodlama Türü:\r\n\r\nDosya Adını Değiştir:";
            // 
            // fileicon3_lbl
            // 
            this.fileicon3_lbl.Image = ((System.Drawing.Image)(resources.GetObject("fileicon3_lbl.Image")));
            this.fileicon3_lbl.Location = new System.Drawing.Point(5, 15);
            this.fileicon3_lbl.Name = "fileicon3_lbl";
            this.fileicon3_lbl.Size = new System.Drawing.Size(50, 34);
            this.fileicon3_lbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileicon3_lbl.TabIndex = 3;
            this.fileicon3_lbl.TabStop = false;
            // 
            // filename3_lbl
            // 
            this.filename3_lbl.AutoSize = true;
            this.filename3_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename3_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filename3_lbl.Location = new System.Drawing.Point(55, 22);
            this.filename3_lbl.Name = "filename3_lbl";
            this.filename3_lbl.Size = new System.Drawing.Size(108, 21);
            this.filename3_lbl.TabIndex = 11;
            this.filename3_lbl.Text = "Adsız Belge";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Location = new System.Drawing.Point(-12, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(817, 411);
            this.backgroundPanel.TabIndex = 16;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fileInfo_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.settingsMenu);
            this.Controls.Add(this.statisticsMenu);
            this.Controls.Add(this.generalMenu);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fileInfo_window";
            this.Text = "opentypr - Dosya Bilgileri";
            this.Load += new System.EventHandler(this.fileInfo_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highlight_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon2_img)).EndInit();
            this.generalMenu.ResumeLayout(false);
            this.generalMenu.PerformLayout();
            this.statisticsMenu.ResumeLayout(false);
            this.statisticsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon_img)).EndInit();
            this.settingsMenu.ResumeLayout(false);
            this.settingsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileicon3_lbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.Panel topMenu;
        private Modules.CustomButtons close_btn;
        private System.Windows.Forms.PictureBox highlight_img;
        private System.Windows.Forms.Timer anim_timer;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox fileicon2_img;
        private System.Windows.Forms.Label filename2_lbl;
        private System.Windows.Forms.Panel generalMenu;
        private System.Windows.Forms.Label general_lbl;
        private System.Windows.Forms.Label filetype_lbl;
        private System.Windows.Forms.Panel statisticsMenu;
        private System.Windows.Forms.Label pages_lbl;
        private System.Windows.Forms.Label statistics_lbl;
        private System.Windows.Forms.PictureBox fileicon_img;
        private System.Windows.Forms.Label filename_lbl;
        private System.Windows.Forms.Panel settingsMenu;
        private System.Windows.Forms.Label settings_lbl;
        private System.Windows.Forms.PictureBox fileicon3_lbl;
        private System.Windows.Forms.Label filename3_lbl;
        private System.Windows.Forms.TextBox filename_txt;
        private System.Windows.Forms.ComboBox plainorrichtext_cmb;
        private Modules.CustomButtons help_btn;
        private System.Windows.Forms.Label plainorrichtext_lbl;
        private System.Windows.Forms.Label template_lbl;
        private System.Windows.Forms.Label filelocation_lbl;
        private System.Windows.Forms.Label size_lbl;
        private System.Windows.Forms.Label fileextension_lbl;
        private System.Windows.Forms.Label characters_lbl;
        private System.Windows.Forms.Label words_lbl;
        private System.Windows.Forms.Label lines_lbl;
        private Modules.CustomButtons settings_btn;
        private Modules.CustomButtons statistics_btn;
        private Modules.CustomButtons general_btn;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}