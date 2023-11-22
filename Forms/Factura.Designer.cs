namespace Forms
{
    partial class Factura
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
            lblClienteNombre = new Label();
            listProductos = new ListView();
            lblTotal = new Label();
            lblTotalPrecio = new Label();
            btnAceptar = new Button();
            lblFactura = new Label();
            lblFacturaNumero = new Label();
            SuspendLayout();
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(12, 9);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(72, 28);
            lblClienteNombre.TabIndex = 13;
            lblClienteNombre.Text = "Cliente";
            // 
            // listProductos
            // 
            listProductos.Location = new Point(25, 56);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(392, 335);
            listProductos.TabIndex = 14;
            listProductos.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(253, 404);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total:";
            // 
            // lblTotalPrecio
            // 
            lblTotalPrecio.AutoSize = true;
            lblTotalPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrecio.Location = new Point(317, 404);
            lblTotalPrecio.Name = "lblTotalPrecio";
            lblTotalPrecio.Size = new Size(23, 28);
            lblTotalPrecio.TabIndex = 16;
            lblTotalPrecio.Text = "0";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(39, 419);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(118, 38);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactura.Location = new Point(237, 9);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(107, 28);
            lblFactura.TabIndex = 18;
            lblFactura.Text = "N° Factura:";
            // 
            // lblFacturaNumero
            // 
            lblFacturaNumero.AutoSize = true;
            lblFacturaNumero.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaNumero.Location = new Point(338, 9);
            lblFacturaNumero.Name = "lblFacturaNumero";
            lblFacturaNumero.Size = new Size(23, 28);
            lblFacturaNumero.TabIndex = 19;
            lblFacturaNumero.Text = "0";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 482);
            Controls.Add(lblFacturaNumero);
            Controls.Add(lblFactura);
            Controls.Add(btnAceptar);
            Controls.Add(lblTotalPrecio);
            Controls.Add(lblTotal);
            Controls.Add(listProductos);
            Controls.Add(lblClienteNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblClienteNombre;
        private ListView listProductos;
        private Label lblTotal;
        private Label lblTotalPrecio;
        private Button btnAceptar;
        private Label lblFactura;
        private Label lblFacturaNumero;
    }
}