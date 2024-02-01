namespace reto1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbgerente = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbsecre = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtsalarioneto = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario neto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellido";
            // 
            // rbgerente
            // 
            this.rbgerente.AutoSize = true;
            this.rbgerente.Location = new System.Drawing.Point(508, 189);
            this.rbgerente.Name = "rbgerente";
            this.rbgerente.Size = new System.Drawing.Size(76, 20);
            this.rbgerente.TabIndex = 7;
            this.rbgerente.TabStop = true;
            this.rbgerente.Text = "Gerente";
            this.rbgerente.UseVisualStyleBackColor = true;
            // 
            // rbsub
            // 
            this.rbsub.AutoSize = true;
            this.rbsub.Location = new System.Drawing.Point(508, 229);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(98, 20);
            this.rbsub.TabIndex = 8;
            this.rbsub.TabStop = true;
            this.rbsub.Text = "Subgerente";
            this.rbsub.UseVisualStyleBackColor = true;
            // 
            // rbsecre
            // 
            this.rbsecre.AutoSize = true;
            this.rbsecre.Location = new System.Drawing.Point(508, 270);
            this.rbsecre.Name = "rbsecre";
            this.rbsecre.Size = new System.Drawing.Size(90, 20);
            this.rbsecre.TabIndex = 9;
            this.rbsecre.TabStop = true;
            this.rbsecre.Text = "Secretaria";
            this.rbsecre.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(231, 111);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 10;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(465, 111);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 22);
            this.txtapellido.TabIndex = 11;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(283, 207);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 22);
            this.txtsalario.TabIndex = 12;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(283, 252);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(100, 22);
            this.txtdescuento.TabIndex = 13;
            // 
            // txtsalarioneto
            // 
            this.txtsalarioneto.Location = new System.Drawing.Point(283, 301);
            this.txtsalarioneto.Name = "txtsalarioneto";
            this.txtsalarioneto.Size = new System.Drawing.Size(100, 22);
            this.txtsalarioneto.TabIndex = 14;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(362, 370);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 15;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsalarioneto);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.rbsecre);
            this.Controls.Add(this.rbsub);
            this.Controls.Add(this.rbgerente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbgerente;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbsecre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtsalarioneto;
        private System.Windows.Forms.Button btncalcular;
    }
}

