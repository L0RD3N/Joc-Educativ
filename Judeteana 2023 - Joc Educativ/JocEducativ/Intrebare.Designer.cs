namespace JocEducativ
{
	partial class Intrebare
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intrebare));
			this.tBoxQuestion = new System.Windows.Forms.TextBox();
			this.rBtn1 = new System.Windows.Forms.RadioButton();
			this.rBtn2 = new System.Windows.Forms.RadioButton();
			this.rBtn3 = new System.Windows.Forms.RadioButton();
			this.btnAnswer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tBoxQuestion
			// 
			this.tBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBoxQuestion.Location = new System.Drawing.Point(42, 36);
			this.tBoxQuestion.Multiline = true;
			this.tBoxQuestion.Name = "tBoxQuestion";
			this.tBoxQuestion.ReadOnly = true;
			this.tBoxQuestion.Size = new System.Drawing.Size(1162, 213);
			this.tBoxQuestion.TabIndex = 0;
			// 
			// rBtn1
			// 
			this.rBtn1.AutoSize = true;
			this.rBtn1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtn1.Location = new System.Drawing.Point(59, 275);
			this.rBtn1.Name = "rBtn1";
			this.rBtn1.Size = new System.Drawing.Size(197, 44);
			this.rBtn1.TabIndex = 1;
			this.rBtn1.TabStop = true;
			this.rBtn1.Text = "radioButton1";
			this.rBtn1.UseVisualStyleBackColor = true;
			this.rBtn1.CheckedChanged += new System.EventHandler(this.rBtn1_CheckedChanged);
			// 
			// rBtn2
			// 
			this.rBtn2.AutoSize = true;
			this.rBtn2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtn2.Location = new System.Drawing.Point(59, 351);
			this.rBtn2.Name = "rBtn2";
			this.rBtn2.Size = new System.Drawing.Size(197, 44);
			this.rBtn2.TabIndex = 2;
			this.rBtn2.TabStop = true;
			this.rBtn2.Text = "radioButton2";
			this.rBtn2.UseVisualStyleBackColor = true;
			this.rBtn2.CheckedChanged += new System.EventHandler(this.rBtn2_CheckedChanged);
			// 
			// rBtn3
			// 
			this.rBtn3.AutoSize = true;
			this.rBtn3.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtn3.Location = new System.Drawing.Point(59, 430);
			this.rBtn3.Name = "rBtn3";
			this.rBtn3.Size = new System.Drawing.Size(197, 44);
			this.rBtn3.TabIndex = 3;
			this.rBtn3.TabStop = true;
			this.rBtn3.Text = "radioButton3";
			this.rBtn3.UseVisualStyleBackColor = true;
			this.rBtn3.CheckedChanged += new System.EventHandler(this.rBtn3_CheckedChanged);
			// 
			// btnAnswer
			// 
			this.btnAnswer.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnAnswer.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnswer.Location = new System.Drawing.Point(59, 527);
			this.btnAnswer.Name = "btnAnswer";
			this.btnAnswer.Size = new System.Drawing.Size(285, 74);
			this.btnAnswer.TabIndex = 4;
			this.btnAnswer.Text = "Inregistreaza raspuns";
			this.btnAnswer.UseVisualStyleBackColor = false;
			this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// Intrebare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1393, 636);
			this.Controls.Add(this.btnAnswer);
			this.Controls.Add(this.rBtn3);
			this.Controls.Add(this.rBtn2);
			this.Controls.Add(this.rBtn1);
			this.Controls.Add(this.tBoxQuestion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Intrebare";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Intrebare";
			this.Load += new System.EventHandler(this.Intrebare_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tBoxQuestion;
		private System.Windows.Forms.RadioButton rBtn1;
		private System.Windows.Forms.RadioButton rBtn2;
		private System.Windows.Forms.RadioButton rBtn3;
		private System.Windows.Forms.Button btnAnswer;
	}
}