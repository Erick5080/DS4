namespace Laboratorio_14
{
    partial class frmProductos
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
            tsbBuscar = new PictureBox();
            btnSalir = new Button();
            txtStock = new TextBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblId = new Label();
            lblStock = new Label();
            lblBuscar = new Label();
            txtId = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            tstId = new TextBox();
            tsbEliminar = new PictureBox();
            tsbNuevo = new PictureBox();
            pictureBox3 = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbCancelar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            SuspendLayout();
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.buscar;
            tsbBuscar.Location = new Point(387, 20);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(24, 20);
            tsbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbBuscar.TabIndex = 0;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 294);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 48);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(178, 217);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(137, 23);
            txtStock.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(42, 187);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(178, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(42, 109);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(178, 187);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(162, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(76, 15);
            lblBuscar.TabIndex = 7;
            lblBuscar.Text = "Buscar por Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(42, 127);
            txtId.Name = "txtId";
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(42, 214);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(83, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(493, 23);
            txtNombre.TabIndex = 10;
            // 
            // tstId
            // 
            tstId.Location = new Point(244, 17);
            tstId.Name = "tstId";
            tstId.Size = new Size(137, 23);
            tstId.TabIndex = 11;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = Properties.Resources.eliminar;
            tsbEliminar.Location = new Point(132, 17);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(24, 20);
            tsbEliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbEliminar.TabIndex = 12;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.nuevo;
            tsbNuevo.Location = new Point(42, 17);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(24, 20);
            tsbNuevo.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbNuevo.TabIndex = 13;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(311, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = Properties.Resources.guardar;
            tsbGuardar.Location = new Point(72, 17);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(24, 20);
            tsbGuardar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbGuardar.TabIndex = 15;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = Properties.Resources.cancelar;
            tsbCancelar.Location = new Point(102, 17);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(24, 20);
            tsbCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbCancelar.TabIndex = 16;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 365);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(pictureBox3);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbEliminar);
            Controls.Add(tstId);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtId);
            Controls.Add(lblBuscar);
            Controls.Add(lblStock);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(txtStock);
            Controls.Add(btnSalir);
            Controls.Add(tsbBuscar);
            Name = "frmProductos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tsbBuscar;
        private Button btnSalir;
        private TextBox txtStock;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblId;
        private Label lblStock;
        private Label lblBuscar;
        private TextBox txtId;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox tstId;
        private PictureBox tsbEliminar;
        private PictureBox tsbNuevo;
        private PictureBox pictureBox3;
        private PictureBox tsbGuardar;
        private PictureBox tsbCancelar;
    }
}
