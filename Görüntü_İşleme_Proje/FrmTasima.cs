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
    public partial class FrmTasima : Form
    {
        public FrmTasima()
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

        private void BtnTasima_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TxtX.Text != "" && TxtY.Text != "")
                {
                    Color OkunanRenk; Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width;
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                    double x2 = 0, y2 = 0;
                    //Taşıma mesafelerini atıyor.
                    int Tx = Convert.ToInt32( TxtX.Text);
                    int Ty = Convert.ToInt32( TxtY.Text);
                    for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                    {
                        for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x1, y1);
                            x2 = x1 + Tx;
                            y2 = y1 + Ty;
                            if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                            {
                                CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                            }
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                    pictureBox3.Visible = true;
                }
                else 
                {
                    MessageBox.Show("Lütfen Taşıma Değerlerini Girin !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
