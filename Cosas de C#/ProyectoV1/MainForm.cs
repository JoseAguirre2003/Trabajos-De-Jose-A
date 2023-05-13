using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV1.Classes;

namespace ProyectoV1
{
	public partial class MainForm : Form
	{
		ColeccionDiscos coleccionDVD = new ColeccionDiscos();
		
		public MainForm()
		{
			InitializeComponent();
			btnGestionDVD.Click += new EventHandler(btnModuloDVD);
		}
		
		public void btnModuloDVD(object sender, EventArgs e){
			FormDVD formDVD = new FormDVD(coleccionDVD);
			formDVD.Show();
		}
	}
}