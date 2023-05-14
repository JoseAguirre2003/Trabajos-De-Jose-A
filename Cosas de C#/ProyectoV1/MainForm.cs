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
		ColeccionClientes coleccionClient = new ColeccionClientes();
		
		public MainForm()
		{
			InitializeComponent();
			btnGestionDVD.Click += new EventHandler(btnModuloDVDClick);
			btnModuloClientes.Click += new EventHandler(btnModuloClientesClick);
		}
		
		public void btnModuloDVDClick(object sender, EventArgs e){
			FormDVD formDVD = new FormDVD(coleccionDVD);
			formDVD.Show();
		}
		
		public void btnModuloClientesClick(object sender, EventArgs e){
			Form formClientes = new FormClient(coleccionClient);
			formClientes.Show();
		}
	}
}