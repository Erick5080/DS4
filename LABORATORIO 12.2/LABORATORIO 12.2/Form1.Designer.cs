namespace LABORATORIO_12._2
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
            lblTitulo = new Label();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblPromedio = new Label();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            btnSalida = new Button();
            txtNota1 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(219, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(88, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nota Promedio";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(104, 113);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(56, 15);
            lblNota1.TabIndex = 1;
            lblNota1.Text = "Nota N°1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(104, 156);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(56, 15);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "Nota N°2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(104, 200);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(56, 15);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "Nota N°3";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(104, 322);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(59, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(116, 251);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 226);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(219, 251);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(320, 251);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(75, 23);
            btnSalida.TabIndex = 9;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalir_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(283, 107);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 10;
            txtNota1.TextChanged += txtNota1_TextChanged;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(283, 197);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 11;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(283, 148);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 12;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(283, 314);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(txtResultado);
            Controls.Add(txtNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota1);
            Controls.Add(btnSalida);
            Controls.Add(btnLimpiar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(lblPromedio);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblPromedio;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Button btnLimpiar;
        private Button btnSalida;
        private TextBox txtNota1;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private TextBox txtResultado;
    }
}
