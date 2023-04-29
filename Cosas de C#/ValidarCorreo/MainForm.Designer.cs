/*
 * Creado por SharpDevelop.
 * Usuario: Vladi1000
 * Fecha: 28/04/2023
 * Hora: 08:35 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ValidarCorreo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnValidar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnValidar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 125);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 2;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 175);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 20);
			this.textBox4.TabIndex = 3;
			// 
			// btnValidar
			// 
			this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnValidar.FlatAppearance.BorderSize = 0;
			this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnValidar.Location = new System.Drawing.Point(172, 213);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(100, 37);
			this.btnValidar.TabIndex = 4;
			this.btnValidar.Text = "Validar";
			this.btnValidar.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(268, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "label3";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(260, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "label4";
			this.label4.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "ValidarCorreo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
