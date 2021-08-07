
namespace DojoAcademia
{
    partial class FormProfessores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnAlterarProfessor = new System.Windows.Forms.Button();
            this.btnNovoProfessor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnoDataGridViewTextBoxColumn,
            this.salarioHoraDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.professorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(DojoAcademia.Dominio.Professor);
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioHoraDataGridViewTextBoxColumn
            // 
            this.salarioHoraDataGridViewTextBoxColumn.DataPropertyName = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.HeaderText = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.Name = "salarioHoraDataGridViewTextBoxColumn";
            this.salarioHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.Location = new System.Drawing.Point(515, 168);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 6;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = true;
            // 
            // btnAlterarProfessor
            // 
            this.btnAlterarProfessor.Location = new System.Drawing.Point(434, 168);
            this.btnAlterarProfessor.Name = "btnAlterarProfessor";
            this.btnAlterarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarProfessor.TabIndex = 5;
            this.btnAlterarProfessor.Text = "Alterar";
            this.btnAlterarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnNovoProfessor
            // 
            this.btnNovoProfessor.Location = new System.Drawing.Point(353, 168);
            this.btnNovoProfessor.Name = "btnNovoProfessor";
            this.btnNovoProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProfessor.TabIndex = 4;
            this.btnNovoProfessor.Text = "Novo";
            this.btnNovoProfessor.UseVisualStyleBackColor = true;
            // 
            // FormProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.btnAlterarProfessor);
            this.Controls.Add(this.btnNovoProfessor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProfessores";
            this.Text = "FormProfessores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnAlterarProfessor;
        private System.Windows.Forms.Button btnNovoProfessor;
    }
}