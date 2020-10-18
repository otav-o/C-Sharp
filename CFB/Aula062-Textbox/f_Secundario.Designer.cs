namespace Aula062_Textbox
{
    partial class f_Secundario
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
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(12, 12);
            this.tb_veiculos.Multiline = true;
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.Size = new System.Drawing.Size(205, 324);
            this.tb_veiculos.TabIndex = 0;
            // 
            // f_Secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 348);
            this.Controls.Add(this.tb_veiculos);
            this.MaximizeBox = false;
            this.Name = "f_Secundario";
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_Secundario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_veiculos;
    }
}