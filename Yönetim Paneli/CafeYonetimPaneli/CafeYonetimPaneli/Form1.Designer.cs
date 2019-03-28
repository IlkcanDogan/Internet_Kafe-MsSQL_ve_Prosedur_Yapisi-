namespace CafeYonetimPaneli
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
            this.View = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnlineSayisi = new System.Windows.Forms.Label();
            this.lblOfflineSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrYenile = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.View.BackColor = System.Drawing.Color.White;
            this.View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.View.ForeColor = System.Drawing.Color.Black;
            this.View.Location = new System.Drawing.Point(-1, 1);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(766, 352);
            this.View.TabIndex = 0;
            this.View.UseCompatibleStateImageBehavior = false;
            this.View.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.View_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanılan Masa Sayısı :";
            // 
            // lblOnlineSayisi
            // 
            this.lblOnlineSayisi.AutoSize = true;
            this.lblOnlineSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnlineSayisi.Location = new System.Drawing.Point(142, 14);
            this.lblOnlineSayisi.Name = "lblOnlineSayisi";
            this.lblOnlineSayisi.Size = new System.Drawing.Size(16, 15);
            this.lblOnlineSayisi.TabIndex = 3;
            this.lblOnlineSayisi.Text = "...";
            // 
            // lblOfflineSayisi
            // 
            this.lblOfflineSayisi.AutoSize = true;
            this.lblOfflineSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOfflineSayisi.Location = new System.Drawing.Point(106, 31);
            this.lblOfflineSayisi.Name = "lblOfflineSayisi";
            this.lblOfflineSayisi.Size = new System.Drawing.Size(16, 15);
            this.lblOfflineSayisi.TabIndex = 5;
            this.lblOfflineSayisi.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boş Masa sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblOfflineSayisi);
            this.groupBox1.Controls.Add(this.lblOnlineSayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİ";
            // 
            // tmrYenile
            // 
            this.tmrYenile.Tick += new System.EventHandler(this.tmrYenile_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(765, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.View);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Yönetim Paneli v1.0 | Kodlayan İlkcan Doğan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnlineSayisi;
        private System.Windows.Forms.Label lblOfflineSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer tmrYenile;
    }
}

