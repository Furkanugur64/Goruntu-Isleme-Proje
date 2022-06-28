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
    public partial class FrmNegatifAlma : Form
    {
        public FrmNegatifAlma()
        {
            InitializeComponent();
        }

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void BtnNegatifAl_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null) 
            {
                Color OkunanRenk, DonusenRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.
                int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        R = 255 - OkunanRenk.R;
                        G = 255 - OkunanRenk.G;
                        B = 255 - OkunanRenk.B;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
