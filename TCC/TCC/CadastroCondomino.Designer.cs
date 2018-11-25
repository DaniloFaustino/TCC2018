namespace TCC
{
    partial class CadastroCondomino
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabCPF = new System.Windows.Forms.Label();
            this.LabNome = new System.Windows.Forms.Label();
            this.LabApt = new System.Windows.Forms.Label();
            this.LabSenha = new System.Windows.Forms.Label();
            this.LabConfirmarSenha = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtApt = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.LabCadCondo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboCondo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboCondo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabCadCondo);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.TxtConfirmarSenha);
            this.groupBox1.Controls.Add(this.TxtSenha);
            this.groupBox1.Controls.Add(this.TxtApt);
            this.groupBox1.Controls.Add(this.TxtCPF);
            this.groupBox1.Controls.Add(this.LabConfirmarSenha);
            this.groupBox1.Controls.Add(this.LabSenha);
            this.groupBox1.Controls.Add(this.LabApt);
            this.groupBox1.Controls.Add(this.LabNome);
            this.groupBox1.Controls.Add(this.LabCPF);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do condômino";
            // 
            // LabCPF
            // 
            this.LabCPF.AutoSize = true;
            this.LabCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCPF.Location = new System.Drawing.Point(16, 25);
            this.LabCPF.Name = "LabCPF";
            this.LabCPF.Size = new System.Drawing.Size(38, 17);
            this.LabCPF.TabIndex = 0;
            this.LabCPF.Text = "CPF:";
            // 
            // LabNome
            // 
            this.LabNome.AutoSize = true;
            this.LabNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNome.Location = new System.Drawing.Point(16, 50);
            this.LabNome.Name = "LabNome";
            this.LabNome.Size = new System.Drawing.Size(49, 17);
            this.LabNome.TabIndex = 1;
            this.LabNome.Text = "Nome:";
            // 
            // LabApt
            // 
            this.LabApt.AutoSize = true;
            this.LabApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabApt.Location = new System.Drawing.Point(17, 105);
            this.LabApt.Name = "LabApt";
            this.LabApt.Size = new System.Drawing.Size(93, 17);
            this.LabApt.TabIndex = 2;
            this.LabApt.Text = "Apartamento:";
            // 
            // LabSenha
            // 
            this.LabSenha.AutoSize = true;
            this.LabSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSenha.Location = new System.Drawing.Point(17, 131);
            this.LabSenha.Name = "LabSenha";
            this.LabSenha.Size = new System.Drawing.Size(53, 17);
            this.LabSenha.TabIndex = 3;
            this.LabSenha.Text = "Senha:";
            // 
            // LabConfirmarSenha
            // 
            this.LabConfirmarSenha.AutoSize = true;
            this.LabConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabConfirmarSenha.Location = new System.Drawing.Point(16, 157);
            this.LabConfirmarSenha.Name = "LabConfirmarSenha";
            this.LabConfirmarSenha.Size = new System.Drawing.Size(118, 17);
            this.LabConfirmarSenha.TabIndex = 4;
            this.LabConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(60, 24);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(100, 20);
            this.TxtCPF.TabIndex = 5;
            // 
            // TxtApt
            // 
            this.TxtApt.Location = new System.Drawing.Point(116, 104);
            this.TxtApt.Name = "TxtApt";
            this.TxtApt.Size = new System.Drawing.Size(100, 20);
            this.TxtApt.TabIndex = 6;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(76, 130);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 7;
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(140, 156);
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtConfirmarSenha.TabIndex = 8;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(73, 50);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 9;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(249, 275);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // LabCadCondo
            // 
            this.LabCadCondo.AutoSize = true;
            this.LabCadCondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadCondo.Location = new System.Drawing.Point(16, 202);
            this.LabCadCondo.Name = "LabCadCondo";
            this.LabCadCondo.Size = new System.Drawing.Size(247, 17);
            this.LabCadCondo.TabIndex = 10;
            this.LabCadCondo.Text = "Condômino cadastrado com sucesso! ";
            this.LabCadCondo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Condomínio:";
            // 
            // ComboCondo
            // 
            this.ComboCondo.FormattingEnabled = true;
            this.ComboCondo.Location = new System.Drawing.Point(108, 77);
            this.ComboCondo.Name = "ComboCondo";
            this.ComboCondo.Size = new System.Drawing.Size(121, 21);
            this.ComboCondo.TabIndex = 12;
            // 
            // CadastroCondomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 327);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroCondomino";
            this.Text = "CadastroCondomino";
            this.Load += new System.EventHandler(this.CadastroCondomino_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabCPF;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtConfirmarSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtApt;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Label LabConfirmarSenha;
        private System.Windows.Forms.Label LabSenha;
        private System.Windows.Forms.Label LabApt;
        private System.Windows.Forms.Label LabNome;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label LabCadCondo;
        private System.Windows.Forms.ComboBox ComboCondo;
        private System.Windows.Forms.Label label1;
    }
}