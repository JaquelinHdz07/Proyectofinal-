namespace Menu
{
	partial class Login
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
			this.btnEnter = new System.Windows.Forms.Button();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(42, 228);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(80, 39);
			this.btnEnter.TabIndex = 0;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(42, 163);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(220, 26);
			this.txtContraseña.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "User:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(42, 71);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(220, 26);
			this.txtUsuario.TabIndex = 4;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 328);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.btnEnter);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
	}
}