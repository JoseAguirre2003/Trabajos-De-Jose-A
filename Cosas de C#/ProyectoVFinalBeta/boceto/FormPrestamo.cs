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
		List<dvdEnPrestamo> listaDVDPrestamos = new List<dvdEnPrestamo>();
		float costo = 0;
		float monto = 0;
		
		public FormPrestamo(ColeccionDiscos colDVD, ColeccionClientes colClient, ColeccionPrestamos colPres){
			InitializeComponent();
			coleccionDVD = colDVD;
			coleccionClient = colClient;
			coleccionPrestam = colPres;
			btnCerrar.Click += new EventHandler(btnSalir_Click);
			comboBoxCedula.SelectedIndexChanged += new EventHandler(elegirClienteChangeIndex);
			comboBoxDVD.SelectedIndexChanged += new EventHandler(elegirDVDChangeIndex);
			btnAgregar.Click += new EventHandler(agregarDVD);
			btnQuitar.Click += new EventHandler(quitarDVD);
			btnRegistrar.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			btnGuardar.Click += new EventHandler(guardar);
			btnRecuperar.Click += new EventHandler(recuperar);
			btnRestaurarClient.Click += new EventHandler(restaurarClient);
			btnRestaurarDVD.Click += new EventHandler(restaurarDVD);
			
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
			if(comboBoxCedula.SelectedIndex > -1){
				dataGridView1.Rows.Clear();
				listaDVDPrestamos.Clear();
				monto = 0;
				lblMonto.Text = "Monto Total:  0$";
				Cliente client = coleccionClient._listaClientes[comboBoxCedula.SelectedIndex];
				lblCedulaInf.Text = "Cedula:  " + client.Cedula;
				lblNombreInf.Text = "Nombre:  " + client.Nombres;
				lblApellidoInf.Text = "Apellido:  " + client.Apellido;
				lblFechaNacim.Text = "Fecha de Nacimiento:  " + client.FechaNacim.ToShortDateString();
				lblDireccionInf.Text = "Direccion:  " + client.Direccion;
				lblCorreoInf.Text = "Correo:  " + client.Correo;
				lblTelefMvlInf.Text = "Telefono Movil:  " + client.NumeroMovil;
				lblTelefInf.Text = "Telefono:  " + client.NumeroCasa;
				lblFechaRegist.Text = "Fecha de Registro:  " + client.FechaRegist.ToShortDateString();
				dataGridView1.Rows.Clear();
				listaDVDPrestamos.Clear();
				btnQuitar.Enabled = true;
			}
		}
		
		public void elegirDVDChangeIndex(object sender, EventArgs e){
			if(comboBoxDVD.SelectedIndex > -1){
				String tipo = coleccionDVD._coleccionDVD[comboBoxDVD.SelectedIndex]._type;
				switch (tipo){
					case "BluRay":
						numericUpDown1.Minimum = 3;
						costo = 2f / 3f;
						break;
					case "Juego":
						numericUpDown1.Minimum = 4;
						costo = 2f / 4f;
						break;
					case "Album":
						numericUpDown1.Minimum = 7;
						costo = 2f / 7f;
						break;
				}
			}
		}
		
		public void agregarDVD(object sender, EventArgs e){
			Int16 pos = (Int16)comboBoxDVD.SelectedIndex;
			dvdEnPrestamo dvdPrest = new dvdEnPrestamo();
			if(pos > -1){
				monto += (float)numericUpDown1.Value * costo;
				lblMonto.Text = "Monto Total:  " + Math.Round(monto).ToString() + "$";
				dvdPrest._codigo = coleccionDVD._coleccionDVD[comboBoxDVD.SelectedIndex]._code;
				dvdPrest._titulo = coleccionDVD._coleccionDVD[comboBoxDVD.SelectedIndex]._title;
				dvdPrest._tipo = coleccionDVD._coleccionDVD[comboBoxDVD.SelectedIndex]._type;
				dvdPrest._diasEnRenta = (Int16)numericUpDown1.Value;
				dvdPrest._monto = dvdPrest._diasEnRenta * establecerCosto(dvdPrest._tipo);
				listaDVDPrestamos.Add(dvdPrest);
				dataGridView1.Rows.Add(dvdPrest._codigo, dvdPrest._titulo, dvdPrest._tipo, dvdPrest._diasEnRenta.ToString(), Math.Round(dvdPrest._monto).ToString() + "$", "No establecido aun");
			}
		}
		
		public float establecerCosto(String tipo){
			switch (tipo){
				case "BluRay":
					return 2f / 3f;
				case "Juego":
					return 2f / 4f;
				case "Album":
					return 2f / 7f;
				default:
					return 0f;
			}
		}

		public void quitarDVD(object sender, EventArgs e){
			int fila = dataGridView1.CurrentCell.RowIndex;
			if(fila > -1){
				dataGridView1.Rows.RemoveAt(fila);
				monto -= listaDVDPrestamos[fila]._monto;
				lblMonto.Text = "Monto Total:  " + Math.Round(monto).ToString() + "$";
				listaDVDPrestamos.RemoveAt(fila);
				MessageBox.Show("DVD Removido");
			}else
				MessageBox.Show("No se ha seleccionado ninguna fila");
		}

		public void btnRegistrarClick(object sender, EventArgs e){
			//Falta validar!
			if(validar()){
				String codigo = txtCodigo.Text;
				Cliente client = coleccionClient._listaClientes[comboBoxCedula.SelectedIndex];
				DateTime fechaRegist = new DateTime(dateTimeRegistro.Value.Year, dateTimeRegistro.Value.Month, dateTimeRegistro.Value.Day);
				List<dvdEnPrestamo> liDVD = new List<dvdEnPrestamo>();
				foreach (dvdEnPrestamo dvd in listaDVDPrestamos){
					dvd._devolucion = fechaRegist.AddDays(dvd._diasEnRenta);
					liDVD.Add(dvd);
				}
				coleccionPrestam.Agregar(codigo, client, liDVD, fechaRegist, monto);
				monto = 0;
				MessageBox.Show("Registrado!");
				limpiar();
			}else{
				MessageBox.Show("Datos errados");
			}
		}

		public void btnBuscarClick(object sender, EventArgs e){
			//Falta validar
			if(txtCodigo.Text.Trim() != ""){
				Int16 pos = coleccionPrestam.Buscar(txtCodigo.Text);
				Prestamo pres;
				if(pos > -1){
					dataGridView1.Rows.Clear();
					listaDVDPrestamos.Clear();
					pres = coleccionPrestam._prestamosRegistrados[pos];
					lblCedulaInf.Text = "Cedula:  " + pres._cliente.Cedula;
					lblNombreInf.Text = "Nombre:  " + pres._cliente.Nombres;
					lblApellidoInf.Text = "Apellido:  " + pres._cliente.Apellido;
					lblFechaNacim.Text = "Fecha de Nacimiento:  " + pres._cliente.FechaNacim.ToShortDateString();
					lblDireccionInf.Text = "Direccion:  " + pres._cliente.Direccion;
					lblCorreoInf.Text = "Correo:  " + pres._cliente.Correo;
					lblTelefMvlInf.Text = "Telefono Movil:  " + pres._cliente.NumeroMovil;
					lblTelefInf.Text = "Telefono:  " + pres._cliente.NumeroCasa;
					lblFechaRegist.Text = "Fecha de Registro:  " + pres._cliente.FechaRegist.ToShortDateString();
					comboBoxCedula.SelectedIndex = coleccionClient.Buscar(pres._cliente.Cedula);
					lblMonto.Text = "Monto Total:  " + Math.Round(pres._monto).ToString() + "$";
					foreach(dvdEnPrestamo dvd in pres._articulos){
						dataGridView1.Rows.Add(dvd._codigo, dvd._titulo, dvd._tipo, dvd._diasEnRenta, Math.Round(dvd._monto).ToString() + "$", dvd._devolucion.ToShortDateString());
						listaDVDPrestamos.Add(dvd);
					}
					btnQuitar.Enabled = false;
				}else
					MessageBox.Show("No se pudo encontrar el prestamo que busca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
				
		}
		
		public void limpiar(){
			txtCodigo.Text = "";
			comboBoxCedula.Text = "Cedula";
			comboBoxCedula.SelectedIndex = -1;
			comboBoxDVD.Text = "Titulo del DVD";
			comboBoxDVD.SelectedIndex = -1;
			dateTimeRegistro.Value = DateTime.Now;
			dataGridView1.Rows.Clear();
			listaDVDPrestamos.Clear();
			lblCedulaInf.Text = "Cedula:  ";
			lblNombreInf.Text = "Nombre:  ";
			lblApellidoInf.Text = "Apellido:  ";
			lblFechaNacim.Text = "Fecha de Nacimiento:  ";
			lblDireccionInf.Text = "Direccion:  ";
			lblCorreoInf.Text = "Correo:  ";
			lblTelefMvlInf.Text = "Telefono Movil:  ";
			lblTelefInf.Text = "Telefono:  ";
			lblFechaRegist.Text = "Fecha de Registro:  ";
			lblMonto.Text = "Monto Total:  0$";
			monto = 0;
		}
		
		public void reiniciar(object sender, EventArgs e){
			limpiar();
		}
		
		public void guardar(object sender, EventArgs e){
			coleccionPrestam.guardar();
			MessageBox.Show("Datos guardados!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		public void recuperar(object sender, EventArgs e){
			if(coleccionPrestam.recuperar()){
				MessageBox.Show("Recuperado!", "Recuperar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else
				MessageBox.Show("No existe el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public bool validar(){
			bool valido = true;
			
			if(!Validacion.validarTxtVacio(txtCodigo.Text)){
				valido = false;
				errorProviderCodigo.SetError(txtCodigo, "Campo vacio");
			}else if(coleccionPrestam.Buscar(txtCodigo.Text) > -1){
				valido = false;
				errorProviderCodigo.SetError(txtCodigo, "El codigo ya esta usado");
			}else
				errorProviderCodigo.Clear();
			
			if(comboBoxDVD.SelectedIndex < 0){
				valido = false;
				errorProviderDVD.SetError(comboBoxDVD, "No se ha seleccionado nada");
			}else
				errorProviderDVD.Clear();
			
			if(comboBoxCedula.SelectedIndex < 0){
				valido = false;
				errorProviderCliente.SetError(comboBoxCedula, "No se ha seleccionado nada");
			}else
				errorProviderCliente.Clear();
			
			if(!Validacion.validarFechaFutura(dateTimeRegistro.Value)){
				valido = false;
				errorProviderFecha.SetError(dateTimeRegistro, "Fecha es futura");
			}else
				errorProviderFecha.Clear();
				
			return valido;
		}
		
		public void restaurarDVD(object sender, EventArgs e){
			if(coleccionDVD.recuperar()){
				foreach(DVD dvd in coleccionDVD._coleccionDVD){
					comboBoxDVD.Items.Add(dvd);
				}
				MessageBox.Show("DVD Recuperados!", "Recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else
				MessageBox.Show("No existe el archivo de DVD, vaya al modulo de DVD y registre DVDs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public void restaurarClient(object sender, EventArgs e){
			if(coleccionClient.recuperar()){
				foreach(Cliente client in coleccionClient._listaClientes){
					comboBoxCedula.Items.Add(client);
				}
				MessageBox.Show("Clientes Recuperados!", "Recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else
				MessageBox.Show("No existe el archivo de Clientes, vaya al modulo de Clientes y registre Clientes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}