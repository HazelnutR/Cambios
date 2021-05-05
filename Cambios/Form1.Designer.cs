
namespace Cambios
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Origem = new System.Windows.Forms.ComboBox();
            this.combo_Destino = new System.Windows.Forms.ComboBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor :";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(86, 38);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(500, 27);
            this.txt_Valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de origem :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de destino :";
            // 
            // combo_Origem
            // 
            this.combo_Origem.FormattingEnabled = true;
            this.combo_Origem.Location = new System.Drawing.Point(172, 99);
            this.combo_Origem.Name = "combo_Origem";
            this.combo_Origem.Size = new System.Drawing.Size(395, 27);
            this.combo_Origem.TabIndex = 4;
            // 
            // combo_Destino
            // 
            this.combo_Destino.FormattingEnabled = true;
            this.combo_Destino.Location = new System.Drawing.Point(172, 142);
            this.combo_Destino.Name = "combo_Destino";
            this.combo_Destino.Size = new System.Drawing.Size(395, 27);
            this.combo_Destino.TabIndex = 5;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(608, 32);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(123, 36);
            this.btn_Convert.TabIndex = 6;
            this.btn_Convert.Text = "Converter";
            this.btn_Convert.UseVisualStyleBackColor = true;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(197, 195);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(341, 19);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 234);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(53, 19);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(608, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(123, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 262);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.combo_Destino);
            this.Controls.Add(this.combo_Origem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Origem;
        private System.Windows.Forms.ComboBox combo_Destino;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

