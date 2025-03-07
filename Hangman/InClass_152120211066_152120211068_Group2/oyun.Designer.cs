namespace InClass_152120211066_152120211068_Group2
{
    partial class oyun
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonİpucu = new System.Windows.Forms.Button();
            this.buttonTahmin = new System.Windows.Forms.Button();
            this.buttonBitir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(529, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGMAN";
            // 
            // buttonİpucu
            // 
            this.buttonİpucu.BackColor = System.Drawing.Color.Orange;
            this.buttonİpucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonİpucu.Location = new System.Drawing.Point(332, 107);
            this.buttonİpucu.Name = "buttonİpucu";
            this.buttonİpucu.Size = new System.Drawing.Size(84, 29);
            this.buttonİpucu.TabIndex = 1;
            this.buttonİpucu.Text = "İpucu?";
            this.buttonİpucu.UseVisualStyleBackColor = false;
            this.buttonİpucu.Click += new System.EventHandler(this.buttonİpucu_Click);
            // 
            // buttonTahmin
            // 
            this.buttonTahmin.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahmin.Location = new System.Drawing.Point(164, 363);
            this.buttonTahmin.Name = "buttonTahmin";
            this.buttonTahmin.Size = new System.Drawing.Size(123, 50);
            this.buttonTahmin.TabIndex = 2;
            this.buttonTahmin.Text = "Tahmin Et";
            this.buttonTahmin.UseVisualStyleBackColor = false;
            this.buttonTahmin.Click += new System.EventHandler(this.buttonTahmin_Click);
            // 
            // buttonBitir
            // 
            this.buttonBitir.BackColor = System.Drawing.Color.Gold;
            this.buttonBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBitir.Location = new System.Drawing.Point(293, 363);
            this.buttonBitir.Name = "buttonBitir";
            this.buttonBitir.Size = new System.Drawing.Size(123, 50);
            this.buttonBitir.TabIndex = 3;
            this.buttonBitir.Text = "Oyunu Bitir";
            this.buttonBitir.UseVisualStyleBackColor = false;
            this.buttonBitir.Click += new System.EventHandler(this.buttonBitir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelLength);
            this.panel1.Controls.Add(this.labelWrong);
            this.panel1.Controls.Add(this.labelPuan);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelWord);
            this.panel1.Controls.Add(this.buttonİpucu);
            this.panel1.Controls.Add(this.buttonBitir);
            this.panel1.Controls.Add(this.buttonTahmin);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 426);
            this.panel1.TabIndex = 4;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLength.Location = new System.Drawing.Point(18, 208);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(156, 20);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "Kelime Uzunluğu:";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWrong.Location = new System.Drawing.Point(19, 249);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(155, 20);
            this.labelWrong.TabIndex = 7;
            this.labelWrong.Text = "Yanlış Tahminler:";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuan.Location = new System.Drawing.Point(20, 320);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(154, 27);
            this.labelPuan.TabIndex = 6;
            this.labelPuan.Text = "PUAN: 100 P";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 379);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelWord
            // 
            this.labelWord.BackColor = System.Drawing.Color.Silver;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWord.ForeColor = System.Drawing.Color.Black;
            this.labelWord.Location = new System.Drawing.Point(18, 40);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(398, 64);
            this.labelWord.TabIndex = 4;
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(449, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 426);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InClass_152120211066_152120211068_Group2.Properties.Resources.man_000000;
            this.pictureBox1.Location = new System.Drawing.Point(30, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "TERCİHLER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Süre: 30";
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(891, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "oyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oyun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonİpucu;
        private System.Windows.Forms.Button buttonTahmin;
        private System.Windows.Forms.Button buttonBitir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}