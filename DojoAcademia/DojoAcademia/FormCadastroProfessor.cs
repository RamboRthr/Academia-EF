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
    public partial class FormCadastroProfessor : Form
    {
        Professor professor;
        public FormCadastroProfessor(Professor professor1)
        {
            InitializeComponent();
            professor = professor1;
        }

        private void FormCadastroProfessor_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", professor, "Nome");
            mskCPF.DataBindings.Add("Text", professor, "CPF");
            mskCPF.Enabled = string.IsNullOrEmpty(professor.CPF);
            mskTelefone.DataBindings.Add("Text", professor, "Telefone");
            foreach (var item in cbxTurno.Items)
            {
                if (item.ToString() == professor.Turno)
                {
                    cbxTurno.SelectedItem = item;
                }
            }
            txtSalarioHora.DataBindings.Add(new Binding("Text",professor,"SalarioHora" ));
        }



        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            professor.Turno = cbxTurno.SelectedItem.ToString();
        }
    }
}
