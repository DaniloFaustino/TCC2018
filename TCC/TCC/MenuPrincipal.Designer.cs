namespace TCC
{
    partial class MenuPrincipal
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
            this.LabUser = new System.Windows.Forms.Label();
            this.LabSenha = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LinkCad = new System.Windows.Forms.LinkLabel();
            this.LinkSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUser.Location = new System.Drawing.Point(78, 56);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(64, 17);
            this.LabUser.TabIndex = 0;
            this.LabUser.Text = "Usuário";
            // 
            // LabSenha
            // 
            this.LabSenha.AutoSize = true;
            this.LabSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSenha.Location = new System.Drawing.Point(78, 108);
            this.LabSenha.Name = "LabSenha";
            this.LabSenha.Size = new System.Drawing.Size(54, 17);
            this.LabSenha.TabIndex = 1;
            this.LabSenha.Text = "Senha";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(81, 76);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 20);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(81, 128);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 3;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(91, 154);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // LinkCad
            // 
            this.LinkCad.AutoSize = true;
            this.LinkCad.Location = new System.Drawing.Point(78, 189);
            this.LinkCad.Name = "LinkCad";
            this.LinkCad.Size = new System.Drawing.Size(108, 13);
            this.LinkCad.TabIndex = 5;
            this.LinkCad.TabStop = true;
            this.LinkCad.Text = "Não possuo cadastro";
            // 
            // LinkSenha
            // 
            this.LinkSenha.AutoSize = true;
            this.LinkSenha.Location = new System.Drawing.Point(78, 211);
            this.LinkSenha.Name = "LinkSenha";
            this.LinkSenha.Size = new System.Drawing.Size(108, 13);
            this.LinkSenha.TabIndex = 6;
            this.LinkSenha.TabStop = true;
            this.LinkSenha.Text = "Esqueci minha senha";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LinkSenha);
            this.Controls.Add(this.LinkCad);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LabSenha);
            this.Controls.Add(this.LabUser);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.Label LabSenha;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.LinkLabel LinkCad;
        private System.Windows.Forms.LinkLabel LinkSenha;
    }
}

