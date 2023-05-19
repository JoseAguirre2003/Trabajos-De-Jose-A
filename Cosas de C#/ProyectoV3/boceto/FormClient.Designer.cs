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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.Pmovement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.Pmovement.Controls.Add(this.lbGedtionDVD);
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(620, 38);
			this.Pmovement.TabIndex = 0;
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(27, 0);
			this.lbGedtionDVD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(349, 39);
			this.lbGedtionDVD.TabIndex = 2;
			this.lbGedtionDVD.Text = "Gestión de Clientes";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 38);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(5, 515);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(615, 38);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(5, 515);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(5, 548);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(610, 5);
			this.panel4.TabIndex = 3;
			// 
			// lblCedula
			// 
			this.lblCedula.ForeColor = System.Drawing.Color.White;
			this.lblCedula.Location = new System.Drawing.Point(13, 62);
			this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCedula.Name = "lblCedula";
			this.lblCedula.Size = new System.Drawing.Size(77, 25);
			this.lblCedula.TabIndex = 9;
			this.lblCedula.Text = "Cédula: ";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(88, 62);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(240, 22);
			this.txtCedula.TabIndex = 10;
			// 
			// lblNombre
			// 
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(13, 124);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(77, 25);
			this.lblNombre.TabIndex = 11;
			this.lblNombre.Text = "Nombre: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(88, 121);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(240, 22);
			this.txtNombre.TabIndex = 12;
			// 
			// labelApellido
			// 
			this.labelApellido.ForeColor = System.Drawing.Color.White;
			this.labelApellido.Location = new System.Drawing.Point(13, 181);
			this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelApellido.Name = "labelApellido";
			this.labelApellido.Size = new System.Drawing.Size(64, 25);
			this.labelApellido.TabIndex = 15;
			this.labelApellido.Text = "Apellido: ";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(88, 181);
			this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(240, 22);
			this.txtApellido.TabIndex = 16;
			// 
			// lblFechaNac
			// 
			this.lblFechaNac.ForeColor = System.Drawing.Color.White;
			this.lblFechaNac.Location = new System.Drawing.Point(13, 228);
			this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFechaNac.Name = "lblFechaNac";
			this.lblFechaNac.Size = new System.Drawing.Size(147, 25);
			this.lblFechaNac.TabIndex = 17;
			this.lblFechaNac.Text = "Fecha de nacimiento:";
			// 
			// datePickerNacimiento
			// 
			this.datePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerNacimiento.Location = new System.Drawing.Point(156, 228);
			this.datePickerNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.datePickerNacimiento.Name = "datePickerNacimiento";
			this.datePickerNacimiento.Size = new System.Drawing.Size(172, 22);
			this.datePickerNacimiento.TabIndex = 18;
			// 
			// lblDireccion
			// 
			this.lblDireccion.ForeColor = System.Drawing.Color.White;
			this.lblDireccion.Location = new System.Drawing.Point(13, 272);
			this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(77, 25);
			this.lblDireccion.TabIndex = 19;
			this.lblDireccion.Text = "Dirección: ";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(88, 272);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(240, 22);
			this.txtDireccion.TabIndex = 20;
			// 
			// lblCorreo
			// 
			this.lblCorreo.ForeColor = System.Drawing.Color.White;
			this.lblCorreo.Location = new System.Drawing.Point(13, 322);
			this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(77, 25);
			this.lblCorreo.TabIndex = 21;
			this.lblCorreo.Text = "Correo: ";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(88, 322);
			this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(240, 22);
			this.txtCorreo.TabIndex = 22;
			// 
			// lblTelefono
			// 
			this.lblTelefono.ForeColor = System.Drawing.Color.White;
			this.lblTelefono.Location = new System.Drawing.Point(13, 372);
			this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(77, 25);
			this.lblTelefono.TabIndex = 23;
			this.lblTelefono.Text = "Telefono Movil: ";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(88, 372);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(240, 22);
			this.txtTelefono.TabIndex = 24;
			// 
			// lblMovil
			// 
			this.lblMovil.ForeColor = System.Drawing.Color.White;
			this.lblMovil.Location = new System.Drawing.Point(13, 416);
			this.lblMovil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMovil.Name = "lblMovil";
			this.lblMovil.Size = new System.Drawing.Size(77, 25);
			this.lblMovil.TabIndex = 25;
			this.lblMovil.Text = "Movil: ";
			// 
			// txtMovil
			// 
			this.txtMovil.Location = new System.Drawing.Point(88, 416);
			this.txtMovil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMovil.Name = "txtMovil";
			this.txtMovil.Size = new System.Drawing.Size(240, 22);
			this.txtMovil.TabIndex = 26;
			// 
			// lblFechaRegist
			// 
			this.lblFechaRegist.ForeColor = System.Drawing.Color.White;
			this.lblFechaRegist.Location = new System.Drawing.Point(13, 455);
			this.lblFechaRegist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFechaRegist.Name = "lblFechaRegist";
			this.lblFechaRegist.Size = new System.Drawing.Size(135, 25);
			this.lblFechaRegist.TabIndex = 27;
			this.lblFechaRegist.Text = "Fecha de Registro:";
			// 
			// dateTimeRegistro
			// 
			this.dateTimeRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeRegistro.Location = new System.Drawing.Point(156, 458);
			this.dateTimeRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimeRegistro.Name = "dateTimeRegistro";
			this.dateTimeRegistro.Size = new System.Drawing.Size(172, 22);
			this.dateTimeRegistro.TabIndex = 28;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(463, 58);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(100, 28);
			this.btnBuscar.TabIndex = 31;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(463, 121);
			this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(100, 28);
			this.btnReiniciar.TabIndex = 32;
			this.btnReiniciar.Text = "Reiniciar";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			// 
			// btnRegist
			// 
			this.btnRegist.Location = new System.Drawing.Point(27, 495);
			this.btnRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(100, 28);
			this.btnRegist.TabIndex = 33;
			this.btnRegist.Text = "Registrar";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(175, 495);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(100, 28);
			this.btnActualizar.TabIndex = 34;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(316, 495);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(100, 28);
			this.btnEliminar.TabIndex = 35;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(463, 495);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(100, 28);
			this.btnCerrar.TabIndex = 36;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(44, 159);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(519, 266);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(5, 38);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 3);
			this.panel1.TabIndex = 38;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(612, 41);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(3, 507);
			this.panel5.TabIndex = 39;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(5, 545);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(607, 3);
			this.panel6.TabIndex = 40;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(5, 41);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(3, 504);
			this.panel7.TabIndex = 41;
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(620, 553);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
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
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Pmovement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel1;
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
	}
}
