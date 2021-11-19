namespace YouTube_Video_Downloader
{
    partial class YouTubeVideoİndirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeVideoİndirme));
            this.lblYazı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.radMP3 = new System.Windows.Forms.RadioButton();
            this.radMP4 = new System.Windows.Forms.RadioButton();
            this.btnİndir = new System.Windows.Forms.Button();
            this.YüklemeBarı = new System.Windows.Forms.ProgressBar();
            this.lblİsim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYazı
            // 
            this.lblYazı.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYazı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYazı.Location = new System.Drawing.Point(0, 0);
            this.lblYazı.Name = "lblYazı";
            this.lblYazı.Size = new System.Drawing.Size(876, 25);
            this.lblYazı.TabIndex = 0;
            this.lblYazı.Text = "YouTube MP3/MP4 Video Downloader";
            this.lblYazı.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Linki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format Türü:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(161, 53);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(596, 31);
            this.txtLink.TabIndex = 3;
            // 
            // radMP3
            // 
            this.radMP3.AutoSize = true;
            this.radMP3.Location = new System.Drawing.Point(177, 120);
            this.radMP3.Name = "radMP3";
            this.radMP3.Size = new System.Drawing.Size(80, 29);
            this.radMP3.TabIndex = 4;
            this.radMP3.TabStop = true;
            this.radMP3.Text = "MP3";
            this.radMP3.UseVisualStyleBackColor = true;
            this.radMP3.CheckedChanged += new System.EventHandler(this.radMP3_CheckedChanged);
            // 
            // radMP4
            // 
            this.radMP4.AutoSize = true;
            this.radMP4.Location = new System.Drawing.Point(263, 120);
            this.radMP4.Name = "radMP4";
            this.radMP4.Size = new System.Drawing.Size(81, 29);
            this.radMP4.TabIndex = 5;
            this.radMP4.TabStop = true;
            this.radMP4.Text = "MP4";
            this.radMP4.UseVisualStyleBackColor = true;
            this.radMP4.CheckedChanged += new System.EventHandler(this.radMP4_CheckedChanged);
            // 
            // btnİndir
            // 
            this.btnİndir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnİndir.Location = new System.Drawing.Point(0, 389);
            this.btnİndir.Name = "btnİndir";
            this.btnİndir.Size = new System.Drawing.Size(876, 36);
            this.btnİndir.TabIndex = 7;
            this.btnİndir.Text = "İndir";
            this.btnİndir.UseVisualStyleBackColor = true;
            this.btnİndir.Click += new System.EventHandler(this.btnİndir_Click);
            // 
            // YüklemeBarı
            // 
            this.YüklemeBarı.BackColor = System.Drawing.Color.Gray;
            this.YüklemeBarı.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YüklemeBarı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YüklemeBarı.Location = new System.Drawing.Point(0, 352);
            this.YüklemeBarı.Name = "YüklemeBarı";
            this.YüklemeBarı.Size = new System.Drawing.Size(876, 37);
            this.YüklemeBarı.TabIndex = 8;
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblİsim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblİsim.ForeColor = System.Drawing.Color.Cyan;
            this.lblİsim.Location = new System.Drawing.Point(0, 325);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(2, 27);
            this.lblİsim.TabIndex = 9;
            // 
            // YouTubeVideoİndirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(876, 425);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.YüklemeBarı);
            this.Controls.Add(this.radMP4);
            this.Controls.Add(this.radMP3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnİndir);
            this.Controls.Add(this.lblYazı);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "YouTubeVideoİndirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Video İndirme";
            this.Load += new System.EventHandler(this.YouTubeVideoİndirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton radMP3;
        private System.Windows.Forms.RadioButton radMP4;
        private System.Windows.Forms.Button btnİndir;
        private System.Windows.Forms.ProgressBar YüklemeBarı;
        private System.Windows.Forms.Label lblİsim;
    }
}

