namespace Forms
{
    partial class FormAplicacion
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
            lblUsuario = new Label();
            lblTitulo = new Label();
            grpProductos = new GroupBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnVender = new Button();
            lblStockProducto = new Label();
            lblPrecioUnitario = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            cmbNombreProducto = new ComboBox();
            listProductos = new ListView();
            button1 = new Button();
            txtClienteNombre = new TextBox();
            grpComprador = new GroupBox();
            lblClienteApellido = new Label();
            lblClienteNombre = new Label();
            btnCliente = new Button();
            txtClienteApellido = new TextBox();
            btnCargarCsv = new Button();
            grpProductos.SuspendLayout();
            grpComprador.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(647, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(48, 28);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "user";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cascadia Mono SemiBold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(28, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 35);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "SISTEMAS DE VENTAS";
            // 
            // grpProductos
            // 
            grpProductos.BackColor = SystemColors.ActiveCaption;
            grpProductos.Controls.Add(lblCantidad);
            grpProductos.Controls.Add(txtCantidad);
            grpProductos.Controls.Add(btnVender);
            grpProductos.Controls.Add(lblStockProducto);
            grpProductos.Controls.Add(lblPrecioUnitario);
            grpProductos.Controls.Add(lblStock);
            grpProductos.Controls.Add(lblPrecio);
            grpProductos.Controls.Add(cmbNombreProducto);
            grpProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            grpProductos.Location = new Point(28, 206);
            grpProductos.Name = "grpProductos";
            grpProductos.Size = new Size(549, 216);
            grpProductos.TabIndex = 5;
            grpProductos.TabStop = false;
            grpProductos.Text = "Productos";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(337, 120);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(95, 28);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(431, 114);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(112, 34);
            txtCantidad.TabIndex = 8;
            // 
            // btnVender
            // 
            btnVender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.Location = new Point(218, 172);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(118, 38);
            btnVender.TabIndex = 7;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockProducto.Location = new Point(247, 120);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(23, 28);
            lblStockProducto.TabIndex = 6;
            lblStockProducto.Text = "0";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioUnitario.Location = new Point(72, 120);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(56, 28);
            lblPrecioUnitario.TabIndex = 5;
            lblPrecioUnitario.Text = "0000";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(186, 120);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 28);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(6, 120);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 28);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // cmbNombreProducto
            // 
            cmbNombreProducto.DropDownHeight = 200;
            cmbNombreProducto.DropDownWidth = 100;
            cmbNombreProducto.FormattingEnabled = true;
            cmbNombreProducto.IntegralHeight = false;
            cmbNombreProducto.ItemHeight = 28;
            cmbNombreProducto.Location = new Point(6, 59);
            cmbNombreProducto.Name = "cmbNombreProducto";
            cmbNombreProducto.Size = new Size(537, 36);
            cmbNombreProducto.TabIndex = 0;
            cmbNombreProducto.Tag = "";
            cmbNombreProducto.Text = "Nombre";
            cmbNombreProducto.SelectedIndexChanged += cmbNombreProducto_SelectedIndexChanged;
            // 
            // listProductos
            // 
            listProductos.Location = new Point(583, 70);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(244, 352);
            listProductos.TabIndex = 6;
            listProductos.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(627, 473);
            button1.Name = "button1";
            button1.Size = new Size(160, 38);
            button1.TabIndex = 8;
            button1.Text = "Finalizar Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(18, 63);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(187, 34);
            txtClienteNombre.TabIndex = 9;
            // 
            // grpComprador
            // 
            grpComprador.BackColor = SystemColors.ActiveCaption;
            grpComprador.Controls.Add(lblClienteApellido);
            grpComprador.Controls.Add(lblClienteNombre);
            grpComprador.Controls.Add(btnCliente);
            grpComprador.Controls.Add(txtClienteApellido);
            grpComprador.Controls.Add(txtClienteNombre);
            grpComprador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            grpComprador.Location = new Point(28, 70);
            grpComprador.Name = "grpComprador";
            grpComprador.Size = new Size(549, 115);
            grpComprador.TabIndex = 10;
            grpComprador.TabStop = false;
            grpComprador.Text = "Cliente";
            // 
            // lblClienteApellido
            // 
            lblClienteApellido.AutoSize = true;
            lblClienteApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellido.Location = new Point(218, 32);
            lblClienteApellido.Name = "lblClienteApellido";
            lblClienteApellido.Size = new Size(90, 28);
            lblClienteApellido.TabIndex = 13;
            lblClienteApellido.Text = "Apellido:";
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(18, 32);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(89, 28);
            lblClienteNombre.TabIndex = 12;
            lblClienteNombre.Text = "Nombre:";
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCliente.Location = new Point(425, 63);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(118, 34);
            btnCliente.TabIndex = 11;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // txtClienteApellido
            // 
            txtClienteApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellido.Location = new Point(218, 63);
            txtClienteApellido.Name = "txtClienteApellido";
            txtClienteApellido.Size = new Size(187, 34);
            txtClienteApellido.TabIndex = 10;
            // 
            // btnCargarCsv
            // 
            btnCargarCsv.BackColor = SystemColors.Info;
            btnCargarCsv.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarCsv.Location = new Point(12, 448);
            btnCargarCsv.Name = "btnCargarCsv";
            btnCargarCsv.Size = new Size(266, 63);
            btnCargarCsv.TabIndex = 11;
            btnCargarCsv.Text = "Cargar Productos por Csv";
            btnCargarCsv.UseVisualStyleBackColor = false;
            btnCargarCsv.Click += btnCargarCsv_Click;
            // 
            // FormAplicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 532);
            Controls.Add(btnCargarCsv);
            Controls.Add(grpComprador);
            Controls.Add(button1);
            Controls.Add(listProductos);
            Controls.Add(grpProductos);
            Controls.Add(lblTitulo);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAplicacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAplicacion";
            FormClosing += FormAplicacion_FormClosing;
            grpProductos.ResumeLayout(false);
            grpProductos.PerformLayout();
            grpComprador.ResumeLayout(false);
            grpComprador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblTitulo;
        private GroupBox grpProductos;
        private ComboBox cmbNombreProducto;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblStockProducto;
        private Label lblPrecioUnitario;
        private Button btnVender;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private ListView listProductos;
        private Button button1;
        private TextBox txtClienteNombre;
        private GroupBox grpComprador;
        private Label lblClienteApellido;
        private Label lblClienteNombre;
        private Button btnCliente;
        private TextBox txtClienteApellido;
        private Button btnCargarCsv;
    }
}