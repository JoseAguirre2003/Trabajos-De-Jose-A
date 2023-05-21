using System;
using System.Collections.Generic;

namespace ProyectoV2.Classes
{
	public class Prestamo
	{
		private String codigo;
		private String cedula;
		private String nombre;
		private String apellido;
		private List<dvdEnPrestamo> articulos;
		private DateTime registroPrestamo;
		
		public String _codigo {get {return codigo;} set{codigo = value;}}
		public String _cedula {get {return cedula;} set{cedula = value;}}
		public String _nombre {get {return nombre;} set{nombre = value;}}
		public String _apellido {get {return apellido;} set{apellido = value;}}
		public List<dvdEnPrestamo> _articulos {get {return articulos;} set{articulos = value;}}
		public DateTime _registroPrestamo {get {return registroPrestamo;} set{registroPrestamo = value;}}
		
		public Prestamo(){
			this.codigo = "";
			this.cedula = "";
			this.nombre = "";
			this.apellido = "";
			this.articulos = new List<dvdEnPrestamo>();
		}
		
		public Prestamo(String code, String cedula, String nombre, String apellido, List<dvdEnPrestamo> articulos){
			this.codigo = code;
			this.cedula = cedula;
			this.nombre = nombre;
			this.apellido = apellido;
			this.articulos = articulos;
		}
	}
}