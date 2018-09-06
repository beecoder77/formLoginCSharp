namespace latihanlogin
{
	partial class login
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
			this.passs = new System.Windows.Forms.TextBox();
			this.Masuk = new System.Windows.Forms.Button();
			this.Keluar = new System.Windows.Forms.Button();
			this.Pass = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.Label();
			this.uname = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// passs
			// 
			this.passs.Location = new System.Drawing.Point(113, 97);
			this.passs.Name = "passs";
			this.passs.Size = new System.Drawing.Size(207, 20);
			this.passs.TabIndex = 1;
			// 
			// Masuk
			// 
			this.Masuk.Location = new System.Drawing.Point(152, 133);
			this.Masuk.Name = "Masuk";
			this.Masuk.Size = new System.Drawing.Size(59, 37);
			this.Masuk.TabIndex = 2;
			this.Masuk.Text = "Masuk";
			this.Masuk.UseVisualStyleBackColor = true;
			this.Masuk.Click += new System.EventHandler(this.Masuk_Click);
			// 
			// Keluar
			// 
			this.Keluar.Location = new System.Drawing.Point(217, 133);
			this.Keluar.Name = "Keluar";
			this.Keluar.Size = new System.Drawing.Size(59, 37);
			this.Keluar.TabIndex = 3;
			this.Keluar.Text = "Keluar";
			this.Keluar.UseVisualStyleBackColor = true;
			this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
			// 
			// Pass
			// 
			this.Pass.AutoSize = true;
			this.Pass.Location = new System.Drawing.Point(46, 100);
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(59, 13);
			this.Pass.TabIndex = 5;
			this.Pass.Text = "Password :";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Location = new System.Drawing.Point(46, 71);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(61, 13);
			this.username.TabIndex = 6;
			this.username.Text = "Username :";
			// 
			// uname
			// 
			this.uname.Location = new System.Drawing.Point(113, 71);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(207, 20);
			this.uname.TabIndex = 1;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 191);
			this.Controls.Add(this.uname);
			this.Controls.Add(this.username);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.Keluar);
			this.Controls.Add(this.Masuk);
			this.Controls.Add(this.passs);
			this.Name = "login";
			this.Text = "Login Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox passs;
		private System.Windows.Forms.Button Masuk;
		private System.Windows.Forms.Button Keluar;
		private System.Windows.Forms.Label Pass;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.TextBox uname;
	}
}

