using System;

namespace ProyectoV2.Classes
{
	public class DVD
	{	
		private String code;
		private String title;
		private DateTime fabricDate;
		private String type;
		private String descrip;		
		private Int16 cantidad;
		private DateTime ingresDate;
		private string imgRuta;
		
		public String _code {get {return code;} set {code = value;}}
		public String _title {get {return title;} set {title = value;}}
		public DateTime _fabricDate {get {return fabricDate;} set {fabricDate = value;}}
		public String _type {get {return type;} set {type = value;}}
		public String _descrip {get {return descrip;} set {descrip = value;}}
		public Int16 _cantidad {get {return cantidad;} set {cantidad = value;}}
		public DateTime _ingresDate {get {return ingresDate;} set {ingresDate = value;}}
		public string _imgRuta {get {return imgRuta;} set {imgRuta = value;}}
		
		public DVD(String code, String title, DateTime fabricDate, String type, String descrip, Int16 cantidad, DateTime ingresDate, string imgRuta){	
			this.code = code;
			this.title = title;
			this.fabricDate = fabricDate;
			this.type = type;
			this.descrip = descrip;
			this.cantidad = cantidad;
			this.ingresDate = ingresDate;
			this.imgRuta = imgRuta;
		}
	}
}