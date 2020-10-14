namespace Aula062_Textbox
{
    partial class f_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.bt_Inserir = new System.Windows.Forms.Button();
            this.tb_inserir = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(12, 21);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(100, 15);
            this.lb_veiculo.TabIndex = 0;
            this.lb_veiculo.Text = "Digite um veículo";
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(197, 39);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(75, 23);
            this.bt_Inserir.TabIndex = 1;
            this.bt_Inserir.Text = "Inserir";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            this.bt_Inserir.Click += new System.EventHandler(this.bt_Inserir_Click);
            // 
            // tb_inserir
            // 
            this.tb_inserir.Location = new System.Drawing.Point(12, 39);
            this.tb_inserir.Name = "tb_inserir";
            this.tb_inserir.Size = new System.Drawing.Size(170, 23);
            this.tb_inserir.TabIndex = 2;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_2.Location = new System.Drawing.Point(12, 68);
            this.tb_2.Multiline = true;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(260, 247);
            this.tb_2.TabIndex = 3;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(12, 335);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(261, 22);
            this.bt_Limpar.TabIndex = 4;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // f_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 369);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_inserir);
            this.Controls.Add(this.bt_Inserir);
            this.Controls.Add(this.lb_veiculo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "f_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.Button bt_Inserir;
        private System.Windows.Forms.TextBox tb_inserir;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Limpar;
    }
}

