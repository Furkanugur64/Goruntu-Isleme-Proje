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
    public partial class FrmKonvolüsyon : Form
    {
        public FrmKonvolüsyon()
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
            pictureBox3.Visible = false;
                
        }

        private void BtnKonvolüsyon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int SablonBoyutu = 3;
                int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                int x, y, i, j, toplamR, toplamG, toplamB;
                int R, G, B;
                int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
                int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;

                for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                {
                    for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;
                        int k = 0;
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                toplamR = toplamR + OkunanRenk.R * Matris[k];
                                toplamG = toplamG + OkunanRenk.G * Matris[k];
                                toplamB = toplamB + OkunanRenk.B * Matris[k];
                                k++;
                            }
                        }
                        R = toplamR / MatrisToplami;
                        G = toplamG / MatrisToplami;
                        B = toplamB / MatrisToplami;
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
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
