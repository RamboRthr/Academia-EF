
namespace DojoAcademia
{
    partial class FormCadastroModalidade
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
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVezesSemana = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(158, 77);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(94, 20);
            this.txtSalarioHora.TabIndex = 37;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancelar.Location = new System.Drawing.Point(487, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvar.Location = new System.Drawing.Point(406, 169);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(155, 60);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(86, 13);
            this.lblSalarioHora.TabIndex = 34;
            this.lblSalarioHora.Text = "Preço/Hora (R$)";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(12, 60);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(51, 13);
            this.lblProfessor.TabIndex = 33;
            this.lblProfessor.Text = "Professor";
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(12, 76);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(121, 21);
            this.cbxProfessor.TabIndex = 32;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 20);
            this.txtNome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Vezes/Semana";
            // 
            // cbxVezesSemana
            // 
            this.cbxVezesSemana.FormattingEnabled = true;
            this.cbxVezesSemana.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x"});
            this.cbxVezesSemana.Location = new System.Drawing.Point(279, 76);
            this.cbxVezesSemana.Name = "cbxVezesSemana";
            this.cbxVezesSemana.Size = new System.Drawing.Size(121, 21);
            this.cbxVezesSemana.TabIndex = 38;
            // 
            // FormCadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxVezesSemana);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "FormCadastroModalidade";
            this.Text = "FormCadastroModalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVezesSemana;
    }
}