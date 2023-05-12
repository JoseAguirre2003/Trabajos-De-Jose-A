using System;
using System.Collections.Generic;

namespace ProyectoV1.Classes
{

	public class ColeccionDiscos
	{
		
		List<DVD> coleccionDVD;
		
		public ColeccionDiscos()
		{
			coleccionDVD = new List<DVD>();
		}
		
		public void Agregar(String code, String title, DateTime fabricDate, String type, String descrip, Int16 cantidad, DateTime ingresDate, string imgRuta){	
			DVD dvd = new DVD(code, title, fabricDate, type, descrip, cantidad, ingresDate, imgRuta);
			coleccionDVD.Add(dvd);
		}
		
		public Int16 Buscar(string code){
			Int16 posicion = -1;
			Int16 contador = 0;
			foreach (DVD dvd in coleccionDVD){
				if(dvd._code == code){
					posicion = contador;
					break;
				}
				contador++;
			}
			return posicion;
		}
		
		public void Actualizar(String code, String title, DateTime fabricDate, String type, String descrip, Int16 cantidad, DateTime ingresDate, string imgRuta){
			Int16 posicion = Buscar(code);
			coleccionDVD[posicion]._title = title;
			coleccionDVD[posicion]._fabricDate = fabricDate;
			coleccionDVD[posicion]._type = type;
			coleccionDVD[posicion]._descrip = descrip;
			coleccionDVD[posicion]._cantidad = cantidad;
			coleccionDVD[posicion]._ingresDate = ingresDate;
			coleccionDVD[posicion]._imgRuta = imgRuta;
		}
		
		public bool Eliminar(string code){
			Int16 puesto = Buscar(code);
			if(puesto > -1){
				coleccionDVD.RemoveAt(puesto);
				return true;
			}
			return false;
		}	
	}
}
