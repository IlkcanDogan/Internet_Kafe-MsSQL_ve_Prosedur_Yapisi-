namespace CafeYonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTarife = new System.Windows.Forms.ComboBox();
            this.btnOturum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTarife
            // 
            this.cmbTarife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarife.FormattingEnabled = true;
            this.cmbTarife.Items.AddRange(new object[] {
            "1 TL - 30 dk",
            "2 TL - 1 Saat"});
            this.cmbTarife.Location = new System.Drawing.Point(114, 170);
            this.cmbTarife.Name = "cmbTarife";
            this.cmbTarife.Size = new System.Drawing.Size(121, 21);
            this.cmbTarife.TabIndex = 6;
            // 
            // btnOturum
            // 
            this.btnOturum.Location = new System.Drawing.Point(15, 220);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(223, 40);
            this.btnOturum.TabIndex = 7;
            this.btnOturum.Text = "Oturum Aç";
            this.btnOturum.UseVisualStyleBackColor = true;
            this.btnOturum.Click += new System.EventHandler(this.btnOturum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tarife Listesi :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(256, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOturum);
            this.Controls.Add(this.cmbTarife);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC_ADI - Oturum Aç";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTarife;
        private System.Windows.Forms.Button btnOturum;
        private System.Windows.Forms.Label label1;
    }
}