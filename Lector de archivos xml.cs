using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Menu
{
	public partial class Lecotr_de_archivos_xml : Form
	{
		public Lecotr_de_archivos_xml()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			XmlTextReader xmlTextReader = new XmlTextReader("C:\\xmlSample\\archivo.xml");
			string ultimaEtiqueta = "";
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType == XmlNodeType.Element)
				{
					richTextBox1.Text += (new String(' ', xmlTextReader.Depth * 3) + "<" + xmlTextReader.Name + ">");
					ultimaEtiqueta = xmlTextReader.Name;
					continue;

				}
				if (xmlTextReader.NodeType == XmlNodeType.Text)
				{
					richTextBox1.Text += xmlTextReader.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
				}
				else
					richTextBox1.Text += "\r";
			}

		}
	}
}