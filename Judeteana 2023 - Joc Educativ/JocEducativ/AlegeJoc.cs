using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ
{
	public partial class AlegeJoc : Form
	{

		public static string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JocEducativ.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection verbindung = new SqlConnection(cnxString);
		public static string userName, userEmail;
		List <string> emails = new List <string> ();
		List<string> points = new List<string>();
		List<string> users = new List<string>();

		public AlegeJoc()
		{
			InitializeComponent();
			userName = JocEducativ.instance.userName;
			userEmail = JocEducativ.instance.userEmail;
		}

		public void FillDGV()
		{
			string cmd = String.Format("SELECT EmailUtilizator, PunctajJoc FROM Rezultate WHERE TipJoc = '0' ORDER BY PunctajJoc DESC");
			SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			verbindung.Open();
			SqlDataReader reader = sqlCommand.ExecuteReader();
			int cnt = 0;
			while (reader.Read())
			{
				if (cnt < 3)
				{
					emails.Add(reader[0].ToString());
					points.Add(reader[1].ToString());
					cnt++;
				}
				
			}
			verbindung.Close();

			foreach (string email in emails)
			{
				cmd = String.Format("SELECT NumeUtilizator FROM Utilizatori WHERE EmailUtilizator = '{0}'", email);
				sqlCommand = new SqlCommand(cmd, verbindung);
				verbindung.Open();
				reader = sqlCommand.ExecuteReader();
				while (reader.Read())
				{
					users.Add(reader[0].ToString());
				}
				verbindung.Close();
			}

			dgvGhiceste.RowCount = 3;
			dgvGhiceste.ColumnCount = 3;
			for (int i = 0; i < 3; i ++)
			{
				dgvGhiceste[0, i].Value = users[i];
				dgvGhiceste[1, i].Value = emails[i];
				dgvGhiceste[2, i].Value = points[i];
			}

			//SARPE
			emails.Clear();
			points.Clear();
			users.Clear();

			cmd = String.Format("SELECT EmailUtilizator, PunctajJoc FROM Rezultate WHERE TipJoc = '1' ORDER BY PunctajJoc DESC");
			sqlCommand = new SqlCommand(cmd, verbindung);
			verbindung.Open();
			reader = sqlCommand.ExecuteReader();
			cnt = 0;
			while (reader.Read())
			{
				if (cnt < 3)
				{
					emails.Add(reader[0].ToString());
					points.Add(reader[1].ToString());
					cnt++;
				}

			}
			verbindung.Close();

			foreach (string email in emails)
			{
				cmd = String.Format("SELECT NumeUtilizator FROM Utilizatori WHERE EmailUtilizator = '{0}'", email);
				sqlCommand = new SqlCommand(cmd, verbindung);
				verbindung.Open();
				reader = sqlCommand.ExecuteReader();
				while (reader.Read())
				{
					users.Add(reader[0].ToString());
				}
				verbindung.Close();
			}

			dgvSarpe.RowCount = 3;
			dgvSarpe.ColumnCount = 3;
			for (int i = 0; i < 3; i++)
			{
				dgvSarpe[0, i].Value = users[i];
				dgvSarpe[1, i].Value = emails[i];
				dgvSarpe[2, i].Value = points[i];
			}

		}

		private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnGhiceste_Click(object sender, EventArgs e)
		{
			this.Hide();
			Ghiceste ghiceste = new Ghiceste();
			ghiceste.Show();
		}

		private void btnSarpe_Click(object sender, EventArgs e)
		{
			this.Hide();
			Sarpe sarpe = new Sarpe();
			sarpe.Show();
		}

		private void AlegeJoc_Load(object sender, EventArgs e)
		{
			lblWelcome.Text = "Bine ai venit, " + userName + "! " + "(" + userEmail + ")";
			FillDGV();
		}
	}
}
