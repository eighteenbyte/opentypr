using opentypr.Modules;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;


namespace opentypr
{
    public partial class mainwindow : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Point mouseLoc;
        public int animPos;
        public string filePath;
        public string msgboxTitle;
        public string msgboxDesc;

        //Sürüm kodu ve sürüm
        public string versionCode = "OTBe01";
        public string versionNo = "Beta 0.1";

        //Eklenecek yazılar, eklenecek mi...
        public static string appended_words;
        public static bool isAppendWords;
        public static bool isAppendWordsWild;
        public static bool isAppendReference;
        public static string reference_number;
        public static bool isAppendNotes;
        public static bool isTemplateAdded;

        //istatistikler ve sayfa özellikleri
        public static bool filename_changed;
        public static int character_number;
        public static int page_length;
        public static int page_width = 1554;
        public static int words;
        public static int lines;
        public static int onepage_length = 2198;
        public static bool indent_changed;
        public static int indent_right = 40;
        public static int indent_left = 40;
        public static int indent_top = 40;
        public int zoom_value = 100;

        //font standartları
        Font buttonFont = new Font("Wanted Sans SemiBold", 10);
        Font buttonFont2 = new Font("Wanted Sans SemiBold", 8);
        Font labelFont = new Font("Wanted Sans", 7, FontStyle.Bold);
        Font labelFont2 = new Font("Wanted Sans", 7);
        public string publicFont = "Wanted Sans Medium";
        public FontFamily publicFontFamily;

