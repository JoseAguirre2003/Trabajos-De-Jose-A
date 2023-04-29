using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidarCorreo
{
	public partial class MainForm : Form
	{
		List<TextBox> textBoxs = new List<TextBox>();
		List<Label> labels = new List<Label>();
			
		public MainForm()
		{
			InitializeComponent();
			textBoxs.Add(textBox1);
			labels.Add(label1);
			textBoxs.Add(textBox2);
			labels.Add(label2);
			textBoxs.Add(textBox3);
			labels.Add(label3);
			textBoxs.Add(textBox4);
			labels.Add(label4);
			
			btnValidar.Click += new EventHandler(ValidarCorreos);
		}
		
		public void ValidarCorreos(object sender, EventArgs e){		
		    for (int i = 0; i < textBoxs.Count; i++) { 	
				if(!validarCorreo(textBoxs[i].Text)){
					labels[i].Visible = true;
					labels[i].Text = "EL correo no esta en un formato valido";
					labels[i].ForeColor = Color.Red;
				}else{
					labels[i].Text = "El correo es valido";
					labels[i].Visible = true;
					labels[i].ForeColor = Color.Green;
				}
		    }	
		}
		
		public bool validarCorreo(string email){	
			Regex formaCorreo = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
			return formaCorreo.IsMatch(email);
		}
		
	}
}
