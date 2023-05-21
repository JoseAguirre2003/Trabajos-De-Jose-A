using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoV2.Classes
{
	public class ColeccionClientes
	{
		private List<Cliente> listaClientes;
		public List<Cliente> _listaClientes {get {return listaClientes;} set {listaClientes = value;}}
		string ruta = @"datoCliente.txt";
		char separador = ';';
		
		public ColeccionClientes()
		{
			listaClientes = new List<Cliente>();
		}
		
		public void Agregar(String cedula, String nombres, String apellido, DateTime fechaNacim, String direccion, String correo, String numeroMovil, String numeroCasa, DateTime fechaRegist){	
			Cliente client = new Cliente(cedula, nombres, apellido, fechaNacim, direccion, correo, numeroMovil, numeroCasa, fechaRegist);
			listaClientes.Add(client);
		}
		
		public Int16 Buscar(String cedula){
			Int16 posicion = -1;
			Int16 contador = 0;
			foreach (Cliente client in listaClientes){
				if(client.Cedula == cedula){
					posicion = contador;
					break;
				}
				contador++;
			}
			return posicion;
		}
		
		public void Actualizar(String cedula, String nombres, String apellido, DateTime fechaNacim, String direccion, String correo, String numeroMovil, String numeroCasa, DateTime fechaRegist){
			Int16 posicion = Buscar(cedula);
			if(posicion > -1){
				listaClientes[posicion].Cedula = cedula;
				listaClientes[posicion].Nombres = nombres;
				listaClientes[posicion].Apellido = apellido;
				listaClientes[posicion].FechaNacim = fechaNacim;
				listaClientes[posicion].Direccion = direccion;
				listaClientes[posicion].Correo = correo;
				listaClientes[posicion].NumeroMovil = numeroMovil;
				listaClientes[posicion].NumeroCasa = numeroCasa;
				listaClientes[posicion].FechaRegist = fechaRegist;
			}
		}
		
		public bool Eliminar(string cedula){
			Int16 puesto = Buscar(cedula);
			if(puesto > -1){
				listaClientes.RemoveAt(puesto);
				return true;
			}
			return false;
		}
		
		public void guardar(){
			StreamWriter archEs = new StreamWriter(ruta, false);
			foreach (Cliente client in listaClientes)
				archEs.Write(escribir(client));
			archEs.Close();
		}
		
		public String escribir(Cliente client){
			String l = string.Empty;
			String s = separador.ToString().Trim();
			l = client.Cedula.ToString() + s + client.Nombres.ToString() + s + client.Apellido.ToString() + s;
			l += client.FechaNacim.ToString() + s + client.Direccion.ToString() + s + client.Correo.ToString() + s;
			l += client.NumeroCasa.ToString() + s + client.NumeroMovil.ToString() + s + client.FechaRegist.ToString() + "\n";
			return l;
		}
		
		public bool recuperar(){
			if(File.Exists(ruta)){
				listaClientes.Clear();
				String[] allLines = File.ReadAllLines(ruta);
				String [] datos;
				String CI;
				String nombre;
				String apellido;
				DateTime fechaNacim;
				String direccion;
				String correo;
				String numCasa;
				String numMovil;
				DateTime fechaRegist;
				foreach (String linea in allLines){
					datos = linea.Split(separador);
					CI = datos[0];
					nombre = datos[1];
					apellido = datos[2];
					fechaNacim = Convert.ToDateTime(datos[3]);
					direccion = datos[4];
					correo = datos[5];
					numCasa = datos[6];
					numMovil = datos[7];
					fechaRegist = Convert.ToDateTime(datos[8]);
					listaClientes.Add(new Cliente(CI, nombre, apellido, fechaNacim, direccion, correo, numCasa, numMovil, fechaRegist));
				}
				return true;
			}
			return false;
		}

//		public void guardar(){
//			FileStream arch = new FileStream(ruta, FileMode.OpenOrCreate);
//			BinaryWriter archEs = new BinaryWriter(arch, Encoding.UTF8);
//			foreach (Cliente client in listaClientes){
//				archEs.Write(client.Cedula);
//				archEs.Write(client.Nombres);
//				archEs.Write(client.Apellido);
//				archEs.Write(client.FechaNacim.Day);
//				archEs.Write(client.FechaNacim.Month);
//				archEs.Write(client.FechaNacim.Year);
//				archEs.Write(client.Direccion);
//				archEs.Write(client.Correo);
//				archEs.Write(client.NumeroCasa);
//				archEs.Write(client.NumeroMovil);
//				archEs.Write(client.FechaRegist.Day);
//				archEs.Write(client.FechaRegist.Month);
//				archEs.Write(client.FechaRegist.Year);
//			}
//			archEs.Close();
//		}
//		
//		public bool recuperar(){
//			if(File.Exists(ruta)){
//				listaClientes.Clear();
//				FileStream arch = new FileStream(ruta, FileMode.Open);
//				BinaryReader archLe = new BinaryReader(arch, Encoding.UTF8);
//				Cliente clientRecup;
//				while (archLe.PeekChar() > -1){
//					clientRecup = recuperarObj(archLe);
//					listaClientes.Add(clientRecup);
//				}
//				archLe.Close();
//				return true;
//			}
//			return false;
//		}
//		
//		public Cliente recuperarObj(BinaryReader ar){
//			
//			DateTime fechaNacimiento = new DateTime(2000, 1, 1);
//			DateTime fechaRegistro = new DateTime(2000, 1, 1);
//			
//			String cedula = ar.ReadString();
//			String nombres = ar.ReadString();
//			String apellido = ar.ReadString();
//			Int32 dayNacim = ar.ReadInt32();
//			Int32 monthNacim = ar.ReadInt32();
//			Int32 yearNacim = ar.ReadInt32();
//			String direccion = ar.ReadString();
//			String correo = ar.ReadString();
//			String numeroCasa = ar.ReadString();
//			String numeroMovil = ar.ReadString();
//			Int32 dayRegist = ar.ReadInt32();
//			Int32 monthRegist = ar.ReadInt32();
//			Int32 yearRegist = ar.ReadInt32();
//			
//			fechaNacimiento = new DateTime(yearNacim, monthNacim, dayNacim);
//			fechaRegistro = new DateTime(yearRegist, monthRegist, dayRegist);
//			
//			Cliente clienteRecuperado = new Cliente(cedula, nombres, apellido, fechaNacimiento, direccion, correo, numeroCasa, numeroMovil, fechaRegistro);
//			return clienteRecuperado;
//		}
	}
}