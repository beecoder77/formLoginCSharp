using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihanlogin
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void Masuk_Click(object sender, EventArgs e)
		{
			if (uname.Text == "")
			{
				MessageBox.Show("Harap Masukan Username Bosss");
			}
			else if(passs.Text == "")
			{
				MessageBox.Show("Harap Masukan Password Bosss");
			}
			if(uname.Text == ("salman") && (passs.Text == ("admin")))
			{
				MessageBox.Show("Login Sukses !");
				
				Form2 login = new Form2();
				this.Close();
				login.Show();
			}
			else
			{
				MessageBox.Show("Username atau Password salah !");
			}
		}

		private void Keluar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
