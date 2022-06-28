
namespace Görüntü_İşleme_Proje
{
    partial class FrmSobelFiltresi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobelFiltresi));
            this.Pictureboxexit = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSıfırla = new System.Windows.Forms.Button();
            this.BtnMedyanFiltre = new System.Windows.Forms.Button();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictureboxexit
            // 
            this.Pictureboxexit.BackColor = System.Drawing.Color.Transparent;
            this.Pictureboxexit.Image = ((System.Drawing.Image)(resources.GetObject("Pictureboxexit.Image")));
            this.Pictureboxexit.Location = new System.Drawing.Point(1032, 12);
            this.Pictureboxexit.Name = "Pictureboxexit";
            this.Pictureboxexit.Size = new System.Drawing.Size(65, 53);
            this.Pictureboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictureboxexit.TabIndex = 186;
            this.Pictureboxexit.TabStop = false;
            this.Pictureboxexit.Click += new System.EventHandler(this.Pictureboxexit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(773, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(198, 183);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 183;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(569, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 182;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(365, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 181;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSıfırla
            // 
            this.BtnSıfırla.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfırla.ForeColor = System.Drawing.Color.White;
            this.BtnSıfırla.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_reset_32px;
            this.BtnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSıfırla.Location = new System.Drawing.Point(458, 268);
            this.BtnSıfırla.Name = "BtnSıfırla";
            this.BtnSıfırla.Size = new System.Drawing.Size(198, 66);
            this.BtnSıfırla.TabIndex = 189;
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
            this.BtnMedyanFiltre.Location = new System.Drawing.Point(250, 268);
            this.BtnMedyanFiltre.Name = "BtnMedyanFiltre";
            this.BtnMedyanFiltre.Size = new System.Drawing.Size(198, 66);
            this.BtnMedyanFiltre.TabIndex = 188;
            this.BtnMedyanFiltre.Text = "Sobel Filtresi";
            this.BtnMedyanFiltre.UseVisualStyleBackColor = false;
            this.BtnMedyanFiltre.Click += new System.EventHandler(this.BtnMedyanFiltre_Click);
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
            this.BtnResimSec.Location = new System.Drawing.Point(37, 268);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 66);
            this.BtnResimSec.TabIndex = 187;
            this.BtnResimSec.Text = "Bir Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = false;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(216, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(133, 84);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 190;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSobelFiltresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BtnSıfırla);
            this.Controls.Add(this.BtnMedyanFiltre);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.Pictureboxexit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSobelFiltresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSobelFiltresi";
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Pictureboxexit;
        private System.Windows.Forms.Button BtnSıfırla;
        private System.Windows.Forms.Button BtnMedyanFiltre;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}