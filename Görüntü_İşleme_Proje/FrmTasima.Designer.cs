
namespace Görüntü_İşleme_Proje
{
    partial class FrmTasima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTasima));
            this.Pictureboxexit = new System.Windows.Forms.PictureBox();
            this.BtnSıfırla = new System.Windows.Forms.Button();
            this.BtnTasima = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // BtnSıfırla
            // 
            this.BtnSıfırla.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSıfırla.ForeColor = System.Drawing.Color.White;
            this.BtnSıfırla.Image = global::Görüntü_İşleme_Proje.Properties.Resources.icons8_reset_32px;
            this.BtnSıfırla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSıfırla.Location = new System.Drawing.Point(463, 342);
            this.BtnSıfırla.Name = "BtnSıfırla";
            this.BtnSıfırla.Size = new System.Drawing.Size(198, 66);
            this.BtnSıfırla.TabIndex = 165;
            this.BtnSıfırla.Text = "Sıfırla";
            this.BtnSıfırla.UseVisualStyleBackColor = false;
            this.BtnSıfırla.Click += new System.EventHandler(this.BtnSıfırla_Click);
            // 
            // BtnTasima
            // 
            this.BtnTasima.BackColor = System.Drawing.Color.Red;
            this.BtnTasima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTasima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTasima.ForeColor = System.Drawing.Color.White;
            this.BtnTasima.Image = ((System.Drawing.Image)(resources.GetObject("BtnTasima.Image")));
            this.BtnTasima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTasima.Location = new System.Drawing.Point(255, 342);
            this.BtnTasima.Name = "BtnTasima";
            this.BtnTasima.Size = new System.Drawing.Size(198, 66);
            this.BtnTasima.TabIndex = 164;
            this.BtnTasima.Text = "Taşıma";
            this.BtnTasima.UseVisualStyleBackColor = false;
            this.BtnTasima.Click += new System.EventHandler(this.BtnTasima_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(286, 123);
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
            this.BtnResimSec.Location = new System.Drawing.Point(42, 342);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 66);
            this.BtnResimSec.TabIndex = 162;
            this.BtnResimSec.Text = "Bir Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = false;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(463, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 69);
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
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtX.Location = new System.Drawing.Point(136, 284);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(65, 32);
            this.TxtX.TabIndex = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 170;
            this.label1.Text = "X:";
            // 
            // TxtY
            // 
            this.TxtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtY.Location = new System.Drawing.Point(264, 284);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(65, 32);
            this.TxtY.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(224, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 172;
            this.label2.Text = "Y:";
            // 
            // FrmTasima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSıfırla);
            this.Controls.Add(this.BtnTasima);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pictureboxexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTasima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTasima";
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
        private System.Windows.Forms.Button BtnTasima;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.Label label2;
    }
}