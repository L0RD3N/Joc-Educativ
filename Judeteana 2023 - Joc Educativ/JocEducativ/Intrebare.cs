using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ
{
	public partial class Intrebare : Form
	{

		public static string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JocEducativ.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection verbindung = new SqlConnection(cnxString);
		string correct = "", points, answer;
		public static int score;
		public static Intrebare instance2;
		public static bool done = false;

		public Intrebare()
		{
			InitializeComponent();
			instance2 = this;
			score = Sarpe.instance.playerScore;
		}

		private void rBtn2_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void rBtn3_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{

			if (rBtn1.Checked)
			{
				answer = "1";
			}

			else if (rBtn2.Checked)
				answer = "2";

			else if (rBtn3.Checked)
				answer = "3";

			if (answer == correct)
			{
				MessageBox.Show("Felicitari, ai raspuns corect!");
				score += int.Parse(points);
			}

			else
			{

				MessageBox.Show ("Raspunusl tau este gresit! Raspunsul corect este " +  correct);
			}

			this.Hide();
			Sarpe.instance.playerScore = score;
			Sarpe.instance.StartTimer();

		}

		private void Intrebare_Load(object sender, EventArgs e)
		{
			Random random = new Random();
			int idx = random.Next(1, 21);
			
			verbindung.Open();
			string cmd = String.Format("SELECT * FROM Itemi WHERE idItem = '{0}'", idx);
			SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				tBoxQuestion.Text = sqlDataReader[1].ToString().Trim();
				rBtn1.Text = sqlDataReader[2].ToString();
				rBtn2.Text = sqlDataReader[3].ToString();	
				rBtn3.Text = sqlDataReader[4].ToString();
				correct = sqlDataReader[5].ToString();
				points = sqlDataReader[6].ToString();
			}
			verbindung.Close();
		}

		private void rBtn1_CheckedChanged(object sender, EventArgs e)
		{
			
		}

	}
}
