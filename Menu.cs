using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Login_Click(object sender, EventArgs e)
		{
			Form Login = new Login();
			Login.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form Buscador_de_archivos = new Buscador_de_archivos();
			Buscador_de_archivos.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form Editor_de_imagenes = new Editor_de_imagenes();
			Editor_de_imagenes.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form Lector_de_archivos_xml = new Lecotr_de_archivos_xml();
			Lector_de_archivos_xml.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form Abrir_archvios_de_word_power_point_y_excel = new Abrir_archivos_de_word__power_point_y_excel();
			Abrir_archvios_de_word_power_point_y_excel.Show();
		}
	}
}
