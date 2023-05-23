using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ProyectoV2.Classes
{
	public class ColeccionPrestamos
	{
		private List<Prestamo> prestamosRegistrados;
		public List<Prestamo> _prestamosRegistrados {get{return prestamosRegistrados;} set{prestamosRegistrados = value;}}
		string ruta = "prestamos.txt";
		char separador = ';';
		
		public ColeccionPrestamos(){
			prestamosRegistrados = new List<Prestamo>();
		}
		
		public void Agregar(String code, Cliente client, List<dvdEnPrestamo> articulos, DateTime fechaRegist, float monto){
			Prestamo prest = new Prestamo(code, client, articulos, fechaRegist, monto);
			prestamosRegistrados.Add(prest);
		}
		
		public Int16 Buscar(string code){
			Int16 posicion = -1;
			Int16 contador = 0;
			foreach (Prestamo prest in prestamosRegistrados){
				if(prest._codigo == code){
					posicion = contador;
					break;
				}
				contador++;
			}
			return posicion;
		}
		
		public bool Eliminar(string code){
			Int16 puesto = Buscar(code);
			if(puesto > -1){
				prestamosRegistrados.RemoveAt(puesto);
				return true;
			}
			return false;
		}
		
		public void guardar(){
			StreamWriter arhcEs = new StreamWriter(ruta, false);
			String l;
			foreach (Prestamo prest in prestamosRegistrados){
				l = escribir1(prest);
				arhcEs.Write(l);
				l = escribir2(prest);
				arhcEs.Write(l);
			}
			arhcEs.Close();
		}
		
		public String escribir1(Prestamo prest){
			String l = "Prestamo";
			String s = separador.ToString().Trim();
			l += s + prest._codigo.ToString() + s + prest._cliente.Cedula.ToString() + s + prest._cliente.Nombres.ToString() + s + prest._cliente.Apellido.ToString();
			l += s + prest._cliente.FechaNacim.ToString("s") + s + prest._cliente.Direccion.ToString() + s + prest._cliente.Correo.ToString() + s + prest._cliente.NumeroCasa.ToString();
			l += s + prest._cliente.NumeroMovil.ToString() + s + prest._cliente.FechaRegist.ToString("s") + s + prest._registroPrestamo.ToString("s") + s + prest._monto.ToString("G",CultureInfo.InvariantCulture) + "\n";
			return l;
		}
		
		public String escribir2(Prestamo prest){
			String l = "";
			String s = separador.ToString().Trim();
			foreach (dvdEnPrestamo dvd in prest._articulos){
				l += "Articulo" + s + dvd._codigo.ToString() + s + dvd._titulo.ToString() + s + dvd._tipo.ToString() + s + dvd._diasEnRenta.ToString() + s + dvd._devolucion.ToString("s");
				l += s + dvd._monto.ToString("G",CultureInfo.InvariantCulture) + "\n";
			}
			return l;
		}

//		public bool recuperar(){
//			if(File.Exists(ruta)){
//				String[] allLines = File.ReadAllLines(ruta);
//				String [] datos;
//				dvdEnPrestamo dvd = new dvdEnPrestamo();
//				Cliente client = new Cliente();
//				Prestamo prestamo = new Prestamo();
//				List<dvdEnPrestamo> articulosP = new List<dvdEnPrestamo>();
//				bool prestamoLeido = false;
//				foreach (String linea in allLines) {
//					datos = linea.Split(separador);
//					if(datos[0] == "Prestamo"){
//						if(prestamoLeido){
//							foreach(dvdEnPrestamo dvdP in articulosP){
//								prestamo._articulos.Add(dvdP);
//							}
//							prestamosRegistrados.Add(prestamo);
//							articulosP.Clear();
//						}else
//							prestamoLeido = true;
//						prestamo._codigo = datos[1]; //Del prestamo
//						client.Cedula = datos[2];
//						client.Nombres = datos[3];
//						client.Apellido = datos[4];
//						client.FechaNacim = Convert.ToDateTime(datos[5], CultureInfo.InvariantCulture);
//						client.Direccion = datos[6];
//						client.Correo = datos[7];
//						client.NumeroCasa = datos[8];
//						client.NumeroMovil = datos[9];
//						client.FechaRegist = Convert.ToDateTime(datos[10], CultureInfo.InvariantCulture);
//						prestamo._registroPrestamo = Convert.ToDateTime(datos[11], CultureInfo.InvariantCulture); //Del Prestamo
//						prestamo._monto = float.Parse(datos[12], CultureInfo.InvariantCulture); //Del Prestamo
//					}else if(datos[0] == "Articulo"){
//						dvd._codigo = datos[1];
//						dvd._titulo = datos[2];
//						dvd._tipo = datos[3];
//						dvd._diasEnRenta = Convert.ToInt16(datos[4]);
//						dvd._devolucion = Convert.ToDateTime(datos[5], CultureInfo.InvariantCulture);
//						dvd._monto = float.Parse(datos[6], CultureInfo.InvariantCulture);
//						articulosP.Add(dvd);	
//					}
//				}
//				if(prestamoLeido){
//					foreach(dvdEnPrestamo dvdP in articulosP)
//						prestamo._articulos.Add(dvdP);
//					prestamosRegistrados.Add(prestamo);
//					articulosP.Clear();
//				}
//					
//				return true;
//			}
//			return false;
//		}
		
		public bool recuperar(){
			bool prestamoLeido = false;
			if(File.Exists(ruta)){
				prestamosRegistrados.Clear();
				String[] allLines = File.ReadAllLines(ruta);
				String [] datos;
				String Codigo = "";
				String CI, nombre, apellido;
				DateTime fechaNacim;
				String direccion, correo, numCasa, numMovil;
				DateTime fechaRegist, fechaRegistPrest = new DateTime(2000, 1, 1);
				float monto = 0f;
				String codigoPres, titulo, tipo;
				Int16 diasEnRenta;
				DateTime devolucion;
				float montoArt = 0f;
				dvdEnPrestamo dvd;
				Cliente client = new Cliente();
				Prestamo prestamo = new Prestamo();
				List<dvdEnPrestamo> articulosP = new List<dvdEnPrestamo>();
				foreach (String linea in allLines) {
					datos = linea.Split(separador);
					if(datos[0] == "Prestamo"){
						if(prestamoLeido){
							prestamo = new Prestamo(Codigo, client, new List<dvdEnPrestamo>(), fechaRegistPrest, monto);
							foreach (dvdEnPrestamo dvdP in articulosP)
								prestamo._articulos.Add(dvdP);
							prestamosRegistrados.Add(prestamo);
							articulosP.Clear();
						}else
							prestamoLeido = true;
						Codigo = datos[1]; //Del prestamo
						CI = datos[2];
						nombre = datos[3];
						apellido = datos[4];
						fechaNacim = Convert.ToDateTime(datos[5]);
						direccion = datos[6];
						correo = datos[7];
						numCasa = datos[8];
						numMovil = datos[9];
						fechaRegist = Convert.ToDateTime(datos[10]);
						fechaRegistPrest = Convert.ToDateTime(datos[11]); //Del Prestamo
						monto = float.Parse(datos[12]); //Del Prestamo
						client = new Cliente(CI, nombre, apellido, fechaNacim, direccion, correo, numCasa, numMovil, fechaRegist);
					}else if(datos[0] == "Articulo"){
						codigoPres = datos[1];
						titulo = datos[2];
						tipo = datos[3];
						diasEnRenta = Convert.ToInt16(datos[4]);
						devolucion = Convert.ToDateTime(datos[5]);
						montoArt = float.Parse(datos[6]);
						dvd = new dvdEnPrestamo(codigoPres, titulo, tipo, diasEnRenta, devolucion, montoArt);
						articulosP.Add(dvd);	
					}
				}
				if(prestamoLeido){
					prestamo = new Prestamo(Codigo, client, new List<dvdEnPrestamo>(), fechaRegistPrest, monto);
					foreach (dvdEnPrestamo dvdP in articulosP)
						prestamo._articulos.Add(dvdP);
					prestamosRegistrados.Add(prestamo);
					articulosP.Clear();		
				}
				return true;
			}
			return false;
		}
	}
}
