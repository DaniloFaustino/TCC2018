namespace TCC
{
    partial class CadastroSindico
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
            this.LabSindico = new System.Windows.Forms.Label();
            this.GroupInfoPessoais = new System.Windows.Forms.GroupBox();
            this.LabNome = new System.Windows.Forms.Label();
            this.LabTipo = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabCNPJ_CPF = new System.Windows.Forms.Label();
            this.TxtCNPJ_CPF = new System.Windows.Forms.TextBox();
            this.GroupInfoLogin = new System.Windows.Forms.GroupBox();
            this.LabEmail = new System.Windows.Forms.Label();
            this.LabUser = new System.Windows.Forms.Label();
            this.LabSenha = new System.Windows.Forms.Label();
            this.LabConfirmarSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.MaskedTextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.GroupInfoPessoais.SuspendLayout();
            this.GroupInfoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabSindico
            // 
            this.LabSindico.AutoSize = true;
            this.LabSindico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSindico.Location = new System.Drawing.Point(205, 9);
            this.LabSindico.Name = "LabSindico";
            this.LabSindico.Size = new System.Drawing.Size(168, 17);
            this.LabSindico.TabIndex = 0;
            this.LabSindico.Text = "Síndico/Administração";
            // 
            // GroupInfoPessoais
            // 
            this.GroupInfoPessoais.Controls.Add(this.TxtCNPJ_CPF);
            this.GroupInfoPessoais.Controls.Add(this.LabCNPJ_CPF);
            this.GroupInfoPessoais.Controls.Add(this.label4);
            this.GroupInfoPessoais.Controls.Add(this.TxtNome);
            this.GroupInfoPessoais.Controls.Add(this.ComboTipo);
            this.GroupInfoPessoais.Controls.Add(this.LabTipo);
            this.GroupInfoPessoais.Controls.Add(this.LabNome);
            this.GroupInfoPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupInfoPessoais.Location = new System.Drawing.Point(47, 54);
            this.GroupInfoPessoais.Name = "GroupInfoPessoais";
            this.GroupInfoPessoais.Size = new System.Drawing.Size(459, 94);
            this.GroupInfoPessoais.TabIndex = 1;
            this.GroupInfoPessoais.TabStop = false;
            this.GroupInfoPessoais.Text = "Informações Pessoais";
            this.GroupInfoPessoais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabNome
            // 
            this.LabNome.AutoSize = true;
            this.LabNome.Location = new System.Drawing.Point(15, 30);
            this.LabNome.Name = "LabNome";
            this.LabNome.Size = new System.Drawing.Size(49, 17);
            this.LabNome.TabIndex = 0;
            this.LabNome.Text = "Nome:";
            // 
            // LabTipo
            // 
            this.LabTipo.AutoSize = true;
            this.LabTipo.Location = new System.Drawing.Point(18, 60);
            this.LabTipo.Name = "LabTipo";
            this.LabTipo.Size = new System.Drawing.Size(40, 17);
            this.LabTipo.TabIndex = 1;
            this.LabTipo.Text = "Tipo:";
            // 
            // ComboTipo
            // 
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Location = new System.Drawing.Point(64, 60);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(121, 24);
            this.ComboTipo.TabIndex = 2;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(76, 30);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 23);
            this.TxtNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // LabCNPJ_CPF
            // 
            this.LabCNPJ_CPF.AutoSize = true;
            this.LabCNPJ_CPF.Location = new System.Drawing.Point(205, 30);
            this.LabCNPJ_CPF.Name = "LabCNPJ_CPF";
            this.LabCNPJ_CPF.Size = new System.Drawing.Size(77, 17);
            this.LabCNPJ_CPF.TabIndex = 5;
            this.LabCNPJ_CPF.Text = "CNPJ/CPF:";
            // 
            // TxtCNPJ_CPF
            // 
            this.TxtCNPJ_CPF.Location = new System.Drawing.Point(298, 30);
            this.TxtCNPJ_CPF.Name = "TxtCNPJ_CPF";
            this.TxtCNPJ_CPF.Size = new System.Drawing.Size(100, 23);
            this.TxtCNPJ_CPF.TabIndex = 6;
            // 
            // GroupInfoLogin
            // 
            this.GroupInfoLogin.Controls.Add(this.TxtConfirmarSenha);
            this.GroupInfoLogin.Controls.Add(this.TxtUser);
            this.GroupInfoLogin.Controls.Add(this.TxtSenha);
            this.GroupInfoLogin.Controls.Add(this.TxtEmail);
            this.GroupInfoLogin.Controls.Add(this.LabConfirmarSenha);
            this.GroupInfoLogin.Controls.Add(this.LabSenha);
            this.GroupInfoLogin.Controls.Add(this.LabUser);
            this.GroupInfoLogin.Controls.Add(this.LabEmail);
            this.GroupInfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupInfoLogin.Location = new System.Drawing.Point(47, 166);
            this.GroupInfoLogin.Name = "GroupInfoLogin";
            this.GroupInfoLogin.Size = new System.Drawing.Size(459, 100);
            this.GroupInfoLogin.TabIndex = 2;
            this.GroupInfoLogin.TabStop = false;
            this.GroupInfoLogin.Text = "Informações de Login";
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Location = new System.Drawing.Point(21, 33);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(46, 17);
            this.LabEmail.TabIndex = 0;
            this.LabEmail.Text = "Email:";
            // 
            // LabUser
            // 
            this.LabUser.AutoSize = true;
            this.LabUser.Location = new System.Drawing.Point(205, 33);
            this.LabUser.Name = "LabUser";
            this.LabUser.Size = new System.Drawing.Size(61, 17);
            this.LabUser.TabIndex = 1;
            this.LabUser.Text = "Usuário:";
            // 
            // LabSenha
            // 
            this.LabSenha.AutoSize = true;
            this.LabSenha.Location = new System.Drawing.Point(24, 67);
            this.LabSenha.Name = "LabSenha";
            this.LabSenha.Size = new System.Drawing.Size(53, 17);
            this.LabSenha.TabIndex = 2;
            this.LabSenha.Text = "Senha:";
            // 
            // LabConfirmarSenha
            // 
            this.LabConfirmarSenha.AutoSize = true;
            this.LabConfirmarSenha.Location = new System.Drawing.Point(208, 67);
            this.LabConfirmarSenha.Name = "LabConfirmarSenha";
            this.LabConfirmarSenha.Size = new System.Drawing.Size(118, 17);
            this.LabConfirmarSenha.TabIndex = 3;
            this.LabConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(76, 33);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 23);
            this.TxtEmail.TabIndex = 4;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(84, 67);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 23);
            this.TxtSenha.TabIndex = 5;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(282, 30);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 23);
            this.TxtUser.TabIndex = 6;
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(343, 67);
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(100, 23);
            this.TxtConfirmarSenha.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(430, 272);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 24);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(47, 272);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // CadastroSindico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 303);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.GroupInfoLogin);
            this.Controls.Add(this.GroupInfoPessoais);
            this.Controls.Add(this.LabSindico);
            this.Name = "CadastroSindico";
            this.Text = "CadastroSindico";
            this.GroupInfoPessoais.ResumeLayout(false);
            this.GroupInfoPessoais.PerformLayout();
            this.GroupInfoLogin.ResumeLayout(false);
            this.GroupInfoLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabSindico;
        private System.Windows.Forms.GroupBox GroupInfoPessoais;
        private System.Windows.Forms.Label LabCNPJ_CPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.Label LabTipo;
        private System.Windows.Forms.Label LabNome;
        private System.Windows.Forms.TextBox TxtCNPJ_CPF;
        private System.Windows.Forms.GroupBox GroupInfoLogin;
        private System.Windows.Forms.TextBox TxtConfirmarSenha;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.MaskedTextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LabConfirmarSenha;
        private System.Windows.Forms.Label LabSenha;
        private System.Windows.Forms.Label LabUser;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}