/*
 * Created by SharpDevelop.
 * User: netwo
 * Date: 13/5/2023
 * Time: 12:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoV1
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
			this.lbGedtionDVD = new System.Windows.Forms.Label();
			this.datePickerNacimiento = new System.Windows.Forms.DateTimePicker();
			this.lblFechaNac = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.lblCedula = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.labelApellido = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtMovil = new System.Windows.Forms.TextBox();
			this.lblMovil = new System.Windows.Forms.Label();
			this.dateTimeRegistro = new System.Windows.Forms.DateTimePicker();
			this.lblFechaRegist = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnRegist = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(47, 9);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(263, 32);
			this.lbGedtionDVD.TabIndex = 1;
			this.lbGedtionDVD.Text = "Gestión de Clientes";
			// 
			// datePickerNacimiento
			// 
			this.datePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerNacimiento.Location = new System.Drawing.Point(134, 138);
			this.datePickerNacimiento.Name = "datePickerNacimiento";
			this.datePickerNacimiento.Size = new System.Drawing.Size(130, 20);
			this.datePickerNacimiento.TabIndex = 13;
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.Location = new System.Drawing.Point(19, 137);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(140, 20);
			this.lblFechaNac.TabIndex = 12;
			this.lblFechaNac.Text = "Fecha de nacimiento:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(83, 86);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(181, 20);
			this.txtNombre.TabIndex = 11;
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(19, 86);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(58, 20);
			this.lblNombre.TabIndex = 10;
			this.lblNombre.Text = "Nombre: ";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(83, 60);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(181, 20);
			this.txtCedula.TabIndex = 9;
			// 
			// lblCedula
			// 
			this.lblCedula.Location = new System.Drawing.Point(19, 60);
			this.lblCedula.Name = "lblCedula";
			this.lblCedula.Size = new System.Drawing.Size(58, 20);
			this.lblCedula.TabIndex = 8;
			this.lblCedula.Text = "Cédula: ";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(83, 112);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(181, 20);
			this.txtApellido.TabIndex = 15;
			// 
			// labelApellido
			// 
			this.labelApellido.Location = new System.Drawing.Point(19, 112);
			this.labelApellido.Name = "labelApellido";
			this.labelApellido.Size = new System.Drawing.Size(58, 20);
			this.labelApellido.TabIndex = 14;
			this.labelApellido.Text = "Apellido: ";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(83, 164);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(181, 20);
			this.txtDireccion.TabIndex = 17;
			// 
			// lblDireccion
			// 
			this.lblDireccion.Location = new System.Drawing.Point(19, 164);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(58, 20);
			this.lblDireccion.TabIndex = 16;
			this.lblDireccion.Text = "Dirección: ";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(83, 190);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(181, 20);
			this.txtCorreo.TabIndex = 19;
			// 
			// lblCorreo
			// 
			this.lblCorreo.Location = new System.Drawing.Point(19, 190);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(58, 20);
			this.lblCorreo.TabIndex = 18;
			this.lblCorreo.Text = "Correo: ";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(83, 216);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(181, 20);
			this.txtTelefono.TabIndex = 21;
			// 
			// lblTelefono
			// 
			this.lblTelefono.Location = new System.Drawing.Point(19, 216);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(58, 20);
			this.lblTelefono.TabIndex = 20;
			this.lblTelefono.Text = "Telefono Movil: ";
			// 
			// txtMovil
			// 
			this.txtMovil.Location = new System.Drawing.Point(83, 242);
			this.txtMovil.Name = "txtMovil";
			this.txtMovil.Size = new System.Drawing.Size(181, 20);
			this.txtMovil.TabIndex = 23;
			// 
			// lblMovil
			// 
			this.lblMovil.Location = new System.Drawing.Point(19, 242);
			this.lblMovil.Name = "lblMovil";
			this.lblMovil.Size = new System.Drawing.Size(58, 20);
			this.lblMovil.TabIndex = 22;
			this.lblMovil.Text = "Movil: ";
			// 
			// dateTimeRegistro
			// 
			this.dateTimeRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeRegistro.Location = new System.Drawing.Point(134, 268);
			this.dateTimeRegistro.Name = "dateTimeRegistro";
			this.dateTimeRegistro.Size = new System.Drawing.Size(130, 20);
			this.dateTimeRegistro.TabIndex = 25;
			// 
			// lblFechaRegist
			// 
			this.lblFechaRegist.Location = new System.Drawing.Point(19, 267);
			this.lblFechaRegist.Name = "lblFechaRegist";
			this.lblFechaRegist.Size = new System.Drawing.Size(140, 20);
			this.lblFechaRegist.TabIndex = 24;
			this.lblFechaRegist.Text = "Fecha de Registro:";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(270, 307);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 26;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnRegist
			// 
			this.btnRegist.Location = new System.Drawing.Point(27, 307);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(75, 23);
			this.btnRegist.TabIndex = 29;
			this.btnRegist.Text = "Registrar";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(189, 307);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 28;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(108, 307);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 27;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(281, 58);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 30;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(281, 99);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
			this.btnReiniciar.TabIndex = 31;
			this.btnReiniciar.Text = "Reiniciar";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(389, 353);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnRegist);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnCerrar);
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
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.labelApellido);
			this.Controls.Add(this.datePickerNacimiento);
			this.Controls.Add(this.lblFechaNac);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lblCedula);
			this.Controls.Add(this.lbGedtionDVD);
			this.Name = "FormClient";
			this.Text = "FormClient";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnRegist;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label lblFechaRegist;
		private System.Windows.Forms.DateTimePicker dateTimeRegistro;
		private System.Windows.Forms.Label lblMovil;
		private System.Windows.Forms.TextBox txtMovil;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label labelApellido;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label lblCedula;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblFechaNac;
		private System.Windows.Forms.DateTimePicker datePickerNacimiento;
		private System.Windows.Forms.Label lbGedtionDVD;
	}
}
