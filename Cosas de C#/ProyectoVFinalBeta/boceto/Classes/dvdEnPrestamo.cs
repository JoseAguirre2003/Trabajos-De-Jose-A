using System;

namespace ProyectoV2.Classes
{
	public class dvdEnPrestamo
	{
		private String codigo;
		private String titulo;
		private String tipo;
		private Int16 diasEnRenta;
		private DateTime devolucion;
		private float monto;

		public String _codigo {get {return codigo;} set{codigo = value;}}
		public String _titulo {get {return titulo;} set{titulo = value;}}
		public String _tipo {get {return tipo;} set{tipo = value;}}
		public Int16 _diasEnRenta {get {return diasEnRenta;} set{diasEnRenta = value;}}
		public DateTime _devolucion {get {return devolucion;} set{devolucion = value;}}
		public float _monto {get {return monto;} set {monto = value;}}

		public dvdEnPrestamo(){
			this.codigo = "";
			this.titulo = "";
			this.tipo = "";
			this.diasEnRenta = 0;
			this.devolucion = new DateTime(2000, 1, 1);
			this._monto = 0;
		}
		
		public dvdEnPrestamo(String codigo, String titulo, String tipo, Int16 diasRenta, DateTime devolucion, float monto){
			this.codigo = codigo;
			this.titulo = titulo;
			this.tipo = tipo;
			this.diasEnRenta = diasRenta;
			this.devolucion = devolucion;
			this.monto = monto;
		}
	}
}