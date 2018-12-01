namespace TCC
{
    partial class CadastroOpcoes
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
            this.LabCadOp = new System.Windows.Forms.Label();
            this.BtnCadCond = new System.Windows.Forms.Button();
            this.BtnCadApt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabCadOp
            // 
            this.LabCadOp.AutoSize = true;
            this.LabCadOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadOp.Location = new System.Drawing.Point(23, 21);
            this.LabCadOp.Name = "LabCadOp";
            this.LabCadOp.Size = new System.Drawing.Size(229, 17);
            this.LabCadOp.TabIndex = 0;
            this.LabCadOp.Text = "O QUE DESEJA CADASTRAR?";
            // 
            // BtnCadCond
            // 
            this.BtnCadCond.Location = new System.Drawing.Point(26, 80);
            this.BtnCadCond.Name = "BtnCadCond";
            this.BtnCadCond.Size = new System.Drawing.Size(226, 28);
            this.BtnCadCond.TabIndex = 1;
            this.BtnCadCond.Text = "Cadastrar Condomínio/Administrador";
            this.BtnCadCond.UseVisualStyleBackColor = true;
            this.BtnCadCond.Click += new System.EventHandler(this.BtnCadCond_Click);
            // 
            // BtnCadApt
            // 
            this.BtnCadApt.Location = new System.Drawing.Point(26, 130);
            this.BtnCadApt.Name = "BtnCadApt";
            this.BtnCadApt.Size = new System.Drawing.Size(226, 23);
            this.BtnCadApt.TabIndex = 2;
            this.BtnCadApt.Text = "Cadastrar Condômino";
            this.BtnCadApt.UseVisualStyleBackColor = true;
            this.BtnCadApt.Click += new System.EventHandler(this.BtnCadApt_Click);
            // 
            // CadastroOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.BtnCadApt);
            this.Controls.Add(this.BtnCadCond);
            this.Controls.Add(this.LabCadOp);
            this.Name = "CadastroOpcoes";
            this.Text = "CadastroOpcoes";
            this.Load += new System.EventHandler(this.CadastroOpcoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCadOp;
        private System.Windows.Forms.Button BtnCadCond;
        private System.Windows.Forms.Button BtnCadApt;
    }
}