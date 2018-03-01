namespace práctica_archivostxtybin_xmlybmp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDatosDeImagen = new System.Windows.Forms.TextBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.ofd_image = new System.Windows.Forms.OpenFileDialog();
            this.lblAdorno = new System.Windows.Forms.Label();
            this.lblCatálogo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTeléfono = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.sfd_xml = new System.Windows.Forms.SaveFileDialog();
            this.lblInformación = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatosDeImagen
            // 
            this.txtDatosDeImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosDeImagen.Location = new System.Drawing.Point(12, 56);
            this.txtDatosDeImagen.Multiline = true;
            this.txtDatosDeImagen.Name = "txtDatosDeImagen";
            this.txtDatosDeImagen.Size = new System.Drawing.Size(307, 163);
            this.txtDatosDeImagen.TabIndex = 0;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDatos.Location = new System.Drawing.Point(351, 111);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(114, 52);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "Mostrar Información";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // ofd_image
            // 
            this.ofd_image.FileName = "openFileDialog1";
            // 
            // lblAdorno
            // 
            this.lblAdorno.AutoSize = true;
            this.lblAdorno.Location = new System.Drawing.Point(-8, 245);
            this.lblAdorno.Name = "lblAdorno";
            this.lblAdorno.Size = new System.Drawing.Size(595, 13);
            this.lblAdorno.TabIndex = 2;
            this.lblAdorno.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // lblCatálogo
            // 
            this.lblCatálogo.AutoSize = true;
            this.lblCatálogo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatálogo.Location = new System.Drawing.Point(168, 269);
            this.lblCatálogo.Name = "lblCatálogo";
            this.lblCatálogo.Size = new System.Drawing.Size(179, 18);
            this.lblCatálogo.TabIndex = 3;
            this.lblCatálogo.Text = "Catálogo de información";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(129, 306);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(141, 341);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 18);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.Location = new System.Drawing.Point(124, 375);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(70, 18);
            this.lblTeléfono.TabIndex = 6;
            this.lblTeléfono.Text = "Teléfono:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(131, 411);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(63, 18);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(141, 445);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 307);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(199, 339);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(197, 26);
            this.txtEdad.TabIndex = 10;
            // 
            // txtTeléfono
            // 
            this.txtTeléfono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeléfono.Location = new System.Drawing.Point(199, 376);
            this.txtTeléfono.Name = "txtTeléfono";
            this.txtTeléfono.Size = new System.Drawing.Size(197, 26);
            this.txtTeléfono.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(199, 411);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(197, 26);
            this.txtCiudad.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(199, 443);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArchivo.Location = new System.Drawing.Point(199, 503);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(148, 41);
            this.btnGuardarArchivo.TabIndex = 14;
            this.btnGuardarArchivo.Text = "Guardar archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // lblInformación
            // 
            this.lblInformación.AutoSize = true;
            this.lblInformación.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformación.Location = new System.Drawing.Point(62, 23);
            this.lblInformación.Name = "lblInformación";
            this.lblInformación.Size = new System.Drawing.Size(206, 18);
            this.lblInformación.TabIndex = 16;
            this.lblInformación.Text = "Información del archivo .bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 556);
            this.Controls.Add(this.lblInformación);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtTeléfono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblTeléfono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCatálogo);
            this.Controls.Add(this.lblAdorno);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.txtDatosDeImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatosDeImagen;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.OpenFileDialog ofd_image;
        private System.Windows.Forms.Label lblAdorno;
        private System.Windows.Forms.Label lblCatálogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTeléfono;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardarArchivo;
        private System.Windows.Forms.SaveFileDialog sfd_xml;
        private System.Windows.Forms.Label lblInformación;
    }
}

