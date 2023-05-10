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
		
		public void Agregar(String code, String title, DateTime manuDate, String type, String descript, Int16 amount, DateTime adDate, string imgPath){	
			DVD dvd = new DVD(code, title, manuDate, type, descript, amount, adDate, imgPath);
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
		
		public void Actualizar(string code){
			Int16 posicion = Buscar(code);
			coleccionDVD[posicion]._code;
			coleccionDVD[posicion]._title;
			coleccionDVD[posicion]._manuDate;
			coleccionDVD[posicion]._type;
			coleccionDVD[posicion]._descript;
			coleccionDVD[posicion]._amount;
			coleccionDVD[posicion]._adDate;
			coleccionDVD[posicion]._imgPath;
		}
		
//		public bool Eliminar(){
//			return false;
//		}
	}
}
