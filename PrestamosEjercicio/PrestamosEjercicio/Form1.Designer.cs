
namespace PrestamosEjercicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTNA = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos Prestamo";
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(12, 26);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(222, 316);
            this.lstTipoPrestamos.TabIndex = 1;
            this.lstTipoPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamos_SelectedIndexChanged);
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(246, 26);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(35, 13);
            this.lblLinea.TabIndex = 2;
            this.lblLinea.Text = "Línea";
            // 
            // lblTNA
            // 
            this.lblTNA.AutoSize = true;
            this.lblTNA.Location = new System.Drawing.Point(246, 65);
            this.lblTNA.Name = "lblTNA";
            this.lblTNA.Size = new System.Drawing.Size(29, 13);
            this.lblTNA.TabIndex = 3;
            this.lblTNA.Text = "TNA";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(246, 105);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(246, 144);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(33, 13);
            this.lblPlazo.TabIndex = 5;
            this.lblPlazo.Text = "Plazo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cuota (Capital)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cuota (Interés)";
            // 
            // txtLinea
            // 
            this.txtLinea.Enabled = false;
            this.txtLinea.Location = new System.Drawing.Point(335, 23);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 20);
            this.txtLinea.TabIndex = 8;
            // 
            // txtTNA
            // 
            this.txtTNA.Enabled = false;
            this.txtTNA.Location = new System.Drawing.Point(335, 65);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(101, 20);
            this.txtTNA.TabIndex = 9;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(335, 105);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(101, 20);
            this.txtMonto.TabIndex = 10;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(336, 144);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 11;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(237, 237);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(119, 48);
            this.btnSimular.TabIndex = 12;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CUOTA TOTAL";
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Enabled = false;
            this.txtCuotaCapital.Location = new System.Drawing.Point(340, 329);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaCapital.TabIndex = 14;
            this.txtCuotaCapital.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Enabled = false;
            this.txtCuotaInteres.Location = new System.Drawing.Point(340, 368);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaInteres.TabIndex = 15;
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Enabled = false;
            this.txtCuotaTotal.Location = new System.Drawing.Point(340, 400);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaTotal.TabIndex = 16;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(269, 447);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(142, 45);
            this.btnAlta.TabIndex = 17;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 42);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prestamos dados de alta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.txtCuotaTotal);
            this.groupBox1.Controls.Add(this.txtCuotaInteres);
            this.groupBox1.Controls.Add(this.txtCuotaCapital);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtTNA);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPlazo);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.lblTNA);
            this.groupBox1.Controls.Add(this.lblLinea);
            this.groupBox1.Controls.Add(this.lstTipoPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 509);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(622, 93);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(321, 316);
            this.lstPrestamos.TabIndex = 20;
            this.lstPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstPrestamos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "COMISIÓN TOTAL";
            // 
            // txtComision
            // 
            this.txtComision.Enabled = false;
            this.txtComision.Location = new System.Drawing.Point(797, 473);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(158, 20);
            this.txtComision.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(336, 180);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 20);
            this.txtId.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(365, 237);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 48);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 621);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTipoPrestamos;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTNA;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

