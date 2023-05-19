/*
 * Creado por SharpDevelop.
 * Usuario: angel
 * Fecha: 5/17/2023
 * Hora: 10:18 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoV2
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pMenu = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnReports = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pPrestamos = new System.Windows.Forms.Panel();
			this.btnreportesPrestamos = new System.Windows.Forms.Button();
			this.btnReportClientes = new System.Windows.Forms.Button();
			this.lblhora = new System.Windows.Forms.Label();
			this.lblfecha = new System.Windows.Forms.Label();
			this.pFunciones = new System.Windows.Forms.Panel();
			this.btn_regisPrestamos = new System.Windows.Forms.Button();
			this.btnregis_Clientes = new System.Windows.Forms.Button();
			this.btnDVD = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.pMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.pPrestamos.SuspendLayout();
			this.pFunciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pMenu
			// 
			this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.pMenu.Controls.Add(this.panel6);
			this.pMenu.Controls.Add(this.panel5);
			this.pMenu.Controls.Add(this.btnReports);
			this.pMenu.Controls.Add(this.btnMenu);
			this.pMenu.Controls.Add(this.btnInicio);
			this.pMenu.Controls.Add(this.btnSalir);
			this.pMenu.Controls.Add(this.pictureBox1);
			this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pMenu.Location = new System.Drawing.Point(0, 0);
			this.pMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pMenu.Name = "pMenu";
			this.pMenu.Size = new System.Drawing.Size(1083, 83);
			this.pMenu.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(717, 83);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(123, 123);
			this.panel6.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Location = new System.Drawing.Point(471, 83);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(132, 105);
			this.panel5.TabIndex = 0;
			// 
			// btnReports
			// 
			this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReports.FlatAppearance.BorderSize = 0;
			this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReports.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReports.ForeColor = System.Drawing.Color.White;
			this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
			this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReports.Location = new System.Drawing.Point(688, 10);
			this.btnReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(152, 69);
			this.btnReports.TabIndex = 4;
			this.btnReports.Text = "Reportes";
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnReports.MouseEnter += new System.EventHandler(this.btnmouseEnter);
			this.btnReports.MouseLeave += new System.EventHandler(this.btnmouseLeave);
			// 
			// btnMenu
			// 
			this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenu.FlatAppearance.BorderSize = 0;
			this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenu.ForeColor = System.Drawing.Color.White;
			this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
			this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMenu.Location = new System.Drawing.Point(471, 10);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(152, 69);
			this.btnMenu.TabIndex = 3;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.MouseEnter += new System.EventHandler(this.btnmouseEnter);
			this.btnMenu.MouseLeave += new System.EventHandler(this.btnmouseLeave);
			// 
			// btnInicio
			// 
			this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInicio.FlatAppearance.BorderSize = 0;
			this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.Color.White;
			this.btnInicio.Location = new System.Drawing.Point(281, 10);
			this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(152, 69);
			this.btnInicio.TabIndex = 2;
			this.btnInicio.Text = "INICIO";
			this.btnInicio.UseVisualStyleBackColor = true;
			this.btnInicio.MouseEnter += new System.EventHandler(this.btnmouseEnter);
			this.btnInicio.MouseLeave += new System.EventHandler(this.btnmouseLeave);
			// 
			// btnSalir
			// 
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(1043, 2);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(37, 33);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(266, 81);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 83);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(9, 475);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(1074, 83);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(9, 475);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(9, 550);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1065, 8);
			this.panel3.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel4.Controls.Add(this.panel10);
			this.panel4.Controls.Add(this.panel9);
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Controls.Add(this.pPrestamos);
			this.panel4.Controls.Add(this.lblhora);
			this.panel4.Controls.Add(this.lblfecha);
			this.panel4.Controls.Add(this.pFunciones);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(9, 83);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1065, 467);
			this.panel4.TabIndex = 4;
			// 
			// pPrestamos
			// 
			this.pPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.pPrestamos.Controls.Add(this.btnreportesPrestamos);
			this.pPrestamos.Controls.Add(this.btnReportClientes);
			this.pPrestamos.Location = new System.Drawing.Point(679, 0);
			this.pPrestamos.Name = "pPrestamos";
			this.pPrestamos.Size = new System.Drawing.Size(152, 105);
			this.pPrestamos.TabIndex = 4;
			this.pPrestamos.Visible = false;
			// 
			// btnreportesPrestamos
			// 
			this.btnreportesPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnreportesPrestamos.FlatAppearance.BorderSize = 0;
			this.btnreportesPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btnreportesPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnreportesPrestamos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnreportesPrestamos.ForeColor = System.Drawing.Color.White;
			this.btnreportesPrestamos.Location = new System.Drawing.Point(3, 57);
			this.btnreportesPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnreportesPrestamos.Name = "btnreportesPrestamos";
			this.btnreportesPrestamos.Size = new System.Drawing.Size(149, 47);
			this.btnreportesPrestamos.TabIndex = 5;
			this.btnreportesPrestamos.Text = "Prestamos";
			this.btnreportesPrestamos.UseVisualStyleBackColor = true;
			// 
			// btnReportClientes
			// 
			this.btnReportClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReportClientes.FlatAppearance.BorderSize = 0;
			this.btnReportClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btnReportClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReportClientes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportClientes.ForeColor = System.Drawing.Color.White;
			this.btnReportClientes.Location = new System.Drawing.Point(3, 6);
			this.btnReportClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReportClientes.Name = "btnReportClientes";
			this.btnReportClientes.Size = new System.Drawing.Size(149, 52);
			this.btnReportClientes.TabIndex = 4;
			this.btnReportClientes.Text = "Clientes";
			this.btnReportClientes.UseVisualStyleBackColor = true;
			// 
			// lblhora
			// 
			this.lblhora.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblhora.ForeColor = System.Drawing.Color.White;
			this.lblhora.Location = new System.Drawing.Point(769, 386);
			this.lblhora.Name = "lblhora";
			this.lblhora.Size = new System.Drawing.Size(291, 36);
			this.lblhora.TabIndex = 3;
			this.lblhora.Text = "label2";
			// 
			// lblfecha
			// 
			this.lblfecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfecha.ForeColor = System.Drawing.Color.White;
			this.lblfecha.Location = new System.Drawing.Point(769, 358);
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Size = new System.Drawing.Size(291, 48);
			this.lblfecha.TabIndex = 2;
			this.lblfecha.Text = "label1";
			// 
			// pFunciones
			// 
			this.pFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.pFunciones.Controls.Add(this.btn_regisPrestamos);
			this.pFunciones.Controls.Add(this.btnregis_Clientes);
			this.pFunciones.Controls.Add(this.btnDVD);
			this.pFunciones.Location = new System.Drawing.Point(462, 0);
			this.pFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pFunciones.Name = "pFunciones";
			this.pFunciones.Size = new System.Drawing.Size(152, 158);
			this.pFunciones.TabIndex = 0;
			this.pFunciones.Visible = false;
			// 
			// btn_regisPrestamos
			// 
			this.btn_regisPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_regisPrestamos.FlatAppearance.BorderSize = 0;
			this.btn_regisPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btn_regisPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_regisPrestamos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_regisPrestamos.ForeColor = System.Drawing.Color.White;
			this.btn_regisPrestamos.Location = new System.Drawing.Point(0, 109);
			this.btn_regisPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_regisPrestamos.Name = "btn_regisPrestamos";
			this.btn_regisPrestamos.Size = new System.Drawing.Size(149, 43);
			this.btn_regisPrestamos.TabIndex = 5;
			this.btn_regisPrestamos.Text = "Prestamos";
			this.btn_regisPrestamos.UseVisualStyleBackColor = true;
			// 
			// btnregis_Clientes
			// 
			this.btnregis_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnregis_Clientes.FlatAppearance.BorderSize = 0;
			this.btnregis_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btnregis_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnregis_Clientes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregis_Clientes.ForeColor = System.Drawing.Color.White;
			this.btnregis_Clientes.Location = new System.Drawing.Point(0, 57);
			this.btnregis_Clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnregis_Clientes.Name = "btnregis_Clientes";
			this.btnregis_Clientes.Size = new System.Drawing.Size(149, 47);
			this.btnregis_Clientes.TabIndex = 4;
			this.btnregis_Clientes.Text = "Clientes";
			this.btnregis_Clientes.UseVisualStyleBackColor = true;
			// 
			// btnDVD
			// 
			this.btnDVD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDVD.FlatAppearance.BorderSize = 0;
			this.btnDVD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btnDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDVD.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDVD.ForeColor = System.Drawing.Color.White;
			this.btnDVD.Location = new System.Drawing.Point(0, 5);
			this.btnDVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDVD.Name = "btnDVD";
			this.btnDVD.Size = new System.Drawing.Size(149, 52);
			this.btnDVD.TabIndex = 3;
			this.btnDVD.Text = "DVD";
			this.btnDVD.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(91, 62);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(872, 322);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1065, 3);
			this.panel7.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel8.Location = new System.Drawing.Point(0, 3);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(3, 464);
			this.panel8.TabIndex = 6;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Black;
			this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel9.Location = new System.Drawing.Point(3, 464);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(1062, 3);
			this.panel9.TabIndex = 7;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Black;
			this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel10.Location = new System.Drawing.Point(1062, 3);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(3, 461);
			this.panel10.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(1083, 558);
			this.ControlBox = false;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "boceto";
			this.pMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.pPrestamos.ResumeLayout(false);
			this.pFunciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Button btnReportClientes;
		private System.Windows.Forms.Button btnreportesPrestamos;
		private System.Windows.Forms.Panel pPrestamos;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblfecha;
		private System.Windows.Forms.Label lblhora;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btn_regisPrestamos;
		private System.Windows.Forms.Button btnDVD;
		private System.Windows.Forms.Button btnregis_Clientes;
		private System.Windows.Forms.Panel pFunciones;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnReports;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pMenu;
	}
}
