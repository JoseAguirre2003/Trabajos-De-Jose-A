using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	
	public partial class MainForm : Form
	{
		Panel p= new Panel();
		int posX=0;
		int posY=0;
		ColeccionDiscos coleccionDVD = new ColeccionDiscos();
		ColeccionClientes coleccionClient = new ColeccionClientes();
		ColeccionPrestamos coleccionPrestam = new ColeccionPrestamos();
		
		public MainForm()
		{
			InitializeComponent();
			btnMenu.Click += new EventHandler(btnMenu_Click);
			btnSalir.Click += new EventHandler(btnSalir_Click);
			pMenu.MouseMove += new MouseEventHandler(pMenu_MouseMove);
			timer1.Enabled=true;
			timer1.Tick += new EventHandler(timer1_Tick);
			btnDVD.Click += new EventHandler(btnDVD_Click);
			btnReports.Click += new EventHandler(btnReports_Click);
			btnregis_Clientes.Click += new EventHandler(btnregis_Clientes_Click);
			btn_regisPrestamos.Click += new EventHandler(btnPrestamo_Click);
			btnreportesPrestamos.Click += new EventHandler(btnreportesPrestamos_Click);
		}

		void btnDVD_Click(object sender, EventArgs e){
			FormDVD vent = new FormDVD(coleccionDVD);
			vent.Show();
		}
		
		void btnregis_Clientes_Click(object sender, EventArgs e){
			FormClient vent= new FormClient(coleccionClient);
			vent.Show();
		}
		
		void btnPrestamo_Click(object sender, EventArgs e){
			FormPrestamo vent = new FormPrestamo(coleccionDVD, coleccionClient, coleccionPrestam);
			vent.Show();
		}
		
		void btnreportesPrestamos_Click(object sender, EventArgs e){
			FormConsultaPrestamo vent = new FormConsultaPrestamo();
			vent.Show();
		}

		void btnReports_Click(object sender, EventArgs e){
			if(!pPrestamos.Visible)
				pPrestamos.Visible=true;
			else
				pPrestamos.Visible=false;
		}

		void timer1_Tick(object sender, EventArgs e){
			lblhora.Text= DateTime.Now.ToString("hh:mm:ss");
			lblfecha.Text= DateTime.Now.ToLongDateString();
		}

		void pMenu_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button != MouseButtons.Left)
			{
				posX= e.X;
				posY= e.Y;
			}else{
				Left= Left+(e.X-posX);
				Top= Top+(e.Y - posY);
			}
		}

		void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Seguro que quiere salir del programa?","Pregunta por salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(r == DialogResult.Yes)
				Application.Exit();
		}

		void btnMenu_Click(object sender, EventArgs e)
		{
			if(!pFunciones.Visible)
				pFunciones.Visible=true;
			else
				pFunciones.Visible=false;
		}
		private void btnmouseEnter(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			pMenu.Controls.Add(p);
			p.BackColor= Color.FromArgb(248, 241, 241);
			p.Size= new Size(114,8);
			p.Location= new Point(btn.Location.X,btn.Location.Y+53);
		}
		private void btnmouseLeave(object sender, EventArgs e)
		{
			pMenu.Controls.Remove(p);
		}
	}
}
