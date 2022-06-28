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
    public partial class FrmEsikleme : Form
    {
        public FrmEsikleme()
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
            catch 
            {
            }
        }

        private void BtnSıfırla_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Visible = false;
        }

        private void BtnEsikle_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image!=null)
            {
                if (TxtEsiklemeDegeri.Text != "" ) 
                {
                    try
                    {
                        int R = 0, G = 0, B = 0;
                        Color OkunanRenk, DonusenRenk;
                        Bitmap GirisResmi, CikisResmi;
                        GirisResmi = new Bitmap(pictureBox1.Image);

                        int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                        int ResimYuksekligi = GirisResmi.Height;
                        CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.
                        int EsiklemeDegeri = Convert.ToInt32(TxtEsiklemeDegeri.Text);

                        for (int x = 0; x < ResimGenisligi; x++)
                        {
                            for (int y = 0; y < ResimYuksekligi; y++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x, y);
                                if (OkunanRenk.R >= EsiklemeDegeri)
                                    R = 255;
                                else
                                    R = 0;
                                if (OkunanRenk.G >= EsiklemeDegeri)
                                    G = 255;
                                else
                                    G = 0;
                                if (OkunanRenk.B >= EsiklemeDegeri)
                                    B = 255;
                                else
                                    B = 0;
                                DonusenRenk = Color.FromArgb(R, G, B);
                                CikisResmi.SetPixel(x, y, DonusenRenk);
                            }
                        }
                        pictureBox2.Image = CikisResmi;
                        pictureBox3.Visible = true;
                    }
                    catch
                    {                       
                    }
                   
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
    }
}
