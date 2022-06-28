
namespace Görüntü_İşleme_Proje
{
    partial class FrmKontrast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKontrast));
            this.Pictureboxexit = new System.Windows.Forms.PictureBox();
            this.BtnSıfırla = new System.Windows.Forms.Button();
            this.BtnKontrast = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtKontrastDegeri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictureboxexit
            // 
            this.Pictureboxexit.BackColor = System.Drawing.Color.Transparent;
            this.Pictureboxexit.Image = ((System.Drawing.Image)(resources.GetObject("Pictureboxexit.Image")));
            this.Pictureboxexit.Location = new System.Drawing.Point(695, 12);
            this.Pictureboxexit.Name = "Pictureboxexit";
            this.Pictureboxexit.Size = new System.Drawing.Size(65, 53);
            this.Pictureboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictureboxexit.TabIndex = 149;
            this.Pictureboxexit.TabStop = false;
            this.Pictureboxexit.Click += new System.EventHandler(this.Pictureboxexit_Click);
            // 
            // BtnSıfırla
            // 
            this.BtnSıfırla.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfırla.ForeColor = System.Drawing.Color.White;
            this.BtnSıfırla.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_reset_32px;
            this.BtnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSıfırla.Location = new System.Drawing.Point(452, 295);
            this.BtnSıfırla.Name = "BtnSıfırla";
            this.BtnSıfırla.Size = new System.Drawing.Size(198, 66);
            this.BtnSıfırla.TabIndex = 165;
            this.BtnSıfırla.Text = "Sıfırla";
            this.BtnSıfırla.UseVisualStyleBackColor = false;
            this.BtnSıfırla.Click += new System.EventHandler(this.BtnSıfırla_Click);
            // 
            // BtnKontrast
            // 
            this.BtnKontrast.BackColor = System.Drawing.Color.Red;
            this.BtnKontrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKontrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKontrast.ForeColor = System.Drawing.Color.White;
            this.BtnKontrast.Image = ((System.Drawing.Image)(resources.GetObject("BtnKontrast.Image")));
            this.BtnKontrast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKontrast.Location = new System.Drawing.Point(244, 295);
            this.BtnKontrast.Name = "BtnKontrast";
            this.BtnKontrast.Size = new System.Drawing.Size(198, 66);
            this.BtnKontrast.TabIndex = 164;
            this.BtnKontrast.Text = "        Kontrast Uygula";
            this.BtnKontrast.UseVisualStyleBackColor = false;
            this.BtnKontrast.Click += new System.EventHandler(this.BtnKontrast_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(291, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 163;
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
            this.BtnResimSec.Location = new System.Drawing.Point(31, 295);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 66);
            this.BtnResimSec.TabIndex = 162;
            this.BtnResimSec.Text = "Bir Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = false;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(468, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtKontrastDegeri
            // 
            this.TxtKontrastDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKontrastDegeri.Location = new System.Drawing.Point(361, 236);
            this.TxtKontrastDegeri.Name = "TxtKontrastDegeri";
            this.TxtKontrastDegeri.Size = new System.Drawing.Size(142, 32);
            this.TxtKontrastDegeri.TabIndex = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(186, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 170;
            this.label1.Text = "Eşikleme Değeri:";
            // 
            // FrmKontrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(768, 390);
            this.Controls.Add(this.TxtKontrastDegeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSıfırla);
            this.Controls.Add(this.BtnKontrast);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pictureboxexit);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKontrast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKontrast";
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictureboxexit;
        private System.Windows.Forms.Button BtnSıfırla;
        private System.Windows.Forms.Button BtnKontrast;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtKontrastDegeri;
        private System.Windows.Forms.Label label1;
    }
}