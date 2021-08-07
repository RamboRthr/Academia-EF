using DojoAcademia.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DojoAcademia
{
    public partial class FormCadastroAluno : Form
    {
        Aluno aluno;
        public FormCadastroAluno(Aluno aluno1)
        {
            InitializeComponent();
            aluno = aluno1;
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", aluno, "Nome");
            maskCPF.DataBindings.Add("Text", aluno, "CPF");
            maskTelefone.DataBindings.Add("Text", aluno, "Telefone");

        }
    }
}
