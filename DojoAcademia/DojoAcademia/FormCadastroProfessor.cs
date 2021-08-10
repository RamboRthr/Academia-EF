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
            mskTelefone.DataBindings.Add("Text", professor, "Telefone");
            turnoBindingSource.DataSource = new AppDBContext().Turnos.ToList();
            foreach (var turno in professor.Turnos)
            {
                cbxTurno.Items.Add(turno.Nome);
            }
            cbxTurno.SelectedItem = professor.Turnos[0];
            cbxSalarioHora.DataBindings.Add("Text", professor, "Telefone");

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
