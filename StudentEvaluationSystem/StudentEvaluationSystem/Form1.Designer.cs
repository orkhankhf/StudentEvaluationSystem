﻿namespace StudentEvaluationSystem
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Window_Close_Btn = new System.Windows.Forms.Button();
			this.Main_Logo = new System.Windows.Forms.PictureBox();
			this.Teacher_Login_Btn = new System.Windows.Forms.Button();
			this.Mentor_Login_Btn = new System.Windows.Forms.Button();
			this.Student_Login_Btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Main_Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// Window_Close_Btn
			// 
			this.Window_Close_Btn.BackColor = System.Drawing.Color.LightCoral;
			this.Window_Close_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Close_Btn.BackgroundImage")));
			this.Window_Close_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Window_Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Window_Close_Btn.FlatAppearance.BorderSize = 0;
			this.Window_Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Window_Close_Btn.Location = new System.Drawing.Point(754, 0);
			this.Window_Close_Btn.Name = "Window_Close_Btn";
			this.Window_Close_Btn.Size = new System.Drawing.Size(46, 25);
			this.Window_Close_Btn.TabIndex = 0;
			this.Window_Close_Btn.UseVisualStyleBackColor = false;
			this.Window_Close_Btn.Click += new System.EventHandler(this.Window_Close_Btn_Click);
			// 
			// Main_Logo
			// 
			this.Main_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main_Logo.BackgroundImage")));
			this.Main_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Main_Logo.ImageLocation = "";
			this.Main_Logo.Location = new System.Drawing.Point(117, 40);
			this.Main_Logo.Name = "Main_Logo";
			this.Main_Logo.Size = new System.Drawing.Size(566, 138);
			this.Main_Logo.TabIndex = 1;
			this.Main_Logo.TabStop = false;
			// 
			// Teacher_Login_Btn
			// 
			this.Teacher_Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(205)))));
			this.Teacher_Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Teacher_Login_Btn.FlatAppearance.BorderSize = 0;
			this.Teacher_Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Teacher_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Teacher_Login_Btn.ForeColor = System.Drawing.Color.White;
			this.Teacher_Login_Btn.Location = new System.Drawing.Point(260, 216);
			this.Teacher_Login_Btn.Name = "Teacher_Login_Btn";
			this.Teacher_Login_Btn.Size = new System.Drawing.Size(280, 50);
			this.Teacher_Login_Btn.TabIndex = 1;
			this.Teacher_Login_Btn.Text = "Teacher Login";
			this.Teacher_Login_Btn.UseVisualStyleBackColor = false;
			this.Teacher_Login_Btn.Click += new System.EventHandler(this.Teacher_Login_Btn_Click);
			// 
			// Mentor_Login_Btn
			// 
			this.Mentor_Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
			this.Mentor_Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Mentor_Login_Btn.FlatAppearance.BorderSize = 0;
			this.Mentor_Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Mentor_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Mentor_Login_Btn.ForeColor = System.Drawing.Color.White;
			this.Mentor_Login_Btn.Location = new System.Drawing.Point(260, 272);
			this.Mentor_Login_Btn.Name = "Mentor_Login_Btn";
			this.Mentor_Login_Btn.Size = new System.Drawing.Size(280, 50);
			this.Mentor_Login_Btn.TabIndex = 2;
			this.Mentor_Login_Btn.Text = "Mentor Login";
			this.Mentor_Login_Btn.UseVisualStyleBackColor = false;
			// 
			// Student_Login_Btn
			// 
			this.Student_Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(36)))));
			this.Student_Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Student_Login_Btn.FlatAppearance.BorderSize = 0;
			this.Student_Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Student_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Student_Login_Btn.ForeColor = System.Drawing.Color.White;
			this.Student_Login_Btn.Location = new System.Drawing.Point(260, 328);
			this.Student_Login_Btn.Name = "Student_Login_Btn";
			this.Student_Login_Btn.Size = new System.Drawing.Size(280, 50);
			this.Student_Login_Btn.TabIndex = 3;
			this.Student_Login_Btn.Text = "Mentor Login";
			this.Student_Login_Btn.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.Student_Login_Btn);
			this.Controls.Add(this.Mentor_Login_Btn);
			this.Controls.Add(this.Teacher_Login_Btn);
			this.Controls.Add(this.Main_Logo);
			this.Controls.Add(this.Window_Close_Btn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Main_Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Window_Close_Btn;
		private System.Windows.Forms.PictureBox Main_Logo;
		private System.Windows.Forms.Button Teacher_Login_Btn;
		private System.Windows.Forms.Button Mentor_Login_Btn;
		private System.Windows.Forms.Button Student_Login_Btn;
	}
}

