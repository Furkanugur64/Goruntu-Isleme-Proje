
namespace Görüntü_İşleme_Proje
{
    partial class FrmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.BtnNegatif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGriTon = new System.Windows.Forms.Button();
            this.BtnParlaklik = new System.Windows.Forms.Button();
            this.BtnEsikleme = new System.Windows.Forms.Button();
            this.BtnHistogram = new System.Windows.Forms.Button();
            this.BtnKontrast = new System.Windows.Forms.Button();
            this.BtnTasima = new System.Windows.Forms.Button();
            this.BtnAynalama = new System.Windows.Forms.Button();
            this.FrmOrtFiltre = new System.Windows.Forms.Button();
            this.BtnPersfektif = new System.Windows.Forms.Button();
            this.FrmDondur = new System.Windows.Forms.Button();
            this.BtnEgme = new System.Windows.Forms.Button();
            this.BtnMedianFiltre = new System.Windows.Forms.Button();
            this.BtnKonvolüsyon = new System.Windows.Forms.Button();
            this.BtnSobelFiltresi = new System.Windows.Forms.Button();
            this.BtnPrewitt = new System.Windows.Forms.Button();
            this.BtnRobert = new System.Windows.Forms.Button();
            this.BtnMorfolojik = new System.Windows.Forms.Button();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNegatif
            // 
            this.BtnNegatif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnNegatif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNegatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNegatif.ForeColor = System.Drawing.Color.White;
            this.BtnNegatif.Location = new System.Drawing.Point(27, 66);
            this.BtnNegatif.Name = "BtnNegatif";
            this.BtnNegatif.Size = new System.Drawing.Size(162, 68);
            this.BtnNegatif.TabIndex = 147;
            this.BtnNegatif.Text = "Negatifini Alma";
            this.BtnNegatif.UseVisualStyleBackColor = false;
            this.BtnNegatif.Click += new System.EventHandler(this.BtnNegatif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 148;
            this.label1.Text = "GÖRÜNTÜ İŞLEME PROJE";
            // 
            // BtnGriTon
            // 
            this.BtnGriTon.BackColor = System.Drawing.Color.Blue;
            this.BtnGriTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGriTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGriTon.ForeColor = System.Drawing.Color.White;
            this.BtnGriTon.Location = new System.Drawing.Point(203, 66);
            this.BtnGriTon.Name = "BtnGriTon";
            this.BtnGriTon.Size = new System.Drawing.Size(162, 68);
            this.BtnGriTon.TabIndex = 149;
            this.BtnGriTon.Text = "Gri Ton ";
            this.BtnGriTon.UseVisualStyleBackColor = false;
            this.BtnGriTon.Click += new System.EventHandler(this.BtnGriTon_Click);
            // 
            // BtnParlaklik
            // 
            this.BtnParlaklik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnParlaklik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnParlaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnParlaklik.ForeColor = System.Drawing.Color.White;
            this.BtnParlaklik.Location = new System.Drawing.Point(379, 66);
            this.BtnParlaklik.Name = "BtnParlaklik";
            this.BtnParlaklik.Size = new System.Drawing.Size(162, 68);
            this.BtnParlaklik.TabIndex = 150;
            this.BtnParlaklik.Text = "Parlaklık";
            this.BtnParlaklik.UseVisualStyleBackColor = false;
            this.BtnParlaklik.Click += new System.EventHandler(this.BtnParlaklik_Click);
            // 
            // BtnEsikleme
            // 
            this.BtnEsikleme.BackColor = System.Drawing.Color.Blue;
            this.BtnEsikleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsikleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEsikleme.ForeColor = System.Drawing.Color.White;
            this.BtnEsikleme.Location = new System.Drawing.Point(555, 66);
            this.BtnEsikleme.Name = "BtnEsikleme";
            this.BtnEsikleme.Size = new System.Drawing.Size(162, 68);
            this.BtnEsikleme.TabIndex = 151;
            this.BtnEsikleme.Text = "Eşikleme";
            this.BtnEsikleme.UseVisualStyleBackColor = false;
            this.BtnEsikleme.Click += new System.EventHandler(this.BtnEsikleme_Click);
            // 
            // BtnHistogram
            // 
            this.BtnHistogram.BackColor = System.Drawing.Color.Blue;
            this.BtnHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHistogram.ForeColor = System.Drawing.Color.White;
            this.BtnHistogram.Location = new System.Drawing.Point(27, 152);
            this.BtnHistogram.Name = "BtnHistogram";
            this.BtnHistogram.Size = new System.Drawing.Size(162, 68);
            this.BtnHistogram.TabIndex = 152;
            this.BtnHistogram.Text = "Histogram";
            this.BtnHistogram.UseVisualStyleBackColor = false;
            this.BtnHistogram.Click += new System.EventHandler(this.BtnHistogram_Click);
            // 
            // BtnKontrast
            // 
            this.BtnKontrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnKontrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKontrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKontrast.ForeColor = System.Drawing.Color.White;
            this.BtnKontrast.Location = new System.Drawing.Point(203, 152);
            this.BtnKontrast.Name = "BtnKontrast";
            this.BtnKontrast.Size = new System.Drawing.Size(162, 68);
            this.BtnKontrast.TabIndex = 153;
            this.BtnKontrast.Text = "Kontrast";
            this.BtnKontrast.UseVisualStyleBackColor = false;
            this.BtnKontrast.Click += new System.EventHandler(this.BtnKontrast_Click);
            // 
            // BtnTasima
            // 
            this.BtnTasima.BackColor = System.Drawing.Color.Blue;
            this.BtnTasima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTasima.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTasima.ForeColor = System.Drawing.Color.White;
            this.BtnTasima.Location = new System.Drawing.Point(379, 152);
            this.BtnTasima.Name = "BtnTasima";
            this.BtnTasima.Size = new System.Drawing.Size(162, 68);
            this.BtnTasima.TabIndex = 154;
            this.BtnTasima.Text = "Taşıma";
            this.BtnTasima.UseVisualStyleBackColor = false;
            this.BtnTasima.Click += new System.EventHandler(this.BtnTasima_Click);
            // 
            // BtnAynalama
            // 
            this.BtnAynalama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAynalama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAynalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAynalama.ForeColor = System.Drawing.Color.White;
            this.BtnAynalama.Location = new System.Drawing.Point(555, 152);
            this.BtnAynalama.Name = "BtnAynalama";
            this.BtnAynalama.Size = new System.Drawing.Size(162, 68);
            this.BtnAynalama.TabIndex = 155;
            this.BtnAynalama.Text = "Aynalama";
            this.BtnAynalama.UseVisualStyleBackColor = false;
            this.BtnAynalama.Click += new System.EventHandler(this.BtnAynalama_Click);
            // 
            // FrmOrtFiltre
            // 
            this.FrmOrtFiltre.BackColor = System.Drawing.Color.Blue;
            this.FrmOrtFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmOrtFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FrmOrtFiltre.ForeColor = System.Drawing.Color.White;
            this.FrmOrtFiltre.Location = new System.Drawing.Point(556, 239);
            this.FrmOrtFiltre.Name = "FrmOrtFiltre";
            this.FrmOrtFiltre.Size = new System.Drawing.Size(162, 68);
            this.FrmOrtFiltre.TabIndex = 159;
            this.FrmOrtFiltre.Text = "Ortalama Filtresi";
            this.FrmOrtFiltre.UseVisualStyleBackColor = false;
            this.FrmOrtFiltre.Click += new System.EventHandler(this.FrmOrtFiltre_Click);
            // 
            // BtnPersfektif
            // 
            this.BtnPersfektif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPersfektif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersfektif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersfektif.ForeColor = System.Drawing.Color.White;
            this.BtnPersfektif.Location = new System.Drawing.Point(380, 239);
            this.BtnPersfektif.Name = "BtnPersfektif";
            this.BtnPersfektif.Size = new System.Drawing.Size(162, 68);
            this.BtnPersfektif.TabIndex = 158;
            this.BtnPersfektif.Text = "Persfektif";
            this.BtnPersfektif.UseVisualStyleBackColor = false;
            this.BtnPersfektif.Click += new System.EventHandler(this.BtnPersfektif_Click);
            // 
            // FrmDondur
            // 
            this.FrmDondur.BackColor = System.Drawing.Color.Blue;
            this.FrmDondur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FrmDondur.ForeColor = System.Drawing.Color.White;
            this.FrmDondur.Location = new System.Drawing.Point(204, 239);
            this.FrmDondur.Name = "FrmDondur";
            this.FrmDondur.Size = new System.Drawing.Size(162, 68);
            this.FrmDondur.TabIndex = 157;
            this.FrmDondur.Text = "Döndürme";
            this.FrmDondur.UseVisualStyleBackColor = false;
            this.FrmDondur.Click += new System.EventHandler(this.FrmDondur_Click);
            // 
            // BtnEgme
            // 
            this.BtnEgme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEgme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEgme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEgme.ForeColor = System.Drawing.Color.White;
            this.BtnEgme.Location = new System.Drawing.Point(28, 239);
            this.BtnEgme.Name = "BtnEgme";
            this.BtnEgme.Size = new System.Drawing.Size(162, 68);
            this.BtnEgme.TabIndex = 156;
            this.BtnEgme.Text = "Eğme Kaydırma";
            this.BtnEgme.UseVisualStyleBackColor = false;
            this.BtnEgme.Click += new System.EventHandler(this.BtnEgme_Click);
            // 
            // BtnMedianFiltre
            // 
            this.BtnMedianFiltre.BackColor = System.Drawing.Color.Blue;
            this.BtnMedianFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedianFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMedianFiltre.ForeColor = System.Drawing.Color.White;
            this.BtnMedianFiltre.Location = new System.Drawing.Point(27, 327);
            this.BtnMedianFiltre.Name = "BtnMedianFiltre";
            this.BtnMedianFiltre.Size = new System.Drawing.Size(162, 68);
            this.BtnMedianFiltre.TabIndex = 160;
            this.BtnMedianFiltre.Text = "Medyan Filtresi";
            this.BtnMedianFiltre.UseVisualStyleBackColor = false;
            this.BtnMedianFiltre.Click += new System.EventHandler(this.BtnMedianFiltre_Click);
            // 
            // BtnKonvolüsyon
            // 
            this.BtnKonvolüsyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnKonvolüsyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKonvolüsyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKonvolüsyon.ForeColor = System.Drawing.Color.White;
            this.BtnKonvolüsyon.Location = new System.Drawing.Point(204, 327);
            this.BtnKonvolüsyon.Name = "BtnKonvolüsyon";
            this.BtnKonvolüsyon.Size = new System.Drawing.Size(162, 68);
            this.BtnKonvolüsyon.TabIndex = 161;
            this.BtnKonvolüsyon.Text = "Konvolüsyon";
            this.BtnKonvolüsyon.UseVisualStyleBackColor = false;
            this.BtnKonvolüsyon.Click += new System.EventHandler(this.BtnKonvolüsyon_Click);
            // 
            // BtnSobelFiltresi
            // 
            this.BtnSobelFiltresi.BackColor = System.Drawing.Color.Blue;
            this.BtnSobelFiltresi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobelFiltresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSobelFiltresi.ForeColor = System.Drawing.Color.White;
            this.BtnSobelFiltresi.Location = new System.Drawing.Point(380, 327);
            this.BtnSobelFiltresi.Name = "BtnSobelFiltresi";
            this.BtnSobelFiltresi.Size = new System.Drawing.Size(162, 68);
            this.BtnSobelFiltresi.TabIndex = 162;
            this.BtnSobelFiltresi.Text = "Sobel Filtresi";
            this.BtnSobelFiltresi.UseVisualStyleBackColor = false;
            this.BtnSobelFiltresi.Click += new System.EventHandler(this.BtnSobelFiltresi_Click);
            // 
            // BtnPrewitt
            // 
            this.BtnPrewitt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnPrewitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPrewitt.ForeColor = System.Drawing.Color.White;
            this.BtnPrewitt.Location = new System.Drawing.Point(555, 327);
            this.BtnPrewitt.Name = "BtnPrewitt";
            this.BtnPrewitt.Size = new System.Drawing.Size(162, 68);
            this.BtnPrewitt.TabIndex = 163;
            this.BtnPrewitt.Text = "Prewitt Filtresi";
            this.BtnPrewitt.UseVisualStyleBackColor = false;
            this.BtnPrewitt.Click += new System.EventHandler(this.BtnPrewitt_Click);
            // 
            // BtnRobert
            // 
            this.BtnRobert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRobert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRobert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRobert.ForeColor = System.Drawing.Color.White;
            this.BtnRobert.Location = new System.Drawing.Point(27, 411);
            this.BtnRobert.Name = "BtnRobert";
            this.BtnRobert.Size = new System.Drawing.Size(162, 68);
            this.BtnRobert.TabIndex = 164;
            this.BtnRobert.Text = "Robert Cross";
            this.BtnRobert.UseVisualStyleBackColor = false;
            this.BtnRobert.Click += new System.EventHandler(this.BtnRobert_Click);
            // 
            // BtnMorfolojik
            // 
            this.BtnMorfolojik.BackColor = System.Drawing.Color.Blue;
            this.BtnMorfolojik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMorfolojik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMorfolojik.ForeColor = System.Drawing.Color.White;
            this.BtnMorfolojik.Location = new System.Drawing.Point(204, 411);
            this.BtnMorfolojik.Name = "BtnMorfolojik";
            this.BtnMorfolojik.Size = new System.Drawing.Size(162, 68);
            this.BtnMorfolojik.TabIndex = 165;
            this.BtnMorfolojik.Text = "Morfolojik İşlemler";
            this.BtnMorfolojik.UseVisualStyleBackColor = false;
            this.BtnMorfolojik.Click += new System.EventHandler(this.BtnMorfolojik_Click);
            // 
            // BtnZoom
            // 
            this.BtnZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnZoom.ForeColor = System.Drawing.Color.White;
            this.BtnZoom.Location = new System.Drawing.Point(380, 411);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(162, 68);
            this.BtnZoom.TabIndex = 166;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = false;
            this.BtnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(769, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnMorfolojik);
            this.Controls.Add(this.BtnRobert);
            this.Controls.Add(this.BtnPrewitt);
            this.Controls.Add(this.BtnSobelFiltresi);
            this.Controls.Add(this.BtnKonvolüsyon);
            this.Controls.Add(this.BtnMedianFiltre);
            this.Controls.Add(this.FrmOrtFiltre);
            this.Controls.Add(this.BtnPersfektif);
            this.Controls.Add(this.FrmDondur);
            this.Controls.Add(this.BtnEgme);
            this.Controls.Add(this.BtnAynalama);
            this.Controls.Add(this.BtnTasima);
            this.Controls.Add(this.BtnKontrast);
            this.Controls.Add(this.BtnHistogram);
            this.Controls.Add(this.BtnEsikleme);
            this.Controls.Add(this.BtnParlaklik);
            this.Controls.Add(this.BtnGriTon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNegatif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNegatif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGriTon;
        private System.Windows.Forms.Button BtnParlaklik;
        private System.Windows.Forms.Button BtnEsikleme;
        private System.Windows.Forms.Button BtnHistogram;
        private System.Windows.Forms.Button BtnKontrast;
        private System.Windows.Forms.Button BtnTasima;
        private System.Windows.Forms.Button BtnAynalama;
        private System.Windows.Forms.Button FrmOrtFiltre;
        private System.Windows.Forms.Button BtnPersfektif;
        private System.Windows.Forms.Button FrmDondur;
        private System.Windows.Forms.Button BtnEgme;
        private System.Windows.Forms.Button BtnMedianFiltre;
        private System.Windows.Forms.Button BtnKonvolüsyon;
        private System.Windows.Forms.Button BtnSobelFiltresi;
        private System.Windows.Forms.Button BtnPrewitt;
        private System.Windows.Forms.Button BtnRobert;
        private System.Windows.Forms.Button BtnMorfolojik;
        private System.Windows.Forms.Button BtnZoom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

