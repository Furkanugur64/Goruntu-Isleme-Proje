using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_İşleme_Proje
{
    public partial class FrmHistogram : Form
    {
        public FrmHistogram()
        {
            InitializeComponent();
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }

        private void BtnSıfırla_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            listBox1.Items.Clear();
            BtnHistogram.Enabled = false;
            pictureBox3.Visible = false;

        }

        private void BtnHistogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ArrayList DiziPiksel = new ArrayList();
                int OrtalamaRenk = 0; Color OkunanRenk;
                int R = 0, G = 0, B = 0; Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                int i = 0; //piksel sayısı tutulacak.
                for (int x = 0; x < GirisResmi.Width; x++)
                {
                    for (int y = 0; y < GirisResmi.Height; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                        DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor.
                    }
                }
                int[] DiziPikselSayilari = new int[256];
                for (int r = 0; r <= 255; r++) //256 tane renk tonu için dönecek.
                {
                    int PikselSayisi = 0;
                    for (int s = 0; s < DiziPiksel.Count; s++)  //resimdeki piksel sayısınca dönecek.
                    {
                        if (r == Convert.ToInt16(DiziPiksel[s])) PikselSayisi++;
                    }
                    DiziPikselSayilari[r] = PikselSayisi;
                }

                //Değerleri listbox'a ekliyor. 
                int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak.
                for (int k = 0; k <= 255; k++)
                {
                    listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]); //Maksimum piksel sayısını bulmaya çalışıyor. 
                    if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                    {
                        RenkMaksPikselSayisi = DiziPikselSayilari[k];
                    }
                }

                //Grafiği çiziyor.
                Graphics CizimAlani; 
                Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
                Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
                CizimAlani = pictureBox2.CreateGraphics();
                pictureBox3.Visible = true;
                pictureBox2.Refresh(); 
                int GrafikYuksekligi = 300;
                double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
                double OlcekX = 1.5;
                int X_kaydirma = 10;
                for (int x = 0; x <= 255; x++)
                {
                    if (x % 50 == 0)
                        CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                        CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                    //Dikey kırmızı çizgiler.
                }
                LblHistogram.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();

            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGriTon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
                int ResimYuksekligi = GirisResmi.Height;
                Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.
                int GriDeger = 0;
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        double R = OkunanRenk.R;
                        double G = OkunanRenk.G;
                        double B = OkunanRenk.B;
                        //GriDeger = Convert.ToInt16((R + G + B) / 3);
                        GriDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                        DonusenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                    }
                }
                pictureBox1.Image = CikisResmi;
                BtnHistogram.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();
        }
    }
}
