namespace Veri_Yapısı
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.txtOyunSonucu = new System.Windows.Forms.TextBox();
            this.btnYenidenOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyna.Location = new System.Drawing.Point(48, 60);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(157, 38);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "HER TUR İÇİN BAS";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOyunSonucu
            // 
            this.txtOyunSonucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunSonucu.Location = new System.Drawing.Point(317, 60);
            this.txtOyunSonucu.Multiline = true;
            this.txtOyunSonucu.Name = "txtOyunSonucu";
            this.txtOyunSonucu.Size = new System.Drawing.Size(357, 239);
            this.txtOyunSonucu.TabIndex = 1;
            // 
            // btnYenidenOyna
            // 
            this.btnYenidenOyna.BackColor = System.Drawing.Color.Red;
            this.btnYenidenOyna.Enabled = false;
            this.btnYenidenOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenidenOyna.Location = new System.Drawing.Point(48, 245);
            this.btnYenidenOyna.Name = "btnYenidenOyna";
            this.btnYenidenOyna.Size = new System.Drawing.Size(157, 39);
            this.btnYenidenOyna.TabIndex = 2;
            this.btnYenidenOyna.Text = "YENİDEN OYNA";
            this.btnYenidenOyna.UseVisualStyleBackColor = false;
            this.btnYenidenOyna.Click += new System.EventHandler(this.btnYenidenOyna_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOyna;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(737, 416);
            this.Controls.Add(this.btnYenidenOyna);
            this.Controls.Add(this.txtOyunSonucu);
            this.Controls.Add(this.btnOyna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.TextBox txtOyunSonucu;
        private System.Windows.Forms.Button btnYenidenOyna;
    }
}

