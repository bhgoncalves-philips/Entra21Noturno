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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> nomes, telefones, emails;
        bool novo;
        public Form1()
        {
            InitializeComponent();
            nomes = new List<string>();
            telefones = new List<string>();
            emails = new List<string>();
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
                txtNome.Text = nomes[listBox1.SelectedIndex];
                txtEmail.Text = emails[listBox1.SelectedIndex];
                maskedTextBox1.Text = telefones[listBox1.SelectedIndex];
                novo = false;
                btnGravar.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                emails.Add(txtEmail.Text);
                nomes.Add(txtNome.Text);
                telefones.Add(maskedTextBox1.Text);
                listBox1.Items.Clear();
            }
            else
            {
                nomes[listBox1.SelectedIndex] = txtNome.Text;
                emails[listBox1.SelectedIndex] = txtEmail.Text;
                telefones[listBox1.SelectedIndex] = maskedTextBox1.Text;
            }

            foreach (var nome in nomes)
            {
                listBox1.Items.Add(nome);
            }
        }
    }
}
