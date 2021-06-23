using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroForm
{
    public partial class Form1 : Form
    {
        int numero1, numero2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{numero1 + numero2}");
        }

        private void btnSubtracao_click(object sender, EventArgs e)
        {
            MessageBox.Show($"{numero1 - numero2}");
        }

        private void txtNumero2_Leave(object sender, EventArgs e)
        {
            numero2 = int.Parse(txtNumero2.Text);
        }

        private void txtNumero1_Leave(object sender, EventArgs e)
        {
            numero1 = int.Parse(txtNumero1.Text);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{numero1 * numero2}");
        }
    }
}
