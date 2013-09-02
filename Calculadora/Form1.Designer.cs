namespace Calculadora
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdSumar = new System.Windows.Forms.Button();
            this.cmdResta = new System.Windows.Forms.Button();
            this.cmdMult = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // cmdSumar
            // 
            this.cmdSumar.Location = new System.Drawing.Point(162, 12);
            this.cmdSumar.Name = "cmdSumar";
            this.cmdSumar.Size = new System.Drawing.Size(75, 23);
            this.cmdSumar.TabIndex = 2;
            this.cmdSumar.Text = "+";
            this.cmdSumar.UseVisualStyleBackColor = true;
            // 
            // cmdResta
            // 
            this.cmdResta.Location = new System.Drawing.Point(162, 41);
            this.cmdResta.Name = "cmdResta";
            this.cmdResta.Size = new System.Drawing.Size(75, 23);
            this.cmdResta.TabIndex = 3;
            this.cmdResta.Text = "-";
            this.cmdResta.UseVisualStyleBackColor = true;
            // 
            // cmdMult
            // 
            this.cmdMult.Location = new System.Drawing.Point(162, 70);
            this.cmdMult.Name = "cmdMult";
            this.cmdMult.Size = new System.Drawing.Size(75, 23);
            this.cmdMult.TabIndex = 4;
            this.cmdMult.Text = "*";
            this.cmdMult.UseVisualStyleBackColor = true;
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(162, 99);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(75, 23);
            this.cmdDiv.TabIndex = 5;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMult);
            this.Controls.Add(this.cmdResta);
            this.Controls.Add(this.cmdSumar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculadora1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cmdSumar;
        private System.Windows.Forms.Button cmdResta;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button button1;
    }
}

