using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ProyectoV1.Classes;

namespace ProyectoV1
{
	public partial class FormDVD : Form
	{
		ColeccionDiscos colecDVD;
		public FormDVD(ColeccionDiscos col)
		{
			InitializeComponent();
			btnCerrar.Click += new EventHandler(btnCerrarClick);
			btnRegist.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			btnBuscarImg.Click += new EventHandler(btnBuscarImgClick);
			btnActualizar.Click += new EventHandler(btnActualizarClick);
			btnEliminar.Click += new EventHandler(btnEliminarClick);
			btnReiniciar.Click += new EventHandler(btnReiniciarClick);
			colecDVD = col;
			pictureBox1.BackgroundImage = Image.FromFile(@"img\dvdLabel.png");
		}
		
		public void btnRegistrarClick(object sender, EventArgs e){
			//Falta validar!!
			if(validar()){
				String code = txtCode.Text;
				String title = txtTitle.Text;
				DateTime fabricDate = datePickerFabric.Value;
				String type = string.Empty;
				
				if(radioButton1.Checked)
					type = "BluRay";
				else if(radioButton2.Checked)
					type = "Juego";
				else if(radioButton3.Checked)
					type = "Album";
				
				String descrip = richTxtDescrip.Text;
				Int16 cant = (Int16)numericUpCantidad.Value;
				DateTime ingresDate = datePickerIngres.Value;
				string imgRuta = txtRuta.Text;
				
				colecDVD.Agregar(code, title, fabricDate, type, descrip, cant, ingresDate, imgRuta);
				MessageBox.Show("Guardado con exito!");
				limpiar();
			}else{
				MessageBox.Show("Datos errados :(");
			}
		}
		
		//Falta validar!!
		public void btnBuscarClick(object sender, EventArgs e){
			Int16 pos = colecDVD.Buscar(txtCode.Text);
			DVD dvdInUse;
			if(pos > -1){
				dvdInUse = colecDVD._coleccionDVD[pos];
				txtTitle.Text = dvdInUse._title;
				datePickerFabric.Value = dvdInUse._fabricDate;
				switch (dvdInUse._type){
					case "BluRay":
						radioButton1.Checked = true;
						break;
					case "Juego":
						radioButton2.Checked = true;
						break;
					case "Album":
						radioButton3.Checked = true;
						break;
				}
				richTxtDescrip.Text = dvdInUse._descrip;
				numericUpCantidad.Value = dvdInUse._cantidad;
				datePickerIngres.Value = dvdInUse._ingresDate;
				txtRuta.Text = dvdInUse._imgRuta;
				pictureBox1.BackgroundImage = Image.FromFile(@dvdInUse._imgRuta);
			}else{
				MessageBox.Show("No se pudo encontrar el DVD que busca :(");
			}
		}
		
		public void btnActualizarClick(object sender, EventArgs e){
			if(true){
				String code = txtCode.Text;
				String title = txtTitle.Text;
				DateTime fabricDate = datePickerFabric.Value;
				String type = string.Empty;
				
				if(radioButton1.Checked)
					type = "BluRay";
				else if(radioButton2.Checked)
					type = "Juego";
				else if(radioButton3.Checked)
					type = "Album";
				
				String descrip = richTxtDescrip.Text;
				Int16 cant = (Int16)numericUpCantidad.Value;
				DateTime ingresDate = datePickerIngres.Value;
				string imgRuta = txtRuta.Text;
				
				colecDVD.Actualizar(code, title, fabricDate, type, descrip, cant, ingresDate, imgRuta);
				MessageBox.Show("Actualizado con EXITO! :)");
				limpiar();
			}
		}
		
		//Falta validar!!
		public void btnEliminarClick(object sender, EventArgs e){
			String code = txtCode.Text;
			if(colecDVD.Eliminar(code)){
				MessageBox.Show("Eliminado!");
				limpiar();
			}else
				MessageBox.Show("No se pudo encontrar para su eliminacion");
			
		}
		
		//Falta validar!!
		public void btnBuscarImgClick(object sender, EventArgs e){
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Img Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
			if(openFile.ShowDialog() == DialogResult.OK){
				txtRuta.Text = openFile.FileName;
				pictureBox1.BackgroundImage = Image.FromFile(txtRuta.Text);
			}
		}
		
		public void btnCerrarClick(object sender, EventArgs e){
			Dispose();
		}
		
		public void limpiar(){		
			txtCode.Text = "";
			txtTitle.Text = "";
			datePickerFabric.Value = DateTime.Now;
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			richTxtDescrip.Text = "";
			numericUpCantidad.Value = 0;
			datePickerIngres.Value = DateTime.Now;
			txtRuta.Text = "";
			pictureBox1.BackgroundImage = Image.FromFile(@"img\dvdLabel.png");
		}
		
		public void btnReiniciarClick(object sender, EventArgs e){
			limpiar();
		}
		
		public bool validar(){	
			bool valido = true;
			
			//Validar Codigo
			if(!Validacion.validarTxtVacio(txtCode.Text)){
				valido = false;
				errorProviderCode.SetError(txtCode, "ERROR! El campo esta vacio");
			}else if(colecDVD.Buscar(txtCode.Text) > -1){
				valido = false;
				errorProviderCode.SetError(txtCode, "ERROR! El codigo ya esta en uso!");
			}else
				errorProviderCode.Clear();
			
			//Validar Titulo
			if(!Validacion.validarTxtVacio(txtTitle.Text)){
				valido = false;
				errorProviderTitulo.SetError(txtTitle, "ERROR! El campo esta vacio");
			}else if(colecDVD.Buscar(txtTitle.Text) > -1){
				valido = false;
				errorProviderTitulo.SetError(txtTitle, "ERROR! El titulo ya esta en uso!");
			}else
				errorProviderTitulo.Clear();
			
			//Validar Fecha de Fabricacion
			if(!Validacion.validarFechaFutura(datePickerFabric.Value)){
				valido = false;
				errorProviderFechaF.SetError(datePickerFabric, "ERROR! La fecha es futura!");
			}else
				errorProviderFechaF.Clear();
			
			//Validar Radio Buttons
			if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked){
				valido = false;
				errorProviderRadioBt.SetError(grupBoxTypeDVD, "ERROR! No se ha seleccionado el tipo de contenido de DVD");
			}else
				errorProviderRadioBt.Clear();
			
			//Validar Descripcion
			if(!Validacion.validarTxtVacio(richTxtDescrip.Text)){
				valido = false;
				errorProviderDescrip.SetError(richTxtDescrip, "ERROR! El campo esta vacio");
			}else
				errorProviderDescrip.Clear();
			
			//Validar Cantidad
			if(numericUpCantidad.Value < 1){
				valido = false;
				errorProviderCantidad.SetError(numericUpCantidad, "Error! Cantidad no debe ser 0 o inferior");
			}else
				errorProviderCantidad.Clear();
			
			//Validar Fecha de Ingreso
			if(!Validacion.validarFechaFutura(datePickerIngres.Value)){
				valido = false;
				errorProviderFechaI.SetError(datePickerIngres, "ERROR! La fecha es futura!");
			}else
				errorProviderFechaI.Clear();
			
			//Validar Imagen
			if(!File.Exists(txtRuta.Text)){
				valido = false;
				errorProviderRuta.SetError(txtRuta, "ERROR! La Ruta no existe");
			}else
				errorProviderRuta.Clear();
				
			return valido;
		}
	}
}