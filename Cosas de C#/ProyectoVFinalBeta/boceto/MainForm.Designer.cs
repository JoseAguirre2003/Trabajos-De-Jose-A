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
			this.btnReportIngres = new System.Windows.Forms.Button();
			this.lbltusmuetos = new System.Windows.Forms.Label();
			this.lblhora = new System.Windows.Forms.Label();
			this.lblfecha = new System.Windows.Forms.Label();
			this.pFunciones = new System.Windows.Forms.Panel();
			this.btn_regisPrestamos = new System.Windows.Forms.Button();
			this.btnregis_Clientes = new System.Windows.Forms.Button();
			this.btnDVD = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			this.pMenu.Margin = new System.Windows.Forms.Padding(2);
			this.pMenu.Name = "pMenu";
			this.pMenu.Size = new System.Drawing.Size(812, 67);
			this.pMenu.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(538, 67);
			this.panel6.Margin = new System.Windows.Forms.Padding(2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(92, 100);
			this.panel6.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Location = new System.Drawing.Point(353, 67);
			this.panel5.Margin = new System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(100, 86);
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
			this.btnReports.Location = new System.Drawing.Point(516, 8);
			this.btnReports.Margin = new System.Windows.Forms.Padding(2);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(114, 56);
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
			this.btnMenu.Location = new System.Drawing.Point(353, 8);
			this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(114, 56);
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
			this.btnInicio.Location = new System.Drawing.Point(211, 8);
			this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(114, 56);
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
			this.btnSalir.Location = new System.Drawing.Point(782, 2);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(28, 27);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(2, 2);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 67);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(7, 386);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(805, 67);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(7, 386);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(7, 447);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(798, 6);
			this.panel3.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.panel4.Controls.Add(this.pPrestamos);
			this.panel4.Controls.Add(this.lbltusmuetos);
			this.panel4.Controls.Add(this.lblhora);
			this.panel4.Controls.Add(this.lblfecha);
			this.panel4.Controls.Add(this.pFunciones);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(7, 67);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(798, 380);
			this.panel4.TabIndex = 4;
			// 
			// pPrestamos
			// 
			this.pPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.pPrestamos.Controls.Add(this.btnreportesPrestamos);
			this.pPrestamos.Controls.Add(this.btnReportIngres);
			this.pPrestamos.Location = new System.Drawing.Point(509, 0);
			this.pPrestamos.Margin = new System.Windows.Forms.Padding(2);
			this.pPrestamos.Name = "pPrestamos";
			this.pPrestamos.Size = new System.Drawing.Size(114, 85);
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
			this.btnreportesPrestamos.Location = new System.Drawing.Point(2, 46);
			this.btnreportesPrestamos.Margin = new System.Windows.Forms.Padding(2);
			this.btnreportesPrestamos.Name = "btnreportesPrestamos";
			this.btnreportesPrestamos.Size = new System.Drawing.Size(112, 38);
			this.btnreportesPrestamos.TabIndex = 5;
			this.btnreportesPrestamos.Text = "Prestamos";
			this.btnreportesPrestamos.UseVisualStyleBackColor = true;
			// 
			// btnReportIngres
			// 
			this.btnReportIngres.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReportIngres.FlatAppearance.BorderSize = 0;
			this.btnReportIngres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(66)))));
			this.btnReportIngres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReportIngres.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportIngres.ForeColor = System.Drawing.Color.White;
			this.btnReportIngres.Location = new System.Drawing.Point(2, 5);
			this.btnReportIngres.Margin = new System.Windows.Forms.Padding(2);
			this.btnReportIngres.Name = "btnReportIngres";
			this.btnReportIngres.Size = new System.Drawing.Size(112, 42);
			this.btnReportIngres.TabIndex = 4;
			this.btnReportIngres.Text = "Ingresos";
			this.btnReportIngres.UseVisualStyleBackColor = true;
			// 
			// lbltusmuetos
			// 
			this.lbltusmuetos.Location = new System.Drawing.Point(0, 0);
			this.lbltusmuetos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbltusmuetos.Name = "lbltusmuetos";
			this.lbltusmuetos.Size = new System.Drawing.Size(67, 15);
			this.lbltusmuetos.TabIndex = 0;
			// 
			// lblhora
			// 
			this.lblhora.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblhora.ForeColor = System.Drawing.Color.White;
			this.lblhora.Location = new System.Drawing.Point(577, 314);
			this.lblhora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblhora.Name = "lblhora";
			this.lblhora.Size = new System.Drawing.Size(218, 29);
			this.lblhora.TabIndex = 3;
			this.lblhora.Text = "label2";
			// 
			// lblfecha
			// 
			this.lblfecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfecha.ForeColor = System.Drawing.Color.White;
			this.lblfecha.Location = new System.Drawing.Point(577, 291);
			this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Size = new System.Drawing.Size(218, 39);
			this.lblfecha.TabIndex = 2;
			this.lblfecha.Text = "label1";
			// 
			// pFunciones
			// 
			this.pFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			this.pFunciones.Controls.Add(this.btn_regisPrestamos);
			this.pFunciones.Controls.Add(this.btnregis_Clientes);
			this.pFunciones.Controls.Add(this.btnDVD);
			this.pFunciones.Location = new System.Drawing.Point(346, 0);
			this.pFunciones.Margin = new System.Windows.Forms.Padding(2);
			this.pFunciones.Name = "pFunciones";
			this.pFunciones.Size = new System.Drawing.Size(114, 128);
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
			this.btn_regisPrestamos.Location = new System.Drawing.Point(0, 89);
			this.btn_regisPrestamos.Margin = new System.Windows.Forms.Padding(2);
			this.btn_regisPrestamos.Name = "btn_regisPrestamos";
			this.btn_regisPrestamos.Size = new System.Drawing.Size(112, 35);
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
			this.btnregis_Clientes.Location = new System.Drawing.Point(0, 46);
			this.btnregis_Clientes.Margin = new System.Windows.Forms.Padding(2);
			this.btnregis_Clientes.Name = "btnregis_Clientes";
			this.btnregis_Clientes.Size = new System.Drawing.Size(112, 38);
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
			this.btnDVD.Location = new System.Drawing.Point(0, 4);
			this.btnDVD.Margin = new System.Windows.Forms.Padding(2);
			this.btnDVD.Name = "btnDVD";
			this.btnDVD.Size = new System.Drawing.Size(112, 42);
			this.btnDVD.TabIndex = 3;
			this.btnDVD.Text = "DVD";
			this.btnDVD.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(68, 50);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(654, 262);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(812, 453);
			this.ControlBox = false;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
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
		private System.Windows.Forms.Button btnReportIngres;
		private System.Windows.Forms.Button btnreportesPrestamos;
		private System.Windows.Forms.Panel pPrestamos;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lbltusmuetos;
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
