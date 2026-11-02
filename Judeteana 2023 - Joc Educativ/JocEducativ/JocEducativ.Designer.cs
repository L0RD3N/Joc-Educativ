namespace JocEducativ
{
	partial class JocEducativ
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocEducativ));
			this.btnLogin = new System.Windows.Forms.Button();
			this.tBoxEmail = new System.Windows.Forms.TextBox();
			this.tBoxPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnLogin.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(358, 386);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(179, 70);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Logare";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tBoxEmail
			// 
			this.tBoxEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBoxEmail.Location = new System.Drawing.Point(307, 194);
			this.tBoxEmail.Name = "tBoxEmail";
			this.tBoxEmail.Size = new System.Drawing.Size(311, 32);
			this.tBoxEmail.TabIndex = 1;
			// 
			// tBoxPass
			// 
			this.tBoxPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBoxPass.Location = new System.Drawing.Point(307, 268);
			this.tBoxPass.Name = "tBoxPass";
			this.tBoxPass.PasswordChar = '*';
			this.tBoxPass.Size = new System.Drawing.Size(311, 32);
			this.tBoxPass.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(146, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "E-mail:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(153, 263);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "Parola:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1036, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// iesireToolStripMenuItem
			// 
			this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
			this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.iesireToolStripMenuItem.Text = "Iesire";
			this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(814, 40);
			this.label3.TabIndex = 6;
			this.label3.Text = "Bine ai venit la Joc Educativ! Logheaza-te si distreaza-te invatand!";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(397, 30);
			this.label4.TabIndex = 7;
			this.label4.Text = "^ Poti mereu sa iesi apasand pe acest buton.";
			// 
			// JocEducativ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1036, 564);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tBoxPass);
			this.Controls.Add(this.tBoxEmail);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "JocEducativ";
			this.Text = "Autentificare";
			this.Load += new System.EventHandler(this.JocEducativ_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tBoxEmail;
		private System.Windows.Forms.TextBox tBoxPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

