namespace CafeYonetimPaneli
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKapanis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPC = new System.Windows.Forms.ComboBox();
            this.btnAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKapanis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBaglanti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi";
            // 
            // lblKapanis
            // 
            this.lblKapanis.AutoSize = true;
            this.lblKapanis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapanis.Location = new System.Drawing.Point(89, 73);
            this.lblKapanis.Name = "lblKapanis";
            this.lblKapanis.Size = new System.Drawing.Size(16, 15);
            this.lblKapanis.TabIndex = 13;
            this.lblKapanis.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kapanış Saati:";
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaglanti.Location = new System.Drawing.Point(92, 44);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(16, 15);
            this.lblBaglanti.TabIndex = 11;
            this.lblBaglanti.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bağlantı Saati :";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIP.Location = new System.Drawing.Point(64, 16);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(16, 15);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Adresi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAktar);
            this.groupBox2.Controls.Add(this.cmbPC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Masa Seç :";
            // 
            // cmbPC
            // 
            this.cmbPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPC.FormattingEnabled = true;
            this.cmbPC.Location = new System.Drawing.Point(67, 23);
            this.cmbPC.Name = "cmbPC";
            this.cmbPC.Size = new System.Drawing.Size(121, 21);
            this.cmbPC.TabIndex = 10;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(9, 61);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(179, 23);
            this.btnAktar.TabIndex = 10;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(252, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC_Adi";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKapanis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBaglanti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbPC;
    }
}