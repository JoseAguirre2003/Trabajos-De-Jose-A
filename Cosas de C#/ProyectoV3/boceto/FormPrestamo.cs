using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	
	public partial class FormPrestamo : Form
	{
		int posX=0;
		int posY=0;
		ColeccionDiscos coleccionDVD;
		ColeccionClientes coleccionClient;
		ColeccionPrestamo coleccionPrestam;
		
		public FormPrestamo(ColeccionDiscos colDVD, ColeccionClientes colClient, ColeccionPrestamo colPres)
		{
			InitializeComponent();
			coleccionDVD = colDVD;
			coleccionClient = colClient;
			coleccionPrestam = colPres;
			btnSalir.Click += new EventHandler(btnSalir_Click);
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);
		}

		void Pmovement_MouseMove(object sender, MouseEventArgs e)
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
			this.Close();
		}
	}
}
