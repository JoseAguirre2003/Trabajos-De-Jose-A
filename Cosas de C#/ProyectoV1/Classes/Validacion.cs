using System;
using System.Text.RegularExpressions;

namespace ProyectoV1.Classes
{
	static public class Validacion
	{
		static public bool validarTxtVacio(String texto){
			if(texto.Trim() == "")
				return false;
			return true;
		}
		
		static public bool validarNum(decimal num, decimal numMin, decimal numMax){
			if (num < numMin || num > numMax)
				return false;
			return true;
		}
		
		static public bool validarFechaFutura(DateTime fecha){
			if(fecha > DateTime.Now)
				return false;
			return true;
		}
		
		static public bool validarFechaPasada(DateTime fecha){
			if(fecha < DateTime.Now)
				return false;
			return true;
		}
		
		static public bool validarFechaRango(DateTime fecha, DateTime fechaMin, DateTime fechaMax){
			if(fecha < fechaMin || fecha > fechaMax)
				return false;
			return true;
		}
		
		static public bool validarCorreo(string email){	
			Regex formaCorreo = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
			return formaCorreo.IsMatch(email);
		}
		
	}
}