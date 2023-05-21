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
			btnGuardar.Click +=  new EventHandler(btnGuardarClick);
			btnRecuperar.Click += new EventHandler(btnRecuperarClick);
			coleccionClient = col;
			dateTimeRegistro.Value = DateTime.Now.AddYears(-16);
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
			if(validar(true)){
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
				MessageBox.Show("Registrado con exito!");
				limpiar();
			}else
				MessageBox.Show("Datos errados");
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
			if(validar(false)){
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
			dateTimeRegistro.Value = DateTime.Now.AddYears(-16);
		}
		
		public bool validar(bool registrando){
			bool valido = true;
			
			//Validar Cedula
			if(!Validacion.validarTxtVacio(txtCedula.Text)){
				valido = false;
				errorProviderCedula.SetError(txtCedula, "El Campo esta vacio");
			}else if(!Validacion.valicarSoloNum(txtCedula.Text)){
				valido = false;
				errorProviderCedula.SetError(txtCedula, "Solo se admiten numeros");
			}else if(registrando && coleccionClient.Buscar(txtCedula.Text) > -1){
				valido = false;
				errorProviderCedula.SetError(txtCedula, "Ya esta en uso");
			}else
				errorProviderCedula.Clear();
			
			//Validar Nombre
			if(!Validacion.validarTxtVacio(txtNombre.Text)){
				valido = false;
				errorProviderNombre.SetError(txtNombre, "El Campo esta vacio");
			}else
				errorProviderNombre.Clear();
			
			//Validar Apellido
			if(!Validacion.validarTxtVacio(txtApellido.Text)){
				valido = false;
				errorProviderApellido.SetError(txtApellido, "El Campo esta vacio");
			}else
				errorProviderApellido.Clear();
			
			if(datePickerNacimiento.Value > DateTime.Now.AddYears(-16)){
				valido = false;
				errorProviderFecha.SetError(datePickerNacimiento, "La fecha es de nacimiento es menor a 16 años");
			}else
				errorProviderFecha.Clear();
			
			//Validar Direccion
			if(!Validacion.validarTxtVacio(txtDireccion.Text)){
				valido = false;
				errorProviderDireccion.SetError(txtDireccion, "El Campo esta vacio");
			}else
				errorProviderDireccion.Clear();
			
			//Validar Correo
			if(!Validacion.validarTxtVacio(txtCorreo.Text)){
				valido = false;
				errorProviderCorreo.SetError(txtCorreo, "El Campo esta vacio");
			}else if(!Validacion.validarCorreo(txtCorreo.Text)){
				valido = false;
				errorProviderCorreo.SetError(txtCorreo, "El Correo no esta en un formato valido");
			}else
				errorProviderCorreo.Clear();
				
			//Validar Telefono
			if(!Validacion.valicarSoloNum(txtTelefono.Text)){
				valido = false;
				errorProviderTelefono.SetError(txtTelefono, "Solo se admiten numeros");
			}else if(!Validacion.validarTxtVacio(txtTelefono.Text)){
				valido = false;
				errorProviderTelefono.SetError(txtTelefono, "El Campo esta vacio");
			}else
				errorProviderTelefono.Clear();
			
			//Validar Movil
			if(!Validacion.valicarSoloNum(txtMovil.Text)){
				valido = false;
				errorProviderMovil.SetError(txtMovil, "Solo se admiten numeros");
			}else if(!Validacion.validarTxtVacio(txtTelefono.Text)){
				valido = false;
				errorProviderMovil.SetError(txtMovil, "El Campo esta vacio");
			}else
				errorProviderMovil.Clear();
			
			if(!Validacion.validarFechaFutura(dateTimeRegistro.Value)){
				valido = false;
				errorProviderFechaRegist.SetError(dateTimeRegistro, "La Fecha es futura");
			}else if(dateTimeRegistro.Value < datePickerNacimiento.Value){
				valido = false;
				errorProviderFechaRegist.SetError(dateTimeRegistro, "La Fecha de registro es anterior a la fecha de nacimiento");
			}else
				errorProviderFechaRegist.Clear();
			return valido;
		}
		
		public void btnGuardarClick(object sender, EventArgs e){
			coleccionClient.guardar();
			MessageBox.Show("Guardado!");
		}
		
		public void btnRecuperarClick(object sender, EventArgs e){
			if(coleccionClient.recuperar()){
				MessageBox.Show("Recuperado!");
			}else
				MessageBox.Show("No existe el archivo");
		}
	}
}
