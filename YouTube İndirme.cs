using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MediaToolkit;
using VideoLibrary;

namespace YouTube_Video_Downloader
{
    public partial class YouTubeVideoİndirme : Form
    {
        Boolean Format = true;
        // True = mp3, False = mp4
        public YouTubeVideoİndirme()
        {
            InitializeComponent();
        }

        private void YouTubeVideoİndirme_Load(object sender, EventArgs e)
        {
            YüklemeBarı.Visible = false;
            radMP3.Checked = true;
        }

        private async void btnİndir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog İndirme = new FolderBrowserDialog() { Description = "Lütfen indirmek için dosya seçiniz." })
            {
                if (İndirme.ShowDialog() == DialogResult.OK)
                {
                    if (txtLink.Text != "")
                    {
                        GetTitle();
                        MessageBox.Show("İndirme işlemi başladı. Lütfen bekleyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnİndir.Enabled = Convert.ToBoolean(0);
                        var youtube = YouTube.Default;
                        var video = await youtube.GetVideoAsync(txtLink.Text);
                        File.WriteAllBytes(İndirme.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());
                        var GirişDosyası = new MediaToolkit.Model.MediaFile { Filename = İndirme.SelectedPath + @"\" + video.FullName };
                        var ÇıkışDosyası = new MediaToolkit.Model.MediaFile { Filename = $"{İndirme.SelectedPath + @"\" + video.FullName}.mp3" };
                        using(var Enging = new Engine())
                        {
                            Enging.GetMetadata(GirişDosyası);
                            Enging.Convert(GirişDosyası, ÇıkışDosyası);
                        }
                        if (Format == true)
                        {
                            File.Delete(İndirme.SelectedPath + @"\" + video.FullName);
                        }
                        else
                        {
                            File.Delete($"{İndirme.SelectedPath + @"\" + video.FullName}.mp3");
                        }
                        YüklemeBarı.Visible = true;
                        YüklemeBarı.Value = 100;
                        btnİndir.Enabled = Convert.ToBoolean(1);
                        MessageBox.Show("İndirme işlemi bitti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YüklemeBarı.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Link kısmı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dosya yolu seçmeden işlem yapamazsınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void radMP3_CheckedChanged(object sender, EventArgs e)
        {
            Format = true;
        }
        private void radMP4_CheckedChanged(object sender, EventArgs e)
        {
            Format = false;
        }
        void GetTitle()
        {
            WebRequest İstemci = HttpWebRequest.Create(txtLink.Text);
            WebResponse Yanıt;
            Yanıt = İstemci.GetResponse();
            StreamReader stream = new StreamReader(Yanıt.GetResponseStream());
            string Gelen = stream.ReadToEnd();
            int Başlangıç = Gelen.IndexOf("<title>") + 7;
            int Bitiş = Gelen.Substring(Başlangıç).IndexOf("</title>");
            string GelenBilgi = Gelen.Substring(Başlangıç, Bitiş);
            lblİsim.Text = (GelenBilgi);
        }
    }
}
