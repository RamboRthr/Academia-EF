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
    public partial class FormCadastroModalidade : Form
    {
        Modalidade modalidade;
        public FormCadastroModalidade(Modalidade modalidade)
        {
            InitializeComponent();
            this.modalidade = modalidade;
        }

        private void FormCadastroModalidade_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add(new Binding("Text", modalidade, "Nome"));
            txtPrecoHora.DataBindings.Add(new Binding("Text", modalidade, "PrecoHora"));

            foreach (var item in cbxVezesSemana.Items)
            {
                if (int.Parse(item.ToString()) == modalidade.VezesSemana)
                {
                    cbxVezesSemana.SelectedItem = item;
                }
            }
            foreach (Professor professor in cbxProfessor.Items)
            {
                if (professor.ToString() == modalidade.Professor.Nome)
                {
                    cbxProfessor.SelectedItem = professor;
                }
            }
        }

        private void cbxVezesSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            modalidade.VezesSemana = Convert.ToInt32(cbxVezesSemana.SelectedItem);
        }

        private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            modalidade.Professor = cbxProfessor.SelectedItem as Professor;
        }
    }
}
