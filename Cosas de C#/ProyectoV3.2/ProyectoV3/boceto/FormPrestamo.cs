using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	
	public partial class FormPrestamo : Form
	{
		int posX=0;
		int posY=0;
		ColeccionDiscos coleccionDVD;
		ColeccionClientes coleccionClient;
		ColeccionPrestamos coleccionPrestam;
		List<dvdEnPrestamo> listaDVDPrestamos;
		decimal costo = 0;
		decimal monto = 0;
		
		public FormPrestamo(ColeccionDiscos colDVD, ColeccionClientes colClient, ColeccionPrestamos colPres){
			InitializeComponent();
			coleccionDVD = colDVD;
			coleccionClient = colClient;
			coleccionPrestam = colPres;
			btnCerrar.Click += new EventHandler(btnSalir_Click);
			comboBoxCedula.SelectedIndexChanged += new EventHandler(elegirClienteChangeIndex);
			comboBoxDVD.SelectedIndexChanged += new EventHandler(elegirDVDChangeIndex);
			btnAgregar.Click += new EventHandler(agregarDVD);
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);

			foreach(Cliente client in coleccionClient._listaClientes){
				comboBoxCedula.Items.Add(client);
			}
			foreach(DVD dvd in coleccionDVD._coleccionDVD){
				comboBoxDVD.Items.Add(dvd);
			}
		}

		void Pmovement_MouseMove(object sender, MouseEventArgs e){
			if(e.Button != MouseButtons.Left){
				posX= e.X;
				posY= e.Y;
			}else{
				Left= Left+(e.X-posX);
				Top= Top+(e.Y - posY);
			}
		}

		void btnSalir_Click(object sender, EventArgs e){
			this.Close();
		}
		
		public void elegirClienteChangeIndex(object sender, EventArgs e){
			Cliente client = coleccionClient._listaClientes[comboBoxCedula.SelectedIndex];
			lblCedulaInf.Text = "Cedula:  " + client.Cedula;
			lblNombreInf.Text = "Nombre:  " + client.Nombres;
			lblApellidoInf.Text = "Apellido:  " + client.Apellido;
			lblFechaNacim.Text = "Fecha de Nacimiento:  " + client.FechaNacim.ToShortDateString();
			lblDireccionInf.Text = "Direccion:  " + client.Direccion;
			lblCorreoInf.Text = "Correo:  " + client.Correo;
			lblTelefMvlInf.Text = "Telefono Movil:  " + client.NumeroMovil;
			lblTelefInf.Text = "Telefono:  " + client.NumeroCasa;
			lblFechaNacim.Text = "Fecha de Registro:  " + client.FechaRegist.ToShortDateString();
		}
		
		public void elegirDVDChangeIndex(object sender, EventArgs e){
			String tipo = coleccionDVD._coleccionDVD[comboBoxDVD.SelectedIndex]._type;
			switch (tipo){
				case "BluRay":
					numericUpDown1.Minimum = 3;
					costo = 2m / 3m;
					break;
				case "Juego":
					numericUpDown1.Minimum = 4;
					costo = 2m / 4m;
					break;
				case "Album":
					numericUpDown1.Minimum = 7;
					costo = 2m / 7m;
					break;
			}
		}
		
		public void agregarDVD(object sender, EventArgs e){
			Int16 pos = (Int16)comboBoxDVD.SelectedIndex;
			if(pos > -1){
				monto += numericUpDown1.Value * costo;
				lblMonto.Text = "Monto Total:  " + (numericUpDown1.Value * costo).ToString() + "$";
			}
		}
		
		public void quitarDVD(object sender, EventArgs e){
			
		}
		
		public void registrarClick(object sender, EventArgs e){
			
		}
	}
}