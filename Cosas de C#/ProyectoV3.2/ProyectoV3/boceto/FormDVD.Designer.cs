/*
 * Creado por SharpDevelop.
 * Usuario: angel
 * Fecha: 5/17/2023
 * Hora: 2:10 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class FormDVD
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
			this.lbGedtionDVD = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblFabric = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.datePickerFabric = new System.Windows.Forms.DateTimePicker();
			this.grupBoxTypeDVD = new System.Windows.Forms.GroupBox();
			this.pictureboxOPC = new System.Windows.Forms.PictureBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDescrip = new System.Windows.Forms.Label();
			this.richTxtDescrip = new System.Windows.Forms.RichTextBox();
			this.btnBuscarImg = new System.Windows.Forms.Button();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.lblCant = new System.Windows.Forms.Label();
			this.numericUpCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblIngreso = new System.Windows.Forms.Label();
			this.datePickerIngres = new System.Windows.Forms.DateTimePicker();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegist = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.Pmovement = new System.Windows.Forms.Panel();
			this.errorProviderCode = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderTitulo = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderFechaF = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderRadioBt = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderDescrip = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderCantidad = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderFechaI = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderRuta = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnRecuperar = new System.Windows.Forms.Button();
			this.grupBoxTypeDVD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureboxOPC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTitulo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRadioBt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDescrip)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRuta)).BeginInit();
			this.SuspendLayout();
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.lbGedtionDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbGedtionDVD.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(9, 6);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(255, 23);
			this.lbGedtionDVD.TabIndex = 1;
			this.lbGedtionDVD.Text = "Gestion de DVD";
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.Color.White;
			this.lblCodigo.Location = new System.Drawing.Point(22, 44);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(58, 20);
			this.lblCodigo.TabIndex = 2;
			this.lblCodigo.Text = "Codigo: ";
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Location = new System.Drawing.Point(86, 44);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(181, 20);
			this.txtCode.TabIndex = 3;
			// 
			// lblTitulo
			// 
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(22, 70);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(58, 20);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "Titulo: ";
			// 
			// lblFabric
			// 
			this.lblFabric.ForeColor = System.Drawing.Color.White;
			this.lblFabric.Location = new System.Drawing.Point(22, 96);
			this.lblFabric.Name = "lblFabric";
			this.lblFabric.Size = new System.Drawing.Size(69, 20);
			this.lblFabric.TabIndex = 6;
			this.lblFabric.Text = "Fabricacion:";
			// 
			// txtTitle
			// 
			this.txtTitle.BackColor = System.Drawing.Color.White;
			this.txtTitle.Location = new System.Drawing.Point(86, 70);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(181, 20);
			this.txtTitle.TabIndex = 7;
			// 
			// datePickerFabric
			// 
			this.datePickerFabric.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
			this.datePickerFabric.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerFabric.Location = new System.Drawing.Point(86, 96);
			this.datePickerFabric.Name = "datePickerFabric";
			this.datePickerFabric.Size = new System.Drawing.Size(181, 20);
			this.datePickerFabric.TabIndex = 8;
			// 
			// grupBoxTypeDVD
			// 
			this.grupBoxTypeDVD.Controls.Add(this.pictureboxOPC);
			this.grupBoxTypeDVD.Controls.Add(this.radioButton3);
			this.grupBoxTypeDVD.Controls.Add(this.radioButton2);
			this.grupBoxTypeDVD.Controls.Add(this.radioButton1);
			this.grupBoxTypeDVD.ForeColor = System.Drawing.Color.White;
			this.grupBoxTypeDVD.Location = new System.Drawing.Point(22, 122);
			this.grupBoxTypeDVD.Name = "grupBoxTypeDVD";
			this.grupBoxTypeDVD.Size = new System.Drawing.Size(245, 96);
			this.grupBoxTypeDVD.TabIndex = 9;
			this.grupBoxTypeDVD.TabStop = false;
			this.grupBoxTypeDVD.Text = "Tipo de Contenido";
			// 
			// pictureboxOPC
			// 
			this.pictureboxOPC.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pictureboxOPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureboxOPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureboxOPC.Location = new System.Drawing.Point(160, 11);
			this.pictureboxOPC.Margin = new System.Windows.Forms.Padding(2);
			this.pictureboxOPC.Name = "pictureboxOPC";
			this.pictureboxOPC.Size = new System.Drawing.Size(82, 81);
			this.pictureboxOPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureboxOPC.TabIndex = 3;
			this.pictureboxOPC.TabStop = false;
			// 
			// radioButton3
			// 
			this.radioButton3.ForeColor = System.Drawing.Color.White;
			this.radioButton3.Location = new System.Drawing.Point(5, 66);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(122, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Album Musical";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.ForeColor = System.Drawing.Color.White;
			this.radioButton2.Location = new System.Drawing.Point(5, 43);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(122, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Juego de Consola";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.ForeColor = System.Drawing.Color.White;
			this.radioButton1.Location = new System.Drawing.Point(5, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(122, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Pelicula en Blu-Ray";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(293, 44);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 18;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(293, 80);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// lblDescrip
			// 
			this.lblDescrip.ForeColor = System.Drawing.Color.White;
			this.lblDescrip.Location = new System.Drawing.Point(22, 230);
			this.lblDescrip.Name = "lblDescrip";
			this.lblDescrip.Size = new System.Drawing.Size(69, 20);
			this.lblDescrip.TabIndex = 20;
			this.lblDescrip.Text = "Descripcion: ";
			// 
			// richTxtDescrip
			// 
			this.richTxtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTxtDescrip.Location = new System.Drawing.Point(17, 249);
			this.richTxtDescrip.Name = "richTxtDescrip";
			this.richTxtDescrip.Size = new System.Drawing.Size(246, 97);
			this.richTxtDescrip.TabIndex = 21;
			this.richTxtDescrip.Text = "";
			// 
			// btnBuscarImg
			// 
			this.btnBuscarImg.Location = new System.Drawing.Point(293, 236);
			this.btnBuscarImg.Name = "btnBuscarImg";
			this.btnBuscarImg.Size = new System.Drawing.Size(94, 23);
			this.btnBuscarImg.TabIndex = 22;
			this.btnBuscarImg.Text = "Buscar Imagen";
			this.btnBuscarImg.UseVisualStyleBackColor = true;
			// 
			// txtRuta
			// 
			this.txtRuta.BackColor = System.Drawing.Color.White;
			this.txtRuta.Location = new System.Drawing.Point(293, 264);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(150, 20);
			this.txtRuta.TabIndex = 23;
			// 
			// lblCant
			// 
			this.lblCant.ForeColor = System.Drawing.Color.White;
			this.lblCant.Location = new System.Drawing.Point(22, 360);
			this.lblCant.Name = "lblCant";
			this.lblCant.Size = new System.Drawing.Size(58, 20);
			this.lblCant.TabIndex = 24;
			this.lblCant.Text = "Cantidad: ";
			// 
			// numericUpCantidad
			// 
			this.numericUpCantidad.BackColor = System.Drawing.Color.White;
			this.numericUpCantidad.Location = new System.Drawing.Point(86, 358);
			this.numericUpCantidad.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.numericUpCantidad.Name = "numericUpCantidad";
			this.numericUpCantidad.Size = new System.Drawing.Size(182, 20);
			this.numericUpCantidad.TabIndex = 25;
			// 
			// lblIngreso
			// 
			this.lblIngreso.ForeColor = System.Drawing.Color.White;
			this.lblIngreso.Location = new System.Drawing.Point(22, 384);
			this.lblIngreso.Name = "lblIngreso";
			this.lblIngreso.Size = new System.Drawing.Size(69, 20);
			this.lblIngreso.TabIndex = 26;
			this.lblIngreso.Text = "Ingreso:";
			// 
			// datePickerIngres
			// 
			this.datePickerIngres.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerIngres.Location = new System.Drawing.Point(86, 384);
			this.datePickerIngres.Name = "datePickerIngres";
			this.datePickerIngres.Size = new System.Drawing.Size(181, 20);
			this.datePickerIngres.TabIndex = 27;
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(22, 414);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
			this.btnReiniciar.TabIndex = 28;
			this.btnReiniciar.Text = "Reiniciar";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(293, 321);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 29;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(293, 349);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 30;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnRegist
			// 
			this.btnRegist.Location = new System.Drawing.Point(293, 379);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(75, 23);
			this.btnRegist.TabIndex = 31;
			this.btnRegist.Text = "Registrar";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(378, 414);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 32;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(465, 28);
			this.Pmovement.TabIndex = 33;
			// 
			// errorProviderCode
			// 
			this.errorProviderCode.ContainerControl = this;
			// 
			// errorProviderTitulo
			// 
			this.errorProviderTitulo.ContainerControl = this;
			// 
			// errorProviderFechaF
			// 
			this.errorProviderFechaF.ContainerControl = this;
			// 
			// errorProviderRadioBt
			// 
			this.errorProviderRadioBt.ContainerControl = this;
			// 
			// errorProviderDescrip
			// 
			this.errorProviderDescrip.ContainerControl = this;
			// 
			// errorProviderCantidad
			// 
			this.errorProviderCantidad.ContainerControl = this;
			// 
			// errorProviderFechaI
			// 
			this.errorProviderFechaI.ContainerControl = this;
			// 
			// errorProviderRuta
			// 
			this.errorProviderRuta.ContainerControl = this;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(378, 321);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 34;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnRecuperar
			// 
			this.btnRecuperar.Location = new System.Drawing.Point(378, 349);
			this.btnRecuperar.Name = "btnRecuperar";
			this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
			this.btnRecuperar.TabIndex = 35;
			this.btnRecuperar.Text = "Restaurar";
			this.btnRecuperar.UseVisualStyleBackColor = true;
			// 
			// FormDVD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(465, 449);
			this.Controls.Add(this.btnRecuperar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnRegist);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.datePickerIngres);
			this.Controls.Add(this.lblIngreso);
			this.Controls.Add(this.numericUpCantidad);
			this.Controls.Add(this.lblCant);
			this.Controls.Add(this.txtRuta);
			this.Controls.Add(this.btnBuscarImg);
			this.Controls.Add(this.richTxtDescrip);
			this.Controls.Add(this.lblDescrip);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.grupBoxTypeDVD);
			this.Controls.Add(this.datePickerFabric);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.lblFabric);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.lbGedtionDVD);
			this.Controls.Add(this.Pmovement);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormDVD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.grupBoxTypeDVD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureboxOPC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTitulo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRadioBt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDescrip)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRuta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureboxOPC;
		private System.Windows.Forms.Panel Pmovement;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnRegist;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.DateTimePicker datePickerIngres;
		private System.Windows.Forms.Label lblIngreso;
		private System.Windows.Forms.NumericUpDown numericUpCantidad;
		private System.Windows.Forms.Label lblCant;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Button btnBuscarImg;
		private System.Windows.Forms.RichTextBox richTxtDescrip;
		private System.Windows.Forms.Label lblDescrip;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox grupBoxTypeDVD;
		private System.Windows.Forms.DateTimePicker datePickerFabric;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label lblFabric;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lbGedtionDVD;
		private System.Windows.Forms.ErrorProvider errorProviderCode;
		private System.Windows.Forms.ErrorProvider errorProviderTitulo;
		private System.Windows.Forms.ErrorProvider errorProviderFechaF;
		private System.Windows.Forms.ErrorProvider errorProviderRadioBt;
		private System.Windows.Forms.ErrorProvider errorProviderDescrip;
		private System.Windows.Forms.ErrorProvider errorProviderCantidad;
		private System.Windows.Forms.ErrorProvider errorProviderFechaI;
		private System.Windows.Forms.ErrorProvider errorProviderRuta;
		private System.Windows.Forms.Button btnRecuperar;
		private System.Windows.Forms.Button btnGuardar;
	}
}
