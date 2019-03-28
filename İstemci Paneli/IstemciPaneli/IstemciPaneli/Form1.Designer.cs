namespace IstemciPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblOturum = new System.Windows.Forms.Label();
            this.tmrSorgula = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bağlantı Durumu :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(162, 246);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(16, 15);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "...";
            // 
            // lblOturum
            // 
            this.lblOturum.AutoSize = true;
            this.lblOturum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOturum.Location = new System.Drawing.Point(43, 273);
            this.lblOturum.Name = "lblOturum";
            this.lblOturum.Size = new System.Drawing.Size(16, 15);
            this.lblOturum.TabIndex = 3;
            this.lblOturum.Text = "...";
            // 
            // tmrSorgula
            // 
            this.tmrSorgula.Tick += new System.EventHandler(this.tmrSorgula_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(326, 307);
            this.Controls.Add(this.lblOturum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstemci Paneli |Kodlayan İlkcan Doğan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblOturum;
        private System.Windows.Forms.Timer tmrSorgula;
    }
}

