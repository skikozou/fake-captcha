﻿namespace captcha
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			pictureBox1 = new PictureBox();
			button2 = new Button();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(719, 373);
			button1.Name = "button1";
			button1.Size = new Size(187, 70);
			button1.TabIndex = 0;
			button1.Text = "Gen";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(894, 350);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.Location = new Point(12, 368);
			button2.Name = "button2";
			button2.Size = new Size(63, 30);
			button2.TabIndex = 2;
			button2.Text = "check";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(81, 373);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(175, 23);
			textBox1.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(918, 450);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(pictureBox1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private PictureBox pictureBox1;
		private Button button2;
		private TextBox textBox1;
	}
}
