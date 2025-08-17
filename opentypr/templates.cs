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
    public partial class templates : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Point mouseLoc;

        public static int template = 0;
        public templates()
        {
            InitializeComponent();
        }

        private void templates_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            if(Properties.Settings.Default.darktheme)
                DarkTheme();
            else
                LightTheme();
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

        private void close_btn_Click(object sender, EventArgs e) => Close();

        private void SetTemplatePreview(int templateNumber)
        {
            preview_txt.SelectAll();
            switch(templateNumber)
            {
                case 0: preview_txt.SelectedRtf = Properties.Resources.defaultTemplate; break;
                case 1: preview_txt.SelectedRtf = Properties.Resources.basic; break;
                case 2: preview_txt.SelectedRtf = Properties.Resources.modern; break;
                case 3: preview_txt.SelectedRtf = Properties.Resources.article; break;
                case 4: preview_txt.SelectedRtf = Properties.Resources.letter; break;
            }
            template = templateNumber;
        }

        private void default_btn_Click(object sender, EventArgs e) => SetTemplatePreview(0);
        private void basic_btn_Click(object sender, EventArgs e) => SetTemplatePreview(1);
        private void modern_btn_Click(object sender, EventArgs e) => SetTemplatePreview(2);
        private void article_btn_Click(object sender, EventArgs e) => SetTemplatePreview(3);
        private void letter_btn_Click(object sender, EventArgs e) => SetTemplatePreview(4);

        private void apply_btn_Click(object sender, EventArgs e)
        {
            mainwindow.isTemplateAdded = true;
            Close();
        }

        /*
        main dosyasında olduğu gibi tema yeri oldukça uzun, onunla ilgili açıklamayı
        main dosyasında yaptım
        */

        public void DarkTheme()
        {
            //ust panel
            logo_img.Image = Properties.Resources.opentypr;
            close_btn.BackgroundImage = Properties.Resources.close;
            topMenu.BackColor = Color.FromArgb(23, 23, 23);
            close_btn.BackColor = Color.FromArgb(43, 43, 43);
            title_lbl.ForeColor = Color.White;

            //ic kisim
            backgroundPanel.BackColor = Color.FromArgb(43, 43, 43);
            modern_btn.BackColor = Color.FromArgb(73, 73, 73);
            basic_btn.BackColor = Color.FromArgb(73, 73, 73);
            default_btn.BackColor = Color.FromArgb(73, 73, 73);
            letter_btn.BackColor = Color.FromArgb(73, 73, 73);
            article_btn.BackColor = Color.FromArgb(73, 73, 73);
            apply_btn.BackColor = Color.FromArgb(33, 33, 33);
            modern_btn.ForeColor = Color.White;
            basic_btn.ForeColor = Color.White;
            default_btn.ForeColor = Color.White;
            letter_btn.ForeColor = Color.White;
            article_btn.ForeColor = Color.White;
            apply_btn.ForeColor = Color.White;
            general_lbl.ForeColor = Color.Silver;
            special_lbl.ForeColor = Color.Silver;
        }

        public void LightTheme()
        {
            //ust panel
            logo_img.Image = Properties.Resources.opentyprdark;
            close_btn.BackgroundImage = Properties.Resources.close_dark;
            topMenu.BackColor = Color.FromArgb(200, 200, 200);
            close_btn.BackColor = Color.FromArgb(220, 220, 220);
            title_lbl.ForeColor = Color.FromArgb(30, 30, 30);

            //ic kisim
            backgroundPanel.BackColor = Color.FromArgb(220, 220, 220);
            modern_btn.BackColor = Color.FromArgb(240, 240, 240);
            basic_btn.BackColor = Color.FromArgb(240, 240, 240);
            default_btn.BackColor = Color.FromArgb(240, 240, 240);
            letter_btn.BackColor = Color.FromArgb(240, 240, 240);
            article_btn.BackColor = Color.FromArgb(240, 240, 240);
            apply_btn.BackColor = Color.FromArgb(210, 210, 210);
            modern_btn.ForeColor = Color.FromArgb(30, 30, 30);
            basic_btn.ForeColor = Color.FromArgb(30, 30, 30);
            default_btn.ForeColor = Color.FromArgb(30, 30, 30);
            letter_btn.ForeColor = Color.FromArgb(30, 30, 30);
            article_btn.ForeColor = Color.FromArgb(30, 30, 30);
            apply_btn.ForeColor = Color.FromArgb(30, 30, 30);
            general_lbl.ForeColor = Color.FromArgb(60, 60, 60);
            special_lbl.ForeColor = Color.FromArgb(60, 60, 60);
        }
    }
}
