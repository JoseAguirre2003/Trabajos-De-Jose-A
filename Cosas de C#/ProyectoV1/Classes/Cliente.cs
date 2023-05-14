using System;

namespace ProyectoV1.Classes
{
	public class Cliente
	{
		private String cedula;	
		private String nombres;
		private String apellido;
		private DateTime fechaNacim;
		private String direccion;
		private String correo;
		private String numeroMovil;
		private String numeroCasa;
		private DateTime fechaRegist;
		
		public String Cedula {get { return cedula; }set { cedula = value; }}
		public String Nombres {get { return nombres; }set { nombres = value; }}
		public String Apellido {get { return apellido; }set { apellido = value; }}
		public DateTime FechaNacim {get { return fechaNacim; }set { fechaNacim = value; }}
		public String Direccion {get { return direccion; }set { direccion = value; }}
		public String Correo {get { return correo; }set { correo = value; }}
		public String NumeroMovil {get { return numeroMovil; }set { numeroMovil = value; }}
		public String NumeroCasa {get { return numeroCasa; }set { numeroCasa = value; }}
		public DateTime FechaRegist {get { return fechaRegist; } set { fechaRegist = value; }}
		
		public Cliente(String cedula, String nombres, String apellido, DateTime fechaNacim, String direccion, String correo, String numeroMovil, String numeroCasa, DateTime fechaRegist){
			this.cedula = cedula;
			this.nombres = nombres;
			this.apellido = apellido;
			this.fechaNacim = fechaNacim;
			this.direccion = direccion;
			this.correo = correo;
			this.numeroMovil = numeroMovil;
			this.numeroCasa = numeroCasa;
			this.fechaRegist = fechaRegist;
		}
	}
}