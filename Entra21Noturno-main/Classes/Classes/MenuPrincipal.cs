using Classes.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class MenuPrincipal : Form
    {
        Academia academia;
        public MenuPrincipal()
        {
            academia = new Academia();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formulario formulario = new Formulario(academia);
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProfessores formulario = new FrmProfessores(academia);
            formulario.Show();
        }
    }
}
