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
    public partial class FrmMedyanFiltresi : Form
    {
        public FrmMedyanFiltresi()
        {
            InitializeComponent();
        }

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();
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
            pictureBox3.Visible = false;
        }

        private void BtnMedyanFiltre_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TxtMeydanFiltre.Text != "")
                {
                    Color OkunanRenk;
                    Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width;
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                    int SablonBoyutu = Convert.ToInt32(TxtMeydanFiltre.Text);

                    int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                    int[] R = new int[ElemanSayisi];
                    int[] G = new int[ElemanSayisi];
                    int[] B = new int[ElemanSayisi];
                    int[] Gri = new int[ElemanSayisi];
                    int x, y, i, j;

                    for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                    {
                        for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                        { //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                            int k = 0;
                            for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                            {
                                for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                {
                                    OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                    R[k] = OkunanRenk.R; G[k] = OkunanRenk.G; B[k] = OkunanRenk.B;
                                    Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114);
                                    k++;
                                }
                            }
                            int GeciciSayi = 0;
                            for (i = 0; i < ElemanSayisi; i++)
                            {
                                for (j = i + 1; j < ElemanSayisi; j++)
                                {
                                    if (Gri[j] < Gri[i])
                                    {
                                        GeciciSayi = Gri[i]; Gri[i] = Gri[j]; Gri[j] = GeciciSayi;
                                        GeciciSayi = R[i]; R[i] = R[j]; R[j] = GeciciSayi;
                                        GeciciSayi = G[i]; G[i] = G[j]; G[j] = GeciciSayi;
                                        GeciciSayi = B[i]; B[i] = B[j]; B[j] = GeciciSayi;
                                    }
                                }
                            }
                            CikisResmi.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) / 2], B[(ElemanSayisi - 1) / 2]));
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                    pictureBox3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Filtre Değeri Giriniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}