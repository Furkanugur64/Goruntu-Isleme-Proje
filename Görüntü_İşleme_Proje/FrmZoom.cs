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
    public partial class FrmZoom : Form
    {
        public FrmZoom()
        {
            InitializeComponent();
        }
        PictureBox org;
        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
               if(openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    org = new PictureBox();
                    org.Load(openFileDialog1.FileName);
                    pictureBox1.Load(openFileDialog1.FileName);
                }
                
            }
            catch { }
        }

        private void BtnSıfırla_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;            
        }

        

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            FrmAnaForm ana = new FrmAnaForm();
            ana.Show();
            this.Hide();
        }
       
        Image ZoomPicture(Image img,Size size) 
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        


        private void FrmZoom_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox1.Image;


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0) 
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }
    }
}
