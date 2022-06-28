
namespace Görüntü_İşleme_Proje
{
    partial class FrmMedyanFiltresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedyanFiltresi));
            this.TxtMeydanFiltre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSıfırla = new System.Windows.Forms.Button();
            this.BtnMedyanFiltre = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pictureboxexit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMeydanFiltre
            // 
            this.TxtMeydanFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMeydanFiltre.Location = new System.Drawing.Point(313, 298);
            this.TxtMeydanFiltre.Name = "TxtMeydanFiltre";
            this.TxtMeydanFiltre.Size = new System.Drawing.Size(142, 32);
            this.TxtMeydanFiltre.TabIndex = 187;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(119, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 186;
            this.label1.Text = "Filtre Değeri Girin:";
            // 
            // BtnSıfırla
            // 
            this.BtnSıfırla.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfırla.ForeColor = System.Drawing.Color.White;
            this.BtnSıfırla.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_reset_32px;
            this.BtnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSıfırla.Location = new System.Drawing.Point(451, 361);
            this.BtnSıfırla.Name = "BtnSıfırla";
            this.BtnSıfırla.Size = new System.Drawing.Size(198, 66);
            this.BtnSıfırla.TabIndex = 184;
            this.BtnSıfırla.Text = "Sıfırla";
            this.BtnSıfırla.UseVisualStyleBackColor = false;
            this.BtnSıfırla.Click += new System.EventHandler(this.BtnSıfırla_Click);
            // 
            // BtnMedyanFiltre
            // 
            this.BtnMedyanFiltre.BackColor = System.Drawing.Color.Red;
            this.BtnMedyanFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedyanFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMedyanFiltre.ForeColor = System.Drawing.Color.White;
            this.BtnMedyanFiltre.Image = ((System.Drawing.Image)(resources.GetObject("BtnMedyanFiltre.Image")));
            this.BtnMedyanFiltre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedyanFiltre.Location = new System.Drawing.Point(243, 361);
            this.BtnMedyanFiltre.Name = "BtnMedyanFiltre";
            this.BtnMedyanFiltre.Size = new System.Drawing.Size(198, 66);
            this.BtnMedyanFiltre.TabIndex = 183;
            this.BtnMedyanFiltre.Text = "  Medyan Uygula";
            this.BtnMedyanFiltre.UseVisualStyleBackColor = false;
            this.BtnMedyanFiltre.Click += new System.EventHandler(this.BtnMedyanFiltre_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(277, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 182;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.BackColor = System.Drawing.Color.Green;
            this.BtnResimSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnResimSec.ForeColor = System.Drawing.Color.White;
            this.BtnResimSec.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_camera_30px;
            this.BtnResimSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResimSec.Location = new System.Drawing.Point(30, 361);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 66);
            this.BtnResimSec.TabIndex = 181;
            this.BtnResimSec.Text = "Bir Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = false;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(454, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 180;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 179;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Pictureboxexit
            // 
            this.Pictureboxexit.BackColor = System.Drawing.Color.Transparent;
            this.Pictureboxexit.Image = ((System.Drawing.Image)(resources.GetObject("Pictureboxexit.Image")));
            this.Pictureboxexit.Location = new System.Drawing.Point(705, 24);
            this.Pictureboxexit.Name = "Pictureboxexit";
            this.Pictureboxexit.Size = new System.Drawing.Size(65, 53);
            this.Pictureboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictureboxexit.TabIndex = 185;
            this.Pictureboxexit.TabStop = false;
            this.Pictureboxexit.Click += new System.EventHandler(this.Pictureboxexit_Click);
            // 
            // FrmMedyanFiltresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtMeydanFiltre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pictureboxexit);
            this.Controls.Add(this.BtnSıfırla);
            this.Controls.Add(this.BtnMedyanFiltre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMedyanFiltresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedyanFiltresi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMeydanFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSıfırla;
        private System.Windows.Forms.Button BtnMedyanFiltre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox Pictureboxexit;
    }
}