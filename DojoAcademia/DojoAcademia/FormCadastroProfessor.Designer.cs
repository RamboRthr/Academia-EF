
namespace DojoAcademia
{
    partial class FormCadastroProfessor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneALuno = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancelar.Location = new System.Drawing.Point(496, 167);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvar.Location = new System.Drawing.Point(415, 167);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(254, 58);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(90, 13);
            this.lblSalarioHora.TabIndex = 22;
            this.lblSalarioHora.Text = "Salário/Hora (R$)";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(127, 58);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 20;
            this.lblTurno.Text = "Turno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(21, 74);
            this.maskedTextBox2.Mask = "(99) 99999-9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 18;
            // 
            // lblTelefoneALuno
            // 
            this.lblTelefoneALuno.AutoSize = true;
            this.lblTelefoneALuno.Location = new System.Drawing.Point(21, 58);
            this.lblTelefoneALuno.Name = "lblTelefoneALuno";
            this.lblTelefoneALuno.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneALuno.TabIndex = 17;
            this.lblTelefoneALuno.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(453, 32);
            this.maskedTextBox1.Mask = "999,999,999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(453, 16);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 15;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 20);
            this.txtNome.TabIndex = 13;
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(257, 75);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(94, 20);
            this.txtSalarioHora.TabIndex = 25;
            // 
            // FormCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 235);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lblTelefoneALuno);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "FormCadastroProfessor";
            this.Text = "FormCadastroProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblTelefoneALuno;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioHora;
    }
}