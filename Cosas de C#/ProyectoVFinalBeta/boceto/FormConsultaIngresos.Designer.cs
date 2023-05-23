/*
 * Creado por SharpDevelop.
 * Usuario: Vladi1000
 * Fecha: 20/05/2023
 * Hora: 12:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class FormConsultaIngresos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDVD;
		private System.Windows.Forms.Label lblConsulta;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblFiltrarFecha;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.Label lblMontoEs;
		private System.Windows.Forms.Label lblMonto;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaIngresos));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblConsulta = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblFiltrarFecha = new System.Windows.Forms.Label();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.lblMontoEs = new System.Windows.Forms.Label();
			this.lblMonto = new System.Windows.Forms.Label();
			this.Pmovement = new System.Windows.Forms.Panel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRestaurarPres = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Pmovement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Cedula,
			this.Nombre,
			this.Apellido,
			this.CodigoDVD});
			this.dataGridView1.Location = new System.Drawing.Point(12, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(734, 311);
			this.dataGridView1.TabIndex = 5;
			// 
			// Cedula
			// 
			this.Cedula.HeaderText = "Codigo";
			this.Cedula.Name = "Cedula";
			this.Cedula.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Tipo de Medio";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Apellido
			// 
			this.Apellido.HeaderText = "Dias de Renta";
			this.Apellido.Name = "Apellido";
			this.Apellido.ReadOnly = true;
			// 
			// CodigoDVD
			// 
			this.CodigoDVD.HeaderText = "Monto";
			this.CodigoDVD.Name = "CodigoDVD";
			this.CodigoDVD.ReadOnly = true;
			// 
			// lblConsulta
			// 
			this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsulta.Location = new System.Drawing.Point(0, 0);
			this.lblConsulta.Name = "lblConsulta";
			this.lblConsulta.Size = new System.Drawing.Size(352, 37);
			this.lblConsulta.TabIndex = 6;
			this.lblConsulta.Text = "Consulta de Pagos:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 69);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// lblFiltrarFecha
			// 
			this.lblFiltrarFecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltrarFecha.ForeColor = System.Drawing.Color.White;
			this.lblFiltrarFecha.Location = new System.Drawing.Point(10, 41);
			this.lblFiltrarFecha.Name = "lblFiltrarFecha";
			this.lblFiltrarFecha.Size = new System.Drawing.Size(130, 28);
			this.lblFiltrarFecha.TabIndex = 8;
			this.lblFiltrarFecha.Text = "Filtrar por fecha:";
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Location = new System.Drawing.Point(114, 69);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(76, 20);
			this.btnFiltrar.TabIndex = 9;
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseVisualStyleBackColor = true;
			// 
			// lblMontoEs
			// 
			this.lblMontoEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoEs.ForeColor = System.Drawing.Color.White;
			this.lblMontoEs.Location = new System.Drawing.Point(752, 95);
			this.lblMontoEs.Name = "lblMontoEs";
			this.lblMontoEs.Size = new System.Drawing.Size(154, 34);
			this.lblMontoEs.TabIndex = 10;
			this.lblMontoEs.Text = "Monto Total:";
			// 
			// lblMonto
			// 
			this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonto.ForeColor = System.Drawing.Color.White;
			this.lblMonto.Location = new System.Drawing.Point(761, 129);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(172, 27);
			this.lblMonto.TabIndex = 13;
			this.lblMonto.Text = "0$";
			// 
			// Pmovement
			// 
			this.Pmovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.Pmovement.Controls.Add(this.btnSalir);
			this.Pmovement.Controls.Add(this.lblConsulta);
			this.Pmovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.Pmovement.Location = new System.Drawing.Point(0, 0);
			this.Pmovement.Margin = new System.Windows.Forms.Padding(2);
			this.Pmovement.Name = "Pmovement";
			this.Pmovement.Size = new System.Drawing.Size(986, 37);
			this.Pmovement.TabIndex = 14;
			// 
			// btnSalir
			// 
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(956, 0);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(28, 27);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(984, 37);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(2, 394);
			this.panel1.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 429);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 2);
			this.panel2.TabIndex = 16;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 37);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(2, 392);
			this.panel3.TabIndex = 17;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(2, 37);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(982, 2);
			this.panel4.TabIndex = 18;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(752, 202);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(227, 190);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// btnRestaurarPres
			// 
			this.btnRestaurarPres.Location = new System.Drawing.Point(837, 55);
			this.btnRestaurarPres.Name = "btnRestaurarPres";
			this.btnRestaurarPres.Size = new System.Drawing.Size(119, 23);
			this.btnRestaurarPres.TabIndex = 76;
			this.btnRestaurarPres.Text = "Restaurar Prestamos";
			this.btnRestaurarPres.UseVisualStyleBackColor = true;
			// 
			// FormConsultaIngresos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(986, 431);
			this.Controls.Add(this.btnRestaurarPres);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Pmovement);
			this.Controls.Add(this.lblMonto);
			this.Controls.Add(this.lblMontoEs);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.lblFiltrarFecha);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormConsultaIngresos";
			this.Text = "FormConsultaIngresos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Pmovement.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel Pmovement;
		private System.Windows.Forms.Button btnRestaurarPres;
	}
}