        //74 piksel = 1cm
        public static int page_count = 1;
        public Color text_color = Color.White;
        public Color highlight_color = Color.FromArgb(103, 103, 103);
        public Color page_color = Color.FromArgb(103, 103, 103);
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT lParam);
        const int PFM_SPACEBEFORE = 0x00000040;
        const int PFM_SPACEAFTER = 0x00000080;
        const int PFM_LINESPACING = 0x00000100;
        const int SCF_SELECTION = 1;
        const int EM_SETPARAFORMAT = 1095;
        int space = 0;
        int grip = 16;
        int caption = 40;

        //tablolar
        public static int rows;
        public static int columns;
        public static int tableWidth;
        public static bool isTableDrawn;
        [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool Repaint);
        public mainwindow(string s)
        {
            InitializeComponent();
            AutoUpdate();

            fontSelector_cmb.DataSource = FontFamily.Families.ToList();
            RegisterClickEvents(this);

            if(s != "Adsız")
            {
                LoadFileOnStartup(s);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;

            // PARAFORMAT2
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if(p.Y <= caption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - grip && p.Y >= ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
                if (p.X <= grip && p.Y >= ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)16;
                    return;
                }
                if (p.X <= grip)
                {
                    m.Result = (IntPtr)10;
                    return;
                }
                if (p.X >= this.ClientSize.Width - grip)
                {
                    m.Result = (IntPtr)11;
                    return;
                }
                if (p.Y <= grip)
                {
                    m.Result = (IntPtr)12;
                    return;
                }
                if (p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)15;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseLoc = e.Location;
        }

        private void topMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + e.X - mouseLoc.X, Location.Y + e.Y - mouseLoc.Y);
        }

        public void LoadFileOnStartup(string path)
        {
            RichTextBoxStreamType type = RichTextBoxStreamType.RichText;
            try
            {
                main_textbox.LoadFile(path, type);
            }
            catch
            {
                main_textbox.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
            filePath = path;
            fileName_lbl.Text = "| " + path;
        }

        public void AutoUpdate()
        {
            try
            {
                WebClient webClient = new WebClient();
                var client = new WebClient();
                if (!webClient.DownloadString("https://www.dropbox.com/scl/fi/nflilu2tf208friy70f33/version.txt?rlkey=z9dwh179pw2004vjrm3htnzzf&st=92a6nfce&dl=1").Contains("0.1"))
                {
                    if (MessageBox.Show("Yeni bir sürüm mevcut! İndirmek ister misin? (Bu genelde 1 dakika alır ve mükemmel özellikler ekler!)", "opentypr Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (File.Exists(@".\opentyprSetup.exe")) { File.Delete(@".\opentyprSetup.exe"); }
                            client.DownloadFile("https://www.dropbox.com/scl/fi/mzwpfhamagrp5457xl9ia/opentyprSetup.zip?rlkey=1jhzh36mdo974w6vu7xtx7hlf&st=ao5pxh4m&dl=1", @"opentyprSetup.zip");
                            string zipPath = @".\opentyprSetup.zip";
                            string extractPath = @".\";
                            ZipFile.ExtractToDirectory(zipPath, extractPath);
                            Process process = new Process();
                            process.StartInfo.FileName = "msiexec.exe";
                            process.StartInfo.Arguments = string.Format("/i opentyprSetup.exe");
                            this.Close();
                            process.Start();
                        }
                        catch
                        {
                            MessageBox.Show("Güncelleme İndirilemedi. Acaba internetinizde bir problem olabilir mi? Sorun devam ederse https://eighteenbyte.com adresinden uygulamayı yeniden indirmeyi deneyin.", "opentypr - Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Güncelleme İndirilemedi. Acaba internetinizde bir problem olabilir mi? Sorun devam ederse https://eighteenbyte.com adresinden uygulamayı yeniden indirmeyi deneyin.", "opentypr - Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void mainwindow_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            if (Properties.Settings.Default.darktheme ==  true)
                DarkTheme();
            else
                LightTheme();
            main_textbox.SetInnerMargins(indent_left, indent_top, indent_right, 0);
            
            bool Result = MoveWindow(this.Handle, this.Left, this.Top, 1400, 700, true);
            page_length = main_textbox.Height;
            fontRefresh();
        }

        private void setLineFormat(byte rule, int space)
        {
            PARAFORMAT fmt = new PARAFORMAT();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.dwMask = PFM_LINESPACING;
            fmt.dyLineSpacing = space;
            fmt.bLineSpacingRule = rule;
            main_textbox.SelectAll();
            SendMessage(new HandleRef(main_textbox, main_textbox.Handle),
                         EM_SETPARAFORMAT,
                         SCF_SELECTION,
                         ref fmt
                       );
        }

        private void close_btn_Click(object sender, EventArgs e) => Close();

        //şuanlık tam ekran düğmesi yok
        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;  
        }

        private void minimize_btn_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void SetButtonState(Button activeButton, int position, Panel activePanel)
        {
            Color activeColor = Properties.Settings.Default.darktheme ? Color.White : Color.Black;
            Color inactiveColor = Properties.Settings.Default.darktheme ? Color.LightGray : Color.FromArgb(30, 30, 30);

            toolbar_btn.ForeColor = inactiveColor;
            add_btn.ForeColor = inactiveColor;
            edit_btn.ForeColor = inactiveColor;
            appearance_btn.ForeColor = inactiveColor;

            activeButton.ForeColor = activeColor;

            toolbarMenu.Visible = false;
            addMenu.Visible = false;
            editMenu.Visible = false;
            appearenceMenu.Visible = false;

            activePanel.Visible = true;
            animPos = position;
            anim_timer.Enabled = true;
        }

        //bu sayılar altındaki highlight'ın yatay pozisyonda nereye gideceğini belirtiyor, çözünürlük değişse de problem değil
        private void toolbar_btn_Click(object sender, EventArgs e) => SetButtonState(add_btn, 158, toolbarMenu);
        private void add_btn_Click(object sender, EventArgs e) => SetButtonState(add_btn, 270, addMenu);
        private void edit_btn_Click(object sender, EventArgs e) => SetButtonState(add_btn, 371, editMenu);
        private void appearance_btn_Click(object sender, EventArgs e) => SetButtonState(add_btn, 480, appearenceMenu);

        //bu animasyon için olan fonksiyon biraz karışık çalışıyor nasıl olsa diye bıraktım :) -maqs
        private void anim_timer_Tick(object sender, EventArgs e)
        {
            int diff = animPos - menu_highlight.Left;

            if (diff != 0)
            {
                int step = Math.Abs(diff) < 15 ? 1 : 15;
                menu_highlight.Left += Math.Sign(diff) * step;
            }
            else
                anim_timer.Enabled = false;
        }

        private void file_btn_Click(object sender, EventArgs e)
        {
            bool visible = !fileMenu.Visible;
            ShutdownAllMinorPanels();
            fileMenu.Visible = visible;

            Color selectedColor = Properties.Settings.Default.darktheme ? Color.White : Color.Black;
            Color defaultColor = Properties.Settings.Default.darktheme ? Color.LightGray : Color.FromArgb(30, 30, 30);

            file_btn.ForeColor = visible ? selectedColor : defaultColor;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (newMenu.Visible == false)
                ShowOnlyPanel(newMenu);
            else
                newMenu.Visible = false;
        }

        private void new_btn_MouseEnter(object sender, EventArgs e) => ShowOnlyPanel(newMenu);

        private void emptyDoc_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kaydedilmeyen değişiklikler silinecektir. Yeni bir belge açılmasını istiyor musunuz?", "opentypr", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                main_textbox.Text = "";
                file_btn.PerformClick();
            }
        }

        private void TogglePanelVisibility(Panel targetPanel)
        {
            bool isVisible = targetPanel.Visible;
            HideFilePanels();
            targetPanel.Visible = !isVisible;
        }

        private void ShowOnlyPanel(Panel targetPanel)
        {
            HideFilePanels();
            targetPanel.Visible = true;
        }

        private void HideFilePanels()
        {
            openMenu.Visible = false;
            newMenu.Visible = false;
            saveMenu.Visible = false;
            shareMenu.Visible = false;
            exportMenu.Visible = false;
        }

        private void open_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(openMenu);
        private void open_btn_MouseEnter(object sender, EventArgs e) => ShowOnlyPanel(openMenu);
        private void saveparent_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(saveMenu);
        private void saveparent_btn_MouseEnter(object sender, EventArgs e) => ShowOnlyPanel(saveMenu);
        private void share_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(shareMenu);
        private void share_btn_MouseEnter(object sender, EventArgs e) => ShowOnlyPanel(shareMenu);
        private void export_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(exportMenu);
        private void export_btn_MouseEnter(object sender, EventArgs e) => ShowOnlyPanel(exportMenu);

        private void selectfile_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Tüm Dosyalar(*.*)|*.*|Word Dosyası(*.docx)|*.docx|Zengin Metin Belgesi(*.rtf)|*.rtf|Metin Belgesi(*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        main_textbox.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch
                    {
                        main_textbox.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    }         
                }
                filePath = ofd.FileName;
                fileName_lbl.Text = ofd.FileName;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))

            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Tüm Dosyalar(*.*)|*.*|Word Dosyası(*.docx)|*.docx|Zengin Metin Belgesi(*.rtf)|*.rtf|Metin Belgesi(*.txt)|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            main_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                        }
                        catch
                        {
                            main_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    filePath = sfd.FileName;
                    fileName_lbl.Text = sfd.FileName;
                }
            }
            else
            {
                try
                {
                    main_textbox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    main_textbox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void saveAs_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Tüm Dosyalar(*.*)|*.*|Word Dosyası(*.docx)|*.docx|Zengin Metin Belgesi(*.rtf)|*.rtf|Metin Belgesi(*.txt)|*.txt", ValidateNames = true })
            {
                sfd.FileName = fileInfo_window.fileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        main_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch
                    {
                        main_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                    }
                    filePath = sfd.FileName;
                    fileName_lbl.Text = "| " + sfd.FileName;
                    fileInfo_window.fileName = sfd.FileName;
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void toPDF_btn_Click(object sender, EventArgs e) => printDocument.Print();

        public int firstCharOnPage = 0;
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e) => firstCharOnPage = 0;
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            firstCharOnPage = main_textbox.FormatRange(false, e, firstCharOnPage, main_textbox.TextLength);
            if (firstCharOnPage < main_textbox.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
        private void printDocument_EndPrint(object sender, PrintEventArgs e) => main_textbox.FormatRangeDone();

        private void UpdateTextBoxHeight(RichTextBox tb)
        {
            int height = (int)Math.Round(this.CreateGraphics().MeasureString(tb.Text, tb.Font).Height, 0);
            int newHeight = CalculateTextLoss(height);
            if (newHeight > 500)
                tb.Height = newHeight;
        }

        private void UpdateTextStatistics(RichTextBox tb)
        {
            int len = tb.TextLength;
            lines = len > 0 ? tb.GetLineFromCharIndex(len - 1) + 1 : 0;
            character_number = len;
            words = tb.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            numberOfCharacters_lbl.Font = new Font("Wanted Sans", 7, FontStyle.Bold);
            numberOfCharacters_lbl.Text = $"Karakterler: {character_number}";

            numberOfPages_lbl.Font = new Font("Wanted Sans", 7, FontStyle.Bold);
            numberOfPages_lbl.Text = $"Sayfalar: {CalculatePageCount(page_length)}";

            page_length = main_textbox.Height;
        }

        private void main_textbox_TextChanged(object sender, EventArgs e)
        {
            //her ana yazı kutusunda bir değişiklik gerçekleştiğinde uzunluğunu ve istatistikleri güncelleyelim!
            if (sender is RichTextBox tb)
            {
                UpdateTextBoxHeight(tb);
                UpdateTextStatistics(tb);
            }
        }

        /*CalculateTextLoss ve CalculatePageCount yeteri derecede doğru hesaplıyor ama daha iyi hesaplayan bir
        fonksiyon yapabilirseniz yazmaktan çekinmeyin! -maqs */
        public int CalculateTextLoss(int height)
        {
            return height - (height / 11) / 4;
        }

        public int CalculatePageCount(int pageLength)
        {
            if (pageLength < onepage_length)
            {
                page_count = 1;
                return 1;
            }
            int rounded = (int)Math.Round((double)pageLength / onepage_length);
            page_count = (rounded >= ((double)pageLength / onepage_length)) ? rounded : rounded + 1;
            return page_count;
        }

        //tüm tek satırlık araçlar
        private void select_btn_Click(object sender, EventArgs e) => selectall_btn.Visible = !selectall_btn.Visible;
        private void paste_btn_Click(object sender, EventArgs e) => main_textbox.Paste();
        private void copy_btn_Click(object sender, EventArgs e) => main_textbox.Copy();
        private void undo_btn_Click(object sender, EventArgs e) => main_textbox.Undo();
        private void redo_btn_Click(object sender, EventArgs e) => main_textbox.Redo();
        private void cut_btn_Click(object sender, EventArgs e) => main_textbox.Cut();
        private void selectall_btn_Click(object sender, EventArgs e) => main_textbox.SelectAll();

        private void main_textbox_Click(object sender, EventArgs e)
        {
            ShutdownAllMinorPanels(); //ana yazı kutusuna dokunulunca tüm üst menüler kapansın
            bool hasSelection = main_textbox.SelectionLength > 0;
            copy_btn.Enabled = hasSelection;
            cut_btn.Enabled = hasSelection;
        }

        //tüm fontları combobox'a o fontun stiliyle yazan fonksiyon
        private void fontSelector_cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            var comboBox = (System.Windows.Forms.ComboBox)sender;
            var fontFamily = (FontFamily)comboBox.Items[e.Index];
            var font = new Font(fontFamily, comboBox.Font.SizeInPoints);

            e.DrawBackground();
            e.Graphics.DrawString(font.Name, font, Brushes.White, e.Bounds.X, e.Bounds.Y);
            publicFont = font.Name;
            publicFontFamily = fontFamily;
        }

        private void HandleAppendWords()
        {
            if(Properties.Settings.Default.darktheme)
                AppendFormattedText(main_textbox, appended_words, Color.White, false, 0);
            else
                AppendFormattedText(main_textbox, appended_words, Color.Black, false, 0);
            isAppendWords = false;
        }

        private void HandleAppendWordsWild()
        {
            if (Properties.Settings.Default.darktheme)
                AppendFormattedTextWild(main_textbox, appended_words, Color.White);
            else
                AppendFormattedTextWild(main_textbox, appended_words, Color.Black);
            isAppendWordsWild = false;
        }

        private void HandleDrawTable()
        {
            main_textbox.Rtf = InsertTableInRichTextBox(columns, rows, tableWidth);
            isTableDrawn = false;
        }

        private void HandleAppendReference()
        {
            AppendFormattedText(main_textbox, reference_number + ".     ", Color.CornflowerBlue, false, 0);
            if (Properties.Settings.Default.darktheme)
                AppendFormattedText(main_textbox, appended_words, Color.White, false, 0);
            else
                AppendFormattedText(main_textbox, appended_words, Color.Black, false, 0);
            isAppendReference = false;
        }

        private void HandleAppendNotes()
        {
            if (Properties.Settings.Default.darktheme)
                AppendFormattedText(main_textbox, "Not: " + appended_words, Color.White, true, 0);
            else
                AppendFormattedText(main_textbox, "Not: " + appended_words, Color.Black, true, 0);
            isAppendNotes = false;
        }

        private void HandleTemplateAddition()
        {
            switch (templates.template)
            {
                case 0: main_textbox.SelectedRtf = Properties.Resources.defaultTemplate; break;
                case 1: main_textbox.SelectedRtf = Properties.Resources.basic; break;
                case 2: main_textbox.SelectedRtf = Properties.Resources.modern; break;
                case 3: main_textbox.SelectedRtf = Properties.Resources.article; break;
                case 4: main_textbox.SelectedRtf = Properties.Resources.letter; break;
            }
            isTemplateAdded = false;
        }

        private void update_Tick(object sender, EventArgs e)
        {
            fontSelector_cmb.Text = publicFont;

            if (isAppendWords) HandleAppendWords();
            if (isAppendWordsWild) HandleAppendWordsWild();
            if (isTableDrawn) HandleDrawTable();
            if (isAppendReference) HandleAppendReference();
            if (isAppendNotes) HandleAppendNotes();
            if (isTemplateAdded) HandleTemplateAddition();

            if (filename_changed)
            {
                fileName_lbl.Text = "| " + fileInfo_window.fileName;
                fileName_lbl.Font = new Font("Wanted Sans SemiBold", 10);
                filename_changed = false;
            }
            if (indent_changed)
            {
                main_textbox.SetInnerMargins(indent_left, indent_top, indent_right, 0);
                ruler.Value = CalculateRulerValue(indent_left);
                indent_changed = false;
            }

            fontRefresh();
        }

        private void HandleNewFont()
        {
            Font newFont = new Font(publicFont, Int32.Parse(fontSizeSelector_cmb.Text));
            main_textbox.SelectionFont = newFont;
        }

        private void fontSelector_cmb_SelectedIndexChanged(object sender, EventArgs e) => HandleNewFont();
        private void fontSizeSelector_cmb_SelectedIndexChanged(object sender, EventArgs e) => HandleNewFont();

        private void ToggleFontStyle(FontStyle style)
        {
            Font selectedFont = main_textbox.SelectionFont;
            if (selectedFont != null)
                main_textbox.SelectionFont = new Font(selectedFont, selectedFont.Style ^ style);
        }

        private void bold_btn_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Bold);
        private void italic_btn_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Italic);
        private void underlined_btn_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Underline);
        private void strikethrough_btn_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Strikeout);

        private void ToggleCharOffset(int offset)
        {
            if (main_textbox.SelectionFont == null) return;

            if (main_textbox.SelectionCharOffset != offset)
                main_textbox.SelectionCharOffset = offset;
            else
                main_textbox.SelectionCharOffset = 0;
        }

        private void subscript_btn_Click(object sender, EventArgs e)
        {
            int offset = -main_textbox.SelectionFont.Height / 2;
            ToggleCharOffset(offset);
        }

        private void superscript_btn_Click(object sender, EventArgs e)
        {
            int offset = main_textbox.SelectionFont.Height / 2;
            ToggleCharOffset(offset);
        }

        private void ChangeFontSize(int delta)
        {
            if (int.TryParse(fontSizeSelector_cmb.Text, out int currentSize))
            {
                int newSize = currentSize + delta;
                if (newSize < 1) newSize = 1;
                fontSizeSelector_cmb.Text = newSize.ToString();
                main_textbox.SelectionFont = new Font(publicFont, newSize);
            }
        }

        private void decreaseFontSize_btn_Click(object sender, EventArgs e) => ChangeFontSize(-1);
        private void increaseFontSize_btn_Click(object sender, EventArgs e) => ChangeFontSize(1);

        private void deleteForming_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu işlem zengin metin belgenizdeki tüm yazı tiplerini, renklerini, vurguları ve hizalandırmaları kısacası tüm biçimlendirmeyi silecektir. İşleme devam etmek ister misiniz?", "Biçimlendirmeyi Silmeye Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //varsayılan yazı formasyonu
                main_textbox.Font = new Font("Wanted Sans Medium", 12);
                main_textbox.ForeColor = Color.White;
                fontSelector_cmb.Text = "Wanted Sans Medium";
                fontSizeSelector_cmb.Text = "12";
            }
        }

        private void AlignText(HorizontalAlignment alignment)
        {
            main_textbox.SelectAll();
            main_textbox.SelectionAlignment = alignment;
        }

        //girinti artacaksa true, azalacaksa false
        private void ChangeIndent(int changeIndentBy, bool isIncreasing)
        {
            if(isIncreasing)
            {
                int newIndent = indent_left + 20;
                if (newIndent > 140) newIndent = 140;
                main_textbox.SetInnerMargins(newIndent, indent_top, indent_right, 0);
                indent_left = newIndent;
            }
            else
            {
                int newIndent = indent_left - 20;
                if (newIndent < 40) newIndent = 40;
                main_textbox.SetInnerMargins(newIndent, indent_top, indent_right, 0);
                indent_left = newIndent;
            }
            ruler.Value = CalculateRulerValue(indent_left);
        }

        private void decreaseIndent_btn_Click(object sender, EventArgs e) => ChangeIndent(20, false);
        private void increaseIndent_btn_Click(object sender, EventArgs e) => ChangeIndent(20, true);

        public int CalculateRulerValue(int indent)
        {
            return (int)Math.Round(indent / 4.0); //daha spesifik bir hesaplama yöntemi bulunabilir
        }

        private void alignToMiddle_btn_Click(object sender, EventArgs e) => AlignText(HorizontalAlignment.Center);
        private void alignToLeft_btn_Click(object sender, EventArgs e) => AlignText(HorizontalAlignment.Left);
        private void alignToRight_btn_Click(object sender, EventArgs e) => AlignText(HorizontalAlignment.Right);

        private void SetReadOnlyMode(bool isReadOnly)
        {
            main_textbox.ReadOnly = isReadOnly;
            lock_btn.Visible = !isReadOnly;
            unlock_btn.Visible = isReadOnly;
        }

        private void lock_btn_Click(object sender, EventArgs e) => SetReadOnlyMode(true);
        private void unlock_btn_Click(object sender, EventArgs e) => SetReadOnlyMode(false);

        private void lineGap_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(lineSpacing_menu);
        private void bulletList_btn_Click(object sender, EventArgs e) => TogglePanelVisibility(bulletListMenu);

        private void lineSpacing_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lineSpacing_cmb.Text)
            {
                case "1": setLineFormat(0, space); break;
                case "1,5": setLineFormat(1, space); break;
                case "2": setLineFormat(2, space); break;
            }
        }

        private void ShutdownAllMinorPanels()
        {
            fileMenu.Visible = false;
            openMenu.Visible = false;
            newMenu.Visible = false;
            shareMenu.Visible = false;
            lineSpacing_menu.Visible = false;
            exportMenu.Visible = false;
            bulletListMenu.Visible = false;
            helpMenu.Visible = false;
        }

        private void SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType type, AdvancedTextBox.AdvRichTextBulletStyle style)
        {
            main_textbox.BulletType = type;
            main_textbox.BulletStyle = style;
            main_textbox.NumberedBullet(true);
            bulletListMenu.Visible = false;
        }

        private void bullet1_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.Number, AdvancedTextBox.AdvRichTextBulletStyle.Period);
        private void bullet2_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.UpperCaseLetter, AdvancedTextBox.AdvRichTextBulletStyle.RightParenthesis);
        private void bullet3_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.Number, AdvancedTextBox.AdvRichTextBulletStyle.RightParenthesis);
        private void bullet4_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.LowerCaseLetter, AdvancedTextBox.AdvRichTextBulletStyle.RightParenthesis);
        private void bullet5_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.UpperCaseRoman, AdvancedTextBox.AdvRichTextBulletStyle.Period);
        private void bullet6_btn_Click(object sender, EventArgs e) => SetBulletFormat(AdvancedTextBox.AdvRichTextBulletType.LowerCaseRoman, AdvancedTextBox.AdvRichTextBulletStyle.Period);

        private void HighlightText(string searchText, Color highlightColor)
        {
            int index = 0;
            main_textbox.SelectionBackColor = Color.Transparent;

            while (index < main_textbox.Text.LastIndexOf(searchText, StringComparison.OrdinalIgnoreCase))
            {
                main_textbox.Find(searchText, index, main_textbox.TextLength, RichTextBoxFinds.None);
                main_textbox.SelectionBackColor = highlightColor;
                index = main_textbox.Text.IndexOf(searchText, index, StringComparison.OrdinalIgnoreCase) + 1;
            }
        }

        private void find_btn_Click(object sender, EventArgs e) => HighlightText(find_txt.Text, Color.MediumSlateBlue);
        private void closeFind_btn_Click(object sender, EventArgs e)
        {
            HighlightText(find_txt.Text, Color.FromArgb(103, 103, 103));
            findMenu.Visible = false;
            searchMenu.Visible = false;
        }

        private void findParent_btn_Click(object sender, EventArgs e)
        {
            //çok sağlıklı bir bul fonksiyonu değil çünkü highlighları temizliyor sonrasında sıkıntı yaratabilir -maqs
            if (findMenu.Visible)
            {
                string temp = main_textbox.Text;
                main_textbox.Text = "";
                main_textbox.Text = temp;

                HighlightText(find_txt.Text, Color.FromArgb(103, 103, 103));
                findMenu.Visible = false;
            }
            else
            {
                findMenu.Visible = true;
                searchMenu.Visible = false;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            fileInfo_window fileInfo = new fileInfo_window();
            switch (search_txtBox.Text)
            {
                case "Dosya Menüsü":
                    file_btn.PerformClick();
                    break;
                case "Araç Çubuğu":
                    toolbar_btn.PerformClick();
                    break;
                case "Ekle":
                    add_btn.PerformClick();
                    break;
                case "Düzenle":
                    edit_btn.PerformClick();
                    break;
                case "Görünüm":
                    appearance_btn.PerformClick();
                    break;
                case "İstatistikler":
                    fileInfo.menuNumber = 1;
                    fileInfo.Show();
                    break;
                case "Ayarlar":
                    fileInfo.menuNumber = 2;
                    fileInfo.Show();
                    break;
                case "Dosya Bilgileri":
                    edit_btn.PerformClick();
                    fileInfo.menuNumber = 0;
                    fileInfo.Show();
                    break;
            }
            searchMenu.Visible = false;
        }

        private void searchParent_btn_Click(object sender, EventArgs e)
        {
            searchMenu.Visible = !searchMenu.Visible;
            if(searchMenu.Visible)
                findMenu.Visible = false;
        }

        private void dateandtime_btn_Click(object sender, EventArgs e) => HandleMsgBox(1);

        private void addImage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog P_OpenFileDialog = new OpenFileDialog();
                P_OpenFileDialog.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png|*.ico|*.ico";
                DialogResult P_DialogResult = P_OpenFileDialog.ShowDialog();
                if (P_DialogResult == DialogResult.OK)
                {
                    Clipboard.SetDataObject(Image.FromFile(P_OpenFileDialog.FileName), false);
                    if (main_textbox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    {
                        main_textbox.Paste();
                        Clipboard.SetDataObject(String.Empty, false);
                    }
                }
            }
            catch { MessageBox.Show("Resim yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void addVideo_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Dosyaları|*.mp4;*.avi;*.mov;*.wmv;*.mkv";
                openFileDialog.Title = "opentypr | Video Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string videoPath = openFileDialog.FileName;

                    if (IsVideoFile(videoPath))
                        EmbedFileWithIcon(main_textbox, videoPath);
                    else
                        MessageBox.Show("Seçilen dosya bir video dosyası değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //bu fonksiyon video dosyasını ikon şeklinde gözükmesini sağlayacaktır
        private void EmbedFileWithIcon(RichTextBox richTextBox, string filePath)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetFileDropList(new System.Collections.Specialized.StringCollection { filePath });

                if (Clipboard.ContainsFileDropList())
                    richTextBox.Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosyayı gömmekte sorun yaşandı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsVideoFile(string filePath)
        {
            string[] validExtensions = { ".mp4", ".avi", ".mov", ".wmv", ".mkv" };
            string extension = Path.GetExtension(filePath).ToLower();
            return Array.Exists(validExtensions, ext => ext == extension);
        }

        public static string InsertTableInRichTextBox(int rows, int cols, int cellWidth)
        {
            StringBuilder rtf = new StringBuilder();
            rtf.Append(@"{\rtf1 ");

            for (int i = 0; i < rows; i++)
            {
                rtf.Append(@"\trowd");

                for (int j = 0; j < cols; j++)
                {
                    int cellRight = (j + 1) * cellWidth;
                    rtf.Append($@"\cellx{cellRight}");
                }

                //Hücre boş olsun ya da olmasın her hücre \intbl ve \cell içinde bulundurur
                for (int j = 0; j < cols; j++)
                {
                    rtf.Append(@"\intbl \cell ");
                }

                rtf.Append(@"\row ");
            }

            rtf.Append(@"\pard}");
            return rtf.ToString();
        }

        private void addReferenceNoParent_btn_Click(object sender, EventArgs e) => addReferenceNoMenu.Visible = !addReferenceNoMenu.Visible;

        private void addReferenceNo_btn_Click(object sender, EventArgs e)
        {
            AppendFormattedText(main_textbox, "[", Color.White, false, main_textbox.SelectionFont.Height / 2);
            AppendFormattedText(main_textbox, referenceNo_txt.Text, Color.CornflowerBlue, false, main_textbox.SelectionFont.Height / 2);
            AppendFormattedText(main_textbox, "]", Color.White, false, main_textbox.SelectionFont.Height / 2);
            addReferenceNoMenu.Visible = false;
        }

        public void AppendFormattedText(RichTextBox rtb, string text, Color textColour, Boolean isItalic, int charOffset)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text);
            int end = rtb.TextLength;
            rtb.Select(start, end - start);

            rtb.SelectionColor = textColour;
            rtb.SelectionCharOffset = charOffset;
            rtb.SelectionFont = new Font(
                 rtb.SelectionFont.FontFamily,
                 rtb.SelectionFont.Size,
                 (isItalic ? FontStyle.Italic : FontStyle.Regular));

            rtb.SelectionLength = 0;
            rtb.SelectionColor = Color.White;
            refresh_btn.PerformClick();
        }

        //
        //Wild versiyonunun normalden farkı formatının ne olursa olsun Arial 12 Regular şeklinde yazdırmasıdır.
        //
        public void AppendFormattedTextWild(RichTextBox rtb, string text, Color textColour)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text);
            int end = rtb.TextLength;
            rtb.Select(start, end - start);

            rtb.SelectionColor = textColour;
            rtb.SelectionFont = new Font(
                 "Arial",
                 12,
                 FontStyle.Regular);

            rtb.SelectionLength = 0;
            rtb.SelectionColor = Color.White;
            refresh_btn.PerformClick();
        }

        private void HandleMsgBox(int msgBoxNumber)
        {
            messagebox msgbox = new messagebox();
            msgbox.msgBoxNumber = msgBoxNumber;
            msgbox.Show();
            refresh_btn.PerformClick();
        }

        private void fileinfo_btn_Click(object sender, EventArgs e)
        {
            fileInfo_window fileInfo = new fileInfo_window();
            fileInfo.menuNumber = 1;
            fileInfo.Show();
            refresh_btn.PerformClick();
        }

        private void addLink_btn_Click(object sender, EventArgs e) => HandleMsgBox(1);
        private void filename_btn_Click(object sender, EventArgs e) => HandleMsgBox(2);
        private void addTable_btn_Click(object sender, EventArgs e) => HandleMsgBox(3);
        private void addReference_btn_Click(object sender, EventArgs e) => HandleMsgBox(4);
        private void addNote_btn_Click(object sender, EventArgs e) => HandleMsgBox(5);
        private void addSymbol_btn_Click(object sender, EventArgs e) => HandleMsgBox(6);
        private void addEquation_btn_Click(object sender, EventArgs e) => HandleMsgBox(7);

        private void textColorMenuIndicator_BackColorChanged(object sender, EventArgs e)
        {
            text_color = textColorMenuIndicator.BackColor;
            textColorIndicator.BackColor = text_color;
        }

        private void SetTextColor(Color color)
        {
            textColorMenuIndicator.BackColor = color;
            GetRGB_TextColor(color);
            textColorSelectMenu.Visible = false;
            main_textbox.SelectionColor = color;
        }

        private void textColorRed_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Red);
        private void textColorOrange_btn_Click(object sender, EventArgs e) => SetTextColor(Color.DarkOrange);
        private void textColorLightGreen_btn_Click(object sender, EventArgs e) => SetTextColor(Color.LightGreen);
        private void textColorYellow_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Gold);
        private void textColorBlue_btn_Click(object sender, EventArgs e) => SetTextColor(Color.RoyalBlue);
        private void textColorSeaGreen_btn_Click(object sender, EventArgs e) => SetTextColor(Color.SeaGreen);
        private void textColorTurqoise_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Turquoise);
        private void textColorLime_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Lime);
        private void textColorPink_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Magenta);
        private void textColorPurple_btn_Click(object sender, EventArgs e) => SetTextColor(Color.DarkViolet);
        private void textColorDarkBlue_btn_Click(object sender, EventArgs e) => SetTextColor(Color.MediumBlue);
        private void textColorWhite_btn_Click(object sender, EventArgs e) => SetTextColor(Color.White);

        private void highlightWhite_btn_Click(object sender, EventArgs e) => SetTextColor(Color.White);
        private void highlightPink_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Magenta);
        private void highlightPurple_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Violet);
        private void highlightDarkBlue_btn_Click(object sender, EventArgs e) => SetTextColor(Color.MediumBlue);
        private void highlightBlue_btn_Click(object sender, EventArgs e) => SetTextColor(Color.RoyalBlue);
        private void highlightTurquoise_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Turquoise);
        private void highlightLime_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Lime);
        private void highlightSeaGreen_btn_Click(object sender, EventArgs e) => SetTextColor(Color.SeaGreen);
        private void highlightLightGreen_btn_Click(object sender, EventArgs e) => SetTextColor(Color.LightGreen);
        private void highlightYellow_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Gold);
        private void highlightOrange_btn_Click(object sender, EventArgs e) => SetTextColor(Color.DarkOrange);
        private void highlightRed_btn_Click(object sender, EventArgs e) => SetTextColor(Color.Red);

        public void GetRGB_TextColor(Color clr)
        {
            textColorRedValue_lbl.Text = clr.R.ToString();
            textColorGreenValue_lbl.Text = clr.G.ToString();
            textColorBlueValue_lbl.Text = clr.B.ToString();
        }

        private void textcolor_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (textColorSelectMenu.Visible)
                textColorSelectMenu.Visible = false;
            main_textbox.SelectionColor = textColorIndicator.BackColor;
        }

        private void textcolor_btn_MouseEnter(object sender, EventArgs e)
        {
            if (!textColorSelectMenu.Visible)
            {
                textColorSelectMenu.Visible = true;
                highlightColorSelectMenu.Visible = false;
            }
        }

        private void SetCustomColor(ColorDialog dialog, Action<Color> applyColor)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
                applyColor(dialog.Color);
        }

        private void textColorSelectColor_btn_Click(object sender, EventArgs e)
        {
            SetCustomColor(colorDialog, color =>
            {
                text_color = color;
                textColorIndicator.BackColor = color;
                textColorMenuIndicator.BackColor = color;
                GetRGB_TextColor(color);
                main_textbox.SelectionColor = color;
            });
        }

        private void highlightSelectColor_btn_Click(object sender, EventArgs e)
        {
            SetCustomColor(colorDialog, color =>
            {
                highlight_color = color;
                highlightColorIndicator.BackColor = color;
                highlightColorMenuIndicator.BackColor = color;
                GetRGB_Highlight(color);
                main_textbox.SelectionBackColor = color;
            });
        }

        private void highlight_btn_MouseDown(object sender, MouseEventArgs e)
        {
            highlightColorSelectMenu.Visible = !highlightColorSelectMenu.Visible;
            main_textbox.SelectionBackColor = highlightColorIndicator.BackColor;
        }

        private void highlight_btn_MouseEnter(object sender, EventArgs e)
        {
            if (!highlightColorSelectMenu.Visible)
            {
                highlightColorSelectMenu.Visible = true;
                textColorSelectMenu.Visible = false;
            }
        }

        public void GetRGB_Highlight(Color clr)
        {
            highlightRedValue_lbl.Text = clr.R.ToString();
            highlightGreenValue_lbl.Text = clr.G.ToString();
            highlightBlueValue_lbl.Text = clr.B.ToString();
        }

        private void highlightColorMenuIndicator_BackColorChanged(object sender, EventArgs e)
        {
            highlight_color = highlightColorMenuIndicator.BackColor;
            highlightColorIndicator.BackColor = highlight_color;
        }

        private void closeHighlight_btn_Click(object sender, EventArgs e)
        {
            main_textbox.SelectionBackColor = main_textbox.BackColor;
            highlightColorMenuIndicator.BackColor = main_textbox.BackColor;
            highlight_color = main_textbox.BackColor;
            GetRGB_Highlight(main_textbox.BackColor);
            highlightColorSelectMenu.Visible = false;
        }

        private void defaultTextTemplate_btn_Click(object sender, EventArgs e) => main_textbox.SelectionFont = new Font("Wanted Sans Bold", 12);
        private void bodyText_btn_Click(object sender, EventArgs e) => main_textbox.SelectionFont = new Font("Wanted Sans Bold", 10);
        private void title1_btn_Click(object sender, EventArgs e) => main_textbox.SelectionFont = new Font("Wanted Sans Bold", 18);
        private void title2_btn_Click(object sender, EventArgs e) => main_textbox.SelectionFont = new Font("Wanted Sans Bold", 16);
        private void subtitle_btn_Click(object sender, EventArgs e) => main_textbox.SelectionFont = new Font("Wanted Sans Bold", 14);

        private void template_btn_Click(object sender, EventArgs e)
        {
            templates template_window = new templates();
            template_window.Show();
            newMenu.Visible = false;
            fileMenu.Visible = false;
        }

        private void RegisterClickEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.MouseDown += Control_MouseDown;

                if (control.HasChildren)
                {
                    RegisterClickEvents(control);
                }
            }
            parent.MouseDown += Control_MouseDown;
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (!textColorSelectMenu.Bounds.Contains(this.PointToClient(Cursor.Position)))
                textColorSelectMenu.Visible = false;
            if (!highlightColorSelectMenu.Bounds.Contains(this.PointToClient(Cursor.Position)))
                highlightColorSelectMenu.Visible = false;
            if (!pageColorMenu.Bounds.Contains(this.PointToClient(Cursor.Position)))
                pageColorMenu.Visible = false;
        }

        private void draganddropEnabled_btn_Click(object sender, EventArgs e)
        {
            if(main_textbox.EnableAutoDragDrop)
            {
                main_textbox.EnableAutoDragDrop = false;
                draganddropEnabled_btn.BorderColor = Color.FromArgb(103, 103, 103);
            }
            else
            {
                main_textbox.EnableAutoDragDrop = true;
                draganddropEnabled_btn.BorderColor = Color.FromArgb(132, 152, 255);
            }
        }

        private void detectLinks_btn_Click(object sender, EventArgs e)
        {
            if(main_textbox.DetectUrls)
            {
                main_textbox.DetectUrls = false;
                detectLinks_btn.BorderColor = Color.FromArgb(103, 103, 103);
            }
            else
            {
                main_textbox.DetectUrls = true;
                detectLinks_btn.BorderColor = Color.FromArgb(132, 152, 255);
            }
            refresh_btn.PerformClick();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            main_textbox.SetInnerMargins(indent_left, indent_top, indent_right, 0);
            page_length = main_textbox.Height;
            fontRefresh();
        }

        private void pageColor_btn_MouseEnter(object sender, EventArgs e) => pageColorMenu.Visible = !pageColorMenu.Visible;

        private void pageColor_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (pageColorMenu.Visible)
                pageColorMenu.Visible = false;
            main_textbox.BackColor = pageColor_btn.BorderColor;
        }

        private void SetPaperColor(Color color)
        {
            pageColorMenuIndicator.BackColor = color;
            GetRGB_PageColor(color);
            pageColorMenu.Visible = false;
            main_textbox.BackColor = color;
        }

        public void GetRGB_PageColor(Color clr)
        {
            pageColorRedValue_lbl.Text = clr.R.ToString();
            pageColorGreenValue_lbl.Text = clr.G.ToString();
            pageColorBlueValue_lbl.Text = clr.B.ToString();
        }

        private void pageColorWhite_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.White);
        private void pageColorPink_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.Magenta);
        private void pageColorPurple_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.DarkViolet);
        private void pageColorDarkBlue_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.MediumBlue);
        private void pageColorBlue_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.RoyalBlue);
        private void pageColorTurqoise_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.Turquoise);
        private void pageColorLime_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.Lime);
        private void pageColorSeaGreen_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.SeaGreen);
        private void pageColorLightGreen_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.LightGreen);
        private void pageColorYellow_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.Gold);
        private void pageColorOrange_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.DarkOrange);
        private void pageColorRed_btn_Click(object sender, EventArgs e) => SetPaperColor(Color.Red);

        private void pageColorMenuIndicator_BackColorChanged(object sender, EventArgs e)
        {
            page_color = pageColorMenuIndicator.BackColor;
            pageColor_btn.BorderColor = page_color;
        }

        private void pageColorSelectColor_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color clr = colorDialog.Color;
                page_color = clr;
                pageColor_btn.BorderColor = clr;
                pageColorMenuIndicator.BackColor = clr;
                GetRGB_PageColor(clr);
                main_textbox.BackColor = clr;
            }
        }

        private void statusbar_btn_Click(object sender, EventArgs e)
        {
            if(statusBar.Visible)
            {
                statusBar.Visible = false;
                statusbar_btn.BorderColor = Color.FromArgb(103, 103, 103);
            }
            else
            {
                statusBar.Visible = true;
                statusbar_btn.BorderColor = Color.FromArgb(132, 152, 255);
            }
        }

        private void zoom_btn_Click(object sender, EventArgs e) => zoomMenu.Visible = !zoomMenu.Visible;

        private void zoomIncrease_btn_Click(object sender, EventArgs e)
        {
            if (zoomTrackBar1.Value <= 350)
                zoomTrackBar1.Value += 50;
        }

        private void zoomDecrease_btn_Click(object sender, EventArgs e)
        {
            if(zoomTrackBar1.Value >= 100)
                zoomTrackBar1.Value -= 50;
        }

        private void SetZoomValue(int value)
        {
            zoom_value = value;
            statusBarZoom_trck.Value = value;
            zoomTrackBar1.Value = value;
            zoom_lbl.Text = "%" + value;
            statusBarZoom_lbl.Text = "%" + value;
            UpdateZoomValue(value);
        }

        private void statusBarZoom_trck_ValueChanged(object sender, EventArgs e) => SetZoomValue(statusBarZoom_trck.Value);
        private void zoomTrackBar1_ValueChanged(object sender, EventArgs e) => SetZoomValue(zoomTrackBar1.Value);

        private void defaultZoom_btn_Click(object sender, EventArgs e)
        {
            zoom_value = 100;
            zoomTrackBar1.Value = zoom_value;
            statusBarZoom_trck.Value = zoom_value;
            zoom_lbl.Text = "%" + zoom_value.ToString();
            statusBarZoom_lbl.Text = "%" + zoom_value.ToString();
            UpdateZoomValue(zoom_value);
        }

        public void UpdateZoomValue(int value)
        {
            float realvalue = 1f;
            realvalue = (float)value / 100f;
            main_textbox.ZoomFactor = realvalue;
        }

        private void kenarboyutu_Click(object sender, EventArgs e) => HandleMsgBox(8);

        private void ruler_ValueChanged(object sender, EventArgs e)
        {
            indent_left = ruler.Value * 4; //biraz daha spesifik hesaplamalar gerekebilir
            main_textbox.SetInnerMargins(indent_left, indent_top, indent_right, 0);
        }

        private void ruler_btn_Click(object sender, EventArgs e)
        {
            if(rulerMenu.Visible)
            {
                rulerMenu.Visible = false;
                ruler_btn.BorderColor = Color.FromArgb(103, 103, 103);
            }
            else
            {
                rulerMenu.Visible = true;
                ruler_btn.BorderColor = Color.FromArgb(132, 152, 255);
            }
        }

        private void closeSearch_btn_Click(object sender, EventArgs e) => searchMenu.Visible = false;

        private void about_btn_Click(object sender, EventArgs e) => MessageBox.Show("Sürüm: opentypr " + versionNo + " | Sürüm Kodu: " + versionCode + " | 2025 eighteenbyte");

        private void settings_btn_Click(object sender, EventArgs e)
        {
            fileInfo_window fileInfoWin = new fileInfo_window();
            fileInfoWin.menuNumber = 2;
            fileInfoWin.Show();
        }

        //font yenile fonksiyonuna daha düzgün bir alternatif bulunması lazım -maqs
        public void fontRefresh()
        {
            SetProcessDPIAware();
            page_length = main_textbox.Height;
            new_btn.Font = buttonFont;
            open_btn.Font = buttonFont;
            saveparent_btn.Font = buttonFont;
            share_btn.Font = buttonFont;
            export_btn.Font = buttonFont;
            print_btn.Font = buttonFont;
            help_btn.Font = buttonFont;
            reportBugs_btn.Font = buttonFont;
            about_btn.Font = buttonFont;
            OSandFormatting_lbl.Font = labelFont;
            numberOfPages_lbl.Font = labelFont;
            numberOfCharacters_lbl.Font = labelFont;
            statusBarZoom_lbl.Font = labelFont;
            file_btn.Font = buttonFont2;
            toolbar_btn.Font = buttonFont2;
            edit_btn.Font = buttonFont2;
            add_btn.Font = buttonFont2;
            appearance_btn.Font = buttonFont2;
            settings_btn.Font = buttonFont2;
            helpParent_btn.Font = buttonFont2;
            fileName_lbl.Font = buttonFont;
            otherEdit_lbl.Font = labelFont2;
            appearancePage_lbl.Font = labelFont2;
            page_lbl.Font = labelFont2;
            reference_lbl.Font = labelFont2;
            media_lbl.Font = labelFont2;
            textAdd_lbl.Font = labelFont2;
            dateandtime_lbl.Font = labelFont2;
            show_lbl.Font = labelFont2;
            zoomcategory_lbl.Font = labelFont2;
            theme_lbl.Font = labelFont2;
            general_lbl.Font = labelFont2;
            font_lbl.Font = labelFont2;
            paragraph_lbl.Font = labelFont2;
            search_lbl.Font = labelFont2;
            textTemplates_lbl.Font = labelFont2;
            lineSpacing_lbl.Font = buttonFont2;
            bullet6_btn.Font = buttonFont2;
            bullet1_btn.Font = buttonFont2;
            bullet3_btn.Font = buttonFont2;
            bullet2_btn.Font = buttonFont2;
            bullet5_btn.Font = buttonFont2;
            bullet4_btn.Font = buttonFont2;
            fileinfo_btn.Font = buttonFont;
            filename_btn.Font = buttonFont;
        }

        //
        //
        /*ÇOK ÖNEMLİ: EVET KOYU MOD VE AÇIK MOD FONKSİYONLARI ÇOOOOOOOOOK UZUN!
        
        Ama nasıl bildiniz? Şuan yapabileceğim pek bir şey yok. Burayı düzeltmemin
        tek yolu tüm kontrol türlerini algılayan bir mekanizma ile renkleri toptan
        belirlemek olacak. Ama sorun şu ki tüm aynı türdeki kontroller aynı renkte değil,
        yani istisnalar var. Muhtemelen kontrol türlerini algılayan ve aynı zamanda
        istisnaları tespit edebilen bir fonksiyon lazım bize ama şuanlık böyle dursun bakalım.
        İllaki aklımıza bir şeyler gelir, öptüm.   -maqs*/
        //
        //

        public void DarkTheme()
        {
            //arac cubugu ikonlar
            paste_btn.Image = Properties.Resources.paste;
            copy_btn.Image = Properties.Resources.copy;
            cut_btn.Image = Properties.Resources.cut;
            select_btn.Image = Properties.Resources.select;
            undo_btn.Image = Properties.Resources.undo;
            redo_btn.Image = Properties.Resources.redo;
            selectall_btn.Image = Properties.Resources.selectall;
            bold_btn.Image = Properties.Resources.bold;
            italic_btn.Image = Properties.Resources.italic;
            underlined_btn.Image = Properties.Resources.underlined;
            strikethrough_btn.Image = Properties.Resources.strikethrough;
            textcolor_btn.Image = Properties.Resources.textcolor;
            highlight_btn.Image = Properties.Resources.highlight;
            superscript_btn.Image = Properties.Resources.superscript;
            subscript_btn.Image = Properties.Resources.subscript;
            characterGap_btn.Image = Properties.Resources.charactergap;
            decreaseFontSize_btn.Image = Properties.Resources.decreasesize;
            increaseFontSize_btn.Image = Properties.Resources.increasesize;
            deleteForming_btn.Image = Properties.Resources.deleteforming;
            bulletList_btn.Image = Properties.Resources.bulletlist;
            alignToLeft_btn.Image = Properties.Resources.aligntoleft;
            alignToMiddle_btn.Image = Properties.Resources.alignmiddle;
            alignToRight_btn.Image = Properties.Resources.aligntoright;
            increaseIndent_btn.Image = Properties.Resources.increaseindent;
            decreaseIndent_btn.Image = Properties.Resources.decreaseindent;
            lock_btn.Image = Properties.Resources._lock;
            unlock_btn.Image = Properties.Resources.unlock;
            lineGap_btn.Image = Properties.Resources.linegap;
            findParent_btn.Image = Properties.Resources.search;
            searchParent_btn.Image = Properties.Resources.search;

            //ekle panel ikonlar
            dateandtime_btn.Image = Properties.Resources.dateandtime;
            addSymbol_btn.Image = Properties.Resources.symbol;
            addEquation_btn.Image = Properties.Resources.equation;
            addReference_btn.Image = Properties.Resources.reference;
            addReferenceNoParent_btn.Image = Properties.Resources.referencenumber;
            addNote_btn.Image = Properties.Resources.note;

            //duzenle panel ikonlar
            pageSize_btn.Image = Properties.Resources.pagesize;
            verticalPage_btn.Image = Properties.Resources.verticalpage;
            horizontalPage_btn.Image = Properties.Resources.horizontalpage;
            pageColor_btn.Image = Properties.Resources.pagecolor;
            indentSize_btn.Image = Properties.Resources.pageindent;
            draganddropEnabled_btn.Image = Properties.Resources.draganddrop;
            detectLinks_btn.Image = Properties.Resources.detectlinks;

            //goruntu panel ikonlar
            ruler_btn.Image = Properties.Resources.ruler;
            statusbar_btn.Image = Properties.Resources.statusbar;
            zoom_btn.Image = Properties.Resources.zoom;
            defaultZoom_btn.Image = Properties.Resources.defaultzoom;
            darkTheme_btn.Image = Properties.Resources.darkmode;

            //dosya panel ikonlar
            new_btn.BackgroundImage = Properties.Resources._new;
            open_btn.BackgroundImage = Properties.Resources.open;
            share_btn.BackgroundImage = Properties.Resources.sharelong;
            saveparent_btn.BackgroundImage = Properties.Resources.savewarrow;
            export_btn.BackgroundImage = Properties.Resources.exportlong;
            print_btn.BackgroundImage = Properties.Resources.printlong;
            fileinfo_btn.BackgroundImage = Properties.Resources.infolong;
            filename_btn.BackgroundImage = Properties.Resources.renamelong;
            template_btn.BackgroundImage = Properties.Resources.templatelong;
            dropfile_btn.BackgroundImage = Properties.Resources.draganddropfile;
            save_btn.BackgroundImage = Properties.Resources.save;
            saveAs_btn.BackgroundImage = Properties.Resources.saveas;
            email_btn.BackgroundImage = Properties.Resources.email;
            toPDF_btn.BackgroundImage = Properties.Resources.toPDF;
            toDOCX_btn.BackgroundImage = Properties.Resources.toDOCX;
            toRTF_btn.BackgroundImage = Properties.Resources.toRTF;

            //ana paneller
            topMenu.BackColor = Color.FromArgb(23, 23, 23);
            toolbarMenu.BackColor = Color.FromArgb(43, 43, 43);
            addMenu.BackColor = Color.FromArgb(43, 43, 43);
            editMenu.BackColor = Color.FromArgb(43, 43, 43);
            appearenceMenu.BackColor = Color.FromArgb(43, 43, 43);

            //ustpanel
            logo_img.Image = Properties.Resources.opentypr;
            minimize_btn.BackgroundImage = Properties.Resources.minimize;
            maximize_btn.BackgroundImage = Properties.Resources.maximize;
            close_btn.BackgroundImage = Properties.Resources.close;
            topMenu.BackColor = Color.FromArgb(23, 23, 23);
            file_btn.BackColor = Color.FromArgb(23, 23, 23);
            toolbar_btn.BackColor = Color.FromArgb(23, 23, 23);
            add_btn.BackColor = Color.FromArgb(23, 23, 23);
            edit_btn.BackColor = Color.FromArgb(23, 23, 23);
            appearance_btn.BackColor = Color.FromArgb(23, 23, 23);
            settings_btn.BackColor = Color.FromArgb(23, 23, 23);
            helpParent_btn.BackColor = Color.FromArgb(23, 23, 23);
            backgroundPanel.BackColor = Color.FromArgb(73, 73, 73);
            txtboxPanel.BackColor = Color.FromArgb(73, 73, 73);
            fileName_lbl.ForeColor = Color.White;
            toolbar_btn.ForeColor = Color.White;
            add_btn.ForeColor = Color.LightGray;
            edit_btn.ForeColor = Color.LightGray;
            appearance_btn.ForeColor = Color.LightGray;
            file_btn.ForeColor = Color.LightGray;
            settings_btn.ForeColor = Color.LightGray;
            helpParent_btn.ForeColor = Color.LightGray;
            windowCtrlMenu.BackColor = Color.FromArgb(43, 43, 43);
            minimize_btn.BackColor = Color.FromArgb(43, 43, 43);
            maximize_btn.BackColor = Color.FromArgb(43, 43, 43);
            close_btn.BackColor = Color.FromArgb(43, 43, 43);

            //yardim panel
            about_btn.BackgroundImage = Properties.Resources.infolong;
            helpMenu.BackColor = Color.FromArgb(23, 23, 23);
            help_btn.BackColor = Color.FromArgb(23, 23, 23);
            reportBugs_btn.BackColor = Color.FromArgb(23, 23, 23);
            about_btn.BackColor = Color.FromArgb(23, 23, 23);
            help_btn.ForeColor = Color.White;
            reportBugs_btn.ForeColor = Color.White;
            about_btn.ForeColor = Color.White;

            //dosya panel
            fileMenu.BackColor = Color.FromArgb(23, 23, 23);
            new_btn.BackColor = Color.FromArgb(23, 23, 23);
            open_btn.BackColor = Color.FromArgb(23, 23, 23);
            saveparent_btn.BackColor = Color.FromArgb(23, 23, 23);
            share_btn.BackColor = Color.FromArgb(23, 23, 23);
            print_btn.BackColor = Color.FromArgb(23, 23, 23);
            export_btn.BackColor = Color.FromArgb(23, 23, 23);
            filename_btn.BackColor = Color.FromArgb(23, 23, 23);
            fileinfo_btn.BackColor = Color.FromArgb(23, 23, 23);
            newMenu.BackColor = Color.FromArgb(23, 23, 23);
            emptyDoc_btn.BackColor = Color.FromArgb(23, 23, 23);
            template_btn.BackColor = Color.FromArgb(23, 23, 23);
            openMenu.BackColor = Color.FromArgb(23, 23, 23);
            dropfile_btn.BackColor = Color.FromArgb(23, 23, 23);
            selectfile_btn.BackColor = Color.FromArgb(23, 23, 23);
            saveMenu.BackColor = Color.FromArgb(23, 23, 23);
            save_btn.BackColor = Color.FromArgb(23, 23, 23);
            saveAs_btn.BackColor = Color.FromArgb(23, 23, 23);
            shareMenu.BackColor = Color.FromArgb(23, 23, 23);
            toTeams_btn.BackColor = Color.FromArgb(23, 23, 23);
            email_btn.BackColor = Color.FromArgb(23, 23, 23);
            exportMenu.BackColor = Color.FromArgb(23, 23, 23);
            toPDF_btn.BackColor = Color.FromArgb(23, 23, 23);
            toRTF_btn.BackColor = Color.FromArgb(23, 23, 23);
            toDOCX_btn.BackColor = Color.FromArgb(23, 23, 23);
            fileMenu.ForeColor = Color.White;
            new_btn.ForeColor = Color.White;
            open_btn.ForeColor = Color.White;
            saveparent_btn.ForeColor = Color.White;
            share_btn.ForeColor = Color.White;
            print_btn.ForeColor = Color.White;
            export_btn.ForeColor = Color.White;
            filename_btn.ForeColor = Color.White;
            fileinfo_btn.ForeColor = Color.White;
            emptyDoc_btn.ForeColor = Color.White;
            template_btn.ForeColor = Color.White;
            dropfile_btn.ForeColor = Color.White;
            selectfile_btn.ForeColor = Color.White;
            save_btn.ForeColor = Color.White;
            saveAs_btn.ForeColor = Color.White;
            toTeams_btn.ForeColor = Color.White;
            email_btn.ForeColor = Color.White;
            toPDF_btn.ForeColor = Color.White;
            toRTF_btn.ForeColor = Color.White;
            toDOCX_btn.ForeColor = Color.White;

            //cetvel + durum cubugu + yazi kutusu
            rulerMenu.BackColor = Color.FromArgb(43, 43, 43);
            ruler.BackColor = Color.FromArgb(43, 43, 43);
            statusBar.BackColor = Color.FromArgb(43, 43, 43);
            OSandFormatting_lbl.ForeColor = Color.LightGray;
            numberOfPages_lbl.ForeColor = Color.LightGray;
            numberOfCharacters_lbl.ForeColor = Color.LightGray;
            statusBarZoom_lbl.ForeColor = Color.LightGray;
            statusBarZoom_trck.BackColor = Color.FromArgb(43, 43, 43);
            main_textbox.BackColor = Color.FromArgb(103, 103, 103);
            main_textbox.ForeColor = Color.White;

            //arac cubugu panel
            paste_btn.BackColor = Color.FromArgb(43, 43, 43);
            copy_btn.BackColor = Color.FromArgb(43, 43, 43);
            cut_btn.BackColor = Color.FromArgb(43, 43, 43);
            select_btn.BackColor = Color.FromArgb(43, 43, 43);
            undo_btn.BackColor = Color.FromArgb(43, 43, 43);
            redo_btn.BackColor = Color.FromArgb(43, 43, 43);
            selectall_btn.BackColor = Color.FromArgb(23, 23, 23);
            bold_btn.BackColor = Color.FromArgb(43, 43, 43);
            italic_btn.BackColor = Color.FromArgb(43, 43, 43);
            underlined_btn.BackColor = Color.FromArgb(43, 43, 43);
            strikethrough_btn.BackColor = Color.FromArgb(43, 43, 43);
            textcolor_btn.BackColor = Color.FromArgb(43, 43, 43);
            highlight_btn.BackColor = Color.FromArgb(43, 43, 43);
            superscript_btn.BackColor = Color.FromArgb(43, 43, 43);
            subscript_btn.BackColor = Color.FromArgb(43, 43, 43);
            characterGap_btn.BackColor = Color.FromArgb(43, 43, 43);
            decreaseFontSize_btn.BackColor = Color.FromArgb(43, 43, 43);
            increaseFontSize_btn.BackColor = Color.FromArgb(43, 43, 43);
            deleteForming_btn.BackColor = Color.FromArgb(43, 43, 43);
            fontSelector_cmb.BackColor = Color.FromArgb(43, 43, 43);
            fontSizeSelector_cmb.BackColor = Color.FromArgb(43, 43, 43);
            bulletList_btn.BackColor = Color.FromArgb(43, 43, 43);
            alignToLeft_btn.BackColor = Color.FromArgb(43, 43, 43);
            alignToMiddle_btn.BackColor = Color.FromArgb(43, 43, 43);
            alignToRight_btn.BackColor = Color.FromArgb(43, 43, 43);
            increaseIndent_btn.BackColor = Color.FromArgb(43, 43, 43);
            decreaseIndent_btn.BackColor = Color.FromArgb(43, 43, 43);
            lock_btn.BackColor = Color.FromArgb(43, 43, 43);
            unlock_btn.BackColor = Color.FromArgb(43, 43, 43);
            lineGap_btn.BackColor = Color.FromArgb(43, 43, 43);
            lineSpacing_menu.BackColor = Color.FromArgb(43, 43, 43);
            lineSpacing_cmb.BackColor = Color.FromArgb(43, 43, 43);
            findParent_btn.BackColor = Color.FromArgb(43, 43, 43);
            searchParent_btn.BackColor = Color.FromArgb(43, 43, 43);
            textTemplatesMenu.BackColor = Color.FromArgb(73, 73, 73);
            defaultTextTemplate_btn.BackColor = Color.FromArgb(43, 43, 43);
            bodyText_btn.BackColor = Color.FromArgb(43, 43, 43);
            title1_btn.BackColor = Color.FromArgb(43, 43, 43);
            title2_btn.BackColor = Color.FromArgb(43, 43, 43);
            subtitle_btn.BackColor = Color.FromArgb(43, 43, 43);
            paste_btn.ForeColor = Color.LightGray;
            copy_btn.ForeColor = Color.LightGray;
            cut_btn.ForeColor = Color.LightGray;
            select_btn.ForeColor = Color.LightGray;
            selectall_btn.ForeColor = Color.LightGray;
            bulletList_btn.ForeColor = Color.LightGray;
            findParent_btn.ForeColor = Color.LightGray;
            searchParent_btn.ForeColor = Color.LightGray;
            defaultTextTemplate_btn.ForeColor = Color.LightGray;
            bodyText_btn.ForeColor = Color.LightGray;
            title1_btn.ForeColor = Color.LightGray;
            title2_btn.ForeColor = Color.LightGray;
            subtitle_btn.ForeColor = Color.LightGray;
            fontSelector_cmb.ForeColor = Color.LightGray;
            fontSizeSelector_cmb.ForeColor = Color.LightGray;
            general_lbl.ForeColor = Color.White;
            font_lbl.ForeColor = Color.White;
            paragraph_lbl.ForeColor = Color.White;
            search_lbl.ForeColor = Color.White;
            textTemplates_lbl.ForeColor = Color.White;
            lineSpacing_lbl.ForeColor = Color.White;
            lineSpacing_cmb.ForeColor = Color.White;
            bulletListMenu.BackColor = Color.FromArgb(33, 33, 33);
            bullet6_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet1_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet3_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet2_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet5_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet4_btn.BackColor = Color.FromArgb(43, 43, 43);
            bullet6_btn.ForeColor = Color.White;
            bullet1_btn.ForeColor = Color.White;
            bullet3_btn.ForeColor = Color.White;
            bullet2_btn.ForeColor = Color.White;
            bullet5_btn.ForeColor = Color.White;
            bullet4_btn.ForeColor = Color.White;
            highlightColorSelectMenu.BackColor = Color.FromArgb(33, 33, 33);
            highlightBlue_lbl.ForeColor = Color.White;
            highlightGreen_lbl.ForeColor = Color.White;
            highlightRed_lbl.ForeColor = Color.White;
            highlightGreenValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            highlightRedValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            highlightBlueValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            highlightGreenValue_lbl.ForeColor = Color.White;
            highlightRedValue_lbl.ForeColor = Color.White;
            highlightBlueValue_lbl.ForeColor = Color.White;
            closeHighlight_btn.BackColor = Color.FromArgb(23, 23, 23);
            highlightSelectColor_btn.BackColor = Color.FromArgb(23, 23, 23);
            closeHighlight_btn.ForeColor = Color.LightGray;
            highlightSelectColor_btn.ForeColor = Color.LightGray;
            textColorSelectMenu.BackColor = Color.FromArgb(33, 33, 33);
            textColorRed_lbl.ForeColor = Color.White;
            textColorGreen_lbl.ForeColor = Color.White;
            textColorBlue_lbl.ForeColor = Color.White;
            textColorGreenValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            textColorRedValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            textColorBlueValue_lbl.BackColor = Color.FromArgb(33, 33, 33);
            textColorGreenValue_lbl.ForeColor = Color.White;
            textColorRedValue_lbl.ForeColor = Color.White;
            textColorBlueValue_lbl.ForeColor = Color.White;
            textColorSelectColor_btn.BackColor = Color.FromArgb(23, 23, 23);
            textColorSelectColor_btn.ForeColor = Color.LightGray;

            //ekle panel
            addMenu.BackColor = Color.FromArgb(43, 43, 43);
            dateandtime_btn.BackColor = Color.FromArgb(43, 43, 43);
            addLink_btn.BackColor = Color.FromArgb(43, 43, 43);
            addEmoji_btn.BackColor = Color.FromArgb(43, 43, 43);
            addSymbol_btn.BackColor = Color.FromArgb(43, 43, 43);
            addEquation_btn.BackColor = Color.FromArgb(43, 43, 43);
            addImage_btn.BackColor = Color.FromArgb(43, 43, 43);
            addVideo_btn.BackColor = Color.FromArgb(43, 43, 43);
            addTable_btn.BackColor = Color.FromArgb(43, 43, 43);
            addReference_btn.BackColor = Color.FromArgb(43, 43, 43);
            addReferenceNoParent_btn.BackColor = Color.FromArgb(43, 43, 43);
            addNote_btn.BackColor = Color.FromArgb(43, 43, 43);
            addReferenceNoMenu.BackColor = Color.FromArgb(33, 33, 33);
            referenceNo_txt.BackColor = Color.FromArgb(33, 33, 33);
            addReferenceNo_btn.BackColor = Color.FromArgb(23, 23, 23);
            addReferenceNo_btn.ForeColor = Color.LightGray;
            dateandtime_btn.ForeColor = Color.LightGray;
            addLink_btn.ForeColor = Color.LightGray;
            addEmoji_btn.ForeColor = Color.LightGray;
            addSymbol_btn.ForeColor = Color.LightGray;
            addEquation_btn.ForeColor = Color.LightGray;
            addImage_btn.ForeColor = Color.LightGray;
            addVideo_btn.ForeColor = Color.LightGray;
            addTable_btn.ForeColor = Color.LightGray;
            addReference_btn.ForeColor = Color.LightGray;
            addReferenceNoParent_btn.ForeColor = Color.LightGray;
            addNote_btn.ForeColor = Color.LightGray;
            referenceNo_txt.ForeColor = Color.White;
            number_lbl.ForeColor = Color.White;
            dateandtime_lbl.ForeColor = Color.White;
            textAdd_lbl.ForeColor = Color.White;
            media_lbl.ForeColor = Color.White;
            reference_lbl.ForeColor = Color.White;

            //duzenle panel
            editMenu.BackColor = Color.FromArgb(43, 43, 43);
            pageSize_btn.BackColor = Color.FromArgb(43, 43, 43);
            verticalPage_btn.BackColor = Color.FromArgb(43, 43, 43);
            horizontalPage_btn.BackColor = Color.FromArgb(43, 43, 43);
            pageColor_btn.BackColor = Color.FromArgb(43, 43, 43);
            indentSize_btn.BackColor = Color.FromArgb(43, 43, 43);
            refresh_btn.BackColor = Color.FromArgb(43, 43, 43);
            draganddropEnabled_btn.BackColor = Color.FromArgb(43, 43, 43);
            detectLinks_btn.BackColor = Color.FromArgb(43, 43, 43);
            pageSize_btn.ForeColor = Color.LightGray;
            verticalPage_btn.ForeColor = Color.LightGray;
            horizontalPage_btn.ForeColor = Color.LightGray;
            pageColor_btn.ForeColor = Color.LightGray;
            indentSize_btn.ForeColor = Color.LightGray;
            refresh_btn.ForeColor = Color.LightGray;
            draganddropEnabled_btn.ForeColor = Color.LightGray;
            detectLinks_btn.ForeColor = Color.LightGray;
            page_lbl.ForeColor = Color.White;
            appearancePage_lbl.ForeColor = Color.White;
            otherEdit_lbl.ForeColor = Color.White;

            //gorunum panel
            appearenceMenu.BackColor = Color.FromArgb(43, 43, 43);
            ruler_btn.BackColor = Color.FromArgb(43, 43, 43);
            statusbar_btn.BackColor = Color.FromArgb(43, 43, 43);
            zoom_btn.BackColor = Color.FromArgb(43, 43, 43);
            defaultZoom_btn.BackColor = Color.FromArgb(43, 43, 43);
            darkTheme_btn.BackColor = Color.FromArgb(43, 43, 43);
            lightTheme_btn.BackColor = Color.FromArgb(43, 43, 43);
            ruler_btn.ForeColor = Color.LightGray;
            statusbar_btn.ForeColor = Color.LightGray;
            zoom_btn.ForeColor = Color.LightGray;
            defaultZoom_btn.ForeColor = Color.LightGray;
            darkTheme_btn.ForeColor = Color.LightGray;
            lightTheme_btn.ForeColor = Color.LightGray;
            show_lbl.ForeColor = Color.White;
            zoomcategory_lbl.ForeColor = Color.White;
            theme_lbl.ForeColor = Color.White;
            zoom_lbl.ForeColor = Color.White;

            //bul ve ara panel
            find_btn.Image = Properties.Resources.find;
            closeFind_btn.BackgroundImage = Properties.Resources.close;
            findMenu.BackColor = Color.FromArgb(33, 33, 33);
            find_txt.BackColor = Color.FromArgb(33, 33, 33);
            find_btn.BackColor = Color.FromArgb(43, 43, 43);
            closeFind_btn.BackColor = Color.FromArgb(43, 43, 43);
            find_txt.ForeColor = Color.White;
            find_btn.ForeColor = Color.White;
            closeFind_btn.ForeColor = Color.White;
            search_btn.Image = Properties.Resources.search;
            closeSearch_btn.BackgroundImage = Properties.Resources.close;
            searchMenu.BackColor = Color.FromArgb(33, 33, 33);
            search_txtBox.BackColor = Color.FromArgb(33, 33, 33);
            search_btn.BackColor = Color.FromArgb(43, 43, 43);
            closeSearch_btn.BackColor = Color.FromArgb(43, 43, 43);
            search_txtBox.ForeColor = Color.White;
            search_btn.ForeColor = Color.White;
            closeSearch_btn.ForeColor = Color.White;

            //cizgiler
            fileLine1.Image = Properties.Resources.gray_dark;
            fileLine2.Image = Properties.Resources.gray_dark;
            toolsLine1.Image = Properties.Resources.gray_dark;
            toolsLine2.Image = Properties.Resources.gray_dark;
            toolsLine3.Image = Properties.Resources.gray_dark;
            toolsLine4.Image = Properties.Resources.gray_dark;
            toolsLine5.Image = Properties.Resources.gray_dark;
            addLine1.Image = Properties.Resources.gray_dark;
            addLine2.Image = Properties.Resources.gray_dark;
            addLine3.Image = Properties.Resources.gray_dark;
            addLine4.Image = Properties.Resources.gray_dark;
            editLine1.Image = Properties.Resources.gray_dark;
            editLine2.Image = Properties.Resources.gray_dark;
            editLine3.Image = Properties.Resources.gray_dark;
            apprLine1.Image = Properties.Resources.gray_dark;
            apprLine2.Image = Properties.Resources.gray_dark;
            apprLine3.Image = Properties.Resources.gray_dark;
            img_buffer.Image = Properties.Resources.gray_dark;

            lightTheme_btn.BorderSize = 0;
            darkTheme_btn.BorderSize = 1;
            Properties.Settings.Default.darktheme = true;
        }

        public void LightTheme()
        {
            //arac cubugu ikonlar
            paste_btn.Image = Properties.Resources.paste_dark;
            copy_btn.Image = Properties.Resources.copy_dark;
            cut_btn.Image = Properties.Resources.cut_dark;
            select_btn.Image = Properties.Resources.select_dark;
            undo_btn.Image = Properties.Resources.undo_dark;
            redo_btn.Image = Properties.Resources.redo_dark;
            selectall_btn.Image = Properties.Resources.selectall_dark;
            bold_btn.Image = Properties.Resources.bold_dark;
            italic_btn.Image = Properties.Resources.italic_dark;
            underlined_btn.Image = Properties.Resources.underlined_dark;
            strikethrough_btn.Image = Properties.Resources.strikethrough_dark;
            textcolor_btn.Image = Properties.Resources.textcolor_dark;
            highlight_btn.Image = Properties.Resources.highlight_dark;
            superscript_btn.Image = Properties.Resources.superscript_dark;
            subscript_btn.Image = Properties.Resources.subscript_dark;
            characterGap_btn.Image = Properties.Resources.charactergap_dark;
            decreaseFontSize_btn.Image = Properties.Resources.decreasesize_dark;
            increaseFontSize_btn.Image = Properties.Resources.increasesize_dark;
            deleteForming_btn.Image = Properties.Resources.deleteforming_dark;
            bulletList_btn.Image = Properties.Resources.bulletlist_dark;
            alignToLeft_btn.Image = Properties.Resources.aligntoleft_dark;
            alignToMiddle_btn.Image = Properties.Resources.alignmiddle_dark;
            alignToRight_btn.Image = Properties.Resources.aligntoright_dark;
            increaseIndent_btn.Image = Properties.Resources.increaseindent_dark;
            decreaseIndent_btn.Image = Properties.Resources.decreaseindent_dark;
            lock_btn.Image = Properties.Resources.lock_dark;
            unlock_btn.Image = Properties.Resources.unlock_dark;
            lineGap_btn.Image = Properties.Resources.linegap_dark;
            findParent_btn.Image = Properties.Resources.search_dark;
            searchParent_btn.Image = Properties.Resources.search_dark;

            //ekle panel ikonlar
            dateandtime_btn.Image = Properties.Resources.dateandtime_dark;
            addSymbol_btn.Image = Properties.Resources.symbol_dark;
            addEquation_btn.Image = Properties.Resources.equation_dark;
            addReference_btn.Image = Properties.Resources.reference_dark;
            addReferenceNoParent_btn.Image = Properties.Resources.referencenumber_dark;
            addNote_btn.Image = Properties.Resources.note_dark;

            //duzenle panel ikonlar
            pageSize_btn.Image = Properties.Resources.pagesize_dark;
            verticalPage_btn.Image = Properties.Resources.verticalpage_dark;
            horizontalPage_btn.Image = Properties.Resources.horizontalpage_dark;
            pageColor_btn.Image = Properties.Resources.pagecolor_dark;
            indentSize_btn.Image = Properties.Resources.pageindent_dark;
            draganddropEnabled_btn.Image = Properties.Resources.draganddrop_dark;
            detectLinks_btn.Image = Properties.Resources.detectlinks_dark;

            //goruntu panel ikonlar
            ruler_btn.Image = Properties.Resources.ruler_dark;
            statusbar_btn.Image = Properties.Resources.statusbar_dark;
            zoom_btn.Image = Properties.Resources.zoom_dark;
            defaultZoom_btn.Image = Properties.Resources.defaultzoom_dark;
            darkTheme_btn.Image = Properties.Resources.darkmode_dark;

            //dosya panel ikonlar
            new_btn.BackgroundImage = Properties.Resources.new_dark;
            open_btn.BackgroundImage = Properties.Resources.open_dark;
            share_btn.BackgroundImage = Properties.Resources.sharelong_dark;
            saveparent_btn.BackgroundImage = Properties.Resources.savewarrow_dark;
            export_btn.BackgroundImage = Properties.Resources.exportlong_dark;
            print_btn.BackgroundImage = Properties.Resources.printlong_dark;
            fileinfo_btn.BackgroundImage = Properties.Resources.infolong_dark;
            filename_btn.BackgroundImage = Properties.Resources.renamelong_dark;
            template_btn.BackgroundImage = Properties.Resources.templatelong_dark;
            dropfile_btn.BackgroundImage = Properties.Resources.draganddropfile_dark;
            save_btn.BackgroundImage = Properties.Resources.save_dark;
            saveAs_btn.BackgroundImage = Properties.Resources.saveas_dark;
            email_btn.BackgroundImage = Properties.Resources.email_dark;
            toPDF_btn.BackgroundImage = Properties.Resources.toPDF_dark;
            toDOCX_btn.BackgroundImage = Properties.Resources.toDOCX_dark;
            toRTF_btn.BackgroundImage = Properties.Resources.toRTF_dark;

            topMenu.BackColor = Color.FromArgb(200, 200, 200);
            toolbarMenu.BackColor = Color.FromArgb(220, 220, 220);
            addMenu.BackColor = Color.FromArgb(43, 43, 43);
            editMenu.BackColor = Color.FromArgb(43, 43, 43);
            appearenceMenu.BackColor = Color.FromArgb(43, 43, 43);

            //ustpanel
            logo_img.Image = Properties.Resources.opentyprdark;
            minimize_btn.BackgroundImage = Properties.Resources.minimize_dark;
            maximize_btn.BackgroundImage = Properties.Resources.maximize_dark;
            close_btn.BackgroundImage = Properties.Resources.close_dark;
            topMenu.BackColor = Color.FromArgb(200, 200, 200);
            file_btn.BackColor = Color.FromArgb(200, 200, 200);
            toolbar_btn.BackColor = Color.FromArgb(200, 200, 200);
            add_btn.BackColor = Color.FromArgb(200, 200, 200);
            edit_btn.BackColor = Color.FromArgb(200, 200, 200);
            appearance_btn.BackColor = Color.FromArgb(200, 200, 200);
            settings_btn.BackColor = Color.FromArgb(200, 200, 200);
            helpParent_btn.BackColor = Color.FromArgb(200, 200, 200);
            backgroundPanel.BackColor = Color.FromArgb(240, 240, 240);
            txtboxPanel.BackColor = Color.FromArgb(240, 240, 240);
            fileName_lbl.ForeColor = Color.Black;
            toolbar_btn.ForeColor = Color.Black;
            add_btn.ForeColor = Color.FromArgb(30, 30, 30);
            edit_btn.ForeColor = Color.FromArgb(30, 30, 30);
            appearance_btn.ForeColor = Color.FromArgb(30, 30, 30);
            file_btn.ForeColor = Color.FromArgb(30, 30, 30);
            settings_btn.ForeColor = Color.FromArgb(30, 30, 30);
            helpParent_btn.ForeColor = Color.FromArgb(30, 30, 30);
            windowCtrlMenu.BackColor = Color.FromArgb(220, 220, 220);
            minimize_btn.BackColor = Color.FromArgb(220, 220, 220);
            maximize_btn.BackColor = Color.FromArgb(220, 220, 220);
            close_btn.BackColor = Color.FromArgb(220, 220, 220);

            //yardim panel
            about_btn.BackgroundImage = Properties.Resources.infolong_dark;
            helpMenu.BackColor = Color.FromArgb(200, 200, 200);
            help_btn.BackColor = Color.FromArgb(200, 200, 200);
            reportBugs_btn.BackColor = Color.FromArgb(200, 200, 200);
            about_btn.BackColor = Color.FromArgb(200, 200, 200);
            help_btn.ForeColor = Color.FromArgb(30, 30, 30);
            reportBugs_btn.ForeColor = Color.FromArgb(30, 30, 30);
            about_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //dosya panel
            fileMenu.BackColor = Color.FromArgb(200, 200, 200);
            new_btn.BackColor = Color.FromArgb(200, 200, 200);
            open_btn.BackColor = Color.FromArgb(200, 200, 200);
            saveparent_btn.BackColor = Color.FromArgb(200, 200, 200);
            share_btn.BackColor = Color.FromArgb(200, 200, 200);
            print_btn.BackColor = Color.FromArgb(200, 200, 200);
            export_btn.BackColor = Color.FromArgb(200, 200, 200);
            filename_btn.BackColor = Color.FromArgb(200, 200, 200);
            fileinfo_btn.BackColor = Color.FromArgb(200, 200, 200);
            newMenu.BackColor = Color.FromArgb(200, 200, 200);
            emptyDoc_btn.BackColor = Color.FromArgb(200, 200, 200);
            template_btn.BackColor = Color.FromArgb(200, 200, 200);
            openMenu.BackColor = Color.FromArgb(200, 200, 200);
            dropfile_btn.BackColor = Color.FromArgb(200, 200, 200);
            selectfile_btn.BackColor = Color.FromArgb(200, 200, 200);
            saveMenu.BackColor = Color.FromArgb(200, 200, 200);
            save_btn.BackColor = Color.FromArgb(200, 200, 200);
            saveAs_btn.BackColor = Color.FromArgb(200, 200, 200);
            shareMenu.BackColor = Color.FromArgb(200, 200, 200);
            toTeams_btn.BackColor = Color.FromArgb(200, 200, 200);
            email_btn.BackColor = Color.FromArgb(200, 200, 200);
            exportMenu.BackColor = Color.FromArgb(200, 200, 200);
            toPDF_btn.BackColor = Color.FromArgb(200, 200, 200);
            toRTF_btn.BackColor = Color.FromArgb(200, 200, 200);
            toDOCX_btn.BackColor = Color.FromArgb(200, 200, 200);
            fileMenu.ForeColor = Color.FromArgb(30, 30, 30);
            new_btn.ForeColor = Color.FromArgb(30, 30, 30);
            open_btn.ForeColor = Color.FromArgb(30, 30, 30);
            saveparent_btn.ForeColor = Color.FromArgb(30, 30, 30);
            share_btn.ForeColor = Color.FromArgb(30, 30, 30);
            print_btn.ForeColor = Color.FromArgb(30, 30, 30);
            export_btn.ForeColor = Color.FromArgb(30, 30, 30);
            filename_btn.ForeColor = Color.FromArgb(30, 30, 30);
            fileinfo_btn.ForeColor = Color.FromArgb(30, 30, 30);
            emptyDoc_btn.ForeColor = Color.FromArgb(30, 30, 30);
            template_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dropfile_btn.ForeColor = Color.FromArgb(30, 30, 30);
            selectfile_btn.ForeColor = Color.FromArgb(30, 30, 30);
            save_btn.ForeColor = Color.FromArgb(30, 30, 30);
            saveAs_btn.ForeColor = Color.FromArgb(30, 30, 30);
            toTeams_btn.ForeColor = Color.FromArgb(30, 30, 30);
            email_btn.ForeColor = Color.FromArgb(30, 30, 30);
            toPDF_btn.ForeColor = Color.FromArgb(30, 30, 30);
            toRTF_btn.ForeColor = Color.FromArgb(30, 30, 30);
            toDOCX_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //cetvel + durum cubugu + yazi kutusu
            rulerMenu.BackColor = Color.FromArgb(220, 220, 220);
            ruler.BackColor = Color.FromArgb(220, 220, 220);
            statusBar.BackColor = Color.FromArgb(220, 220, 220);
            OSandFormatting_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            numberOfPages_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            numberOfCharacters_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            statusBarZoom_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            statusBarZoom_trck.BackColor = Color.FromArgb(220, 220, 220);
            main_textbox.BackColor = Color.White;
            main_textbox.ForeColor = Color.Black;

            //arac cubugu panel
            paste_btn.BackColor = Color.FromArgb(220, 220, 220);
            copy_btn.BackColor = Color.FromArgb(220, 220, 220);
            cut_btn.BackColor = Color.FromArgb(220, 220, 220);
            select_btn.BackColor = Color.FromArgb(220, 220, 220);
            undo_btn.BackColor = Color.FromArgb(220, 220, 220);
            redo_btn.BackColor = Color.FromArgb(220, 220, 220);
            selectall_btn.BackColor = Color.FromArgb(200, 200, 200);
            bold_btn.BackColor = Color.FromArgb(220, 220, 220);
            italic_btn.BackColor = Color.FromArgb(220, 220, 220);
            underlined_btn.BackColor = Color.FromArgb(220, 220, 220);
            strikethrough_btn.BackColor = Color.FromArgb(220, 220, 220);
            textcolor_btn.BackColor = Color.FromArgb(220, 220, 220);
            highlight_btn.BackColor = Color.FromArgb(220, 220, 220);
            superscript_btn.BackColor = Color.FromArgb(220, 220, 220);
            subscript_btn.BackColor = Color.FromArgb(220, 220, 220);
            characterGap_btn.BackColor = Color.FromArgb(220, 220, 220);
            decreaseFontSize_btn.BackColor = Color.FromArgb(220, 220, 220);
            increaseFontSize_btn.BackColor = Color.FromArgb(220, 220, 220);
            deleteForming_btn.BackColor = Color.FromArgb(220, 220, 220);
            fontSelector_cmb.BackColor = Color.FromArgb(220, 220, 220);
            fontSizeSelector_cmb.BackColor = Color.FromArgb(220, 220, 220);
            bulletList_btn.BackColor = Color.FromArgb(220, 220, 220);
            alignToLeft_btn.BackColor = Color.FromArgb(220, 220, 220);
            alignToMiddle_btn.BackColor = Color.FromArgb(220, 220, 220);
            alignToRight_btn.BackColor = Color.FromArgb(220, 220, 220);
            increaseIndent_btn.BackColor = Color.FromArgb(220, 220, 220);
            decreaseIndent_btn.BackColor = Color.FromArgb(220, 220, 220);
            lock_btn.BackColor = Color.FromArgb(220, 220, 220);
            unlock_btn.BackColor = Color.FromArgb(220, 220, 220);
            lineGap_btn.BackColor = Color.FromArgb(220, 220, 220);
            lineSpacing_menu.BackColor = Color.FromArgb(220, 220, 220);
            lineSpacing_cmb.BackColor = Color.FromArgb(220, 220, 220);
            findParent_btn.BackColor = Color.FromArgb(220, 220, 220);
            searchParent_btn.BackColor = Color.FromArgb(220, 220, 220);
            textTemplatesMenu.BackColor = Color.FromArgb(240, 240, 240);
            defaultTextTemplate_btn.BackColor = Color.FromArgb(220, 220, 220);
            bodyText_btn.BackColor = Color.FromArgb(220, 220, 220);
            title1_btn.BackColor = Color.FromArgb(220, 220, 220);
            title2_btn.BackColor = Color.FromArgb(220, 220, 220);
            subtitle_btn.BackColor = Color.FromArgb(220, 220, 220);
            paste_btn.ForeColor = Color.FromArgb(30, 30, 30);
            copy_btn.ForeColor = Color.FromArgb(30, 30, 30);
            cut_btn.ForeColor = Color.FromArgb(30, 30, 30);
            select_btn.ForeColor = Color.FromArgb(30, 30, 30);
            selectall_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bulletList_btn.ForeColor = Color.FromArgb(30, 30, 30);
            findParent_btn.ForeColor = Color.FromArgb(30, 30, 30);
            searchParent_btn.ForeColor = Color.FromArgb(30, 30, 30);
            defaultTextTemplate_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bodyText_btn.ForeColor = Color.FromArgb(30, 30, 30);
            title1_btn.ForeColor = Color.FromArgb(30, 30, 30);
            title2_btn.ForeColor = Color.FromArgb(30, 30, 30);
            subtitle_btn.ForeColor = Color.FromArgb(30, 30, 30);
            fontSelector_cmb.ForeColor = Color.FromArgb(30, 30, 30);
            fontSizeSelector_cmb.ForeColor = Color.FromArgb(30, 30, 30);
            general_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            font_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            paragraph_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            search_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textTemplates_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            lineSpacing_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            lineSpacing_cmb.ForeColor = Color.FromArgb(30, 30, 30);
            bulletListMenu.BackColor = Color.FromArgb(200, 200, 200);
            bullet6_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet1_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet3_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet2_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet5_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet4_btn.BackColor = Color.FromArgb(220, 220, 220);
            bullet6_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bullet1_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bullet3_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bullet2_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bullet5_btn.ForeColor = Color.FromArgb(30, 30, 30);
            bullet4_btn.ForeColor = Color.FromArgb(30, 30, 30);
            highlightColorSelectMenu.BackColor = Color.FromArgb(200, 200, 200);
            highlightBlue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            highlightGreen_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            highlightRed_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            highlightGreenValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            highlightRedValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            highlightBlueValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            highlightGreenValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            highlightRedValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            highlightBlueValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            closeHighlight_btn.BackColor = Color.FromArgb(190, 190, 190);
            highlightSelectColor_btn.BackColor = Color.FromArgb(190, 190, 190);
            closeHighlight_btn.ForeColor = Color.FromArgb(30, 30, 30);
            highlightSelectColor_btn.ForeColor = Color.FromArgb(30, 30, 30);
            textColorSelectMenu.BackColor = Color.FromArgb(200, 200, 200);
            textColorRed_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorGreen_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorBlue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorGreenValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            textColorRedValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            textColorBlueValue_lbl.BackColor = Color.FromArgb(200, 200, 200);
            textColorGreenValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorRedValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorBlueValue_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textColorSelectColor_btn.BackColor = Color.FromArgb(190, 190, 190);
            textColorSelectColor_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //ekle panel
            addMenu.BackColor = Color.FromArgb(220, 220, 220);
            dateandtime_btn.BackColor = Color.FromArgb(220, 220, 220);
            addLink_btn.BackColor = Color.FromArgb(220, 220, 220);
            addEmoji_btn.BackColor = Color.FromArgb(220, 220, 220);
            addSymbol_btn.BackColor = Color.FromArgb(220, 220, 220);
            addEquation_btn.BackColor = Color.FromArgb(220, 220, 220);
            addImage_btn.BackColor = Color.FromArgb(220, 220, 220);
            addVideo_btn.BackColor = Color.FromArgb(220, 220, 220);
            addTable_btn.BackColor = Color.FromArgb(220, 220, 220);
            addReference_btn.BackColor = Color.FromArgb(220, 220, 220);
            addReferenceNoParent_btn.BackColor = Color.FromArgb(220, 220, 220);
            addNote_btn.BackColor = Color.FromArgb(220, 220, 220);
            addReferenceNoMenu.BackColor = Color.FromArgb(230, 230, 230);
            referenceNo_txt.BackColor = Color.FromArgb(230, 230, 230);
            addReferenceNo_btn.BackColor = Color.FromArgb(240, 240, 240);
            addReferenceNo_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtime_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addLink_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addEmoji_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addSymbol_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addEquation_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addImage_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addVideo_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addTable_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addReference_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addReferenceNoParent_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addNote_btn.ForeColor = Color.FromArgb(30, 30, 30);
            referenceNo_txt.ForeColor = Color.FromArgb(30, 30, 30);
            number_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtime_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            textAdd_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            media_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            reference_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //duzenle panel
            editMenu.BackColor = Color.FromArgb(220, 220, 220);
            pageSize_btn.BackColor = Color.FromArgb(220, 220, 220);
            verticalPage_btn.BackColor = Color.FromArgb(220, 220, 220);
            horizontalPage_btn.BackColor = Color.FromArgb(220, 220, 220);
            pageColor_btn.BackColor = Color.FromArgb(220, 220, 220);
            indentSize_btn.BackColor = Color.FromArgb(220, 220, 220);
            refresh_btn.BackColor = Color.FromArgb(220, 220, 220);
            draganddropEnabled_btn.BackColor = Color.FromArgb(220, 220, 220);
            detectLinks_btn.BackColor = Color.FromArgb(220, 220, 220);
            pageSize_btn.ForeColor = Color.FromArgb(30, 30, 30);
            verticalPage_btn.ForeColor = Color.FromArgb(30, 30, 30);
            horizontalPage_btn.ForeColor = Color.FromArgb(30, 30, 30);
            pageColor_btn.ForeColor = Color.FromArgb(30, 30, 30);
            indentSize_btn.ForeColor = Color.FromArgb(30, 30, 30);
            refresh_btn.ForeColor = Color.FromArgb(30, 30, 30);
            draganddropEnabled_btn.ForeColor = Color.FromArgb(30, 30, 30);
            detectLinks_btn.ForeColor = Color.FromArgb(30, 30, 30);
            page_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            appearancePage_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            otherEdit_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //gorunum panel
            appearenceMenu.BackColor = Color.FromArgb(220, 220, 220);
            ruler_btn.BackColor = Color.FromArgb(220, 220, 220);
            statusbar_btn.BackColor = Color.FromArgb(220, 220, 220);
            zoom_btn.BackColor = Color.FromArgb(220, 220, 220);
            defaultZoom_btn.BackColor = Color.FromArgb(220, 220, 220);
            darkTheme_btn.BackColor = Color.FromArgb(220, 220, 220);
            lightTheme_btn.BackColor = Color.FromArgb(220, 220, 220);
            ruler_btn.ForeColor = Color.FromArgb(30, 30, 30);
            statusbar_btn.ForeColor = Color.FromArgb(30, 30, 30);
            zoom_btn.ForeColor = Color.FromArgb(30, 30, 30);
            defaultZoom_btn.ForeColor = Color.FromArgb(30, 30, 30);
            darkTheme_btn.ForeColor = Color.FromArgb(30, 30, 30);
            lightTheme_btn.ForeColor = Color.FromArgb(30, 30, 30);
            show_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            zoomcategory_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            theme_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            zoom_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //bul ve ara panel
            find_btn.Image = Properties.Resources.find_dark;
            closeFind_btn.BackgroundImage = Properties.Resources.close_dark;
            findMenu.BackColor = Color.FromArgb(210, 210, 210);
            find_txt.BackColor = Color.FromArgb(210, 210, 210);
            find_btn.BackColor = Color.FromArgb(220, 220, 220);
            closeFind_btn.BackColor = Color.FromArgb(220, 220, 220);
            find_txt.ForeColor = Color.FromArgb(30, 30, 30);
            find_btn.ForeColor = Color.FromArgb(30, 30, 30);
            closeFind_btn.ForeColor = Color.FromArgb(30, 30, 30);
            search_btn.Image = Properties.Resources.search_dark;
            closeSearch_btn.BackgroundImage = Properties.Resources.close_dark;
            searchMenu.BackColor = Color.FromArgb(210, 210, 210);
            search_txtBox.BackColor = Color.FromArgb(210, 210, 210);
            search_btn.BackColor = Color.FromArgb(220, 220, 220);
            closeSearch_btn.BackColor = Color.FromArgb(220, 220, 220);
            search_txtBox.ForeColor = Color.FromArgb(30, 30, 30);
            search_btn.ForeColor = Color.FromArgb(30, 30, 30);
            closeSearch_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //cizgiler
            fileLine1.Image = Properties.Resources.lightgray;
            fileLine2.Image = Properties.Resources.lightgray;
            toolsLine1.Image = Properties.Resources.gray;
            toolsLine2.Image = Properties.Resources.gray;
            toolsLine3.Image = Properties.Resources.gray;
            toolsLine4.Image = Properties.Resources.gray;
            toolsLine5.Image = Properties.Resources.gray;
            addLine1.Image = Properties.Resources.gray;
            addLine2.Image = Properties.Resources.gray;
            addLine3.Image = Properties.Resources.gray;
            addLine4.Image = Properties.Resources.gray;
            editLine1.Image = Properties.Resources.gray;
            editLine2.Image = Properties.Resources.gray;
            editLine3.Image = Properties.Resources.gray;
            apprLine1.Image = Properties.Resources.gray;
            apprLine2.Image = Properties.Resources.gray;
            apprLine3.Image = Properties.Resources.gray;
            img_buffer.Image = Properties.Resources.lightgray;

            lightTheme_btn.BorderSize = 1;
            darkTheme_btn.BorderSize = 0;
            Properties.Settings.Default.darktheme = false;
        }

        public void ChangeTheme(bool isLightTheme)
        {
            if(isLightTheme)
                LightTheme();
            else
                DarkTheme();
            Properties.Settings.Default.Save();
        }

        private void lightTheme_btn_Click(object sender, EventArgs e) => ChangeTheme(true);
        private void darkTheme_btn_Click(object sender, EventArgs e) => ChangeTheme(false);
    }

    class RoundRectangle
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,     
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr obj);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
    }
}
