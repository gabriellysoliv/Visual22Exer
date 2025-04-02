namespace aplicativo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.excluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagina principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(329, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "text aligin intem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.excluir.Location = new System.Drawing.Point(332, 251);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 24);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(332, 193);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Location = new System.Drawing.Point(333, 222);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(75, 23);
            this.atualizar.TabIndex = 7;
            this.atualizar.Text = "atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "titulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
    }
}

