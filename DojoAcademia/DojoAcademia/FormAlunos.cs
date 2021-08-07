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

            using (var form =
                new FormCadastroAluno(
                    alunoBindingSource.Current as Aluno))
            {
                if (form.ShowDialog() == DialogResult.Yes)
                {
                    var aluno = alunoBindingSource.Current as Aluno;

                    using (var db = new AppDBContext())
                    {
                        if (db.Entry(aluno).State == EntityState.Detached)
                        {
                            db.Set<Aluno>().Attach(aluno);
                        }
                        if (String.IsNullOrEmpty(aluno.CPF))
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
        }
    }
}
