namespace opentypr
{
    partial class mainwindow
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.fileName_lbl = new System.Windows.Forms.Label();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.menu_highlight = new System.Windows.Forms.PictureBox();
            this.anim_timer = new System.Windows.Forms.Timer(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.txtboxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.main_textbox = new opentypr.Modules.AdvancedTextBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.topMenu = new System.Windows.Forms.Panel();
            this.helpParent_btn = new opentypr.Modules.CustomButtons();
            this.settings_btn = new opentypr.Modules.CustomButtons();
            this.appearance_btn = new opentypr.Modules.CustomButtons();
            this.edit_btn = new opentypr.Modules.CustomButtons();
            this.add_btn = new opentypr.Modules.CustomButtons();
            this.toolbar_btn = new opentypr.Modules.CustomButtons();
            this.windowCtrlMenu = new opentypr.Modules.CustomPanels();
            this.minimize_btn = new opentypr.Modules.CustomButtons();
            this.close_btn = new opentypr.Modules.CustomButtons();
            this.maximize_btn = new opentypr.Modules.CustomButtons();
            this.file_btn = new opentypr.Modules.CustomButtons();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.searchMenu = new opentypr.Modules.CustomPanels();
            this.search_txtBox = new System.Windows.Forms.TextBox();
            this.closeSearch_btn = new opentypr.Modules.CustomButtons();
            this.search_btn = new opentypr.Modules.CustomButtons();
            this.exportMenu = new opentypr.Modules.CustomPanels();
            this.toRTF_btn = new opentypr.Modules.CustomButtons();
            this.toDOCX_btn = new opentypr.Modules.CustomButtons();
            this.toPDF_btn = new opentypr.Modules.CustomButtons();
            this.shareMenu = new opentypr.Modules.CustomPanels();
            this.email_btn = new opentypr.Modules.CustomButtons();
            this.toTeams_btn = new opentypr.Modules.CustomButtons();
            this.saveMenu = new opentypr.Modules.CustomPanels();
            this.saveAs_btn = new opentypr.Modules.CustomButtons();
            this.save_btn = new opentypr.Modules.CustomButtons();
            this.openMenu = new opentypr.Modules.CustomPanels();
            this.dropfile_btn = new opentypr.Modules.CustomButtons();
            this.selectfile_btn = new opentypr.Modules.CustomButtons();
            this.newMenu = new opentypr.Modules.CustomPanels();
            this.template_btn = new opentypr.Modules.CustomButtons();
            this.emptyDoc_btn = new opentypr.Modules.CustomButtons();
            this.highlightColorSelectMenu = new opentypr.Modules.CustomPanels();
            this.closeHighlight_btn = new opentypr.Modules.CustomButtons();
            this.highlightWhite_btn = new opentypr.Modules.CustomButtons();
            this.highlightPink_btn = new opentypr.Modules.CustomButtons();
            this.highlightPurple_btn = new opentypr.Modules.CustomButtons();
            this.highlightDarkBlue_btn = new opentypr.Modules.CustomButtons();
            this.highlightBlue_btn = new opentypr.Modules.CustomButtons();
            this.highlightTurquoise_btn = new opentypr.Modules.CustomButtons();
            this.highlightLime_btn = new opentypr.Modules.CustomButtons();
            this.highlightSeaGreen_btn = new opentypr.Modules.CustomButtons();
            this.highlightLightGreen_btn = new opentypr.Modules.CustomButtons();
            this.highlightYellow_btn = new opentypr.Modules.CustomButtons();
            this.highlightOrange_btn = new opentypr.Modules.CustomButtons();
            this.highlightRed_btn = new opentypr.Modules.CustomButtons();
            this.highlightBlue_lbl = new System.Windows.Forms.Label();
            this.highlightGreen_lbl = new System.Windows.Forms.Label();
            this.highlightRed_lbl = new System.Windows.Forms.Label();
            this.highlightColorMenuIndicator = new System.Windows.Forms.Label();
            this.highlightBlueValue_lbl = new System.Windows.Forms.TextBox();
            this.highlightGreenValue_lbl = new System.Windows.Forms.TextBox();
            this.highlightRedValue_lbl = new System.Windows.Forms.TextBox();
            this.highlightSelectColor_btn = new opentypr.Modules.CustomButtons();
            this.textColorSelectMenu = new opentypr.Modules.CustomPanels();
            this.textColorWhite_btn = new opentypr.Modules.CustomButtons();
            this.textColorPink_btn = new opentypr.Modules.CustomButtons();
            this.textColorPurple_btn = new opentypr.Modules.CustomButtons();
            this.textColorDarkBlue_btn = new opentypr.Modules.CustomButtons();
            this.textColorBlue_btn = new opentypr.Modules.CustomButtons();
            this.textColorTurqoise_btn = new opentypr.Modules.CustomButtons();
            this.textColorLime_btn = new opentypr.Modules.CustomButtons();
            this.textColorSeaGreen_btn = new opentypr.Modules.CustomButtons();
            this.textColorLightGreen_btn = new opentypr.Modules.CustomButtons();
            this.textColorYellow_btn = new opentypr.Modules.CustomButtons();
            this.textColorOrange_btn = new opentypr.Modules.CustomButtons();
            this.textColorRed_btn = new opentypr.Modules.CustomButtons();
            this.textColorBlue_lbl = new System.Windows.Forms.Label();
            this.textColorGreen_lbl = new System.Windows.Forms.Label();
            this.textColorRed_lbl = new System.Windows.Forms.Label();
            this.textColorMenuIndicator = new System.Windows.Forms.Label();
            this.textColorBlueValue_lbl = new System.Windows.Forms.TextBox();
            this.textColorGreenValue_lbl = new System.Windows.Forms.TextBox();
            this.textColorRedValue_lbl = new System.Windows.Forms.TextBox();
            this.textColorSelectColor_btn = new opentypr.Modules.CustomButtons();
            this.findMenu = new opentypr.Modules.CustomPanels();
            this.find_txt = new System.Windows.Forms.TextBox();
            this.closeFind_btn = new opentypr.Modules.CustomButtons();
            this.find_btn = new opentypr.Modules.CustomButtons();
            this.helpMenu = new opentypr.Modules.CustomPanels();
            this.about_btn = new opentypr.Modules.CustomButtons();
            this.img_buffer = new System.Windows.Forms.PictureBox();
            this.reportBugs_btn = new opentypr.Modules.CustomButtons();
            this.help_btn = new opentypr.Modules.CustomButtons();
            this.fileMenu = new opentypr.Modules.CustomPanels();
            this.fileinfo_btn = new opentypr.Modules.CustomButtons();
            this.filename_btn = new opentypr.Modules.CustomButtons();
            this.fileLine2 = new System.Windows.Forms.PictureBox();
            this.print_btn = new opentypr.Modules.CustomButtons();
            this.export_btn = new opentypr.Modules.CustomButtons();
            this.share_btn = new opentypr.Modules.CustomButtons();
            this.fileLine1 = new System.Windows.Forms.PictureBox();
            this.saveparent_btn = new opentypr.Modules.CustomButtons();
            this.open_btn = new opentypr.Modules.CustomButtons();
            this.new_btn = new opentypr.Modules.CustomButtons();
            this.bulletListMenu = new opentypr.Modules.CustomPanels();
            this.bullet6_btn = new opentypr.Modules.CustomButtons();
            this.bullet4_btn = new opentypr.Modules.CustomButtons();
            this.bullet5_btn = new opentypr.Modules.CustomButtons();
            this.bullet2_btn = new opentypr.Modules.CustomButtons();
            this.bullet3_btn = new opentypr.Modules.CustomButtons();
            this.bullet1_btn = new opentypr.Modules.CustomButtons();
            this.lineSpacing_menu = new opentypr.Modules.CustomPanels();
            this.lineSpacing_lbl = new System.Windows.Forms.Label();
            this.lineSpacing_cmb = new System.Windows.Forms.ComboBox();
            this.pageColorMenu = new opentypr.Modules.CustomPanels();
            this.pageColorWhite_btn = new opentypr.Modules.CustomButtons();
            this.pageColorPink_btn = new opentypr.Modules.CustomButtons();
            this.pageColorPurple_btn = new opentypr.Modules.CustomButtons();
            this.pageColorDarkBlue_btn = new opentypr.Modules.CustomButtons();
            this.pageColorBlue_btn = new opentypr.Modules.CustomButtons();
            this.pageColorTurqoise_btn = new opentypr.Modules.CustomButtons();
            this.pageColorLime_btn = new opentypr.Modules.CustomButtons();
            this.pageColorSeaGreen_btn = new opentypr.Modules.CustomButtons();
            this.pageColorLightGreen_btn = new opentypr.Modules.CustomButtons();
            this.pageColorYellow_btn = new opentypr.Modules.CustomButtons();
            this.pageColorOrange_btn = new opentypr.Modules.CustomButtons();
            this.pageColorRed_btn = new opentypr.Modules.CustomButtons();
            this.pageColorBlue_lbl = new System.Windows.Forms.Label();
            this.pageColorGreen_lbl = new System.Windows.Forms.Label();
            this.pageColorRed_lbl = new System.Windows.Forms.Label();
            this.pageColorMenuIndicator = new System.Windows.Forms.Label();
            this.pageColorBlueValue_lbl = new System.Windows.Forms.TextBox();
            this.pageColorGreenValue_lbl = new System.Windows.Forms.TextBox();
            this.pageColorRedValue_lbl = new System.Windows.Forms.TextBox();
            this.pageColorSelectColor_btn = new opentypr.Modules.CustomButtons();
            this.statusBar = new opentypr.Modules.CustomPanels();
            this.subStatusBar = new System.Windows.Forms.Panel();
            this.statusBarZoom_lbl = new System.Windows.Forms.Label();
            this.statusBarZoom_trck = new System.Windows.Forms.TrackBar();
            this.numberOfCharacters_lbl = new System.Windows.Forms.Label();
            this.numberOfPages_lbl = new System.Windows.Forms.Label();
            this.OSandFormatting_lbl = new System.Windows.Forms.Label();
            this.rulerMenu = new opentypr.Modules.CustomPanels();
            this.subRulerMenu = new System.Windows.Forms.Panel();
            this.ruler = new System.Windows.Forms.TrackBar();
            this.appearenceMenu = new opentypr.Modules.CustomPanels();
            this.zoomMenu = new opentypr.Modules.CustomPanels();
            this.zoomDecrease_btn = new opentypr.Modules.CustomButtons();
            this.zoomIncrease_btn = new opentypr.Modules.CustomButtons();
            this.zoomTrackBar1 = new System.Windows.Forms.TrackBar();
            this.zoom_lbl = new System.Windows.Forms.Label();
            this.apprLine3 = new System.Windows.Forms.PictureBox();
            this.darkTheme_btn = new opentypr.Modules.CustomButtons();
            this.lightTheme_btn = new opentypr.Modules.CustomButtons();
            this.theme_lbl = new System.Windows.Forms.Label();
            this.apprLine2 = new System.Windows.Forms.PictureBox();
            this.zoomcategory_lbl = new System.Windows.Forms.Label();
            this.defaultZoom_btn = new opentypr.Modules.CustomButtons();
            this.zoom_btn = new opentypr.Modules.CustomButtons();
            this.apprLine1 = new System.Windows.Forms.PictureBox();
            this.statusbar_btn = new opentypr.Modules.CustomButtons();
            this.ruler_btn = new opentypr.Modules.CustomButtons();
            this.show_lbl = new System.Windows.Forms.Label();
            this.toolbarMenu = new opentypr.Modules.CustomPanels();
            this.textTemplatesMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultTextTemplate_btn = new opentypr.Modules.CustomButtons();
            this.bodyText_btn = new opentypr.Modules.CustomButtons();
            this.title1_btn = new opentypr.Modules.CustomButtons();
            this.title2_btn = new opentypr.Modules.CustomButtons();
            this.subtitle_btn = new opentypr.Modules.CustomButtons();
            this.searchParent_btn = new opentypr.Modules.CustomButtons();
            this.findParent_btn = new opentypr.Modules.CustomButtons();
            this.subscript_btn = new opentypr.Modules.CustomButtons();
            this.superscript_btn = new opentypr.Modules.CustomButtons();
            this.lock_btn = new opentypr.Modules.CustomButtons();
            this.lineGap_btn = new opentypr.Modules.CustomButtons();
            this.unlock_btn = new opentypr.Modules.CustomButtons();
            this.increaseIndent_btn = new opentypr.Modules.CustomButtons();
            this.decreaseIndent_btn = new opentypr.Modules.CustomButtons();
            this.bulletList_btn = new opentypr.Modules.CustomButtons();
            this.alignToRight_btn = new opentypr.Modules.CustomButtons();
            this.alignToMiddle_btn = new opentypr.Modules.CustomButtons();
            this.alignToLeft_btn = new opentypr.Modules.CustomButtons();
            this.characterGap_btn = new opentypr.Modules.CustomButtons();
            this.deleteForming_btn = new opentypr.Modules.CustomButtons();
            this.highlightColorIndicator = new System.Windows.Forms.PictureBox();
            this.highlight_btn = new opentypr.Modules.CustomButtons();
            this.decreaseFontSize_btn = new opentypr.Modules.CustomButtons();
            this.increaseFontSize_btn = new opentypr.Modules.CustomButtons();
            this.textColorIndicator = new System.Windows.Forms.PictureBox();
            this.textcolor_btn = new opentypr.Modules.CustomButtons();
            this.strikethrough_btn = new opentypr.Modules.CustomButtons();
            this.underlined_btn = new opentypr.Modules.CustomButtons();
            this.italic_btn = new opentypr.Modules.CustomButtons();
            this.bold_btn = new opentypr.Modules.CustomButtons();
            this.fontSizeSelector_cmb = new System.Windows.Forms.ComboBox();
            this.fontSelector_cmb = new System.Windows.Forms.ComboBox();
            this.toolsLine5 = new System.Windows.Forms.PictureBox();
            this.textTemplates_lbl = new System.Windows.Forms.Label();
            this.toolsLine4 = new System.Windows.Forms.PictureBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.toolsLine3 = new System.Windows.Forms.PictureBox();
            this.paragraph_lbl = new System.Windows.Forms.Label();
            this.toolsLine2 = new System.Windows.Forms.PictureBox();
            this.font_lbl = new System.Windows.Forms.Label();
            this.select_btn = new opentypr.Modules.CustomButtons();
            this.selectall_btn = new opentypr.Modules.CustomButtons();
            this.redo_btn = new opentypr.Modules.CustomButtons();
            this.undo_btn = new opentypr.Modules.CustomButtons();
            this.toolsLine1 = new System.Windows.Forms.PictureBox();
            this.general_lbl = new System.Windows.Forms.Label();
            this.cut_btn = new opentypr.Modules.CustomButtons();
            this.copy_btn = new opentypr.Modules.CustomButtons();
            this.paste_btn = new opentypr.Modules.CustomButtons();
            this.editMenu = new opentypr.Modules.CustomPanels();
            this.editLine3 = new System.Windows.Forms.PictureBox();
            this.detectLinks_btn = new opentypr.Modules.CustomButtons();
            this.refresh_btn = new opentypr.Modules.CustomButtons();
            this.draganddropEnabled_btn = new opentypr.Modules.CustomButtons();
            this.otherEdit_lbl = new System.Windows.Forms.Label();
            this.editLine2 = new System.Windows.Forms.PictureBox();
            this.indentSize_btn = new opentypr.Modules.CustomButtons();
            this.pageColor_btn = new opentypr.Modules.CustomButtons();
            this.appearancePage_lbl = new System.Windows.Forms.Label();
            this.editLine1 = new System.Windows.Forms.PictureBox();
            this.horizontalPage_btn = new opentypr.Modules.CustomButtons();
            this.verticalPage_btn = new opentypr.Modules.CustomButtons();
            this.pageSize_btn = new opentypr.Modules.CustomButtons();
            this.page_lbl = new System.Windows.Forms.Label();
            this.addMenu = new opentypr.Modules.CustomPanels();
            this.addReferenceNoMenu = new opentypr.Modules.CustomPanels();
            this.number_lbl = new System.Windows.Forms.Label();
            this.referenceNo_txt = new System.Windows.Forms.TextBox();
            this.addReferenceNo_btn = new opentypr.Modules.CustomButtons();
            this.addLine4 = new System.Windows.Forms.PictureBox();
            this.addNote_btn = new opentypr.Modules.CustomButtons();
            this.addReferenceNoParent_btn = new opentypr.Modules.CustomButtons();
            this.addReference_btn = new opentypr.Modules.CustomButtons();
            this.reference_lbl = new System.Windows.Forms.Label();
            this.addLine3 = new System.Windows.Forms.PictureBox();
            this.media_lbl = new System.Windows.Forms.Label();
            this.addTable_btn = new opentypr.Modules.CustomButtons();
            this.addVideo_btn = new opentypr.Modules.CustomButtons();
            this.addImage_btn = new opentypr.Modules.CustomButtons();
            this.addLine2 = new System.Windows.Forms.PictureBox();
            this.addEquation_btn = new opentypr.Modules.CustomButtons();
            this.addSymbol_btn = new opentypr.Modules.CustomButtons();
            this.addEmoji_btn = new opentypr.Modules.CustomButtons();
            this.textAdd_lbl = new System.Windows.Forms.Label();
            this.addLink_btn = new opentypr.Modules.CustomButtons();
            this.addLine1 = new System.Windows.Forms.PictureBox();
            this.dateandtime_lbl = new System.Windows.Forms.Label();
            this.dateandtime_btn = new opentypr.Modules.CustomButtons();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_highlight)).BeginInit();
            this.txtboxPanel.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.windowCtrlMenu.SuspendLayout();
            this.searchMenu.SuspendLayout();
            this.exportMenu.SuspendLayout();
            this.shareMenu.SuspendLayout();
            this.saveMenu.SuspendLayout();
            this.openMenu.SuspendLayout();
            this.newMenu.SuspendLayout();
            this.highlightColorSelectMenu.SuspendLayout();
            this.textColorSelectMenu.SuspendLayout();
            this.findMenu.SuspendLayout();
            this.helpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_buffer)).BeginInit();
            this.fileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileLine1)).BeginInit();
            this.bulletListMenu.SuspendLayout();
            this.lineSpacing_menu.SuspendLayout();
            this.pageColorMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.subStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarZoom_trck)).BeginInit();
            this.rulerMenu.SuspendLayout();
            this.subRulerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruler)).BeginInit();
            this.appearenceMenu.SuspendLayout();
            this.zoomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine1)).BeginInit();
            this.toolbarMenu.SuspendLayout();
            this.textTemplatesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highlightColorIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textColorIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine1)).BeginInit();
            this.editMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLine1)).BeginInit();
            this.addMenu.SuspendLayout();
            this.addReferenceNoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileName_lbl
            // 
            this.fileName_lbl.AutoSize = true;
            this.fileName_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileName_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileName_lbl.Location = new System.Drawing.Point(137, 19);
            this.fileName_lbl.Name = "fileName_lbl";
            this.fileName_lbl.Size = new System.Drawing.Size(129, 24);
            this.fileName_lbl.TabIndex = 4;
            this.fileName_lbl.Text = "| Adsız Belge";
            // 
            // logo_img
            // 
            this.logo_img.Image = ((System.Drawing.Image)(resources.GetObject("logo_img.Image")));
            this.logo_img.Location = new System.Drawing.Point(-21, 7);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(194, 50);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 0;
            this.logo_img.TabStop = false;
            // 
            // menu_highlight
            // 
            this.menu_highlight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_highlight.BackgroundImage")));
            this.menu_highlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_highlight.Location = new System.Drawing.Point(206, 98);
            this.menu_highlight.Name = "menu_highlight";
            this.menu_highlight.Size = new System.Drawing.Size(80, 3);
            this.menu_highlight.TabIndex = 3;
            this.menu_highlight.TabStop = false;
            // 
            // anim_timer
            // 
            this.anim_timer.Interval = 1;
            this.anim_timer.Tick += new System.EventHandler(this.anim_timer_Tick);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // txtboxPanel
            // 
            this.txtboxPanel.AutoScroll = true;
            this.txtboxPanel.Controls.Add(this.main_textbox);
            this.txtboxPanel.Location = new System.Drawing.Point(1, 283);
            this.txtboxPanel.Name = "txtboxPanel";
            this.txtboxPanel.Padding = new System.Windows.Forms.Padding(200, 50, 0, 0);
            this.txtboxPanel.Size = new System.Drawing.Size(1712, 579);
            this.txtboxPanel.TabIndex = 17;
            // 
            // main_textbox
            // 
            this.main_textbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.main_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.main_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_textbox.BulletStyle = opentypr.Modules.AdvancedTextBox.AdvRichTextBulletStyle.NoNumber;
            this.main_textbox.BulletType = opentypr.Modules.AdvancedTextBox.AdvRichTextBulletType.Normal;
            this.main_textbox.EnableAutoDragDrop = true;
            this.main_textbox.Font = new System.Drawing.Font("Wanted Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.main_textbox.ForeColor = System.Drawing.Color.White;
            this.main_textbox.HideSelection = false;
            this.main_textbox.Location = new System.Drawing.Point(203, 53);
            this.main_textbox.Name = "main_textbox";
            this.main_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.main_textbox.Size = new System.Drawing.Size(1554, 496);
            this.main_textbox.TabIndex = 16;
            this.main_textbox.Text = "";
            this.main_textbox.Click += new System.EventHandler(this.main_textbox_Click);
            this.main_textbox.TextChanged += new System.EventHandler(this.main_textbox_TextChanged);
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // topMenu
            // 
            this.topMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.topMenu.Controls.Add(this.helpParent_btn);
            this.topMenu.Controls.Add(this.settings_btn);
            this.topMenu.Controls.Add(this.appearance_btn);
            this.topMenu.Controls.Add(this.edit_btn);
            this.topMenu.Controls.Add(this.add_btn);
            this.topMenu.Controls.Add(this.toolbar_btn);
            this.topMenu.Controls.Add(this.fileName_lbl);
            this.topMenu.Controls.Add(this.windowCtrlMenu);
            this.topMenu.Controls.Add(this.file_btn);
            this.topMenu.Controls.Add(this.logo_img);
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1732, 111);
            this.topMenu.TabIndex = 0;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            // 
            // helpParent_btn
            // 
            this.helpParent_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.helpParent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.helpParent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.helpParent_btn.BorderRadius = 10;
            this.helpParent_btn.BorderSize = 0;
            this.helpParent_btn.Enabled = false;
            this.helpParent_btn.FlatAppearance.BorderSize = 0;
            this.helpParent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpParent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpParent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.helpParent_btn.Location = new System.Drawing.Point(1215, 63);
            this.helpParent_btn.Name = "helpParent_btn";
            this.helpParent_btn.Size = new System.Drawing.Size(137, 40);
            this.helpParent_btn.TabIndex = 10;
            this.helpParent_btn.Text = "Yardım";
            this.helpParent_btn.UseVisualStyleBackColor = false;
            // 
            // settings_btn
            // 
            this.settings_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.settings_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.settings_btn.BorderRadius = 10;
            this.settings_btn.BorderSize = 0;
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_btn.ForeColor = System.Drawing.Color.LightGray;
            this.settings_btn.Location = new System.Drawing.Point(1060, 63);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(137, 40);
            this.settings_btn.TabIndex = 9;
            this.settings_btn.Text = "Ayarlar";
            this.settings_btn.UseVisualStyleBackColor = false;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // appearance_btn
            // 
            this.appearance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.appearance_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.appearance_btn.BorderRadius = 10;
            this.appearance_btn.BorderSize = 0;
            this.appearance_btn.FlatAppearance.BorderSize = 0;
            this.appearance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appearance_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appearance_btn.ForeColor = System.Drawing.Color.LightGray;
            this.appearance_btn.Location = new System.Drawing.Point(613, 63);
            this.appearance_btn.Name = "appearance_btn";
            this.appearance_btn.Size = new System.Drawing.Size(137, 40);
            this.appearance_btn.TabIndex = 8;
            this.appearance_btn.Text = "Görünüm";
            this.appearance_btn.UseVisualStyleBackColor = true;
            this.appearance_btn.Click += new System.EventHandler(this.appearance_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.edit_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.edit_btn.BorderRadius = 10;
            this.edit_btn.BorderSize = 0;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_btn.ForeColor = System.Drawing.Color.LightGray;
            this.edit_btn.Location = new System.Drawing.Point(470, 63);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(137, 40);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Düzenle";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.add_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.add_btn.BorderRadius = 10;
            this.add_btn.BorderSize = 0;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_btn.ForeColor = System.Drawing.Color.LightGray;
            this.add_btn.Location = new System.Drawing.Point(339, 63);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(125, 40);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Ekle";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // toolbar_btn
            // 
            this.toolbar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.toolbar_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.toolbar_btn.BorderRadius = 10;
            this.toolbar_btn.BorderSize = 0;
            this.toolbar_btn.FlatAppearance.BorderSize = 0;
            this.toolbar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolbar_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolbar_btn.ForeColor = System.Drawing.Color.White;
            this.toolbar_btn.Location = new System.Drawing.Point(165, 63);
            this.toolbar_btn.Name = "toolbar_btn";
            this.toolbar_btn.Size = new System.Drawing.Size(168, 40);
            this.toolbar_btn.TabIndex = 5;
            this.toolbar_btn.Text = "Araç Çubuğu";
            this.toolbar_btn.UseVisualStyleBackColor = true;
            this.toolbar_btn.Click += new System.EventHandler(this.toolbar_btn_Click);
            // 
            // windowCtrlMenu
            // 
            this.windowCtrlMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.windowCtrlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.windowCtrlMenu.BorderColor = System.Drawing.Color.White;
            this.windowCtrlMenu.BorderRadius = 15;
            this.windowCtrlMenu.BorderSize = 0;
            this.windowCtrlMenu.Controls.Add(this.minimize_btn);
            this.windowCtrlMenu.Controls.Add(this.close_btn);
            this.windowCtrlMenu.Controls.Add(this.maximize_btn);
            this.windowCtrlMenu.ForeColor = System.Drawing.Color.White;
            this.windowCtrlMenu.Location = new System.Drawing.Point(1270, 12);
            this.windowCtrlMenu.Name = "windowCtrlMenu";
            this.windowCtrlMenu.Size = new System.Drawing.Size(80, 40);
            this.windowCtrlMenu.TabIndex = 3;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.minimize_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize_btn.BackgroundImage")));
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_btn.BorderColor = System.Drawing.Color.White;
            this.minimize_btn.BorderRadius = 6;
            this.minimize_btn.BorderSize = 0;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(9, 6);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 30);
            this.minimize_btn.TabIndex = 0;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btn.BackgroundImage")));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.BorderColor = System.Drawing.Color.White;
            this.close_btn.BorderRadius = 6;
            this.close_btn.BorderSize = 0;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(47, 6);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 30);
            this.close_btn.TabIndex = 2;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.maximize_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize_btn.BackgroundImage")));
            this.maximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximize_btn.BorderColor = System.Drawing.Color.White;
            this.maximize_btn.BorderRadius = 6;
            this.maximize_btn.BorderSize = 0;
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(51, 6);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(32, 30);
            this.maximize_btn.TabIndex = 1;
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Visible = false;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // file_btn
            // 
            this.file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.file_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.file_btn.BorderRadius = 10;
            this.file_btn.BorderSize = 0;
            this.file_btn.FlatAppearance.BorderSize = 0;
            this.file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.file_btn.ForeColor = System.Drawing.Color.LightGray;
            this.file_btn.Location = new System.Drawing.Point(13, 63);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(146, 40);
            this.file_btn.TabIndex = 2;
            this.file_btn.Text = "Dosya";
            this.file_btn.UseVisualStyleBackColor = true;
            this.file_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Location = new System.Drawing.Point(-1, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(3000, 1500);
            this.backgroundPanel.TabIndex = 69;
            // 
            // searchMenu
            // 
            this.searchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchMenu.BorderColor = System.Drawing.Color.White;
            this.searchMenu.BorderRadius = 15;
            this.searchMenu.BorderSize = 0;
            this.searchMenu.Controls.Add(this.search_txtBox);
            this.searchMenu.Controls.Add(this.closeSearch_btn);
            this.searchMenu.Controls.Add(this.search_btn);
            this.searchMenu.ForeColor = System.Drawing.Color.White;
            this.searchMenu.Location = new System.Drawing.Point(550, 258);
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(787, 50);
            this.searchMenu.TabIndex = 59;
            this.searchMenu.Visible = false;
            // 
            // search_txtBox
            // 
            this.search_txtBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Dosya Menüsü",
            "Araç Çubuğu",
            "Ekle",
            "Düzenle",
            "Görünüm",
            "İstatistikler",
            "Ayarlar",
            "Dosya Bilgileri"});
            this.search_txtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_txtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.search_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txtBox.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_txtBox.ForeColor = System.Drawing.Color.White;
            this.search_txtBox.Location = new System.Drawing.Point(17, 15);
            this.search_txtBox.Name = "search_txtBox";
            this.search_txtBox.Size = new System.Drawing.Size(574, 24);
            this.search_txtBox.TabIndex = 57;
            // 
            // closeSearch_btn
            // 
            this.closeSearch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeSearch_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeSearch_btn.BackgroundImage")));
            this.closeSearch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeSearch_btn.BorderColor = System.Drawing.Color.White;
            this.closeSearch_btn.BorderRadius = 6;
            this.closeSearch_btn.BorderSize = 0;
            this.closeSearch_btn.FlatAppearance.BorderSize = 0;
            this.closeSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSearch_btn.ForeColor = System.Drawing.Color.White;
            this.closeSearch_btn.Location = new System.Drawing.Point(749, 11);
            this.closeSearch_btn.Name = "closeSearch_btn";
            this.closeSearch_btn.Size = new System.Drawing.Size(32, 30);
            this.closeSearch_btn.TabIndex = 57;
            this.closeSearch_btn.UseVisualStyleBackColor = false;
            this.closeSearch_btn.Click += new System.EventHandler(this.closeSearch_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.search_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.search_btn.BorderRadius = 7;
            this.search_btn.BorderSize = 0;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_btn.ForeColor = System.Drawing.Color.LightGray;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(615, 8);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(131, 35);
            this.search_btn.TabIndex = 55;
            this.search_btn.Text = "        Ara";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // exportMenu
            // 
            this.exportMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.exportMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.exportMenu.BorderRadius = 10;
            this.exportMenu.BorderSize = 0;
            this.exportMenu.Controls.Add(this.toRTF_btn);
            this.exportMenu.Controls.Add(this.toDOCX_btn);
            this.exportMenu.Controls.Add(this.toPDF_btn);
            this.exportMenu.ForeColor = System.Drawing.Color.White;
            this.exportMenu.Location = new System.Drawing.Point(268, 294);
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.Size = new System.Drawing.Size(287, 135);
            this.exportMenu.TabIndex = 14;
            this.exportMenu.Visible = false;
            // 
            // toRTF_btn
            // 
            this.toRTF_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.toRTF_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toRTF_btn.BackgroundImage")));
            this.toRTF_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toRTF_btn.BorderColor = System.Drawing.Color.White;
            this.toRTF_btn.BorderRadius = 10;
            this.toRTF_btn.BorderSize = 0;
            this.toRTF_btn.FlatAppearance.BorderSize = 0;
            this.toRTF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toRTF_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toRTF_btn.ForeColor = System.Drawing.Color.White;
            this.toRTF_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toRTF_btn.Location = new System.Drawing.Point(3, 88);
            this.toRTF_btn.Name = "toRTF_btn";
            this.toRTF_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.toRTF_btn.Size = new System.Drawing.Size(284, 43);
            this.toRTF_btn.TabIndex = 2;
            this.toRTF_btn.Text = "       rtf Olarak Aktar";
            this.toRTF_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toRTF_btn.UseVisualStyleBackColor = false;
            // 
            // toDOCX_btn
            // 
            this.toDOCX_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.toDOCX_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toDOCX_btn.BackgroundImage")));
            this.toDOCX_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toDOCX_btn.BorderColor = System.Drawing.Color.White;
            this.toDOCX_btn.BorderRadius = 10;
            this.toDOCX_btn.BorderSize = 0;
            this.toDOCX_btn.FlatAppearance.BorderSize = 0;
            this.toDOCX_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toDOCX_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toDOCX_btn.ForeColor = System.Drawing.Color.White;
            this.toDOCX_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toDOCX_btn.Location = new System.Drawing.Point(3, 47);
            this.toDOCX_btn.Name = "toDOCX_btn";
            this.toDOCX_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.toDOCX_btn.Size = new System.Drawing.Size(284, 43);
            this.toDOCX_btn.TabIndex = 1;
            this.toDOCX_btn.Text = "       docx Olarak Aktar";
            this.toDOCX_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toDOCX_btn.UseVisualStyleBackColor = false;
            // 
            // toPDF_btn
            // 
            this.toPDF_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.toPDF_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toPDF_btn.BackgroundImage")));
            this.toPDF_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toPDF_btn.BorderColor = System.Drawing.Color.White;
            this.toPDF_btn.BorderRadius = 10;
            this.toPDF_btn.BorderSize = 0;
            this.toPDF_btn.FlatAppearance.BorderSize = 0;
            this.toPDF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toPDF_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toPDF_btn.ForeColor = System.Drawing.Color.White;
            this.toPDF_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toPDF_btn.Location = new System.Drawing.Point(3, 4);
            this.toPDF_btn.Name = "toPDF_btn";
            this.toPDF_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.toPDF_btn.Size = new System.Drawing.Size(284, 43);
            this.toPDF_btn.TabIndex = 0;
            this.toPDF_btn.Text = "       pdf Olarak Aktar";
            this.toPDF_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toPDF_btn.UseVisualStyleBackColor = false;
            this.toPDF_btn.Click += new System.EventHandler(this.toPDF_btn_Click);
            // 
            // shareMenu
            // 
            this.shareMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.shareMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.shareMenu.BorderRadius = 10;
            this.shareMenu.BorderSize = 0;
            this.shareMenu.Controls.Add(this.email_btn);
            this.shareMenu.Controls.Add(this.toTeams_btn);
            this.shareMenu.ForeColor = System.Drawing.Color.White;
            this.shareMenu.Location = new System.Drawing.Point(266, 253);
            this.shareMenu.Name = "shareMenu";
            this.shareMenu.Size = new System.Drawing.Size(305, 96);
            this.shareMenu.TabIndex = 13;
            this.shareMenu.Visible = false;
            // 
            // email_btn
            // 
            this.email_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.email_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("email_btn.BackgroundImage")));
            this.email_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.email_btn.BorderColor = System.Drawing.Color.White;
            this.email_btn.BorderRadius = 10;
            this.email_btn.BorderSize = 0;
            this.email_btn.FlatAppearance.BorderSize = 0;
            this.email_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_btn.ForeColor = System.Drawing.Color.White;
            this.email_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.email_btn.Location = new System.Drawing.Point(3, 47);
            this.email_btn.Name = "email_btn";
            this.email_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.email_btn.Size = new System.Drawing.Size(302, 43);
            this.email_btn.TabIndex = 1;
            this.email_btn.Text = "       E-Posta Gönder";
            this.email_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.email_btn.UseVisualStyleBackColor = false;
            // 
            // toTeams_btn
            // 
            this.toTeams_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.toTeams_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toTeams_btn.BackgroundImage")));
            this.toTeams_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toTeams_btn.BorderColor = System.Drawing.Color.White;
            this.toTeams_btn.BorderRadius = 10;
            this.toTeams_btn.BorderSize = 0;
            this.toTeams_btn.FlatAppearance.BorderSize = 0;
            this.toTeams_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toTeams_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toTeams_btn.ForeColor = System.Drawing.Color.White;
            this.toTeams_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toTeams_btn.Location = new System.Drawing.Point(3, 4);
            this.toTeams_btn.Name = "toTeams_btn";
            this.toTeams_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.toTeams_btn.Size = new System.Drawing.Size(302, 43);
            this.toTeams_btn.TabIndex = 0;
            this.toTeams_btn.Text = "       Teams\'e gönder";
            this.toTeams_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toTeams_btn.UseVisualStyleBackColor = false;
            // 
            // saveMenu
            // 
            this.saveMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.saveMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.saveMenu.BorderRadius = 10;
            this.saveMenu.BorderSize = 0;
            this.saveMenu.Controls.Add(this.saveAs_btn);
            this.saveMenu.Controls.Add(this.save_btn);
            this.saveMenu.ForeColor = System.Drawing.Color.White;
            this.saveMenu.Location = new System.Drawing.Point(266, 205);
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(255, 96);
            this.saveMenu.TabIndex = 12;
            this.saveMenu.Visible = false;
            // 
            // saveAs_btn
            // 
            this.saveAs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.saveAs_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveAs_btn.BackgroundImage")));
            this.saveAs_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveAs_btn.BorderColor = System.Drawing.Color.White;
            this.saveAs_btn.BorderRadius = 10;
            this.saveAs_btn.BorderSize = 0;
            this.saveAs_btn.FlatAppearance.BorderSize = 0;
            this.saveAs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAs_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveAs_btn.ForeColor = System.Drawing.Color.White;
            this.saveAs_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAs_btn.Location = new System.Drawing.Point(3, 47);
            this.saveAs_btn.Name = "saveAs_btn";
            this.saveAs_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.saveAs_btn.Size = new System.Drawing.Size(248, 43);
            this.saveAs_btn.TabIndex = 1;
            this.saveAs_btn.Text = "       Farklı Kaydet";
            this.saveAs_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saveAs_btn.UseVisualStyleBackColor = false;
            this.saveAs_btn.Click += new System.EventHandler(this.saveAs_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_btn.BackgroundImage")));
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_btn.BorderColor = System.Drawing.Color.White;
            this.save_btn.BorderRadius = 10;
            this.save_btn.BorderSize = 0;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_btn.Location = new System.Drawing.Point(3, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.save_btn.Size = new System.Drawing.Size(248, 43);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "       Kaydet";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // openMenu
            // 
            this.openMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.openMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.openMenu.BorderRadius = 10;
            this.openMenu.BorderSize = 0;
            this.openMenu.Controls.Add(this.dropfile_btn);
            this.openMenu.Controls.Add(this.selectfile_btn);
            this.openMenu.ForeColor = System.Drawing.Color.White;
            this.openMenu.Location = new System.Drawing.Point(266, 164);
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(255, 96);
            this.openMenu.TabIndex = 11;
            this.openMenu.Visible = false;
            // 
            // dropfile_btn
            // 
            this.dropfile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dropfile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropfile_btn.BackgroundImage")));
            this.dropfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dropfile_btn.BorderColor = System.Drawing.Color.White;
            this.dropfile_btn.BorderRadius = 10;
            this.dropfile_btn.BorderSize = 0;
            this.dropfile_btn.FlatAppearance.BorderSize = 0;
            this.dropfile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dropfile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dropfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropfile_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dropfile_btn.ForeColor = System.Drawing.Color.White;
            this.dropfile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dropfile_btn.Location = new System.Drawing.Point(3, 47);
            this.dropfile_btn.Name = "dropfile_btn";
            this.dropfile_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.dropfile_btn.Size = new System.Drawing.Size(248, 43);
            this.dropfile_btn.TabIndex = 1;
            this.dropfile_btn.Text = "       Dosya Sürükle";
            this.dropfile_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dropfile_btn.UseVisualStyleBackColor = false;
            // 
            // selectfile_btn
            // 
            this.selectfile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.selectfile_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectfile_btn.BackgroundImage")));
            this.selectfile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectfile_btn.BorderColor = System.Drawing.Color.White;
            this.selectfile_btn.BorderRadius = 10;
            this.selectfile_btn.BorderSize = 0;
            this.selectfile_btn.FlatAppearance.BorderSize = 0;
            this.selectfile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.selectfile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.selectfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectfile_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectfile_btn.ForeColor = System.Drawing.Color.White;
            this.selectfile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectfile_btn.Location = new System.Drawing.Point(3, 4);
            this.selectfile_btn.Name = "selectfile_btn";
            this.selectfile_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.selectfile_btn.Size = new System.Drawing.Size(248, 43);
            this.selectfile_btn.TabIndex = 0;
            this.selectfile_btn.Text = "       Dosya Seç";
            this.selectfile_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.selectfile_btn.UseVisualStyleBackColor = false;
            this.selectfile_btn.Click += new System.EventHandler(this.selectfile_btn_Click);
            // 
            // newMenu
            // 
            this.newMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.newMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.newMenu.BorderRadius = 10;
            this.newMenu.BorderSize = 0;
            this.newMenu.Controls.Add(this.template_btn);
            this.newMenu.Controls.Add(this.emptyDoc_btn);
            this.newMenu.ForeColor = System.Drawing.Color.White;
            this.newMenu.Location = new System.Drawing.Point(266, 110);
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(255, 96);
            this.newMenu.TabIndex = 10;
            this.newMenu.Visible = false;
            // 
            // template_btn
            // 
            this.template_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.template_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("template_btn.BackgroundImage")));
            this.template_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.template_btn.BorderColor = System.Drawing.Color.White;
            this.template_btn.BorderRadius = 10;
            this.template_btn.BorderSize = 0;
            this.template_btn.FlatAppearance.BorderSize = 0;
            this.template_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.template_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.template_btn.ForeColor = System.Drawing.Color.White;
            this.template_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.template_btn.Location = new System.Drawing.Point(3, 47);
            this.template_btn.Name = "template_btn";
            this.template_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.template_btn.Size = new System.Drawing.Size(248, 43);
            this.template_btn.TabIndex = 1;
            this.template_btn.Text = "       Şablon Seç";
            this.template_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.template_btn.UseVisualStyleBackColor = false;
            this.template_btn.Click += new System.EventHandler(this.template_btn_Click);
            // 
            // emptyDoc_btn
            // 
            this.emptyDoc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.emptyDoc_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emptyDoc_btn.BackgroundImage")));
            this.emptyDoc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.emptyDoc_btn.BorderColor = System.Drawing.Color.White;
            this.emptyDoc_btn.BorderRadius = 10;
            this.emptyDoc_btn.BorderSize = 0;
            this.emptyDoc_btn.FlatAppearance.BorderSize = 0;
            this.emptyDoc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyDoc_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emptyDoc_btn.ForeColor = System.Drawing.Color.White;
            this.emptyDoc_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emptyDoc_btn.Location = new System.Drawing.Point(3, 4);
            this.emptyDoc_btn.Name = "emptyDoc_btn";
            this.emptyDoc_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.emptyDoc_btn.Size = new System.Drawing.Size(248, 43);
            this.emptyDoc_btn.TabIndex = 0;
            this.emptyDoc_btn.Text = "       Boş Belge";
            this.emptyDoc_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.emptyDoc_btn.UseVisualStyleBackColor = false;
            this.emptyDoc_btn.Click += new System.EventHandler(this.emptyDoc_btn_Click);
            // 
            // highlightColorSelectMenu
            // 
            this.highlightColorSelectMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.highlightColorSelectMenu.BorderColor = System.Drawing.Color.White;
            this.highlightColorSelectMenu.BorderRadius = 15;
            this.highlightColorSelectMenu.BorderSize = 0;
            this.highlightColorSelectMenu.Controls.Add(this.closeHighlight_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightWhite_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightPink_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightPurple_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightDarkBlue_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightBlue_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightTurquoise_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightLime_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightSeaGreen_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightLightGreen_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightYellow_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightOrange_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightRed_btn);
            this.highlightColorSelectMenu.Controls.Add(this.highlightBlue_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightGreen_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightRed_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightColorMenuIndicator);
            this.highlightColorSelectMenu.Controls.Add(this.highlightBlueValue_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightGreenValue_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightRedValue_lbl);
            this.highlightColorSelectMenu.Controls.Add(this.highlightSelectColor_btn);
            this.highlightColorSelectMenu.ForeColor = System.Drawing.Color.White;
            this.highlightColorSelectMenu.Location = new System.Drawing.Point(380, 238);
            this.highlightColorSelectMenu.Name = "highlightColorSelectMenu";
            this.highlightColorSelectMenu.Size = new System.Drawing.Size(294, 179);
            this.highlightColorSelectMenu.TabIndex = 66;
            this.highlightColorSelectMenu.Visible = false;
            // 
            // closeHighlight_btn
            // 
            this.closeHighlight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.closeHighlight_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.closeHighlight_btn.BorderRadius = 10;
            this.closeHighlight_btn.BorderSize = 0;
            this.closeHighlight_btn.FlatAppearance.BorderSize = 0;
            this.closeHighlight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeHighlight_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeHighlight_btn.ForeColor = System.Drawing.Color.LightGray;
            this.closeHighlight_btn.Location = new System.Drawing.Point(4, 93);
            this.closeHighlight_btn.Name = "closeHighlight_btn";
            this.closeHighlight_btn.Size = new System.Drawing.Size(281, 40);
            this.closeHighlight_btn.TabIndex = 31;
            this.closeHighlight_btn.Text = "Vurguyu Kapat";
            this.closeHighlight_btn.UseVisualStyleBackColor = false;
            this.closeHighlight_btn.Click += new System.EventHandler(this.closeHighlight_btn_Click);
            // 
            // highlightWhite_btn
            // 
            this.highlightWhite_btn.BackColor = System.Drawing.Color.White;
            this.highlightWhite_btn.BorderColor = System.Drawing.Color.White;
            this.highlightWhite_btn.BorderRadius = 0;
            this.highlightWhite_btn.BorderSize = 0;
            this.highlightWhite_btn.FlatAppearance.BorderSize = 0;
            this.highlightWhite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightWhite_btn.ForeColor = System.Drawing.Color.White;
            this.highlightWhite_btn.Location = new System.Drawing.Point(263, 63);
            this.highlightWhite_btn.Name = "highlightWhite_btn";
            this.highlightWhite_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightWhite_btn.TabIndex = 30;
            this.highlightWhite_btn.UseVisualStyleBackColor = false;
            this.highlightWhite_btn.Click += new System.EventHandler(this.highlightWhite_btn_Click);
            // 
            // highlightPink_btn
            // 
            this.highlightPink_btn.BackColor = System.Drawing.Color.Magenta;
            this.highlightPink_btn.BorderColor = System.Drawing.Color.White;
            this.highlightPink_btn.BorderRadius = 0;
            this.highlightPink_btn.BorderSize = 0;
            this.highlightPink_btn.FlatAppearance.BorderSize = 0;
            this.highlightPink_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightPink_btn.ForeColor = System.Drawing.Color.White;
            this.highlightPink_btn.Location = new System.Drawing.Point(238, 63);
            this.highlightPink_btn.Name = "highlightPink_btn";
            this.highlightPink_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightPink_btn.TabIndex = 29;
            this.highlightPink_btn.UseVisualStyleBackColor = false;
            this.highlightPink_btn.Click += new System.EventHandler(this.highlightPink_btn_Click);
            // 
            // highlightPurple_btn
            // 
            this.highlightPurple_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.highlightPurple_btn.BorderColor = System.Drawing.Color.White;
            this.highlightPurple_btn.BorderRadius = 0;
            this.highlightPurple_btn.BorderSize = 0;
            this.highlightPurple_btn.FlatAppearance.BorderSize = 0;
            this.highlightPurple_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightPurple_btn.ForeColor = System.Drawing.Color.White;
            this.highlightPurple_btn.Location = new System.Drawing.Point(213, 63);
            this.highlightPurple_btn.Name = "highlightPurple_btn";
            this.highlightPurple_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightPurple_btn.TabIndex = 28;
            this.highlightPurple_btn.UseVisualStyleBackColor = false;
            this.highlightPurple_btn.Click += new System.EventHandler(this.highlightPurple_btn_Click);
            // 
            // highlightDarkBlue_btn
            // 
            this.highlightDarkBlue_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.highlightDarkBlue_btn.BorderColor = System.Drawing.Color.White;
            this.highlightDarkBlue_btn.BorderRadius = 0;
            this.highlightDarkBlue_btn.BorderSize = 0;
            this.highlightDarkBlue_btn.FlatAppearance.BorderSize = 0;
            this.highlightDarkBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightDarkBlue_btn.ForeColor = System.Drawing.Color.White;
            this.highlightDarkBlue_btn.Location = new System.Drawing.Point(188, 63);
            this.highlightDarkBlue_btn.Name = "highlightDarkBlue_btn";
            this.highlightDarkBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightDarkBlue_btn.TabIndex = 27;
            this.highlightDarkBlue_btn.UseVisualStyleBackColor = false;
            this.highlightDarkBlue_btn.Click += new System.EventHandler(this.highlightDarkBlue_btn_Click);
            // 
            // highlightBlue_btn
            // 
            this.highlightBlue_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.highlightBlue_btn.BorderColor = System.Drawing.Color.White;
            this.highlightBlue_btn.BorderRadius = 0;
            this.highlightBlue_btn.BorderSize = 0;
            this.highlightBlue_btn.FlatAppearance.BorderSize = 0;
            this.highlightBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightBlue_btn.ForeColor = System.Drawing.Color.White;
            this.highlightBlue_btn.Location = new System.Drawing.Point(263, 37);
            this.highlightBlue_btn.Name = "highlightBlue_btn";
            this.highlightBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightBlue_btn.TabIndex = 26;
            this.highlightBlue_btn.UseVisualStyleBackColor = false;
            this.highlightBlue_btn.Click += new System.EventHandler(this.highlightBlue_btn_Click);
            // 
            // highlightTurquoise_btn
            // 
            this.highlightTurquoise_btn.BackColor = System.Drawing.Color.Turquoise;
            this.highlightTurquoise_btn.BorderColor = System.Drawing.Color.White;
            this.highlightTurquoise_btn.BorderRadius = 0;
            this.highlightTurquoise_btn.BorderSize = 0;
            this.highlightTurquoise_btn.FlatAppearance.BorderSize = 0;
            this.highlightTurquoise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightTurquoise_btn.ForeColor = System.Drawing.Color.White;
            this.highlightTurquoise_btn.Location = new System.Drawing.Point(238, 37);
            this.highlightTurquoise_btn.Name = "highlightTurquoise_btn";
            this.highlightTurquoise_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightTurquoise_btn.TabIndex = 25;
            this.highlightTurquoise_btn.UseVisualStyleBackColor = false;
            this.highlightTurquoise_btn.Click += new System.EventHandler(this.highlightTurquoise_btn_Click);
            // 
            // highlightLime_btn
            // 
            this.highlightLime_btn.BackColor = System.Drawing.Color.Lime;
            this.highlightLime_btn.BorderColor = System.Drawing.Color.White;
            this.highlightLime_btn.BorderRadius = 0;
            this.highlightLime_btn.BorderSize = 0;
            this.highlightLime_btn.FlatAppearance.BorderSize = 0;
            this.highlightLime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightLime_btn.ForeColor = System.Drawing.Color.White;
            this.highlightLime_btn.Location = new System.Drawing.Point(213, 37);
            this.highlightLime_btn.Name = "highlightLime_btn";
            this.highlightLime_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightLime_btn.TabIndex = 24;
            this.highlightLime_btn.UseVisualStyleBackColor = false;
            this.highlightLime_btn.Click += new System.EventHandler(this.highlightLime_btn_Click);
            // 
            // highlightSeaGreen_btn
            // 
            this.highlightSeaGreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.highlightSeaGreen_btn.BorderColor = System.Drawing.Color.White;
            this.highlightSeaGreen_btn.BorderRadius = 0;
            this.highlightSeaGreen_btn.BorderSize = 0;
            this.highlightSeaGreen_btn.FlatAppearance.BorderSize = 0;
            this.highlightSeaGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightSeaGreen_btn.ForeColor = System.Drawing.Color.White;
            this.highlightSeaGreen_btn.Location = new System.Drawing.Point(188, 37);
            this.highlightSeaGreen_btn.Name = "highlightSeaGreen_btn";
            this.highlightSeaGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightSeaGreen_btn.TabIndex = 23;
            this.highlightSeaGreen_btn.UseVisualStyleBackColor = false;
            this.highlightSeaGreen_btn.Click += new System.EventHandler(this.highlightSeaGreen_btn_Click);
            // 
            // highlightLightGreen_btn
            // 
            this.highlightLightGreen_btn.BackColor = System.Drawing.Color.LightGreen;
            this.highlightLightGreen_btn.BorderColor = System.Drawing.Color.White;
            this.highlightLightGreen_btn.BorderRadius = 0;
            this.highlightLightGreen_btn.BorderSize = 0;
            this.highlightLightGreen_btn.FlatAppearance.BorderSize = 0;
            this.highlightLightGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightLightGreen_btn.ForeColor = System.Drawing.Color.White;
            this.highlightLightGreen_btn.Location = new System.Drawing.Point(263, 11);
            this.highlightLightGreen_btn.Name = "highlightLightGreen_btn";
            this.highlightLightGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightLightGreen_btn.TabIndex = 22;
            this.highlightLightGreen_btn.UseVisualStyleBackColor = false;
            this.highlightLightGreen_btn.Click += new System.EventHandler(this.highlightLightGreen_btn_Click);
            // 
            // highlightYellow_btn
            // 
            this.highlightYellow_btn.BackColor = System.Drawing.Color.Gold;
            this.highlightYellow_btn.BorderColor = System.Drawing.Color.White;
            this.highlightYellow_btn.BorderRadius = 0;
            this.highlightYellow_btn.BorderSize = 0;
            this.highlightYellow_btn.FlatAppearance.BorderSize = 0;
            this.highlightYellow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightYellow_btn.ForeColor = System.Drawing.Color.White;
            this.highlightYellow_btn.Location = new System.Drawing.Point(238, 11);
            this.highlightYellow_btn.Name = "highlightYellow_btn";
            this.highlightYellow_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightYellow_btn.TabIndex = 21;
            this.highlightYellow_btn.UseVisualStyleBackColor = false;
            this.highlightYellow_btn.Click += new System.EventHandler(this.highlightYellow_btn_Click);
            // 
            // highlightOrange_btn
            // 
            this.highlightOrange_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.highlightOrange_btn.BorderColor = System.Drawing.Color.White;
            this.highlightOrange_btn.BorderRadius = 0;
            this.highlightOrange_btn.BorderSize = 0;
            this.highlightOrange_btn.FlatAppearance.BorderSize = 0;
            this.highlightOrange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightOrange_btn.ForeColor = System.Drawing.Color.White;
            this.highlightOrange_btn.Location = new System.Drawing.Point(213, 11);
            this.highlightOrange_btn.Name = "highlightOrange_btn";
            this.highlightOrange_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightOrange_btn.TabIndex = 20;
            this.highlightOrange_btn.UseVisualStyleBackColor = false;
            this.highlightOrange_btn.Click += new System.EventHandler(this.highlightOrange_btn_Click);
            // 
            // highlightRed_btn
            // 
            this.highlightRed_btn.BackColor = System.Drawing.Color.Red;
            this.highlightRed_btn.BorderColor = System.Drawing.Color.White;
            this.highlightRed_btn.BorderRadius = 0;
            this.highlightRed_btn.BorderSize = 0;
            this.highlightRed_btn.FlatAppearance.BorderSize = 0;
            this.highlightRed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightRed_btn.ForeColor = System.Drawing.Color.White;
            this.highlightRed_btn.Location = new System.Drawing.Point(188, 11);
            this.highlightRed_btn.Name = "highlightRed_btn";
            this.highlightRed_btn.Size = new System.Drawing.Size(20, 20);
            this.highlightRed_btn.TabIndex = 19;
            this.highlightRed_btn.UseVisualStyleBackColor = false;
            this.highlightRed_btn.Click += new System.EventHandler(this.highlightRed_btn_Click);
            // 
            // highlightBlue_lbl
            // 
            this.highlightBlue_lbl.AutoSize = true;
            this.highlightBlue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightBlue_lbl.Location = new System.Drawing.Point(72, 62);
            this.highlightBlue_lbl.Name = "highlightBlue_lbl";
            this.highlightBlue_lbl.Size = new System.Drawing.Size(29, 20);
            this.highlightBlue_lbl.TabIndex = 18;
            this.highlightBlue_lbl.Text = "M:";
            // 
            // highlightGreen_lbl
            // 
            this.highlightGreen_lbl.AutoSize = true;
            this.highlightGreen_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightGreen_lbl.Location = new System.Drawing.Point(72, 37);
            this.highlightGreen_lbl.Name = "highlightGreen_lbl";
            this.highlightGreen_lbl.Size = new System.Drawing.Size(26, 20);
            this.highlightGreen_lbl.TabIndex = 17;
            this.highlightGreen_lbl.Text = "Y:";
            // 
            // highlightRed_lbl
            // 
            this.highlightRed_lbl.AutoSize = true;
            this.highlightRed_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightRed_lbl.Location = new System.Drawing.Point(72, 13);
            this.highlightRed_lbl.Name = "highlightRed_lbl";
            this.highlightRed_lbl.Size = new System.Drawing.Size(25, 20);
            this.highlightRed_lbl.TabIndex = 16;
            this.highlightRed_lbl.Text = "K:";
            // 
            // highlightColorMenuIndicator
            // 
            this.highlightColorMenuIndicator.AutoSize = true;
            this.highlightColorMenuIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.highlightColorMenuIndicator.Font = new System.Drawing.Font("Wanted Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightColorMenuIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.highlightColorMenuIndicator.Location = new System.Drawing.Point(18, 32);
            this.highlightColorMenuIndicator.Name = "highlightColorMenuIndicator";
            this.highlightColorMenuIndicator.Size = new System.Drawing.Size(43, 34);
            this.highlightColorMenuIndicator.TabIndex = 15;
            this.highlightColorMenuIndicator.Text = "    ";
            this.highlightColorMenuIndicator.BackColorChanged += new System.EventHandler(this.highlightColorMenuIndicator_BackColorChanged);
            // 
            // highlightBlueValue_lbl
            // 
            this.highlightBlueValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.highlightBlueValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highlightBlueValue_lbl.Enabled = false;
            this.highlightBlueValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightBlueValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.highlightBlueValue_lbl.Location = new System.Drawing.Point(103, 65);
            this.highlightBlueValue_lbl.Name = "highlightBlueValue_lbl";
            this.highlightBlueValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.highlightBlueValue_lbl.TabIndex = 14;
            this.highlightBlueValue_lbl.Text = "103";
            // 
            // highlightGreenValue_lbl
            // 
            this.highlightGreenValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.highlightGreenValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highlightGreenValue_lbl.Enabled = false;
            this.highlightGreenValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightGreenValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.highlightGreenValue_lbl.Location = new System.Drawing.Point(103, 40);
            this.highlightGreenValue_lbl.Name = "highlightGreenValue_lbl";
            this.highlightGreenValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.highlightGreenValue_lbl.TabIndex = 13;
            this.highlightGreenValue_lbl.Text = "103";
            // 
            // highlightRedValue_lbl
            // 
            this.highlightRedValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.highlightRedValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highlightRedValue_lbl.Enabled = false;
            this.highlightRedValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightRedValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.highlightRedValue_lbl.Location = new System.Drawing.Point(103, 16);
            this.highlightRedValue_lbl.Name = "highlightRedValue_lbl";
            this.highlightRedValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.highlightRedValue_lbl.TabIndex = 12;
            this.highlightRedValue_lbl.Text = "103";
            // 
            // highlightSelectColor_btn
            // 
            this.highlightSelectColor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.highlightSelectColor_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.highlightSelectColor_btn.BorderRadius = 10;
            this.highlightSelectColor_btn.BorderSize = 0;
            this.highlightSelectColor_btn.FlatAppearance.BorderSize = 0;
            this.highlightSelectColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlightSelectColor_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlightSelectColor_btn.ForeColor = System.Drawing.Color.LightGray;
            this.highlightSelectColor_btn.Location = new System.Drawing.Point(4, 136);
            this.highlightSelectColor_btn.Name = "highlightSelectColor_btn";
            this.highlightSelectColor_btn.Size = new System.Drawing.Size(281, 40);
            this.highlightSelectColor_btn.TabIndex = 11;
            this.highlightSelectColor_btn.Text = "Özel Renk Seç";
            this.highlightSelectColor_btn.UseVisualStyleBackColor = false;
            this.highlightSelectColor_btn.Click += new System.EventHandler(this.highlightSelectColor_btn_Click);
            // 
            // textColorSelectMenu
            // 
            this.textColorSelectMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textColorSelectMenu.BorderColor = System.Drawing.Color.White;
            this.textColorSelectMenu.BorderRadius = 15;
            this.textColorSelectMenu.BorderSize = 0;
            this.textColorSelectMenu.Controls.Add(this.textColorWhite_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorPink_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorPurple_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorDarkBlue_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorBlue_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorTurqoise_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorLime_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorSeaGreen_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorLightGreen_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorYellow_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorOrange_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorRed_btn);
            this.textColorSelectMenu.Controls.Add(this.textColorBlue_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorGreen_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorRed_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorMenuIndicator);
            this.textColorSelectMenu.Controls.Add(this.textColorBlueValue_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorGreenValue_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorRedValue_lbl);
            this.textColorSelectMenu.Controls.Add(this.textColorSelectColor_btn);
            this.textColorSelectMenu.ForeColor = System.Drawing.Color.White;
            this.textColorSelectMenu.Location = new System.Drawing.Point(337, 238);
            this.textColorSelectMenu.Name = "textColorSelectMenu";
            this.textColorSelectMenu.Size = new System.Drawing.Size(294, 137);
            this.textColorSelectMenu.TabIndex = 65;
            this.textColorSelectMenu.Visible = false;
            // 
            // textColorWhite_btn
            // 
            this.textColorWhite_btn.BackColor = System.Drawing.Color.White;
            this.textColorWhite_btn.BorderColor = System.Drawing.Color.White;
            this.textColorWhite_btn.BorderRadius = 0;
            this.textColorWhite_btn.BorderSize = 0;
            this.textColorWhite_btn.FlatAppearance.BorderSize = 0;
            this.textColorWhite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorWhite_btn.ForeColor = System.Drawing.Color.White;
            this.textColorWhite_btn.Location = new System.Drawing.Point(263, 63);
            this.textColorWhite_btn.Name = "textColorWhite_btn";
            this.textColorWhite_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorWhite_btn.TabIndex = 30;
            this.textColorWhite_btn.UseVisualStyleBackColor = false;
            this.textColorWhite_btn.Click += new System.EventHandler(this.textColorWhite_btn_Click);
            // 
            // textColorPink_btn
            // 
            this.textColorPink_btn.BackColor = System.Drawing.Color.Magenta;
            this.textColorPink_btn.BorderColor = System.Drawing.Color.White;
            this.textColorPink_btn.BorderRadius = 0;
            this.textColorPink_btn.BorderSize = 0;
            this.textColorPink_btn.FlatAppearance.BorderSize = 0;
            this.textColorPink_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorPink_btn.ForeColor = System.Drawing.Color.White;
            this.textColorPink_btn.Location = new System.Drawing.Point(238, 63);
            this.textColorPink_btn.Name = "textColorPink_btn";
            this.textColorPink_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorPink_btn.TabIndex = 29;
            this.textColorPink_btn.UseVisualStyleBackColor = false;
            this.textColorPink_btn.Click += new System.EventHandler(this.textColorPink_btn_Click);
            // 
            // textColorPurple_btn
            // 
            this.textColorPurple_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.textColorPurple_btn.BorderColor = System.Drawing.Color.White;
            this.textColorPurple_btn.BorderRadius = 0;
            this.textColorPurple_btn.BorderSize = 0;
            this.textColorPurple_btn.FlatAppearance.BorderSize = 0;
            this.textColorPurple_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorPurple_btn.ForeColor = System.Drawing.Color.White;
            this.textColorPurple_btn.Location = new System.Drawing.Point(213, 63);
            this.textColorPurple_btn.Name = "textColorPurple_btn";
            this.textColorPurple_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorPurple_btn.TabIndex = 28;
            this.textColorPurple_btn.UseVisualStyleBackColor = false;
            this.textColorPurple_btn.Click += new System.EventHandler(this.textColorPurple_btn_Click);
            // 
            // textColorDarkBlue_btn
            // 
            this.textColorDarkBlue_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.textColorDarkBlue_btn.BorderColor = System.Drawing.Color.White;
            this.textColorDarkBlue_btn.BorderRadius = 0;
            this.textColorDarkBlue_btn.BorderSize = 0;
            this.textColorDarkBlue_btn.FlatAppearance.BorderSize = 0;
            this.textColorDarkBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorDarkBlue_btn.ForeColor = System.Drawing.Color.White;
            this.textColorDarkBlue_btn.Location = new System.Drawing.Point(188, 63);
            this.textColorDarkBlue_btn.Name = "textColorDarkBlue_btn";
            this.textColorDarkBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorDarkBlue_btn.TabIndex = 27;
            this.textColorDarkBlue_btn.UseVisualStyleBackColor = false;
            this.textColorDarkBlue_btn.Click += new System.EventHandler(this.textColorDarkBlue_btn_Click);
            // 
            // textColorBlue_btn
            // 
            this.textColorBlue_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.textColorBlue_btn.BorderColor = System.Drawing.Color.White;
            this.textColorBlue_btn.BorderRadius = 0;
            this.textColorBlue_btn.BorderSize = 0;
            this.textColorBlue_btn.FlatAppearance.BorderSize = 0;
            this.textColorBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorBlue_btn.ForeColor = System.Drawing.Color.White;
            this.textColorBlue_btn.Location = new System.Drawing.Point(263, 37);
            this.textColorBlue_btn.Name = "textColorBlue_btn";
            this.textColorBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorBlue_btn.TabIndex = 26;
            this.textColorBlue_btn.UseVisualStyleBackColor = false;
            this.textColorBlue_btn.Click += new System.EventHandler(this.textColorBlue_btn_Click);
            // 
            // textColorTurqoise_btn
            // 
            this.textColorTurqoise_btn.BackColor = System.Drawing.Color.Turquoise;
            this.textColorTurqoise_btn.BorderColor = System.Drawing.Color.White;
            this.textColorTurqoise_btn.BorderRadius = 0;
            this.textColorTurqoise_btn.BorderSize = 0;
            this.textColorTurqoise_btn.FlatAppearance.BorderSize = 0;
            this.textColorTurqoise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorTurqoise_btn.ForeColor = System.Drawing.Color.White;
            this.textColorTurqoise_btn.Location = new System.Drawing.Point(238, 37);
            this.textColorTurqoise_btn.Name = "textColorTurqoise_btn";
            this.textColorTurqoise_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorTurqoise_btn.TabIndex = 25;
            this.textColorTurqoise_btn.UseVisualStyleBackColor = false;
            this.textColorTurqoise_btn.Click += new System.EventHandler(this.textColorTurqoise_btn_Click);
            // 
            // textColorLime_btn
            // 
            this.textColorLime_btn.BackColor = System.Drawing.Color.Lime;
            this.textColorLime_btn.BorderColor = System.Drawing.Color.White;
            this.textColorLime_btn.BorderRadius = 0;
            this.textColorLime_btn.BorderSize = 0;
            this.textColorLime_btn.FlatAppearance.BorderSize = 0;
            this.textColorLime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorLime_btn.ForeColor = System.Drawing.Color.White;
            this.textColorLime_btn.Location = new System.Drawing.Point(213, 37);
            this.textColorLime_btn.Name = "textColorLime_btn";
            this.textColorLime_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorLime_btn.TabIndex = 24;
            this.textColorLime_btn.UseVisualStyleBackColor = false;
            this.textColorLime_btn.Click += new System.EventHandler(this.textColorLime_btn_Click);
            // 
            // textColorSeaGreen_btn
            // 
            this.textColorSeaGreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.textColorSeaGreen_btn.BorderColor = System.Drawing.Color.White;
            this.textColorSeaGreen_btn.BorderRadius = 0;
            this.textColorSeaGreen_btn.BorderSize = 0;
            this.textColorSeaGreen_btn.FlatAppearance.BorderSize = 0;
            this.textColorSeaGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorSeaGreen_btn.ForeColor = System.Drawing.Color.White;
            this.textColorSeaGreen_btn.Location = new System.Drawing.Point(188, 37);
            this.textColorSeaGreen_btn.Name = "textColorSeaGreen_btn";
            this.textColorSeaGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorSeaGreen_btn.TabIndex = 23;
            this.textColorSeaGreen_btn.UseVisualStyleBackColor = false;
            this.textColorSeaGreen_btn.Click += new System.EventHandler(this.textColorSeaGreen_btn_Click);
            // 
            // textColorLightGreen_btn
            // 
            this.textColorLightGreen_btn.BackColor = System.Drawing.Color.LightGreen;
            this.textColorLightGreen_btn.BorderColor = System.Drawing.Color.White;
            this.textColorLightGreen_btn.BorderRadius = 0;
            this.textColorLightGreen_btn.BorderSize = 0;
            this.textColorLightGreen_btn.FlatAppearance.BorderSize = 0;
            this.textColorLightGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorLightGreen_btn.ForeColor = System.Drawing.Color.White;
            this.textColorLightGreen_btn.Location = new System.Drawing.Point(263, 11);
            this.textColorLightGreen_btn.Name = "textColorLightGreen_btn";
            this.textColorLightGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorLightGreen_btn.TabIndex = 22;
            this.textColorLightGreen_btn.UseVisualStyleBackColor = false;
            this.textColorLightGreen_btn.Click += new System.EventHandler(this.textColorLightGreen_btn_Click);
            // 
            // textColorYellow_btn
            // 
            this.textColorYellow_btn.BackColor = System.Drawing.Color.Gold;
            this.textColorYellow_btn.BorderColor = System.Drawing.Color.White;
            this.textColorYellow_btn.BorderRadius = 0;
            this.textColorYellow_btn.BorderSize = 0;
            this.textColorYellow_btn.FlatAppearance.BorderSize = 0;
            this.textColorYellow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorYellow_btn.ForeColor = System.Drawing.Color.White;
            this.textColorYellow_btn.Location = new System.Drawing.Point(238, 11);
            this.textColorYellow_btn.Name = "textColorYellow_btn";
            this.textColorYellow_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorYellow_btn.TabIndex = 21;
            this.textColorYellow_btn.UseVisualStyleBackColor = false;
            this.textColorYellow_btn.Click += new System.EventHandler(this.textColorYellow_btn_Click);
            // 
            // textColorOrange_btn
            // 
            this.textColorOrange_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.textColorOrange_btn.BorderColor = System.Drawing.Color.White;
            this.textColorOrange_btn.BorderRadius = 0;
            this.textColorOrange_btn.BorderSize = 0;
            this.textColorOrange_btn.FlatAppearance.BorderSize = 0;
            this.textColorOrange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorOrange_btn.ForeColor = System.Drawing.Color.White;
            this.textColorOrange_btn.Location = new System.Drawing.Point(213, 11);
            this.textColorOrange_btn.Name = "textColorOrange_btn";
            this.textColorOrange_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorOrange_btn.TabIndex = 20;
            this.textColorOrange_btn.UseVisualStyleBackColor = false;
            this.textColorOrange_btn.Click += new System.EventHandler(this.textColorOrange_btn_Click);
            // 
            // textColorRed_btn
            // 
            this.textColorRed_btn.BackColor = System.Drawing.Color.Red;
            this.textColorRed_btn.BorderColor = System.Drawing.Color.White;
            this.textColorRed_btn.BorderRadius = 0;
            this.textColorRed_btn.BorderSize = 0;
            this.textColorRed_btn.FlatAppearance.BorderSize = 0;
            this.textColorRed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorRed_btn.ForeColor = System.Drawing.Color.White;
            this.textColorRed_btn.Location = new System.Drawing.Point(188, 11);
            this.textColorRed_btn.Name = "textColorRed_btn";
            this.textColorRed_btn.Size = new System.Drawing.Size(20, 20);
            this.textColorRed_btn.TabIndex = 19;
            this.textColorRed_btn.UseVisualStyleBackColor = false;
            this.textColorRed_btn.Click += new System.EventHandler(this.textColorRed_btn_Click);
            // 
            // textColorBlue_lbl
            // 
            this.textColorBlue_lbl.AutoSize = true;
            this.textColorBlue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorBlue_lbl.Location = new System.Drawing.Point(72, 62);
            this.textColorBlue_lbl.Name = "textColorBlue_lbl";
            this.textColorBlue_lbl.Size = new System.Drawing.Size(29, 20);
            this.textColorBlue_lbl.TabIndex = 18;
            this.textColorBlue_lbl.Text = "M:";
            // 
            // textColorGreen_lbl
            // 
            this.textColorGreen_lbl.AutoSize = true;
            this.textColorGreen_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorGreen_lbl.Location = new System.Drawing.Point(72, 37);
            this.textColorGreen_lbl.Name = "textColorGreen_lbl";
            this.textColorGreen_lbl.Size = new System.Drawing.Size(26, 20);
            this.textColorGreen_lbl.TabIndex = 17;
            this.textColorGreen_lbl.Text = "Y:";
            // 
            // textColorRed_lbl
            // 
            this.textColorRed_lbl.AutoSize = true;
            this.textColorRed_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorRed_lbl.Location = new System.Drawing.Point(72, 13);
            this.textColorRed_lbl.Name = "textColorRed_lbl";
            this.textColorRed_lbl.Size = new System.Drawing.Size(25, 20);
            this.textColorRed_lbl.TabIndex = 16;
            this.textColorRed_lbl.Text = "K:";
            // 
            // textColorMenuIndicator
            // 
            this.textColorMenuIndicator.AutoSize = true;
            this.textColorMenuIndicator.BackColor = System.Drawing.Color.White;
            this.textColorMenuIndicator.Font = new System.Drawing.Font("Wanted Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorMenuIndicator.Location = new System.Drawing.Point(18, 32);
            this.textColorMenuIndicator.Name = "textColorMenuIndicator";
            this.textColorMenuIndicator.Size = new System.Drawing.Size(43, 34);
            this.textColorMenuIndicator.TabIndex = 15;
            this.textColorMenuIndicator.Text = "    ";
            this.textColorMenuIndicator.BackColorChanged += new System.EventHandler(this.textColorMenuIndicator_BackColorChanged);
            // 
            // textColorBlueValue_lbl
            // 
            this.textColorBlueValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textColorBlueValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textColorBlueValue_lbl.Enabled = false;
            this.textColorBlueValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorBlueValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.textColorBlueValue_lbl.Location = new System.Drawing.Point(103, 66);
            this.textColorBlueValue_lbl.Name = "textColorBlueValue_lbl";
            this.textColorBlueValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.textColorBlueValue_lbl.TabIndex = 14;
            this.textColorBlueValue_lbl.Text = "255";
            // 
            // textColorGreenValue_lbl
            // 
            this.textColorGreenValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textColorGreenValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textColorGreenValue_lbl.Enabled = false;
            this.textColorGreenValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorGreenValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.textColorGreenValue_lbl.Location = new System.Drawing.Point(103, 40);
            this.textColorGreenValue_lbl.Name = "textColorGreenValue_lbl";
            this.textColorGreenValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.textColorGreenValue_lbl.TabIndex = 13;
            this.textColorGreenValue_lbl.Text = "255";
            // 
            // textColorRedValue_lbl
            // 
            this.textColorRedValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textColorRedValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textColorRedValue_lbl.Enabled = false;
            this.textColorRedValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorRedValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.textColorRedValue_lbl.Location = new System.Drawing.Point(103, 15);
            this.textColorRedValue_lbl.Name = "textColorRedValue_lbl";
            this.textColorRedValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.textColorRedValue_lbl.TabIndex = 12;
            this.textColorRedValue_lbl.Text = "255";
            // 
            // textColorSelectColor_btn
            // 
            this.textColorSelectColor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textColorSelectColor_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textColorSelectColor_btn.BorderRadius = 10;
            this.textColorSelectColor_btn.BorderSize = 0;
            this.textColorSelectColor_btn.FlatAppearance.BorderSize = 0;
            this.textColorSelectColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textColorSelectColor_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textColorSelectColor_btn.ForeColor = System.Drawing.Color.LightGray;
            this.textColorSelectColor_btn.Location = new System.Drawing.Point(5, 91);
            this.textColorSelectColor_btn.Name = "textColorSelectColor_btn";
            this.textColorSelectColor_btn.Size = new System.Drawing.Size(281, 40);
            this.textColorSelectColor_btn.TabIndex = 11;
            this.textColorSelectColor_btn.Text = "Özel Renk Seç";
            this.textColorSelectColor_btn.UseVisualStyleBackColor = false;
            this.textColorSelectColor_btn.Click += new System.EventHandler(this.textColorSelectColor_btn_Click);
            // 
            // findMenu
            // 
            this.findMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.findMenu.BorderColor = System.Drawing.Color.White;
            this.findMenu.BorderRadius = 15;
            this.findMenu.BorderSize = 0;
            this.findMenu.Controls.Add(this.find_txt);
            this.findMenu.Controls.Add(this.closeFind_btn);
            this.findMenu.Controls.Add(this.find_btn);
            this.findMenu.ForeColor = System.Drawing.Color.White;
            this.findMenu.Location = new System.Drawing.Point(550, 258);
            this.findMenu.Name = "findMenu";
            this.findMenu.Size = new System.Drawing.Size(787, 50);
            this.findMenu.TabIndex = 58;
            this.findMenu.Visible = false;
            // 
            // find_txt
            // 
            this.find_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.find_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_txt.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.find_txt.ForeColor = System.Drawing.Color.White;
            this.find_txt.Location = new System.Drawing.Point(18, 13);
            this.find_txt.Name = "find_txt";
            this.find_txt.Size = new System.Drawing.Size(574, 24);
            this.find_txt.TabIndex = 56;
            // 
            // closeFind_btn
            // 
            this.closeFind_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.closeFind_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeFind_btn.BackgroundImage")));
            this.closeFind_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeFind_btn.BorderColor = System.Drawing.Color.White;
            this.closeFind_btn.BorderRadius = 6;
            this.closeFind_btn.BorderSize = 0;
            this.closeFind_btn.FlatAppearance.BorderSize = 0;
            this.closeFind_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFind_btn.ForeColor = System.Drawing.Color.White;
            this.closeFind_btn.Location = new System.Drawing.Point(749, 10);
            this.closeFind_btn.Name = "closeFind_btn";
            this.closeFind_btn.Size = new System.Drawing.Size(32, 30);
            this.closeFind_btn.TabIndex = 3;
            this.closeFind_btn.UseVisualStyleBackColor = false;
            this.closeFind_btn.Click += new System.EventHandler(this.closeFind_btn_Click);
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.find_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.find_btn.BorderRadius = 7;
            this.find_btn.BorderSize = 0;
            this.find_btn.FlatAppearance.BorderSize = 0;
            this.find_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.find_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.find_btn.ForeColor = System.Drawing.Color.LightGray;
            this.find_btn.Image = ((System.Drawing.Image)(resources.GetObject("find_btn.Image")));
            this.find_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find_btn.Location = new System.Drawing.Point(615, 7);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(131, 35);
            this.find_btn.TabIndex = 55;
            this.find_btn.Text = "        Bul";
            this.find_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.helpMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.helpMenu.BorderRadius = 10;
            this.helpMenu.BorderSize = 0;
            this.helpMenu.Controls.Add(this.about_btn);
            this.helpMenu.Controls.Add(this.img_buffer);
            this.helpMenu.Controls.Add(this.reportBugs_btn);
            this.helpMenu.Controls.Add(this.help_btn);
            this.helpMenu.ForeColor = System.Drawing.Color.White;
            this.helpMenu.Location = new System.Drawing.Point(-2035, 216);
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(255, 147);
            this.helpMenu.TabIndex = 10;
            this.helpMenu.Visible = false;
            // 
            // about_btn
            // 
            this.about_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.about_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about_btn.BackgroundImage")));
            this.about_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about_btn.BorderColor = System.Drawing.Color.White;
            this.about_btn.BorderRadius = 10;
            this.about_btn.BorderSize = 0;
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.about_btn.ForeColor = System.Drawing.Color.White;
            this.about_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.about_btn.Location = new System.Drawing.Point(3, 100);
            this.about_btn.Name = "about_btn";
            this.about_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.about_btn.Size = new System.Drawing.Size(248, 43);
            this.about_btn.TabIndex = 9;
            this.about_btn.Text = "       Hakkında";
            this.about_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // img_buffer
            // 
            this.img_buffer.Image = ((System.Drawing.Image)(resources.GetObject("img_buffer.Image")));
            this.img_buffer.Location = new System.Drawing.Point(16, 95);
            this.img_buffer.Name = "img_buffer";
            this.img_buffer.Size = new System.Drawing.Size(222, 2);
            this.img_buffer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_buffer.TabIndex = 7;
            this.img_buffer.TabStop = false;
            // 
            // reportBugs_btn
            // 
            this.reportBugs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.reportBugs_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reportBugs_btn.BackgroundImage")));
            this.reportBugs_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportBugs_btn.BorderColor = System.Drawing.Color.White;
            this.reportBugs_btn.BorderRadius = 10;
            this.reportBugs_btn.BorderSize = 0;
            this.reportBugs_btn.FlatAppearance.BorderSize = 0;
            this.reportBugs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBugs_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportBugs_btn.ForeColor = System.Drawing.Color.White;
            this.reportBugs_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBugs_btn.Location = new System.Drawing.Point(3, 47);
            this.reportBugs_btn.Name = "reportBugs_btn";
            this.reportBugs_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.reportBugs_btn.Size = new System.Drawing.Size(248, 43);
            this.reportBugs_btn.TabIndex = 1;
            this.reportBugs_btn.Text = "       Hata Bildir";
            this.reportBugs_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.reportBugs_btn.UseVisualStyleBackColor = false;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.help_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_btn.BackgroundImage")));
            this.help_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.help_btn.BorderColor = System.Drawing.Color.White;
            this.help_btn.BorderRadius = 10;
            this.help_btn.BorderSize = 0;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help_btn.Location = new System.Drawing.Point(3, 4);
            this.help_btn.Name = "help_btn";
            this.help_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.help_btn.Size = new System.Drawing.Size(248, 43);
            this.help_btn.TabIndex = 0;
            this.help_btn.Text = "       Yardım";
            this.help_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.help_btn.UseVisualStyleBackColor = false;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.fileMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.fileMenu.BorderRadius = 10;
            this.fileMenu.BorderSize = 0;
            this.fileMenu.Controls.Add(this.fileinfo_btn);
            this.fileMenu.Controls.Add(this.filename_btn);
            this.fileMenu.Controls.Add(this.fileLine2);
            this.fileMenu.Controls.Add(this.print_btn);
            this.fileMenu.Controls.Add(this.export_btn);
            this.fileMenu.Controls.Add(this.share_btn);
            this.fileMenu.Controls.Add(this.fileLine1);
            this.fileMenu.Controls.Add(this.saveparent_btn);
            this.fileMenu.Controls.Add(this.open_btn);
            this.fileMenu.Controls.Add(this.new_btn);
            this.fileMenu.ForeColor = System.Drawing.Color.White;
            this.fileMenu.Location = new System.Drawing.Point(7, 109);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(255, 363);
            this.fileMenu.TabIndex = 7;
            this.fileMenu.Visible = false;
            // 
            // fileinfo_btn
            // 
            this.fileinfo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.fileinfo_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileinfo_btn.BackgroundImage")));
            this.fileinfo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fileinfo_btn.BorderColor = System.Drawing.Color.White;
            this.fileinfo_btn.BorderRadius = 10;
            this.fileinfo_btn.BorderSize = 0;
            this.fileinfo_btn.FlatAppearance.BorderSize = 0;
            this.fileinfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileinfo_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileinfo_btn.ForeColor = System.Drawing.Color.White;
            this.fileinfo_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileinfo_btn.Location = new System.Drawing.Point(4, 318);
            this.fileinfo_btn.Name = "fileinfo_btn";
            this.fileinfo_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.fileinfo_btn.Size = new System.Drawing.Size(248, 43);
            this.fileinfo_btn.TabIndex = 9;
            this.fileinfo_btn.Text = "       Dosya Bilgisi";
            this.fileinfo_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fileinfo_btn.UseVisualStyleBackColor = true;
            this.fileinfo_btn.Click += new System.EventHandler(this.fileinfo_btn_Click);
            // 
            // filename_btn
            // 
            this.filename_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.filename_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filename_btn.BackgroundImage")));
            this.filename_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filename_btn.BorderColor = System.Drawing.Color.White;
            this.filename_btn.BorderRadius = 10;
            this.filename_btn.BorderSize = 0;
            this.filename_btn.FlatAppearance.BorderSize = 0;
            this.filename_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filename_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filename_btn.ForeColor = System.Drawing.Color.White;
            this.filename_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filename_btn.Location = new System.Drawing.Point(4, 276);
            this.filename_btn.Name = "filename_btn";
            this.filename_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.filename_btn.Size = new System.Drawing.Size(248, 43);
            this.filename_btn.TabIndex = 8;
            this.filename_btn.Text = "       Dosya Adı";
            this.filename_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.filename_btn.UseVisualStyleBackColor = true;
            this.filename_btn.Click += new System.EventHandler(this.filename_btn_Click);
            // 
            // fileLine2
            // 
            this.fileLine2.Image = ((System.Drawing.Image)(resources.GetObject("fileLine2.Image")));
            this.fileLine2.Location = new System.Drawing.Point(16, 272);
            this.fileLine2.Name = "fileLine2";
            this.fileLine2.Size = new System.Drawing.Size(222, 2);
            this.fileLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileLine2.TabIndex = 7;
            this.fileLine2.TabStop = false;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.print_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_btn.BackgroundImage")));
            this.print_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.print_btn.BorderColor = System.Drawing.Color.White;
            this.print_btn.BorderRadius = 10;
            this.print_btn.BorderSize = 0;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print_btn.Location = new System.Drawing.Point(3, 227);
            this.print_btn.Name = "print_btn";
            this.print_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.print_btn.Size = new System.Drawing.Size(248, 43);
            this.print_btn.TabIndex = 6;
            this.print_btn.Text = "       Yazdır";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.export_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("export_btn.BackgroundImage")));
            this.export_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.export_btn.BorderColor = System.Drawing.Color.White;
            this.export_btn.BorderRadius = 10;
            this.export_btn.BorderSize = 0;
            this.export_btn.FlatAppearance.BorderSize = 0;
            this.export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.export_btn.ForeColor = System.Drawing.Color.White;
            this.export_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.export_btn.Location = new System.Drawing.Point(3, 185);
            this.export_btn.Name = "export_btn";
            this.export_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.export_btn.Size = new System.Drawing.Size(248, 43);
            this.export_btn.TabIndex = 5;
            this.export_btn.Text = "       Dışarı Aktar";
            this.export_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            this.export_btn.MouseEnter += new System.EventHandler(this.export_btn_MouseEnter);
            // 
            // share_btn
            // 
            this.share_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.share_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("share_btn.BackgroundImage")));
            this.share_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.share_btn.BorderColor = System.Drawing.Color.White;
            this.share_btn.BorderRadius = 10;
            this.share_btn.BorderSize = 0;
            this.share_btn.FlatAppearance.BorderSize = 0;
            this.share_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.share_btn.ForeColor = System.Drawing.Color.White;
            this.share_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.share_btn.Location = new System.Drawing.Point(3, 142);
            this.share_btn.Name = "share_btn";
            this.share_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.share_btn.Size = new System.Drawing.Size(248, 43);
            this.share_btn.TabIndex = 4;
            this.share_btn.Text = "       Paylaş";
            this.share_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.share_btn.UseVisualStyleBackColor = true;
            this.share_btn.Click += new System.EventHandler(this.share_btn_Click);
            this.share_btn.MouseEnter += new System.EventHandler(this.share_btn_MouseEnter);
            // 
            // fileLine1
            // 
            this.fileLine1.Image = ((System.Drawing.Image)(resources.GetObject("fileLine1.Image")));
            this.fileLine1.Location = new System.Drawing.Point(16, 136);
            this.fileLine1.Name = "fileLine1";
            this.fileLine1.Size = new System.Drawing.Size(222, 2);
            this.fileLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileLine1.TabIndex = 3;
            this.fileLine1.TabStop = false;
            // 
            // saveparent_btn
            // 
            this.saveparent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.saveparent_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveparent_btn.BackgroundImage")));
            this.saveparent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveparent_btn.BorderColor = System.Drawing.Color.White;
            this.saveparent_btn.BorderRadius = 10;
            this.saveparent_btn.BorderSize = 0;
            this.saveparent_btn.FlatAppearance.BorderSize = 0;
            this.saveparent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveparent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveparent_btn.ForeColor = System.Drawing.Color.White;
            this.saveparent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveparent_btn.Location = new System.Drawing.Point(3, 90);
            this.saveparent_btn.Name = "saveparent_btn";
            this.saveparent_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.saveparent_btn.Size = new System.Drawing.Size(248, 43);
            this.saveparent_btn.TabIndex = 2;
            this.saveparent_btn.Text = "       Kaydet";
            this.saveparent_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.saveparent_btn.UseVisualStyleBackColor = true;
            this.saveparent_btn.Click += new System.EventHandler(this.saveparent_btn_Click);
            this.saveparent_btn.MouseEnter += new System.EventHandler(this.saveparent_btn_MouseEnter);
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.open_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_btn.BackgroundImage")));
            this.open_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open_btn.BorderColor = System.Drawing.Color.White;
            this.open_btn.BorderRadius = 10;
            this.open_btn.BorderSize = 0;
            this.open_btn.FlatAppearance.BorderSize = 0;
            this.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.open_btn.ForeColor = System.Drawing.Color.White;
            this.open_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.open_btn.Location = new System.Drawing.Point(3, 47);
            this.open_btn.Name = "open_btn";
            this.open_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.open_btn.Size = new System.Drawing.Size(248, 43);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "       Aç";
            this.open_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            this.open_btn.MouseEnter += new System.EventHandler(this.open_btn_MouseEnter);
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.new_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("new_btn.BackgroundImage")));
            this.new_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.new_btn.BorderColor = System.Drawing.Color.White;
            this.new_btn.BorderRadius = 10;
            this.new_btn.BorderSize = 0;
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.new_btn.Location = new System.Drawing.Point(3, 4);
            this.new_btn.Name = "new_btn";
            this.new_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.new_btn.Size = new System.Drawing.Size(248, 43);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "       Yeni";
            this.new_btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            this.new_btn.MouseEnter += new System.EventHandler(this.new_btn_MouseEnter);
            // 
            // bulletListMenu
            // 
            this.bulletListMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bulletListMenu.BorderColor = System.Drawing.Color.White;
            this.bulletListMenu.BorderRadius = 15;
            this.bulletListMenu.BorderSize = 0;
            this.bulletListMenu.Controls.Add(this.bullet6_btn);
            this.bulletListMenu.Controls.Add(this.bullet4_btn);
            this.bulletListMenu.Controls.Add(this.bullet5_btn);
            this.bulletListMenu.Controls.Add(this.bullet2_btn);
            this.bulletListMenu.Controls.Add(this.bullet3_btn);
            this.bulletListMenu.Controls.Add(this.bullet1_btn);
            this.bulletListMenu.ForeColor = System.Drawing.Color.White;
            this.bulletListMenu.Location = new System.Drawing.Point(760, 159);
            this.bulletListMenu.Name = "bulletListMenu";
            this.bulletListMenu.Size = new System.Drawing.Size(196, 269);
            this.bulletListMenu.TabIndex = 57;
            this.bulletListMenu.Visible = false;
            // 
            // bullet6_btn
            // 
            this.bullet6_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet6_btn.BorderColor = System.Drawing.Color.White;
            this.bullet6_btn.BorderRadius = 15;
            this.bullet6_btn.BorderSize = 0;
            this.bullet6_btn.FlatAppearance.BorderSize = 0;
            this.bullet6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet6_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet6_btn.ForeColor = System.Drawing.Color.White;
            this.bullet6_btn.Location = new System.Drawing.Point(100, 178);
            this.bullet6_btn.Name = "bullet6_btn";
            this.bullet6_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet6_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet6_btn.TabIndex = 6;
            this.bullet6_btn.Text = "i.\r\nii.\r\niii.";
            this.bullet6_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet6_btn.UseVisualStyleBackColor = false;
            this.bullet6_btn.Click += new System.EventHandler(this.bullet6_btn_Click);
            // 
            // bullet4_btn
            // 
            this.bullet4_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet4_btn.BorderColor = System.Drawing.Color.White;
            this.bullet4_btn.BorderRadius = 15;
            this.bullet4_btn.BorderSize = 0;
            this.bullet4_btn.FlatAppearance.BorderSize = 0;
            this.bullet4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet4_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet4_btn.ForeColor = System.Drawing.Color.White;
            this.bullet4_btn.Location = new System.Drawing.Point(100, 92);
            this.bullet4_btn.Name = "bullet4_btn";
            this.bullet4_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet4_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet4_btn.TabIndex = 5;
            this.bullet4_btn.Text = "a)\r\nb)\r\nc)";
            this.bullet4_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet4_btn.UseVisualStyleBackColor = false;
            this.bullet4_btn.Click += new System.EventHandler(this.bullet4_btn_Click);
            // 
            // bullet5_btn
            // 
            this.bullet5_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet5_btn.BorderColor = System.Drawing.Color.White;
            this.bullet5_btn.BorderRadius = 15;
            this.bullet5_btn.BorderSize = 0;
            this.bullet5_btn.FlatAppearance.BorderSize = 0;
            this.bullet5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet5_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet5_btn.ForeColor = System.Drawing.Color.White;
            this.bullet5_btn.Location = new System.Drawing.Point(5, 178);
            this.bullet5_btn.Name = "bullet5_btn";
            this.bullet5_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet5_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet5_btn.TabIndex = 4;
            this.bullet5_btn.Text = "I.\r\nII.\r\nIII.";
            this.bullet5_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet5_btn.UseVisualStyleBackColor = false;
            this.bullet5_btn.Click += new System.EventHandler(this.bullet5_btn_Click);
            // 
            // bullet2_btn
            // 
            this.bullet2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet2_btn.BorderColor = System.Drawing.Color.White;
            this.bullet2_btn.BorderRadius = 15;
            this.bullet2_btn.BorderSize = 0;
            this.bullet2_btn.FlatAppearance.BorderSize = 0;
            this.bullet2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet2_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet2_btn.ForeColor = System.Drawing.Color.White;
            this.bullet2_btn.Location = new System.Drawing.Point(100, 6);
            this.bullet2_btn.Name = "bullet2_btn";
            this.bullet2_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet2_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet2_btn.TabIndex = 3;
            this.bullet2_btn.Text = "A)\r\nB)\r\nC)";
            this.bullet2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet2_btn.UseVisualStyleBackColor = false;
            this.bullet2_btn.Click += new System.EventHandler(this.bullet2_btn_Click);
            // 
            // bullet3_btn
            // 
            this.bullet3_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet3_btn.BorderColor = System.Drawing.Color.White;
            this.bullet3_btn.BorderRadius = 15;
            this.bullet3_btn.BorderSize = 0;
            this.bullet3_btn.FlatAppearance.BorderSize = 0;
            this.bullet3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet3_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet3_btn.ForeColor = System.Drawing.Color.White;
            this.bullet3_btn.Location = new System.Drawing.Point(5, 92);
            this.bullet3_btn.Name = "bullet3_btn";
            this.bullet3_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet3_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet3_btn.TabIndex = 2;
            this.bullet3_btn.Text = "1)\r\n2)\r\n3)";
            this.bullet3_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet3_btn.UseVisualStyleBackColor = false;
            this.bullet3_btn.Click += new System.EventHandler(this.bullet3_btn_Click);
            // 
            // bullet1_btn
            // 
            this.bullet1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bullet1_btn.BorderColor = System.Drawing.Color.White;
            this.bullet1_btn.BorderRadius = 15;
            this.bullet1_btn.BorderSize = 0;
            this.bullet1_btn.FlatAppearance.BorderSize = 0;
            this.bullet1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet1_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bullet1_btn.ForeColor = System.Drawing.Color.White;
            this.bullet1_btn.Location = new System.Drawing.Point(5, 6);
            this.bullet1_btn.Name = "bullet1_btn";
            this.bullet1_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bullet1_btn.Size = new System.Drawing.Size(89, 80);
            this.bullet1_btn.TabIndex = 1;
            this.bullet1_btn.Text = "1.\r\n2.\r\n3.";
            this.bullet1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bullet1_btn.UseVisualStyleBackColor = false;
            this.bullet1_btn.Click += new System.EventHandler(this.bullet1_btn_Click);
            // 
            // lineSpacing_menu
            // 
            this.lineSpacing_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lineSpacing_menu.BorderColor = System.Drawing.Color.White;
            this.lineSpacing_menu.BorderRadius = 15;
            this.lineSpacing_menu.BorderSize = 0;
            this.lineSpacing_menu.Controls.Add(this.lineSpacing_lbl);
            this.lineSpacing_menu.Controls.Add(this.lineSpacing_cmb);
            this.lineSpacing_menu.ForeColor = System.Drawing.Color.White;
            this.lineSpacing_menu.Location = new System.Drawing.Point(976, 246);
            this.lineSpacing_menu.Name = "lineSpacing_menu";
            this.lineSpacing_menu.Size = new System.Drawing.Size(139, 97);
            this.lineSpacing_menu.TabIndex = 19;
            this.lineSpacing_menu.Visible = false;
            // 
            // lineSpacing_lbl
            // 
            this.lineSpacing_lbl.AutoSize = true;
            this.lineSpacing_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineSpacing_lbl.Location = new System.Drawing.Point(13, 14);
            this.lineSpacing_lbl.Name = "lineSpacing_lbl";
            this.lineSpacing_lbl.Size = new System.Drawing.Size(107, 20);
            this.lineSpacing_lbl.TabIndex = 56;
            this.lineSpacing_lbl.Text = "Satır Aralığı:";
            // 
            // lineSpacing_cmb
            // 
            this.lineSpacing_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lineSpacing_cmb.Font = new System.Drawing.Font("Wanted Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineSpacing_cmb.ForeColor = System.Drawing.Color.White;
            this.lineSpacing_cmb.FormattingEnabled = true;
            this.lineSpacing_cmb.ItemHeight = 24;
            this.lineSpacing_cmb.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2"});
            this.lineSpacing_cmb.Location = new System.Drawing.Point(13, 45);
            this.lineSpacing_cmb.Name = "lineSpacing_cmb";
            this.lineSpacing_cmb.Size = new System.Drawing.Size(107, 32);
            this.lineSpacing_cmb.TabIndex = 55;
            this.lineSpacing_cmb.Text = "1";
            this.lineSpacing_cmb.SelectedIndexChanged += new System.EventHandler(this.lineSpacing_cmb_SelectedIndexChanged);
            // 
            // pageColorMenu
            // 
            this.pageColorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pageColorMenu.BorderColor = System.Drawing.Color.White;
            this.pageColorMenu.BorderRadius = 15;
            this.pageColorMenu.BorderSize = 0;
            this.pageColorMenu.Controls.Add(this.pageColorWhite_btn);
            this.pageColorMenu.Controls.Add(this.pageColorPink_btn);
            this.pageColorMenu.Controls.Add(this.pageColorPurple_btn);
            this.pageColorMenu.Controls.Add(this.pageColorDarkBlue_btn);
            this.pageColorMenu.Controls.Add(this.pageColorBlue_btn);
            this.pageColorMenu.Controls.Add(this.pageColorTurqoise_btn);
            this.pageColorMenu.Controls.Add(this.pageColorLime_btn);
            this.pageColorMenu.Controls.Add(this.pageColorSeaGreen_btn);
            this.pageColorMenu.Controls.Add(this.pageColorLightGreen_btn);
            this.pageColorMenu.Controls.Add(this.pageColorYellow_btn);
            this.pageColorMenu.Controls.Add(this.pageColorOrange_btn);
            this.pageColorMenu.Controls.Add(this.pageColorRed_btn);
            this.pageColorMenu.Controls.Add(this.pageColorBlue_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorGreen_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorRed_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorMenuIndicator);
            this.pageColorMenu.Controls.Add(this.pageColorBlueValue_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorGreenValue_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorRedValue_lbl);
            this.pageColorMenu.Controls.Add(this.pageColorSelectColor_btn);
            this.pageColorMenu.ForeColor = System.Drawing.Color.White;
            this.pageColorMenu.Location = new System.Drawing.Point(327, 255);
            this.pageColorMenu.Name = "pageColorMenu";
            this.pageColorMenu.Size = new System.Drawing.Size(294, 137);
            this.pageColorMenu.TabIndex = 67;
            this.pageColorMenu.Visible = false;
            // 
            // pageColorWhite_btn
            // 
            this.pageColorWhite_btn.BackColor = System.Drawing.Color.White;
            this.pageColorWhite_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorWhite_btn.BorderRadius = 0;
            this.pageColorWhite_btn.BorderSize = 0;
            this.pageColorWhite_btn.FlatAppearance.BorderSize = 0;
            this.pageColorWhite_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorWhite_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorWhite_btn.Location = new System.Drawing.Point(263, 63);
            this.pageColorWhite_btn.Name = "pageColorWhite_btn";
            this.pageColorWhite_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorWhite_btn.TabIndex = 30;
            this.pageColorWhite_btn.UseVisualStyleBackColor = false;
            this.pageColorWhite_btn.Click += new System.EventHandler(this.pageColorWhite_btn_Click);
            // 
            // pageColorPink_btn
            // 
            this.pageColorPink_btn.BackColor = System.Drawing.Color.Magenta;
            this.pageColorPink_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorPink_btn.BorderRadius = 0;
            this.pageColorPink_btn.BorderSize = 0;
            this.pageColorPink_btn.FlatAppearance.BorderSize = 0;
            this.pageColorPink_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorPink_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorPink_btn.Location = new System.Drawing.Point(238, 63);
            this.pageColorPink_btn.Name = "pageColorPink_btn";
            this.pageColorPink_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorPink_btn.TabIndex = 29;
            this.pageColorPink_btn.UseVisualStyleBackColor = false;
            this.pageColorPink_btn.Click += new System.EventHandler(this.pageColorPink_btn_Click);
            // 
            // pageColorPurple_btn
            // 
            this.pageColorPurple_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.pageColorPurple_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorPurple_btn.BorderRadius = 0;
            this.pageColorPurple_btn.BorderSize = 0;
            this.pageColorPurple_btn.FlatAppearance.BorderSize = 0;
            this.pageColorPurple_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorPurple_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorPurple_btn.Location = new System.Drawing.Point(213, 63);
            this.pageColorPurple_btn.Name = "pageColorPurple_btn";
            this.pageColorPurple_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorPurple_btn.TabIndex = 28;
            this.pageColorPurple_btn.UseVisualStyleBackColor = false;
            this.pageColorPurple_btn.Click += new System.EventHandler(this.pageColorPurple_btn_Click);
            // 
            // pageColorDarkBlue_btn
            // 
            this.pageColorDarkBlue_btn.BackColor = System.Drawing.Color.MediumBlue;
            this.pageColorDarkBlue_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorDarkBlue_btn.BorderRadius = 0;
            this.pageColorDarkBlue_btn.BorderSize = 0;
            this.pageColorDarkBlue_btn.FlatAppearance.BorderSize = 0;
            this.pageColorDarkBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorDarkBlue_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorDarkBlue_btn.Location = new System.Drawing.Point(188, 63);
            this.pageColorDarkBlue_btn.Name = "pageColorDarkBlue_btn";
            this.pageColorDarkBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorDarkBlue_btn.TabIndex = 27;
            this.pageColorDarkBlue_btn.UseVisualStyleBackColor = false;
            this.pageColorDarkBlue_btn.Click += new System.EventHandler(this.pageColorDarkBlue_btn_Click);
            // 
            // pageColorBlue_btn
            // 
            this.pageColorBlue_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.pageColorBlue_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorBlue_btn.BorderRadius = 0;
            this.pageColorBlue_btn.BorderSize = 0;
            this.pageColorBlue_btn.FlatAppearance.BorderSize = 0;
            this.pageColorBlue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorBlue_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorBlue_btn.Location = new System.Drawing.Point(263, 37);
            this.pageColorBlue_btn.Name = "pageColorBlue_btn";
            this.pageColorBlue_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorBlue_btn.TabIndex = 26;
            this.pageColorBlue_btn.UseVisualStyleBackColor = false;
            this.pageColorBlue_btn.Click += new System.EventHandler(this.pageColorBlue_btn_Click);
            // 
            // pageColorTurqoise_btn
            // 
            this.pageColorTurqoise_btn.BackColor = System.Drawing.Color.Turquoise;
            this.pageColorTurqoise_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorTurqoise_btn.BorderRadius = 0;
            this.pageColorTurqoise_btn.BorderSize = 0;
            this.pageColorTurqoise_btn.FlatAppearance.BorderSize = 0;
            this.pageColorTurqoise_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorTurqoise_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorTurqoise_btn.Location = new System.Drawing.Point(238, 37);
            this.pageColorTurqoise_btn.Name = "pageColorTurqoise_btn";
            this.pageColorTurqoise_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorTurqoise_btn.TabIndex = 25;
            this.pageColorTurqoise_btn.UseVisualStyleBackColor = false;
            this.pageColorTurqoise_btn.Click += new System.EventHandler(this.pageColorTurqoise_btn_Click);
            // 
            // pageColorLime_btn
            // 
            this.pageColorLime_btn.BackColor = System.Drawing.Color.Lime;
            this.pageColorLime_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorLime_btn.BorderRadius = 0;
            this.pageColorLime_btn.BorderSize = 0;
            this.pageColorLime_btn.FlatAppearance.BorderSize = 0;
            this.pageColorLime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorLime_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorLime_btn.Location = new System.Drawing.Point(213, 37);
            this.pageColorLime_btn.Name = "pageColorLime_btn";
            this.pageColorLime_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorLime_btn.TabIndex = 24;
            this.pageColorLime_btn.UseVisualStyleBackColor = false;
            this.pageColorLime_btn.Click += new System.EventHandler(this.pageColorLime_btn_Click);
            // 
            // pageColorSeaGreen_btn
            // 
            this.pageColorSeaGreen_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.pageColorSeaGreen_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorSeaGreen_btn.BorderRadius = 0;
            this.pageColorSeaGreen_btn.BorderSize = 0;
            this.pageColorSeaGreen_btn.FlatAppearance.BorderSize = 0;
            this.pageColorSeaGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorSeaGreen_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorSeaGreen_btn.Location = new System.Drawing.Point(188, 37);
            this.pageColorSeaGreen_btn.Name = "pageColorSeaGreen_btn";
            this.pageColorSeaGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorSeaGreen_btn.TabIndex = 23;
            this.pageColorSeaGreen_btn.UseVisualStyleBackColor = false;
            this.pageColorSeaGreen_btn.Click += new System.EventHandler(this.pageColorSeaGreen_btn_Click);
            // 
            // pageColorLightGreen_btn
            // 
            this.pageColorLightGreen_btn.BackColor = System.Drawing.Color.LightGreen;
            this.pageColorLightGreen_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorLightGreen_btn.BorderRadius = 0;
            this.pageColorLightGreen_btn.BorderSize = 0;
            this.pageColorLightGreen_btn.FlatAppearance.BorderSize = 0;
            this.pageColorLightGreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorLightGreen_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorLightGreen_btn.Location = new System.Drawing.Point(263, 11);
            this.pageColorLightGreen_btn.Name = "pageColorLightGreen_btn";
            this.pageColorLightGreen_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorLightGreen_btn.TabIndex = 22;
            this.pageColorLightGreen_btn.UseVisualStyleBackColor = false;
            this.pageColorLightGreen_btn.Click += new System.EventHandler(this.pageColorLightGreen_btn_Click);
            // 
            // pageColorYellow_btn
            // 
            this.pageColorYellow_btn.BackColor = System.Drawing.Color.Gold;
            this.pageColorYellow_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorYellow_btn.BorderRadius = 0;
            this.pageColorYellow_btn.BorderSize = 0;
            this.pageColorYellow_btn.FlatAppearance.BorderSize = 0;
            this.pageColorYellow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorYellow_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorYellow_btn.Location = new System.Drawing.Point(238, 11);
            this.pageColorYellow_btn.Name = "pageColorYellow_btn";
            this.pageColorYellow_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorYellow_btn.TabIndex = 21;
            this.pageColorYellow_btn.UseVisualStyleBackColor = false;
            this.pageColorYellow_btn.Click += new System.EventHandler(this.pageColorYellow_btn_Click);
            // 
            // pageColorOrange_btn
            // 
            this.pageColorOrange_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.pageColorOrange_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorOrange_btn.BorderRadius = 0;
            this.pageColorOrange_btn.BorderSize = 0;
            this.pageColorOrange_btn.FlatAppearance.BorderSize = 0;
            this.pageColorOrange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorOrange_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorOrange_btn.Location = new System.Drawing.Point(213, 11);
            this.pageColorOrange_btn.Name = "pageColorOrange_btn";
            this.pageColorOrange_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorOrange_btn.TabIndex = 20;
            this.pageColorOrange_btn.UseVisualStyleBackColor = false;
            this.pageColorOrange_btn.Click += new System.EventHandler(this.pageColorOrange_btn_Click);
            // 
            // pageColorRed_btn
            // 
            this.pageColorRed_btn.BackColor = System.Drawing.Color.Red;
            this.pageColorRed_btn.BorderColor = System.Drawing.Color.White;
            this.pageColorRed_btn.BorderRadius = 0;
            this.pageColorRed_btn.BorderSize = 0;
            this.pageColorRed_btn.FlatAppearance.BorderSize = 0;
            this.pageColorRed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorRed_btn.ForeColor = System.Drawing.Color.White;
            this.pageColorRed_btn.Location = new System.Drawing.Point(188, 11);
            this.pageColorRed_btn.Name = "pageColorRed_btn";
            this.pageColorRed_btn.Size = new System.Drawing.Size(20, 20);
            this.pageColorRed_btn.TabIndex = 19;
            this.pageColorRed_btn.UseVisualStyleBackColor = false;
            this.pageColorRed_btn.Click += new System.EventHandler(this.pageColorRed_btn_Click);
            // 
            // pageColorBlue_lbl
            // 
            this.pageColorBlue_lbl.AutoSize = true;
            this.pageColorBlue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorBlue_lbl.Location = new System.Drawing.Point(72, 62);
            this.pageColorBlue_lbl.Name = "pageColorBlue_lbl";
            this.pageColorBlue_lbl.Size = new System.Drawing.Size(29, 20);
            this.pageColorBlue_lbl.TabIndex = 18;
            this.pageColorBlue_lbl.Text = "M:";
            // 
            // pageColorGreen_lbl
            // 
            this.pageColorGreen_lbl.AutoSize = true;
            this.pageColorGreen_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorGreen_lbl.Location = new System.Drawing.Point(72, 37);
            this.pageColorGreen_lbl.Name = "pageColorGreen_lbl";
            this.pageColorGreen_lbl.Size = new System.Drawing.Size(26, 20);
            this.pageColorGreen_lbl.TabIndex = 17;
            this.pageColorGreen_lbl.Text = "Y:";
            // 
            // pageColorRed_lbl
            // 
            this.pageColorRed_lbl.AutoSize = true;
            this.pageColorRed_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorRed_lbl.Location = new System.Drawing.Point(72, 13);
            this.pageColorRed_lbl.Name = "pageColorRed_lbl";
            this.pageColorRed_lbl.Size = new System.Drawing.Size(25, 20);
            this.pageColorRed_lbl.TabIndex = 16;
            this.pageColorRed_lbl.Text = "K:";
            // 
            // pageColorMenuIndicator
            // 
            this.pageColorMenuIndicator.AutoSize = true;
            this.pageColorMenuIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.pageColorMenuIndicator.Font = new System.Drawing.Font("Wanted Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorMenuIndicator.Location = new System.Drawing.Point(18, 32);
            this.pageColorMenuIndicator.Name = "pageColorMenuIndicator";
            this.pageColorMenuIndicator.Size = new System.Drawing.Size(43, 34);
            this.pageColorMenuIndicator.TabIndex = 15;
            this.pageColorMenuIndicator.Text = "    ";
            this.pageColorMenuIndicator.BackColorChanged += new System.EventHandler(this.pageColorMenuIndicator_BackColorChanged);
            // 
            // pageColorBlueValue_lbl
            // 
            this.pageColorBlueValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pageColorBlueValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageColorBlueValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorBlueValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.pageColorBlueValue_lbl.Location = new System.Drawing.Point(103, 66);
            this.pageColorBlueValue_lbl.Name = "pageColorBlueValue_lbl";
            this.pageColorBlueValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.pageColorBlueValue_lbl.TabIndex = 14;
            this.pageColorBlueValue_lbl.Text = "103";
            // 
            // pageColorGreenValue_lbl
            // 
            this.pageColorGreenValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pageColorGreenValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageColorGreenValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorGreenValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.pageColorGreenValue_lbl.Location = new System.Drawing.Point(103, 40);
            this.pageColorGreenValue_lbl.Name = "pageColorGreenValue_lbl";
            this.pageColorGreenValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.pageColorGreenValue_lbl.TabIndex = 13;
            this.pageColorGreenValue_lbl.Text = "103";
            // 
            // pageColorRedValue_lbl
            // 
            this.pageColorRedValue_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pageColorRedValue_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageColorRedValue_lbl.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorRedValue_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.pageColorRedValue_lbl.Location = new System.Drawing.Point(103, 15);
            this.pageColorRedValue_lbl.Name = "pageColorRedValue_lbl";
            this.pageColorRedValue_lbl.Size = new System.Drawing.Size(78, 21);
            this.pageColorRedValue_lbl.TabIndex = 12;
            this.pageColorRedValue_lbl.Text = "103";
            // 
            // pageColorSelectColor_btn
            // 
            this.pageColorSelectColor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pageColorSelectColor_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pageColorSelectColor_btn.BorderRadius = 10;
            this.pageColorSelectColor_btn.BorderSize = 0;
            this.pageColorSelectColor_btn.FlatAppearance.BorderSize = 0;
            this.pageColorSelectColor_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pageColorSelectColor_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pageColorSelectColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColorSelectColor_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColorSelectColor_btn.ForeColor = System.Drawing.Color.LightGray;
            this.pageColorSelectColor_btn.Location = new System.Drawing.Point(5, 91);
            this.pageColorSelectColor_btn.Name = "pageColorSelectColor_btn";
            this.pageColorSelectColor_btn.Size = new System.Drawing.Size(281, 40);
            this.pageColorSelectColor_btn.TabIndex = 11;
            this.pageColorSelectColor_btn.Text = "Özel Renk Seç";
            this.pageColorSelectColor_btn.UseVisualStyleBackColor = false;
            this.pageColorSelectColor_btn.Click += new System.EventHandler(this.pageColorSelectColor_btn_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.statusBar.BorderColor = System.Drawing.Color.White;
            this.statusBar.BorderRadius = 10;
            this.statusBar.BorderSize = 0;
            this.statusBar.Controls.Add(this.subStatusBar);
            this.statusBar.ForeColor = System.Drawing.Color.White;
            this.statusBar.Location = new System.Drawing.Point(5, 820);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1853, 34);
            this.statusBar.TabIndex = 64;
            // 
            // subStatusBar
            // 
            this.subStatusBar.Controls.Add(this.statusBarZoom_lbl);
            this.subStatusBar.Controls.Add(this.statusBarZoom_trck);
            this.subStatusBar.Controls.Add(this.numberOfCharacters_lbl);
            this.subStatusBar.Controls.Add(this.numberOfPages_lbl);
            this.subStatusBar.Controls.Add(this.OSandFormatting_lbl);
            this.subStatusBar.Location = new System.Drawing.Point(-6, -32);
            this.subStatusBar.Name = "subStatusBar";
            this.subStatusBar.Size = new System.Drawing.Size(2143, 132);
            this.subStatusBar.TabIndex = 5;
            // 
            // statusBarZoom_lbl
            // 
            this.statusBarZoom_lbl.AutoSize = true;
            this.statusBarZoom_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBarZoom_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.statusBarZoom_lbl.Location = new System.Drawing.Point(1795, 42);
            this.statusBarZoom_lbl.Name = "statusBarZoom_lbl";
            this.statusBarZoom_lbl.Size = new System.Drawing.Size(49, 18);
            this.statusBarZoom_lbl.TabIndex = 2;
            this.statusBarZoom_lbl.Text = "%100";
            // 
            // statusBarZoom_trck
            // 
            this.statusBarZoom_trck.LargeChange = 50;
            this.statusBarZoom_trck.Location = new System.Drawing.Point(1650, 35);
            this.statusBarZoom_trck.Maximum = 400;
            this.statusBarZoom_trck.Minimum = 50;
            this.statusBarZoom_trck.Name = "statusBarZoom_trck";
            this.statusBarZoom_trck.Size = new System.Drawing.Size(137, 56);
            this.statusBarZoom_trck.SmallChange = 25;
            this.statusBarZoom_trck.TabIndex = 3;
            this.statusBarZoom_trck.TickFrequency = 50;
            this.statusBarZoom_trck.TickStyle = System.Windows.Forms.TickStyle.None;
            this.statusBarZoom_trck.Value = 100;
            this.statusBarZoom_trck.ValueChanged += new System.EventHandler(this.statusBarZoom_trck_ValueChanged);
            // 
            // numberOfCharacters_lbl
            // 
            this.numberOfCharacters_lbl.AutoSize = true;
            this.numberOfCharacters_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfCharacters_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.numberOfCharacters_lbl.Location = new System.Drawing.Point(327, 42);
            this.numberOfCharacters_lbl.Name = "numberOfCharacters_lbl";
            this.numberOfCharacters_lbl.Size = new System.Drawing.Size(108, 18);
            this.numberOfCharacters_lbl.TabIndex = 1;
            this.numberOfCharacters_lbl.Text = "Karakterler: 0";
            // 
            // numberOfPages_lbl
            // 
            this.numberOfPages_lbl.AutoSize = true;
            this.numberOfPages_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfPages_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.numberOfPages_lbl.Location = new System.Drawing.Point(204, 42);
            this.numberOfPages_lbl.Name = "numberOfPages_lbl";
            this.numberOfPages_lbl.Size = new System.Drawing.Size(84, 18);
            this.numberOfPages_lbl.TabIndex = 4;
            this.numberOfPages_lbl.Text = "Sayfalar: 1";
            // 
            // OSandFormatting_lbl
            // 
            this.OSandFormatting_lbl.AutoSize = true;
            this.OSandFormatting_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OSandFormatting_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.OSandFormatting_lbl.Location = new System.Drawing.Point(21, 42);
            this.OSandFormatting_lbl.Name = "OSandFormatting_lbl";
            this.OSandFormatting_lbl.Size = new System.Drawing.Size(139, 18);
            this.OSandFormatting_lbl.TabIndex = 0;
            this.OSandFormatting_lbl.Text = "Windows 11, UTF8";
            // 
            // rulerMenu
            // 
            this.rulerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.rulerMenu.BorderColor = System.Drawing.Color.White;
            this.rulerMenu.BorderRadius = 10;
            this.rulerMenu.BorderSize = 0;
            this.rulerMenu.Controls.Add(this.subRulerMenu);
            this.rulerMenu.ForeColor = System.Drawing.Color.White;
            this.rulerMenu.Location = new System.Drawing.Point(204, 278);
            this.rulerMenu.Name = "rulerMenu";
            this.rulerMenu.Size = new System.Drawing.Size(1515, 38);
            this.rulerMenu.TabIndex = 68;
            // 
            // subRulerMenu
            // 
            this.subRulerMenu.Controls.Add(this.ruler);
            this.subRulerMenu.Location = new System.Drawing.Point(-36, -24);
            this.subRulerMenu.Name = "subRulerMenu";
            this.subRulerMenu.Size = new System.Drawing.Size(1932, 127);
            this.subRulerMenu.TabIndex = 1;
            // 
            // ruler
            // 
            this.ruler.LargeChange = 10;
            this.ruler.Location = new System.Drawing.Point(21, 27);
            this.ruler.Maximum = 300;
            this.ruler.Name = "ruler";
            this.ruler.Size = new System.Drawing.Size(1530, 56);
            this.ruler.SmallChange = 5;
            this.ruler.TabIndex = 0;
            this.ruler.TickFrequency = 5;
            this.ruler.Value = 10;
            this.ruler.ValueChanged += new System.EventHandler(this.ruler_ValueChanged);
            // 
            // appearenceMenu
            // 
            this.appearenceMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appearenceMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.appearenceMenu.BorderColor = System.Drawing.Color.White;
            this.appearenceMenu.BorderRadius = 0;
            this.appearenceMenu.BorderSize = 0;
            this.appearenceMenu.Controls.Add(this.zoomMenu);
            this.appearenceMenu.Controls.Add(this.zoom_lbl);
            this.appearenceMenu.Controls.Add(this.apprLine3);
            this.appearenceMenu.Controls.Add(this.darkTheme_btn);
            this.appearenceMenu.Controls.Add(this.lightTheme_btn);
            this.appearenceMenu.Controls.Add(this.theme_lbl);
            this.appearenceMenu.Controls.Add(this.apprLine2);
            this.appearenceMenu.Controls.Add(this.zoomcategory_lbl);
            this.appearenceMenu.Controls.Add(this.defaultZoom_btn);
            this.appearenceMenu.Controls.Add(this.zoom_btn);
            this.appearenceMenu.Controls.Add(this.apprLine1);
            this.appearenceMenu.Controls.Add(this.statusbar_btn);
            this.appearenceMenu.Controls.Add(this.ruler_btn);
            this.appearenceMenu.Controls.Add(this.show_lbl);
            this.appearenceMenu.ForeColor = System.Drawing.Color.White;
            this.appearenceMenu.Location = new System.Drawing.Point(-1, 104);
            this.appearenceMenu.Name = "appearenceMenu";
            this.appearenceMenu.Size = new System.Drawing.Size(1748, 151);
            this.appearenceMenu.TabIndex = 62;
            this.appearenceMenu.Visible = false;
            // 
            // zoomMenu
            // 
            this.zoomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.zoomMenu.BorderColor = System.Drawing.Color.White;
            this.zoomMenu.BorderRadius = 8;
            this.zoomMenu.BorderSize = 0;
            this.zoomMenu.Controls.Add(this.zoomDecrease_btn);
            this.zoomMenu.Controls.Add(this.zoomIncrease_btn);
            this.zoomMenu.Controls.Add(this.zoomTrackBar1);
            this.zoomMenu.ForeColor = System.Drawing.Color.White;
            this.zoomMenu.Location = new System.Drawing.Point(261, 55);
            this.zoomMenu.Name = "zoomMenu";
            this.zoomMenu.Size = new System.Drawing.Size(217, 52);
            this.zoomMenu.TabIndex = 43;
            this.zoomMenu.Visible = false;
            // 
            // zoomDecrease_btn
            // 
            this.zoomDecrease_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.zoomDecrease_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.zoomDecrease_btn.BorderRadius = 7;
            this.zoomDecrease_btn.BorderSize = 0;
            this.zoomDecrease_btn.FlatAppearance.BorderSize = 0;
            this.zoomDecrease_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.zoomDecrease_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.zoomDecrease_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomDecrease_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoomDecrease_btn.ForeColor = System.Drawing.Color.LightGray;
            this.zoomDecrease_btn.Image = ((System.Drawing.Image)(resources.GetObject("zoomDecrease_btn.Image")));
            this.zoomDecrease_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomDecrease_btn.Location = new System.Drawing.Point(11, 9);
            this.zoomDecrease_btn.Name = "zoomDecrease_btn";
            this.zoomDecrease_btn.Size = new System.Drawing.Size(34, 35);
            this.zoomDecrease_btn.TabIndex = 45;
            this.zoomDecrease_btn.Text = "        Yakınlaştır";
            this.zoomDecrease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomDecrease_btn.UseVisualStyleBackColor = false;
            this.zoomDecrease_btn.Click += new System.EventHandler(this.zoomDecrease_btn_Click);
            // 
            // zoomIncrease_btn
            // 
            this.zoomIncrease_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.zoomIncrease_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.zoomIncrease_btn.BorderRadius = 7;
            this.zoomIncrease_btn.BorderSize = 0;
            this.zoomIncrease_btn.FlatAppearance.BorderSize = 0;
            this.zoomIncrease_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.zoomIncrease_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.zoomIncrease_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomIncrease_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoomIncrease_btn.ForeColor = System.Drawing.Color.LightGray;
            this.zoomIncrease_btn.Image = ((System.Drawing.Image)(resources.GetObject("zoomIncrease_btn.Image")));
            this.zoomIncrease_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomIncrease_btn.Location = new System.Drawing.Point(178, 9);
            this.zoomIncrease_btn.Name = "zoomIncrease_btn";
            this.zoomIncrease_btn.Size = new System.Drawing.Size(34, 35);
            this.zoomIncrease_btn.TabIndex = 44;
            this.zoomIncrease_btn.Text = "        Yakınlaştır";
            this.zoomIncrease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomIncrease_btn.UseVisualStyleBackColor = false;
            this.zoomIncrease_btn.Click += new System.EventHandler(this.zoomIncrease_btn_Click);
            // 
            // zoomTrackBar1
            // 
            this.zoomTrackBar1.LargeChange = 50;
            this.zoomTrackBar1.Location = new System.Drawing.Point(43, 15);
            this.zoomTrackBar1.Maximum = 400;
            this.zoomTrackBar1.Minimum = 50;
            this.zoomTrackBar1.Name = "zoomTrackBar1";
            this.zoomTrackBar1.Size = new System.Drawing.Size(137, 56);
            this.zoomTrackBar1.SmallChange = 25;
            this.zoomTrackBar1.TabIndex = 4;
            this.zoomTrackBar1.TickFrequency = 50;
            this.zoomTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomTrackBar1.Value = 100;
            this.zoomTrackBar1.ValueChanged += new System.EventHandler(this.zoomTrackBar1_ValueChanged);
            // 
            // zoom_lbl
            // 
            this.zoom_lbl.AutoSize = true;
            this.zoom_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoom_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zoom_lbl.Location = new System.Drawing.Point(254, 105);
            this.zoom_lbl.Name = "zoom_lbl";
            this.zoom_lbl.Size = new System.Drawing.Size(46, 18);
            this.zoom_lbl.TabIndex = 42;
            this.zoom_lbl.Text = "%100";
            // 
            // apprLine3
            // 
            this.apprLine3.Image = ((System.Drawing.Image)(resources.GetObject("apprLine3.Image")));
            this.apprLine3.Location = new System.Drawing.Point(723, 20);
            this.apprLine3.Name = "apprLine3";
            this.apprLine3.Size = new System.Drawing.Size(3, 115);
            this.apprLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apprLine3.TabIndex = 41;
            this.apprLine3.TabStop = false;
            // 
            // darkTheme_btn
            // 
            this.darkTheme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.darkTheme_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.darkTheme_btn.BorderRadius = 7;
            this.darkTheme_btn.BorderSize = 0;
            this.darkTheme_btn.FlatAppearance.BorderSize = 0;
            this.darkTheme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkTheme_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.darkTheme_btn.ForeColor = System.Drawing.Color.LightGray;
            this.darkTheme_btn.Image = ((System.Drawing.Image)(resources.GetObject("darkTheme_btn.Image")));
            this.darkTheme_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.darkTheme_btn.Location = new System.Drawing.Point(502, 63);
            this.darkTheme_btn.Name = "darkTheme_btn";
            this.darkTheme_btn.Size = new System.Drawing.Size(200, 35);
            this.darkTheme_btn.TabIndex = 40;
            this.darkTheme_btn.Text = "        Koyu Mod";
            this.darkTheme_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.darkTheme_btn.UseVisualStyleBackColor = false;
            this.darkTheme_btn.Click += new System.EventHandler(this.darkTheme_btn_Click);
            // 
            // lightTheme_btn
            // 
            this.lightTheme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lightTheme_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.lightTheme_btn.BorderRadius = 7;
            this.lightTheme_btn.BorderSize = 1;
            this.lightTheme_btn.FlatAppearance.BorderSize = 0;
            this.lightTheme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightTheme_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lightTheme_btn.ForeColor = System.Drawing.Color.LightGray;
            this.lightTheme_btn.Image = ((System.Drawing.Image)(resources.GetObject("lightTheme_btn.Image")));
            this.lightTheme_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightTheme_btn.Location = new System.Drawing.Point(502, 19);
            this.lightTheme_btn.Name = "lightTheme_btn";
            this.lightTheme_btn.Size = new System.Drawing.Size(200, 35);
            this.lightTheme_btn.TabIndex = 39;
            this.lightTheme_btn.Text = "        Açık Mod";
            this.lightTheme_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightTheme_btn.UseVisualStyleBackColor = false;
            this.lightTheme_btn.Click += new System.EventHandler(this.lightTheme_btn_Click);
            // 
            // theme_lbl
            // 
            this.theme_lbl.AutoSize = true;
            this.theme_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.theme_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.theme_lbl.Location = new System.Drawing.Point(578, 129);
            this.theme_lbl.Name = "theme_lbl";
            this.theme_lbl.Size = new System.Drawing.Size(46, 18);
            this.theme_lbl.TabIndex = 38;
            this.theme_lbl.Text = "Tema";
            // 
            // apprLine2
            // 
            this.apprLine2.Image = ((System.Drawing.Image)(resources.GetObject("apprLine2.Image")));
            this.apprLine2.Location = new System.Drawing.Point(484, 20);
            this.apprLine2.Name = "apprLine2";
            this.apprLine2.Size = new System.Drawing.Size(3, 115);
            this.apprLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apprLine2.TabIndex = 37;
            this.apprLine2.TabStop = false;
            // 
            // zoomcategory_lbl
            // 
            this.zoomcategory_lbl.AutoSize = true;
            this.zoomcategory_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoomcategory_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zoomcategory_lbl.Location = new System.Drawing.Point(329, 129);
            this.zoomcategory_lbl.Name = "zoomcategory_lbl";
            this.zoomcategory_lbl.Size = new System.Drawing.Size(77, 18);
            this.zoomcategory_lbl.TabIndex = 36;
            this.zoomcategory_lbl.Text = "Yakınlaştır";
            // 
            // defaultZoom_btn
            // 
            this.defaultZoom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.defaultZoom_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.defaultZoom_btn.BorderRadius = 7;
            this.defaultZoom_btn.BorderSize = 0;
            this.defaultZoom_btn.FlatAppearance.BorderSize = 0;
            this.defaultZoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultZoom_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.defaultZoom_btn.ForeColor = System.Drawing.Color.LightGray;
            this.defaultZoom_btn.Image = ((System.Drawing.Image)(resources.GetObject("defaultZoom_btn.Image")));
            this.defaultZoom_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.defaultZoom_btn.Location = new System.Drawing.Point(257, 63);
            this.defaultZoom_btn.Name = "defaultZoom_btn";
            this.defaultZoom_btn.Size = new System.Drawing.Size(209, 35);
            this.defaultZoom_btn.TabIndex = 35;
            this.defaultZoom_btn.Text = "        Varsayılan Ayar";
            this.defaultZoom_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.defaultZoom_btn.UseVisualStyleBackColor = false;
            this.defaultZoom_btn.Click += new System.EventHandler(this.defaultZoom_btn_Click);
            // 
            // zoom_btn
            // 
            this.zoom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.zoom_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.zoom_btn.BorderRadius = 7;
            this.zoom_btn.BorderSize = 0;
            this.zoom_btn.FlatAppearance.BorderSize = 0;
            this.zoom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoom_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoom_btn.ForeColor = System.Drawing.Color.LightGray;
            this.zoom_btn.Image = ((System.Drawing.Image)(resources.GetObject("zoom_btn.Image")));
            this.zoom_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoom_btn.Location = new System.Drawing.Point(257, 19);
            this.zoom_btn.Name = "zoom_btn";
            this.zoom_btn.Size = new System.Drawing.Size(212, 35);
            this.zoom_btn.TabIndex = 29;
            this.zoom_btn.Text = "        Yakınlaştır";
            this.zoom_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoom_btn.UseVisualStyleBackColor = false;
            this.zoom_btn.Click += new System.EventHandler(this.zoom_btn_Click);
            // 
            // apprLine1
            // 
            this.apprLine1.Image = ((System.Drawing.Image)(resources.GetObject("apprLine1.Image")));
            this.apprLine1.Location = new System.Drawing.Point(245, 19);
            this.apprLine1.Name = "apprLine1";
            this.apprLine1.Size = new System.Drawing.Size(3, 115);
            this.apprLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apprLine1.TabIndex = 28;
            this.apprLine1.TabStop = false;
            // 
            // statusbar_btn
            // 
            this.statusbar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.statusbar_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.statusbar_btn.BorderRadius = 7;
            this.statusbar_btn.BorderSize = 1;
            this.statusbar_btn.FlatAppearance.BorderSize = 0;
            this.statusbar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusbar_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusbar_btn.ForeColor = System.Drawing.Color.LightGray;
            this.statusbar_btn.Image = ((System.Drawing.Image)(resources.GetObject("statusbar_btn.Image")));
            this.statusbar_btn.Location = new System.Drawing.Point(130, 10);
            this.statusbar_btn.Name = "statusbar_btn";
            this.statusbar_btn.Size = new System.Drawing.Size(100, 110);
            this.statusbar_btn.TabIndex = 24;
            this.statusbar_btn.Text = "Durum Çubuğu";
            this.statusbar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statusbar_btn.UseVisualStyleBackColor = false;
            this.statusbar_btn.Click += new System.EventHandler(this.statusbar_btn_Click);
            // 
            // ruler_btn
            // 
            this.ruler_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ruler_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ruler_btn.BorderRadius = 7;
            this.ruler_btn.BorderSize = 1;
            this.ruler_btn.FlatAppearance.BorderSize = 0;
            this.ruler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruler_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ruler_btn.ForeColor = System.Drawing.Color.LightGray;
            this.ruler_btn.Image = ((System.Drawing.Image)(resources.GetObject("ruler_btn.Image")));
            this.ruler_btn.Location = new System.Drawing.Point(16, 10);
            this.ruler_btn.Name = "ruler_btn";
            this.ruler_btn.Size = new System.Drawing.Size(100, 110);
            this.ruler_btn.TabIndex = 23;
            this.ruler_btn.Text = "Cetvel";
            this.ruler_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ruler_btn.UseVisualStyleBackColor = false;
            this.ruler_btn.Click += new System.EventHandler(this.ruler_btn_Click);
            // 
            // show_lbl
            // 
            this.show_lbl.AutoSize = true;
            this.show_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.show_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_lbl.Location = new System.Drawing.Point(95, 129);
            this.show_lbl.Name = "show_lbl";
            this.show_lbl.Size = new System.Drawing.Size(57, 18);
            this.show_lbl.TabIndex = 21;
            this.show_lbl.Text = "Göster";
            // 
            // toolbarMenu
            // 
            this.toolbarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolbarMenu.BorderColor = System.Drawing.Color.White;
            this.toolbarMenu.BorderRadius = 0;
            this.toolbarMenu.BorderSize = 0;
            this.toolbarMenu.Controls.Add(this.textTemplatesMenu);
            this.toolbarMenu.Controls.Add(this.searchParent_btn);
            this.toolbarMenu.Controls.Add(this.findParent_btn);
            this.toolbarMenu.Controls.Add(this.subscript_btn);
            this.toolbarMenu.Controls.Add(this.superscript_btn);
            this.toolbarMenu.Controls.Add(this.lock_btn);
            this.toolbarMenu.Controls.Add(this.lineGap_btn);
            this.toolbarMenu.Controls.Add(this.unlock_btn);
            this.toolbarMenu.Controls.Add(this.increaseIndent_btn);
            this.toolbarMenu.Controls.Add(this.decreaseIndent_btn);
            this.toolbarMenu.Controls.Add(this.bulletList_btn);
            this.toolbarMenu.Controls.Add(this.alignToRight_btn);
            this.toolbarMenu.Controls.Add(this.alignToMiddle_btn);
            this.toolbarMenu.Controls.Add(this.alignToLeft_btn);
            this.toolbarMenu.Controls.Add(this.characterGap_btn);
            this.toolbarMenu.Controls.Add(this.deleteForming_btn);
            this.toolbarMenu.Controls.Add(this.highlightColorIndicator);
            this.toolbarMenu.Controls.Add(this.highlight_btn);
            this.toolbarMenu.Controls.Add(this.decreaseFontSize_btn);
            this.toolbarMenu.Controls.Add(this.increaseFontSize_btn);
            this.toolbarMenu.Controls.Add(this.textColorIndicator);
            this.toolbarMenu.Controls.Add(this.textcolor_btn);
            this.toolbarMenu.Controls.Add(this.strikethrough_btn);
            this.toolbarMenu.Controls.Add(this.underlined_btn);
            this.toolbarMenu.Controls.Add(this.italic_btn);
            this.toolbarMenu.Controls.Add(this.bold_btn);
            this.toolbarMenu.Controls.Add(this.fontSizeSelector_cmb);
            this.toolbarMenu.Controls.Add(this.fontSelector_cmb);
            this.toolbarMenu.Controls.Add(this.toolsLine5);
            this.toolbarMenu.Controls.Add(this.textTemplates_lbl);
            this.toolbarMenu.Controls.Add(this.toolsLine4);
            this.toolbarMenu.Controls.Add(this.search_lbl);
            this.toolbarMenu.Controls.Add(this.toolsLine3);
            this.toolbarMenu.Controls.Add(this.paragraph_lbl);
            this.toolbarMenu.Controls.Add(this.toolsLine2);
            this.toolbarMenu.Controls.Add(this.font_lbl);
            this.toolbarMenu.Controls.Add(this.select_btn);
            this.toolbarMenu.Controls.Add(this.selectall_btn);
            this.toolbarMenu.Controls.Add(this.redo_btn);
            this.toolbarMenu.Controls.Add(this.undo_btn);
            this.toolbarMenu.Controls.Add(this.toolsLine1);
            this.toolbarMenu.Controls.Add(this.general_lbl);
            this.toolbarMenu.Controls.Add(this.cut_btn);
            this.toolbarMenu.Controls.Add(this.copy_btn);
            this.toolbarMenu.Controls.Add(this.paste_btn);
            this.toolbarMenu.ForeColor = System.Drawing.Color.White;
            this.toolbarMenu.Location = new System.Drawing.Point(0, 105);
            this.toolbarMenu.Name = "toolbarMenu";
            this.toolbarMenu.Size = new System.Drawing.Size(1789, 153);
            this.toolbarMenu.TabIndex = 18;
            // 
            // textTemplatesMenu
            // 
            this.textTemplatesMenu.AutoScroll = true;
            this.textTemplatesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textTemplatesMenu.Controls.Add(this.defaultTextTemplate_btn);
            this.textTemplatesMenu.Controls.Add(this.bodyText_btn);
            this.textTemplatesMenu.Controls.Add(this.title1_btn);
            this.textTemplatesMenu.Controls.Add(this.title2_btn);
            this.textTemplatesMenu.Controls.Add(this.subtitle_btn);
            this.textTemplatesMenu.Location = new System.Drawing.Point(1195, 21);
            this.textTemplatesMenu.Name = "textTemplatesMenu";
            this.textTemplatesMenu.Size = new System.Drawing.Size(390, 100);
            this.textTemplatesMenu.TabIndex = 54;
            // 
            // defaultTextTemplate_btn
            // 
            this.defaultTextTemplate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.defaultTextTemplate_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.defaultTextTemplate_btn.BorderRadius = 10;
            this.defaultTextTemplate_btn.BorderSize = 0;
            this.defaultTextTemplate_btn.FlatAppearance.BorderSize = 0;
            this.defaultTextTemplate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultTextTemplate_btn.Font = new System.Drawing.Font("Wanted Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.defaultTextTemplate_btn.ForeColor = System.Drawing.Color.LightGray;
            this.defaultTextTemplate_btn.Location = new System.Drawing.Point(3, 3);
            this.defaultTextTemplate_btn.Name = "defaultTextTemplate_btn";
            this.defaultTextTemplate_btn.Size = new System.Drawing.Size(174, 78);
            this.defaultTextTemplate_btn.TabIndex = 11;
            this.defaultTextTemplate_btn.Text = "Varsayılan Paragraf";
            this.defaultTextTemplate_btn.UseVisualStyleBackColor = false;
            this.defaultTextTemplate_btn.Click += new System.EventHandler(this.defaultTextTemplate_btn_Click);
            // 
            // bodyText_btn
            // 
            this.bodyText_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bodyText_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.bodyText_btn.BorderRadius = 10;
            this.bodyText_btn.BorderSize = 0;
            this.bodyText_btn.FlatAppearance.BorderSize = 0;
            this.bodyText_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyText_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bodyText_btn.ForeColor = System.Drawing.Color.LightGray;
            this.bodyText_btn.Location = new System.Drawing.Point(183, 3);
            this.bodyText_btn.Name = "bodyText_btn";
            this.bodyText_btn.Size = new System.Drawing.Size(173, 78);
            this.bodyText_btn.TabIndex = 12;
            this.bodyText_btn.Text = "Gövde Metni";
            this.bodyText_btn.UseVisualStyleBackColor = false;
            this.bodyText_btn.Click += new System.EventHandler(this.bodyText_btn_Click);
            // 
            // title1_btn
            // 
            this.title1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.title1_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title1_btn.BorderRadius = 10;
            this.title1_btn.BorderSize = 0;
            this.title1_btn.FlatAppearance.BorderSize = 0;
            this.title1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title1_btn.Font = new System.Drawing.Font("Wanted Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title1_btn.ForeColor = System.Drawing.Color.LightGray;
            this.title1_btn.Location = new System.Drawing.Point(3, 87);
            this.title1_btn.Name = "title1_btn";
            this.title1_btn.Size = new System.Drawing.Size(174, 78);
            this.title1_btn.TabIndex = 13;
            this.title1_btn.Text = "Başlık 1";
            this.title1_btn.UseVisualStyleBackColor = false;
            this.title1_btn.Click += new System.EventHandler(this.title1_btn_Click);
            // 
            // title2_btn
            // 
            this.title2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.title2_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title2_btn.BorderRadius = 10;
            this.title2_btn.BorderSize = 0;
            this.title2_btn.FlatAppearance.BorderSize = 0;
            this.title2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title2_btn.Font = new System.Drawing.Font("Wanted Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title2_btn.ForeColor = System.Drawing.Color.LightGray;
            this.title2_btn.Location = new System.Drawing.Point(183, 87);
            this.title2_btn.Name = "title2_btn";
            this.title2_btn.Size = new System.Drawing.Size(173, 78);
            this.title2_btn.TabIndex = 14;
            this.title2_btn.Text = "Başlık 2";
            this.title2_btn.UseVisualStyleBackColor = false;
            this.title2_btn.Click += new System.EventHandler(this.title2_btn_Click);
            // 
            // subtitle_btn
            // 
            this.subtitle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.subtitle_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.subtitle_btn.BorderRadius = 10;
            this.subtitle_btn.BorderSize = 0;
            this.subtitle_btn.FlatAppearance.BorderSize = 0;
            this.subtitle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitle_btn.Font = new System.Drawing.Font("Wanted Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtitle_btn.ForeColor = System.Drawing.Color.LightGray;
            this.subtitle_btn.Location = new System.Drawing.Point(3, 171);
            this.subtitle_btn.Name = "subtitle_btn";
            this.subtitle_btn.Size = new System.Drawing.Size(206, 78);
            this.subtitle_btn.TabIndex = 15;
            this.subtitle_btn.Text = "Alt Başlık";
            this.subtitle_btn.UseVisualStyleBackColor = false;
            this.subtitle_btn.Click += new System.EventHandler(this.subtitle_btn_Click);
            // 
            // searchParent_btn
            // 
            this.searchParent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.searchParent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.searchParent_btn.BorderRadius = 7;
            this.searchParent_btn.BorderSize = 0;
            this.searchParent_btn.FlatAppearance.BorderSize = 0;
            this.searchParent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchParent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchParent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.searchParent_btn.Image = ((System.Drawing.Image)(resources.GetObject("searchParent_btn.Image")));
            this.searchParent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchParent_btn.Location = new System.Drawing.Point(1044, 57);
            this.searchParent_btn.Name = "searchParent_btn";
            this.searchParent_btn.Size = new System.Drawing.Size(131, 35);
            this.searchParent_btn.TabIndex = 53;
            this.searchParent_btn.Text = "        Ara";
            this.searchParent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchParent_btn.UseVisualStyleBackColor = false;
            this.searchParent_btn.Click += new System.EventHandler(this.searchParent_btn_Click);
            // 
            // findParent_btn
            // 
            this.findParent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.findParent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.findParent_btn.BorderRadius = 7;
            this.findParent_btn.BorderSize = 0;
            this.findParent_btn.FlatAppearance.BorderSize = 0;
            this.findParent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findParent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findParent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.findParent_btn.Image = ((System.Drawing.Image)(resources.GetObject("findParent_btn.Image")));
            this.findParent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findParent_btn.Location = new System.Drawing.Point(1044, 20);
            this.findParent_btn.Name = "findParent_btn";
            this.findParent_btn.Size = new System.Drawing.Size(131, 35);
            this.findParent_btn.TabIndex = 52;
            this.findParent_btn.Text = "        Bul";
            this.findParent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findParent_btn.UseVisualStyleBackColor = false;
            this.findParent_btn.Click += new System.EventHandler(this.findParent_btn_Click);
            // 
            // subscript_btn
            // 
            this.subscript_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.subscript_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.subscript_btn.BorderRadius = 7;
            this.subscript_btn.BorderSize = 0;
            this.subscript_btn.FlatAppearance.BorderSize = 0;
            this.subscript_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscript_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subscript_btn.ForeColor = System.Drawing.Color.LightGray;
            this.subscript_btn.Image = ((System.Drawing.Image)(resources.GetObject("subscript_btn.Image")));
            this.subscript_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subscript_btn.Location = new System.Drawing.Point(590, 98);
            this.subscript_btn.Name = "subscript_btn";
            this.subscript_btn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.subscript_btn.Size = new System.Drawing.Size(41, 35);
            this.subscript_btn.TabIndex = 51;
            this.subscript_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subscript_btn.UseVisualStyleBackColor = false;
            this.subscript_btn.Click += new System.EventHandler(this.subscript_btn_Click);
            // 
            // superscript_btn
            // 
            this.superscript_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.superscript_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.superscript_btn.BorderRadius = 7;
            this.superscript_btn.BorderSize = 0;
            this.superscript_btn.FlatAppearance.BorderSize = 0;
            this.superscript_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superscript_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.superscript_btn.ForeColor = System.Drawing.Color.LightGray;
            this.superscript_btn.Image = ((System.Drawing.Image)(resources.GetObject("superscript_btn.Image")));
            this.superscript_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.superscript_btn.Location = new System.Drawing.Point(590, 57);
            this.superscript_btn.Name = "superscript_btn";
            this.superscript_btn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.superscript_btn.Size = new System.Drawing.Size(41, 35);
            this.superscript_btn.TabIndex = 50;
            this.superscript_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.superscript_btn.UseVisualStyleBackColor = false;
            this.superscript_btn.Click += new System.EventHandler(this.superscript_btn_Click);
            // 
            // lock_btn
            // 
            this.lock_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lock_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lock_btn.BorderRadius = 7;
            this.lock_btn.BorderSize = 0;
            this.lock_btn.FlatAppearance.BorderSize = 0;
            this.lock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lock_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lock_btn.ForeColor = System.Drawing.Color.LightGray;
            this.lock_btn.Image = ((System.Drawing.Image)(resources.GetObject("lock_btn.Image")));
            this.lock_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lock_btn.Location = new System.Drawing.Point(980, 57);
            this.lock_btn.Name = "lock_btn";
            this.lock_btn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lock_btn.Size = new System.Drawing.Size(41, 35);
            this.lock_btn.TabIndex = 49;
            this.lock_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lock_btn.UseVisualStyleBackColor = false;
            this.lock_btn.Click += new System.EventHandler(this.lock_btn_Click);
            // 
            // lineGap_btn
            // 
            this.lineGap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lineGap_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lineGap_btn.BorderRadius = 7;
            this.lineGap_btn.BorderSize = 0;
            this.lineGap_btn.FlatAppearance.BorderSize = 0;
            this.lineGap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineGap_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lineGap_btn.ForeColor = System.Drawing.Color.LightGray;
            this.lineGap_btn.Image = ((System.Drawing.Image)(resources.GetObject("lineGap_btn.Image")));
            this.lineGap_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineGap_btn.Location = new System.Drawing.Point(980, 98);
            this.lineGap_btn.Name = "lineGap_btn";
            this.lineGap_btn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lineGap_btn.Size = new System.Drawing.Size(41, 35);
            this.lineGap_btn.TabIndex = 48;
            this.lineGap_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineGap_btn.UseVisualStyleBackColor = false;
            this.lineGap_btn.Click += new System.EventHandler(this.lineGap_btn_Click);
            // 
            // unlock_btn
            // 
            this.unlock_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.unlock_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.unlock_btn.BorderRadius = 7;
            this.unlock_btn.BorderSize = 0;
            this.unlock_btn.FlatAppearance.BorderSize = 0;
            this.unlock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unlock_btn.ForeColor = System.Drawing.Color.LightGray;
            this.unlock_btn.Image = ((System.Drawing.Image)(resources.GetObject("unlock_btn.Image")));
            this.unlock_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unlock_btn.Location = new System.Drawing.Point(980, 57);
            this.unlock_btn.Name = "unlock_btn";
            this.unlock_btn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.unlock_btn.Size = new System.Drawing.Size(41, 35);
            this.unlock_btn.TabIndex = 47;
            this.unlock_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unlock_btn.UseVisualStyleBackColor = false;
            this.unlock_btn.Click += new System.EventHandler(this.unlock_btn_Click);
            // 
            // increaseIndent_btn
            // 
            this.increaseIndent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.increaseIndent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.increaseIndent_btn.BorderRadius = 7;
            this.increaseIndent_btn.BorderSize = 0;
            this.increaseIndent_btn.FlatAppearance.BorderSize = 0;
            this.increaseIndent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseIndent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.increaseIndent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.increaseIndent_btn.Image = ((System.Drawing.Image)(resources.GetObject("increaseIndent_btn.Image")));
            this.increaseIndent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.increaseIndent_btn.Location = new System.Drawing.Point(805, 98);
            this.increaseIndent_btn.Name = "increaseIndent_btn";
            this.increaseIndent_btn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.increaseIndent_btn.Size = new System.Drawing.Size(41, 35);
            this.increaseIndent_btn.TabIndex = 46;
            this.increaseIndent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.increaseIndent_btn.UseVisualStyleBackColor = false;
            this.increaseIndent_btn.Click += new System.EventHandler(this.increaseIndent_btn_Click);
            // 
            // decreaseIndent_btn
            // 
            this.decreaseIndent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.decreaseIndent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.decreaseIndent_btn.BorderRadius = 7;
            this.decreaseIndent_btn.BorderSize = 0;
            this.decreaseIndent_btn.FlatAppearance.BorderSize = 0;
            this.decreaseIndent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseIndent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decreaseIndent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.decreaseIndent_btn.Image = ((System.Drawing.Image)(resources.GetObject("decreaseIndent_btn.Image")));
            this.decreaseIndent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decreaseIndent_btn.Location = new System.Drawing.Point(760, 98);
            this.decreaseIndent_btn.Name = "decreaseIndent_btn";
            this.decreaseIndent_btn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.decreaseIndent_btn.Size = new System.Drawing.Size(41, 35);
            this.decreaseIndent_btn.TabIndex = 45;
            this.decreaseIndent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decreaseIndent_btn.UseVisualStyleBackColor = false;
            this.decreaseIndent_btn.Click += new System.EventHandler(this.decreaseIndent_btn_Click);
            // 
            // bulletList_btn
            // 
            this.bulletList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bulletList_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.bulletList_btn.BorderRadius = 7;
            this.bulletList_btn.BorderSize = 0;
            this.bulletList_btn.FlatAppearance.BorderSize = 0;
            this.bulletList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulletList_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulletList_btn.ForeColor = System.Drawing.Color.LightGray;
            this.bulletList_btn.Image = ((System.Drawing.Image)(resources.GetObject("bulletList_btn.Image")));
            this.bulletList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bulletList_btn.Location = new System.Drawing.Point(760, 20);
            this.bulletList_btn.Name = "bulletList_btn";
            this.bulletList_btn.Size = new System.Drawing.Size(186, 35);
            this.bulletList_btn.TabIndex = 44;
            this.bulletList_btn.Text = "        Sıralı Liste";
            this.bulletList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bulletList_btn.UseVisualStyleBackColor = false;
            this.bulletList_btn.Click += new System.EventHandler(this.bulletList_btn_Click);
            // 
            // alignToRight_btn
            // 
            this.alignToRight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.alignToRight_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.alignToRight_btn.BorderRadius = 7;
            this.alignToRight_btn.BorderSize = 0;
            this.alignToRight_btn.FlatAppearance.BorderSize = 0;
            this.alignToRight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignToRight_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignToRight_btn.ForeColor = System.Drawing.Color.LightGray;
            this.alignToRight_btn.Image = ((System.Drawing.Image)(resources.GetObject("alignToRight_btn.Image")));
            this.alignToRight_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToRight_btn.Location = new System.Drawing.Point(850, 57);
            this.alignToRight_btn.Name = "alignToRight_btn";
            this.alignToRight_btn.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.alignToRight_btn.Size = new System.Drawing.Size(41, 35);
            this.alignToRight_btn.TabIndex = 43;
            this.alignToRight_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToRight_btn.UseVisualStyleBackColor = false;
            this.alignToRight_btn.Click += new System.EventHandler(this.alignToRight_btn_Click);
            // 
            // alignToMiddle_btn
            // 
            this.alignToMiddle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.alignToMiddle_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.alignToMiddle_btn.BorderRadius = 7;
            this.alignToMiddle_btn.BorderSize = 0;
            this.alignToMiddle_btn.FlatAppearance.BorderSize = 0;
            this.alignToMiddle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignToMiddle_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignToMiddle_btn.ForeColor = System.Drawing.Color.LightGray;
            this.alignToMiddle_btn.Image = ((System.Drawing.Image)(resources.GetObject("alignToMiddle_btn.Image")));
            this.alignToMiddle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToMiddle_btn.Location = new System.Drawing.Point(805, 57);
            this.alignToMiddle_btn.Name = "alignToMiddle_btn";
            this.alignToMiddle_btn.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.alignToMiddle_btn.Size = new System.Drawing.Size(41, 35);
            this.alignToMiddle_btn.TabIndex = 42;
            this.alignToMiddle_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToMiddle_btn.UseVisualStyleBackColor = false;
            this.alignToMiddle_btn.Click += new System.EventHandler(this.alignToMiddle_btn_Click);
            // 
            // alignToLeft_btn
            // 
            this.alignToLeft_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.alignToLeft_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.alignToLeft_btn.BorderRadius = 7;
            this.alignToLeft_btn.BorderSize = 0;
            this.alignToLeft_btn.FlatAppearance.BorderSize = 0;
            this.alignToLeft_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignToLeft_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignToLeft_btn.ForeColor = System.Drawing.Color.LightGray;
            this.alignToLeft_btn.Image = ((System.Drawing.Image)(resources.GetObject("alignToLeft_btn.Image")));
            this.alignToLeft_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToLeft_btn.Location = new System.Drawing.Point(760, 57);
            this.alignToLeft_btn.Name = "alignToLeft_btn";
            this.alignToLeft_btn.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.alignToLeft_btn.Size = new System.Drawing.Size(41, 35);
            this.alignToLeft_btn.TabIndex = 41;
            this.alignToLeft_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alignToLeft_btn.UseVisualStyleBackColor = false;
            this.alignToLeft_btn.Click += new System.EventHandler(this.alignToLeft_btn_Click);
            // 
            // characterGap_btn
            // 
            this.characterGap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.characterGap_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.characterGap_btn.BorderRadius = 7;
            this.characterGap_btn.BorderSize = 0;
            this.characterGap_btn.FlatAppearance.BorderSize = 0;
            this.characterGap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.characterGap_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.characterGap_btn.ForeColor = System.Drawing.Color.LightGray;
            this.characterGap_btn.Image = ((System.Drawing.Image)(resources.GetObject("characterGap_btn.Image")));
            this.characterGap_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.characterGap_btn.Location = new System.Drawing.Point(635, 98);
            this.characterGap_btn.Name = "characterGap_btn";
            this.characterGap_btn.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.characterGap_btn.Size = new System.Drawing.Size(41, 35);
            this.characterGap_btn.TabIndex = 40;
            this.characterGap_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.characterGap_btn.UseVisualStyleBackColor = false;
            // 
            // deleteForming_btn
            // 
            this.deleteForming_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteForming_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.deleteForming_btn.BorderRadius = 7;
            this.deleteForming_btn.BorderSize = 0;
            this.deleteForming_btn.FlatAppearance.BorderSize = 0;
            this.deleteForming_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteForming_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteForming_btn.ForeColor = System.Drawing.Color.LightGray;
            this.deleteForming_btn.Image = ((System.Drawing.Image)(resources.GetObject("deleteForming_btn.Image")));
            this.deleteForming_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteForming_btn.Location = new System.Drawing.Point(680, 98);
            this.deleteForming_btn.Name = "deleteForming_btn";
            this.deleteForming_btn.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.deleteForming_btn.Size = new System.Drawing.Size(41, 35);
            this.deleteForming_btn.TabIndex = 39;
            this.deleteForming_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteForming_btn.UseVisualStyleBackColor = false;
            this.deleteForming_btn.Click += new System.EventHandler(this.deleteForming_btn_Click);
            // 
            // highlightColorIndicator
            // 
            this.highlightColorIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.highlightColorIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highlightColorIndicator.Location = new System.Drawing.Point(392, 125);
            this.highlightColorIndicator.Name = "highlightColorIndicator";
            this.highlightColorIndicator.Size = new System.Drawing.Size(31, 3);
            this.highlightColorIndicator.TabIndex = 38;
            this.highlightColorIndicator.TabStop = false;
            // 
            // highlight_btn
            // 
            this.highlight_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.highlight_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.highlight_btn.BorderRadius = 7;
            this.highlight_btn.BorderSize = 0;
            this.highlight_btn.FlatAppearance.BorderSize = 0;
            this.highlight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highlight_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highlight_btn.ForeColor = System.Drawing.Color.LightGray;
            this.highlight_btn.Image = ((System.Drawing.Image)(resources.GetObject("highlight_btn.Image")));
            this.highlight_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.highlight_btn.Location = new System.Drawing.Point(384, 98);
            this.highlight_btn.Name = "highlight_btn";
            this.highlight_btn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.highlight_btn.Size = new System.Drawing.Size(41, 35);
            this.highlight_btn.TabIndex = 37;
            this.highlight_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.highlight_btn.UseVisualStyleBackColor = false;
            this.highlight_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.highlight_btn_MouseDown);
            this.highlight_btn.MouseEnter += new System.EventHandler(this.highlight_btn_MouseEnter);
            // 
            // decreaseFontSize_btn
            // 
            this.decreaseFontSize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.decreaseFontSize_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.decreaseFontSize_btn.BorderRadius = 7;
            this.decreaseFontSize_btn.BorderSize = 0;
            this.decreaseFontSize_btn.FlatAppearance.BorderSize = 0;
            this.decreaseFontSize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decreaseFontSize_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decreaseFontSize_btn.ForeColor = System.Drawing.Color.LightGray;
            this.decreaseFontSize_btn.Image = ((System.Drawing.Image)(resources.GetObject("decreaseFontSize_btn.Image")));
            this.decreaseFontSize_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decreaseFontSize_btn.Location = new System.Drawing.Point(635, 57);
            this.decreaseFontSize_btn.Name = "decreaseFontSize_btn";
            this.decreaseFontSize_btn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.decreaseFontSize_btn.Size = new System.Drawing.Size(41, 35);
            this.decreaseFontSize_btn.TabIndex = 36;
            this.decreaseFontSize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decreaseFontSize_btn.UseVisualStyleBackColor = false;
            this.decreaseFontSize_btn.Click += new System.EventHandler(this.decreaseFontSize_btn_Click);
            // 
            // increaseFontSize_btn
            // 
            this.increaseFontSize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.increaseFontSize_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.increaseFontSize_btn.BorderRadius = 7;
            this.increaseFontSize_btn.BorderSize = 0;
            this.increaseFontSize_btn.FlatAppearance.BorderSize = 0;
            this.increaseFontSize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseFontSize_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.increaseFontSize_btn.ForeColor = System.Drawing.Color.LightGray;
            this.increaseFontSize_btn.Image = ((System.Drawing.Image)(resources.GetObject("increaseFontSize_btn.Image")));
            this.increaseFontSize_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.increaseFontSize_btn.Location = new System.Drawing.Point(680, 57);
            this.increaseFontSize_btn.Name = "increaseFontSize_btn";
            this.increaseFontSize_btn.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.increaseFontSize_btn.Size = new System.Drawing.Size(41, 35);
            this.increaseFontSize_btn.TabIndex = 35;
            this.increaseFontSize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.increaseFontSize_btn.UseVisualStyleBackColor = false;
            this.increaseFontSize_btn.Click += new System.EventHandler(this.increaseFontSize_btn_Click);
            // 
            // textColorIndicator
            // 
            this.textColorIndicator.BackColor = System.Drawing.Color.White;
            this.textColorIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textColorIndicator.Location = new System.Drawing.Point(345, 125);
            this.textColorIndicator.Name = "textColorIndicator";
            this.textColorIndicator.Size = new System.Drawing.Size(31, 3);
            this.textColorIndicator.TabIndex = 19;
            this.textColorIndicator.TabStop = false;
            // 
            // textcolor_btn
            // 
            this.textcolor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textcolor_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.textcolor_btn.BorderRadius = 7;
            this.textcolor_btn.BorderSize = 0;
            this.textcolor_btn.FlatAppearance.BorderSize = 0;
            this.textcolor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textcolor_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textcolor_btn.ForeColor = System.Drawing.Color.LightGray;
            this.textcolor_btn.Image = ((System.Drawing.Image)(resources.GetObject("textcolor_btn.Image")));
            this.textcolor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textcolor_btn.Location = new System.Drawing.Point(339, 98);
            this.textcolor_btn.Name = "textcolor_btn";
            this.textcolor_btn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.textcolor_btn.Size = new System.Drawing.Size(41, 35);
            this.textcolor_btn.TabIndex = 34;
            this.textcolor_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textcolor_btn.UseVisualStyleBackColor = false;
            this.textcolor_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textcolor_btn_MouseDown);
            this.textcolor_btn.MouseEnter += new System.EventHandler(this.textcolor_btn_MouseEnter);
            // 
            // strikethrough_btn
            // 
            this.strikethrough_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.strikethrough_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.strikethrough_btn.BorderRadius = 7;
            this.strikethrough_btn.BorderSize = 0;
            this.strikethrough_btn.FlatAppearance.BorderSize = 0;
            this.strikethrough_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikethrough_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.strikethrough_btn.ForeColor = System.Drawing.Color.LightGray;
            this.strikethrough_btn.Image = ((System.Drawing.Image)(resources.GetObject("strikethrough_btn.Image")));
            this.strikethrough_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.strikethrough_btn.Location = new System.Drawing.Point(474, 57);
            this.strikethrough_btn.Name = "strikethrough_btn";
            this.strikethrough_btn.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.strikethrough_btn.Size = new System.Drawing.Size(41, 35);
            this.strikethrough_btn.TabIndex = 33;
            this.strikethrough_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.strikethrough_btn.UseVisualStyleBackColor = false;
            this.strikethrough_btn.Click += new System.EventHandler(this.strikethrough_btn_Click);
            // 
            // underlined_btn
            // 
            this.underlined_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.underlined_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.underlined_btn.BorderRadius = 7;
            this.underlined_btn.BorderSize = 0;
            this.underlined_btn.FlatAppearance.BorderSize = 0;
            this.underlined_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlined_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.underlined_btn.ForeColor = System.Drawing.Color.LightGray;
            this.underlined_btn.Image = ((System.Drawing.Image)(resources.GetObject("underlined_btn.Image")));
            this.underlined_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.underlined_btn.Location = new System.Drawing.Point(429, 57);
            this.underlined_btn.Name = "underlined_btn";
            this.underlined_btn.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.underlined_btn.Size = new System.Drawing.Size(41, 35);
            this.underlined_btn.TabIndex = 32;
            this.underlined_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.underlined_btn.UseVisualStyleBackColor = false;
            this.underlined_btn.Click += new System.EventHandler(this.underlined_btn_Click);
            // 
            // italic_btn
            // 
            this.italic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.italic_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.italic_btn.BorderRadius = 7;
            this.italic_btn.BorderSize = 0;
            this.italic_btn.FlatAppearance.BorderSize = 0;
            this.italic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italic_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.italic_btn.ForeColor = System.Drawing.Color.LightGray;
            this.italic_btn.Image = ((System.Drawing.Image)(resources.GetObject("italic_btn.Image")));
            this.italic_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.italic_btn.Location = new System.Drawing.Point(384, 57);
            this.italic_btn.Name = "italic_btn";
            this.italic_btn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.italic_btn.Size = new System.Drawing.Size(41, 35);
            this.italic_btn.TabIndex = 31;
            this.italic_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.italic_btn.UseVisualStyleBackColor = false;
            this.italic_btn.Click += new System.EventHandler(this.italic_btn_Click);
            // 
            // bold_btn
            // 
            this.bold_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.bold_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.bold_btn.BorderRadius = 7;
            this.bold_btn.BorderSize = 0;
            this.bold_btn.FlatAppearance.BorderSize = 0;
            this.bold_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bold_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bold_btn.ForeColor = System.Drawing.Color.LightGray;
            this.bold_btn.Image = ((System.Drawing.Image)(resources.GetObject("bold_btn.Image")));
            this.bold_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bold_btn.Location = new System.Drawing.Point(339, 57);
            this.bold_btn.Name = "bold_btn";
            this.bold_btn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bold_btn.Size = new System.Drawing.Size(41, 35);
            this.bold_btn.TabIndex = 30;
            this.bold_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bold_btn.UseVisualStyleBackColor = false;
            this.bold_btn.Click += new System.EventHandler(this.bold_btn_Click);
            // 
            // fontSizeSelector_cmb
            // 
            this.fontSizeSelector_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.fontSizeSelector_cmb.Font = new System.Drawing.Font("Wanted Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontSizeSelector_cmb.ForeColor = System.Drawing.Color.White;
            this.fontSizeSelector_cmb.FormattingEnabled = true;
            this.fontSizeSelector_cmb.ItemHeight = 24;
            this.fontSizeSelector_cmb.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "21",
            "22",
            "24",
            "26",
            "28",
            "32",
            "36",
            "40",
            "42",
            "44",
            "48",
            "54",
            "60",
            "66",
            "72",
            "80",
            "88",
            "96"});
            this.fontSizeSelector_cmb.Location = new System.Drawing.Point(617, 19);
            this.fontSizeSelector_cmb.Name = "fontSizeSelector_cmb";
            this.fontSizeSelector_cmb.Size = new System.Drawing.Size(107, 32);
            this.fontSizeSelector_cmb.TabIndex = 29;
            this.fontSizeSelector_cmb.Text = "12";
            this.fontSizeSelector_cmb.SelectedIndexChanged += new System.EventHandler(this.fontSizeSelector_cmb_SelectedIndexChanged);
            // 
            // fontSelector_cmb
            // 
            this.fontSelector_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.fontSelector_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fontSelector_cmb.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontSelector_cmb.ForeColor = System.Drawing.Color.White;
            this.fontSelector_cmb.FormattingEnabled = true;
            this.fontSelector_cmb.ItemHeight = 21;
            this.fontSelector_cmb.Location = new System.Drawing.Point(339, 19);
            this.fontSelector_cmb.Name = "fontSelector_cmb";
            this.fontSelector_cmb.Size = new System.Drawing.Size(268, 27);
            this.fontSelector_cmb.TabIndex = 28;
            this.fontSelector_cmb.Text = "Wanted Sans Medium";
            this.fontSelector_cmb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.fontSelector_cmb_DrawItem);
            this.fontSelector_cmb.SelectedIndexChanged += new System.EventHandler(this.fontSelector_cmb_SelectedIndexChanged);
            // 
            // toolsLine5
            // 
            this.toolsLine5.Image = ((System.Drawing.Image)(resources.GetObject("toolsLine5.Image")));
            this.toolsLine5.Location = new System.Drawing.Point(1596, 22);
            this.toolsLine5.Name = "toolsLine5";
            this.toolsLine5.Size = new System.Drawing.Size(3, 115);
            this.toolsLine5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsLine5.TabIndex = 27;
            this.toolsLine5.TabStop = false;
            // 
            // textTemplates_lbl
            // 
            this.textTemplates_lbl.AutoSize = true;
            this.textTemplates_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTemplates_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTemplates_lbl.Location = new System.Drawing.Point(1338, 129);
            this.textTemplates_lbl.Name = "textTemplates_lbl";
            this.textTemplates_lbl.Size = new System.Drawing.Size(108, 18);
            this.textTemplates_lbl.TabIndex = 26;
            this.textTemplates_lbl.Text = "Yazı Şablonları";
            // 
            // toolsLine4
            // 
            this.toolsLine4.Image = ((System.Drawing.Image)(resources.GetObject("toolsLine4.Image")));
            this.toolsLine4.Location = new System.Drawing.Point(1179, 19);
            this.toolsLine4.Name = "toolsLine4";
            this.toolsLine4.Size = new System.Drawing.Size(3, 115);
            this.toolsLine4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsLine4.TabIndex = 25;
            this.toolsLine4.TabStop = false;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_lbl.Location = new System.Drawing.Point(1095, 129);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(33, 18);
            this.search_lbl.TabIndex = 24;
            this.search_lbl.Text = "Ara";
            // 
            // toolsLine3
            // 
            this.toolsLine3.Image = ((System.Drawing.Image)(resources.GetObject("toolsLine3.Image")));
            this.toolsLine3.Location = new System.Drawing.Point(1039, 19);
            this.toolsLine3.Name = "toolsLine3";
            this.toolsLine3.Size = new System.Drawing.Size(3, 115);
            this.toolsLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsLine3.TabIndex = 23;
            this.toolsLine3.TabStop = false;
            // 
            // paragraph_lbl
            // 
            this.paragraph_lbl.AutoSize = true;
            this.paragraph_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paragraph_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paragraph_lbl.Location = new System.Drawing.Point(860, 129);
            this.paragraph_lbl.Name = "paragraph_lbl";
            this.paragraph_lbl.Size = new System.Drawing.Size(71, 18);
            this.paragraph_lbl.TabIndex = 22;
            this.paragraph_lbl.Text = "Paragraf";
            // 
            // toolsLine2
            // 
            this.toolsLine2.Image = ((System.Drawing.Image)(resources.GetObject("toolsLine2.Image")));
            this.toolsLine2.Location = new System.Drawing.Point(744, 19);
            this.toolsLine2.Name = "toolsLine2";
            this.toolsLine2.Size = new System.Drawing.Size(3, 115);
            this.toolsLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsLine2.TabIndex = 19;
            this.toolsLine2.TabStop = false;
            // 
            // font_lbl
            // 
            this.font_lbl.AutoSize = true;
            this.font_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.font_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.font_lbl.Location = new System.Drawing.Point(507, 129);
            this.font_lbl.Name = "font_lbl";
            this.font_lbl.Size = new System.Drawing.Size(64, 18);
            this.font_lbl.TabIndex = 18;
            this.font_lbl.Text = "Yazı Tipi";
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.select_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.select_btn.BorderRadius = 7;
            this.select_btn.BorderSize = 0;
            this.select_btn.FlatAppearance.BorderSize = 0;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.select_btn.ForeColor = System.Drawing.Color.LightGray;
            this.select_btn.Image = ((System.Drawing.Image)(resources.GetObject("select_btn.Image")));
            this.select_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select_btn.Location = new System.Drawing.Point(118, 86);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(186, 35);
            this.select_btn.TabIndex = 16;
            this.select_btn.Text = "        Seç";
            this.select_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // selectall_btn
            // 
            this.selectall_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.selectall_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.selectall_btn.BorderRadius = 7;
            this.selectall_btn.BorderSize = 0;
            this.selectall_btn.FlatAppearance.BorderSize = 0;
            this.selectall_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectall_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectall_btn.ForeColor = System.Drawing.Color.LightGray;
            this.selectall_btn.Image = ((System.Drawing.Image)(resources.GetObject("selectall_btn.Image")));
            this.selectall_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectall_btn.Location = new System.Drawing.Point(118, 104);
            this.selectall_btn.Name = "selectall_btn";
            this.selectall_btn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.selectall_btn.Size = new System.Drawing.Size(186, 48);
            this.selectall_btn.TabIndex = 17;
            this.selectall_btn.Text = "        Tümünü Seç";
            this.selectall_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectall_btn.UseVisualStyleBackColor = false;
            this.selectall_btn.Visible = false;
            this.selectall_btn.Click += new System.EventHandler(this.selectall_btn_Click);
            // 
            // redo_btn
            // 
            this.redo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.redo_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.redo_btn.BorderRadius = 7;
            this.redo_btn.BorderSize = 0;
            this.redo_btn.FlatAppearance.BorderSize = 0;
            this.redo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redo_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redo_btn.ForeColor = System.Drawing.Color.LightGray;
            this.redo_btn.Image = ((System.Drawing.Image)(resources.GetObject("redo_btn.Image")));
            this.redo_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redo_btn.Location = new System.Drawing.Point(263, 48);
            this.redo_btn.Name = "redo_btn";
            this.redo_btn.Size = new System.Drawing.Size(41, 35);
            this.redo_btn.TabIndex = 15;
            this.redo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redo_btn.UseVisualStyleBackColor = false;
            this.redo_btn.Click += new System.EventHandler(this.redo_btn_Click);
            // 
            // undo_btn
            // 
            this.undo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.undo_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.undo_btn.BorderRadius = 7;
            this.undo_btn.BorderSize = 0;
            this.undo_btn.FlatAppearance.BorderSize = 0;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.undo_btn.ForeColor = System.Drawing.Color.LightGray;
            this.undo_btn.Image = ((System.Drawing.Image)(resources.GetObject("undo_btn.Image")));
            this.undo_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undo_btn.Location = new System.Drawing.Point(263, 10);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(41, 35);
            this.undo_btn.TabIndex = 14;
            this.undo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undo_btn.UseVisualStyleBackColor = false;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // toolsLine1
            // 
            this.toolsLine1.Image = ((System.Drawing.Image)(resources.GetObject("toolsLine1.Image")));
            this.toolsLine1.Location = new System.Drawing.Point(320, 19);
            this.toolsLine1.Name = "toolsLine1";
            this.toolsLine1.Size = new System.Drawing.Size(3, 115);
            this.toolsLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toolsLine1.TabIndex = 10;
            this.toolsLine1.TabStop = false;
            // 
            // general_lbl
            // 
            this.general_lbl.AutoSize = true;
            this.general_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.general_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.general_lbl.Location = new System.Drawing.Point(138, 129);
            this.general_lbl.Name = "general_lbl";
            this.general_lbl.Size = new System.Drawing.Size(49, 18);
            this.general_lbl.TabIndex = 11;
            this.general_lbl.Text = "Genel";
            // 
            // cut_btn
            // 
            this.cut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cut_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.cut_btn.BorderRadius = 7;
            this.cut_btn.BorderSize = 0;
            this.cut_btn.FlatAppearance.BorderSize = 0;
            this.cut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cut_btn.ForeColor = System.Drawing.Color.LightGray;
            this.cut_btn.Image = ((System.Drawing.Image)(resources.GetObject("cut_btn.Image")));
            this.cut_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cut_btn.Location = new System.Drawing.Point(118, 48);
            this.cut_btn.Name = "cut_btn";
            this.cut_btn.Size = new System.Drawing.Size(140, 35);
            this.cut_btn.TabIndex = 13;
            this.cut_btn.Text = "        Kes";
            this.cut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cut_btn.UseVisualStyleBackColor = false;
            this.cut_btn.Click += new System.EventHandler(this.cut_btn_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.copy_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.copy_btn.BorderRadius = 7;
            this.copy_btn.BorderSize = 0;
            this.copy_btn.FlatAppearance.BorderSize = 0;
            this.copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copy_btn.ForeColor = System.Drawing.Color.LightGray;
            this.copy_btn.Image = ((System.Drawing.Image)(resources.GetObject("copy_btn.Image")));
            this.copy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy_btn.Location = new System.Drawing.Point(118, 10);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(140, 35);
            this.copy_btn.TabIndex = 12;
            this.copy_btn.Text = "        Kopyala";
            this.copy_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // paste_btn
            // 
            this.paste_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.paste_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.paste_btn.BorderRadius = 7;
            this.paste_btn.BorderSize = 0;
            this.paste_btn.FlatAppearance.BorderSize = 0;
            this.paste_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paste_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paste_btn.ForeColor = System.Drawing.Color.LightGray;
            this.paste_btn.Image = ((System.Drawing.Image)(resources.GetObject("paste_btn.Image")));
            this.paste_btn.Location = new System.Drawing.Point(16, 10);
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.Size = new System.Drawing.Size(95, 90);
            this.paste_btn.TabIndex = 11;
            this.paste_btn.Text = "Yapıştır";
            this.paste_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paste_btn.UseVisualStyleBackColor = false;
            this.paste_btn.Click += new System.EventHandler(this.paste_btn_Click);
            // 
            // editMenu
            // 
            this.editMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.editMenu.BorderColor = System.Drawing.Color.White;
            this.editMenu.BorderRadius = 0;
            this.editMenu.BorderSize = 0;
            this.editMenu.Controls.Add(this.editLine3);
            this.editMenu.Controls.Add(this.detectLinks_btn);
            this.editMenu.Controls.Add(this.refresh_btn);
            this.editMenu.Controls.Add(this.draganddropEnabled_btn);
            this.editMenu.Controls.Add(this.otherEdit_lbl);
            this.editMenu.Controls.Add(this.editLine2);
            this.editMenu.Controls.Add(this.indentSize_btn);
            this.editMenu.Controls.Add(this.pageColor_btn);
            this.editMenu.Controls.Add(this.appearancePage_lbl);
            this.editMenu.Controls.Add(this.editLine1);
            this.editMenu.Controls.Add(this.horizontalPage_btn);
            this.editMenu.Controls.Add(this.verticalPage_btn);
            this.editMenu.Controls.Add(this.pageSize_btn);
            this.editMenu.Controls.Add(this.page_lbl);
            this.editMenu.ForeColor = System.Drawing.Color.White;
            this.editMenu.Location = new System.Drawing.Point(0, 105);
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(1702, 153);
            this.editMenu.TabIndex = 61;
            this.editMenu.Visible = false;
            // 
            // editLine3
            // 
            this.editLine3.Image = ((System.Drawing.Image)(resources.GetObject("editLine3.Image")));
            this.editLine3.Location = new System.Drawing.Point(918, 18);
            this.editLine3.Name = "editLine3";
            this.editLine3.Size = new System.Drawing.Size(3, 115);
            this.editLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editLine3.TabIndex = 37;
            this.editLine3.TabStop = false;
            // 
            // detectLinks_btn
            // 
            this.detectLinks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.detectLinks_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.detectLinks_btn.BorderRadius = 7;
            this.detectLinks_btn.BorderSize = 1;
            this.detectLinks_btn.FlatAppearance.BorderSize = 0;
            this.detectLinks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectLinks_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detectLinks_btn.ForeColor = System.Drawing.Color.LightGray;
            this.detectLinks_btn.Image = ((System.Drawing.Image)(resources.GetObject("detectLinks_btn.Image")));
            this.detectLinks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detectLinks_btn.Location = new System.Drawing.Point(693, 58);
            this.detectLinks_btn.Name = "detectLinks_btn";
            this.detectLinks_btn.Size = new System.Drawing.Size(208, 35);
            this.detectLinks_btn.TabIndex = 36;
            this.detectLinks_btn.Text = "        Bağlantı Algıla";
            this.detectLinks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detectLinks_btn.UseVisualStyleBackColor = false;
            this.detectLinks_btn.Click += new System.EventHandler(this.detectLinks_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.refresh_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.refresh_btn.BorderRadius = 7;
            this.refresh_btn.BorderSize = 0;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refresh_btn.ForeColor = System.Drawing.Color.LightGray;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(577, 20);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(100, 105);
            this.refresh_btn.TabIndex = 35;
            this.refresh_btn.Text = "Yenile";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // draganddropEnabled_btn
            // 
            this.draganddropEnabled_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.draganddropEnabled_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.draganddropEnabled_btn.BorderRadius = 7;
            this.draganddropEnabled_btn.BorderSize = 1;
            this.draganddropEnabled_btn.FlatAppearance.BorderSize = 0;
            this.draganddropEnabled_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draganddropEnabled_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.draganddropEnabled_btn.ForeColor = System.Drawing.Color.LightGray;
            this.draganddropEnabled_btn.Image = ((System.Drawing.Image)(resources.GetObject("draganddropEnabled_btn.Image")));
            this.draganddropEnabled_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.draganddropEnabled_btn.Location = new System.Drawing.Point(693, 20);
            this.draganddropEnabled_btn.Name = "draganddropEnabled_btn";
            this.draganddropEnabled_btn.Size = new System.Drawing.Size(208, 35);
            this.draganddropEnabled_btn.TabIndex = 34;
            this.draganddropEnabled_btn.Text = "        Sürükle Bırak";
            this.draganddropEnabled_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.draganddropEnabled_btn.UseVisualStyleBackColor = false;
            this.draganddropEnabled_btn.Click += new System.EventHandler(this.draganddropEnabled_btn_Click);
            // 
            // otherEdit_lbl
            // 
            this.otherEdit_lbl.AutoSize = true;
            this.otherEdit_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otherEdit_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.otherEdit_lbl.Location = new System.Drawing.Point(724, 129);
            this.otherEdit_lbl.Name = "otherEdit_lbl";
            this.otherEdit_lbl.Size = new System.Drawing.Size(45, 18);
            this.otherEdit_lbl.TabIndex = 33;
            this.otherEdit_lbl.Text = "Diğer";
            // 
            // editLine2
            // 
            this.editLine2.Image = ((System.Drawing.Image)(resources.GetObject("editLine2.Image")));
            this.editLine2.Location = new System.Drawing.Point(552, 18);
            this.editLine2.Name = "editLine2";
            this.editLine2.Size = new System.Drawing.Size(3, 115);
            this.editLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editLine2.TabIndex = 32;
            this.editLine2.TabStop = false;
            // 
            // indentSize_btn
            // 
            this.indentSize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.indentSize_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.indentSize_btn.BorderRadius = 7;
            this.indentSize_btn.BorderSize = 0;
            this.indentSize_btn.FlatAppearance.BorderSize = 0;
            this.indentSize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indentSize_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.indentSize_btn.ForeColor = System.Drawing.Color.LightGray;
            this.indentSize_btn.Image = ((System.Drawing.Image)(resources.GetObject("indentSize_btn.Image")));
            this.indentSize_btn.Location = new System.Drawing.Point(435, 10);
            this.indentSize_btn.Name = "indentSize_btn";
            this.indentSize_btn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.indentSize_btn.Size = new System.Drawing.Size(100, 120);
            this.indentSize_btn.TabIndex = 31;
            this.indentSize_btn.Text = "Kenar Boyutu";
            this.indentSize_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.indentSize_btn.UseVisualStyleBackColor = false;
            this.indentSize_btn.Click += new System.EventHandler(this.kenarboyutu_Click);
            // 
            // pageColor_btn
            // 
            this.pageColor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pageColor_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.pageColor_btn.BorderRadius = 7;
            this.pageColor_btn.BorderSize = 1;
            this.pageColor_btn.FlatAppearance.BorderSize = 0;
            this.pageColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageColor_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageColor_btn.ForeColor = System.Drawing.Color.LightGray;
            this.pageColor_btn.Image = ((System.Drawing.Image)(resources.GetObject("pageColor_btn.Image")));
            this.pageColor_btn.Location = new System.Drawing.Point(329, 10);
            this.pageColor_btn.Name = "pageColor_btn";
            this.pageColor_btn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pageColor_btn.Size = new System.Drawing.Size(100, 120);
            this.pageColor_btn.TabIndex = 29;
            this.pageColor_btn.Text = "Kağıt Rengi";
            this.pageColor_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pageColor_btn.UseVisualStyleBackColor = false;
            this.pageColor_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pageColor_btn_MouseDown);
            this.pageColor_btn.MouseEnter += new System.EventHandler(this.pageColor_btn_MouseEnter);
            // 
            // appearancePage_lbl
            // 
            this.appearancePage_lbl.AutoSize = true;
            this.appearancePage_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appearancePage_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.appearancePage_lbl.Location = new System.Drawing.Point(402, 129);
            this.appearancePage_lbl.Name = "appearancePage_lbl";
            this.appearancePage_lbl.Size = new System.Drawing.Size(66, 18);
            this.appearancePage_lbl.TabIndex = 28;
            this.appearancePage_lbl.Text = "Görünüş";
            // 
            // editLine1
            // 
            this.editLine1.Image = ((System.Drawing.Image)(resources.GetObject("editLine1.Image")));
            this.editLine1.Location = new System.Drawing.Point(311, 18);
            this.editLine1.Name = "editLine1";
            this.editLine1.Size = new System.Drawing.Size(3, 115);
            this.editLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editLine1.TabIndex = 27;
            this.editLine1.TabStop = false;
            // 
            // horizontalPage_btn
            // 
            this.horizontalPage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.horizontalPage_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.horizontalPage_btn.BorderRadius = 7;
            this.horizontalPage_btn.BorderSize = 0;
            this.horizontalPage_btn.Enabled = false;
            this.horizontalPage_btn.FlatAppearance.BorderSize = 0;
            this.horizontalPage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horizontalPage_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.horizontalPage_btn.ForeColor = System.Drawing.Color.LightGray;
            this.horizontalPage_btn.Image = ((System.Drawing.Image)(resources.GetObject("horizontalPage_btn.Image")));
            this.horizontalPage_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.horizontalPage_btn.Location = new System.Drawing.Point(123, 48);
            this.horizontalPage_btn.Name = "horizontalPage_btn";
            this.horizontalPage_btn.Size = new System.Drawing.Size(168, 35);
            this.horizontalPage_btn.TabIndex = 26;
            this.horizontalPage_btn.Text = "        Yatay Kağıt";
            this.horizontalPage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.horizontalPage_btn.UseVisualStyleBackColor = false;
            // 
            // verticalPage_btn
            // 
            this.verticalPage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.verticalPage_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.verticalPage_btn.BorderRadius = 7;
            this.verticalPage_btn.BorderSize = 1;
            this.verticalPage_btn.Enabled = false;
            this.verticalPage_btn.FlatAppearance.BorderSize = 0;
            this.verticalPage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verticalPage_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verticalPage_btn.ForeColor = System.Drawing.Color.LightGray;
            this.verticalPage_btn.Image = ((System.Drawing.Image)(resources.GetObject("verticalPage_btn.Image")));
            this.verticalPage_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verticalPage_btn.Location = new System.Drawing.Point(123, 10);
            this.verticalPage_btn.Name = "verticalPage_btn";
            this.verticalPage_btn.Size = new System.Drawing.Size(168, 35);
            this.verticalPage_btn.TabIndex = 25;
            this.verticalPage_btn.Text = "        Dikey Kağıt";
            this.verticalPage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verticalPage_btn.UseVisualStyleBackColor = false;
            // 
            // pageSize_btn
            // 
            this.pageSize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pageSize_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.pageSize_btn.BorderRadius = 7;
            this.pageSize_btn.BorderSize = 0;
            this.pageSize_btn.Enabled = false;
            this.pageSize_btn.FlatAppearance.BorderSize = 0;
            this.pageSize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageSize_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pageSize_btn.ForeColor = System.Drawing.Color.LightGray;
            this.pageSize_btn.Image = ((System.Drawing.Image)(resources.GetObject("pageSize_btn.Image")));
            this.pageSize_btn.Location = new System.Drawing.Point(16, 10);
            this.pageSize_btn.Name = "pageSize_btn";
            this.pageSize_btn.Size = new System.Drawing.Size(100, 123);
            this.pageSize_btn.TabIndex = 22;
            this.pageSize_btn.Text = "Kağıt Boyutu";
            this.pageSize_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pageSize_btn.UseVisualStyleBackColor = false;
            // 
            // page_lbl
            // 
            this.page_lbl.AutoSize = true;
            this.page_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.page_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.page_lbl.Location = new System.Drawing.Point(145, 129);
            this.page_lbl.Name = "page_lbl";
            this.page_lbl.Size = new System.Drawing.Size(44, 18);
            this.page_lbl.TabIndex = 20;
            this.page_lbl.Text = "Kağıt";
            // 
            // addMenu
            // 
            this.addMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addMenu.BorderColor = System.Drawing.Color.White;
            this.addMenu.BorderRadius = 0;
            this.addMenu.BorderSize = 0;
            this.addMenu.Controls.Add(this.addReferenceNoMenu);
            this.addMenu.Controls.Add(this.addLine4);
            this.addMenu.Controls.Add(this.addNote_btn);
            this.addMenu.Controls.Add(this.addReferenceNoParent_btn);
            this.addMenu.Controls.Add(this.addReference_btn);
            this.addMenu.Controls.Add(this.reference_lbl);
            this.addMenu.Controls.Add(this.addLine3);
            this.addMenu.Controls.Add(this.media_lbl);
            this.addMenu.Controls.Add(this.addTable_btn);
            this.addMenu.Controls.Add(this.addVideo_btn);
            this.addMenu.Controls.Add(this.addImage_btn);
            this.addMenu.Controls.Add(this.addLine2);
            this.addMenu.Controls.Add(this.addEquation_btn);
            this.addMenu.Controls.Add(this.addSymbol_btn);
            this.addMenu.Controls.Add(this.addEmoji_btn);
            this.addMenu.Controls.Add(this.textAdd_lbl);
            this.addMenu.Controls.Add(this.addLink_btn);
            this.addMenu.Controls.Add(this.addLine1);
            this.addMenu.Controls.Add(this.dateandtime_lbl);
            this.addMenu.Controls.Add(this.dateandtime_btn);
            this.addMenu.ForeColor = System.Drawing.Color.White;
            this.addMenu.Location = new System.Drawing.Point(0, 105);
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(1718, 153);
            this.addMenu.TabIndex = 60;
            this.addMenu.Visible = false;
            // 
            // addReferenceNoMenu
            // 
            this.addReferenceNoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addReferenceNoMenu.BorderColor = System.Drawing.Color.White;
            this.addReferenceNoMenu.BorderRadius = 15;
            this.addReferenceNoMenu.BorderSize = 0;
            this.addReferenceNoMenu.Controls.Add(this.number_lbl);
            this.addReferenceNoMenu.Controls.Add(this.referenceNo_txt);
            this.addReferenceNoMenu.Controls.Add(this.addReferenceNo_btn);
            this.addReferenceNoMenu.ForeColor = System.Drawing.Color.White;
            this.addReferenceNoMenu.Location = new System.Drawing.Point(1074, 18);
            this.addReferenceNoMenu.Name = "addReferenceNoMenu";
            this.addReferenceNoMenu.Size = new System.Drawing.Size(134, 103);
            this.addReferenceNoMenu.TabIndex = 37;
            this.addReferenceNoMenu.Visible = false;
            // 
            // number_lbl
            // 
            this.number_lbl.AutoSize = true;
            this.number_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number_lbl.Location = new System.Drawing.Point(5, 38);
            this.number_lbl.Name = "number_lbl";
            this.number_lbl.Size = new System.Drawing.Size(63, 18);
            this.number_lbl.TabIndex = 38;
            this.number_lbl.Text = "Numara";
            // 
            // referenceNo_txt
            // 
            this.referenceNo_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.referenceNo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.referenceNo_txt.Font = new System.Drawing.Font("Wanted Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.referenceNo_txt.ForeColor = System.Drawing.Color.White;
            this.referenceNo_txt.Location = new System.Drawing.Point(10, 9);
            this.referenceNo_txt.Name = "referenceNo_txt";
            this.referenceNo_txt.Size = new System.Drawing.Size(100, 28);
            this.referenceNo_txt.TabIndex = 12;
            this.referenceNo_txt.Text = "1";
            // 
            // addReferenceNo_btn
            // 
            this.addReferenceNo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.addReferenceNo_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addReferenceNo_btn.BorderRadius = 10;
            this.addReferenceNo_btn.BorderSize = 0;
            this.addReferenceNo_btn.FlatAppearance.BorderSize = 0;
            this.addReferenceNo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReferenceNo_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addReferenceNo_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addReferenceNo_btn.Location = new System.Drawing.Point(4, 58);
            this.addReferenceNo_btn.Name = "addReferenceNo_btn";
            this.addReferenceNo_btn.Size = new System.Drawing.Size(125, 40);
            this.addReferenceNo_btn.TabIndex = 11;
            this.addReferenceNo_btn.Text = "Ekle";
            this.addReferenceNo_btn.UseVisualStyleBackColor = false;
            this.addReferenceNo_btn.Click += new System.EventHandler(this.addReferenceNo_btn_Click);
            // 
            // addLine4
            // 
            this.addLine4.Image = ((System.Drawing.Image)(resources.GetObject("addLine4.Image")));
            this.addLine4.Location = new System.Drawing.Point(1112, 18);
            this.addLine4.Name = "addLine4";
            this.addLine4.Size = new System.Drawing.Size(3, 115);
            this.addLine4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addLine4.TabIndex = 36;
            this.addLine4.TabStop = false;
            // 
            // addNote_btn
            // 
            this.addNote_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addNote_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addNote_btn.BorderRadius = 7;
            this.addNote_btn.BorderSize = 0;
            this.addNote_btn.FlatAppearance.BorderSize = 0;
            this.addNote_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNote_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addNote_btn.Image = ((System.Drawing.Image)(resources.GetObject("addNote_btn.Image")));
            this.addNote_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNote_btn.Location = new System.Drawing.Point(864, 62);
            this.addNote_btn.Name = "addNote_btn";
            this.addNote_btn.Size = new System.Drawing.Size(230, 35);
            this.addNote_btn.TabIndex = 35;
            this.addNote_btn.Text = "        Not";
            this.addNote_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNote_btn.UseVisualStyleBackColor = false;
            this.addNote_btn.Click += new System.EventHandler(this.addNote_btn_Click);
            // 
            // addReferenceNoParent_btn
            // 
            this.addReferenceNoParent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addReferenceNoParent_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addReferenceNoParent_btn.BorderRadius = 7;
            this.addReferenceNoParent_btn.BorderSize = 0;
            this.addReferenceNoParent_btn.FlatAppearance.BorderSize = 0;
            this.addReferenceNoParent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReferenceNoParent_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addReferenceNoParent_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addReferenceNoParent_btn.Image = ((System.Drawing.Image)(resources.GetObject("addReferenceNoParent_btn.Image")));
            this.addReferenceNoParent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addReferenceNoParent_btn.Location = new System.Drawing.Point(864, 20);
            this.addReferenceNoParent_btn.Name = "addReferenceNoParent_btn";
            this.addReferenceNoParent_btn.Size = new System.Drawing.Size(230, 35);
            this.addReferenceNoParent_btn.TabIndex = 34;
            this.addReferenceNoParent_btn.Text = "        Başvuru Numarası";
            this.addReferenceNoParent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addReferenceNoParent_btn.UseVisualStyleBackColor = false;
            this.addReferenceNoParent_btn.Click += new System.EventHandler(this.addReferenceNoParent_btn_Click);
            // 
            // addReference_btn
            // 
            this.addReference_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addReference_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addReference_btn.BorderRadius = 7;
            this.addReference_btn.BorderSize = 0;
            this.addReference_btn.FlatAppearance.BorderSize = 0;
            this.addReference_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReference_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addReference_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addReference_btn.Image = ((System.Drawing.Image)(resources.GetObject("addReference_btn.Image")));
            this.addReference_btn.Location = new System.Drawing.Point(760, 20);
            this.addReference_btn.Name = "addReference_btn";
            this.addReference_btn.Size = new System.Drawing.Size(100, 105);
            this.addReference_btn.TabIndex = 33;
            this.addReference_btn.Text = "Başvuru";
            this.addReference_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addReference_btn.UseVisualStyleBackColor = false;
            this.addReference_btn.Click += new System.EventHandler(this.addReference_btn_Click);
            // 
            // reference_lbl
            // 
            this.reference_lbl.AutoSize = true;
            this.reference_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reference_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reference_lbl.Location = new System.Drawing.Point(900, 129);
            this.reference_lbl.Name = "reference_lbl";
            this.reference_lbl.Size = new System.Drawing.Size(63, 18);
            this.reference_lbl.TabIndex = 32;
            this.reference_lbl.Text = "Başvuru";
            // 
            // addLine3
            // 
            this.addLine3.Image = ((System.Drawing.Image)(resources.GetObject("addLine3.Image")));
            this.addLine3.Location = new System.Drawing.Point(742, 18);
            this.addLine3.Name = "addLine3";
            this.addLine3.Size = new System.Drawing.Size(3, 115);
            this.addLine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addLine3.TabIndex = 31;
            this.addLine3.TabStop = false;
            // 
            // media_lbl
            // 
            this.media_lbl.AutoSize = true;
            this.media_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.media_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.media_lbl.Location = new System.Drawing.Point(552, 129);
            this.media_lbl.Name = "media_lbl";
            this.media_lbl.Size = new System.Drawing.Size(55, 18);
            this.media_lbl.TabIndex = 30;
            this.media_lbl.Text = "Medya";
            // 
            // addTable_btn
            // 
            this.addTable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addTable_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addTable_btn.BorderRadius = 7;
            this.addTable_btn.BorderSize = 0;
            this.addTable_btn.FlatAppearance.BorderSize = 0;
            this.addTable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTable_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTable_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addTable_btn.Image = ((System.Drawing.Image)(resources.GetObject("addTable_btn.Image")));
            this.addTable_btn.Location = new System.Drawing.Point(634, 20);
            this.addTable_btn.Name = "addTable_btn";
            this.addTable_btn.Size = new System.Drawing.Size(95, 90);
            this.addTable_btn.TabIndex = 29;
            this.addTable_btn.Text = "Tablo";
            this.addTable_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTable_btn.UseVisualStyleBackColor = false;
            this.addTable_btn.Click += new System.EventHandler(this.addTable_btn_Click);
            // 
            // addVideo_btn
            // 
            this.addVideo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addVideo_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addVideo_btn.BorderRadius = 7;
            this.addVideo_btn.BorderSize = 0;
            this.addVideo_btn.FlatAppearance.BorderSize = 0;
            this.addVideo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVideo_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addVideo_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addVideo_btn.Image = ((System.Drawing.Image)(resources.GetObject("addVideo_btn.Image")));
            this.addVideo_btn.Location = new System.Drawing.Point(533, 20);
            this.addVideo_btn.Name = "addVideo_btn";
            this.addVideo_btn.Size = new System.Drawing.Size(95, 90);
            this.addVideo_btn.TabIndex = 28;
            this.addVideo_btn.Text = "Video";
            this.addVideo_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addVideo_btn.UseVisualStyleBackColor = false;
            this.addVideo_btn.Click += new System.EventHandler(this.addVideo_btn_Click);
            // 
            // addImage_btn
            // 
            this.addImage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addImage_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addImage_btn.BorderRadius = 7;
            this.addImage_btn.BorderSize = 0;
            this.addImage_btn.FlatAppearance.BorderSize = 0;
            this.addImage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImage_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addImage_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addImage_btn.Image = ((System.Drawing.Image)(resources.GetObject("addImage_btn.Image")));
            this.addImage_btn.Location = new System.Drawing.Point(432, 20);
            this.addImage_btn.Name = "addImage_btn";
            this.addImage_btn.Size = new System.Drawing.Size(95, 90);
            this.addImage_btn.TabIndex = 27;
            this.addImage_btn.Text = "Resim";
            this.addImage_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addImage_btn.UseVisualStyleBackColor = false;
            this.addImage_btn.Click += new System.EventHandler(this.addImage_btn_Click);
            // 
            // addLine2
            // 
            this.addLine2.Image = ((System.Drawing.Image)(resources.GetObject("addLine2.Image")));
            this.addLine2.Location = new System.Drawing.Point(418, 18);
            this.addLine2.Name = "addLine2";
            this.addLine2.Size = new System.Drawing.Size(3, 115);
            this.addLine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addLine2.TabIndex = 26;
            this.addLine2.TabStop = false;
            // 
            // addEquation_btn
            // 
            this.addEquation_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addEquation_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addEquation_btn.BorderRadius = 7;
            this.addEquation_btn.BorderSize = 0;
            this.addEquation_btn.FlatAppearance.BorderSize = 0;
            this.addEquation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEquation_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEquation_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addEquation_btn.Image = ((System.Drawing.Image)(resources.GetObject("addEquation_btn.Image")));
            this.addEquation_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEquation_btn.Location = new System.Drawing.Point(260, 86);
            this.addEquation_btn.Name = "addEquation_btn";
            this.addEquation_btn.Size = new System.Drawing.Size(140, 35);
            this.addEquation_btn.TabIndex = 25;
            this.addEquation_btn.Text = "        Denklem";
            this.addEquation_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEquation_btn.UseVisualStyleBackColor = false;
            this.addEquation_btn.Click += new System.EventHandler(this.addEquation_btn_Click);
            // 
            // addSymbol_btn
            // 
            this.addSymbol_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addSymbol_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addSymbol_btn.BorderRadius = 7;
            this.addSymbol_btn.BorderSize = 0;
            this.addSymbol_btn.FlatAppearance.BorderSize = 0;
            this.addSymbol_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSymbol_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addSymbol_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addSymbol_btn.Image = ((System.Drawing.Image)(resources.GetObject("addSymbol_btn.Image")));
            this.addSymbol_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSymbol_btn.Location = new System.Drawing.Point(260, 48);
            this.addSymbol_btn.Name = "addSymbol_btn";
            this.addSymbol_btn.Size = new System.Drawing.Size(140, 35);
            this.addSymbol_btn.TabIndex = 24;
            this.addSymbol_btn.Text = "        Sembol";
            this.addSymbol_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSymbol_btn.UseVisualStyleBackColor = false;
            this.addSymbol_btn.Click += new System.EventHandler(this.addSymbol_btn_Click);
            // 
            // addEmoji_btn
            // 
            this.addEmoji_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addEmoji_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addEmoji_btn.BorderRadius = 7;
            this.addEmoji_btn.BorderSize = 0;
            this.addEmoji_btn.Enabled = false;
            this.addEmoji_btn.FlatAppearance.BorderSize = 0;
            this.addEmoji_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmoji_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmoji_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addEmoji_btn.Image = ((System.Drawing.Image)(resources.GetObject("addEmoji_btn.Image")));
            this.addEmoji_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmoji_btn.Location = new System.Drawing.Point(260, 10);
            this.addEmoji_btn.Name = "addEmoji_btn";
            this.addEmoji_btn.Size = new System.Drawing.Size(140, 35);
            this.addEmoji_btn.TabIndex = 23;
            this.addEmoji_btn.Text = "        Emoji";
            this.addEmoji_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmoji_btn.UseVisualStyleBackColor = false;
            // 
            // textAdd_lbl
            // 
            this.textAdd_lbl.AutoSize = true;
            this.textAdd_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdd_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAdd_lbl.Location = new System.Drawing.Point(266, 129);
            this.textAdd_lbl.Name = "textAdd_lbl";
            this.textAdd_lbl.Size = new System.Drawing.Size(36, 18);
            this.textAdd_lbl.TabIndex = 22;
            this.textAdd_lbl.Text = "Yazı";
            // 
            // addLink_btn
            // 
            this.addLink_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addLink_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.addLink_btn.BorderRadius = 7;
            this.addLink_btn.BorderSize = 0;
            this.addLink_btn.FlatAppearance.BorderSize = 0;
            this.addLink_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLink_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLink_btn.ForeColor = System.Drawing.Color.LightGray;
            this.addLink_btn.Image = ((System.Drawing.Image)(resources.GetObject("addLink_btn.Image")));
            this.addLink_btn.Location = new System.Drawing.Point(153, 10);
            this.addLink_btn.Name = "addLink_btn";
            this.addLink_btn.Size = new System.Drawing.Size(100, 105);
            this.addLink_btn.TabIndex = 21;
            this.addLink_btn.Text = "Bağlantı";
            this.addLink_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addLink_btn.UseVisualStyleBackColor = false;
            this.addLink_btn.Click += new System.EventHandler(this.addLink_btn_Click);
            // 
            // addLine1
            // 
            this.addLine1.Image = ((System.Drawing.Image)(resources.GetObject("addLine1.Image")));
            this.addLine1.Location = new System.Drawing.Point(141, 19);
            this.addLine1.Name = "addLine1";
            this.addLine1.Size = new System.Drawing.Size(3, 115);
            this.addLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addLine1.TabIndex = 20;
            this.addLine1.TabStop = false;
            // 
            // dateandtime_lbl
            // 
            this.dateandtime_lbl.AutoSize = true;
            this.dateandtime_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateandtime_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateandtime_lbl.Location = new System.Drawing.Point(20, 129);
            this.dateandtime_lbl.Name = "dateandtime_lbl";
            this.dateandtime_lbl.Size = new System.Drawing.Size(100, 18);
            this.dateandtime_lbl.TabIndex = 19;
            this.dateandtime_lbl.Text = "Tarih ve Saat";
            // 
            // dateandtime_btn
            // 
            this.dateandtime_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dateandtime_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dateandtime_btn.BorderRadius = 7;
            this.dateandtime_btn.BorderSize = 0;
            this.dateandtime_btn.FlatAppearance.BorderSize = 0;
            this.dateandtime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateandtime_btn.Font = new System.Drawing.Font("Wanted Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateandtime_btn.ForeColor = System.Drawing.Color.LightGray;
            this.dateandtime_btn.Image = ((System.Drawing.Image)(resources.GetObject("dateandtime_btn.Image")));
            this.dateandtime_btn.Location = new System.Drawing.Point(16, 10);
            this.dateandtime_btn.Name = "dateandtime_btn";
            this.dateandtime_btn.Size = new System.Drawing.Size(110, 110);
            this.dateandtime_btn.TabIndex = 12;
            this.dateandtime_btn.Text = "Tarih ve Saat";
            this.dateandtime_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dateandtime_btn.UseVisualStyleBackColor = false;
            this.dateandtime_btn.Click += new System.EventHandler(this.dateandtime_btn_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1360, 800);
            this.Controls.Add(this.searchMenu);
            this.Controls.Add(this.findMenu);
            this.Controls.Add(this.newMenu);
            this.Controls.Add(this.openMenu);
            this.Controls.Add(this.saveMenu);
            this.Controls.Add(this.exportMenu);
            this.Controls.Add(this.pageColorMenu);
            this.Controls.Add(this.shareMenu);
            this.Controls.Add(this.textColorSelectMenu);
            this.Controls.Add(this.highlightColorSelectMenu);
            this.Controls.Add(this.menu_highlight);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.helpMenu);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.bulletListMenu);
            this.Controls.Add(this.lineSpacing_menu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.rulerMenu);
            this.Controls.Add(this.txtboxPanel);
            this.Controls.Add(this.appearenceMenu);
            this.Controls.Add(this.toolbarMenu);
            this.Controls.Add(this.editMenu);
            this.Controls.Add(this.addMenu);
            this.Controls.Add(this.backgroundPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "mainwindow";
            this.Text = "opentypr | Adsız Belge";
            this.Load += new System.EventHandler(this.mainwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_highlight)).EndInit();
            this.txtboxPanel.ResumeLayout(false);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.windowCtrlMenu.ResumeLayout(false);
            this.searchMenu.ResumeLayout(false);
            this.searchMenu.PerformLayout();
            this.exportMenu.ResumeLayout(false);
            this.shareMenu.ResumeLayout(false);
            this.saveMenu.ResumeLayout(false);
            this.openMenu.ResumeLayout(false);
            this.newMenu.ResumeLayout(false);
            this.highlightColorSelectMenu.ResumeLayout(false);
            this.highlightColorSelectMenu.PerformLayout();
            this.textColorSelectMenu.ResumeLayout(false);
            this.textColorSelectMenu.PerformLayout();
            this.findMenu.ResumeLayout(false);
            this.findMenu.PerformLayout();
            this.helpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_buffer)).EndInit();
            this.fileMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileLine1)).EndInit();
            this.bulletListMenu.ResumeLayout(false);
            this.lineSpacing_menu.ResumeLayout(false);
            this.lineSpacing_menu.PerformLayout();
            this.pageColorMenu.ResumeLayout(false);
            this.pageColorMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.subStatusBar.ResumeLayout(false);
            this.subStatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarZoom_trck)).EndInit();
            this.rulerMenu.ResumeLayout(false);
            this.subRulerMenu.ResumeLayout(false);
            this.subRulerMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruler)).EndInit();
            this.appearenceMenu.ResumeLayout(false);
            this.appearenceMenu.PerformLayout();
            this.zoomMenu.ResumeLayout(false);
            this.zoomMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apprLine1)).EndInit();
            this.toolbarMenu.ResumeLayout(false);
            this.toolbarMenu.PerformLayout();
            this.textTemplatesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highlightColorIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textColorIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsLine1)).EndInit();
            this.editMenu.ResumeLayout(false);
            this.editMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLine1)).EndInit();
            this.addMenu.ResumeLayout(false);
            this.addMenu.PerformLayout();
            this.addReferenceNoMenu.ResumeLayout(false);
            this.addReferenceNoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLine1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_img;
        private Modules.CustomButtons file_btn;
        private Modules.CustomButtons minimize_btn;
        private Modules.CustomButtons maximize_btn;
        private Modules.CustomButtons close_btn;
        private Modules.CustomPanels windowCtrlMenu;
        private System.Windows.Forms.Label fileName_lbl;
        private System.Windows.Forms.PictureBox menu_highlight;
        private Modules.CustomButtons edit_btn;
        private Modules.CustomButtons add_btn;
        private Modules.CustomButtons toolbar_btn;
        private Modules.CustomButtons settings_btn;
        private Modules.CustomButtons helpParent_btn;
        private System.Windows.Forms.Timer anim_timer;
        private Modules.CustomButtons new_btn;
        private Modules.CustomPanels fileMenu;
        private Modules.CustomButtons open_btn;
        private Modules.CustomButtons saveparent_btn;
        private Modules.CustomButtons print_btn;
        private Modules.CustomButtons export_btn;
        private Modules.CustomButtons share_btn;
        private Modules.CustomPanels newMenu;
        private Modules.CustomButtons template_btn;
        private Modules.CustomButtons emptyDoc_btn;
        private Modules.CustomPanels openMenu;
        private Modules.CustomButtons dropfile_btn;
        private Modules.CustomButtons selectfile_btn;
        private Modules.CustomPanels saveMenu;
        private Modules.CustomButtons saveAs_btn;
        private Modules.CustomButtons save_btn;
        private Modules.CustomPanels shareMenu;
        private Modules.CustomButtons email_btn;
        private Modules.CustomButtons toTeams_btn;
        private Modules.CustomPanels exportMenu;
        private Modules.CustomButtons toRTF_btn;
        private Modules.CustomButtons toDOCX_btn;
        private Modules.CustomButtons toPDF_btn;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private Modules.AdvancedTextBox main_textbox;
        private System.Windows.Forms.FlowLayoutPanel txtboxPanel;
        private Modules.CustomPanels toolbarMenu;
        private Modules.CustomButtons paste_btn;
        private Modules.CustomButtons cut_btn;
        private Modules.CustomButtons copy_btn;
        private System.Windows.Forms.PictureBox toolsLine1;
        private System.Windows.Forms.Label general_lbl;
        private Modules.CustomButtons undo_btn;
        private Modules.CustomButtons redo_btn;
        private Modules.CustomButtons select_btn;
        private Modules.CustomButtons selectall_btn;
        private System.Windows.Forms.PictureBox toolsLine2;
        private System.Windows.Forms.Label font_lbl;
        private System.Windows.Forms.PictureBox toolsLine5;
        private System.Windows.Forms.Label textTemplates_lbl;
        private System.Windows.Forms.PictureBox toolsLine4;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.PictureBox toolsLine3;
        private System.Windows.Forms.Label paragraph_lbl;
        private System.Windows.Forms.ComboBox fontSelector_cmb;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.ComboBox fontSizeSelector_cmb;
        private Modules.CustomButtons bold_btn;
        private Modules.CustomButtons italic_btn;
        private Modules.CustomButtons strikethrough_btn;
        private Modules.CustomButtons underlined_btn;
        private Modules.CustomButtons textcolor_btn;
        private System.Windows.Forms.PictureBox textColorIndicator;
        private Modules.CustomButtons decreaseFontSize_btn;
        private Modules.CustomButtons increaseFontSize_btn;
        private System.Windows.Forms.PictureBox highlightColorIndicator;
        private Modules.CustomButtons highlight_btn;
        private Modules.CustomButtons characterGap_btn;
        private Modules.CustomButtons deleteForming_btn;
        private Modules.CustomButtons alignToRight_btn;
        private Modules.CustomButtons alignToMiddle_btn;
        private Modules.CustomButtons alignToLeft_btn;
        private Modules.CustomButtons bulletList_btn;
        private Modules.CustomButtons lineGap_btn;
        private Modules.CustomButtons unlock_btn;
        private Modules.CustomButtons increaseIndent_btn;
        private Modules.CustomButtons decreaseIndent_btn;
        private Modules.CustomButtons lock_btn;
        private Modules.CustomButtons subscript_btn;
        private Modules.CustomButtons superscript_btn;
        private Modules.CustomButtons searchParent_btn;
        private Modules.CustomButtons findParent_btn;
        private Modules.CustomButtons defaultTextTemplate_btn;
        private System.Windows.Forms.FlowLayoutPanel textTemplatesMenu;
        private Modules.CustomButtons bodyText_btn;
        private Modules.CustomButtons title1_btn;
        private Modules.CustomButtons title2_btn;
        private Modules.CustomButtons subtitle_btn;
        private Modules.CustomPanels lineSpacing_menu;
        private System.Windows.Forms.Label lineSpacing_lbl;
        private System.Windows.Forms.ComboBox lineSpacing_cmb;
        private Modules.CustomPanels bulletListMenu;
        private Modules.CustomButtons bullet2_btn;
        private Modules.CustomButtons bullet3_btn;
        private Modules.CustomButtons bullet1_btn;
        private Modules.CustomButtons bullet5_btn;
        private Modules.CustomButtons bullet6_btn;
        private Modules.CustomButtons bullet4_btn;
        private Modules.CustomPanels findMenu;
        private Modules.CustomButtons find_btn;
        private Modules.CustomButtons closeFind_btn;
        private Modules.CustomPanels searchMenu;
        private Modules.CustomButtons search_btn;
        private Modules.CustomPanels addMenu;
        private System.Windows.Forms.Label dateandtime_lbl;
        private Modules.CustomButtons dateandtime_btn;
        private System.Windows.Forms.PictureBox addLine1;
        private Modules.CustomButtons addLink_btn;
        private Modules.CustomButtons addEquation_btn;
        private Modules.CustomButtons addSymbol_btn;
        private Modules.CustomButtons addEmoji_btn;
        private System.Windows.Forms.Label textAdd_lbl;
        private System.Windows.Forms.PictureBox addLine2;
        private Modules.CustomButtons addImage_btn;
        private System.Windows.Forms.PictureBox addLine3;
        private System.Windows.Forms.Label media_lbl;
        private Modules.CustomButtons addTable_btn;
        private Modules.CustomButtons addVideo_btn;
        private System.Windows.Forms.Label reference_lbl;
        private Modules.CustomButtons addReference_btn;
        private Modules.CustomButtons addNote_btn;
        private Modules.CustomButtons addReferenceNoParent_btn;
        private System.Windows.Forms.PictureBox addLine4;
        private Modules.CustomPanels editMenu;
        private System.Windows.Forms.Label page_lbl;
        private Modules.CustomButtons pageSize_btn;
        private Modules.CustomButtons horizontalPage_btn;
        private Modules.CustomButtons verticalPage_btn;
        private System.Windows.Forms.Label appearancePage_lbl;
        private System.Windows.Forms.PictureBox editLine1;
        private Modules.CustomButtons indentSize_btn;
        private Modules.CustomButtons detectLinks_btn;
        private Modules.CustomButtons refresh_btn;
        private Modules.CustomButtons draganddropEnabled_btn;
        private System.Windows.Forms.Label otherEdit_lbl;
        private System.Windows.Forms.PictureBox editLine2;
        private System.Windows.Forms.PictureBox editLine3;
        private Modules.CustomPanels appearenceMenu;
        private Modules.CustomButtons statusbar_btn;
        private Modules.CustomButtons ruler_btn;
        private System.Windows.Forms.Label show_lbl;
        private System.Windows.Forms.PictureBox apprLine1;
        private Modules.CustomButtons zoom_btn;
        private Modules.CustomButtons defaultZoom_btn;
        private System.Windows.Forms.Label zoomcategory_lbl;
        private System.Windows.Forms.PictureBox apprLine3;
        private Modules.CustomButtons darkTheme_btn;
        private Modules.CustomButtons lightTheme_btn;
        private System.Windows.Forms.Label theme_lbl;
        private System.Windows.Forms.PictureBox apprLine2;
        private System.Windows.Forms.Label zoom_lbl;
        private Modules.CustomPanels helpMenu;
        private Modules.CustomButtons about_btn;
        private System.Windows.Forms.PictureBox img_buffer;
        private Modules.CustomButtons reportBugs_btn;
        private Modules.CustomButtons help_btn;
        private Modules.CustomPanels addReferenceNoMenu;
        private System.Windows.Forms.Label number_lbl;
        private System.Windows.Forms.TextBox referenceNo_txt;
        private Modules.CustomButtons addReferenceNo_btn;
        private Modules.CustomPanels statusBar;
        private System.Windows.Forms.Label OSandFormatting_lbl;
        private System.Windows.Forms.Label numberOfCharacters_lbl;
        private System.Windows.Forms.Label statusBarZoom_lbl;
        private System.Windows.Forms.TrackBar statusBarZoom_trck;
        private Modules.CustomPanels textColorSelectMenu;
        private Modules.CustomButtons textColorSelectColor_btn;
        private System.Windows.Forms.Label textColorBlue_lbl;
        private System.Windows.Forms.Label textColorGreen_lbl;
        private System.Windows.Forms.Label textColorRed_lbl;
        private System.Windows.Forms.Label textColorMenuIndicator;
        private System.Windows.Forms.TextBox textColorBlueValue_lbl;
        private System.Windows.Forms.TextBox textColorGreenValue_lbl;
        private System.Windows.Forms.TextBox textColorRedValue_lbl;
        private Modules.CustomButtons textColorRed_btn;
        private Modules.CustomButtons textColorPink_btn;
        private Modules.CustomButtons textColorPurple_btn;
        private Modules.CustomButtons textColorDarkBlue_btn;
        private Modules.CustomButtons textColorBlue_btn;
        private Modules.CustomButtons textColorTurqoise_btn;
        private Modules.CustomButtons textColorLime_btn;
        private Modules.CustomButtons textColorSeaGreen_btn;
        private Modules.CustomButtons textColorLightGreen_btn;
        private Modules.CustomButtons textColorYellow_btn;
        private Modules.CustomButtons textColorOrange_btn;
        private Modules.CustomButtons textColorWhite_btn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Modules.CustomPanels highlightColorSelectMenu;
        private Modules.CustomButtons highlightWhite_btn;
        private Modules.CustomButtons highlightPink_btn;
        private Modules.CustomButtons highlightPurple_btn;
        private Modules.CustomButtons highlightDarkBlue_btn;
        private Modules.CustomButtons highlightBlue_btn;
        private Modules.CustomButtons highlightTurquoise_btn;
        private Modules.CustomButtons highlightLime_btn;
        private Modules.CustomButtons highlightSeaGreen_btn;
        private Modules.CustomButtons highlightLightGreen_btn;
        private Modules.CustomButtons highlightYellow_btn;
        private Modules.CustomButtons highlightOrange_btn;
        private Modules.CustomButtons highlightRed_btn;
        private System.Windows.Forms.Label highlightBlue_lbl;
        private System.Windows.Forms.Label highlightGreen_lbl;
        private System.Windows.Forms.Label highlightRed_lbl;
        private System.Windows.Forms.Label highlightColorMenuIndicator;
        private System.Windows.Forms.TextBox highlightBlueValue_lbl;
        private System.Windows.Forms.TextBox highlightGreenValue_lbl;
        private System.Windows.Forms.TextBox highlightRedValue_lbl;
        private Modules.CustomButtons highlightSelectColor_btn;
        private Modules.CustomButtons closeHighlight_btn;
        private Modules.CustomButtons appearance_btn;
        private System.Windows.Forms.Panel topMenu;
        private Modules.CustomButtons fileinfo_btn;
        private Modules.CustomButtons filename_btn;
        private System.Windows.Forms.Label numberOfPages_lbl;
        private Modules.CustomButtons closeSearch_btn;
        private System.Windows.Forms.TextBox find_txt;
        private System.Windows.Forms.TextBox search_txtBox;
        private Modules.CustomPanels pageColorMenu;
        private Modules.CustomButtons pageColorWhite_btn;
        private Modules.CustomButtons pageColorPink_btn;
        private Modules.CustomButtons pageColorPurple_btn;
        private Modules.CustomButtons pageColorDarkBlue_btn;
        private Modules.CustomButtons pageColorBlue_btn;
        private Modules.CustomButtons pageColorTurqoise_btn;
        private Modules.CustomButtons pageColorLime_btn;
        private Modules.CustomButtons pageColorSeaGreen_btn;
        private Modules.CustomButtons pageColorLightGreen_btn;
        private Modules.CustomButtons pageColorYellow_btn;
        private Modules.CustomButtons pageColorOrange_btn;
        private Modules.CustomButtons pageColorRed_btn;
        private System.Windows.Forms.Label pageColorBlue_lbl;
        private System.Windows.Forms.Label pageColorGreen_lbl;
        private System.Windows.Forms.Label pageColorRed_lbl;
        private System.Windows.Forms.Label pageColorMenuIndicator;
        private System.Windows.Forms.TextBox pageColorBlueValue_lbl;
        private System.Windows.Forms.TextBox pageColorGreenValue_lbl;
        private System.Windows.Forms.TextBox pageColorRedValue_lbl;
        private Modules.CustomButtons pageColorSelectColor_btn;
        private Modules.CustomButtons pageColor_btn;
        private Modules.CustomPanels zoomMenu;
        private Modules.CustomButtons zoomDecrease_btn;
        private Modules.CustomButtons zoomIncrease_btn;
        private System.Windows.Forms.TrackBar zoomTrackBar1;
        private Modules.CustomPanels rulerMenu;
        private System.Windows.Forms.TrackBar ruler;
        private System.Windows.Forms.Panel subStatusBar;
        private System.Windows.Forms.Panel subRulerMenu;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.PictureBox fileLine2;
        private System.Windows.Forms.PictureBox fileLine1;
    }
}

