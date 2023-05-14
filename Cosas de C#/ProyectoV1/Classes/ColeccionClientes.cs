using System;
using System.Collections.Generic;

namespace ProyectoV1.Classes
{
	public class ColeccionClientes
	{
		private List<Cliente> listaClientes;
		public List<Cliente> _listaClientes {get {return listaClientes;} set {listaClientes = value;}}
		
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
	}
}