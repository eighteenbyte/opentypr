namespace opentypr
{
    partial class templates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(templates));
            this.preview_txt = new System.Windows.Forms.RichTextBox();
            this.general_lbl = new System.Windows.Forms.Label();
            this.special_lbl = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.apply_btn = new opentypr.Modules.CustomButtons();
            this.letter_btn = new opentypr.Modules.CustomButtons();
            this.article_btn = new opentypr.Modules.CustomButtons();
            this.basic_btn = new opentypr.Modules.CustomButtons();
            this.default_btn = new opentypr.Modules.CustomButtons();
            this.modern_btn = new opentypr.Modules.CustomButtons();
            this.topMenu = new opentypr.Modules.CustomPanels();
            this.title_lbl = new System.Windows.Forms.Label();
            this.logo_img = new System.Windows.Forms.PictureBox();
            this.close_btn = new opentypr.Modules.CustomButtons();
            this.backgroundPanel.SuspendLayout();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).BeginInit();
            this.SuspendLayout();
            // 
            // preview_txt
            // 
            this.preview_txt.BackColor = System.Drawing.Color.White;
            this.preview_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preview_txt.ForeColor = System.Drawing.Color.White;
            this.preview_txt.Location = new System.Drawing.Point(482, 70);
            this.preview_txt.Name = "preview_txt";
            this.preview_txt.Size = new System.Drawing.Size(397, 391);
            this.preview_txt.TabIndex = 4;
            this.preview_txt.Text = "";
            // 
            // general_lbl
            // 
            this.general_lbl.AutoSize = true;
            this.general_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.general_lbl.ForeColor = System.Drawing.Color.Silver;
            this.general_lbl.Location = new System.Drawing.Point(21, 55);
            this.general_lbl.Name = "general_lbl";
            this.general_lbl.Size = new System.Drawing.Size(49, 18);
            this.general_lbl.TabIndex = 6;
            this.general_lbl.Text = "Genel";
            // 
            // special_lbl
            // 
            this.special_lbl.AutoSize = true;
            this.special_lbl.Font = new System.Drawing.Font("Wanted Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.special_lbl.ForeColor = System.Drawing.Color.Silver;
            this.special_lbl.Location = new System.Drawing.Point(18, 210);
            this.special_lbl.Name = "special_lbl";
            this.special_lbl.Size = new System.Drawing.Size(89, 18);
            this.special_lbl.TabIndex = 9;
            this.special_lbl.Text = "Özel Amaçlı";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.apply_btn);
            this.backgroundPanel.Controls.Add(this.letter_btn);
            this.backgroundPanel.Controls.Add(this.special_lbl);
            this.backgroundPanel.Controls.Add(this.article_btn);
            this.backgroundPanel.Controls.Add(this.general_lbl);
            this.backgroundPanel.Controls.Add(this.basic_btn);
            this.backgroundPanel.Controls.Add(this.default_btn);
            this.backgroundPanel.Controls.Add(this.modern_btn);
            this.backgroundPanel.Location = new System.Drawing.Point(-9, 44);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(911, 433);
            this.backgroundPanel.TabIndex = 13;
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.apply_btn.BorderColor = System.Drawing.Color.White;
            this.apply_btn.BorderRadius = 15;
            this.apply_btn.BorderSize = 0;
            this.apply_btn.FlatAppearance.BorderSize = 0;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apply_btn.ForeColor = System.Drawing.Color.White;
            this.apply_btn.Location = new System.Drawing.Point(21, 361);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(173, 55);
            this.apply_btn.TabIndex = 12;
            this.apply_btn.Text = "Uygula";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // letter_btn
            // 
            this.letter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.letter_btn.BorderColor = System.Drawing.Color.White;
            this.letter_btn.BorderRadius = 15;
            this.letter_btn.BorderSize = 0;
            this.letter_btn.FlatAppearance.BorderSize = 0;
            this.letter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letter_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.letter_btn.ForeColor = System.Drawing.Color.White;
            this.letter_btn.Location = new System.Drawing.Point(200, 240);
            this.letter_btn.Name = "letter_btn";
            this.letter_btn.Size = new System.Drawing.Size(173, 55);
            this.letter_btn.TabIndex = 11;
            this.letter_btn.Text = "İş Mektubu";
            this.letter_btn.UseVisualStyleBackColor = false;
            this.letter_btn.Click += new System.EventHandler(this.letter_btn_Click);
            // 
            // article_btn
            // 
            this.article_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.article_btn.BorderColor = System.Drawing.Color.White;
            this.article_btn.BorderRadius = 15;
            this.article_btn.BorderSize = 0;
            this.article_btn.FlatAppearance.BorderSize = 0;
            this.article_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.article_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.article_btn.ForeColor = System.Drawing.Color.White;
            this.article_btn.Location = new System.Drawing.Point(21, 240);
            this.article_btn.Name = "article_btn";
            this.article_btn.Size = new System.Drawing.Size(173, 55);
            this.article_btn.TabIndex = 10;
            this.article_btn.Text = "Makale";
            this.article_btn.UseVisualStyleBackColor = false;
            this.article_btn.Click += new System.EventHandler(this.article_btn_Click);
            // 
            // basic_btn
            // 
            this.basic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.basic_btn.BorderColor = System.Drawing.Color.White;
            this.basic_btn.BorderRadius = 15;
            this.basic_btn.BorderSize = 0;
            this.basic_btn.FlatAppearance.BorderSize = 0;
            this.basic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basic_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basic_btn.ForeColor = System.Drawing.Color.White;
            this.basic_btn.Location = new System.Drawing.Point(200, 76);
            this.basic_btn.Name = "basic_btn";
            this.basic_btn.Size = new System.Drawing.Size(173, 55);
            this.basic_btn.TabIndex = 7;
            this.basic_btn.Text = "Basit";
            this.basic_btn.UseVisualStyleBackColor = false;
            this.basic_btn.Click += new System.EventHandler(this.basic_btn_Click);
            // 
            // default_btn
            // 
            this.default_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.default_btn.BorderColor = System.Drawing.Color.White;
            this.default_btn.BorderRadius = 15;
            this.default_btn.BorderSize = 0;
            this.default_btn.FlatAppearance.BorderSize = 0;
            this.default_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.default_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.default_btn.ForeColor = System.Drawing.Color.White;
            this.default_btn.Location = new System.Drawing.Point(21, 137);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(173, 55);
            this.default_btn.TabIndex = 8;
            this.default_btn.Text = "Varsayılan";
            this.default_btn.UseVisualStyleBackColor = false;
            this.default_btn.Click += new System.EventHandler(this.default_btn_Click);
            // 
            // modern_btn
            // 
            this.modern_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.modern_btn.BorderColor = System.Drawing.Color.White;
            this.modern_btn.BorderRadius = 15;
            this.modern_btn.BorderSize = 0;
            this.modern_btn.FlatAppearance.BorderSize = 0;
            this.modern_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modern_btn.Font = new System.Drawing.Font("Wanted Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modern_btn.ForeColor = System.Drawing.Color.White;
            this.modern_btn.Location = new System.Drawing.Point(21, 76);
            this.modern_btn.Name = "modern_btn";
            this.modern_btn.Size = new System.Drawing.Size(173, 55);
            this.modern_btn.TabIndex = 5;
            this.modern_btn.Text = "Modern";
            this.modern_btn.UseVisualStyleBackColor = false;
            this.modern_btn.Click += new System.EventHandler(this.modern_btn_Click);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.topMenu.BorderColor = System.Drawing.Color.White;
            this.topMenu.BorderRadius = 0;
            this.topMenu.BorderSize = 0;
            this.topMenu.Controls.Add(this.title_lbl);
            this.topMenu.Controls.Add(this.logo_img);
            this.topMenu.Controls.Add(this.close_btn);
            this.topMenu.ForeColor = System.Drawing.Color.White;
            this.topMenu.Location = new System.Drawing.Point(-9, -4);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(905, 66);
            this.topMenu.TabIndex = 3;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            this.topMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseMove);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Wanted Sans SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title_lbl.Location = new System.Drawing.Point(142, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(154, 21);
            this.title_lbl.TabIndex = 6;
            this.title_lbl.Text = "| Belge Şablonları";
            // 
            // logo_img
            // 
            this.logo_img.Image = ((System.Drawing.Image)(resources.GetObject("logo_img.Image")));
            this.logo_img.Location = new System.Drawing.Point(-16, 9);
            this.logo_img.Name = "logo_img";
            this.logo_img.Size = new System.Drawing.Size(194, 50);
            this.logo_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_img.TabIndex = 5;
            this.logo_img.TabStop = false;
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
            this.close_btn.Location = new System.Drawing.Point(855, 19);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 30);
            this.close_btn.TabIndex = 2;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(890, 472);
            this.Controls.Add(this.preview_txt);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "opentypr - Şablonlar";
            this.Load += new System.EventHandler(this.templates_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Modules.CustomButtons close_btn;
        private Modules.CustomPanels topMenu;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox logo_img;
        private System.Windows.Forms.RichTextBox preview_txt;
        private Modules.CustomButtons modern_btn;
        private System.Windows.Forms.Label general_lbl;
        private Modules.CustomButtons basic_btn;
        private Modules.CustomButtons default_btn;
        private System.Windows.Forms.Label special_lbl;
        private Modules.CustomButtons letter_btn;
        private Modules.CustomButtons article_btn;
        private Modules.CustomButtons apply_btn;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}