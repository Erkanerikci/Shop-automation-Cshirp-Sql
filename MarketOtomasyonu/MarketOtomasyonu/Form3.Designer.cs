namespace MarketOtomasyonu
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtbarkod = new TextBox();
            txtad = new TextBox();
            txtfirma = new TextBox();
            txtfiyat = new TextBox();
            txtstok = new TextBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            btnfoto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(721, 234);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // button1
            // 
            button1.Location = new Point(546, 281);
            button1.Name = "button1";
            button1.Size = new Size(79, 35);
            button1.TabIndex = 1;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(546, 338);
            button2.Name = "button2";
            button2.Size = new Size(79, 35);
            button2.TabIndex = 1;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 403);
            button3.Name = "button3";
            button3.Size = new Size(79, 35);
            button3.TabIndex = 1;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 296);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Barkod No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 324);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Urun Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 353);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Uretici Firma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 383);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 2;
            label4.Text = "Fiyatı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 413);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 2;
            label5.Text = "Stok Miktarı: ";
            // 
            // txtbarkod
            // 
            txtbarkod.Location = new Point(157, 293);
            txtbarkod.Name = "txtbarkod";
            txtbarkod.Size = new Size(100, 23);
            txtbarkod.TabIndex = 3;
            // 
            // txtad
            // 
            txtad.Location = new Point(157, 321);
            txtad.Name = "txtad";
            txtad.Size = new Size(100, 23);
            txtad.TabIndex = 3;
            // 
            // txtfirma
            // 
            txtfirma.Location = new Point(157, 350);
            txtfirma.Name = "txtfirma";
            txtfirma.Size = new Size(100, 23);
            txtfirma.TabIndex = 3;
            // 
            // txtfiyat
            // 
            txtfiyat.Location = new Point(157, 380);
            txtfiyat.Name = "txtfiyat";
            txtfiyat.Size = new Size(100, 23);
            txtfiyat.TabIndex = 3;
            // 
            // txtstok
            // 
            txtstok.Location = new Point(157, 409);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(100, 23);
            txtstok.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(319, 5);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 2;
            label6.Text = "Yiyecek";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 293);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 4;
            label7.Text = "Fotograf:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(372, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 102);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnfoto
            // 
            btnfoto.Location = new Point(280, 324);
            btnfoto.Name = "btnfoto";
            btnfoto.Size = new Size(77, 39);
            btnfoto.TabIndex = 1;
            btnfoto.Text = "Fotoğraf Ekle";
            btnfoto.UseVisualStyleBackColor = true;
            btnfoto.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(txtstok);
            Controls.Add(txtfiyat);
            Controls.Add(txtfirma);
            Controls.Add(txtad);
            Controls.Add(txtbarkod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnfoto);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtbarkod;
        private TextBox txtad;
        private TextBox txtfirma;
        private TextBox txtfiyat;
        private TextBox txtstok;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnfoto;
    }
}