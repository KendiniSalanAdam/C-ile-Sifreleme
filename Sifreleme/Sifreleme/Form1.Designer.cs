namespace Sifreleme
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
            this.Sifrele = new System.Windows.Forms.Button();
            this.SifreCöz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sifrele
            // 
            this.Sifrele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sifrele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sifrele.Location = new System.Drawing.Point(67, 32);
            this.Sifrele.Name = "Sifrele";
            this.Sifrele.Size = new System.Drawing.Size(103, 24);
            this.Sifrele.TabIndex = 0;
            this.Sifrele.Text = "Şifrele";
            this.Sifrele.UseVisualStyleBackColor = true;
            this.Sifrele.Click += new System.EventHandler(this.button1_Click);
            // 
            // SifreCöz
            // 
            this.SifreCöz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SifreCöz.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SifreCöz.Location = new System.Drawing.Point(67, 207);
            this.SifreCöz.Name = "SifreCöz";
            this.SifreCöz.Size = new System.Drawing.Size(103, 30);
            this.SifreCöz.TabIndex = 1;
            this.SifreCöz.Text = "Şifreyi Çöz";
            this.SifreCöz.UseVisualStyleBackColor = true;
            this.SifreCöz.Click += new System.EventHandler(this.SifreCöz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifrelenmiş Metin";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 23);
            this.textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(559, 313);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SifreCöz);
            this.Controls.Add(this.Sifrele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sifrele;
        private Button SifreCöz;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
    }
}