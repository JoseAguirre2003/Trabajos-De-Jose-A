using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	public partial class FormConsultaPrestamo : Form
	{
		int posY=0;
		int posX=0;
		ColeccionPrestamos coleccionPrestam = new ColeccionPrestamos();
		public FormConsultaPrestamo(ColeccionPrestamos col)
		{
			InitializeComponent();
			btnSalir.Click += new EventHandler(btnSalir_Click);
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);
			btnFiltrar.Click += new EventHandler(filtrar);
			btnMstrarGeneral.Click += new EventHandler(mostrarTodo);
			btnRestaurarPres.Click += new EventHandler(restaurarPres);
			
			coleccionPrestam = col;
			if(coleccionPrestam._prestamosRegistrados.Count > 0){
				rellenarTodo();
				foreach(Prestamo prestamo in coleccionPrestam._prestamosRegistrados)
					comboBoxClientes.Items.Add(prestamo._cliente.Cedula);
			}
		}
		
		public void rellenarTodo(){
			foreach (Prestamo prestamo in coleccionPrestam._prestamosRegistrados) 
				foreach (dvdEnPrestamo dvd in prestamo._articulos) 
					dataGridView1.Rows.Add(prestamo._cliente.Cedula, prestamo._cliente.Nombres, prestamo._cliente.Apellido, dvd._codigo, dvd._titulo, prestamo._registroPrestamo.ToShortDateString(), dvd._diasEnRenta, dvd._devolucion.ToShortDateString());
		}
		
		public void mostrarTodo(object sender, EventArgs e){
			dataGridView1.Rows.Clear();
			rellenarTodo();
		}
		
		public void filtrar(object sender, EventArgs e){
			if(comboBoxClientes.Text.Trim() != ""){
				bool encontrado = false;
				String cedulaABuscar = comboBoxClientes.Text;
				dataGridView1.Rows.Clear();
				foreach (Prestamo prestamo in coleccionPrestam._prestamosRegistrados){
					if(prestamo._cliente.Cedula == cedulaABuscar){
						encontrado = true;
						foreach (dvdEnPrestamo dvd in prestamo._articulos) 
							dataGridView1.Rows.Add(prestamo._cliente.Cedula, prestamo._cliente.Nombres, prestamo._cliente.Apellido, dvd._codigo, dvd._titulo, prestamo._registroPrestamo.ToShortDateString(), dvd._diasEnRenta, dvd._devolucion.ToShortDateString());
						break;
					}
				}
				if(!encontrado)
					MessageBox.Show("No se ha encontrado ningun cliente por esa cedula");
			}else
				MessageBox.Show("El Campo esta vacio");
		}
		
		public void restaurarPres(object sender, EventArgs e){
			if(coleccionPrestam.recuperar()){
				MessageBox.Show("Prestamos Recuperados!", "Recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				rellenarTodo();
			}else
				MessageBox.Show("No existe el archivo de Prestamos, vaya al modulo de Prestamos y registrelos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		void btnSalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
