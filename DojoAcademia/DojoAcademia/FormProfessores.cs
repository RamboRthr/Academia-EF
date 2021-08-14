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
    public partial class FormProfessores : Form
    {
        public FormProfessores()
        {
            InitializeComponent();
        }

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            var professor1 = new Professor();
            if (sender == btnNovoProfessor)
            {
                professorBindingSource.Add(professor1);
                professorBindingSource.MoveLast();
            }

            if (professorBindingSource.Current == null) return;

            using (var form =
                new FormCadastroProfessor(
                    professorBindingSource.Current as Professor))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    var professor = professorBindingSource.Current as Professor;

                    if (new ProfessorRepository().Save(professor) > 0)
                    {
                        dataGridView1.Refresh();
                    }
                    
                }
                else
                {
                    if (sender == btnNovoProfessor)
                    {
                        professorBindingSource.RemoveCurrent();
                    }
                }

            }
        }

        private void FormProfessores_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                professorBindingSource.DataSource = db.Professores.ToList();
            }
        }

        private void btnExcluirProfessor_Click(object sender, EventArgs e)
        {
            var professor = professorBindingSource.Current as Professor;
            if (professor == null) return;

            if (MessageBox.Show("Deseja realmente excluir o aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (new ProfessorRepository().Delete(professor) > 0)
            {
                professorBindingSource.Remove(professor);
                dataGridView1.Refresh();
            }
        }
    }
}
