namespace Menu
{
	partial class Menu
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.Color.DarkOrchid;
			this.Login.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login.ForeColor = System.Drawing.Color.White;
			this.Login.Location = new System.Drawing.Point(45, 40);
			this.Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(129, 82);
			this.Login.TabIndex = 0;
			this.Login.Text = "Login";
			this.Login.UseVisualStyleBackColor = false;
			this.Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkOrchid;
			this.button1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(45, 170);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 82);
			this.button1.TabIndex = 1;
			this.button1.Text = "Buscador de archivos";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkOrchid;
			this.button2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(45, 306);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 82);
			this.button2.TabIndex = 2;
			this.button2.Text = "Editor de imagenes";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkOrchid;
			this.button3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(513, 40);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 82);
			this.button3.TabIndex = 3;
			this.button3.Text = "Reproductor de musica";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DarkOrchid;
			this.button4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(513, 170);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(147, 82);
			this.button4.TabIndex = 4;
			this.button4.Text = "Lector de archivos xml";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DarkOrchid;
			this.button5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(496, 294);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(178, 107);
			this.button5.TabIndex = 5;
			this.button5.Text = "Abrir archvios de word, power point y excel";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(740, 427);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Login);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

