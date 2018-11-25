namespace TCC
{
    partial class Login
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
            this.LabErro = new System.Windows.Forms.Label();
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
            this.TxtSenha.PasswordChar = '*';
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
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
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
            this.LinkCad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCad_LinkClicked);
            // 
            // LabErro
            // 
            this.LabErro.AutoSize = true;
            this.LabErro.ForeColor = System.Drawing.Color.Red;
            this.LabErro.Location = new System.Drawing.Point(78, 212);
            this.LabErro.Name = "LabErro";
            this.LabErro.Size = new System.Drawing.Size(115, 13);
            this.LabErro.TabIndex = 7;
            this.LabErro.Text = "Informações Incorretas";
            this.LabErro.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.LabErro);
            this.Controls.Add(this.LinkCad);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LabSenha);
            this.Controls.Add(this.LabUser);
            this.Name = "Login";
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
        private System.Windows.Forms.Label LabErro;
    }
}

