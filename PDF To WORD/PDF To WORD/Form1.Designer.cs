
namespace PDF_To_WORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPdfDosyasi = new System.Windows.Forms.RichTextBox();
            this.txtDosyaYolu = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Opf = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtDosyaYolu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF To WORD !";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 428);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(787, 54);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Dönüştür !";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPdfDosyasi
            // 
            this.txtPdfDosyasi.Location = new System.Drawing.Point(12, 147);
            this.txtPdfDosyasi.Name = "txtPdfDosyasi";
            this.txtPdfDosyasi.Size = new System.Drawing.Size(787, 275);
            this.txtPdfDosyasi.TabIndex = 2;
            this.txtPdfDosyasi.Text = "";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(12, 94);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtDosyaYolu.Properties.Appearance.Options.UseFont = true;
            this.txtDosyaYolu.Size = new System.Drawing.Size(579, 40);
            this.txtDosyaYolu.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(597, 93);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(202, 48);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Dosya Seç";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Opf
            // 
            this.Opf.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(811, 496);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.txtPdfDosyasi);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PDF To WORD !";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDosyaYolu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox txtPdfDosyasi;
        private DevExpress.XtraEditors.TextEdit txtDosyaYolu;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.OpenFileDialog Opf;
    }
}

