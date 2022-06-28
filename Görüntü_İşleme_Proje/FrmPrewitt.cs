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
    public partial class FrmPrewitt : Form
    {
        public FrmPrewitt()
        {
            InitializeComponent();
        }

        private void BtnSıfırla_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Visible = false;
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

        private void BtnPrewittFiltre_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

                int SablonBoyutu = 3;
                int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                int x, y;
                Color Renk;
                int P1, P2, P3, P4, P5, P6, P7, P8, P9;
                for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                {
                    for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                    {
                        Renk = GirisResmi.GetPixel(x - 1, y - 1);
                        P1 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x, y - 1);
                        P2 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x + 1, y - 1);
                        P3 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x - 1, y);
                        P4 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x, y);
                        P5 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x + 1, y);
                        P6 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x - 1, y + 1);
                        P7 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x, y + 1);
                        P8 = (Renk.R + Renk.G + Renk.B) / 3;
                        Renk = GirisResmi.GetPixel(x + 1, y + 1);
                        P9 = (Renk.R + Renk.G + Renk.B) / 3;
                        int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9);
                        int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9);
                        int PrewittDegeri = 0;
                        PrewittDegeri = Gx;
                        PrewittDegeri = Gy;
                        PrewittDegeri = Gx + Gy;
                        if (PrewittDegeri > 255) PrewittDegeri = 255;
                        CikisResmi.SetPixel(x, y, Color.FromArgb(PrewittDegeri, PrewittDegeri, PrewittDegeri));
                    }
                }
                pictureBox2.Image = CikisResmi;
                pictureBox3.Visible = true;
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
