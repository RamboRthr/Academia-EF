using DojoAcademia.Dominio;
using DojoAcademia.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DojoAcademia
{
    public partial class FormAlunos : Form
    {

        public FormAlunos()
        {
            InitializeComponent();

        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            var aluno1 = new Aluno();
            if (sender == btnNovoAluno)
            {
                alunoBindingSource.Add(aluno1);
                alunoBindingSource.MoveLast();
            }

            if (alunoBindingSource.Current == null) return;

            var aluno = alunoBindingSource.Current as Aluno;
            bool cpfVazio = string.IsNullOrEmpty(aluno.CPF);

            var form = new FormCadastroAluno(alunoBindingSource.Current as Aluno);
            if (form.ShowDialog() == DialogResult.Yes)
            {
                aluno = alunoBindingSource.Current as Aluno;

                using (var db = new AppDBContext())
                {
                    if (db.Entry(aluno).State == EntityState.Detached)
                    {
                        db.Set<Aluno>().Attach(aluno);
                    }

                    if (cpfVazio)
                    {
                        db.Entry(aluno).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(aluno).State = EntityState.Modified;
                    }

                    if (db.SaveChanges() > 0)
                    {
                        dataGridView1.Refresh();
                    }
                }
            }
            else
            {
                if (sender == btnNovoAluno)
                {
                    alunoBindingSource.RemoveCurrent();
                }
            }

        }
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            var aluno = alunoBindingSource.Current as Aluno;
            if (aluno == null) return;

            if (MessageBox.Show("Deseja realmente excluir o aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (new AlunoRepository().Delete(aluno) > 0)
            {
                alunoBindingSource.Remove(aluno);
                dataGridView1.Refresh();
            }
        }
        private void FormAlunos_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                alunoBindingSource.DataSource = db.Alunos.Include("Modalidade").ToList();
            }
        }
    }

    
}


