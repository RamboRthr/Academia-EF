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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FormAlunos formAlunos = new FormAlunos();
            formAlunos.Show();

        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            FormProfessores formProfessores = new FormProfessores();
            formProfessores.Show();
        }

        private void btnModalidades_Click(object sender, EventArgs e)
        {
            FormModalidades formModalidades = new FormModalidades();
            formModalidades.Show();
        }
    }
}
