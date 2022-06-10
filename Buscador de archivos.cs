using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
namespace Menu
{
	public partial class Buscador_de_archivos : Form
	{
		public Buscador_de_archivos()
		{
			InitializeComponent();
		}
		string CarpetaBusquedad = "";

		Computer Ju = new Computer();

		private void btnCarpeta_Click(object sender, EventArgs e)
		{
			//Crear cuadro de Seleccionar carpeta
			FolderBrowserDialog Carpeta = new FolderBrowserDialog();

			//Si la carpeta ha sido elegida
			if (Carpeta.ShowDialog() == DialogResult.OK)
			{
				//Carpeta que hemos seleccionado
				CarpetaBusquedad = Carpeta.SelectedPath;

				//Verificar si es correcto
				MessageBox.Show(CarpetaBusquedad);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (CarpetaBusquedad == "")
			{
				MessageBox.Show("Falta Sleccionar carpeta");
			}
			else
			{
				//Archivos
				for (int i = 0; i < Directory.EnumerateFiles(CarpetaBusquedad).Count(); i++)
				{
					FileInfo k = new FileInfo(Directory.GetFiles(CarpetaBusquedad)[i]);
					if (k.Name == textBox1.Text)
					{
						listBox1.Items.Add("Archivo encontrado en: " + k.FullName);
					}

				}
			}
		}
	}
}
