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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboCondominio = new System.Windows.Forms.ComboBox();
            this.ComboCondomino = new System.Windows.Forms.ComboBox();
            this.ComboCodigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(207, 206);
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
            this.LabCondominio.Location = new System.Drawing.Point(25, 34);
            this.LabCondominio.Name = "LabCondominio";
            this.LabCondominio.Size = new System.Drawing.Size(83, 17);
            this.LabCondominio.TabIndex = 1;
            this.LabCondominio.Text = "Condomíno:";
            // 
            // LabCondomino
            // 
            this.LabCondomino.AutoSize = true;
            this.LabCondomino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondomino.Location = new System.Drawing.Point(25, 62);
            this.LabCondomino.Name = "LabCondomino";
            this.LabCondomino.Size = new System.Drawing.Size(83, 17);
            this.LabCondomino.TabIndex = 2;
            this.LabCondomino.Text = "Condômino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // ComboCondominio
            // 
            this.ComboCondominio.FormattingEnabled = true;
            this.ComboCondominio.Location = new System.Drawing.Point(115, 33);
            this.ComboCondominio.Name = "ComboCondominio";
            this.ComboCondominio.Size = new System.Drawing.Size(121, 21);
            this.ComboCondominio.TabIndex = 4;
            // 
            // ComboCondomino
            // 
            this.ComboCondomino.FormattingEnabled = true;
            this.ComboCondomino.Location = new System.Drawing.Point(115, 61);
            this.ComboCondomino.Name = "ComboCondomino";
            this.ComboCondomino.Size = new System.Drawing.Size(121, 21);
            this.ComboCondomino.TabIndex = 5;
            this.ComboCondomino.SelectedIndexChanged += new System.EventHandler(this.ComboCondomino_SelectedIndexChanged);
            // 
            // ComboCodigo
            // 
            this.ComboCodigo.FormattingEnabled = true;
            this.ComboCodigo.Location = new System.Drawing.Point(115, 89);
            this.ComboCodigo.Name = "ComboCodigo";
            this.ComboCodigo.Size = new System.Drawing.Size(121, 21);
            this.ComboCodigo.TabIndex = 6;
            // 
            // AdicionarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.ComboCodigo);
            this.Controls.Add(this.ComboCondomino);
            this.Controls.Add(this.ComboCondominio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabCondomino);
            this.Controls.Add(this.LabCondominio);
            this.Controls.Add(this.BtnAdicionar);
            this.Name = "AdicionarMulta";
            this.Text = "AdicionarMulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label LabCondominio;
        private System.Windows.Forms.Label LabCondomino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboCondominio;
        private System.Windows.Forms.ComboBox ComboCondomino;
        private System.Windows.Forms.ComboBox ComboCodigo;
    }
}