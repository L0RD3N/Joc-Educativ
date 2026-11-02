namespace JocEducativ
{
	partial class Sarpe
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sarpe));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblScore = new System.Windows.Forms.Label();
			this.timerGame = new System.Windows.Forms.Timer(this.components);
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.pBoxGame = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1152, 28);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// iesireToolStripMenuItem
			// 
			this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
			this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.iesireToolStripMenuItem.Text = "Iesire";
			this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(752, 147);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(73, 35);
			this.lblScore.TabIndex = 40;
			this.lblScore.Text = "SCOR";
			// 
			// timerGame
			// 
			this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnStart.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(736, 313);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(158, 59);
			this.btnStart.TabIndex = 42;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Crimson;
			this.btnStop.Enabled = false;
			this.btnStop.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.Location = new System.Drawing.Point(736, 393);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(158, 59);
			this.btnStop.TabIndex = 43;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// pBoxGame
			// 
			this.pBoxGame.BackColor = System.Drawing.Color.Black;
			this.pBoxGame.Location = new System.Drawing.Point(24, 64);
			this.pBoxGame.Name = "pBoxGame";
			this.pBoxGame.Size = new System.Drawing.Size(500, 600);
			this.pBoxGame.TabIndex = 44;
			this.pBoxGame.TabStop = false;
			this.pBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
			// 
			// Sarpe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1152, 686);
			this.Controls.Add(this.pBoxGame);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Sarpe";
			this.Text = "Sarpe";
			this.Load += new System.EventHandler(this.Sarpe_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sarpe_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Timer timerGame;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.PictureBox pBoxGame;
	}
}