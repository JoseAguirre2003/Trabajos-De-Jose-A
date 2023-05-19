using System;
using System.Collections.Generic;

namespace ProyectoV2.Classes
{
	public class ColeccionPrestamo
	{
		private List<Prestamo> listPrest;
		public List<Prestamo> _listPrest {get {return listPrest;} set {listPrest = value;}}
		
		public ColeccionPrestamo()
		{
			listPrest = new List<Prestamo>();
		}
		
		public void Agregar(Cliente clientePres, DVD dvdPrest, Int16 diasRenta){
			Prestamo prest = new Prestamo(clientePres, dvdPrest, diasRenta);
			listPrest.Add(prest);
		}
	}
}
