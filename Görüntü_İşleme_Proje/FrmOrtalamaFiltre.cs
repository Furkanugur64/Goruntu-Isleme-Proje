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
    public partial class FrmOrtalamaFiltre : Form
    {
        public FrmOrtalamaFiltre()
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
            comboBox1.SelectedIndex = -1;
        }

        private void BtnOrtFiltre_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) 
            {
                if (comboBox1.Text != "") 
                {
                    Color OkunanRenk;
                    Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int ResimGenisligi = GirisResmi.Width;
                    int ResimYuksekligi = GirisResmi.Height;
                    CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                    int SablonBoyutu = Convert.ToInt32(comboBox1.Text);  
                    int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                    for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                    {
                        for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                        {
                            toplamR = 0; toplamG = 0; toplamB = 0;
                            for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                            {
                                for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                {
                                    OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                    toplamR = toplamR + OkunanRenk.R; toplamG = toplamG + OkunanRenk.G; toplamB = toplamB + OkunanRenk.B;
                                }
                            }
                            ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                            ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                            ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                            CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                    pictureBox3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Lütfen Filtreleme Değeri Seçin!!", "Görüntü İşleme Proje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
