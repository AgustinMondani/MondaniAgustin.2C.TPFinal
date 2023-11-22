namespace Forms
{
    partial class FormRegistro
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
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtContraseña = new TextBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(71, 204);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(187, 34);
            txtCorreo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(71, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 34);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(71, 124);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(187, 34);
            txtApellido.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(71, 283);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(187, 34);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(71, 173);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(76, 28);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(71, 252);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(114, 28);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(71, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 28);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(71, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(98, 339);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(118, 38);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 407);
            Controls.Add(btnAceptar);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(txtContraseña);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            FormClosed += FormRegistro_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtContraseña;
        private Label lblCorreo;
        private Label lblContraseña;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnAceptar;
    }
}