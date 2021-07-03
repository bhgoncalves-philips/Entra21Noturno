using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dominio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Contato> contatos;
        bool novo;
        public Form1()
        {
            InitializeComponent();
            contatos = new List<Contato>();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            txtEmail.Text = "";
            txtNome.Text = "";
            maskedTextBox1.Text = "";
            txtNome.Focus();
            btnGravar.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                txtNome.Text = contatos[listBox1.SelectedIndex].Nome;
                txtEmail.Text = contatos[listBox1.SelectedIndex].Email;
                maskedTextBox1.Text = contatos[listBox1.SelectedIndex].Telefone;
                novo = false;
                btnGravar.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contatos.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (novo)
            {
                Contato contato = new Contato
                {
                    Email = txtEmail.Text,
                    Nome = txtNome.Text,
                    Telefone = maskedTextBox1.Text
                };
                contatos.Add(contato);
                listBox1.Items.Add(contato);
            }
            else
            {
                contatos[listBox1.SelectedIndex].Nome = txtNome.Text;
                contatos[listBox1.SelectedIndex].Email = txtEmail.Text;
                contatos[listBox1.SelectedIndex].Telefone = maskedTextBox1.Text;
            }

            listBox1.Items.Clear();
            foreach (var contato in contatos)
            {
                listBox1.Items.Add(contato);
            }
        }
    }
}
