using System;
using System.Collections.Generic;

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
		
		public void Agregar(String code, String cedula, String nombre, String apellido, List<dvdEnPrestamo> articulos){
			Prestamo prest = new Prestamo(code, cedula, nombre, apellido, articulos);
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
	}
}
