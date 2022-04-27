namespace Portfolio_Ciclo_3
{
    partial class Portfolio
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
            this.indicadorA = new System.Windows.Forms.Label();
            this.indicadorB = new System.Windows.Forms.Label();
            this.indicadorC = new System.Windows.Forms.Label();
            this.tbEntradaDadosA = new System.Windows.Forms.TextBox();
            this.tbEntradaDadosB = new System.Windows.Forms.TextBox();
            this.tbEntradaDadosC = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.indicadorResultadoDelta = new System.Windows.Forms.Label();
            this.indicadorResultadoX1 = new System.Windows.Forms.Label();
            this.indicadorResultadoX2 = new System.Windows.Forms.Label();
            this.tbResultadoDelta = new System.Windows.Forms.TextBox();
            this.tbResultadoX1 = new System.Windows.Forms.TextBox();
            this.tbResultadoX2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equação de 2º Grau";
            // 
            // indicadorA
            // 
            this.indicadorA.Location = new System.Drawing.Point(55, 56);
            this.indicadorA.Name = "indicadorA";
            this.indicadorA.Size = new System.Drawing.Size(73, 23);
            this.indicadorA.TabIndex = 0;
            this.indicadorA.Text = "Valor para A:";
            // 
            // indicadorB
            // 
            this.indicadorB.Location = new System.Drawing.Point(55, 93);
            this.indicadorB.Name = "indicadorB";
            this.indicadorB.Size = new System.Drawing.Size(73, 23);
            this.indicadorB.TabIndex = 0;
            this.indicadorB.Text = "Valor para B:";
            // 
            // indicadorC
            // 
            this.indicadorC.Location = new System.Drawing.Point(55, 127);
            this.indicadorC.Name = "indicadorC";
            this.indicadorC.Size = new System.Drawing.Size(73, 23);
            this.indicadorC.TabIndex = 0;
            this.indicadorC.Text = "Valor para C:";
            // 
            // tbEntradaDadosA
            // 
            this.tbEntradaDadosA.Location = new System.Drawing.Point(135, 56);
            this.tbEntradaDadosA.Name = "tbEntradaDadosA";
            this.tbEntradaDadosA.Size = new System.Drawing.Size(100, 23);
            this.tbEntradaDadosA.TabIndex = 14;
            // 
            // tbEntradaDadosB
            // 
            this.tbEntradaDadosB.Location = new System.Drawing.Point(135, 93);
            this.tbEntradaDadosB.Name = "tbEntradaDadosB";
            this.tbEntradaDadosB.Size = new System.Drawing.Size(100, 23);
            this.tbEntradaDadosB.TabIndex = 15;
            // 
            // tbEntradaDadosC
            // 
            this.tbEntradaDadosC.Location = new System.Drawing.Point(135, 127);
            this.tbEntradaDadosC.Name = "tbEntradaDadosC";
            this.tbEntradaDadosC.Size = new System.Drawing.Size(100, 23);
            this.tbEntradaDadosC.TabIndex = 16;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(55, 178);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(173, 23);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // indicadorResultadoDelta
            // 
            this.indicadorResultadoDelta.AutoSize = true;
            this.indicadorResultadoDelta.Location = new System.Drawing.Point(321, 60);
            this.indicadorResultadoDelta.Name = "indicadorResultadoDelta";
            this.indicadorResultadoDelta.Size = new System.Drawing.Size(37, 15);
            this.indicadorResultadoDelta.TabIndex = 17;
            this.indicadorResultadoDelta.Text = "Delta:";
            this.indicadorResultadoDelta.Click += new System.EventHandler(this.indicadorResultadoDelta_Click);
            // 
            // indicadorResultadoX1
            // 
            this.indicadorResultadoX1.AutoSize = true;
            this.indicadorResultadoX1.Location = new System.Drawing.Point(321, 114);
            this.indicadorResultadoX1.Name = "indicadorResultadoX1";
            this.indicadorResultadoX1.Size = new System.Drawing.Size(22, 15);
            this.indicadorResultadoX1.TabIndex = 18;
            this.indicadorResultadoX1.Text = "x1:";
            // 
            // indicadorResultadoX2
            // 
            this.indicadorResultadoX2.AutoSize = true;
            this.indicadorResultadoX2.Location = new System.Drawing.Point(321, 163);
            this.indicadorResultadoX2.Name = "indicadorResultadoX2";
            this.indicadorResultadoX2.Size = new System.Drawing.Size(22, 15);
            this.indicadorResultadoX2.TabIndex = 19;
            this.indicadorResultadoX2.Text = "x2:";
            // 
            // tbResultadoDelta
            // 
            this.tbResultadoDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbResultadoDelta.Location = new System.Drawing.Point(362, 55);
            this.tbResultadoDelta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResultadoDelta.Name = "tbResultadoDelta";
            this.tbResultadoDelta.ReadOnly = true;
            this.tbResultadoDelta.Size = new System.Drawing.Size(205, 26);
            this.tbResultadoDelta.TabIndex = 3;
            // 
            // tbResultadoX1
            // 
            this.tbResultadoX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbResultadoX1.Location = new System.Drawing.Point(362, 107);
            this.tbResultadoX1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResultadoX1.Name = "tbResultadoX1";
            this.tbResultadoX1.ReadOnly = true;
            this.tbResultadoX1.Size = new System.Drawing.Size(205, 26);
            this.tbResultadoX1.TabIndex = 20;
            // 
            // tbResultadoX2
            // 
            this.tbResultadoX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbResultadoX2.Location = new System.Drawing.Point(362, 156);
            this.tbResultadoX2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResultadoX2.Name = "tbResultadoX2";
            this.tbResultadoX2.ReadOnly = true;
            this.tbResultadoX2.Size = new System.Drawing.Size(205, 26);
            this.tbResultadoX2.TabIndex = 21;
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indicadorA);
            this.Controls.Add(this.indicadorB);
            this.Controls.Add(this.indicadorC);
            this.Controls.Add(this.tbEntradaDadosA);
            this.Controls.Add(this.tbEntradaDadosB);
            this.Controls.Add(this.tbEntradaDadosC);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indicadorResultadoDelta);
            this.Controls.Add(this.indicadorResultadoX1);
            this.Controls.Add(this.indicadorResultadoX2);
            this.Controls.Add(this.tbResultadoDelta);
            this.Controls.Add(this.tbResultadoX1);
            this.Controls.Add(this.tbResultadoX2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Portfolio";
            this.Text = "Equação de 2º Grau";
            this.Load += new System.EventHandler(this.Portfolio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label indicadorA;
        private System.Windows.Forms.Label indicadorB;
        private System.Windows.Forms.Label indicadorC;
        private System.Windows.Forms.TextBox tbEntradaDadosA;
        private System.Windows.Forms.TextBox tbEntradaDadosB;
        private System.Windows.Forms.TextBox tbEntradaDadosC;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label indicadorResultadoDelta;
        private System.Windows.Forms.Label indicadorResultadoX1;
        private System.Windows.Forms.Label indicadorResultadoX2;
        private System.Windows.Forms.TextBox tbResultadoDelta;
        private System.Windows.Forms.TextBox tbResultadoX1;
        private System.Windows.Forms.TextBox tbResultadoX2;
    }
}