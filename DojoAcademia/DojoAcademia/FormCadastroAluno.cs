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
            mskCpf.DataBindings.Add("Text", aluno, "CPF");
            mskCpf.Enabled = string.IsNullOrEmpty(aluno.CPF);
            mskTelefone.DataBindings.Add("Text", aluno, "Telefone");
            using (var db = new AppDBContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.OrderBy(m => m.Nome).ToList();
            }

            foreach (var item in cbxTurno.Items)
            {
                if (item.ToString() == aluno.TurnoAluno)
                {
                    cbxTurno.SelectedItem = item;
                }
            }

            if (aluno.Modalidade != null)
            {
                foreach (var item in cbxTurno.Items)
                {
                    var modalidade = item as Modalidade;
                    if (modalidade.Nome == aluno.Modalidade.Nome)
                    {
                        cbxTurno.SelectedItem = item;
                    }
                }
            }
            else
            {
                aluno.Modalidade = cbxTurno.Items[0] as Modalidade;
            }
            

                 
        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            aluno.TurnoAluno = cbxTurno.SelectedItem.ToString();
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            aluno.Modalidade =  cbxModalidade.SelectedItem as Modalidade;
        }
    }
}
