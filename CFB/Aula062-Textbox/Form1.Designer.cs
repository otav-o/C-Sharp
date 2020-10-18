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
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.bt_mostrarNum = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(12, 32);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(100, 15);
            this.lb_veiculo.TabIndex = 0;
            this.lb_veiculo.Text = "Digite um veículo";
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(197, 50);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(75, 23);
            this.bt_Inserir.TabIndex = 1;
            this.bt_Inserir.Text = "Inserir";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            this.bt_Inserir.Click += new System.EventHandler(this.bt_Inserir_Click);
            // 
            // tb_inserir
            // 
            this.tb_inserir.Location = new System.Drawing.Point(12, 50);
            this.tb_inserir.Name = "tb_inserir";
            this.tb_inserir.Size = new System.Drawing.Size(170, 23);
            this.tb_inserir.TabIndex = 2;
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_veiculos.Location = new System.Drawing.Point(12, 75);
            this.tb_veiculos.Multiline = true;
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.ReadOnly = true;
            this.tb_veiculos.Size = new System.Drawing.Size(270, 251);
            this.tb_veiculos.TabIndex = 3;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(12, 328);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(271, 26);
            this.bt_Limpar.TabIndex = 4;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.Location = new System.Drawing.Point(12, 356);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(271, 30);
            this.bt_mostrar.TabIndex = 5;
            this.bt_mostrar.Text = "Mostrar veículos";
            this.bt_mostrar.UseVisualStyleBackColor = true;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // bt_mostrarNum
            // 
            this.bt_mostrarNum.Location = new System.Drawing.Point(12, 388);
            this.bt_mostrarNum.Name = "bt_mostrarNum";
            this.bt_mostrarNum.Size = new System.Drawing.Size(271, 33);
            this.bt_mostrarNum.TabIndex = 6;
            this.bt_mostrarNum.Text = "Mostrar Num";
            this.bt_mostrarNum.UseVisualStyleBackColor = true;
            this.bt_mostrarNum.Click += new System.EventHandler(this.bt_mostrarNum_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Componentes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // f_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.bt_mostrarNum);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.tb_inserir);
            this.Controls.Add(this.bt_Inserir);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.Button bt_mostrarNum;
        public System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

