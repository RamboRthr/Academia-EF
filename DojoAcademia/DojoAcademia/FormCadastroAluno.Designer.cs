
namespace DojoAcademia
{
    partial class FormCadastroAluno
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneALuno = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(444, 9);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            this.maskCPF.Location = new System.Drawing.Point(444, 25);
            this.maskCPF.Mask = "999,999,999-99";
            this.maskCPF.Name = "maskedTextBox1";
            this.maskCPF.Size = new System.Drawing.Size(100, 20);
            this.maskCPF.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            this.maskTelefone.Location = new System.Drawing.Point(12, 67);
            this.maskTelefone.Mask = "(99) 99999-9999";
            this.maskTelefone.Name = "maskedTextBox2";
            this.maskTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskTelefone.TabIndex = 6;
            // 
            // lblTelefoneALuno
            // 
            this.lblTelefoneALuno.AutoSize = true;
            this.lblTelefoneALuno.Location = new System.Drawing.Point(12, 51);
            this.lblTelefoneALuno.Name = "lblTelefoneALuno";
            this.lblTelefoneALuno.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneALuno.TabIndex = 5;
            this.lblTelefoneALuno.Text = "Telefone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(118, 51);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modalidade";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvar.Location = new System.Drawing.Point(406, 160);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancelar.Location = new System.Drawing.Point(487, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 247);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.lblTelefoneALuno);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "FormCadastroAluno";
            this.Text = "FormCadastroAluno";
            this.Load += new System.EventHandler(this.FormCadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.Label lblTelefoneALuno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}