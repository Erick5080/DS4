namespace Laboratorio_12._1
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
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            lblVelocidad = new Label();
            lblTiempo = new Label();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            txtResultado = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(136, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(254, 186);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(359, 186);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 47);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Calculador de Distancia";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(84, 91);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(58, 15);
            lblVelocidad.TabIndex = 4;
            lblVelocidad.Text = "Velocidad";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(84, 132);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(47, 15);
            lblTiempo.TabIndex = 5;
            lblTiempo.Text = "Tiempo";
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(262, 84);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(100, 23);
            txtVelocidad.TabIndex = 6;
            txtVelocidad.TextChanged += txtDistancia_TextChanged;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(262, 132);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 7;
            txtTiempo.TextChanged += txtTiempo_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(262, 253);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 8;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(84, 256);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(lblTiempo);
            Controls.Add(lblVelocidad);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label lblVelocidad;
        private Label lblTiempo;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}
