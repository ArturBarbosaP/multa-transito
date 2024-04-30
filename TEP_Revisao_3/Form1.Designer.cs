
namespace TEP_Revisao_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.lbl_velmax = new System.Windows.Forms.Label();
            this.lbl_velvei = new System.Windows.Forms.Label();
            this.txt_velmax = new System.Windows.Forms.TextBox();
            this.txt_velvei = new System.Windows.Forms.TextBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.lbl_separador = new System.Windows.Forms.Label();
            this.lbl_placaS = new System.Windows.Forms.Label();
            this.lbl_velex = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(188, 14);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(100, 20);
            this.txt_placa.TabIndex = 0;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(36, 18);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(91, 13);
            this.lbl_placa.TabIndex = 1;
            this.lbl_placa.Text = "Placa do veículo:";
            // 
            // lbl_velmax
            // 
            this.lbl_velmax.AutoSize = true;
            this.lbl_velmax.Location = new System.Drawing.Point(36, 45);
            this.lbl_velmax.Name = "lbl_velmax";
            this.lbl_velmax.Size = new System.Drawing.Size(101, 13);
            this.lbl_velmax.TabIndex = 2;
            this.lbl_velmax.Text = "Velocidade máxima:";
            // 
            // lbl_velvei
            // 
            this.lbl_velvei.AutoSize = true;
            this.lbl_velvei.Location = new System.Drawing.Point(36, 72);
            this.lbl_velvei.Name = "lbl_velvei";
            this.lbl_velvei.Size = new System.Drawing.Size(117, 13);
            this.lbl_velvei.TabIndex = 3;
            this.lbl_velvei.Text = "Velocidade do veículo:";
            // 
            // txt_velmax
            // 
            this.txt_velmax.Location = new System.Drawing.Point(188, 41);
            this.txt_velmax.Name = "txt_velmax";
            this.txt_velmax.Size = new System.Drawing.Size(100, 20);
            this.txt_velmax.TabIndex = 4;
            // 
            // txt_velvei
            // 
            this.txt_velvei.Location = new System.Drawing.Point(188, 68);
            this.txt_velvei.Name = "txt_velvei";
            this.txt_velvei.Size = new System.Drawing.Size(100, 20);
            this.txt_velvei.TabIndex = 5;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(39, 104);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(249, 26);
            this.btn_imprimir.TabIndex = 6;
            this.btn_imprimir.Text = "Imprimir multa";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // lbl_separador
            // 
            this.lbl_separador.AutoSize = true;
            this.lbl_separador.Location = new System.Drawing.Point(-15, 133);
            this.lbl_separador.Name = "lbl_separador";
            this.lbl_separador.Size = new System.Drawing.Size(361, 13);
            this.lbl_separador.TabIndex = 7;
            this.lbl_separador.Text = "___________________________________________________________";
            // 
            // lbl_placaS
            // 
            this.lbl_placaS.AutoSize = true;
            this.lbl_placaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placaS.Location = new System.Drawing.Point(126, 156);
            this.lbl_placaS.Name = "lbl_placaS";
            this.lbl_placaS.Size = new System.Drawing.Size(0, 15);
            this.lbl_placaS.TabIndex = 8;
            this.lbl_placaS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_velex
            // 
            this.lbl_velex.AutoSize = true;
            this.lbl_velex.Location = new System.Drawing.Point(36, 190);
            this.lbl_velex.Name = "lbl_velex";
            this.lbl_velex.Size = new System.Drawing.Size(0, 13);
            this.lbl_velex.TabIndex = 9;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(36, 222);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(0, 13);
            this.lbl_valor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_velex);
            this.Controls.Add(this.lbl_placaS);
            this.Controls.Add(this.lbl_separador);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_velvei);
            this.Controls.Add(this.txt_velmax);
            this.Controls.Add(this.lbl_velvei);
            this.Controls.Add(this.lbl_velmax);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.txt_placa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multa de Transito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.Label lbl_velmax;
        private System.Windows.Forms.Label lbl_velvei;
        private System.Windows.Forms.TextBox txt_velmax;
        private System.Windows.Forms.TextBox txt_velvei;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label lbl_separador;
        private System.Windows.Forms.Label lbl_placaS;
        private System.Windows.Forms.Label lbl_velex;
        private System.Windows.Forms.Label lbl_valor;
    }
}

