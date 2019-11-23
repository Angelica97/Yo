namespace Generador_y_lector
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.pbmostrararchivo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnabrir = new System.Windows.Forms.Button();
            this.pnseparacion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbgenerar
            // 
            this.pbgenerar.Location = new System.Drawing.Point(12, 106);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(300, 300);
            this.pbgenerar.TabIndex = 0;
            this.pbgenerar.TabStop = false;
            // 
            // pbmostrararchivo
            // 
            this.pbmostrararchivo.Location = new System.Drawing.Point(513, 93);
            this.pbmostrararchivo.Name = "pbmostrararchivo";
            this.pbmostrararchivo.Size = new System.Drawing.Size(300, 300);
            this.pbmostrararchivo.TabIndex = 1;
            this.pbmostrararchivo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(12, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(433, 35);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtmostrar
            // 
            this.txtmostrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostrar.Location = new System.Drawing.Point(513, 420);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(300, 35);
            this.txtmostrar.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnguardar.Location = new System.Drawing.Point(318, 106);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(127, 50);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnabrir
            // 
            this.btnabrir.BackColor = System.Drawing.Color.Transparent;
            this.btnabrir.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnabrir.Location = new System.Drawing.Point(513, 27);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(300, 60);
            this.btnabrir.TabIndex = 6;
            this.btnabrir.Text = "Abrir archivo";
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // pnseparacion
            // 
            this.pnseparacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnseparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnseparacion.Location = new System.Drawing.Point(476, 12);
            this.pnseparacion.Name = "pnseparacion";
            this.pnseparacion.Size = new System.Drawing.Size(10, 466);
            this.pnseparacion.TabIndex = 7;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 490);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.pnseparacion);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbmostrararchivo);
            this.Controls.Add(this.pbgenerar);
            this.Name = "frmprincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.PictureBox pbmostrararchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Panel pnseparacion;
    }
}

