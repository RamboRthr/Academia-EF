
namespace DojoAcademia
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnModalidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(159, 61);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(159, 90);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(75, 23);
            this.btnProfessores.TabIndex = 1;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // btnModalidades
            // 
            this.btnModalidades.Location = new System.Drawing.Point(159, 119);
            this.btnModalidades.Name = "btnModalidades";
            this.btnModalidades.Size = new System.Drawing.Size(75, 23);
            this.btnModalidades.TabIndex = 2;
            this.btnModalidades.Text = "Modalidades";
            this.btnModalidades.UseVisualStyleBackColor = true;
            this.btnModalidades.Click += new System.EventHandler(this.btnModalidades_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 239);
            this.Controls.Add(this.btnModalidades);
            this.Controls.Add(this.btnProfessores);
            this.Controls.Add(this.btnAlunos);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnModalidades;
    }
}

