using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opentypr
{
    public partial class messagebox : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Point mouseLoc;
        public int msgBoxNumber = 0;
        //1 = Tarih ve Saat
        //2 = Baglanti
        //3 = Tablo
        //4 = Basvuru
        //5 = Not
        //6 = Sembol
        //7 = Denklem
        //8 = Kenar Boyutu

        public messagebox()
        {
            InitializeComponent();
        }

        private void messagebox_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();

            if (Properties.Settings.Default.darktheme)
                DarkTheme();
            else
                LightTheme();

            Panel[] menuler =
            {
                dateandtimeMenu, linkMenu, tableMenu, referenceMenu,
                notesMenu, symbolMenu, equationMenu, indentsMenu
            };
            foreach (var menu in menuler)
                menu.Visible = false;

            switch (msgBoxNumber)
            {
                case 1:
                    dateandtimeMenu.Visible = true;
                    msgBox_Title.Text = "Tarih ve Saat Ekle";
                    dateandtimePreview_lbl.Text = DateTime.Now.ToString("g");
                    break;

                case 2:
                    linkMenu.Visible = true;
                    msgBox_Title.Text = "Bağlantı Ekle";
                    break;

                case 3:
                    tableMenu.Visible = true;
                    msgBox_Title.Text = "Tablo Ekle";
                    break;

                case 4:
                    referenceMenu.Visible = true;
                    msgBox_Title.Text = "Başvuru Ekle";
                    break;

                case 5:
                    notesMenu.Visible = true;
                    msgBox_Title.Text = "Not Ekle";
                    break;

                case 6:
                    symbolMenu.Visible = true;
                    msgBox_Title.Text = "Sembol Ekle";
                    break;

                case 7:
                    equationMenu.Visible = true;
                    msgBox_Title.Text = "Denklem Ekle";
                    break;

                case 8:
                    indentsMenu.Visible = true;
                    msgBox_Title.Text = "Kenar Boyutunu Ayarla";
                    midIndent_txt.Text = mainwindow.indent_top.ToString();
                    rightIndent_txt.Text = mainwindow.indent_right.ToString();
                    leftIndent_txt.Text = mainwindow.indent_left.ToString();
                    break;
            }
        }

        private void msgBox_topMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;
            }
        }

        private void msgBox_topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void messagebox_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = RoundRectangle.CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            RoundRectangle.DeleteObject(ptr);
        }

        private void msgBox_Close_Click(object sender, EventArgs e) => Close();

        private void dateandtimeFormat_btn_Click(object sender, EventArgs e) => dateandtimeFormatMenu.Visible = !dateandtimeFormatMenu.Visible;

        private void SetDateTimeFormat(string format, string description)
        {
            dateandtimePreview_lbl.Text = DateTime.Now.ToString(format);
            dateandTimeFormat_lbl.Text = $"Format: {description}";
            dateandtimeFormatMenu.Visible = false;
        }

        private void dateandtimeNormalFormat_btn_Click(object sender, EventArgs e) => SetDateTimeFormat("g", "Normal Tarih ve Saat");
        private void dateandtimeLongFormat_btn_Click(object sender, EventArgs e) => SetDateTimeFormat("F", "Uzun Tarih ve Saat");
        private void dateandtimeOnlyDate_btn_Click(object sender, EventArgs e) => SetDateTimeFormat("d", "Sadece Tarih");
        private void dateandtimeOnlyTime_btn_Click(object sender, EventArgs e) => SetDateTimeFormat("T", "Sadece Saat");
        private void dateandtimeYearMonth_btn_Click(object sender, EventArgs e) => SetDateTimeFormat("Y", "Ay ve Yıl");

        private void addDateandtime_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = dateandtimePreview_lbl.Text;
            mainwindow.isAppendWords = true;
            Close();
        }

        private void addLink_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = linkPreview_lbl.Text;
            mainwindow.isAppendWords = true;
            Close();
        }

        private void ChangeProtocols(string protocol)
        {
            protocolSelection_btn.Text = protocol;
            linkPreview_lbl.Text = protocol + link_txt.Text;
            linkProtocolsMenu.Visible = false;
        }

        private void https_btn_Click(object sender, EventArgs e) => ChangeProtocols("https://");
        private void http_btn_Click(object sender, EventArgs e) => ChangeProtocols("http://");
        private void localhost_btn_Click(object sender, EventArgs e) => ChangeProtocols("localhost/");
        private void protocolSelection_btn_Click(object sender, EventArgs e) => linkProtocolsMenu.Visible = !linkProtocolsMenu.Visible;

        private void link_txt_TextChanged(object sender, EventArgs e) => linkPreview_lbl.Text = protocolSelection_btn.Text + link_txt.Text;

        private void addTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mainwindow.rows = Int32.Parse(column_txt.Text);
                mainwindow.columns = Int32.Parse(line_txt.Text);
                mainwindow.tableWidth = Int32.Parse(cellLength_txt.Text);
                mainwindow.isTableDrawn = true;
                Close();
            }
            catch
            {
                MessageBox.Show("Lütfen ilgili yerlere gerçek tam sayılar giriniz.", "opentypr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addReference_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = referenceText_txt.Text;
            mainwindow.reference_number = referenceNumber_txt.Text;
            mainwindow.isAppendReference = true;
            Close();
        }

        private void addNotes_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = notes_textbox.Text;
            mainwindow.isAppendNotes = true;
            Close();
        }

        private void addSymbol_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = symbolsPreview_lbl.Text;
            mainwindow.isAppendWordsWild = true;
            Close();
        }

        private void generalSymbols_cmb_SelectedIndexChanged(object sender, EventArgs e) => symbolsPreview_lbl.Text += generalSymbols_cmb.Text;
        private void arabicSymbols_cmb_SelectedIndexChanged(object sender, EventArgs e) => symbolsPreview_lbl.Text += arabicSymbols_cmb.Text;
        private void greekSymbols_cmb_SelectedIndexChanged(object sender, EventArgs e) => symbolsPreview_lbl.Text += greekSymbols_cmb.Text;
        private void latinSymbols_cmb_SelectedIndexChanged(object sender, EventArgs e) => symbolsPreview_lbl.Text += latinSymbols_cmb.Text;

        private void equation1_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation1_btn.Text;
        private void equation2_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation2_btn.Text;
        private void equation3_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation3_btn.Text;
        private void equation4_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation4_btn.Text;
        private void equation5_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation5_btn.Text;
        private void equation6_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation6_btn.Text;
        private void equation7_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation7_btn.Text;
        private void equation8_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation8_btn.Text;
        private void equation9_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation9_btn.Text;
        private void equation10_btn_Click(object sender, EventArgs e) => equationPreview_txt.Text += equation10_btn.Text;

        private void addEquation_btn_Click(object sender, EventArgs e)
        {
            mainwindow.appended_words = equationPreview_txt.Text;
            mainwindow.isAppendWordsWild = true;
            Close();
        }

        private void setIndents_btn_Click(object sender, EventArgs e)
        {
            mainwindow.indent_top = Int32.Parse(midIndent_txt.Text);
            mainwindow.indent_right = Int32.Parse(rightIndent_txt.Text);
            mainwindow.indent_left = Int32.Parse(leftIndent_txt.Text);
            mainwindow.indent_changed = true;
            Close();
        }


        /*
        main dosyasında olduğu gibi tema yeri oldukça uzun, onunla ilgili açıklamayı
        main dosyasında yaptım
        */

        public void DarkTheme()
        {
            //ust panel
            msgBox_Close.BackgroundImage = Properties.Resources.close;
            msgBox_topMenu.BackColor = Color.FromArgb(43, 43, 43);
            msgBox_Close.BackColor = Color.FromArgb(73, 73, 73);
            backgroundPanel.BackColor = Color.FromArgb(73, 73, 73);
            msgBox_Title.ForeColor = Color.White;

            //kenar boyutu panel
            indentsMenu.BackColor = Color.FromArgb(73, 73, 73);
            setIndents_btn.BackColor = Color.FromArgb(103, 103, 103);
            rightIndent_txt.BackColor = Color.FromArgb(73, 73, 73);
            leftIndent_txt.BackColor = Color.FromArgb(73, 73, 73);
            midIndent_txt.BackColor = Color.FromArgb(73, 73, 73);
            textBoxExample.BackColor = Color.Gray;
            left_lbl.ForeColor = Color.White;
            right_lbl.ForeColor = Color.White;
            leftpx_lbl.ForeColor = Color.White;
            rightpx_lbl.ForeColor = Color.White;
            midpx_lbl.ForeColor = Color.White;
            mid_lbl.ForeColor = Color.White;
            setIndents_btn.ForeColor = Color.White;

            //basvuru panel
            referenceMenu.BackColor = Color.FromArgb(73, 73, 73);
            referenceNumber_txt.BackColor = Color.FromArgb(73, 73, 73);
            referenceText_txt.BackColor = Color.FromArgb(73, 73, 73);
            addReference_btn.BackColor = Color.FromArgb(103, 103, 103);
            referenceText_txt.ForeColor = Color.White;
            addReference_btn.ForeColor = Color.White;
            referenceText_lbl.ForeColor = Color.White;
            referenceNumber_lbl.ForeColor = Color.White;

            //tablo panel
            tableMenu.BackColor = Color.FromArgb(73, 73, 73);
            column_txt.BackColor = Color.FromArgb(73, 73, 73);
            line_txt.BackColor = Color.FromArgb(73, 73, 73);
            cellLength_txt.BackColor = Color.FromArgb(73, 73, 73);
            addTable_btn.BackColor = Color.FromArgb(103, 103, 103);
            column_txt.ForeColor = Color.White;
            line_txt.ForeColor = Color.White;
            cellLength_txt.ForeColor = Color.White;
            addTable_btn.ForeColor = Color.White;
            columnXline_lbl.ForeColor = Color.White;
            column_lbl.ForeColor = Color.White;
            line_lbl.ForeColor = Color.White;
            cellLength_lbl.ForeColor = Color.White;

            //baglanti panel
            protocolSelection_btn.Image = Properties.Resources.arrowtemplate;
            linkMenu.BackColor = Color.FromArgb(73, 73, 73);
            linkProtocolsMenu.BackColor = Color.FromArgb(103, 103, 103);
            link_txt.BackColor = Color.FromArgb(133, 133, 133);
            linktxtPanel.BackColor = Color.FromArgb(133, 133, 133);
            protocolSelection_btn.BackColor = Color.FromArgb(103, 103, 103);
            http_btn.BackColor = Color.FromArgb(103, 103, 103);
            https_btn.BackColor = Color.FromArgb(103, 103, 103);
            localhost_btn.BackColor = Color.FromArgb(103, 103, 103);
            addLink_btn.BackColor = Color.FromArgb(103, 103, 103);
            linkPreview_lbl.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            link_txt.ForeColor = Color.White;
            protocolSelection_btn.ForeColor = Color.White;
            http_btn.ForeColor = Color.White;
            https_btn.ForeColor = Color.White;
            localhost_btn.ForeColor = Color.White;
            addLink_btn.ForeColor = Color.White;

            //tarih saat panel
            dateandtimeMenu.BackColor = Color.FromArgb(73, 73, 73);
            dateandtimeFormatMenu.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeFormat_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeNormalFormat_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeOnlyDate_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeOnlyTime_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeYearMonth_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeLongFormat_btn.BackColor = Color.FromArgb(103, 103, 103);
            addDateandtime_btn.BackColor = Color.FromArgb(103, 103, 103);
            dateandtimeFormat_btn.ForeColor = Color.White;
            dateandtimeNormalFormat_btn.ForeColor = Color.White;
            dateandtimeOnlyDate_btn.ForeColor = Color.White;
            dateandtimeOnlyTime_btn.ForeColor = Color.White;
            dateandtimeYearMonth_btn.ForeColor = Color.White;
            dateandtimeLongFormat_btn.ForeColor = Color.White;
            addDateandtime_btn.ForeColor = Color.White;
            dateandTimeFormat_lbl.ForeColor = Color.White;
            dateandTimePreText_lbl.ForeColor = Color.White;
            dateandtimePreview_lbl.ForeColor = Color.White;

            //denklem panel
            equationMenu.BackColor = Color.FromArgb(73, 73, 73);
            addEquation_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation1_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation2_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation3_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation4_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation6_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation5_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation8_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation7_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation10_btn.BackColor = Color.FromArgb(103, 103, 103);
            equation9_btn.BackColor = Color.FromArgb(103, 103, 103);
            equationPreview_txt.BackColor = Color.FromArgb(43, 43, 43);
            addEquation_btn.ForeColor = Color.White;
            equation1_btn.ForeColor = Color.White;
            equation2_btn.ForeColor = Color.White;
            equation3_btn.ForeColor = Color.White;
            equation4_btn.ForeColor = Color.White;
            equation6_btn.ForeColor = Color.White;
            equation5_btn.ForeColor = Color.White;
            equation8_btn.ForeColor = Color.White;
            equation7_btn.ForeColor = Color.White;
            equation10_btn.ForeColor = Color.White;
            equation9_btn.ForeColor = Color.White;
            equationPreview_txt.ForeColor = Color.White;
            symbolsPreview_lbl.ForeColor = Color.Silver;

            //sembol panel
            symbolMenu.BackColor = Color.FromArgb(73, 73, 73);
            addSymbol_btn.BackColor = Color.FromArgb(103, 103, 103);
            addSymbol_btn.ForeColor = Color.White;
            symbolsPreText_lbl.ForeColor = Color.Silver;
            generalSymbols_lbl.ForeColor = Color.Silver;
            arabicSymbols_lbl.ForeColor = Color.Silver;
            greekSymbols_lbl.ForeColor = Color.Silver;
            latinSymbols_lbl.ForeColor = Color.Silver;

            //not panel
            notesMenu.BackColor = Color.FromArgb(73, 73, 73);
            addNotes_btn.BackColor = Color.FromArgb(103, 103, 103);
            notes_textbox.BackColor = Color.FromArgb(73, 73, 73);
            notes_textbox.ForeColor = Color.LightGray;
            addNotes_btn.ForeColor = Color.White;
            notesText_lbl.ForeColor = Color.White;
        }

        public void LightTheme()
        {
            //ust panel
            msgBox_Close.BackgroundImage = Properties.Resources.close_dark;
            msgBox_topMenu.BackColor = Color.FromArgb(220, 220, 220);
            msgBox_Close.BackColor = Color.FromArgb(240, 240, 240);
            backgroundPanel.BackColor = Color.FromArgb(240, 240, 240);
            msgBox_Title.ForeColor = Color.FromArgb(30, 30, 30);

            //kenar boyutu panel
            indentsMenu.BackColor = Color.FromArgb(240, 240, 240);
            setIndents_btn.BackColor = Color.FromArgb(250, 250, 250);
            rightIndent_txt.BackColor = Color.FromArgb(240, 240, 240);
            leftIndent_txt.BackColor = Color.FromArgb(240, 240, 240);
            midIndent_txt.BackColor = Color.FromArgb(240, 240, 240);
            textBoxExample.BackColor = Color.FromArgb(255, 255, 255);
            left_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            right_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            leftpx_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            rightpx_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            midpx_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            mid_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            setIndents_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //basvuru panel
            referenceMenu.BackColor = Color.FromArgb(240, 240, 240);
            referenceNumber_txt.BackColor = Color.FromArgb(240, 240, 240);
            referenceText_txt.BackColor = Color.FromArgb(240, 240, 240);
            addReference_btn.BackColor = Color.FromArgb(250, 250, 250);
            referenceText_txt.ForeColor = Color.FromArgb(30, 30, 30);
            addReference_btn.ForeColor = Color.FromArgb(30, 30, 30);
            referenceText_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            referenceNumber_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //tablo panel
            tableMenu.BackColor = Color.FromArgb(240, 240, 240);
            column_txt.BackColor = Color.FromArgb(240, 240, 240);
            line_txt.BackColor = Color.FromArgb(240, 240, 240);
            cellLength_txt.BackColor = Color.FromArgb(240, 240, 240);
            addTable_btn.BackColor = Color.FromArgb(250, 250, 250);
            column_txt.ForeColor = Color.FromArgb(30, 30, 30);
            line_txt.ForeColor = Color.FromArgb(30, 30, 30);
            cellLength_txt.ForeColor = Color.FromArgb(30, 30, 30);
            addTable_btn.ForeColor = Color.FromArgb(30, 30, 30);
            columnXline_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            column_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            line_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            cellLength_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //baglanti panel
            protocolSelection_btn.Image = Properties.Resources.arrowtemplate_dark;
            linkMenu.BackColor = Color.FromArgb(240, 240, 240);
            linkProtocolsMenu.BackColor = Color.FromArgb(250, 250, 250);
            link_txt.BackColor = Color.FromArgb(255, 255, 255);
            linktxtPanel.BackColor = Color.FromArgb(255, 255, 255);
            protocolSelection_btn.BackColor = Color.FromArgb(250, 250, 250);
            http_btn.BackColor = Color.FromArgb(250, 250, 250);
            https_btn.BackColor = Color.FromArgb(250, 250, 250);
            localhost_btn.BackColor = Color.FromArgb(250, 250, 250);
            addLink_btn.BackColor = Color.FromArgb(250, 250, 250);
            linkPreview_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            label6.ForeColor = Color.FromArgb(30, 30, 30);
            link_txt.ForeColor = Color.FromArgb(30, 30, 30);
            protocolSelection_btn.ForeColor = Color.FromArgb(30, 30, 30);
            http_btn.ForeColor = Color.FromArgb(30, 30, 30);
            https_btn.ForeColor = Color.FromArgb(30, 30, 30);
            localhost_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addLink_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //tarih saat panel
            dateandtimeMenu.BackColor = Color.FromArgb(240, 240, 240);
            dateandtimeFormatMenu.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeFormat_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeNormalFormat_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeOnlyDate_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeOnlyTime_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeYearMonth_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeLongFormat_btn.BackColor = Color.FromArgb(250, 250, 250);
            addDateandtime_btn.BackColor = Color.FromArgb(250, 250, 250);
            dateandtimeFormat_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimeNormalFormat_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimeOnlyDate_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimeOnlyTime_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimeYearMonth_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimeLongFormat_btn.ForeColor = Color.FromArgb(30, 30, 30);
            addDateandtime_btn.ForeColor = Color.FromArgb(30, 30, 30);
            dateandTimeFormat_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            dateandTimePreText_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            dateandtimePreview_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //denklem panel
            equationMenu.BackColor = Color.FromArgb(240, 240, 240);
            addEquation_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation1_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation2_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation3_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation4_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation6_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation5_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation8_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation7_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation10_btn.BackColor = Color.FromArgb(250, 250, 250);
            equation9_btn.BackColor = Color.FromArgb(250, 250, 250);
            equationPreview_txt.BackColor = Color.FromArgb(220, 220, 220);
            addEquation_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation1_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation2_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation3_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation4_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation6_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation5_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation8_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation7_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation10_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equation9_btn.ForeColor = Color.FromArgb(30, 30, 30);
            equationPreview_txt.ForeColor = Color.FromArgb(30, 30, 30);
            symbolsPreview_lbl.ForeColor = Color.FromArgb(60, 60, 60);

            //sembol panel
            symbolMenu.BackColor = Color.FromArgb(240, 240, 240);
            addSymbol_btn.BackColor = Color.FromArgb(250, 250, 250);
            addSymbol_btn.ForeColor = Color.FromArgb(30, 30, 30);
            symbolsPreText_lbl.ForeColor = Color.FromArgb(60, 60, 60);
            generalSymbols_lbl.ForeColor = Color.FromArgb(60, 60, 60);
            arabicSymbols_lbl.ForeColor = Color.FromArgb(60, 60, 60);
            greekSymbols_lbl.ForeColor = Color.FromArgb(60, 60, 60);
            latinSymbols_lbl.ForeColor = Color.FromArgb(60, 60, 60);

            //not panel
            notesMenu.BackColor = Color.FromArgb(240, 240, 240);
            addNotes_btn.BackColor = Color.FromArgb(250, 250, 250);
            notes_textbox.BackColor = Color.FromArgb(240, 240, 240);
            notes_textbox.ForeColor = Color.FromArgb(60, 60, 60);
            addNotes_btn.ForeColor = Color.FromArgb(30, 30, 30);
            notesText_lbl.ForeColor = Color.FromArgb(30, 30, 30);
        }
    }
}
