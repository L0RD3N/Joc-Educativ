using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ
{
	public partial class JocEducativ : Form
	{

		public static string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JocEducativ.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection verbindung = new SqlConnection(cnxString);
		public string userName, userEmail;
		public static JocEducativ instance;

		public JocEducativ()
		{
			InitializeComponent();
			instance = this;
		}

		private void FillDB()
		{
			//UTILIZATORI
			//string path = AppDomain.CurrentDomain.BaseDirectory + @"data\utilizatori.txt";
			//StreamReader reader = new StreamReader(path);
			//string line = reader.ReadLine();
			//while (line != null)
			//{
			//	string[] info = line.Split(';');
			//	string email = info[0];
			//	string name = info[1];
			//	string password = info[2];

			//	string cmd = String.Format("INSERT INTO Utilizatori VALUES ('{0}', '{1}', '{2}')", email, name, password);
			//	verbindung.Open();
			//	SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			//	sqlCommand.ExecuteNonQuery();
			//	verbindung.Close();

			//	line = reader.ReadLine();
			//}

			//REZULTATE
			//string path = AppDomain.CurrentDomain.BaseDirectory + @"data\rezultate.txt";
			//StreamReader reader = new StreamReader(path);
			//string line = reader.ReadLine();
			//while (line != null)
			//{
			//	string[] info = line.Split(';');
			//	string type = info[1];
			//	string email = info[2];
			//	string points = info[3];

			//	string cmd = String.Format("INSERT INTO Rezultate VALUES ('{0}', '{1}', '{2}')", type, email, points);
			//	verbindung.Open();
			//	SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			//	sqlCommand.ExecuteNonQuery();
			//	verbindung.Close();

			//	line = reader.ReadLine();
			//}

			//Itemi
			//string path = AppDomain.CurrentDomain.BaseDirectory + @"data\itemi.txt";
			//StreamReader reader = new StreamReader(path);
			//string line = reader.ReadLine();
			//while (line != null)
			//{
			//	string[] info = line.Split(';');
			//	string enunt = info[1];
			//	string a1 = info[2];
			//	string a2 = info[3];
			//	string a3 = info[4];
			//	string c = info[5];
			//	string p = info[6];

			//	string cmd = String.Format("INSERT INTO Itemi VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", enunt, a1, a2, a3, c, p);
			//	verbindung.Open();
			//	SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			//	sqlCommand.ExecuteNonQuery();
			//	verbindung.Close();

			//	line = reader.ReadLine();
			//}

		}
		private void JocEducativ_Load(object sender, EventArgs e)
		{
			//FillDB();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string email = tBoxEmail.Text;
			string password = tBoxPass.Text;

			string cmd = String.Format("SELECT NumeUtilizator FROM Utilizatori WHERE EmailUtilizator = '{0}' AND Parola = '{1}'", email, password);
			verbindung.Open();
			SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			SqlDataReader reader = sqlCommand.ExecuteReader();
			if (reader.Read())
			{
				userName = reader[0].ToString().Trim();
				userEmail = email;
				this.Hide();
				AlegeJoc alegeJoc = new AlegeJoc();
				alegeJoc.Show();
			}
			else
			{
				MessageBox.Show("Date de autentificare invalide!");
				tBoxEmail.Clear();
				tBoxPass.Clear();
			}
			verbindung.Close();
		}

		private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tBoxEmail.Text = "maria@gmail.com";
			tBoxPass.Text = "maria8";
			btnLogin_Click(sender, e);
		}
	}
}
