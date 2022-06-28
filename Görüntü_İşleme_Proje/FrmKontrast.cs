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
    public partial class FrmKontrast : Form
    {
        public FrmKontrast()
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
            TxtKontrastDegeri.Text = "";
            pictureBox3.Visible = false;
        }

        private void BtnKontrast_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TxtKontrastDegeri.Text != "")
                {
                    int R = 0, G = 0, B = 0;
                    Color OkunanRenk, DonusenRenk;
                    Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.
                    double C_KontrastSeviyesi = Convert.ToInt32(TxtKontrastDegeri.Text);
                    double F_KontrastFaktoru = (259 * (C_KontrastSeviyesi + 255)) / (255 * (259 - C_KontrastSeviyesi));
                    for (int x = 0; x < ResimGenisligi; x++)
                    {
                        for (int y = 0; y < ResimYuksekligi; y++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x, y);
                            R = OkunanRenk.R;
                            G = OkunanRenk.G;
                            B = OkunanRenk.B;
                            R = (int)((F_KontrastFaktoru * (R - 128)) + 128);
                            G = (int)((F_KontrastFaktoru * (G - 128)) + 128);
                            B = (int)((F_KontrastFaktoru * (B - 128)) + 128);
                            //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                            if (R > 255) R = 255;
                            if (G > 255) G = 255;
                            if (B > 255) B = 255;
                            if (R < 0) R = 0;
                            if (G < 0) G = 0;
                            if (B < 0) B = 0;
                            DonusenRenk = Color.FromArgb(R, G, B);
                            CikisResmi.SetPixel(x, y, DonusenRenk);
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                    pictureBox3.Visible = true;
                }
                else 
                {
                    MessageBox.Show("Lütfen Bir Kontrast Değeri Girin !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçiniz !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
