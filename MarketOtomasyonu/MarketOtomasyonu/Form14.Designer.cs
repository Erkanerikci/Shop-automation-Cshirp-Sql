namespace MarketOtomasyonu
{
    partial class Form14
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            labeltoplam = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(67, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 244);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(477, 50);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(219, 244);
            listBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürünler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 22);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Sepetiniz";
            // 
            // button1
            // 
            button1.Location = new Point(329, 170);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 2;
            button1.Text = "Sepete Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(486, 335);
            button2.Name = "button2";
            button2.Size = new Size(74, 31);
            button2.TabIndex = 2;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(592, 335);
            button3.Name = "button3";
            button3.Size = new Size(74, 31);
            button3.TabIndex = 2;
            button3.Text = "Ürün Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(544, 372);
            button4.Name = "button4";
            button4.Size = new Size(74, 31);
            button4.TabIndex = 2;
            button4.Text = "Sipariş Et";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labeltoplam
            // 
            labeltoplam.AutoSize = true;
            labeltoplam.Location = new Point(521, 307);
            labeltoplam.Name = "labeltoplam";
            labeltoplam.Size = new Size(0, 15);
            labeltoplam.TabIndex = 3;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labeltoplam);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label labeltoplam;
    }
}