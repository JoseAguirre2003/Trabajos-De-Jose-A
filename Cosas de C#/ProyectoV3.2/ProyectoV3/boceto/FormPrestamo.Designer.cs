/*
 * Creado por SharpDevelop.
 * Usuario: Vladi1000
 * Fecha: 18/05/2023
 * Hora: 09:47 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class FormPrestamo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblCedula;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbGedtionDVD;
		private System.Windows.Forms.Label labelDVD;
		private System.Windows.Forms.Label CantidadDias;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label labelInfClient;
		private System.Windows.Forms.Label lblCedulaInf;
		private System.Windows.Forms.Label lblNombreInf;
		private System.Windows.Forms.Label lblApellidoInf;
		private System.Windows.Forms.Label lblFechaNacim;
		private System.Windows.Forms.Label lblDireccionInf;
		private System.Windows.Forms.Label lblCorreoInf;
		private System.Windows.Forms.Label lblTelefMvlInf;
		private System.Windows.Forms.Label lblTelefInf;
		private System.Windows.Forms.Label lblFechaRegist;
		private System.Windows.Forms.Label labelInfPrestamo;
		private System.Windows.Forms.Label lblPrecioDe;
		private System.Windows.Forms.Label lblCantidadRenta;
		private System.Windows.Forms.Label lblMonto;
		private System.Windows.Forms.Button btnRegistrar;
		
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
			this.lblCedula = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lbGedtionDVD = new System.Windows.Forms.Label();
			this.labelDVD = new System.Windows.Forms.Label();
			this.CantidadDias = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.labelInfClient = new System.Windows.Forms.Label();
			this.lblCedulaInf = new System.Windows.Forms.Label();
			this.lblNombreInf = new System.Windows.Forms.Label();
			this.lblApellidoInf = new System.Windows.Forms.Label();
			this.lblFechaNacim = new System.Windows.Forms.Label();
			this.lblDireccionInf = new System.Windows.Forms.Label();
			this.lblCorreoInf = new System.Windows.Forms.Label();
			this.lblTelefMvlInf = new System.Windows.Forms.Label();
			this.lblTelefInf = new System.Windows.Forms.Label();
			this.lblFechaRegist = new System.Windows.Forms.Label();
			this.labelInfPrestamo = new System.Windows.Forms.Label();
			this.lblPrecioDe = new System.Windows.Forms.Label();
			this.lblCantidadRenta = new System.Windows.Forms.Label();
			this.lblMonto = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.Pmovement = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.comboBoxCedula = new System.Windows.Forms.ComboBox();
			this.comboBoxDVD = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.Pmovement.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCedula
			// 
			this.lblCedula.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCedula.ForeColor = System.Drawing.Color.White;
			this.lblCedula.Location = new System.Drawing.Point(25, 96);
			this.lblCedula.Name = "lblCedula";
			this.lblCedula.Size = new System.Drawing.Size(58, 20);
			this.lblCedula.TabIndex = 4;
			this.lblCedula.Text = "Cedula:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(199, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.BackColor = System.Drawing.Color.Transparent;
			this.lbGedtionDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbGedtionDVD.Font = new System.Drawing.Font("Impact", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(15, 0);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(388, 45);
			this.lbGedtionDVD.TabIndex = 7;
			this.lbGedtionDVD.Text = "Gestion de Prestamos";
			// 
			// labelDVD
			// 
			this.labelDVD.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDVD.ForeColor = System.Drawing.Color.White;
			this.labelDVD.Location = new System.Drawing.Point(25, 125);
			this.labelDVD.Name = "labelDVD";
			this.labelDVD.Size = new System.Drawing.Size(43, 20);
			this.labelDVD.TabIndex = 9;
			this.labelDVD.Text = "DVD:";
			// 
			// CantidadDias
			// 
			this.CantidadDias.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CantidadDias.ForeColor = System.Drawing.Color.White;
			this.CantidadDias.Location = new System.Drawing.Point(25, 165);
			this.CantidadDias.Name = "CantidadDias";
			this.CantidadDias.Size = new System.Drawing.Size(196, 27);
			this.CantidadDias.TabIndex = 10;
			this.CantidadDias.Text = "Cantidad de dias de prestamo:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(209, 168);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown1.TabIndex = 11;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelInfClient
			// 
			this.labelInfClient.BackColor = System.Drawing.Color.Transparent;
			this.labelInfClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelInfClient.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfClient.ForeColor = System.Drawing.Color.White;
			this.labelInfClient.Location = new System.Drawing.Point(297, 66);
			this.labelInfClient.Name = "labelInfClient";
			this.labelInfClient.Size = new System.Drawing.Size(225, 23);
			this.labelInfClient.TabIndex = 14;
			this.labelInfClient.Text = "Info del cliente";
			// 
			// lblCedulaInf
			// 
			this.lblCedulaInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCedulaInf.ForeColor = System.Drawing.Color.White;
			this.lblCedulaInf.Location = new System.Drawing.Point(313, 96);
			this.lblCedulaInf.Name = "lblCedulaInf";
			this.lblCedulaInf.Size = new System.Drawing.Size(226, 20);
			this.lblCedulaInf.TabIndex = 15;
			this.lblCedulaInf.Text = "Cedula:";
			// 
			// lblNombreInf
			// 
			this.lblNombreInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreInf.ForeColor = System.Drawing.Color.White;
			this.lblNombreInf.Location = new System.Drawing.Point(313, 116);
			this.lblNombreInf.Name = "lblNombreInf";
			this.lblNombreInf.Size = new System.Drawing.Size(226, 20);
			this.lblNombreInf.TabIndex = 16;
			this.lblNombreInf.Text = "Nombres:";
			// 
			// lblApellidoInf
			// 
			this.lblApellidoInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApellidoInf.ForeColor = System.Drawing.Color.White;
			this.lblApellidoInf.Location = new System.Drawing.Point(313, 136);
			this.lblApellidoInf.Name = "lblApellidoInf";
			this.lblApellidoInf.Size = new System.Drawing.Size(226, 20);
			this.lblApellidoInf.TabIndex = 17;
			this.lblApellidoInf.Text = "Apellidos:";
			// 
			// lblFechaNacim
			// 
			this.lblFechaNacim.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaNacim.ForeColor = System.Drawing.Color.White;
			this.lblFechaNacim.Location = new System.Drawing.Point(313, 156);
			this.lblFechaNacim.Name = "lblFechaNacim";
			this.lblFechaNacim.Size = new System.Drawing.Size(246, 20);
			this.lblFechaNacim.TabIndex = 18;
			this.lblFechaNacim.Text = "Fecha de Nacimiento:";
			// 
			// lblDireccionInf
			// 
			this.lblDireccionInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccionInf.ForeColor = System.Drawing.Color.White;
			this.lblDireccionInf.Location = new System.Drawing.Point(313, 176);
			this.lblDireccionInf.Name = "lblDireccionInf";
			this.lblDireccionInf.Size = new System.Drawing.Size(226, 31);
			this.lblDireccionInf.TabIndex = 19;
			this.lblDireccionInf.Text = "Direccion:";
			// 
			// lblCorreoInf
			// 
			this.lblCorreoInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreoInf.ForeColor = System.Drawing.Color.White;
			this.lblCorreoInf.Location = new System.Drawing.Point(314, 197);
			this.lblCorreoInf.Name = "lblCorreoInf";
			this.lblCorreoInf.Size = new System.Drawing.Size(226, 20);
			this.lblCorreoInf.TabIndex = 20;
			this.lblCorreoInf.Text = "Correo:";
			// 
			// lblTelefMvlInf
			// 
			this.lblTelefMvlInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefMvlInf.ForeColor = System.Drawing.Color.White;
			this.lblTelefMvlInf.Location = new System.Drawing.Point(313, 217);
			this.lblTelefMvlInf.Name = "lblTelefMvlInf";
			this.lblTelefMvlInf.Size = new System.Drawing.Size(226, 20);
			this.lblTelefMvlInf.TabIndex = 21;
			this.lblTelefMvlInf.Text = "Telefono Movil:";
			// 
			// lblTelefInf
			// 
			this.lblTelefInf.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefInf.ForeColor = System.Drawing.Color.White;
			this.lblTelefInf.Location = new System.Drawing.Point(313, 237);
			this.lblTelefInf.Name = "lblTelefInf";
			this.lblTelefInf.Size = new System.Drawing.Size(226, 20);
			this.lblTelefInf.TabIndex = 22;
			this.lblTelefInf.Text = "Telefono:";
			// 
			// lblFechaRegist
			// 
			this.lblFechaRegist.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaRegist.ForeColor = System.Drawing.Color.White;
			this.lblFechaRegist.Location = new System.Drawing.Point(314, 257);
			this.lblFechaRegist.Name = "lblFechaRegist";
			this.lblFechaRegist.Size = new System.Drawing.Size(246, 20);
			this.lblFechaRegist.TabIndex = 23;
			this.lblFechaRegist.Text = "Fecha de Registro:";
			// 
			// labelInfPrestamo
			// 
			this.labelInfPrestamo.BackColor = System.Drawing.Color.Transparent;
			this.labelInfPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelInfPrestamo.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfPrestamo.ForeColor = System.Drawing.Color.White;
			this.labelInfPrestamo.Location = new System.Drawing.Point(25, 217);
			this.labelInfPrestamo.Name = "labelInfPrestamo";
			this.labelInfPrestamo.Size = new System.Drawing.Size(257, 23);
			this.labelInfPrestamo.TabIndex = 31;
			this.labelInfPrestamo.Text = "Info del Prestamo:";
			// 
			// lblPrecioDe
			// 
			this.lblPrecioDe.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioDe.ForeColor = System.Drawing.Color.White;
			this.lblPrecioDe.Location = new System.Drawing.Point(28, 238);
			this.lblPrecioDe.Name = "lblPrecioDe";
			this.lblPrecioDe.Size = new System.Drawing.Size(270, 17);
			this.lblPrecioDe.TabIndex = 32;
			this.lblPrecioDe.Text = "Se renta por un precio de:";
			// 
			// lblCantidadRenta
			// 
			this.lblCantidadRenta.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidadRenta.ForeColor = System.Drawing.Color.White;
			this.lblCantidadRenta.Location = new System.Drawing.Point(28, 257);
			this.lblCantidadRenta.Name = "lblCantidadRenta";
			this.lblCantidadRenta.Size = new System.Drawing.Size(270, 17);
			this.lblCantidadRenta.TabIndex = 33;
			this.lblCantidadRenta.Text = "La cantidad a alquilar es:";
			// 
			// lblMonto
			// 
			this.lblMonto.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonto.ForeColor = System.Drawing.Color.White;
			this.lblMonto.Location = new System.Drawing.Point(28, 278);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(270, 17);
			this.lblMonto.TabIndex = 34;
			this.lblMonto.Text = "Monto Total:  0$";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(28, 521);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 35;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.Pmovement.Controls.Add(this.panel5);
			this.Pmovement.Controls.Add(this.btnSalir);
			this.Pmovement.Controls.Add(this.lbGedtionDVD);
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(926, 30);
			this.Pmovement.TabIndex = 36;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 28);
			this.panel5.Margin = new System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(926, 2);
			this.panel5.TabIndex = 42;
			// 
			// btnSalir
			// 
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Location = new System.Drawing.Point(953, 2);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(28, 27);
			this.btnSalir.TabIndex = 41;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(12, 543);
			this.panel1.TabIndex = 37;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Black;
			this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel10.Location = new System.Drawing.Point(2, 541);
			this.panel10.Margin = new System.Windows.Forms.Padding(2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(10, 2);
			this.panel10.TabIndex = 1;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Black;
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Margin = new System.Windows.Forms.Padding(2);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(2, 543);
			this.panel9.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(914, 30);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(12, 543);
			this.panel2.TabIndex = 38;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel8.Location = new System.Drawing.Point(0, 541);
			this.panel8.Margin = new System.Windows.Forms.Padding(2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 2);
			this.panel8.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(10, 0);
			this.panel6.Margin = new System.Windows.Forms.Padding(2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(2, 543);
			this.panel6.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(12, 560);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(902, 13);
			this.panel3.TabIndex = 39;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 11);
			this.panel7.Margin = new System.Windows.Forms.Padding(2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(902, 2);
			this.panel7.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(12, 30);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(902, 13);
			this.panel4.TabIndex = 40;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(607, 521);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 59;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// comboBoxCedula
			// 
			this.comboBoxCedula.FormattingEnabled = true;
			this.comboBoxCedula.Location = new System.Drawing.Point(76, 95);
			this.comboBoxCedula.Name = "comboBoxCedula";
			this.comboBoxCedula.Size = new System.Drawing.Size(197, 21);
			this.comboBoxCedula.TabIndex = 61;
			this.comboBoxCedula.Text = "Cedula";
			// 
			// comboBoxDVD
			// 
			this.comboBoxDVD.DisplayMember = "a";
			this.comboBoxDVD.FormattingEnabled = true;
			this.comboBoxDVD.Location = new System.Drawing.Point(76, 125);
			this.comboBoxDVD.Name = "comboBoxDVD";
			this.comboBoxDVD.Size = new System.Drawing.Size(197, 21);
			this.comboBoxDVD.TabIndex = 62;
			this.comboBoxDVD.Text = "Titulo de DVD";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(25, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 63;
			this.label1.Text = "Codigo:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(76, 66);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(117, 20);
			this.txtCodigo.TabIndex = 64;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Cedula,
			this.Nombre,
			this.Apellido,
			this.CodigoDVD,
			this.devolucion});
			this.dataGridView1.Location = new System.Drawing.Point(28, 306);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(863, 209);
			this.dataGridView1.TabIndex = 65;
			// 
			// Cedula
			// 
			this.Cedula.HeaderText = "Codigo";
			this.Cedula.Name = "Cedula";
			this.Cedula.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Titulo";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Tipo";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			// 
			// CodigoDVD
			// 
			this.CodigoDVD.HeaderText = "Dias en renta";
			this.CodigoDVD.Name = "CodigoDVD";
			this.CodigoDVD.ReadOnly = true;
			// 
			// devolucion
			// 
			this.devolucion.HeaderText = "Devolucion";
			this.devolucion.Name = "devolucion";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(49, 195);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(98, 19);
			this.btnAgregar.TabIndex = 66;
			this.btnAgregar.Text = "Agregar DVD";
			this.btnAgregar.UseVisualStyleBackColor = true;
			// 
			// btnQuitar
			// 
			this.btnQuitar.Location = new System.Drawing.Point(153, 195);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(98, 19);
			this.btnQuitar.TabIndex = 67;
			this.btnQuitar.Text = "Quitar DVD";
			this.btnQuitar.UseVisualStyleBackColor = true;
			// 
			// FormPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(926, 573);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxDVD);
			this.Controls.Add(this.comboBoxCedula);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Pmovement);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.lblMonto);
			this.Controls.Add(this.lblCantidadRenta);
			this.Controls.Add(this.lblPrecioDe);
			this.Controls.Add(this.labelInfPrestamo);
			this.Controls.Add(this.lblFechaRegist);
			this.Controls.Add(this.lblTelefInf);
			this.Controls.Add(this.lblTelefMvlInf);
			this.Controls.Add(this.lblCorreoInf);
			this.Controls.Add(this.lblDireccionInf);
			this.Controls.Add(this.lblFechaNacim);
			this.Controls.Add(this.lblApellidoInf);
			this.Controls.Add(this.lblNombreInf);
			this.Controls.Add(this.lblCedulaInf);
			this.Controls.Add(this.labelInfClient);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.CantidadDias);
			this.Controls.Add(this.labelDVD);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblCedula);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPrestamo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormPrestamo";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.Pmovement.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel Pmovement;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.ComboBox comboBoxCedula;
		private System.Windows.Forms.ComboBox comboBoxDVD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDVD;
		private System.Windows.Forms.DataGridViewTextBoxColumn devolucion;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnQuitar;
	}
}
