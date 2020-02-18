namespace ApartmanKayıtDev
{
    partial class FrmFotograf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFotograf));
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ımageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images4"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images5"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images6"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images7"))));
            this.ımageSlider1.Location = new System.Drawing.Point(0, 0);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(1200, 692);
            this.ımageSlider1.TabIndex = 0;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(1139, 0);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(61, 54);
            this.btnAra.TabIndex = 19;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmFotograf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.ımageSlider1);
            this.Name = "FrmFotograf";
            this.Text = "Daire Fotoğrafları";
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
    }
}