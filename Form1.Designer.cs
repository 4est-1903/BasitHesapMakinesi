namespace stajornekler8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblsonuc = new Label();
            rdbtntopla = new RadioButton();
            rdbtncikar = new RadioButton();
            rdbtncarp = new RadioButton();
            rdbtnbol = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtsayi1 = new TextBox();
            txtsayi2 = new TextBox();
            btntemizle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 115);
            label1.Name = "label1";
            label1.Size = new Size(145, 34);
            label1.TabIndex = 0;
            label1.Text = "1. Sayıyı Girin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 173);
            label2.Name = "label2";
            label2.Size = new Size(149, 34);
            label2.TabIndex = 1;
            label2.Text = "2. Sayıyı Girin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Haettenschweiler", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(141, 294);
            label3.Name = "label3";
            label3.Size = new Size(76, 34);
            label3.TabIndex = 2;
            label3.Text = "Sonuç:";
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Font = new Font("Haettenschweiler", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblsonuc.ForeColor = Color.OrangeRed;
            lblsonuc.Location = new Point(223, 294);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(20, 34);
            lblsonuc.TabIndex = 3;
            lblsonuc.Text = " ";
            lblsonuc.Click += label4_Click;
            // 
            // rdbtntopla
            // 
            rdbtntopla.AutoSize = true;
            rdbtntopla.Location = new Point(27, 42);
            rdbtntopla.Name = "rdbtntopla";
            rdbtntopla.Size = new Size(94, 24);
            rdbtntopla.TabIndex = 4;
            rdbtntopla.TabStop = true;
            rdbtntopla.Text = "Toplama +";
            rdbtntopla.UseVisualStyleBackColor = true;
            // 
            // rdbtncikar
            // 
            rdbtncikar.AutoSize = true;
            rdbtncikar.Location = new Point(27, 87);
            rdbtncikar.Name = "rdbtncikar";
            rdbtncikar.Size = new Size(90, 24);
            rdbtncikar.TabIndex = 5;
            rdbtncikar.TabStop = true;
            rdbtncikar.Text = "Çıkarma -";
            rdbtncikar.UseVisualStyleBackColor = true;
            // 
            // rdbtncarp
            // 
            rdbtncarp.AutoSize = true;
            rdbtncarp.Location = new Point(27, 134);
            rdbtncarp.Name = "rdbtncarp";
            rdbtncarp.Size = new Size(86, 24);
            rdbtncarp.TabIndex = 6;
            rdbtncarp.TabStop = true;
            rdbtncarp.Text = "Çarpma *";
            rdbtncarp.UseVisualStyleBackColor = true;
            // 
            // rdbtnbol
            // 
            rdbtnbol.AutoSize = true;
            rdbtnbol.Location = new Point(27, 179);
            rdbtnbol.Name = "rdbtnbol";
            rdbtnbol.Size = new Size(77, 24);
            rdbtnbol.TabIndex = 7;
            rdbtnbol.TabStop = true;
            rdbtnbol.Text = "Bölme /";
            rdbtnbol.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtnbol);
            groupBox1.Controls.Add(rdbtncarp);
            groupBox1.Controls.Add(rdbtncikar);
            groupBox1.Controls.Add(rdbtntopla);
            groupBox1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(604, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 249);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(141, 234);
            button1.Name = "button1";
            button1.Size = new Size(161, 39);
            button1.TabIndex = 9;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtsayi1
            // 
            txtsayi1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsayi1.Location = new Point(292, 118);
            txtsayi1.Name = "txtsayi1";
            txtsayi1.Size = new Size(200, 31);
            txtsayi1.TabIndex = 10;
            // 
            // txtsayi2
            // 
            txtsayi2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsayi2.Location = new Point(292, 176);
            txtsayi2.Name = "txtsayi2";
            txtsayi2.Size = new Size(200, 31);
            txtsayi2.TabIndex = 11;
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.Black;
            btntemizle.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btntemizle.ForeColor = Color.AliceBlue;
            btntemizle.Location = new Point(331, 234);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(161, 39);
            btntemizle.TabIndex = 12;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(908, 471);
            Controls.Add(btntemizle);
            Controls.Add(txtsayi2);
            Controls.Add(txtsayi1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(lblsonuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblsonuc;
        private RadioButton rdbtntopla;
        private RadioButton rdbtncikar;
        private RadioButton rdbtncarp;
        private RadioButton rdbtnbol;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtsayi1;
        private TextBox txtsayi2;
        private Button btntemizle;
    }
}