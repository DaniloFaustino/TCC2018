namespace TCC
{
    partial class CondominosAdm
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
            this.BtnMulta = new System.Windows.Forms.Button();
            this.BtnDebito = new System.Windows.Forms.Button();
            this.BtnRegistrarPagamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMulta
            // 
            this.BtnMulta.Location = new System.Drawing.Point(31, 32);
            this.BtnMulta.Name = "BtnMulta";
            this.BtnMulta.Size = new System.Drawing.Size(172, 23);
            this.BtnMulta.TabIndex = 0;
            this.BtnMulta.Text = "Registrar Multa/Serviços";
            this.BtnMulta.UseVisualStyleBackColor = true;
            this.BtnMulta.Click += new System.EventHandler(this.BtnMulta_Click);
            // 
            // BtnDebito
            // 
            this.BtnDebito.Location = new System.Drawing.Point(31, 87);
            this.BtnDebito.Name = "BtnDebito";
            this.BtnDebito.Size = new System.Drawing.Size(171, 23);
            this.BtnDebito.TabIndex = 1;
            this.BtnDebito.Text = "Registrar Débitos";
            this.BtnDebito.UseVisualStyleBackColor = true;
            this.BtnDebito.Click += new System.EventHandler(this.BtnDebito_Click);
            // 
            // BtnRegistrarPagamentos
            // 
            this.BtnRegistrarPagamentos.Location = new System.Drawing.Point(32, 132);
            this.BtnRegistrarPagamentos.Name = "BtnRegistrarPagamentos";
            this.BtnRegistrarPagamentos.Size = new System.Drawing.Size(171, 23);
            this.BtnRegistrarPagamentos.TabIndex = 2;
            this.BtnRegistrarPagamentos.Text = "Registrar Pagamentos";
            this.BtnRegistrarPagamentos.UseVisualStyleBackColor = true;
            this.BtnRegistrarPagamentos.Click += new System.EventHandler(this.BtnRegistrarPagamentos_Click);
            // 
            // CondominosAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 181);
            this.Controls.Add(this.BtnRegistrarPagamentos);
            this.Controls.Add(this.BtnDebito);
            this.Controls.Add(this.BtnMulta);
            this.Name = "CondominosAdm";
            this.Text = "CondominosAdm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMulta;
        private System.Windows.Forms.Button BtnDebito;
        private System.Windows.Forms.Button BtnRegistrarPagamentos;
    }
}