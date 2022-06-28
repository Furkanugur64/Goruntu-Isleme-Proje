using System;
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
    public partial class FrmMorfolojik : Form
    {
        public FrmMorfolojik()
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
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Visible = false;
        }

        private void BtnPrewittFiltre_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TxtEsiklemeDegeri.Text != "")
                {
                    Color OkunanRenk;
                    Bitmap GirisResmi, CikisResmi;
                    Bitmap OrjinalResim, GenislemisResim;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width;
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                    Bitmap SiyahBeyazResim = ResmiGriTonaDonusturEsiklemeYap(GirisResmi);

                    pictureBox2.Image = SiyahBeyazResim;
                    pictureBox5.Visible = true;
                    GirisResmi = SiyahBeyazResim;
                    int x, y, i, j;
                    int SablonBoyutu = 3;
                    int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                    for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                    {
                        for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                        {
                            bool RenkSiyah = false;
                            for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                            {
                                for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                {
                                    OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                    if (OkunanRenk.R < 128) //Siyah ise
                                        RenkSiyah = true;
                                }
                            }
                            if (RenkSiyah == true) //Komşularda siyah varsa
                            {
                                Color KendiRengi = GirisResmi.GetPixel(x, y);
                                if (KendiRengi.R > 128)
                                {//kendi rengin beyaz ise onu da siyah yap.
                                    CikisResmi.SetPixel(x, y, Color.FromArgb(255, 0, 0)); //siyah yerine kırmızı kullandık.Genişleyen bölgeyi görmek için
                                }
                            }
                            else //komşularda siyah yok ise kendi rengi yine aynı beyaz kalmalı.
                            {
                                CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                    pictureBox3.Image = CikisResmi;
                    SiyahBeyazResim = new Bitmap(pictureBox2.Image);
                    GenislemisResim = new Bitmap(pictureBox3.Image);
                    Bitmap KenarGoruntuResmi = OrjinalResimdenGenislemisResmiCikar(SiyahBeyazResim, GenislemisResim);
                    pictureBox4.Image = KenarGoruntuResmi;
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Eşikleme Değeri Girin !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Bitmap ResmiGriTonaDonusturEsiklemeYap(Bitmap GirisResmi)
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap CikisResmi;
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor.Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            int R = 0, G = 0, B = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    int Gri = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    int Esikleme = 0;
                    try
                    {
                        Esikleme = Convert.ToInt16(TxtEsiklemeDegeri.Text);
                    }
                    catch
                    {
                        Esikleme = 128;
                    }
                    //Esikleme kısmı
                    if (Gri > Esikleme)
                        Gri = 255;
                    else
                        Gri = 0;
                    DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }
        public Bitmap OrjinalResimdenGenislemisResmiCikar(Bitmap SiyahBeyazResim, Bitmap GenislemisResim)
        {
            Bitmap CikisResmi;
            int ResimGenisligi = SiyahBeyazResim.Width;
            int ResimYuksekligi = SiyahBeyazResim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int x, y;
            int Fark;
            for (x = 0; x < ResimGenisligi; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardaniçeride başlayacak ve bitirecek.
            {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    Color OrjinalRenk = SiyahBeyazResim.GetPixel(x, y);
                    Color GenislemisResimRenk = GenislemisResim.GetPixel(x, y);
                    int OrjinalGri = (OrjinalRenk.R + OrjinalRenk.G + OrjinalRenk.B) / 3;
                    int GenislemisGri = (GenislemisResimRenk.R + GenislemisResimRenk.G +
                    GenislemisResimRenk.B) / 3;
                    Fark = Math.Abs(OrjinalGri - GenislemisGri);
                    CikisResmi.SetPixel(x, y, Color.FromArgb(Fark, Fark, Fark));
                }
            }
            return CikisResmi;
        }

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();
        }
    }
}
