/*
 * Creado por SharpDevelop.
 * Usuario: angel
 * Fecha: 5/18/2023
 * Hora: 7:53 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class FormClient
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
			this.Pmovement = new System.Windows.Forms.Panel();
			this.lbGedtionDVD = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblCedula = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.labelApellido = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.lblFechaNac = new System.Windows.Forms.Label();
			this.datePickerNacimiento = new System.Windows.Forms.DateTimePicker();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.lblMovil = new System.Windows.Forms.Label();
			this.txtMovil = new System.Windows.Forms.TextBox();
			this.lblFechaRegist = new System.Windows.Forms.Label();
			this.dateTimeRegistro = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.btnRegist = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.errorProviderCedula = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderFecha = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderCorreo = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderMovil = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderFechaRegist = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnRecuperar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.Pmovement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCedula)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFecha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderMovil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaRegist)).BeginInit();
			this.SuspendLayout();
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.Pmovement.Controls.Add(this.lbGedtionDVD);
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(465, 31);
			this.Pmovement.TabIndex = 0;
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(20, 0);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(262, 32);
			this.lbGedtionDVD.TabIndex = 2;
			this.lbGedtionDVD.Text = "Gestión de Clientes";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 31);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(4, 418);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(461, 31);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(4, 418);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(4, 445);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(457, 4);
			this.panel4.TabIndex = 3;
			// 
			// lblCedula
			// 
			this.lblCedula.ForeColor = System.Drawing.Color.White;
			this.lblCedula.Location = new System.Drawing.Point(10, 50);
			this.lblCedula.Name = "lblCedula";
			this.lblCedula.Size = new System.Drawing.Size(58, 20);
			this.lblCedula.TabIndex = 9;
			this.lblCedula.Text = "Cédula: ";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(66, 50);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(181, 20);
			this.txtCedula.TabIndex = 10;
			// 
			// lblNombre
			// 
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(10, 101);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(58, 20);
			this.lblNombre.TabIndex = 11;
			this.lblNombre.Text = "Nombre: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(66, 98);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(181, 20);
			this.txtNombre.TabIndex = 12;
			// 
			// labelApellido
			// 
			this.labelApellido.ForeColor = System.Drawing.Color.White;
			this.labelApellido.Location = new System.Drawing.Point(10, 147);
			this.labelApellido.Name = "labelApellido";
			this.labelApellido.Size = new System.Drawing.Size(48, 20);
			this.labelApellido.TabIndex = 15;
			this.labelApellido.Text = "Apellido: ";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(66, 147);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(181, 20);
			this.txtApellido.TabIndex = 16;
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.ForeColor = System.Drawing.Color.White;
			this.lblFechaNac.Location = new System.Drawing.Point(10, 185);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(110, 20);
			this.lblFechaNac.TabIndex = 17;
			this.lblFechaNac.Text = "Fecha de nacimiento:";
			// 
			// datePickerNacimiento
			// 
			this.datePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerNacimiento.Location = new System.Drawing.Point(117, 185);
			this.datePickerNacimiento.Name = "datePickerNacimiento";
			this.datePickerNacimiento.Size = new System.Drawing.Size(130, 20);
			this.datePickerNacimiento.TabIndex = 18;
			// 
			// lblDireccion
			// 
			this.lblDireccion.ForeColor = System.Drawing.Color.White;
			this.lblDireccion.Location = new System.Drawing.Point(10, 221);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(58, 20);
			this.lblDireccion.TabIndex = 19;
			this.lblDireccion.Text = "Dirección: ";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(66, 221);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(181, 20);
			this.txtDireccion.TabIndex = 20;
			// 
			// lblCorreo
			// 
			this.lblCorreo.ForeColor = System.Drawing.Color.White;
			this.lblCorreo.Location = new System.Drawing.Point(10, 262);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(58, 20);
			this.lblCorreo.TabIndex = 21;
			this.lblCorreo.Text = "Correo: ";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(66, 262);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(181, 20);
			this.txtCorreo.TabIndex = 22;
			// 
			// lblTelefono
			// 
			this.lblTelefono.ForeColor = System.Drawing.Color.White;
			this.lblTelefono.Location = new System.Drawing.Point(10, 302);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(58, 20);
			this.lblTelefono.TabIndex = 23;
			this.lblTelefono.Text = "Telefono Movil: ";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(66, 302);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(181, 20);
			this.txtTelefono.TabIndex = 24;
			// 
			// lblMovil
			// 
			this.lblMovil.ForeColor = System.Drawing.Color.White;
			this.lblMovil.Location = new System.Drawing.Point(10, 338);
			this.lblMovil.Name = "lblMovil";
			this.lblMovil.Size = new System.Drawing.Size(58, 20);
			this.lblMovil.TabIndex = 25;
			this.lblMovil.Text = "Movil: ";
			// 
			// txtMovil
			// 
			this.txtMovil.Location = new System.Drawing.Point(66, 338);
			this.txtMovil.Name = "txtMovil";
			this.txtMovil.Size = new System.Drawing.Size(181, 20);
			this.txtMovil.TabIndex = 26;
			// 
			// lblFechaRegist
			// 
			this.lblFechaRegist.ForeColor = System.Drawing.Color.White;
			this.lblFechaRegist.Location = new System.Drawing.Point(10, 370);
			this.lblFechaRegist.Name = "lblFechaRegist";
			this.lblFechaRegist.Size = new System.Drawing.Size(101, 20);
			this.lblFechaRegist.TabIndex = 27;
			this.lblFechaRegist.Text = "Fecha de Registro:";
			// 
			// dateTimeRegistro
			// 
			this.dateTimeRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeRegistro.Location = new System.Drawing.Point(117, 372);
			this.dateTimeRegistro.Name = "dateTimeRegistro";
			this.dateTimeRegistro.Size = new System.Drawing.Size(130, 20);
			this.dateTimeRegistro.TabIndex = 28;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(347, 47);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 31;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(347, 98);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
			this.btnReiniciar.TabIndex = 32;
			this.btnReiniciar.Text = "Reiniciar";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			// 
			// btnRegist
			// 
			this.btnRegist.Location = new System.Drawing.Point(20, 402);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(75, 23);
			this.btnRegist.TabIndex = 33;
			this.btnRegist.Text = "Registrar";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(131, 402);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 34;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(237, 402);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 35;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(347, 402);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 36;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 129);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(389, 216);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// errorProviderCedula
			// 
			this.errorProviderCedula.ContainerControl = this;
			// 
			// errorProviderNombre
			// 
			this.errorProviderNombre.ContainerControl = this;
			// 
			// errorProviderApellido
			// 
			this.errorProviderApellido.ContainerControl = this;
			// 
			// errorProviderFecha
			// 
			this.errorProviderFecha.ContainerControl = this;
			// 
			// errorProviderDireccion
			// 
			this.errorProviderDireccion.ContainerControl = this;
			// 
			// errorProviderCorreo
			// 
			this.errorProviderCorreo.ContainerControl = this;
			// 
			// errorProviderTelefono
			// 
			this.errorProviderTelefono.ContainerControl = this;
			// 
			// errorProviderMovil
			// 
			this.errorProviderMovil.ContainerControl = this;
			// 
			// errorProviderFechaRegist
			// 
			this.errorProviderFechaRegist.ContainerControl = this;
			// 
			// btnRecuperar
			// 
			this.btnRecuperar.Location = new System.Drawing.Point(347, 197);
			this.btnRecuperar.Name = "btnRecuperar";
			this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
			this.btnRecuperar.TabIndex = 39;
			this.btnRecuperar.Text = "Restaurar";
			this.btnRecuperar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(347, 147);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 38;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(465, 449);
			this.Controls.Add(this.btnRecuperar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnRegist);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dateTimeRegistro);
			this.Controls.Add(this.lblFechaRegist);
			this.Controls.Add(this.txtMovil);
			this.Controls.Add(this.lblMovil);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.lblCorreo);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.datePickerNacimiento);
			this.Controls.Add(this.lblFechaNac);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.labelApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lblCedula);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Pmovement);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Pmovement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCedula)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFecha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderMovil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaRegist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnRegist;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DateTimePicker dateTimeRegistro;
		private System.Windows.Forms.Label lblFechaRegist;
		private System.Windows.Forms.TextBox txtMovil;
		private System.Windows.Forms.Label lblMovil;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.DateTimePicker datePickerNacimiento;
		private System.Windows.Forms.Label lblFechaNac;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label labelApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Label lbGedtionDVD;
		private System.Windows.Forms.Label lblCedula;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel Pmovement;
		private System.Windows.Forms.ErrorProvider errorProviderCedula;
		private System.Windows.Forms.ErrorProvider errorProviderNombre;
		private System.Windows.Forms.ErrorProvider errorProviderApellido;
		private System.Windows.Forms.ErrorProvider errorProviderFecha;
		private System.Windows.Forms.ErrorProvider errorProviderDireccion;
		private System.Windows.Forms.ErrorProvider errorProviderCorreo;
		private System.Windows.Forms.ErrorProvider errorProviderTelefono;
		private System.Windows.Forms.ErrorProvider errorProviderMovil;
		private System.Windows.Forms.ErrorProvider errorProviderFechaRegist;
		private System.Windows.Forms.Button btnRecuperar;
		private System.Windows.Forms.Button btnGuardar;
	}
}
