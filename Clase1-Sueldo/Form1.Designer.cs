namespace Clase1_Sueldo
{
    partial class Form1
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
            this.lbl_CalImpuestos = new System.Windows.Forms.Label();
            this.txt_Seguro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.txt_Renta = new System.Windows.Forms.TextBox();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeguroRes = new System.Windows.Forms.TextBox();
            this.txtAFPRes = new System.Windows.Forms.TextBox();
            this.txtRentaRes = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CalImpuestos
            // 
            this.lbl_CalImpuestos.AutoSize = true;
            this.lbl_CalImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CalImpuestos.Location = new System.Drawing.Point(88, 37);
            this.lbl_CalImpuestos.Name = "lbl_CalImpuestos";
            this.lbl_CalImpuestos.Size = new System.Drawing.Size(447, 39);
            this.lbl_CalImpuestos.TabIndex = 0;
            this.lbl_CalImpuestos.Text = "CALCULO DE IMPUESTOS";
            // 
            // txt_Seguro
            // 
            this.txt_Seguro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Seguro.Location = new System.Drawing.Point(35, 48);
            this.txt_Seguro.Name = "txt_Seguro";
            this.txt_Seguro.Size = new System.Drawing.Size(74, 15);
            this.txt_Seguro.TabIndex = 1;
            this.txt_Seguro.Text = "9";
            this.txt_Seguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(112, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(265, 37);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt_AFP
            // 
            this.txt_AFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AFP.Location = new System.Drawing.Point(138, 48);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.Size = new System.Drawing.Size(114, 15);
            this.txt_AFP.TabIndex = 3;
            this.txt_AFP.Text = "7";
            this.txt_AFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Renta
            // 
            this.txt_Renta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Renta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Renta.Location = new System.Drawing.Point(273, 48);
            this.txt_Renta.Name = "txt_Renta";
            this.txt_Renta.Size = new System.Drawing.Size(120, 15);
            this.txt_Renta.TabIndex = 4;
            this.txt_Renta.Text = "10";
            this.txt_Renta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(75, 143);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(217, 22);
            this.txtSueldoBruto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "%Seguro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "%AFP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "%Renta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sueldo Bruto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRentaRes);
            this.groupBox1.Controls.Add(this.txtAFPRes);
            this.groupBox1.Controls.Add(this.txtSeguroRes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Renta);
            this.groupBox1.Controls.Add(this.txt_AFP);
            this.groupBox1.Controls.Add(this.txt_Seguro);
            this.groupBox1.Location = new System.Drawing.Point(40, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 104);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deducciones";
            // 
            // txtSeguroRes
            // 
            this.txtSeguroRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeguroRes.Enabled = false;
            this.txtSeguroRes.Location = new System.Drawing.Point(35, 69);
            this.txtSeguroRes.Name = "txtSeguroRes";
            this.txtSeguroRes.ReadOnly = true;
            this.txtSeguroRes.Size = new System.Drawing.Size(74, 15);
            this.txtSeguroRes.TabIndex = 11;
            // 
            // txtAFPRes
            // 
            this.txtAFPRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAFPRes.Enabled = false;
            this.txtAFPRes.Location = new System.Drawing.Point(138, 69);
            this.txtAFPRes.Name = "txtAFPRes";
            this.txtAFPRes.ReadOnly = true;
            this.txtAFPRes.Size = new System.Drawing.Size(114, 15);
            this.txtAFPRes.TabIndex = 12;
            // 
            // txtRentaRes
            // 
            this.txtRentaRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRentaRes.Enabled = false;
            this.txtRentaRes.Location = new System.Drawing.Point(273, 69);
            this.txtRentaRes.Name = "txtRentaRes";
            this.txtRentaRes.ReadOnly = true;
            this.txtRentaRes.Size = new System.Drawing.Size(120, 15);
            this.txtRentaRes.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(451, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(95, 67);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 344);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl_CalImpuestos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CalImpuestos;
        private System.Windows.Forms.TextBox txt_Seguro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.TextBox txt_Renta;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRentaRes;
        private System.Windows.Forms.TextBox txtAFPRes;
        private System.Windows.Forms.TextBox txtSeguroRes;
        private System.Windows.Forms.Label lblResultado;
    }
}

