using System;

namespace ProyectoV2.Classes
{
	public class Prestamo
	{
		private Cliente clientePres;
		private DVD dvdPrest;
		private Int16 diasRenta;
		
		public Cliente _clientePres {get {return clientePres;} set {clientePres = value;}}
		public DVD _dvdPrest {get {return dvdPrest;} set {dvdPrest = value;}}
		public Int16 _diasRenta {get {return diasRenta;} set {diasRenta = value;}}
		
		public Prestamo(Cliente clientePres, DVD dvdPrest, Int16 diasRenta){
			this.clientePres = clientePres;
			this.dvdPrest = dvdPrest;
			this.diasRenta = diasRenta;
		}
	}
}
