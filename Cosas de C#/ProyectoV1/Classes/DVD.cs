using System;

namespace ProyectoV1.Classes
{
	public class DVD
	{	
		private String code;
		private String title;
		private DateTime manuDate;
		private String type;
		private String descript;		
		private Int16 amount;
		private DateTime adDate;
		private string imgPath;
		
		public String _code {get {return code;} set {code = value;}}
		public String _title {get {return title;} set {title = value;}}
		public DateTime _manuDate {get {return manuDate;} set {manuDate = value;}}
		public String _type {get {return type;} set {type = value;}}
		public String _descript {get {return descript;} set {descript = value;}}
		public Int16 _amount {get {return amount;} set {amount = value;}}
		public DateTime _adDate {get {return adDate;} set {adDate = value;}}
		public string _imgPath {get {return imgPath;} set {imgPath = value;}}
		
		public DVD(String code, String title, DateTime manuDate, String type, String descript, Int16 amount, DateTime adDate, string imgPath){	
			this.code = code;
			this.title = title;
			this.manuDate = manuDate;
			this.type = type;
			this.descript = descript;
			this.amount = amount;
			this.adDate = adDate;
			this.imgPath = imgPath;
		}
	}
}