/*
 * Creado por SharpDevelop.
 * Usuario: Vladi1000
 * Fecha: 11/05/2023
 * Hora: 09:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV1
{
	partial class FormDVD
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbGedtionDVD;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblFabric;
		private System.Windows.Forms.DateTimePicker datePickerFabric;
		private System.Windows.Forms.GroupBox grupBoxTypeDVD;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label lblDescrip;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblCant;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.DateTimePicker datePickerIngres;
		private System.Windows.Forms.Label lblIngreso;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnRegist;
		private System.Windows.Forms.Button btnBuscarImg;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btnCerrar;
		
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
			this.lblCodigo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.grupBoxTypeDVD = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.lblDescrip = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblCant = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.lblFabric = new System.Windows.Forms.Label();
			this.datePickerFabric = new System.Windows.Forms.DateTimePicker();
			this.datePickerIngres = new System.Windows.Forms.DateTimePicker();
			this.lblIngreso = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnRegist = new System.Windows.Forms.Button();
			this.btnBuscarImg = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.grupBoxTypeDVD.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// lbGedtionDVD
			// 
			this.lbGedtionDVD.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGedtionDVD.Location = new System.Drawing.Point(12, 9);
			this.lbGedtionDVD.Name = "lbGedtionDVD";
			this.lbGedtionDVD.Size = new System.Drawing.Size(255, 23);
			this.lbGedtionDVD.TabIndex = 0;
			this.lbGedtionDVD.Text = "Gestion de DVD";
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(22, 44);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(58, 20);
			this.lblCodigo.TabIndex = 1;
			this.lblCodigo.Text = "Codigo: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(86, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(181, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(86, 70);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(181, 20);
			this.textBox2.TabIndex = 4;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(22, 70);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(58, 20);
			this.lblTitulo.TabIndex = 3;
			this.lblTitulo.Text = "Titulo: ";
			// 
			// grupBoxTypeDVD
			// 
			this.grupBoxTypeDVD.Controls.Add(this.radioButton3);
			this.grupBoxTypeDVD.Controls.Add(this.radioButton2);
			this.grupBoxTypeDVD.Controls.Add(this.radioButton1);
			this.grupBoxTypeDVD.Location = new System.Drawing.Point(22, 122);
			this.grupBoxTypeDVD.Name = "grupBoxTypeDVD";
			this.grupBoxTypeDVD.Size = new System.Drawing.Size(245, 96);
			this.grupBoxTypeDVD.TabIndex = 8;
			this.grupBoxTypeDVD.TabStop = false;
			this.grupBoxTypeDVD.Text = "Tipo de Contenido";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(38, 61);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(201, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Album Musical";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(38, 40);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(201, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Juego de Consola";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(38, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(201, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Pelicula en Blu-Ray";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// lblDescrip
			// 
			this.lblDescrip.Location = new System.Drawing.Point(22, 230);
			this.lblDescrip.Name = "lblDescrip";
			this.lblDescrip.Size = new System.Drawing.Size(69, 20);
			this.lblDescrip.TabIndex = 9;
			this.lblDescrip.Text = "Descripcion: ";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(22, 253);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(245, 96);
			this.richTextBox1.TabIndex = 10;
			this.richTextBox1.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(293, 79);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// lblCant
			// 
			this.lblCant.Location = new System.Drawing.Point(22, 360);
			this.lblCant.Name = "lblCant";
			this.lblCant.Size = new System.Drawing.Size(58, 20);
			this.lblCant.TabIndex = 12;
			this.lblCant.Text = "Cantidad: ";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(86, 358);
			this.numericUpDown.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(181, 20);
			this.numericUpDown.TabIndex = 14;
			// 
			// lblFabric
			// 
			this.lblFabric.Location = new System.Drawing.Point(22, 96);
			this.lblFabric.Name = "lblFabric";
			this.lblFabric.Size = new System.Drawing.Size(69, 20);
			this.lblFabric.TabIndex = 5;
			this.lblFabric.Text = "Fabricacion:";
			// 
			// datePickerFabric
			// 
			this.datePickerFabric.Location = new System.Drawing.Point(86, 96);
			this.datePickerFabric.Name = "datePickerFabric";
			this.datePickerFabric.Size = new System.Drawing.Size(181, 20);
			this.datePickerFabric.TabIndex = 7;
			// 
			// datePickerIngres
			// 
			this.datePickerIngres.Location = new System.Drawing.Point(86, 384);
			this.datePickerIngres.Name = "datePickerIngres";
			this.datePickerIngres.Size = new System.Drawing.Size(181, 20);
			this.datePickerIngres.TabIndex = 16;
			// 
			// lblIngreso
			// 
			this.lblIngreso.Location = new System.Drawing.Point(22, 384);
			this.lblIngreso.Name = "lblIngreso";
			this.lblIngreso.Size = new System.Drawing.Size(69, 20);
			this.lblIngreso.TabIndex = 15;
			this.lblIngreso.Text = "Ingreso:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(293, 44);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 17;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(293, 321);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 18;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(293, 350);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 19;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnRegist
			// 
			this.btnRegist.Location = new System.Drawing.Point(293, 379);
			this.btnRegist.Name = "btnRegist";
			this.btnRegist.Size = new System.Drawing.Size(75, 23);
			this.btnRegist.TabIndex = 20;
			this.btnRegist.Text = "Registrar";
			this.btnRegist.UseVisualStyleBackColor = true;
			// 
			// btnBuscarImg
			// 
			this.btnBuscarImg.Location = new System.Drawing.Point(293, 235);
			this.btnBuscarImg.Name = "btnBuscarImg";
			this.btnBuscarImg.Size = new System.Drawing.Size(95, 23);
			this.btnBuscarImg.TabIndex = 21;
			this.btnBuscarImg.Text = "Buscar Imagen";
			this.btnBuscarImg.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(293, 264);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(150, 20);
			this.textBox3.TabIndex = 22;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(378, 9);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 23;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// FormDVD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 421);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btnBuscarImg);
			this.Controls.Add(this.btnRegist);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.datePickerIngres);
			this.Controls.Add(this.lblIngreso);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.lblCant);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblDescrip);
			this.Controls.Add(this.grupBoxTypeDVD);
			this.Controls.Add(this.datePickerFabric);
			this.Controls.Add(this.lblFabric);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.lbGedtionDVD);
			this.Name = "FormDVD";
			this.Text = "FormDVD";
			this.grupBoxTypeDVD.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
