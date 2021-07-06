using HerancaEComposicao.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaEComposicao
{
    public partial class FrmPessoas : Form
    {
        Compra compra;
        public FrmPessoas()
        {
            InitializeComponent();
            compra = new Compra();
        }

        private void FrmPessoas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compra.AdicionaItem(new Item(txtNome.Text, 
                double.Parse(txtQuantidade.Text), 
                double.Parse(txtPreco.Text)));
            AtualizaListBox();
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            compra.Cliente = txtCliente.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compra.SalvaItem(new Item(txtNome.Text,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtPreco.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //compra.RemoveItem()
        }

        private void AtualizaListBox()
        {
            listBox1.Items.Clear();
            foreach (var item in compra.Items)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
