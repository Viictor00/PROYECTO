namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartidasGanadas = new System.Windows.Forms.RadioButton();
            this.TiempoJugado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.PartidasJugadas = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(116, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(164, 20);
            this.nombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.PartidasGanadas);
            this.groupBox1.Controls.Add(this.TiempoJugado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.PartidasJugadas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // PartidasGanadas
            // 
            this.PartidasGanadas.AutoSize = true;
            this.PartidasGanadas.Location = new System.Drawing.Point(116, 91);
            this.PartidasGanadas.Name = "PartidasGanadas";
            this.PartidasGanadas.Size = new System.Drawing.Size(187, 17);
            this.PartidasGanadas.TabIndex = 7;
            this.PartidasGanadas.TabStop = true;
            this.PartidasGanadas.Text = "Dime cuantas partidas he ganado ";
            this.PartidasGanadas.UseVisualStyleBackColor = true;
            // 
            // TiempoJugado
            // 
            this.TiempoJugado.AutoSize = true;
            this.TiempoJugado.Location = new System.Drawing.Point(116, 119);
            this.TiempoJugado.Name = "TiempoJugado";
            this.TiempoJugado.Size = new System.Drawing.Size(169, 17);
            this.TiempoJugado.TabIndex = 7;
            this.TiempoJugado.TabStop = true;
            this.TiempoJugado.Text = "Dime cuanto tiempo he jugado";
            this.TiempoJugado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(15, 110);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(62, 20);
            this.passwordBox.TabIndex = 9;
            // 
            // PartidasJugadas
            // 
            this.PartidasJugadas.AutoSize = true;
            this.PartidasJugadas.Location = new System.Drawing.Point(116, 68);
            this.PartidasJugadas.Name = "PartidasJugadas";
            this.PartidasJugadas.Size = new System.Drawing.Size(180, 17);
            this.PartidasJugadas.TabIndex = 8;
            this.PartidasJugadas.TabStop = true;
            this.PartidasJugadas.Text = "Dime cuantas partidas he jugado";
            this.PartidasJugadas.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PartidasGanadas;
        private System.Windows.Forms.RadioButton PartidasJugadas;
        private System.Windows.Forms.RadioButton TiempoJugado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button3;
    }
}

