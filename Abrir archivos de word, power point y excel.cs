using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Menu
{
	public partial class Abrir_archivos_de_word__power_point_y_excel : Form
	{
		public Abrir_archivos_de_word__power_point_y_excel()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("WINWORD.EXE");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Users\Marlene\Documents\Ingenieria Informatica\Informatica 1er semestre\Trabajos de Administracion\preguntas balanced scorecard.docx");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("EXCEL.EXE");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Process.Start("POWERPNT.EXE");
		}
	}
}
