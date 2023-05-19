using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	public partial class FormClient : Form
	{
		int posY=0;
		int posX=0;
		ColeccionClientes coleccionClient;
		
		public FormClient(ColeccionClientes col)
		{
			InitializeComponent();
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);
			btnCerrar.Click += new EventHandler(btnCerrar_Click);
			btnRegist.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			btnActualizar.Click += new EventHandler(btnActualizarClick);
			btnEliminar.Click += new EventHandler(btnEliminarClick);
			btnReiniciar.Click += new EventHandler(btnLimpiarClick);
			coleccionClient = col; 
		}

		void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Dispose();
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
		
		public void btnRegistrarClick(object sender, EventArgs e){
			//Falta validar!!
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
				MessageBox.Show("No se encontro el cliente :(");
		}
		
		public void btnActualizarClick(object sender, EventArgs e){
			//
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
				coleccionClient.Actualizar(cedula, nombre, apellido, fechaNacim, direccion, correo, numeroMovil, numeroCasa, fechaRegist);
				MessageBox.Show("Actualizado con exito! :)");
				limpiar();
			}	
		}
		
		public void btnEliminarClick(object sender, EventArgs e){
			String cedula = txtCedula.Text;
			if(coleccionClient.Eliminar(cedula)){
				MessageBox.Show("Eliminado!");
				limpiar();
			}else
				MessageBox.Show("No se pudo encontrar para su eliminacion");
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
