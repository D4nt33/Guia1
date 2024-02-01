namespace EjemploUno
{
    partial class ventana2
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
            this.ibmensajed = new System.Windows.Forms.Label();
            this.btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibmensajed
            // 
            this.ibmensajed.AutoSize = true;
            this.ibmensajed.Location = new System.Drawing.Point(67, 69);
            this.ibmensajed.Name = "ibmensajed";
            this.ibmensajed.Size = new System.Drawing.Size(35, 13);
            this.ibmensajed.TabIndex = 0;
            this.ibmensajed.Text = "label1";
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(231, 198);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 1;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 357);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.ibmensajed);
            this.Name = "ventana2";
            this.Text = "ventana2";
            this.Load += new System.EventHandler(this.ventana2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibmensajed;
        private System.Windows.Forms.Button btnregresar;
    }
}