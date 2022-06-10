using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Menu
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		public void Logins()
		{
			try
			{
				string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
				using (SqlConnection conexion = new SqlConnection(cnn))
				{
					conexion.Open();
					using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM usuarios WHERE usuarios='" + txtUsuario.Text + "' AND pass='" + txtContraseña.Text + "'", conexion))
					{
						SqlDataReader dr = cmd.ExecuteReader();

						if (dr.Read())
						{
							MessageBox.Show("Login exitoso.");
						}
						else
						{
							MessageBox.Show("Datos incorrectos");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnEnter_Click_1(object sender, EventArgs e)
		{
			Logins();
		}
	}
}