namespace _152120211066_152120211068
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelAdres2 = new System.Windows.Forms.Label();
            this.labelSipariş = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxYemek = new System.Windows.Forms.ComboBox();
            this.comboBoxİl = new System.Windows.Forms.ComboBox();
            this.comboBoxİlçe = new System.Windows.Forms.ComboBox();
            this.comboBoxSiparişler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 129);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 22);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(83, 206);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(165, 22);
            this.textBoxTel.TabIndex = 1;
            this.textBoxTel.TextChanged += new System.EventHandler(this.textBoxTel_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Ad-Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yemek Listesi";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(192, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 61);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pilavvvv Sipariş Sistemi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.Location = new System.Drawing.Point(535, 106);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(78, 22);
            this.labelAdres.TabIndex = 15;
            this.labelAdres.Text = "Adres İl";
            // 
            // labelAdres2
            // 
            this.labelAdres2.AutoSize = true;
            this.labelAdres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres2.Location = new System.Drawing.Point(535, 179);
            this.labelAdres2.Name = "labelAdres2";
            this.labelAdres2.Size = new System.Drawing.Size(99, 22);
            this.labelAdres2.TabIndex = 16;
            this.labelAdres2.Text = "Adres İlçe";
            // 
            // labelSipariş
            // 
            this.labelSipariş.AutoSize = true;
            this.labelSipariş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSipariş.Location = new System.Drawing.Point(535, 253);
            this.labelSipariş.Name = "labelSipariş";
            this.labelSipariş.Size = new System.Drawing.Size(115, 22);
            this.labelSipariş.TabIndex = 17;
            this.labelSipariş.Text = "Siparişlerim";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(82, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 73);
            this.button1.TabIndex = 20;
            this.button1.Text = "Sipariş Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // comboBoxYemek
            // 
            this.comboBoxYemek.FormattingEnabled = true;
            this.comboBoxYemek.Location = new System.Drawing.Point(83, 278);
            this.comboBoxYemek.Name = "comboBoxYemek";
            this.comboBoxYemek.Size = new System.Drawing.Size(205, 24);
            this.comboBoxYemek.TabIndex = 21;
            // 
            // comboBoxİl
            // 
            this.comboBoxİl.FormattingEnabled = true;
            this.comboBoxİl.Location = new System.Drawing.Point(539, 127);
            this.comboBoxİl.Name = "comboBoxİl";
            this.comboBoxİl.Size = new System.Drawing.Size(205, 24);
            this.comboBoxİl.TabIndex = 22;
            this.comboBoxİl.SelectedIndexChanged += new System.EventHandler(this.comboBoxİl_SelectedIndexChanged);
            // 
            // comboBoxİlçe
            // 
            this.comboBoxİlçe.FormattingEnabled = true;
            this.comboBoxİlçe.Location = new System.Drawing.Point(539, 204);
            this.comboBoxİlçe.Name = "comboBoxİlçe";
            this.comboBoxİlçe.Size = new System.Drawing.Size(205, 24);
            this.comboBoxİlçe.TabIndex = 23;
            // 
            // comboBoxSiparişler
            // 
            this.comboBoxSiparişler.FormattingEnabled = true;
            this.comboBoxSiparişler.Location = new System.Drawing.Point(539, 278);
            this.comboBoxSiparişler.Name = "comboBoxSiparişler";
            this.comboBoxSiparişler.Size = new System.Drawing.Size(205, 24);
            this.comboBoxSiparişler.TabIndex = 24;
            this.comboBoxSiparişler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiparişler_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(79, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 357);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(539, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 142);
            this.label5.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(823, 513);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSiparişler);
            this.Controls.Add(this.comboBoxİlçe);
            this.Controls.Add(this.comboBoxİl);
            this.Controls.Add(this.comboBoxYemek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSipariş);
            this.Controls.Add(this.labelAdres2);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelAdres2;
        private System.Windows.Forms.Label labelSipariş;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBoxYemek;
        private System.Windows.Forms.ComboBox comboBoxİl;
        private System.Windows.Forms.ComboBox comboBoxİlçe;
        private System.Windows.Forms.ComboBox comboBoxSiparişler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}

