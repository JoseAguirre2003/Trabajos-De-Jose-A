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
			btnCerrar.Click += new EventHandler(btnCerrarClick);
			btnRegist.Click += new EventHandler(btnRegistrarClick);
			btnBuscar.Click += new EventHandler(btnBuscarClick);
			colecDVD = col;
			pictureBox1.BackgroundImage = Image.FromFile(@"img\dvdLabel.png");
		}
		
		public void btnRegistrarClick(object sender, EventArgs e){
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
				
				colecDVD.Agregar(code, title, fabricDate, type, descrip, cant, ingresDate, imgRuta);
				MessageBox.Show("Guardado con exito!");
				limpiar();
			}
		}
		
		public void btnBuscarClick(object sender, EventArgs e){
			Int16 pos = colecDVD.Buscar(txtCode.Text);
			DVD dvdInUse;
			if(pos > -1){
				dvdInUse = colecDVD._coleccionDVD[pos];
				txtTitle.Text = dvdInUse._title;
				datePickerFabric.Value = dvdInUse._fabricDate;
				
				switch (dvdInUse._type) {
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
			}
		}
		
		public void btnActualizarClick(object sender, EventArgs e){
		
		}
		
		public void btnEliminarClick(object sender, EventArgs e){
		
		}
		
		public void btnBuscarImgClick(object sender, EventArgs e){
		
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
	}
}