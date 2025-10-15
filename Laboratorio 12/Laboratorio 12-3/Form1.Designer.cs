namespace Laboratorio_12_3
{
    partial class Triangulos
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_longitudA = new System.Windows.Forms.Label();
            this.lbl_longitudB = new System.Windows.Forms.Label();
            this.lbl_longitudC = new System.Windows.Forms.Label();
            this.txtbox_A = new System.Windows.Forms.TextBox();
            this.txtbox_B = new System.Windows.Forms.TextBox();
            this.txtbox_c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_Csemi = new System.Windows.Forms.Label();
            this.lbl_AreT = new System.Windows.Forms.Label();
            this.txtbox_CalcularSemiP = new System.Windows.Forms.TextBox();
            this.txtbox_AreaT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(201, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(71, 16);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Triangulos";
            // 
            // lbl_longitudA
            // 
            this.lbl_longitudA.AutoSize = true;
            this.lbl_longitudA.Location = new System.Drawing.Point(32, 68);
            this.lbl_longitudA.Name = "lbl_longitudA";
            this.lbl_longitudA.Size = new System.Drawing.Size(186, 16);
            this.lbl_longitudA.TabIndex = 1;
            this.lbl_longitudA.Text = "Ingrese la longitud del lado A :";
            // 
            // lbl_longitudB
            // 
            this.lbl_longitudB.AutoSize = true;
            this.lbl_longitudB.Location = new System.Drawing.Point(32, 125);
            this.lbl_longitudB.Name = "lbl_longitudB";
            this.lbl_longitudB.Size = new System.Drawing.Size(186, 16);
            this.lbl_longitudB.TabIndex = 2;
            this.lbl_longitudB.Text = "Ingrese la longitud del lado B :";
            // 
            // lbl_longitudC
            // 
            this.lbl_longitudC.AutoSize = true;
            this.lbl_longitudC.Location = new System.Drawing.Point(32, 181);
            this.lbl_longitudC.Name = "lbl_longitudC";
            this.lbl_longitudC.Size = new System.Drawing.Size(186, 16);
            this.lbl_longitudC.TabIndex = 3;
            this.lbl_longitudC.Text = "Ingrese la longitud del lado C :";
            // 
            // txtbox_A
            // 
            this.txtbox_A.Location = new System.Drawing.Point(240, 62);
            this.txtbox_A.Name = "txtbox_A";
            this.txtbox_A.Size = new System.Drawing.Size(100, 22);
            this.txtbox_A.TabIndex = 4;
            // 
            // txtbox_B
            // 
            this.txtbox_B.Location = new System.Drawing.Point(240, 119);
            this.txtbox_B.Name = "txtbox_B";
            this.txtbox_B.Size = new System.Drawing.Size(100, 22);
            this.txtbox_B.TabIndex = 5;
            // 
            // txtbox_c
            // 
            this.txtbox_c.Location = new System.Drawing.Point(240, 175);
            this.txtbox_c.Name = "txtbox_c";
            this.txtbox_c.Size = new System.Drawing.Size(100, 22);
            this.txtbox_c.TabIndex = 6;
            this.txtbox_c.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Semiperimetro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Salida";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_Csemi
            // 
            this.lbl_Csemi.AutoSize = true;
            this.lbl_Csemi.Location = new System.Drawing.Point(32, 294);
            this.lbl_Csemi.Name = "lbl_Csemi";
            this.lbl_Csemi.Size = new System.Drawing.Size(153, 16);
            this.lbl_Csemi.TabIndex = 11;
            this.lbl_Csemi.Text = "Calcular Semiperimetro :";
            // 
            // lbl_AreT
            // 
            this.lbl_AreT.AutoSize = true;
            this.lbl_AreT.Location = new System.Drawing.Point(32, 342);
            this.lbl_AreT.Name = "lbl_AreT";
            this.lbl_AreT.Size = new System.Drawing.Size(121, 16);
            this.lbl_AreT.TabIndex = 12;
            this.lbl_AreT.Text = "Area de Triangulo :";
            // 
            // txtbox_CalcularSemiP
            // 
            this.txtbox_CalcularSemiP.Location = new System.Drawing.Point(204, 288);
            this.txtbox_CalcularSemiP.Name = "txtbox_CalcularSemiP";
            this.txtbox_CalcularSemiP.Size = new System.Drawing.Size(100, 22);
            this.txtbox_CalcularSemiP.TabIndex = 13;
            // 
            // txtbox_AreaT
            // 
            this.txtbox_AreaT.Location = new System.Drawing.Point(204, 336);
            this.txtbox_AreaT.Name = "txtbox_AreaT";
            this.txtbox_AreaT.Size = new System.Drawing.Size(100, 22);
            this.txtbox_AreaT.TabIndex = 14;
            // 
            // Triangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.txtbox_AreaT);
            this.Controls.Add(this.txtbox_CalcularSemiP);
            this.Controls.Add(this.lbl_AreT);
            this.Controls.Add(this.lbl_Csemi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_c);
            this.Controls.Add(this.txtbox_B);
            this.Controls.Add(this.txtbox_A);
            this.Controls.Add(this.lbl_longitudC);
            this.Controls.Add(this.lbl_longitudB);
            this.Controls.Add(this.lbl_longitudA);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Triangulos";
            this.Text = "Triangulos";
            this.Load += new System.EventHandler(this.Triangulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_longitudA;
        private System.Windows.Forms.Label lbl_longitudB;
        private System.Windows.Forms.Label lbl_longitudC;
        private System.Windows.Forms.TextBox txtbox_A;
        private System.Windows.Forms.TextBox txtbox_B;
        private System.Windows.Forms.TextBox txtbox_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_Csemi;
        private System.Windows.Forms.Label lbl_AreT;
        private System.Windows.Forms.TextBox txtbox_CalcularSemiP;
        private System.Windows.Forms.TextBox txtbox_AreaT;
    }
}

