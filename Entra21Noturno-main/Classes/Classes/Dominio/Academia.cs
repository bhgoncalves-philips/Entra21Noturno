using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.Dominio
{
    public class Academia
    {
        public List<Aluno> ListaAlunos { get; set; }
        public List<Professor> ListaProfessores { get; set; }
        public List<Modalidade> Modalidades { get; set; }

        public Academia()
        {
            ListaAlunos = new List<Aluno>();
            ListaProfessores = new List<Professor>();
            Modalidades = new List<Modalidade>();

        }

        public void AdicionarAluno(string nome, string telefone, string cpf, string turno)
        {
            ListaAlunos.Add(new Aluno(nome, telefone, cpf, turno));
        }

        public void AdicionarProfessor(string nome, string telefone, string cpf, string turno)
        {
            ListaProfessores.Add(new Professor()
            {
                Nome = nome,
                Telefone = telefone,
                CPF = cpf,
                Turno = turno
            });
        }

        public void AdicionarModalidade()
        {
            Modalidades.Add(new Modalidade());
        }

        public void AtualizarAluno(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno
            )
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
            ListaAlunos[indice].Turno = turno;
        }

        public void AtualizarProfessor(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno)
        {
            ListaProfessores[indice].Nome = nome;
            ListaProfessores[indice].Telefone = telefone;
            ListaProfessores[indice].CPF = cpf;
            ListaProfessores[indice].Turno = turno;
        }

        public void AtualizarModalidade(
            int indice,
            string nome,
            double precoHora,
            Professor professor,
            int vezesSemana)
        {
            Modalidades[indice].Nome = nome;
            Modalidades[indice].PrecoHora = precoHora;
            Modalidades[indice].Professor = professor;
            Modalidades[indice].VezesSemana = vezesSemana;
        }

        public string DadoAluno(int indice, string dado)
        {

            switch (dado)
            {
                case "Nome":
                    dado = ListaAlunos[indice].Nome;
                    break;
                case "Telefone":
                    dado = ListaAlunos[indice].Telefone;
                    break;
                case "CPF":
                    dado = ListaAlunos[indice].CPF;
                    break;
                case "Turno":
                    dado = ListaAlunos[indice].Turno;
                    break;
                case "Modalidade":
                    dado = ListaAlunos[indice].Modalidade.Nome;
                    break;
            }
            return dado;
        }

        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }

        public void DeletarProfessor(int indice)
        {
            ListaProfessores.RemoveAt(indice);
        }


    }
}
