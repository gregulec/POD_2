using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POD_2
{
    public partial class Form1 : Form
    {
        private string text;
        int key;
        private Beaufort b = new Beaufort();
        public Form1()
        {
            InitializeComponent();
        }

        private void encryption_Click(object sender, EventArgs e)
        {
            key = Convert.ToInt32(tb4.Text);
            tb2.Text = b.encryption(tb1.Text,key);
        }
        private void decryption_Click(object sender, EventArgs e)
        {
            key = Convert.ToInt32(tb4.Text);
            tb3.Text = b.decryption(tb2.Text,key);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb1.Text = String.Empty;
            tb2.Text = String.Empty;
            tb3.Text = String.Empty;
        }

        private void savezaszyfrowany_Click(object sender, EventArgs e)
        {
            if (tb2.Text.Length == 0) MessageBox.Show("       WPISZ TEKST DO ZASZYFROWANIA");
            System.IO.File.WriteAllText(@"C:\Users\Public\Beaufort_s.txt", tb2.Text);
        }
       
        private void savejawny_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Length == 0) MessageBox.Show("       WPISZ TEKST DO ZASZYFROWANIA");
            System.IO.File.WriteAllText(@"C:\Users\Public\Beaufort.txt", tb1.Text);
        }

        private void readjawny_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Users\Public\Beaufort.txt") == false)
            {
                MessageBox.Show("    PLIK NIE ISTNIEJE");
            }
            else
            {
                text = System.IO.File.ReadAllText(@"C:\Users\Public\Beaufort.txt");
                tb1.Text = text;
            }
        }

        private void readzaszyfrowany_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Users\Public\Beaufort_s.txt") == false)
            {
                MessageBox.Show("    PLIK NIE ISTNIEJE");
            }
            else
            {
                text = System.IO.File.ReadAllText(@"C:\Users\Public\Beaufort_s.txt");
                tb2.Text = text;
            }
        }

        private void documentation_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
        
        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class Beaufort
    {
        char[] alfabet = new char[27] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',' ' };
        
        public string encryption(string text, int k)
        {
            string after = "";
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (text[i] == alfabet[j])
                    {
                        if (j != 26)
                        {

                            Console.WriteLine(j);
                            int q = 26 - j + k;
                            if (q < 0) q = q + 26;
                            else if (q > 25) q = q - 26;
                            after = after + alfabet[q];
                        }
                        else after = after + text[i];
                    }
                }
            }
            return after;
        }
        public string decryption(string text, int k)
        {
            return encryption(text, k);
        }
    }
}
