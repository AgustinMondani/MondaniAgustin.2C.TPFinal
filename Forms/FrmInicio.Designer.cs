namespace Forms
{
    partial class FrmInicio
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
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            lblInicioSesion = new Label();
            btnIniciar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(67, 128);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(187, 34);
            txtCorreo.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(67, 218);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(187, 34);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(67, 97);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(76, 28);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(67, 187);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(114, 28);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblInicioSesion.Location = new Point(76, 21);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(169, 37);
            lblInicioSesion.TabIndex = 4;
            lblInicioSesion.Text = "Iniciar sesion";
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(25, 318);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(118, 38);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(181, 318);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(118, 38);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 407);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciar);
            Controls.Add(lblInicioSesion);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label lblCorreo;
        private Label lblContraseña;
        private Label lblInicioSesion;
        private Button btnIniciar;
        private Button btnRegistrar;
    }
}