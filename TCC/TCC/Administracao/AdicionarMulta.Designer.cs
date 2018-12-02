namespace TCC
{
    partial class AdicionarMulta
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
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LabCondominio = new System.Windows.Forms.Label();
            this.LabCondomino = new System.Windows.Forms.Label();
            this.LabCodigo = new System.Windows.Forms.Label();
            this.ComboCondominio = new System.Windows.Forms.ComboBox();
            this.ComboCondomino = new System.Windows.Forms.ComboBox();
            this.ComboCodigo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabCadMulta = new System.Windows.Forms.Label();
            this.ComboMes = new System.Windows.Forms.ComboBox();
            this.LabMes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(195, 179);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LabCondominio
            // 
            this.LabCondominio.AutoSize = true;
            this.LabCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondominio.Location = new System.Drawing.Point(13, 22);
            this.LabCondominio.Name = "LabCondominio";
            this.LabCondominio.Size = new System.Drawing.Size(86, 17);
            this.LabCondominio.TabIndex = 1;
            this.LabCondominio.Text = "Condomínio:";
            // 
            // LabCondomino
            // 
            this.LabCondomino.AutoSize = true;
            this.LabCondomino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondomino.Location = new System.Drawing.Point(13, 49);
            this.LabCondomino.Name = "LabCondomino";
            this.LabCondomino.Size = new System.Drawing.Size(83, 17);
            this.LabCondomino.TabIndex = 2;
            this.LabCondomino.Text = "Condômino:";
            // 
            // LabCodigo
            // 
            this.LabCodigo.AutoSize = true;
            this.LabCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCodigo.Location = new System.Drawing.Point(13, 76);
            this.LabCodigo.Name = "LabCodigo";
            this.LabCodigo.Size = new System.Drawing.Size(56, 17);
            this.LabCodigo.TabIndex = 3;
            this.LabCodigo.Text = "Código:";
            // 
            // ComboCondominio
            // 
            this.ComboCondominio.FormattingEnabled = true;
            this.ComboCondominio.Location = new System.Drawing.Point(102, 21);
            this.ComboCondominio.Name = "ComboCondominio";
            this.ComboCondominio.Size = new System.Drawing.Size(121, 21);
            this.ComboCondominio.TabIndex = 4;
            this.ComboCondominio.DropDown += new System.EventHandler(this.ComboCondominio_DropDown);
            // 
            // ComboCondomino
            // 
            this.ComboCondomino.FormattingEnabled = true;
            this.ComboCondomino.Location = new System.Drawing.Point(102, 48);
            this.ComboCondomino.Name = "ComboCondomino";
            this.ComboCondomino.Size = new System.Drawing.Size(121, 21);
            this.ComboCondomino.TabIndex = 5;
            this.ComboCondomino.DropDown += new System.EventHandler(this.ComboCondomino_DropDown);
            // 
            // ComboCodigo
            // 
            this.ComboCodigo.FormattingEnabled = true;
            this.ComboCodigo.Location = new System.Drawing.Point(102, 75);
            this.ComboCodigo.Name = "ComboCodigo";
            this.ComboCodigo.Size = new System.Drawing.Size(121, 21);
            this.ComboCodigo.TabIndex = 6;
            this.ComboCodigo.DropDown += new System.EventHandler(this.ComboCodigo_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabCadMulta);
            this.groupBox1.Controls.Add(this.ComboMes);
            this.groupBox1.Controls.Add(this.LabMes);
            this.groupBox1.Controls.Add(this.LabCondominio);
            this.groupBox1.Controls.Add(this.ComboCodigo);
            this.groupBox1.Controls.Add(this.LabCondomino);
            this.groupBox1.Controls.Add(this.LabCodigo);
            this.groupBox1.Controls.Add(this.ComboCondomino);
            this.groupBox1.Controls.Add(this.ComboCondominio);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Multa ou Serviços Adicionais";
            // 
            // LabCadMulta
            // 
            this.LabCadMulta.AutoSize = true;
            this.LabCadMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadMulta.Location = new System.Drawing.Point(36, 141);
            this.LabCadMulta.Name = "LabCadMulta";
            this.LabCadMulta.Size = new System.Drawing.Size(167, 17);
            this.LabCadMulta.TabIndex = 8;
            this.LabCadMulta.Text = "Adicionado com sucesso!";
            this.LabCadMulta.Visible = false;
            // 
            // ComboMes
            // 
            this.ComboMes.FormattingEnabled = true;
            this.ComboMes.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 ",
            "4 ",
            "5 ",
            "6 ",
            "7",
            "8 ",
            "10 ",
            "11 ",
            "12"});
            this.ComboMes.Location = new System.Drawing.Point(102, 103);
            this.ComboMes.Name = "ComboMes";
            this.ComboMes.Size = new System.Drawing.Size(121, 21);
            this.ComboMes.TabIndex = 9;
            // 
            // LabMes
            // 
            this.LabMes.AutoSize = true;
            this.LabMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMes.Location = new System.Drawing.Point(13, 104);
            this.LabMes.Name = "LabMes";
            this.LabMes.Size = new System.Drawing.Size(38, 17);
            this.LabMes.TabIndex = 8;
            this.LabMes.Text = "Mês:";
            // 
            // AdicionarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAdicionar);
            this.Name = "AdicionarMulta";
            this.Text = "AdicionarMulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label LabCondominio;
        private System.Windows.Forms.Label LabCondomino;
        private System.Windows.Forms.Label LabCodigo;
        private System.Windows.Forms.ComboBox ComboCondominio;
        private System.Windows.Forms.ComboBox ComboCondomino;
        private System.Windows.Forms.ComboBox ComboCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboMes;
        private System.Windows.Forms.Label LabMes;
        private System.Windows.Forms.Label LabCadMulta;
    }
}