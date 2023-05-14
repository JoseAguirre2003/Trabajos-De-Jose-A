using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV1.Classes;

namespace ProyectoV1
{
	public partial class FormClient : Form
	{
		ColeccionClientes coleccionClient;
		
		public FormClient(ColeccionClientes col)
		{
			InitializeComponent();
			btnRegist.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			btnReiniciar.Click += new EventHandler(btnLimpiarClick);
			coleccionClient = col; 
		}
		
		public void btnRegistrarClick(object sender, EventArgs e){
			if(true){
				String cedula = txtCedula.Text;
				String nombre = txtNombre.Text;
				String apellido = txtApellido.Text;
				DateTime fechaNacim = datePickerNacimiento.Value;
				String direccion = txtDireccion.Text;
				String correo = txtCorreo.Text;
				String numeroMovil = txtMovil.Text;
				String numeroCasa = txtTelefono.Text;
				DateTime fechaRegist = dateTimeRegistro.Value;
				coleccionClient.Agregar(cedula, nombre, apellido, fechaNacim, direccion, correo, numeroMovil, numeroCasa, fechaRegist);
				MessageBox.Show("Guardado con exito!");
				limpiar();
			}
		}
		
		public void btnBuscarClick(object sender, EventArgs e){
			//Falta validar
			Int16 pos = coleccionClient.Buscar(txtCedula.Text);
			Cliente client;
			if(pos > -1){
				client = coleccionClient._listaClientes[pos];
				txtNombre.Text = client.Nombres;
				txtApellido.Text = client.Apellido;
				datePickerNacimiento.Value = client.FechaNacim;
				txtDireccion.Text = client.Direccion;
				txtCorreo.Text = client.Correo;
				txtMovil.Text = client.NumeroMovil;
				txtTelefono.Text = client.NumeroCasa;
				dateTimeRegistro.Value = client.FechaRegist;
			}else
				MessageBox.Show("No se encontro :(");
		}
		
		public void btnActualizarClick(object sender, EventArgs e){
			
		}
		
		public void btnEliminarClick(object sender, EventArgs e){
		
		}
		
		public void btnLimpiarClick(object sender, EventArgs e){
			limpiar();
		}
		
		public void limpiar(){
			txtCedula.Text = "";
			txtNombre.Text = "";
			txtApellido.Text = "";
			datePickerNacimiento.Value = DateTime.Now;
			txtDireccion.Text = "";
			txtCorreo.Text = "";
			txtMovil.Text = "";
			txtTelefono.Text = "";
			dateTimeRegistro.Value = DateTime.Now;
		}
	}
}