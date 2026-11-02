namespace JocEducativ
{
	partial class AlegeJoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlegeJoc));
			this.lblWelcome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGhiceste = new System.Windows.Forms.Button();
			this.btnSarpe = new System.Windows.Forms.Button();
			this.dgvGhiceste = new System.Windows.Forms.DataGridView();
			this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puncte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvSarpe = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvGhiceste)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSarpe)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(43, 50);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(87, 40);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(124, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Top scor Ghiceste";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(906, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 35);
			this.label2.TabIndex = 2;
			this.label2.Text = "Top scor Sarpele Educativ";
			// 
			// btnGhiceste
			// 
			this.btnGhiceste.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnGhiceste.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGhiceste.Location = new System.Drawing.Point(174, 516);
			this.btnGhiceste.Name = "btnGhiceste";
			this.btnGhiceste.Size = new System.Drawing.Size(281, 58);
			this.btnGhiceste.TabIndex = 5;
			this.btnGhiceste.Text = "Joaca \"Ghiceste\"!";
			this.btnGhiceste.UseVisualStyleBackColor = false;
			this.btnGhiceste.Click += new System.EventHandler(this.btnGhiceste_Click);
			// 
			// btnSarpe
			// 
			this.btnSarpe.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnSarpe.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSarpe.Location = new System.Drawing.Point(912, 516);
			this.btnSarpe.Name = "btnSarpe";
			this.btnSarpe.Size = new System.Drawing.Size(320, 58);
			this.btnSarpe.TabIndex = 6;
			this.btnSarpe.Text = "Joaca \"Sarpele Educativ\"!";
			this.btnSarpe.UseVisualStyleBackColor = false;
			this.btnSarpe.Click += new System.EventHandler(this.btnSarpe_Click);
			// 
			// dgvGhiceste
			// 
			this.dgvGhiceste.AllowUserToAddRows = false;
			this.dgvGhiceste.AllowUserToDeleteRows = false;
			this.dgvGhiceste.BackgroundColor = System.Drawing.Color.MediumAquamarine;
			this.dgvGhiceste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGhiceste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume,
            this.Mail,
            this.Puncte});
			this.dgvGhiceste.Location = new System.Drawing.Point(26, 188);
			this.dgvGhiceste.Name = "dgvGhiceste";
			this.dgvGhiceste.ReadOnly = true;
			this.dgvGhiceste.RowHeadersWidth = 51;
			this.dgvGhiceste.RowTemplate.Height = 24;
			this.dgvGhiceste.Size = new System.Drawing.Size(572, 301);
			this.dgvGhiceste.TabIndex = 7;
			// 
			// nume
			// 
			this.nume.HeaderText = "Utilizator";
			this.nume.MinimumWidth = 6;
			this.nume.Name = "nume";
			this.nume.ReadOnly = true;
			this.nume.Width = 125;
			// 
			// Mail
			// 
			this.Mail.HeaderText = "Email";
			this.Mail.MinimumWidth = 6;
			this.Mail.Name = "Mail";
			this.Mail.ReadOnly = true;
			this.Mail.Width = 125;
			// 
			// Puncte
			// 
			this.Puncte.HeaderText = "Punctaj";
			this.Puncte.MinimumWidth = 6;
			this.Puncte.Name = "Puncte";
			this.Puncte.ReadOnly = true;
			this.Puncte.Width = 125;
			// 
			// dgvSarpe
			// 
			this.dgvSarpe.AllowUserToAddRows = false;
			this.dgvSarpe.AllowUserToDeleteRows = false;
			this.dgvSarpe.BackgroundColor = System.Drawing.Color.MediumAquamarine;
			this.dgvSarpe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSarpe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dgvSarpe.Location = new System.Drawing.Point(763, 188);
			this.dgvSarpe.Name = "dgvSarpe";
			this.dgvSarpe.ReadOnly = true;
			this.dgvSarpe.RowHeadersWidth = 51;
			this.dgvSarpe.RowTemplate.Height = 24;
			this.dgvSarpe.Size = new System.Drawing.Size(572, 301);
			this.dgvSarpe.TabIndex = 8;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Utilizator";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Email";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Punctaj";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1418, 28);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// iesireToolStripMenuItem
			// 
			this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
			this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.iesireToolStripMenuItem.Text = "Iesire";
			this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
			// 
			// AlegeJoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1418, 596);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dgvSarpe);
			this.Controls.Add(this.dgvGhiceste);
			this.Controls.Add(this.btnSarpe);
			this.Controls.Add(this.btnGhiceste);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblWelcome);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlegeJoc";
			this.Text = "AlegeJoc";
			this.Load += new System.EventHandler(this.AlegeJoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGhiceste)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSarpe)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGhiceste;
		private System.Windows.Forms.Button btnSarpe;
		private System.Windows.Forms.DataGridView dgvGhiceste;
		private System.Windows.Forms.DataGridViewTextBoxColumn nume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puncte;
		private System.Windows.Forms.DataGridView dgvSarpe;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
	}
}