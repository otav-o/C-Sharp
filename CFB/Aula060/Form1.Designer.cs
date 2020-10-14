namespace Aula060
{
    partial class Principal
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
            this.bt_Otavio = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Otavio
            // 
            this.bt_Otavio.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_Otavio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Otavio.ForeColor = System.Drawing.Color.Red;
            this.bt_Otavio.Location = new System.Drawing.Point(34, 48);
            this.bt_Otavio.Name = "bt_Otavio";
            this.bt_Otavio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Otavio.Size = new System.Drawing.Size(205, 64);
            this.bt_Otavio.TabIndex = 0;
            this.bt_Otavio.Text = "OK";
            this.bt_Otavio.UseVisualStyleBackColor = false;
            this.bt_Otavio.Click += new System.EventHandler(this.bt_texto_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_texto.Location = new System.Drawing.Point(12, 9);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(76, 21);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Oi Otávio";
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(34, 118);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(205, 23);
            this.tb_texto.TabIndex = 2;
            this.tb_texto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 409);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.bt_Otavio);
            this.Name = "Principal";
            this.Text = "Esse é meu primeiro formulário!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Otavio;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

