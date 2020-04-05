namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartidasGanadas = new System.Windows.Forms.RadioButton();
            this.tiempoJugado = new System.Windows.Forms.RadioButton();
            this.PartidasJugadas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PartidasGanadas);
            this.groupBox1.Controls.Add(this.tiempoJugado);
            this.groupBox1.Controls.Add(this.PartidasJugadas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 294);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // PartidasGanadas
            // 
            this.PartidasGanadas.AutoSize = true;
            this.PartidasGanadas.Location = new System.Drawing.Point(93, 110);
            this.PartidasGanadas.Name = "PartidasGanadas";
            this.PartidasGanadas.Size = new System.Drawing.Size(187, 17);
            this.PartidasGanadas.TabIndex = 7;
            this.PartidasGanadas.TabStop = true;
            this.PartidasGanadas.Text = "Dime cuantas partidas he ganado ";
            this.PartidasGanadas.UseVisualStyleBackColor = true;
            // 
            // tiempoJugado
            // 
            this.tiempoJugado.AutoSize = true;
            this.tiempoJugado.Location = new System.Drawing.Point(93, 146);
            this.tiempoJugado.Name = "tiempoJugado";
            this.tiempoJugado.Size = new System.Drawing.Size(169, 17);
            this.tiempoJugado.TabIndex = 7;
            this.tiempoJugado.TabStop = true;
            this.tiempoJugado.Text = "Dime cuanto tiempo he jugado";
            this.tiempoJugado.UseVisualStyleBackColor = true;
            // 
            // PartidasJugadas
            // 
            this.PartidasJugadas.AutoSize = true;
            this.PartidasJugadas.Location = new System.Drawing.Point(93, 72);
            this.PartidasJugadas.Name = "PartidasJugadas";
            this.PartidasJugadas.Size = new System.Drawing.Size(180, 17);
            this.PartidasJugadas.TabIndex = 8;
            this.PartidasJugadas.TabStop = true;
            this.PartidasJugadas.Text = "Dime cuantas partidas he jugado";
            this.PartidasJugadas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 418);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PartidasGanadas;
        private System.Windows.Forms.RadioButton tiempoJugado;
        private System.Windows.Forms.RadioButton PartidasJugadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}