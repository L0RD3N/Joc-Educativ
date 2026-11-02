using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocEducativ
{
	public partial class Sarpe : Form
	{

		public static string cnxString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\JocEducativ.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection verbindung = new SqlConnection(cnxString);
		string userEmail;
		List <Circle> snake = new List <Circle> ();
		bool up = false, down = true, left = false, right = false;
		public int playerScore = 0;
		Circle food;
		Graphics graphics;
		public static Sarpe instance;

		public Sarpe()
		{
			InitializeComponent();
			graphics = pBoxGame.CreateGraphics ();
			userEmail = JocEducativ.instance.userEmail;
			instance = this;
		}

		private void registrateScore(int score)
		{
			string cmd = String.Format("INSERT INTO Rezultate VALUES ('{0}', '{1}', '{2}')", 1, userEmail, score);
			verbindung.Open();
			SqlCommand sqlCommand = new SqlCommand(cmd, verbindung);
			sqlCommand.ExecuteNonQuery();
			verbindung.Close();
		}

		private void timerGame_Tick(object sender, EventArgs e)
		{
			CheckDirection();

			for (int i = snake.Count - 1; i > 0; i --)
				{ snake[i].x = snake[i - 1].x; snake[i].y = snake[i - 1].y; }

			checkIntersection();
			pBoxGame.Invalidate();
		}

		private void placeFood()
		{
			food = new Circle(2, 2, Color.Red);
			Random random = new Random();
			food.x = random.Next(1, 500 / 20 - 10);
			food.y = random.Next(1, 600 / 20 - 10);
		}

		public void StartTimer()
		{
			timerGame.Start();
			lblScore.Text = "Punctaj: " + playerScore.ToString();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			btnStart.Visible = false;
			btnStop.Enabled = true;

			snake.Add(new Circle(2, 2, Color.White));
			placeFood();
			timerGame.Start();
			
		}

		private void panelGame_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			for (int i = snake.Count - 1; i >= 0; i --)
			{
				snake[i].drawCircle(g);
			}

			if (timerGame.Enabled)
			{
				food.drawCircle(g);
			}
		}

		private void Sarpe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W && down == false)
			{ up = true; down = false; right = false; left = false; }

			if (e.KeyCode == Keys.S && up == false)
			{ down = true; up = false; right = false; left = false; }

			if (e.KeyCode == Keys.A && right == false)
			{ left = true; up = false; right = false; down = false; }

			if ( e.KeyCode == Keys.D && left == false)
			{ right = true; left = false; up = false; down = false; }

		}

		private void Sarpe_Load(object sender, EventArgs e)
		{
			lblScore.Text = "Punctaj: " + playerScore.ToString();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timerGame.Stop();
			MessageBox.Show("Jocul s-a oprit! Scorul tau a fost inregistrat!");
			registrateScore(playerScore);
			this.Hide();
			AlegeJoc alegeJoc = new AlegeJoc();
			alegeJoc.Show();
		}

		public void CheckDirection()
		{
			if (up == true)
			{
				if (snake[0].y > 0)
					snake[0].y--;
				else
				{ timerGame.Stop(); MessageBox.Show("Ai murit! Scorul tau a fost inregistrat!"); registrateScore(playerScore); return; }
			}
				

			if (down == true)
			{
				if (snake[0].y < 600 / 20 - 7)
					snake[0].y++;
				else
					{ timerGame.Stop(); MessageBox.Show("Ai murit! Scorul tau a fost inregistrat!"); registrateScore(playerScore); return; }
			}

			if (left == true)
			{
				if (snake[0].x > 0)
					snake[0].x--;
				else
				{ timerGame.Stop(); MessageBox.Show("Ai murit! Scorul tau a fost inregistrat!"); registrateScore(playerScore); return; }
			}

			if (right == true)
			{
				if (snake[0].x < 500 / 20 - 7)
					snake[0].x++;

				else
				{ timerGame.Stop(); MessageBox.Show("Ai murit! Scorul tau a fost inregistrat!"); registrateScore(playerScore); return; }
			}

		}
		private void checkIntersection()
		{

			if (snake[0].x == food.x && snake[0].y == food.y)
			{
				placeFood();
				food.drawCircle(graphics);
				snake.Add(new Circle(snake[snake.Count - 1].x - 1, snake[snake.Count - 1].y - 1, Color.ForestGreen));
				timerGame.Stop();
				//this.Hide();
				Intrebare intrebare = new Intrebare();
				intrebare.Show();
				
			}

			//for (int i = snake.Count - 2; i >= 0; i--)
			//{
			//	for (int j = i + 1 ; j < snake.Count ; j++)
			//	{
			//			if (snake[i].x == snake[j].x && snake[i].y == snake[j].y)
			//			{
			//				MessageBox.Show("Ai murit!");
			//				this.Hide();
			//				AlegeJoc alegeJoc = new AlegeJoc();
			//				alegeJoc.Show();
			//				return;
			//			}
			//	}
			//}

		}

		private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
