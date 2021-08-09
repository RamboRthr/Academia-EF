using DojoAcademia.Dominio;
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

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(professor).State == EntityState.Detached)
                        {
                            db.Set<Professor>().Attach(professor);
                        }
                        if (String.IsNullOrEmpty(professor.CPF))
                        {
                            db.Entry(professor).State = EntityState.Added;
                        }
                        else
                        {
                            db.Entry(professor).State = EntityState.Modified;
                        }

                        if (db.SaveChanges() > 0)
                        {
                            dataGridView1.Refresh();
                        }
                    }


                }
                /*else
                {
                    if (sender == btnNovoProfessor)
                    {
                        professorBindingSource.RemoveCurrent();
                    }
                }*/

            }
        }

        private void FormProfessores_Load(object sender, EventArgs e)
        {

        }
    }
}
