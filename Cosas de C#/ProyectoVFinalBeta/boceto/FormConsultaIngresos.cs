using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using ProyectoV2.Classes;

namespace ProyectoV2
{
	public partial class FormConsultaIngresos : Form
	{
		int posY=0;
		int posX=0;
		float montoTotal = 0f;
		ColeccionPrestamos coleccionPrestam = new ColeccionPrestamos();
		
		public FormConsultaIngresos(ColeccionPrestamos col)
		{
			InitializeComponent();
			btnSalir.Click+= new EventHandler(btnSalir_Click);
			Pmovement.MouseMove += new MouseEventHandler(Pmovement_MouseMove);
			btnFiltrar.Click += new EventHandler(filtrar);
			btnRestaurarPres.Click += new EventHandler(restaurarPres);
			coleccionPrestam = col;
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
		
		public void filtrar(object sender, EventArgs e){
			montoTotal = 0f;
			bool encontrado = false;
			dataGridView1.Rows.Clear();
			DateTime fechaFi = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
			DateTime fecha = new DateTime(2000, 1, 1);
			foreach (Prestamo prest in coleccionPrestam._prestamosRegistrados){
				foreach (dvdEnPrestamo dvd in prest._articulos){
					fecha = new DateTime(dvd._devolucion.Year, dvd._devolucion.Month, dvd._devolucion.Day);
					if(fecha == fechaFi){
						dataGridView1.Rows.Add(dvd._codigo, dvd._tipo, dvd._diasEnRenta, dvd._monto.ToString() + "$");
						montoTotal += dvd._monto;
						encontrado = true;
					}
				}
			}
			lblMonto.Text = montoTotal.ToString() + "$";
			if(!encontrado)
				MessageBox.Show("No hay ingresos para ese dia");
		}
		
		public void restaurarPres(object sender, EventArgs e){
			if(coleccionPrestam.recuperar()){
				MessageBox.Show("Prestamos Recuperados!", "Recuperado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else
				MessageBox.Show("No existe el archivo de Prestamos, vaya al modulo de Prestamos y registrelos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);	
		}

		void btnSalir_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
