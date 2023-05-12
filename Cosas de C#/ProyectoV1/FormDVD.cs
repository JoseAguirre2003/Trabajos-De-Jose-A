using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV1.Classes;

namespace ProyectoV1
{
	public partial class FormDVD : Form
	{
		ColeccionDiscos colecDVD;
		public FormDVD(ColeccionDiscos col)
		{
			InitializeComponent();
			colecDVD = col;
		}
	}
}