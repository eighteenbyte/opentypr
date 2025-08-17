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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace opentypr
{
    public partial class fileInfo_window : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Point mouseLoc;
        public int animationPos;

        public string plainOrRichText;
        public static string fileName = "Adsız Belge";

        enum MenuType { General, Statistics, Settings }
        public int menuNumber = 0;
        //0 = genel
        //1 = istatistikler
        //2 = ayarlar

        public fileInfo_window()
        {
            InitializeComponent();
        }

        private void fileInfo_window_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            if(Properties.Settings.Default.darktheme)
                DarkTheme();
            else
                LightTheme();

            //tüm istatistikler burada toplanıyor
            switch (menuNumber)
            {
                case 0: general_btn.PerformClick(); break;
                case 1: statistics_btn.PerformClick(); break;
                case 2: settings_btn.PerformClick(); break;
            }

            switch (templates.template)
            {
                case 0: template_lbl.Text = "Yok"; break;
                case 1: template_lbl.Text = "Modern"; break;
                case 2: template_lbl.Text = "Basit"; break;
                case 3: template_lbl.Text = "Varsayılan"; break;
                case 4: template_lbl.Text = "Makale"; break;
                case 5: template_lbl.Text = "Mektup"; break;
            }

            switch (plainOrRichText)
            {
                case "RichText": plainorrichtext_lbl.Text = "RichText"; break;
                case "PlainText": plainorrichtext_lbl.Text = "PlainText"; break;
                case "UnicodeText": plainorrichtext_lbl.Text = "UnicodeText"; break;
            }

            characters_lbl.Text = mainwindow.character_number.ToString();
            pages_lbl.Text = mainwindow.page_count.ToString();
            lines_lbl.Text = mainwindow.lines.ToString();
            words_lbl.Text = mainwindow.words.ToString();

            filename_lbl.Text = fileName;
            filename2_lbl.Text = fileName;
            filename3_lbl.Text = fileName;
            filename_txt.Text = fileName;
        }

        private void topMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;
            }
        }

        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void anim_timer_Tick(object sender, EventArgs e)
        {
            int diff = animationPos - highlight_img.Left;

            if (diff != 0)
            {
                int step = Math.Abs(diff) < 15 ? 1 : 15;
                highlight_img.Left += Math.Sign(diff) * step;
            }
            else
                anim_timer.Enabled = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            menuNumber = 0;
            Close();
        }

        private void plainorrichtext_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kodlama türünü değiştirmek yazının bozulmasına neden olabilir. Lütfen ne yaptığınızı biliyorsanız bu değeri değiştirin. Bu değeri değiştirmek istediğinizden emin misiniz?", "opentypr | Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                plainOrRichText = plainorrichtext_cmb.Text;
                switch (plainOrRichText)
                {
                    case "RichText": plainorrichtext_lbl.Text = "RichText"; break;
                    case "PlainText": plainorrichtext_lbl.Text = "PlainText"; break;
                    case "UnicodeText": plainorrichtext_lbl.Text = "UnicodeText"; break;
                    default: plainorrichtext_cmb.Text = "RichText"; break;
                }
            }
        }

        private void filename_txt_TextChanged(object sender, EventArgs e)
        {
            fileName = filename_txt.Text;
            mainwindow.filename_changed = true;
            filename2_lbl.Text = fileName;
            filename_lbl.Text = fileName;
            filename3_lbl.Text = fileName;
        }

        //Menü değiştirmek için basit bir sistem belki main'de de bunu kullanabiliriz
        private void ChangeMenu(MenuType selectedMenu, int animPos)
        {
            generalMenu.Visible = (selectedMenu == MenuType.General);
            statisticsMenu.Visible = (selectedMenu == MenuType.Statistics);
            settingsMenu.Visible = (selectedMenu == MenuType.Settings);
            animationPos = animPos;
            anim_timer.Enabled = true;
        }

        private void general_btn_Click(object sender, EventArgs e) => ChangeMenu(MenuType.General, 30);
        private void statistics_btn_Click(object sender, EventArgs e) => ChangeMenu(MenuType.Statistics, 154);
        private void settings_btn_Click(object sender, EventArgs e) => ChangeMenu(MenuType.Settings, 271);

        /*
        main dosyasında olduğu gibi tema yeri oldukça uzun, onunla ilgili açıklamayı
        main dosyasında yaptım
        */

        public void DarkTheme()
        {
            //ust panel
            logo_img.Image = Properties.Resources.opentypr;
            close_btn.BackgroundImage = Properties.Resources.close;
            topMenu.BackColor = Color.FromArgb(43, 43, 43);
            backgroundPanel.BackColor = Color.FromArgb(73, 73, 73);
            general_btn.BackColor = Color.FromArgb(43, 43, 43);
            statistics_btn.BackColor = Color.FromArgb(43, 43, 43);
            settings_btn.BackColor = Color.FromArgb(43, 43, 43);
            close_btn.BackColor = Color.FromArgb(73, 73, 73);
            title_lbl.ForeColor = Color.White;
            general_btn.ForeColor = Color.White;
            statistics_btn.ForeColor = Color.White;
            settings_btn.ForeColor = Color.White;

            //genel sekme
            generalMenu.BackColor = Color.FromArgb(73, 73, 73);
            filename2_lbl.ForeColor = Color.White;
            general_lbl.ForeColor = Color.White;
            filetype_lbl.ForeColor = Color.White;
            fileextension_lbl.ForeColor = Color.White;
            size_lbl.ForeColor = Color.White;
            filelocation_lbl.ForeColor = Color.White;
            template_lbl.ForeColor = Color.White;
            plainorrichtext_lbl.ForeColor = Color.White;

            //istatistik sekme
            statisticsMenu.BackColor = Color.FromArgb(73, 73, 73);
            pages_lbl.ForeColor = Color.White;
            statistics_lbl.ForeColor = Color.White;
            filename_lbl.ForeColor = Color.White;
            lines_lbl.ForeColor = Color.White;
            words_lbl.ForeColor = Color.White;
            characters_lbl.ForeColor = Color.White;

            //ayarlar sekme
            settingsMenu.BackColor = Color.FromArgb(73, 73, 73);
            plainorrichtext_cmb.BackColor = Color.FromArgb(103, 103, 103);
            filename_txt.BackColor = Color.FromArgb(103, 103, 103);
            help_btn.BackColor = Color.FromArgb(43, 43, 43);
            plainorrichtext_cmb.ForeColor = Color.White;
            settings_lbl.ForeColor = Color.White;
            filename3_lbl.ForeColor = Color.White;
            filename_txt.ForeColor = Color.White;
            help_btn.ForeColor = Color.White;
        }

        public void LightTheme()
        {
            //ust panel
            logo_img.Image = Properties.Resources.opentyprdark;
            close_btn.BackgroundImage = Properties.Resources.close_dark;
            topMenu.BackColor = Color.FromArgb(220, 220, 220);
            backgroundPanel.BackColor = Color.FromArgb(240, 240, 240);
            general_btn.BackColor = Color.FromArgb(220, 220, 220);
            statistics_btn.BackColor = Color.FromArgb(220, 220, 220);
            settings_btn.BackColor = Color.FromArgb(220, 220, 220);
            close_btn.BackColor = Color.FromArgb(240, 240, 240);
            title_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            general_btn.ForeColor = Color.FromArgb(30, 30, 30);
            statistics_btn.ForeColor = Color.FromArgb(30, 30, 30);
            settings_btn.ForeColor = Color.FromArgb(30, 30, 30);

            //genel sekme
            generalMenu.BackColor = Color.FromArgb(240, 240, 240);
            filename2_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            general_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            filetype_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            fileextension_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            size_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            filelocation_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            template_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            plainorrichtext_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //istatistik sekme
            statisticsMenu.BackColor = Color.FromArgb(240, 240, 240);
            pages_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            statistics_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            filename_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            lines_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            words_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            characters_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //ayarlar sekme
            settingsMenu.BackColor = Color.FromArgb(240, 240, 240);
            plainorrichtext_cmb.BackColor = Color.FromArgb(250, 250, 250);
            filename_txt.BackColor = Color.FromArgb(250, 250, 250);
            help_btn.BackColor = Color.FromArgb(220, 220, 220);
            plainorrichtext_cmb.ForeColor = Color.FromArgb(30, 30, 30);
            settings_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            filename3_lbl.ForeColor = Color.FromArgb(30, 30, 30);
            filename_txt.ForeColor = Color.FromArgb(30, 30, 30);
            help_btn.ForeColor = Color.FromArgb(30, 30, 30);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
