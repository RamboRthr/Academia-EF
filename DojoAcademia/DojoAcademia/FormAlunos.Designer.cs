
namespace DojoAcademia
{
    partial class FormAlunos
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
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
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
            this.modalidadeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.Location = new System.Drawing.Point(357, 168);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnNovoAluno.TabIndex = 1;
            this.btnNovoAluno.Text = "Novo";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Location = new System.Drawing.Point(438, 168);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 2;
            this.btnAlterarAluno.Text = "Alterar";
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(519, 168);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 3;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modalidadeDataGridViewTextBoxColumn
            // 
            this.modalidadeDataGridViewTextBoxColumn.DataPropertyName = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.HeaderText = "Modalidade";
            this.modalidadeDataGridViewTextBoxColumn.Name = "modalidadeDataGridViewTextBoxColumn";
            this.modalidadeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(DojoAcademia.Dominio.Aluno);
            // 
            // FormAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAlunos";
            this.Text = "FormAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
    }
}