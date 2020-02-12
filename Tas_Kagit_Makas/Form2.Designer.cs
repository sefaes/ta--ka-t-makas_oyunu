namespace Tas_Kagit_Makas
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_oyna = new System.Windows.Forms.Button();
            this.bt_krll = new System.Windows.Forms.Button();
            this.bt_cks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAŞ KAĞIT MAKAS \r\n          OYUNU";
            // 
            // bt_oyna
            // 
            this.bt_oyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_oyna.Location = new System.Drawing.Point(381, 179);
            this.bt_oyna.Name = "bt_oyna";
            this.bt_oyna.Size = new System.Drawing.Size(185, 50);
            this.bt_oyna.TabIndex = 1;
            this.bt_oyna.Text = "OYNA";
            this.bt_oyna.UseVisualStyleBackColor = true;
            this.bt_oyna.Click += new System.EventHandler(this.bt_oyna_Click);
            // 
            // bt_krll
            // 
            this.bt_krll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_krll.Location = new System.Drawing.Point(381, 261);
            this.bt_krll.Name = "bt_krll";
            this.bt_krll.Size = new System.Drawing.Size(185, 50);
            this.bt_krll.TabIndex = 2;
            this.bt_krll.Text = "KURALLAR VE OYANNIŞ";
            this.bt_krll.UseVisualStyleBackColor = true;
            this.bt_krll.Click += new System.EventHandler(this.bt_krll_Click);
            // 
            // bt_cks
            // 
            this.bt_cks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_cks.Location = new System.Drawing.Point(381, 346);
            this.bt_cks.Name = "bt_cks";
            this.bt_cks.Size = new System.Drawing.Size(185, 50);
            this.bt_cks.TabIndex = 3;
            this.bt_cks.Text = "ÇIKIŞ";
            this.bt_cks.UseVisualStyleBackColor = true;
            this.bt_cks.Click += new System.EventHandler(this.bt_cks_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 526);
            this.Controls.Add(this.bt_cks);
            this.Controls.Add(this.bt_krll);
            this.Controls.Add(this.bt_oyna);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_oyna;
        private System.Windows.Forms.Button bt_krll;
        private System.Windows.Forms.Button bt_cks;
    }
}