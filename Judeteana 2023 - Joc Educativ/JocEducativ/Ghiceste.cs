using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ
{
	public partial class Ghiceste : Form
	{

		public static string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JocEducativ.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection verbindung = new SqlConnection(cnxString);
		string userEmail;
		List <string> words = new List <string>();
		List<string> masks = new List<string>();
		int idx, score = 100, stage = 6, wrongs = 0;
		string wordUncover = "";
		public Ghiceste()
		{
			InitializeComponent();
			userEmail = JocEducativ.instance.userEmail;
		}

		private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Ghiceste_Load(object sender, EventArgs e)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + @"data\cuvinte.txt";
			StreamReader streamReader = new StreamReader(path);
			string line = streamReader.ReadLine();
			while (line != null)
			{

				string x = "";
				line = line.ToUpper();
				for (int i = 0; i < line.Length; i ++)
				{
					x += line[i];
					x += " ";
				}
				words.Add(x);

				//string mask = "";
				//for (int i = 0; i < line.Length; i ++)
				//{
				//	if (Char.IsLetter(line[i]))
				//	{
				//		mask += '_';
				//	}

				//}
				//masks.Add(mask);
				line = streamReader.ReadLine();
			}
			Random rnd = new Random();
			idx = rnd.Next(0, words.Count);
			PutWord(idx);
			MessageBox.Show(words[idx]);
			lblScore.Text = "Punctaj: " + score.ToString();
		}

		private void PutWord(int idx)
		{
			string s = "";
			for (int i = 0; i < words[idx].Length; i++)
			{
				if (Char.IsLetter(words[idx][i]))
					s += "_";
				else
					s += " ";
			}
			lblWord.Text = s;
			wordUncover = s;
		}

		private int CheckLetter (char c)
		{
			string s = "";
			int ok = 0;
			bool won = true;

			for (int i = 0; i < words[idx].Length; i ++)
			{
				if (words[idx][i] == c)
				{
					wordUncover = wordUncover.Remove(i, 1);
					wordUncover = wordUncover.Insert(i, c.ToString());
					ok = 1;
				}

			}

			lblWord.Text = wordUncover;

			for (int i = 0; i < wordUncover.Length; i++)
			{
				if (wordUncover[i] == '_')
				{
					won = false;
				}
			}

			if (won)
			{
				return 2;
			}

			return ok;
		}

		private void registrateScore(int score)
		{
			string cmd = String.Format("INSERT INTO Rezultate VALUES ('{0}', '{1}', '{2}')", 0, userEmail, score);
			verbindung.Open();
			SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			sqlCommand.ExecuteNonQuery();
			verbindung.Close();
		}

		private void btnA_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			this.Controls.Remove(btn);

			if (CheckLetter(btn.Text[0]) == 2)
			{
				MessageBox.Show("Ai castigat! Scorul tau a fost inregistrat!");
				registrateScore(score);
				this.Hide();
				AlegeJoc alegeJoc = new AlegeJoc();
				alegeJoc.Show();
				return;

			}

			if (CheckLetter(btn.Text[0]) == 1)
			{
				//MessageBox.Show("Corect!");
				lblScore.Text = "Punctaj: " + score.ToString();
			}

			else
			{ 
				//MessageBox.Show("Incorect!");
				stage--;

				if (stage > 0)
				{
					wrongs++;
					score = score - 4 * wrongs;
					lblScore.Text = "Punctaj: " + score.ToString();
					string path = AppDomain.CurrentDomain.BaseDirectory + @"images\" + stage.ToString() + ".png";
					pBoxFlower.Image = Image.FromFile(path);
				}
				else
				{
					score = 0;
					lblScore.Text = "Punctaj: " + score.ToString();
					MessageBox.Show("Ai pierdut! Scorul tau a fost inregistrat! Mai mult noroc data viitoare!");
					registrateScore(score);
					this.Hide();
					AlegeJoc alegeJoc = new AlegeJoc();
					alegeJoc.Show();
					return;
				}
			}

		}
	}
}
