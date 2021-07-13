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
    public partial class FrmProfessores : Form
    {
        Academia _academia;
        bool novo;
        bool pagar = false;
        bool verificacao;
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
        public FrmProfessores(Academia academia)
        {
            InitializeComponent();
            _academia = academia;
        }


        private void Formulario_Load(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            LimparDados();
            novo = true;
            txtNome.Focus();
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                if (novo)
                {
                    _academia.AdicionarProfessor(
                        txtNome.Text,
                        mskTelefone.Text,
                        mskCPF.Text,
                        cbxTurno.SelectedItem.ToString()
                        );
                }
                else
                {
                    if (lbxProfessores.SelectedIndex >= 0)
                    {
                        _academia.AtualizarProfessor(
                            lbxProfessores.SelectedIndex,
                            txtNome.Text,
                            mskTelefone.Text,
                            mskCPF.Text,
                            cbxTurno.SelectedItem.ToString()
                            );
                    }

                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
            pagar = false;
            novo = false;
            AtualizarListaProfessores();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxProfessores.SelectedIndex >= 0)
            {
                _academia.DeletarProfessor(lbxProfessores.SelectedIndex);
            }
            LimparDados();
            AtualizarListaProfessores();
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
        }


        private void lbxProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbxProfessores.SelectedIndex;
            if (indice >= 0)
            {
                txtNome.Text = _academia.ListaProfessores[indice].Nome;
                mskTelefone.Text = _academia.ListaProfessores[indice].Telefone;
                mskCPF.Text = _academia.ListaProfessores[indice].CPF;
                cbxTurno.SelectedItem = _academia.ListaProfessores[indice].Turno;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
                novo = false;
            }
        }

        private void AtualizarListaProfessores()
        {
            lbxProfessores.Items.Clear();
            foreach (var professor in _academia.ListaProfessores)
            {
                lbxProfessores.Items.Add(professor);
            }
        }

        private void LimparDados()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            mskCPF.Clear();
            cbxTurno.SelectedItem = null;
        }

        private bool VerificarDados()
        {
            verificacao = true;
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Nome.";
            }
            if (!mskTelefone.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Telefone.";
            }
            if (!mskCPF.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> CPF.";
            }
            if (cbxTurno.SelectedItem == null)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Turno.";
            }
            return verificacao;
        }


    }
}
