using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoV2
{
	public partial class FormConsultaIngresos : Form
	{
		int posY=0;
		int posX=0;
		public FormConsultaIngresos()
		{
			InitializeComponent();
			btnSalir.Click+= new EventHandler(btnSalir_Click);
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
