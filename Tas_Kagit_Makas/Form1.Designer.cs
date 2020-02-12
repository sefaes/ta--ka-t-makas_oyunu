namespace Tas_Kagit_Makas
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.klcpuan = new System.Windows.Forms.Label();
            this.blgpuan = new System.Windows.Forms.Label();
            this.lb_snc = new System.Windows.Forms.Label();
            this.pB_Tas = new System.Windows.Forms.PictureBox();
            this.pB_kagt = new System.Windows.Forms.PictureBox();
            this.pB_mks = new System.Windows.Forms.PictureBox();
            this.pB_blg = new System.Windows.Forms.PictureBox();
            this.pB_kl = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_elsay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Tas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_kagt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_mks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_blg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_kl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(205, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANICI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(985, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "BİLGİSAYAR";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(607, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "SKOR";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(413, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "------->";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(829, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "<-------";
            // 
            // klcpuan
            // 
            this.klcpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klcpuan.Location = new System.Drawing.Point(500, 298);
            this.klcpuan.Name = "klcpuan";
            this.klcpuan.Size = new System.Drawing.Size(64, 36);
            this.klcpuan.TabIndex = 10;
            this.klcpuan.Text = "0";
            // 
            // blgpuan
            // 
            this.blgpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blgpuan.Location = new System.Drawing.Point(768, 298);
            this.blgpuan.Name = "blgpuan";
            this.blgpuan.Size = new System.Drawing.Size(55, 46);
            this.blgpuan.TabIndex = 11;
            this.blgpuan.Text = "0";
            // 
            // lb_snc
            // 
            this.lb_snc.AutoSize = true;
            this.lb_snc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_snc.Location = new System.Drawing.Point(598, 94);
            this.lb_snc.Name = "lb_snc";
            this.lb_snc.Size = new System.Drawing.Size(125, 25);
            this.lb_snc.TabIndex = 13;
            this.lb_snc.Text = "BERABERE";
            this.lb_snc.Visible = false;
            // 
            // pB_Tas
            // 
            this.pB_Tas.Image = global::Tas_Kagit_Makas.Properties.Resources.taş;
            this.pB_Tas.Location = new System.Drawing.Point(132, 109);
            this.pB_Tas.Name = "pB_Tas";
            this.pB_Tas.Size = new System.Drawing.Size(84, 86);
            this.pB_Tas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Tas.TabIndex = 4;
            this.pB_Tas.TabStop = false;
            this.pB_Tas.Click += new System.EventHandler(this.pB_Tas_Click);
            // 
            // pB_kagt
            // 
            this.pB_kagt.Image = global::Tas_Kagit_Makas.Properties.Resources.kağıt;
            this.pB_kagt.Location = new System.Drawing.Point(222, 109);
            this.pB_kagt.Name = "pB_kagt";
            this.pB_kagt.Size = new System.Drawing.Size(84, 86);
            this.pB_kagt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_kagt.TabIndex = 3;
            this.pB_kagt.TabStop = false;
            this.pB_kagt.Click += new System.EventHandler(this.pB_kagt_Click);
            // 
            // pB_mks
            // 
            this.pB_mks.Image = global::Tas_Kagit_Makas.Properties.Resources.makas;
            this.pB_mks.Location = new System.Drawing.Point(323, 109);
            this.pB_mks.Name = "pB_mks";
            this.pB_mks.Size = new System.Drawing.Size(84, 86);
            this.pB_mks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_mks.TabIndex = 2;
            this.pB_mks.TabStop = false;
            this.pB_mks.Click += new System.EventHandler(this.pB_mks_Click);
            // 
            // pB_blg
            // 
            this.pB_blg.Location = new System.Drawing.Point(923, 219);
            this.pB_blg.Name = "pB_blg";
            this.pB_blg.Size = new System.Drawing.Size(275, 238);
            this.pB_blg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_blg.TabIndex = 1;
            this.pB_blg.TabStop = false;
            // 
            // pB_kl
            // 
            this.pB_kl.Location = new System.Drawing.Point(132, 219);
            this.pB_kl.Name = "pB_kl";
            this.pB_kl.Size = new System.Drawing.Size(275, 238);
            this.pB_kl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_kl.TabIndex = 0;
            this.pB_kl.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(459, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "OYNANAN EL SAYISI=";
            // 
            // lb_elsay
            // 
            this.lb_elsay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_elsay.Location = new System.Drawing.Point(709, 409);
            this.lb_elsay.Name = "lb_elsay";
            this.lb_elsay.Size = new System.Drawing.Size(49, 36);
            this.lb_elsay.TabIndex = 15;
            this.lb_elsay.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(923, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1093, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_elsay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_snc);
            this.Controls.Add(this.blgpuan);
            this.Controls.Add(this.klcpuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB_Tas);
            this.Controls.Add(this.pB_kagt);
            this.Controls.Add(this.pB_mks);
            this.Controls.Add(this.pB_blg);
            this.Controls.Add(this.pB_kl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Tas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_kagt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_mks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_blg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_kl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_kl;
        private System.Windows.Forms.PictureBox pB_blg;
        private System.Windows.Forms.PictureBox pB_mks;
        private System.Windows.Forms.PictureBox pB_kagt;
        private System.Windows.Forms.PictureBox pB_Tas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label klcpuan;
        private System.Windows.Forms.Label blgpuan;
        private System.Windows.Forms.Label lb_snc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_elsay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

