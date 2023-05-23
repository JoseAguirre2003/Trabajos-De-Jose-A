using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	public partial class FormDVD : Form
	{
		int posX=0;
		int posY=0;
		ColeccionDiscos colecDVD;
		public FormDVD(ColeccionDiscos col)
		{
			
			InitializeComponent();
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);
			radioButton1.Click += new EventHandler(radioButton1_Click);
			radioButton2.Click += new EventHandler(radioButton2_Click);
			radioButton3.Click += new EventHandler(radioButton3_Click);
			btnCerrar.Click += new EventHandler(btnCerrar_Click);
			btnRegist.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			btnBuscarImg.Click += new EventHandler(btnBuscarImgClick);
			btnActualizar.Click += new EventHandler(btnActualizarClick);
			btnEliminar.Click += new EventHandler(btnEliminarClick);
			btnReiniciar.Click += new EventHandler(btnReiniciarClick);
			btnGuardar.Click += new EventHandler(btnGuardar_Click);
			btnRecuperar.Click += new EventHandler(btnRecuperar_Click);
			colecDVD = col;
			pictureBox1.BackgroundImage = Image.FromFile(@"New folder\dvdLabel.png");
			pictureboxOPC.BackgroundImage = Image.FromFile(@"New folder\dvdLabel.png");
		}

		void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		void radioButton3_Click(object sender, EventArgs e)
		{
			if(radioButton3.Checked)
				pictureboxOPC.BackgroundImage=Image.FromFile(@"New folder\R.jpg");
			
		}

		void radioButton2_Click(object sender, EventArgs e)
		{
			if(radioButton2.Checked)
				pictureboxOPC.BackgroundImage=Image.FromFile(@"New folder\Hero_Image_12112020.0.jpg");
			
		}

		void radioButton1_Click(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
				pictureboxOPC.BackgroundImage=Image.FromFile(@"New folder\R (2).png");
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
			if(validar(true)){
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
				MessageBox.Show("Registrado con exito", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar();
			}else{
				MessageBox.Show("Datos errados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		//Falta validar!!
		public void btnBuscarClick(object sender, EventArgs e){
			if(txtCode.Text.Trim() != ""){
				Int16 pos = colecDVD.Buscar(txtCode.Text);
				DVD dvdInUse;
				if(pos > -1){
					dvdInUse = colecDVD._coleccionDVD[pos];
					txtTitle.Text = dvdInUse._title;
					datePickerFabric.Value = dvdInUse._fabricDate;
					switch (dvdInUse._type){
						case "BluRay":
							radioButton1.Checked = true;
							pictureboxOPC.BackgroundImage = Image.FromFile(@"New folder\R (2).png");
							break;
						case "Juego":
							radioButton2.Checked = true;
							pictureboxOPC.BackgroundImage = Image.FromFile(@"New folder\Hero_Image_12112020.0.jpg");
							break;
						case "Album":
							radioButton3.Checked = true;
							pictureboxOPC.BackgroundImage = Image.FromFile(@"New folder\R.jpg");
							break;
					}
					richTxtDescrip.Text = dvdInUse._descrip;
					numericUpCantidad.Value = dvdInUse._cantidad;
					datePickerIngres.Value = dvdInUse._ingresDate;
					if(File.Exists(dvdInUse._imgRuta)){
						pictureBox1.BackgroundImage = Image.FromFile(@dvdInUse._imgRuta);
						txtRuta.Text = dvdInUse._imgRuta;
					}else{
						pictureBox1.BackgroundImage = Image.FromFile(@"New folder\dvdLabel.png");
						MessageBox.Show("La la ruta de la Imagen no se encuentra, se pondra el Label en su lugar", "No se encontro la ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}else
					MessageBox.Show("No se pudo encontrar el DVD que busca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProviderCode.Clear();
			}else
				errorProviderCode.SetError(txtCode, "ERROR! El campo esta vacio");
		}
		
		public void btnActualizarClick(object sender, EventArgs e){
			if(validar(false)){
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
				
				if(colecDVD.Actualizar(code, title, fabricDate, type, descrip, cant, ingresDate, imgRuta))
					MessageBox.Show("Actualizado con EXITO!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("No se ha podido actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				limpiar();
			}else
				MessageBox.Show("No se ha podido actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public void btnEliminarClick(object sender, EventArgs e){
			if(!(txtCode.Text.Trim() == "")){
				String code = txtCode.Text;
				if(colecDVD.Eliminar(code)){
					MessageBox.Show("Eliminado!", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					limpiar();
				}else
					MessageBox.Show("No se pudo encontrar para su eliminacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorProviderCode.Clear();
			}else
				errorProviderCode.SetError(txtCode, "ERROR! El campo esta vacio");
		}
		
		public void btnBuscarImgClick(object sender, EventArgs e){
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Img Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";
			if(openFile.ShowDialog() == DialogResult.OK){
				txtRuta.Text = openFile.FileName;
				pictureBox1.BackgroundImage = Image.FromFile(txtRuta.Text);
			}
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
			pictureBox1.BackgroundImage = Image.FromFile(@"New folder\dvdLabel.png");
			pictureboxOPC.BackgroundImage = Image.FromFile(@"New folder\dvdLabel.png");
		}
		
		public void btnReiniciarClick(object sender, EventArgs e){
			limpiar();
		}
		
		public bool validar(bool registrando){	
			bool valido = true;
			
			//Validar Codigo
			if(!Validacion.validarTxtVacio(txtCode.Text)){
				valido = false;
				errorProviderCode.SetError(txtCode, "ERROR! El campo esta vacio");
			}else if(registrando && colecDVD.Buscar(txtCode.Text) > -1){
				valido = false;
				errorProviderCode.SetError(txtCode, "ERROR! El codigo ya esta en uso!");
			}else
				errorProviderCode.Clear();
			
			//Validar Titulo
			if(!Validacion.validarTxtVacio(txtTitle.Text)){
				valido = false;
				errorProviderTitulo.SetError(txtTitle, "ERROR! El campo esta vacio");
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
			}else if(datePickerIngres.Value < datePickerFabric.Value){
				valido = false;
				errorProviderFechaI.SetError(datePickerIngres, "ERROR! La fecha de ingreso es pasada a la fecha de fabricacion!");
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
		
		void btnGuardar_Click(object sender, EventArgs e){
			colecDVD.guardar();
			MessageBox.Show("Datos guardados!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}	
		
		void btnRecuperar_Click(object sender, EventArgs e){
			if(colecDVD.recuperar()){
				MessageBox.Show("Recuperado!", "Recuperar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else
				MessageBox.Show("No existe el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
