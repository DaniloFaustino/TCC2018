namespace TCC
{
    partial class RegistrarPagamentos
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
            this.LabCondominio = new System.Windows.Forms.Label();
            this.LabCondomino = new System.Windows.Forms.Label();
            this.LabMes = new System.Windows.Forms.Label();
            this.ComboMes = new System.Windows.Forms.ComboBox();
            this.ComboCondomino = new System.Windows.Forms.ComboBox();
            this.ComboCondominio = new System.Windows.Forms.ComboBox();
            this.LabCadRegistro = new System.Windows.Forms.Label();
            this.LabMostrarValor = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabMostrarValor);
            this.groupBox1.Controls.Add(this.LabCadRegistro);
            this.groupBox1.Controls.Add(this.ComboMes);
            this.groupBox1.Controls.Add(this.ComboCondomino);
            this.groupBox1.Controls.Add(this.ComboCondominio);
            this.groupBox1.Controls.Add(this.LabMes);
            this.groupBox1.Controls.Add(this.LabCondomino);
            this.groupBox1.Controls.Add(this.LabCondominio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Pagamento";
            // 
            // LabCondominio
            // 
            this.LabCondominio.AutoSize = true;
            this.LabCondominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondominio.Location = new System.Drawing.Point(9, 28);
            this.LabCondominio.Name = "LabCondominio";
            this.LabCondominio.Size = new System.Drawing.Size(90, 17);
            this.LabCondominio.TabIndex = 1;
            this.LabCondominio.Text = "Condomínio: ";
            // 
            // LabCondomino
            // 
            this.LabCondomino.AutoSize = true;
            this.LabCondomino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondomino.Location = new System.Drawing.Point(9, 55);
            this.LabCondomino.Name = "LabCondomino";
            this.LabCondomino.Size = new System.Drawing.Size(83, 17);
            this.LabCondomino.TabIndex = 1;
            this.LabCondomino.Text = "Condômino:";
            // 
            // LabMes
            // 
            this.LabMes.AutoSize = true;
            this.LabMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMes.Location = new System.Drawing.Point(9, 82);
            this.LabMes.Name = "LabMes";
            this.LabMes.Size = new System.Drawing.Size(42, 17);
            this.LabMes.TabIndex = 1;
            this.LabMes.Text = "Mês: ";
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
            this.ComboMes.Location = new System.Drawing.Point(105, 81);
            this.ComboMes.Name = "ComboMes";
            this.ComboMes.Size = new System.Drawing.Size(121, 21);
            this.ComboMes.TabIndex = 12;
            // 
            // ComboCondomino
            // 
            this.ComboCondomino.FormattingEnabled = true;
            this.ComboCondomino.Location = new System.Drawing.Point(105, 54);
            this.ComboCondomino.Name = "ComboCondomino";
            this.ComboCondomino.Size = new System.Drawing.Size(121, 21);
            this.ComboCondomino.TabIndex = 11;
            this.ComboCondomino.DropDown += new System.EventHandler(this.ComboCondomino_DropDown);
            // 
            // ComboCondominio
            // 
            this.ComboCondominio.FormattingEnabled = true;
            this.ComboCondominio.Location = new System.Drawing.Point(105, 27);
            this.ComboCondominio.Name = "ComboCondominio";
            this.ComboCondominio.Size = new System.Drawing.Size(121, 21);
            this.ComboCondominio.TabIndex = 10;
            this.ComboCondominio.DropDown += new System.EventHandler(this.ComboCondominio_DropDown);
            // 
            // LabCadRegistro
            // 
            this.LabCadRegistro.AutoSize = true;
            this.LabCadRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadRegistro.Location = new System.Drawing.Point(29, 155);
            this.LabCadRegistro.Name = "LabCadRegistro";
            this.LabCadRegistro.Size = new System.Drawing.Size(167, 17);
            this.LabCadRegistro.TabIndex = 13;
            this.LabCadRegistro.Text = "Adicionado com sucesso!";
            this.LabCadRegistro.Visible = false;
            // 
            // LabMostrarValor
            // 
            this.LabMostrarValor.AutoSize = true;
            this.LabMostrarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMostrarValor.Location = new System.Drawing.Point(29, 129);
            this.LabMostrarValor.Name = "LabMostrarValor";
            this.LabMostrarValor.Size = new System.Drawing.Size(76, 17);
            this.LabMostrarValor.TabIndex = 1;
            this.LabMostrarValor.Text = "O Valor é: ";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(181, 213);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 10;
            this.BtnAdicionar.Text = "Atualizar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(21, 213);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 11;
            this.BtnVerificar.Text = "Verificar ";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // RegistrarPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarPagamentos";
            this.Text = "RegistrarPagamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabMes;
        private System.Windows.Forms.Label LabCondomino;
        private System.Windows.Forms.Label LabCondominio;
        private System.Windows.Forms.ComboBox ComboMes;
        private System.Windows.Forms.ComboBox ComboCondomino;
        private System.Windows.Forms.ComboBox ComboCondominio;
        private System.Windows.Forms.Label LabMostrarValor;
        private System.Windows.Forms.Label LabCadRegistro;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnVerificar;
    }
}