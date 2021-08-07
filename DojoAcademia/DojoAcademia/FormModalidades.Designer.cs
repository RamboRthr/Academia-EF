
namespace DojoAcademia
{
    partial class FormModalidades
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
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezesSemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirMoidalidade = new System.Windows.Forms.Button();
            this.btnAlterarModalidade = new System.Windows.Forms.Button();
            this.btnNovaModalidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.precoHoraDataGridViewTextBoxColumn,
            this.vezesSemanaDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modalidadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(467, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(DojoAcademia.Dominio.Modalidade);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoHoraDataGridViewTextBoxColumn
            // 
            this.precoHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.HeaderText = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.Name = "precoHoraDataGridViewTextBoxColumn";
            this.precoHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vezesSemanaDataGridViewTextBoxColumn
            // 
            this.vezesSemanaDataGridViewTextBoxColumn.DataPropertyName = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.HeaderText = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.Name = "vezesSemanaDataGridViewTextBoxColumn";
            this.vezesSemanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnExcluirMoidalidade
            // 
            this.btnExcluirMoidalidade.Location = new System.Drawing.Point(404, 168);
            this.btnExcluirMoidalidade.Name = "btnExcluirMoidalidade";
            this.btnExcluirMoidalidade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirMoidalidade.TabIndex = 6;
            this.btnExcluirMoidalidade.Text = "Excluir";
            this.btnExcluirMoidalidade.UseVisualStyleBackColor = true;
            // 
            // btnAlterarModalidade
            // 
            this.btnAlterarModalidade.Location = new System.Drawing.Point(323, 168);
            this.btnAlterarModalidade.Name = "btnAlterarModalidade";
            this.btnAlterarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarModalidade.TabIndex = 5;
            this.btnAlterarModalidade.Text = "Alterar";
            this.btnAlterarModalidade.UseVisualStyleBackColor = true;
            // 
            // btnNovaModalidade
            // 
            this.btnNovaModalidade.Location = new System.Drawing.Point(242, 168);
            this.btnNovaModalidade.Name = "btnNovaModalidade";
            this.btnNovaModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnNovaModalidade.TabIndex = 4;
            this.btnNovaModalidade.Text = "Nova";
            this.btnNovaModalidade.UseVisualStyleBackColor = true;
            // 
            // FormModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.btnExcluirMoidalidade);
            this.Controls.Add(this.btnAlterarModalidade);
            this.Controls.Add(this.btnNovaModalidade);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormModalidades";
            this.Text = "FormModalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezesSemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.Button btnExcluirMoidalidade;
        private System.Windows.Forms.Button btnAlterarModalidade;
        private System.Windows.Forms.Button btnNovaModalidade;
    }
}