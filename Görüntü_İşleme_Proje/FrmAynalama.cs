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
    public partial class FrmAynalama : Form
    {
        public FrmAynalama()
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
            TxtX.Text = "";
            pictureBox3.Visible = false;
        }

        private void BtnAynalama_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TxtX.Text != "")
                {
                    Color OkunanRenk;
                    Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width;
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                    double Aci = Convert.ToDouble(TxtX.Text);
                    double RadyanAci = Aci * 2 * Math.PI / 360;
                    double x2 = 0, y2 = 0;
                    //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
                    int x0 = ResimGenisligi / 2;
                    int y0 = ResimYuksekligi / 2;
                    for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                    {
                        for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x1, y1);
                            //----A-Orta dikey eksen etrafında aynalama ---------------- //
                            // x2 = Convert.ToInt16(-x1 + 2 * x0);
                            //  y2 = Convert.ToInt16(y1);
                            //----B-Orta yatay eksen etrafında aynalama ---------------- //
                            // x2 = Convert.ToInt16(x1);
                            //  y2 = Convert.ToInt16(-y1 + 2 * y0);
                            //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama---------- 
                            double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                            x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                            y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                            if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                                CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                    pictureBox3.Visible = true;
                }
                else 
                {
                    MessageBox.Show("Lütfen Aynalama Değeri Girin !!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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
