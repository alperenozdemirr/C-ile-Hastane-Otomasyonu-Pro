
namespace HastaneOtomasyonu
{
    partial class RandevuMuayne
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
            this.dgwRandevu = new System.Windows.Forms.DataGridView();
            this.tbxSiraNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCinsiyet = new System.Windows.Forms.Label();
            this.tbxAdSoyad = new System.Windows.Forms.Label();
            this.tbxGiriscinsi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDoktor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMuayne = new System.Windows.Forms.Button();
            this.cbxTedavi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTani = new System.Windows.Forms.TextBox();
            this.tbxRecete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxRandevusaati = new System.Windows.Forms.Label();
            this.tbxBirim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRandevu
            // 
            this.dgwRandevu.BackgroundColor = System.Drawing.Color.White;
            this.dgwRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRandevu.Location = new System.Drawing.Point(12, 133);
            this.dgwRandevu.Name = "dgwRandevu";
            this.dgwRandevu.Size = new System.Drawing.Size(1169, 226);
            this.dgwRandevu.TabIndex = 0;
            this.dgwRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRandevu_CellClick);
            // 
            // tbxSiraNo
            // 
            this.tbxSiraNo.AutoSize = true;
            this.tbxSiraNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSiraNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxSiraNo.Location = new System.Drawing.Point(607, 389);
            this.tbxSiraNo.Name = "tbxSiraNo";
            this.tbxSiraNo.Size = new System.Drawing.Size(0, 43);
            this.tbxSiraNo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 43);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sıra No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxBirim);
            this.groupBox1.Controls.Add(this.tbxRandevusaati);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxCinsiyet);
            this.groupBox1.Controls.Add(this.tbxAdSoyad);
            this.groupBox1.Controls.Add(this.tbxGiriscinsi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbxDoktor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxTc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(88, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 279);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hasta Adı Soyadı";
            // 
            // tbxCinsiyet
            // 
            this.tbxCinsiyet.AutoSize = true;
            this.tbxCinsiyet.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCinsiyet.Location = new System.Drawing.Point(154, 147);
            this.tbxCinsiyet.Name = "tbxCinsiyet";
            this.tbxCinsiyet.Size = new System.Drawing.Size(0, 19);
            this.tbxCinsiyet.TabIndex = 12;
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.AutoSize = true;
            this.tbxAdSoyad.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdSoyad.Location = new System.Drawing.Point(154, 35);
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(0, 19);
            this.tbxAdSoyad.TabIndex = 11;
            // 
            // tbxGiriscinsi
            // 
            this.tbxGiriscinsi.AutoSize = true;
            this.tbxGiriscinsi.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGiriscinsi.Location = new System.Drawing.Point(154, 180);
            this.tbxGiriscinsi.Name = "tbxGiriscinsi";
            this.tbxGiriscinsi.Size = new System.Drawing.Size(0, 19);
            this.tbxGiriscinsi.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Giriş Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cinsiyet";
            // 
            // tbxDoktor
            // 
            this.tbxDoktor.AutoSize = true;
            this.tbxDoktor.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDoktor.Location = new System.Drawing.Point(154, 107);
            this.tbxDoktor.Name = "tbxDoktor";
            this.tbxDoktor.Size = new System.Drawing.Size(0, 19);
            this.tbxDoktor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tc No";
            // 
            // tbxTc
            // 
            this.tbxTc.AutoSize = true;
            this.tbxTc.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTc.Location = new System.Drawing.Point(154, 71);
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(0, 19);
            this.tbxTc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Doktor Adı";
            // 
            // btnMuayne
            // 
            this.btnMuayne.Location = new System.Drawing.Point(657, 610);
            this.btnMuayne.Name = "btnMuayne";
            this.btnMuayne.Size = new System.Drawing.Size(140, 41);
            this.btnMuayne.TabIndex = 21;
            this.btnMuayne.Text = "Muayneyi Tamamla";
            this.btnMuayne.UseVisualStyleBackColor = true;
            this.btnMuayne.Click += new System.EventHandler(this.btnMuayne_Click);
            // 
            // cbxTedavi
            // 
            this.cbxTedavi.FormattingEnabled = true;
            this.cbxTedavi.Location = new System.Drawing.Point(620, 574);
            this.cbxTedavi.Name = "cbxTedavi";
            this.cbxTedavi.Size = new System.Drawing.Size(137, 21);
            this.cbxTedavi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tedavi Yöntemi";
            // 
            // tbxTani
            // 
            this.tbxTani.Location = new System.Drawing.Point(620, 503);
            this.tbxTani.Name = "tbxTani";
            this.tbxTani.Size = new System.Drawing.Size(177, 20);
            this.tbxTani.TabIndex = 18;
            // 
            // tbxRecete
            // 
            this.tbxRecete.Location = new System.Drawing.Point(620, 537);
            this.tbxRecete.Name = "tbxRecete";
            this.tbxRecete.Size = new System.Drawing.Size(177, 20);
            this.tbxRecete.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hastalık Tanısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reçete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(356, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 58);
            this.label2.TabIndex = 26;
            this.label2.Text = "Akyazı Devlet Hastanesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(259, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(675, 45);
            this.label5.TabIndex = 25;
            this.label5.Text = "Randevulu Ve Günlük Muayneler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Randevu Saati";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Birim";
            // 
            // tbxRandevusaati
            // 
            this.tbxRandevusaati.AutoSize = true;
            this.tbxRandevusaati.Location = new System.Drawing.Point(158, 214);
            this.tbxRandevusaati.Name = "tbxRandevusaati";
            this.tbxRandevusaati.Size = new System.Drawing.Size(0, 22);
            this.tbxRandevusaati.TabIndex = 13;
            // 
            // tbxBirim
            // 
            this.tbxBirim.AutoSize = true;
            this.tbxBirim.Location = new System.Drawing.Point(158, 243);
            this.tbxBirim.Name = "tbxBirim";
            this.tbxBirim.Size = new System.Drawing.Size(0, 22);
            this.tbxBirim.TabIndex = 13;
            // 
            // RandevuMuayne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSiraNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMuayne);
            this.Controls.Add(this.cbxTedavi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTani);
            this.Controls.Add(this.tbxRecete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwRandevu);
            this.Name = "RandevuMuayne";
            this.Text = "RandevuMuayne";
            this.Load += new System.EventHandler(this.RandevuMuayne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRandevu;
        private System.Windows.Forms.Label tbxSiraNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tbxCinsiyet;
        private System.Windows.Forms.Label tbxAdSoyad;
        private System.Windows.Forms.Label tbxGiriscinsi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tbxDoktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tbxTc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMuayne;
        private System.Windows.Forms.ComboBox cbxTedavi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTani;
        private System.Windows.Forms.TextBox tbxRecete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tbxBirim;
        private System.Windows.Forms.Label tbxRandevusaati;
        private System.Windows.Forms.Label label13;
    }
}