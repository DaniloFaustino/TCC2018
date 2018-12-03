namespace TCC
{
    partial class MenuAdministracao
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
            this.BtnCondominios = new System.Windows.Forms.Button();
            this.BtnCondominos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCondominios
            // 
            this.BtnCondominios.Location = new System.Drawing.Point(96, 142);
            this.BtnCondominios.Name = "BtnCondominios";
            this.BtnCondominios.Size = new System.Drawing.Size(75, 23);
            this.BtnCondominios.TabIndex = 0;
            this.BtnCondominios.Text = "Condomínios";
            this.BtnCondominios.UseVisualStyleBackColor = true;
            this.BtnCondominios.Click += new System.EventHandler(this.BtnCondominios_Click);
            // 
            // BtnCondominos
            // 
            this.BtnCondominos.Location = new System.Drawing.Point(96, 78);
            this.BtnCondominos.Name = "BtnCondominos";
            this.BtnCondominos.Size = new System.Drawing.Size(75, 23);
            this.BtnCondominos.TabIndex = 1;
            this.BtnCondominos.Text = "Condôminos";
            this.BtnCondominos.UseVisualStyleBackColor = true;
            this.BtnCondominos.Click += new System.EventHandler(this.BtnCondominos_Click);
            // 
            // MenuAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCondominos);
            this.Controls.Add(this.BtnCondominios);
            this.Name = "MenuAdministracao";
            this.Text = "MenuAdministracao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAdministracao_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnCondominios;
        public System.Windows.Forms.Button BtnCondominos;
    }
}