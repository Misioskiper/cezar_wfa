using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace cezar_wfa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int klucz = int.Parse(textBox1.Text);
            string wiad = wiadomosc.Text;
            string zaszfrowane = szyfry.deszyfrowanie(klucz, wiad);
            MessageBox.Show("Odszyfrowana wiadomość to: " + zaszfrowane);
           
        }
    }
}
