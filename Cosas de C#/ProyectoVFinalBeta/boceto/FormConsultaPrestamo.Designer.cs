/*
 * Creado por SharpDevelop.
 * Usuario: Vladi1000
 * Fecha: 20/05/2023
 * Hora: 12:13 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class FormConsultaPrestamo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblConsulta;
		private System.Windows.Forms.Label lblFiltrarFecha;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDVD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TituloDVD;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiasRenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
		private System.Windows.Forms.Button btnMstrarGeneral;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPrestamo));
			this.lblConsulta = new System.Windows.Forms.Label();
			this.lblFiltrarFecha = new System.Windows.Forms.Label();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TituloDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiasRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnMstrarGeneral = new System.Windows.Forms.Button();
			this.Pmovement = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.comboBoxClientes = new System.Windows.Forms.ComboBox();
			this.btnRestaurarPres = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Pmovement.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblConsulta
			// 
			this.lblConsulta.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsulta.ForeColor = System.Drawing.Color.White;
			this.lblConsulta.Location = new System.Drawing.Point(3, 6);
			this.lblConsulta.Name = "lblConsulta";
			this.lblConsulta.Size = new System.Drawing.Size(352, 37);
			this.lblConsulta.TabIndex = 0;
			this.lblConsulta.Text = "Consulta de Prestamos:";
			// 
			// lblFiltrarFecha
			// 
			this.lblFiltrarFecha.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltrarFecha.ForeColor = System.Drawing.Color.White;
			this.lblFiltrarFecha.Location = new System.Drawing.Point(26, 63);
			this.lblFiltrarFecha.Name = "lblFiltrarFecha";
			this.lblFiltrarFecha.Size = new System.Drawing.Size(196, 34);
			this.lblFiltrarFecha.TabIndex = 2;
			this.lblFiltrarFecha.Text = "Filtrar por cliente:";
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Location = new System.Drawing.Point(210, 100);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(100, 23);
			this.btnFiltrar.TabIndex = 3;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
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
			this.TituloDVD,
			this.FechaInicial,
			this.DiasRenta,
			this.FechaDevolucion});
			this.dataGridView1.Location = new System.Drawing.Point(26, 132);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(911, 285);
			this.dataGridView1.TabIndex = 4;
			// 
			// Cedula
			// 
			this.Cedula.HeaderText = "Cedula";
			this.Cedula.Name = "Cedula";
			this.Cedula.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			// 
			// CodigoDVD
			// 
			this.CodigoDVD.HeaderText = "Codigo de DVD";
			this.CodigoDVD.Name = "CodigoDVD";
			this.CodigoDVD.ReadOnly = true;
			// 
			// TituloDVD
			// 
			this.TituloDVD.HeaderText = "Titulo de DVD";
			this.TituloDVD.Name = "TituloDVD";
			this.TituloDVD.ReadOnly = true;
			// 
			// FechaInicial
			// 
			this.FechaInicial.HeaderText = "Fecha Inicial";
			this.FechaInicial.Name = "FechaInicial";
			this.FechaInicial.ReadOnly = true;
			// 
			// DiasRenta
			// 
			this.DiasRenta.HeaderText = "Dias de Renta";
			this.DiasRenta.Name = "DiasRenta";
			this.DiasRenta.ReadOnly = true;
			// 
			// FechaDevolucion
			// 
			this.FechaDevolucion.HeaderText = "Fecha de Devolucion";
			this.FechaDevolucion.Name = "FechaDevolucion";
			this.FechaDevolucion.ReadOnly = true;
			// 
			// btnMstrarGeneral
			// 
			this.btnMstrarGeneral.Location = new System.Drawing.Point(837, 100);
			this.btnMstrarGeneral.Name = "btnMstrarGeneral";
			this.btnMstrarGeneral.Size = new System.Drawing.Size(100, 23);
			this.btnMstrarGeneral.TabIndex = 5;
			this.btnMstrarGeneral.Text = "Mostrar Todo";
			this.btnMstrarGeneral.UseVisualStyleBackColor = true;
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.Pmovement.Controls.Add(this.btnSalir);
			this.Pmovement.Controls.Add(this.lblConsulta);
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(962, 44);
			this.Pmovement.TabIndex = 7;
			// 
			// btnSalir
			// 
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(925, 2);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(28, 27);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 44);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(962, 6);
			this.panel2.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 50);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(2, 390);
			this.panel3.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(2, 438);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(960, 2);
			this.panel4.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(960, 50);
			this.panel5.Margin = new System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(2, 388);
			this.panel5.TabIndex = 11;
			// 
			// comboBoxClientes
			// 
			this.comboBoxClientes.FormattingEnabled = true;
			this.comboBoxClientes.Location = new System.Drawing.Point(26, 100);
			this.comboBoxClientes.Name = "comboBoxClientes";
			this.comboBoxClientes.Size = new System.Drawing.Size(178, 21);
			this.comboBoxClientes.TabIndex = 12;
			// 
			// btnRestaurarPres
			// 
			this.btnRestaurarPres.Location = new System.Drawing.Point(818, 55);
			this.btnRestaurarPres.Name = "btnRestaurarPres";
			this.btnRestaurarPres.Size = new System.Drawing.Size(119, 23);
			this.btnRestaurarPres.TabIndex = 75;
			this.btnRestaurarPres.Text = "Restaurar Prestamos";
			this.btnRestaurarPres.UseVisualStyleBackColor = true;
			// 
			// FormConsultaPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(962, 440);
			this.Controls.Add(this.btnRestaurarPres);
			this.Controls.Add(this.comboBoxClientes);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Pmovement);
			this.Controls.Add(this.btnMstrarGeneral);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.lblFiltrarFecha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormConsultaPrestamo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormConsultaPrestamo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Pmovement.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel Pmovement;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
		private System.Windows.Forms.ComboBox comboBoxClientes;
		private System.Windows.Forms.Button btnRestaurarPres;
	}
}
