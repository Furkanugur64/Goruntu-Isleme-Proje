
namespace Görüntü_İşleme_Proje
{
    partial class FrmAynalama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAynalama));
            this.Pictureboxexit = new System.Windows.Forms.PictureBox();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSıfırla = new System.Windows.Forms.Button();
            this.BtnAynalama = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.Pictureboxexit.Location = new System.Drawing.Point(723, 12);
            this.Pictureboxexit.Name = "Pictureboxexit";
            this.Pictureboxexit.Size = new System.Drawing.Size(65, 53);
            this.Pictureboxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pictureboxexit.TabIndex = 149;
            this.Pictureboxexit.TabStop = false;
            this.Pictureboxexit.Click += new System.EventHandler(this.Pictureboxexit_Click);
            // 
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtX.Location = new System.Drawing.Point(279, 264);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(65, 32);
            this.TxtX.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 180;
            this.label1.Text = "Aynalama Değeri:";
            // 
            // BtnSıfırla
            // 
            this.BtnSıfırla.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfırla.ForeColor = System.Drawing.Color.White;
            this.BtnSıfırla.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_reset_32px;
            this.BtnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSıfırla.Location = new System.Drawing.Point(465, 322);
            this.BtnSıfırla.Name = "BtnSıfırla";
            this.BtnSıfırla.Size = new System.Drawing.Size(198, 66);
            this.BtnSıfırla.TabIndex = 179;
            this.BtnSıfırla.Text = "Sıfırla";
            this.BtnSıfırla.UseVisualStyleBackColor = false;
            this.BtnSıfırla.Click += new System.EventHandler(this.BtnSıfırla_Click);
            // 
            // BtnAynalama
            // 
            this.BtnAynalama.BackColor = System.Drawing.Color.Red;
            this.BtnAynalama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAynalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAynalama.ForeColor = System.Drawing.Color.White;
            this.BtnAynalama.Image = ((System.Drawing.Image)(resources.GetObject("BtnAynalama.Image")));
            this.BtnAynalama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAynalama.Location = new System.Drawing.Point(257, 322);
            this.BtnAynalama.Name = "BtnAynalama";
            this.BtnAynalama.Size = new System.Drawing.Size(198, 66);
            this.BtnAynalama.TabIndex = 178;
            this.BtnAynalama.Text = "Aynalama";
            this.BtnAynalama.UseVisualStyleBackColor = false;
            this.BtnAynalama.Click += new System.EventHandler(this.BtnAynalama_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(288, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 177;
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
            this.BtnResimSec.Location = new System.Drawing.Point(44, 322);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 66);
            this.BtnResimSec.TabIndex = 176;
            this.BtnResimSec.Text = "Bir Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = false;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(465, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 175;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAynalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSıfırla);
            this.Controls.Add(this.BtnAynalama);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pictureboxexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAynalama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAynalama";
            ((System.ComponentModel.ISupportInitialize)(this.Pictureboxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pictureboxexit;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSıfırla;
        private System.Windows.Forms.Button BtnAynalama;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}