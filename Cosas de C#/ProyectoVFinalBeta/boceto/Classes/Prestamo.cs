using System;
using System.Collections.Generic;

namespace ProyectoV2.Classes
{
	public class Prestamo
	{
		private String codigo;
		private Cliente cliente;
		private DateTime registroPrestamo;
		private float monto;
		private List<dvdEnPrestamo> articulos;
		
		public String _codigo {get {return codigo;} set{codigo = value;}}
		public Cliente _cliente {get {return cliente;} set{cliente = value;}}
		public DateTime _registroPrestamo {get {return registroPrestamo;} set{registroPrestamo = value;}}
		public float _monto {get {return monto;} set{monto = value;}}
		public List<dvdEnPrestamo> _articulos {get {return articulos;} set{articulos = value;}}
		
		public Prestamo(){
			this.cliente = new Cliente();
			this.articulos = new List<dvdEnPrestamo>();
			this.monto = 0f;
		}
		
		public Prestamo(String codigo, Cliente cliente, List<dvdEnPrestamo> articulos, DateTime registroPrestamo, float monto){
			this.codigo = codigo;
			this.cliente = cliente;
			this.articulos = articulos;
			this.registroPrestamo = registroPrestamo;
			this.monto = monto;
		}
		
		public override string ToString()
		{
			return string.Format("[Prestamo Codigo={0}, Cliente={1}, RegistroPrestamo={2}, Monto={3}, Articulos={4}]", codigo, cliente, registroPrestamo, monto, articulos);
		}

	}
}