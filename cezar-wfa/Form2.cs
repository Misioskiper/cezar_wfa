using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cezar_wfa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int klucz = int.Parse(textBox1.Text);
            string wiad = wiadomosc.Text;
            string zaszfrowane = szyfry.szyfrowanie(klucz, wiad);
            MessageBox.Show("Zaszyfrowana wiadomość to: "+ zaszfrowane);
        }
    }
}
