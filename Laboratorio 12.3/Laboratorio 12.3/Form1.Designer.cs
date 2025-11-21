namespace Laboratorio_12._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnLimpiar = new Button();
            btnSalida = new Button();
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblC = new Label();
            lblCalcularSemiperimetro = new Label();
            label5 = new Label();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            txtResultSemiP = new TextBox();
            txtAreaTriangulo = new TextBox();
            SuspendLayout();
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(149, 204);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(99, 23);
            btnSemiperimetro.TabIndex = 0;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiPerimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(290, 204);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(75, 23);
            btnArea.TabIndex = 1;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(403, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(517, 204);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(75, 23);
            btnSalida.TabIndex = 3;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalir_Click;
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(111, 42);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(161, 15);
            lblLadoA.TabIndex = 4;
            lblLadoA.Text = "Ingrese la longitud del lado A";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(111, 88);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(160, 15);
            lblLadoB.TabIndex = 5;
            lblLadoB.Text = "Ingrese la longitud del lado B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(111, 134);
            lblC.Name = "lblC";
            lblC.Size = new Size(161, 15);
            lblC.TabIndex = 6;
            lblC.Text = "Ingrese la longitud del lado C";
            // 
            // lblCalcularSemiperimetro
            // 
            lblCalcularSemiperimetro.AutoSize = true;
            lblCalcularSemiperimetro.Location = new Point(111, 287);
            lblCalcularSemiperimetro.Name = "lblCalcularSemiperimetro";
            lblCalcularSemiperimetro.Size = new Size(131, 15);
            lblCalcularSemiperimetro.TabIndex = 7;
            lblCalcularSemiperimetro.Text = "Calcular Semiperimetro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 350);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 8;
            label5.Text = "Area del Triangulo";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(386, 39);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 9;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(386, 85);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 10;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(386, 126);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(100, 23);
            txtLadoC.TabIndex = 11;
            // 
            // txtResultSemiP
            // 
            txtResultSemiP.Location = new Point(386, 279);
            txtResultSemiP.Name = "txtResultSemiP";
            txtResultSemiP.Size = new Size(100, 23);
            txtResultSemiP.TabIndex = 12;
            // 
            // txtAreaTriangulo
            // 
            txtAreaTriangulo.Location = new Point(386, 342);
            txtAreaTriangulo.Name = "txtAreaTriangulo";
            txtAreaTriangulo.Size = new Size(100, 23);
            txtAreaTriangulo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAreaTriangulo);
            Controls.Add(txtResultSemiP);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(label5);
            Controls.Add(lblCalcularSemiperimetro);
            Controls.Add(lblC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Controls.Add(btnSalida);
            Controls.Add(btnLimpiar);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnLimpiar;
        private Button btnSalida;
        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblC;
        private Label lblCalcularSemiperimetro;
        private Label label5;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private TextBox txtResultSemiP;
        private TextBox txtAreaTriangulo;
    }
}
