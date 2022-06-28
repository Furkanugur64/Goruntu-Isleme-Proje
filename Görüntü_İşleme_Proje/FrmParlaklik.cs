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
    public partial class FrmParlaklik : Form
    {
        public FrmParlaklik()
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


        private void BtnParlaklik_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int R = 0, G = 0, B = 0;
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);

                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

                int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    j = 0;
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        R = OkunanRenk.R + 50;
                        G = OkunanRenk.G + 50;
                        B = OkunanRenk.B + 50;
                        if (R > 255)
                            R = 255;
                        if (G > 255)
                            G = 255;
                        if (B > 255)
                            B = 255;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(i, j, DonusenRenk); j++;
                    }
                    i++;
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
