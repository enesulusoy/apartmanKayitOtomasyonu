namespace ApartmanKayıtDev
{
    partial class frmAnaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaform));
            this.btnDaire = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorc = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnFotograf = new DevExpress.XtraEditors.SimpleButton();
            this.btnHakkımızda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDaire
            // 
            this.btnDaire.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaire.Appearance.Options.UseFont = true;
            this.btnDaire.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaire.ImageOptions.Image")));
            this.btnDaire.Location = new System.Drawing.Point(50, 54);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(211, 48);
            this.btnDaire.TabIndex = 1;
            this.btnDaire.Text = "Daireler";
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // btnBorc
            // 
            this.btnBorc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorc.Appearance.Options.UseFont = true;
            this.btnBorc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorc.ImageOptions.Image")));
            this.btnBorc.Location = new System.Drawing.Point(332, 54);
            this.btnBorc.Name = "btnBorc";
            this.btnBorc.Size = new System.Drawing.Size(211, 48);
            this.btnBorc.TabIndex = 2;
            this.btnBorc.Text = "Borçlar";
            this.btnBorc.Click += new System.EventHandler(this.btnBorc_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Appearance.Options.UseFont = true;
            this.btnKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayit.ImageOptions.Image")));
            this.btnKayit.Location = new System.Drawing.Point(611, 54);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(211, 48);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "Kayıt İşlemleri";
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnFotograf
            // 
            this.btnFotograf.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotograf.Appearance.Options.UseFont = true;
            this.btnFotograf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFotograf.ImageOptions.Image")));
            this.btnFotograf.Location = new System.Drawing.Point(50, 147);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(211, 48);
            this.btnFotograf.TabIndex = 4;
            this.btnFotograf.Text = "Fotoğraflar";
            this.btnFotograf.Click += new System.EventHandler(this.btnFotograf_Click);
            // 
            // btnHakkımızda
            // 
            this.btnHakkımızda.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkımızda.Appearance.Options.UseFont = true;
            this.btnHakkımızda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHakkımızda.ImageOptions.Image")));
            this.btnHakkımızda.Location = new System.Drawing.Point(332, 147);
            this.btnHakkımızda.Name = "btnHakkımızda";
            this.btnHakkımızda.Size = new System.Drawing.Size(211, 48);
            this.btnHakkımızda.TabIndex = 5;
            this.btnHakkımızda.Text = "Hakkımızda";
            this.btnHakkımızda.Click += new System.EventHandler(this.btnHakkımızda_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(611, 147);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(211, 48);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(878, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHakkımızda);
            this.Controls.Add(this.btnFotograf);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnBorc);
            this.Controls.Add(this.btnDaire);
            this.Name = "frmAnaform";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDaire;
        private DevExpress.XtraEditors.SimpleButton btnBorc;
        private DevExpress.XtraEditors.SimpleButton btnKayit;
        private DevExpress.XtraEditors.SimpleButton btnFotograf;
        private DevExpress.XtraEditors.SimpleButton btnHakkımızda;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}