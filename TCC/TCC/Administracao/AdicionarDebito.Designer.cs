namespace TCC
{
    partial class AdicionarDebito
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
            this.LabCadDebito = new System.Windows.Forms.Label();
            this.ComboMes = new System.Windows.Forms.ComboBox();
            this.LabMes = new System.Windows.Forms.Label();
            this.LabCondominio = new System.Windows.Forms.Label();
            this.LabCondomino = new System.Windows.Forms.Label();
            this.ComboCondomino = new System.Windows.Forms.ComboBox();
            this.ComboCondominio = new System.Windows.Forms.ComboBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabCadDebito);
            this.groupBox1.Controls.Add(this.ComboMes);
            this.groupBox1.Controls.Add(this.LabMes);
            this.groupBox1.Controls.Add(this.LabCondominio);
            this.groupBox1.Controls.Add(this.LabCondomino);
            this.groupBox1.Controls.Add(this.ComboCondomino);
            this.groupBox1.Controls.Add(this.ComboCondominio);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 142);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Débito";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabCadDebito
            // 
            this.LabCadDebito.AutoSize = true;
            this.LabCadDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadDebito.Location = new System.Drawing.Point(36, 109);
            this.LabCadDebito.Name = "LabCadDebito";
            this.LabCadDebito.Size = new System.Drawing.Size(167, 17);
            this.LabCadDebito.TabIndex = 8;
            this.LabCadDebito.Text = "Adicionado com sucesso!";
            this.LabCadDebito.Visible = false;
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
            this.ComboMes.Location = new System.Drawing.Point(102, 75);
            this.ComboMes.Name = "ComboMes";
            this.ComboMes.Size = new System.Drawing.Size(121, 21);
            this.ComboMes.TabIndex = 9;
            // 
            // LabMes
            // 
            this.LabMes.AutoSize = true;
            this.LabMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMes.Location = new System.Drawing.Point(13, 76);
            this.LabMes.Name = "LabMes";
            this.LabMes.Size = new System.Drawing.Size(38, 17);
            this.LabMes.TabIndex = 8;
            this.LabMes.Text = "Mês:";
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
            // ComboCondomino
            // 
            this.ComboCondomino.FormattingEnabled = true;
            this.ComboCondomino.Location = new System.Drawing.Point(102, 48);
            this.ComboCondomino.Name = "ComboCondomino";
            this.ComboCondomino.Size = new System.Drawing.Size(121, 21);
            this.ComboCondomino.TabIndex = 5;
            this.ComboCondomino.DropDown += new System.EventHandler(this.ComboCondomino_DropDown);
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
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(197, 160);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 9;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // AdicionarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdicionarDebito";
            this.Text = "AdicionarDebito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabCadDebito;
        private System.Windows.Forms.ComboBox ComboMes;
        private System.Windows.Forms.Label LabMes;
        private System.Windows.Forms.Label LabCondominio;
        private System.Windows.Forms.Label LabCondomino;
        private System.Windows.Forms.ComboBox ComboCondomino;
        private System.Windows.Forms.ComboBox ComboCondominio;
        private System.Windows.Forms.Button BtnAdicionar;
    }
}