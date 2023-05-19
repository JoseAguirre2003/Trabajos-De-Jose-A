﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoV2.Classes
{
	public class ColeccionDiscos
	{
		private List<DVD> coleccionDVD;
		public List<DVD> _coleccionDVD {get {return coleccionDVD;} set {coleccionDVD = value;}}
		string ruta = @"datoDVD.txt";
		
		public ColeccionDiscos(){
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
		
		public Int16 BuscarTitle(string title){
			Int16 posicion = -1;
			Int16 contador = 0;
			foreach (DVD dvd in coleccionDVD){
				if(dvd._title == title){
					posicion = contador;
					break;
				}
				contador++;
			}
			return posicion;
		}
		
		public void Actualizar(String code, String title, DateTime fabricDate, String type, String descrip, Int16 cantidad, DateTime ingresDate, string imgRuta){
			Int16 posicion = Buscar(code);
			if(posicion > -1){
				coleccionDVD[posicion]._title = title;
				coleccionDVD[posicion]._fabricDate = fabricDate;
				coleccionDVD[posicion]._type = type;
				coleccionDVD[posicion]._descrip = descrip;
				coleccionDVD[posicion]._cantidad = cantidad;
				coleccionDVD[posicion]._ingresDate = ingresDate;
				coleccionDVD[posicion]._imgRuta = imgRuta;
			}
		}
		
		public bool Eliminar(string code){
			Int16 puesto = Buscar(code);
			if(puesto > -1){
				coleccionDVD.RemoveAt(puesto);
				return true;
			}
			return false;
		}

		public void guardar(){
			FileStream arch = new FileStream(ruta, FileMode.OpenOrCreate);
			BinaryWriter archEs = new BinaryWriter(arch, Encoding.UTF8);
			foreach (DVD dvd in coleccionDVD){
				archEs.Write(dvd._code);
				archEs.Write(dvd._title);
				archEs.Write(dvd._fabricDate.Day);
				archEs.Write(dvd._fabricDate.Month);
				archEs.Write(dvd._fabricDate.Year);
				archEs.Write(dvd._type);
				archEs.Write(dvd._descrip);
				archEs.Write(dvd._cantidad);
				archEs.Write(dvd._ingresDate.Day);
				archEs.Write(dvd._ingresDate.Month);
				archEs.Write(dvd._ingresDate.Year);
				archEs.Write(dvd._imgRuta);
			}
			archEs.Close();
		}
		
		public bool recuperar(){
			if(File.Exists(ruta)){
				coleccionDVD.Clear();
				FileStream arch = new FileStream(ruta, FileMode.Open);
				BinaryReader archLe = new BinaryReader(arch, Encoding.UTF8);
				DVD dvdRecup;
				while (archLe.PeekChar() > -1){
					dvdRecup = recuperarObj(archLe);
					coleccionDVD.Add(dvdRecup);
				}
				archLe.Close();
				return true;
			}
			return false;
		}
		
		public DVD recuperarObj(BinaryReader ar){
			
			DateTime fechaFabric = new DateTime(2000, 1, 1);
			DateTime fechaIngres = new DateTime(2000, 1, 1);
			
			String code = ar.ReadString();
			String title = ar.ReadString();
			Int32 dayFabric = ar.ReadInt32();
			Int32 monthFabric = ar.ReadInt32();
			Int32 yearFabric = ar.ReadInt32();
			String type = ar.ReadString();
			String descrip = ar.ReadString();
			Int16 cant = ar.ReadInt16();
			Int32 dayIngres = ar.ReadInt32();
			Int32 monthIngres = ar.ReadInt32();
			Int32 yearIngres = ar.ReadInt32();
			String rutaImg = ar.ReadString();
			
			fechaFabric = new DateTime(yearFabric, monthFabric, dayFabric);
			fechaIngres = new DateTime(yearIngres, monthIngres, dayIngres);
			
			DVD dvdRecuperado = new DVD(code, title, fechaFabric, type, descrip, cant, fechaIngres, rutaImg);
			return dvdRecuperado;
		}
	}
}