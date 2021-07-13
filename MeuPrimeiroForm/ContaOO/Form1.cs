using ContaOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaOO
{
    public partial class Form1 : Form
    {
        Conta conta = null;
        List<Conta> contas = new List<Conta>();
        public Form1()
        {
            InitializeComponent();
            conta = new ContaCorrente();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            if (conta.Saca(double.Parse(mskValor.Text)))
            {
                MessageBox.Show($"Numero = {conta.Numero} " +
                    $"Titular = {conta.Titular} Saldo Atual {conta.Saldo}");
            }
            else
            {
                MessageBox.Show($"Saldo insuficiente. Saldo Atual {conta.Saldo}");
            }
            mskValor.Text = conta.Saldo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    conta = new ContaCorrente() 
                    { Numero = 1, Titular = "Bruno" };
                    break;
                case 1:
                    conta = new ContaPoupanca()
                    { Numero = 1, Titular = "Bruno" };
                    button1.Enabled = true;
                    break;
                case 2:
                    conta = new ContaInvestimento()
                    { Numero = 1, Titular = "Bruno" };
                    dateTimePicker1.Enabled = true;
                    button1.Enabled = true;
                    break;
                default:
                    conta = new ContaCorrente();
                    break;
            }
            conta.Deposita(20);
            txtNumeroConta.Text = conta.Numero.ToString();
            txtTitular.Text = conta.Titular;
            mskValor.Text = conta.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conta is ContaInvestimento)
            {
                ContaInvestimento rendimento =(ContaInvestimento) conta;
                MessageBox.Show(Convert.ToString(rendimento.RenderMensalmente()));
            }
            if(conta is ContaPoupanca)
            {
                ContaPoupanca rendimento = (ContaPoupanca)conta;
                MessageBox.Show(Convert.ToString(rendimento.RenderMensalmente()));
            }
        }
    }
}
