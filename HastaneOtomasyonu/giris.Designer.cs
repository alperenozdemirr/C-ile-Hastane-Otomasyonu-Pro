
namespace HastaneOtomasyonu
{
    partial class giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDoktor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnAcil = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(174, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Akyazı Devlet Hastanesi";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "saglıkbakanligi.png");
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "saglıkbakanligi.png");
            this.ımageList1.Images.SetKeyName(1, "doktorgırısı.jpg");
            this.ımageList1.Images.SetKeyName(2, "hastagiriş.png");
            this.ımageList1.Images.SetKeyName(3, "hastakabul.jpg");
            this.ımageList1.Images.SetKeyName(4, "yönetici.png");
            this.ımageList1.Images.SetKeyName(5, "acil.png");
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.White;
            this.btnDoktor.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktor.ImageIndex = 1;
            this.btnDoktor.ImageList = this.ımageList1;
            this.btnDoktor.Location = new System.Drawing.Point(347, 254);
            this.btnDoktor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnDoktor.Size = new System.Drawing.Size(140, 113);
            this.btnDoktor.TabIndex = 3;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(326, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hoşgeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(286, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lütfen Biriminizi Seçiniz";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.ImageIndex = 4;
            this.btnAdmin.ImageList = this.ımageList1;
            this.btnAdmin.Location = new System.Drawing.Point(25, 254);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAdmin.Size = new System.Drawing.Size(140, 113);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Yönetici Girişi";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.White;
            this.btnHasta.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasta.ImageIndex = 2;
            this.btnHasta.ImageList = this.ımageList1;
            this.btnHasta.Location = new System.Drawing.Point(503, 254);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnHasta.Size = new System.Drawing.Size(140, 113);
            this.btnHasta.TabIndex = 3;
            this.btnHasta.Text = "Hasta Girişi";
            this.btnHasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnAcil
            // 
            this.btnAcil.BackColor = System.Drawing.Color.White;
            this.btnAcil.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAcil.ImageIndex = 5;
            this.btnAcil.ImageList = this.ımageList1;
            this.btnAcil.Location = new System.Drawing.Point(664, 254);
            this.btnAcil.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAcil.Name = "btnAcil";
            this.btnAcil.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAcil.Size = new System.Drawing.Size(140, 113);
            this.btnAcil.TabIndex = 3;
            this.btnAcil.Text = "Acil Kayıt";
            this.btnAcil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcil.UseVisualStyleBackColor = false;
            this.btnAcil.Click += new System.EventHandler(this.btnAcil_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.White;
            this.btnRandevu.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.ImageIndex = 3;
            this.btnRandevu.ImageList = this.ımageList1;
            this.btnRandevu.Location = new System.Drawing.Point(180, 254);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnRandevu.Size = new System.Drawing.Size(140, 113);
            this.btnRandevu.TabIndex = 3;
            this.btnRandevu.Text = "Randevu Al";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRandevu.UseVisualStyleBackColor = false;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneOtomasyonu.Properties.Resources.saglıkbakanligi;
            this.pictureBox1.Location = new System.Drawing.Point(31, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HastaneOtomasyonu.Properties.Resources.saglıkbakanligi;
            this.pictureBox2.Location = new System.Drawing.Point(664, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 429);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAcil);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnAcil;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}