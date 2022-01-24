namespace POD_2
{
    partial class Form1
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
            this.encryption = new System.Windows.Forms.Button();
            this.decryption = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.savezaszyfrowany = new System.Windows.Forms.Button();
            this.savejawny = new System.Windows.Forms.Button();
            this.readjawny = new System.Windows.Forms.Button();
            this.readzaszyfrowany = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.documentation = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(437, 12);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(75, 23);
            this.encryption.TabIndex = 0;
            this.encryption.Text = "szyfruj";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // decryption
            // 
            this.decryption.Location = new System.Drawing.Point(437, 55);
            this.decryption.Name = "decryption";
            this.decryption.Size = new System.Drawing.Size(75, 23);
            this.decryption.TabIndex = 1;
            this.decryption.Text = "deszyfruj";
            this.decryption.UseVisualStyleBackColor = true;
            this.decryption.Click += new System.EventHandler(this.decryption_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(437, 97);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "czyść pola";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // savezaszyfrowany
            // 
            this.savezaszyfrowany.Location = new System.Drawing.Point(12, 258);
            this.savezaszyfrowany.Name = "savezaszyfrowany";
            this.savezaszyfrowany.Size = new System.Drawing.Size(104, 55);
            this.savezaszyfrowany.TabIndex = 3;
            this.savezaszyfrowany.Text = "zapisz do pliku tekst zaszyfrowany";
            this.savezaszyfrowany.UseVisualStyleBackColor = true;
            this.savezaszyfrowany.Click += new System.EventHandler(this.savezaszyfrowany_Click);
            // 
            // savejawny
            // 
            this.savejawny.Location = new System.Drawing.Point(122, 258);
            this.savejawny.Name = "savejawny";
            this.savejawny.Size = new System.Drawing.Size(99, 55);
            this.savejawny.TabIndex = 4;
            this.savejawny.Text = "zapisz do pliku tekst jawny";
            this.savejawny.UseVisualStyleBackColor = true;
            this.savejawny.Click += new System.EventHandler(this.savejawny_Click);
            // 
            // readjawny
            // 
            this.readjawny.Location = new System.Drawing.Point(227, 258);
            this.readjawny.Name = "readjawny";
            this.readjawny.Size = new System.Drawing.Size(98, 55);
            this.readjawny.TabIndex = 5;
            this.readjawny.Text = "czytaj z pliku tekst jawny";
            this.readjawny.UseVisualStyleBackColor = true;
            this.readjawny.Click += new System.EventHandler(this.readjawny_Click);
            // 
            // readzaszyfrowany
            // 
            this.readzaszyfrowany.Location = new System.Drawing.Point(331, 258);
            this.readzaszyfrowany.Name = "readzaszyfrowany";
            this.readzaszyfrowany.Size = new System.Drawing.Size(100, 55);
            this.readzaszyfrowany.TabIndex = 6;
            this.readzaszyfrowany.Text = "czytaj z pliku tekst zaszyfrowany";
            this.readzaszyfrowany.UseVisualStyleBackColor = true;
            this.readzaszyfrowany.Click += new System.EventHandler(this.readzaszyfrowany_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 12);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(371, 20);
            this.tb1.TabIndex = 7;
            this.tb1.Text = "tekst jawny";
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(12, 55);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(371, 20);
            this.tb2.TabIndex = 8;
            this.tb2.Text = "tekst zaszyfrowany";
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(12, 100);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(371, 20);
            this.tb3.TabIndex = 9;
            this.tb3.Text = "tekst rozkodowany";
            this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
            // 
            // documentation
            // 
            this.documentation.Location = new System.Drawing.Point(437, 258);
            this.documentation.Name = "documentation";
            this.documentation.Size = new System.Drawing.Size(86, 55);
            this.documentation.TabIndex = 10;
            this.documentation.Text = "dokumentacja";
            this.documentation.UseVisualStyleBackColor = true;
            this.documentation.Click += new System.EventHandler(this.documentation_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(12, 168);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 11;
            this.tb4.Text = "klucz 0-25";
            this.tb4.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 374);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.documentation);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.readzaszyfrowany);
            this.Controls.Add(this.readjawny);
            this.Controls.Add(this.savejawny);
            this.Controls.Add(this.savezaszyfrowany);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.decryption);
            this.Controls.Add(this.encryption);
            this.Name = "Form1";
            this.Text = "Beaufort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.Button decryption;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button savezaszyfrowany;
        private System.Windows.Forms.Button savejawny;
        private System.Windows.Forms.Button readjawny;
        private System.Windows.Forms.Button readzaszyfrowany;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button documentation;
        private System.Windows.Forms.TextBox tb4;
    }
}

