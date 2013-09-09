namespace Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FaC = new System.Windows.Forms.Button();
            this.CaF = new System.Windows.Forms.Button();
            this.CaK = new System.Windows.Forms.Button();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.KaC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados:";
            // 
            // FaC
            // 
            this.FaC.Location = new System.Drawing.Point(30, 83);
            this.FaC.Name = "FaC";
            this.FaC.Size = new System.Drawing.Size(75, 23);
            this.FaC.TabIndex = 2;
            this.FaC.Text = "Fº a Cº";
            this.FaC.UseVisualStyleBackColor = true;
            this.FaC.Click += new System.EventHandler(this.FaC_Click);
            // 
            // CaF
            // 
            this.CaF.Location = new System.Drawing.Point(30, 113);
            this.CaF.Name = "CaF";
            this.CaF.Size = new System.Drawing.Size(75, 23);
            this.CaF.TabIndex = 3;
            this.CaF.Text = "Cº a Fº";
            this.CaF.UseVisualStyleBackColor = true;
            this.CaF.Click += new System.EventHandler(this.button2_Click);
            // 
            // CaK
            // 
            this.CaK.Location = new System.Drawing.Point(30, 142);
            this.CaK.Name = "CaK";
            this.CaK.Size = new System.Drawing.Size(75, 23);
            this.CaK.TabIndex = 4;
            this.CaK.Text = "Cº a Kº";
            this.CaK.UseVisualStyleBackColor = true;
            this.CaK.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(77, 52);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 6;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(145, 113);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 7;
            // 
            // KaC
            // 
            this.KaC.Location = new System.Drawing.Point(30, 171);
            this.KaC.Name = "KaC";
            this.KaC.Size = new System.Drawing.Size(75, 23);
            this.KaC.TabIndex = 8;
            this.KaC.Text = "Kº a Cº";
            this.KaC.UseVisualStyleBackColor = true;
            this.KaC.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.KaC);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.CaK);
            this.Controls.Add(this.CaF);
            this.Controls.Add(this.FaC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FaC;
        private System.Windows.Forms.Button CaF;
        private System.Windows.Forms.Button CaK;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button KaC;
    }
}