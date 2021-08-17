using DojoAcademia.Dominio;
using DojoAcademia.Repository;
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
    public partial class FormModalidades : Form
    {

        public FormModalidades()
        {
            InitializeComponent();
        }

        private void btnNovaModalidade_Click(object sender, EventArgs e)
        {
            var modalidade1 = new Modalidade();
            if (sender == btnNovaModalidade)
            {
                modalidadeBindingSource.Add(modalidade1);
                modalidadeBindingSource.MoveLast();
            }

            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (modalidade == null) return;

            var form = new FormCadastroModalidade(modalidade);


            if (form.ShowDialog() == DialogResult.Yes)
            {
                if (new ModaliadeRepository().Save(modalidade) > 0)
                {
                    dataGridView1.Refresh();
                }
            }
            else
            {
                if (sender == btnNovaModalidade)
                {
                    modalidadeBindingSource.RemoveCurrent();
                }
            }


        }

        private void FormModalidades_Load(object sender, EventArgs e)
        {
            using (var db = new AppDBContext())
            {
                modalidadeBindingSource.DataSource = db.Modalidades.Include("Professor").ToList();
            }
        }

        private void btnExcluirMoidalidade_Click(object sender, EventArgs e)
        {
            var modalidade = modalidadeBindingSource.Current as Modalidade;
            if (MessageBox.Show("Deseja excluir esta modalidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (new ModaliadeRepository().Delete(modalidade) > 0)
            {
                modalidadeBindingSource.RemoveCurrent();
                dataGridView1.Refresh();
            }

        }

        private void btnAlterarModalidade_Click(object sender, EventArgs e)
        {
            btnNovaModalidade_Click(sender, e);
        }
    }
}
