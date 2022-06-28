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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void Pictureboxexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGriTon_Click(object sender, EventArgs e)
        {
            FrmGriTon gri = new FrmGriTon();
            gri.Show();
            this.Hide();
        }

        private void BtnParlaklik_Click(object sender, EventArgs e)
        {
            FrmParlaklik fr = new FrmParlaklik();
            fr.Show();
            this.Hide();
        }

        private void BtnEsikleme_Click(object sender, EventArgs e)
        {
            FrmEsikleme esik = new FrmEsikleme();
            esik.Show();
            this.Hide();
        }

        private void BtnHistogram_Click(object sender, EventArgs e)
        {
            FrmHistogram hs = new FrmHistogram();
            hs.Show();
            this.Hide();
        }

        private void BtnKontrast_Click(object sender, EventArgs e)
        {
            FrmKontrast kon = new FrmKontrast();
            kon.Show();
            this.Hide();
        }

        private void BtnTasima_Click(object sender, EventArgs e)
        {
            FrmTasima tasi = new FrmTasima();
            tasi.Show();
            this.Hide();
        }

        private void BtnAynalama_Click(object sender, EventArgs e)
        {
            FrmAynalama ayn = new FrmAynalama();
            ayn.Show();
            this.Hide();
        }

        private void BtnNegatif_Click(object sender, EventArgs e)
        {
            FrmNegatifAlma fr = new FrmNegatifAlma();
            fr.Show();
            this.Hide();
        }

        private void BtnEgme_Click(object sender, EventArgs e)
        {
            FrmEgme egme = new FrmEgme();
            egme.Show();
            this.Hide();
        }

        private void FrmDondur_Click(object sender, EventArgs e)
        {
            FrmDondurma fr = new FrmDondurma();
            fr.Show();
            this.Hide();
        }

        private void BtnPersfektif_Click(object sender, EventArgs e)
        {
            FrmPersfektif fr = new FrmPersfektif();

            fr.Show();
            this.Hide();
        }

        private void FrmOrtFiltre_Click(object sender, EventArgs e)
        {
            FrmOrtalamaFiltre fr = new FrmOrtalamaFiltre();
            fr.Show();
            this.Hide();
        }

        private void BtnMedianFiltre_Click(object sender, EventArgs e)
        {
            FrmMedyanFiltresi medyan = new FrmMedyanFiltresi();
            medyan.Show();
            this.Hide();
        }

        private void BtnKonvolüsyon_Click(object sender, EventArgs e)
        {
            FrmKonvolüsyon fr = new FrmKonvolüsyon();
            fr.Show();
            this.Hide();
                 
        }

        private void BtnSobelFiltresi_Click(object sender, EventArgs e)
        {
            FrmSobelFiltresi sb = new FrmSobelFiltresi();
            sb.Show();
            this.Hide();
        }

        private void BtnPrewitt_Click(object sender, EventArgs e)
        {
            FrmPrewitt fr = new FrmPrewitt();
            fr.Show();
            this.Hide();
        }

        private void BtnRobert_Click(object sender, EventArgs e)
        {
            FrmRobertCross rb = new FrmRobertCross();
            rb.Show();
            this.Hide();
        }

        private void BtnMorfolojik_Click(object sender, EventArgs e)
        {
            FrmMorfolojik fr = new FrmMorfolojik();
            fr.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            FrmZoom zoom = new FrmZoom();
            zoom.Show(); 
            this.Hide();
        }
    }
}
