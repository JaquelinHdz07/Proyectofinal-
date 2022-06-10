namespace Menu
{
	partial class WinReproductorMp3
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
			this.components = new System.ComponentModel.Container();
			this.MsTitulo = new System.Windows.Forms.MenuStrip();
			this.TStripMenuItemArchivos = new System.Windows.Forms.ToolStripMenuItem();
			this.TStripMenuItemAgregar = new System.Windows.Forms.ToolStripMenuItem();
			this.TStripMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.PanelMenu = new System.Windows.Forms.Panel();
			this.BtnMedia = new WinReproductorMp3.Controles.Botones();
			this.LblTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LblTiempo = new System.Windows.Forms.Label();
			this.PanelMedia = new System.Windows.Forms.Panel();
			this.BtnAgregar = new WinReproductorMp3.Controles.Botones();
			this.BtnLimpiar = new WinReproductorMp3.Controles.Botones();
			this.BtnVerRepro = new WinReproductorMp3.Controles.Botones();
			this.BtnVerLista = new WinReproductorMp3.Controles.Botones();
			this.PanelBotones = new System.Windows.Forms.Panel();
			this.BtnPausa = new WinReproductorMp3.Controles.Botones();
			this.BtnSiguiente = new WinReproductorMp3.Controles.Botones();
			this.BtnAnterior = new WinReproductorMp3.Controles.Botones();
			this.BtnDetener = new WinReproductorMp3.Controles.Botones();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ChkVolumen = new System.Windows.Forms.CheckBox();
			this.BtnVolumen = new System.Windows.Forms.Button();
			this.LblFinal = new System.Windows.Forms.Label();
			this.LblTTranscurrido = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MtBalance = new XComponent.SliderBar.MACTrackBar();
			this.LblVol = new System.Windows.Forms.Label();
			this.LblVolumen = new System.Windows.Forms.Label();
			this.MtVolumen = new XComponent.SliderBar.MACTrackBar();
			this.MtStatus = new XComponent.SliderBar.MACTrackBar();
			this.BtnPlay = new WinReproductorMp3.Controles.Botones();
			this.PanelConteo = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.LblConteo = new System.Windows.Forms.Label();
			this.LblTotalSongs = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PanelTagLib = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.LblAlbum = new System.Windows.Forms.Label();
			this.LblAutora = new System.Windows.Forms.Label();
			this.LblAutor = new System.Windows.Forms.Label();
			this.LblTituloa = new System.Windows.Forms.Label();
			this.LblCancion = new System.Windows.Forms.Label();
			this.PanelReproductor = new System.Windows.Forms.Panel();
			this.LstCanciones = new System.Windows.Forms.ListBox();
			this.PxEqualizador = new System.Windows.Forms.PictureBox();
			this.TmTiempo = new System.Windows.Forms.Timer(this.components);
			this.TtMensaje = new System.Windows.Forms.ToolTip(this.components);
			this.BtnSalir = new System.Windows.Forms.PictureBox();
			this.MsTitulo.SuspendLayout();
			this.PanelMenu.SuspendLayout();
			this.PanelMedia.SuspendLayout();
			this.PanelBotones.SuspendLayout();
			this.PanelConteo.SuspendLayout();
			this.PanelTagLib.SuspendLayout();
			this.PanelReproductor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PxEqualizador)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
			this.SuspendLayout();
			// 
			// MsTitulo
			// 
			this.MsTitulo.AutoSize = false;
			this.MsTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.MsTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.TStripMenuItemArchivos});
			this.MsTitulo.Location = new System.Drawing.Point(0, 0);
			this.MsTitulo.Name = "MsTitulo";
			this.MsTitulo.Size = new System.Drawing.Size(837, 50);
			this.MsTitulo.TabIndex = 0;
			this.MsTitulo.Text = "menuStrip1";
			this.MsTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MsTitulo_MouseMove);
			// 
			// TStripMenuItemArchivos
			// 
			this.TStripMenuItemArchivos.AutoSize = false;
			this.TStripMenuItemArchivos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TStripMenuItemArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.TStripMenuItemAgregar,
			this.TStripMenuSalir});
			this.TStripMenuItemArchivos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TStripMenuItemArchivos.ForeColor = System.Drawing.Color.Black;
			this.TStripMenuItemArchivos.ImageTransparentColor = System.Drawing.Color.Navy;
			this.TStripMenuItemArchivos.Name = "TStripMenuItemArchivos";
			this.TStripMenuItemArchivos.Size = new System.Drawing.Size(122, 46);
			this.TStripMenuItemArchivos.Text = "ARCHIVOS";
			// 
			// TStripMenuItemAgregar
			// 
			this.TStripMenuItemAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TStripMenuItemAgregar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TStripMenuItemAgregar.ForeColor = System.Drawing.Color.Black;
			this.TStripMenuItemAgregar.Name = "TStripMenuItemAgregar";
			this.TStripMenuItemAgregar.Size = new System.Drawing.Size(196, 22);
			this.TStripMenuItemAgregar.Text = "AGREGAR ARCHIVOS";
			this.TStripMenuItemAgregar.Click += new System.EventHandler(this.TStripMenuItemAgregar_Click);
			// 
			// TStripMenuSalir
			// 
			this.TStripMenuSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TStripMenuSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TStripMenuSalir.ForeColor = System.Drawing.Color.Black;
			this.TStripMenuSalir.Name = "TStripMenuSalir";
			this.TStripMenuSalir.Size = new System.Drawing.Size(196, 22);
			this.TStripMenuSalir.Text = "SALIR";
			this.TStripMenuSalir.Click += new System.EventHandler(this.TStripMenuSalir_Click);
			// 
			// PanelMenu
			// 
			this.PanelMenu.BackColor = System.Drawing.Color.Magenta;
			this.PanelMenu.Controls.Add(this.BtnMedia);
			this.PanelMenu.Controls.Add(this.LblTotal);
			this.PanelMenu.Controls.Add(this.label5);
			this.PanelMenu.Controls.Add(this.label6);
			this.PanelMenu.Controls.Add(this.LblTiempo);
			this.PanelMenu.Controls.Add(this.PanelMedia);
			this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.PanelMenu.Location = new System.Drawing.Point(0, 50);
			this.PanelMenu.Name = "PanelMenu";
			this.PanelMenu.Size = new System.Drawing.Size(164, 487);
			this.PanelMenu.TabIndex = 1;
			this.PanelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseMove);
			// 
			// BtnMedia
			// 
			this.BtnMedia.BackColor = System.Drawing.Color.LightPink;
			this.BtnMedia.BackgroundColor = System.Drawing.Color.LightPink;
			this.BtnMedia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnMedia.BorderRadius = 10;
			this.BtnMedia.BorderSize = 1;
			this.BtnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnMedia.FlatAppearance.BorderSize = 0;
			this.BtnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMedia.ForeColor = System.Drawing.Color.Black;
			this.BtnMedia.Location = new System.Drawing.Point(4, 72);
			this.BtnMedia.Name = "BtnMedia";
			this.BtnMedia.Size = new System.Drawing.Size(156, 50);
			this.BtnMedia.TabIndex = 75;
			this.BtnMedia.Text = "MEDIA";
			this.BtnMedia.TextColor = System.Drawing.Color.Black;
			this.BtnMedia.UseVisualStyleBackColor = false;
			this.BtnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTotal.ForeColor = System.Drawing.Color.Black;
			this.LblTotal.Location = new System.Drawing.Point(52, 440);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(59, 32);
			this.LblTotal.TabIndex = 60;
			this.LblTotal.Text = "--:--";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(43, 424);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 16);
			this.label5.TabIndex = 59;
			this.label5.Text = "Duración Total";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label6.Location = new System.Drawing.Point(25, 339);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 16);
			this.label6.TabIndex = 61;
			this.label6.Text = "Tiempo Transcurrido";
			// 
			// LblTiempo
			// 
			this.LblTiempo.AutoSize = true;
			this.LblTiempo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTiempo.ForeColor = System.Drawing.Color.Black;
			this.LblTiempo.Location = new System.Drawing.Point(53, 358);
			this.LblTiempo.Name = "LblTiempo";
			this.LblTiempo.Size = new System.Drawing.Size(59, 32);
			this.LblTiempo.TabIndex = 62;
			this.LblTiempo.Text = "--:--";
			// 
			// PanelMedia
			// 
			this.PanelMedia.Controls.Add(this.BtnAgregar);
			this.PanelMedia.Controls.Add(this.BtnLimpiar);
			this.PanelMedia.Controls.Add(this.BtnVerRepro);
			this.PanelMedia.Controls.Add(this.BtnVerLista);
			this.PanelMedia.Location = new System.Drawing.Point(2, 121);
			this.PanelMedia.Name = "PanelMedia";
			this.PanelMedia.Size = new System.Drawing.Size(159, 210);
			this.PanelMedia.TabIndex = 1;
			this.PanelMedia.Visible = false;
			// 
			// BtnAgregar
			// 
			this.BtnAgregar.BackColor = System.Drawing.Color.LightPink;
			this.BtnAgregar.BackgroundColor = System.Drawing.Color.LightPink;
			this.BtnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnAgregar.BorderRadius = 10;
			this.BtnAgregar.BorderSize = 1;
			this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAgregar.FlatAppearance.BorderSize = 0;
			this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
			this.BtnAgregar.Location = new System.Drawing.Point(3, 2);
			this.BtnAgregar.Name = "BtnAgregar";
			this.BtnAgregar.Size = new System.Drawing.Size(156, 50);
			this.BtnAgregar.TabIndex = 74;
			this.BtnAgregar.Text = "ARGREGAR ARCHIVOS";
			this.BtnAgregar.TextColor = System.Drawing.Color.Black;
			this.BtnAgregar.UseVisualStyleBackColor = false;
			this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.BackColor = System.Drawing.Color.LightPink;
			this.BtnLimpiar.BackgroundColor = System.Drawing.Color.LightPink;
			this.BtnLimpiar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnLimpiar.BorderRadius = 10;
			this.BtnLimpiar.BorderSize = 1;
			this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLimpiar.FlatAppearance.BorderSize = 0;
			this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
			this.BtnLimpiar.Location = new System.Drawing.Point(3, 53);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(156, 50);
			this.BtnLimpiar.TabIndex = 73;
			this.BtnLimpiar.Text = "LIMPIAR LISTADO";
			this.BtnLimpiar.TextColor = System.Drawing.Color.Black;
			this.BtnLimpiar.UseVisualStyleBackColor = false;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// BtnVerRepro
			// 
			this.BtnVerRepro.BackColor = System.Drawing.Color.LightPink;
			this.BtnVerRepro.BackgroundColor = System.Drawing.Color.LightPink;
			this.BtnVerRepro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerRepro.BorderRadius = 10;
			this.BtnVerRepro.BorderSize = 1;
			this.BtnVerRepro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnVerRepro.FlatAppearance.BorderSize = 0;
			this.BtnVerRepro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerRepro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerRepro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnVerRepro.ForeColor = System.Drawing.Color.Black;
			this.BtnVerRepro.Location = new System.Drawing.Point(3, 105);
			this.BtnVerRepro.Name = "BtnVerRepro";
			this.BtnVerRepro.Size = new System.Drawing.Size(156, 50);
			this.BtnVerRepro.TabIndex = 72;
			this.BtnVerRepro.Text = "VER REPRODUCTOR";
			this.BtnVerRepro.TextColor = System.Drawing.Color.Black;
			this.BtnVerRepro.UseVisualStyleBackColor = false;
			this.BtnVerRepro.Click += new System.EventHandler(this.BtnVerRepro_Click);
			// 
			// BtnVerLista
			// 
			this.BtnVerLista.BackColor = System.Drawing.Color.LightPink;
			this.BtnVerLista.BackgroundColor = System.Drawing.Color.LightPink;
			this.BtnVerLista.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerLista.BorderRadius = 10;
			this.BtnVerLista.BorderSize = 1;
			this.BtnVerLista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnVerLista.FlatAppearance.BorderSize = 0;
			this.BtnVerLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnVerLista.ForeColor = System.Drawing.Color.Black;
			this.BtnVerLista.Location = new System.Drawing.Point(3, 156);
			this.BtnVerLista.Name = "BtnVerLista";
			this.BtnVerLista.Size = new System.Drawing.Size(156, 50);
			this.BtnVerLista.TabIndex = 71;
			this.BtnVerLista.Text = "VER LISTADO";
			this.BtnVerLista.TextColor = System.Drawing.Color.Black;
			this.BtnVerLista.UseVisualStyleBackColor = false;
			this.BtnVerLista.Click += new System.EventHandler(this.BtnVerLista_Click);
			// 
			// PanelBotones
			// 
			this.PanelBotones.BackColor = System.Drawing.Color.Magenta;
			this.PanelBotones.Controls.Add(this.BtnPausa);
			this.PanelBotones.Controls.Add(this.BtnSiguiente);
			this.PanelBotones.Controls.Add(this.BtnAnterior);
			this.PanelBotones.Controls.Add(this.BtnDetener);
			this.PanelBotones.Controls.Add(this.label7);
			this.PanelBotones.Controls.Add(this.label2);
			this.PanelBotones.Controls.Add(this.ChkVolumen);
			this.PanelBotones.Controls.Add(this.BtnVolumen);
			this.PanelBotones.Controls.Add(this.LblFinal);
			this.PanelBotones.Controls.Add(this.LblTTranscurrido);
			this.PanelBotones.Controls.Add(this.label3);
			this.PanelBotones.Controls.Add(this.MtBalance);
			this.PanelBotones.Controls.Add(this.LblVol);
			this.PanelBotones.Controls.Add(this.LblVolumen);
			this.PanelBotones.Controls.Add(this.MtVolumen);
			this.PanelBotones.Controls.Add(this.MtStatus);
			this.PanelBotones.Controls.Add(this.BtnPlay);
			this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PanelBotones.Location = new System.Drawing.Point(164, 392);
			this.PanelBotones.Name = "PanelBotones";
			this.PanelBotones.Size = new System.Drawing.Size(673, 145);
			this.PanelBotones.TabIndex = 2;
			// 
			// BtnPausa
			// 
			this.BtnPausa.BackColor = System.Drawing.Color.Transparent;
			this.BtnPausa.BackgroundColor = System.Drawing.Color.Transparent;
			this.BtnPausa.BackgroundImage = global::WinReproductorMp3.Properties.Resources.pause100;
			this.BtnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnPausa.BorderColor = System.Drawing.Color.White;
			this.BtnPausa.BorderRadius = 10;
			this.BtnPausa.BorderSize = 1;
			this.BtnPausa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnPausa.FlatAppearance.BorderSize = 0;
			this.BtnPausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnPausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPausa.ForeColor = System.Drawing.Color.White;
			this.BtnPausa.Location = new System.Drawing.Point(24, 39);
			this.BtnPausa.Name = "BtnPausa";
			this.BtnPausa.Size = new System.Drawing.Size(98, 88);
			this.BtnPausa.TabIndex = 104;
			this.BtnPausa.TextColor = System.Drawing.Color.White;
			this.TtMensaje.SetToolTip(this.BtnPausa, "PAUSA");
			this.BtnPausa.UseVisualStyleBackColor = false;
			this.BtnPausa.Visible = false;
			this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
			// 
			// BtnSiguiente
			// 
			this.BtnSiguiente.BackColor = System.Drawing.Color.Transparent;
			this.BtnSiguiente.BackgroundColor = System.Drawing.Color.Transparent;
			this.BtnSiguiente.BackgroundImage = global::WinReproductorMp3.Properties.Resources.end1001;
			this.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnSiguiente.BorderColor = System.Drawing.Color.White;
			this.BtnSiguiente.BorderRadius = 10;
			this.BtnSiguiente.BorderSize = 1;
			this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSiguiente.FlatAppearance.BorderSize = 0;
			this.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSiguiente.ForeColor = System.Drawing.Color.White;
			this.BtnSiguiente.Location = new System.Drawing.Point(356, 57);
			this.BtnSiguiente.Name = "BtnSiguiente";
			this.BtnSiguiente.Size = new System.Drawing.Size(65, 56);
			this.BtnSiguiente.TabIndex = 103;
			this.BtnSiguiente.TextColor = System.Drawing.Color.White;
			this.TtMensaje.SetToolTip(this.BtnSiguiente, "SIGUIENTE");
			this.BtnSiguiente.UseVisualStyleBackColor = false;
			this.BtnSiguiente.Click += new System.EventHandler(this.EvtSiguienteCancion);
			// 
			// BtnAnterior
			// 
			this.BtnAnterior.BackColor = System.Drawing.Color.Transparent;
			this.BtnAnterior.BackgroundColor = System.Drawing.Color.Transparent;
			this.BtnAnterior.BackgroundImage = global::WinReproductorMp3.Properties.Resources.skip_to_start;
			this.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnAnterior.BorderColor = System.Drawing.Color.White;
			this.BtnAnterior.BorderRadius = 10;
			this.BtnAnterior.BorderSize = 1;
			this.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAnterior.FlatAppearance.BorderSize = 0;
			this.BtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAnterior.ForeColor = System.Drawing.Color.White;
			this.BtnAnterior.Location = new System.Drawing.Point(285, 55);
			this.BtnAnterior.Name = "BtnAnterior";
			this.BtnAnterior.Size = new System.Drawing.Size(65, 56);
			this.BtnAnterior.TabIndex = 102;
			this.BtnAnterior.TextColor = System.Drawing.Color.White;
			this.TtMensaje.SetToolTip(this.BtnAnterior, "ANTERIOR");
			this.BtnAnterior.UseVisualStyleBackColor = false;
			this.BtnAnterior.Click += new System.EventHandler(this.EvtCancionAnterior);
			// 
			// BtnDetener
			// 
			this.BtnDetener.BackColor = System.Drawing.Color.Transparent;
			this.BtnDetener.BackgroundColor = System.Drawing.Color.Transparent;
			this.BtnDetener.BackgroundImage = global::WinReproductorMp3.Properties.Resources.stop;
			this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnDetener.BorderColor = System.Drawing.Color.White;
			this.BtnDetener.BorderRadius = 10;
			this.BtnDetener.BorderSize = 1;
			this.BtnDetener.FlatAppearance.BorderSize = 0;
			this.BtnDetener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnDetener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDetener.ForeColor = System.Drawing.Color.White;
			this.BtnDetener.Location = new System.Drawing.Point(209, 55);
			this.BtnDetener.Name = "BtnDetener";
			this.BtnDetener.Size = new System.Drawing.Size(65, 56);
			this.BtnDetener.TabIndex = 101;
			this.BtnDetener.TextColor = System.Drawing.Color.White;
			this.TtMensaje.SetToolTip(this.BtnDetener, "DETENER");
			this.BtnDetener.UseVisualStyleBackColor = false;
			this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(620, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 13);
			this.label7.TabIndex = 100;
			this.label7.Text = "R";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(620, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 99;
			this.label2.Text = "L";
			// 
			// ChkVolumen
			// 
			this.ChkVolumen.AutoSize = true;
			this.ChkVolumen.Location = new System.Drawing.Point(478, 119);
			this.ChkVolumen.Name = "ChkVolumen";
			this.ChkVolumen.Size = new System.Drawing.Size(15, 14);
			this.ChkVolumen.TabIndex = 98;
			this.ChkVolumen.UseVisualStyleBackColor = true;
			this.ChkVolumen.Visible = false;
			this.ChkVolumen.CheckedChanged += new System.EventHandler(this.ChkVolumen_CheckedChanged);
			// 
			// BtnVolumen
			// 
			this.BtnVolumen.BackgroundImage = global::WinReproductorMp3.Properties.Resources.low_volume10;
			this.BtnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnVolumen.FlatAppearance.BorderSize = 0;
			this.BtnVolumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnVolumen.Location = new System.Drawing.Point(475, 87);
			this.BtnVolumen.Name = "BtnVolumen";
			this.BtnVolumen.Size = new System.Drawing.Size(34, 26);
			this.BtnVolumen.TabIndex = 97;
			this.BtnVolumen.UseVisualStyleBackColor = true;
			this.BtnVolumen.Click += new System.EventHandler(this.BtnVolumen_Click);
			// 
			// LblFinal
			// 
			this.LblFinal.AutoSize = true;
			this.LblFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFinal.ForeColor = System.Drawing.Color.Black;
			this.LblFinal.Location = new System.Drawing.Point(451, 24);
			this.LblFinal.Name = "LblFinal";
			this.LblFinal.Size = new System.Drawing.Size(28, 16);
			this.LblFinal.TabIndex = 96;
			this.LblFinal.Text = "--:--";
			// 
			// LblTTranscurrido
			// 
			this.LblTTranscurrido.AutoSize = true;
			this.LblTTranscurrido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTTranscurrido.ForeColor = System.Drawing.Color.Black;
			this.LblTTranscurrido.Location = new System.Drawing.Point(145, 25);
			this.LblTTranscurrido.Name = "LblTTranscurrido";
			this.LblTTranscurrido.Size = new System.Drawing.Size(28, 16);
			this.LblTTranscurrido.TabIndex = 95;
			this.LblTTranscurrido.Text = "--:--";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(582, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "BALANCE";
			// 
			// MtBalance
			// 
			this.MtBalance.BackColor = System.Drawing.Color.Transparent;
			this.MtBalance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.MtBalance.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MtBalance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
			this.MtBalance.IndentHeight = 6;
			this.MtBalance.Location = new System.Drawing.Point(597, 5);
			this.MtBalance.Maximum = 100;
			this.MtBalance.Minimum = -100;
			this.MtBalance.Name = "MtBalance";
			this.MtBalance.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.MtBalance.Size = new System.Drawing.Size(22, 111);
			this.MtBalance.TabIndex = 9;
			this.MtBalance.TextTickStyle = System.Windows.Forms.TickStyle.None;
			this.MtBalance.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
			this.MtBalance.TickHeight = 4;
			this.MtBalance.TickStyle = System.Windows.Forms.TickStyle.None;
			this.TtMensaje.SetToolTip(this.MtBalance, "BALANCE");
			this.MtBalance.TrackerColor = System.Drawing.Color.Black;
			this.MtBalance.TrackerSize = new System.Drawing.Size(10, 10);
			this.MtBalance.TrackLineColor = System.Drawing.Color.White;
			this.MtBalance.TrackLineHeight = 3;
			this.MtBalance.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.MtBalance.Value = 0;
			this.MtBalance.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBalance_ValueChanged);
			// 
			// LblVol
			// 
			this.LblVol.AutoSize = true;
			this.LblVol.ForeColor = System.Drawing.Color.White;
			this.LblVol.Location = new System.Drawing.Point(541, 98);
			this.LblVol.Name = "LblVol";
			this.LblVol.Size = new System.Drawing.Size(13, 13);
			this.LblVol.TabIndex = 8;
			this.LblVol.Text = "0";
			// 
			// LblVolumen
			// 
			this.LblVolumen.AutoSize = true;
			this.LblVolumen.ForeColor = System.Drawing.Color.White;
			this.LblVolumen.Location = new System.Drawing.Point(499, 119);
			this.LblVolumen.Name = "LblVolumen";
			this.LblVolumen.Size = new System.Drawing.Size(60, 13);
			this.LblVolumen.TabIndex = 7;
			this.LblVolumen.Text = "VOLUMEN";
			// 
			// MtVolumen
			// 
			this.MtVolumen.BackColor = System.Drawing.Color.Transparent;
			this.MtVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.MtVolumen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MtVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MtVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
			this.MtVolumen.IndentHeight = 6;
			this.MtVolumen.Location = new System.Drawing.Point(515, 5);
			this.MtVolumen.Maximum = 100;
			this.MtVolumen.Minimum = 0;
			this.MtVolumen.Name = "MtVolumen";
			this.MtVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.MtVolumen.Size = new System.Drawing.Size(22, 111);
			this.MtVolumen.TabIndex = 6;
			this.MtVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
			this.MtVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
			this.MtVolumen.TickHeight = 4;
			this.MtVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
			this.TtMensaje.SetToolTip(this.MtVolumen, "VOLUMEN");
			this.MtVolumen.TrackerColor = System.Drawing.Color.Black;
			this.MtVolumen.TrackerSize = new System.Drawing.Size(10, 10);
			this.MtVolumen.TrackLineColor = System.Drawing.Color.White;
			this.MtVolumen.TrackLineHeight = 3;
			this.MtVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.MtVolumen.Value = 0;
			this.MtVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtVolumen_ValueChanged);
			this.MtVolumen.Scroll += new System.EventHandler(this.MtVolumen_Scroll);
			// 
			// MtStatus
			// 
			this.MtStatus.BackColor = System.Drawing.Color.Transparent;
			this.MtStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.MtStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MtStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
			this.MtStatus.IndentHeight = 6;
			this.MtStatus.Location = new System.Drawing.Point(138, 5);
			this.MtStatus.Maximum = 100;
			this.MtStatus.Minimum = 0;
			this.MtStatus.Name = "MtStatus";
			this.MtStatus.Size = new System.Drawing.Size(350, 22);
			this.MtStatus.TabIndex = 5;
			this.MtStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
			this.MtStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
			this.MtStatus.TickHeight = 4;
			this.MtStatus.TickStyle = System.Windows.Forms.TickStyle.None;
			this.TtMensaje.SetToolTip(this.MtStatus, "BARRA DE ESTADO");
			this.MtStatus.TrackerColor = System.Drawing.Color.Black;
			this.MtStatus.TrackerSize = new System.Drawing.Size(10, 10);
			this.MtStatus.TrackLineColor = System.Drawing.Color.White;
			this.MtStatus.TrackLineHeight = 3;
			this.MtStatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.MtStatus.Value = 0;
			this.MtStatus.Scroll += new System.EventHandler(this.MtStatus_Scroll);
			// 
			// BtnPlay
			// 
			this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
			this.BtnPlay.BackgroundColor = System.Drawing.Color.Transparent;
			this.BtnPlay.BackgroundImage = global::WinReproductorMp3.Properties.Resources.play;
			this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnPlay.BorderColor = System.Drawing.Color.White;
			this.BtnPlay.BorderRadius = 10;
			this.BtnPlay.BorderSize = 1;
			this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnPlay.FlatAppearance.BorderSize = 0;
			this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPlay.ForeColor = System.Drawing.Color.White;
			this.BtnPlay.Location = new System.Drawing.Point(24, 39);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(98, 88);
			this.BtnPlay.TabIndex = 105;
			this.BtnPlay.TextColor = System.Drawing.Color.White;
			this.TtMensaje.SetToolTip(this.BtnPlay, "REPRODUCIR");
			this.BtnPlay.UseVisualStyleBackColor = false;
			this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
			// 
			// PanelConteo
			// 
			this.PanelConteo.BackColor = System.Drawing.Color.Magenta;
			this.PanelConteo.Controls.Add(this.label4);
			this.PanelConteo.Controls.Add(this.LblConteo);
			this.PanelConteo.Controls.Add(this.LblTotalSongs);
			this.PanelConteo.Controls.Add(this.label1);
			this.PanelConteo.Dock = System.Windows.Forms.DockStyle.Right;
			this.PanelConteo.Location = new System.Drawing.Point(506, 0);
			this.PanelConteo.Name = "PanelConteo";
			this.PanelConteo.Size = new System.Drawing.Size(167, 232);
			this.PanelConteo.TabIndex = 3;
			this.PanelConteo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelConteo_MouseMove);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(47, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 71;
			this.label4.Text = "Canción";
			// 
			// LblConteo
			// 
			this.LblConteo.AutoSize = true;
			this.LblConteo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblConteo.ForeColor = System.Drawing.Color.Black;
			this.LblConteo.Location = new System.Drawing.Point(54, 169);
			this.LblConteo.Name = "LblConteo";
			this.LblConteo.Size = new System.Drawing.Size(52, 18);
			this.LblConteo.TabIndex = 70;
			this.LblConteo.Text = "0 de 0";
			// 
			// LblTotalSongs
			// 
			this.LblTotalSongs.AutoSize = true;
			this.LblTotalSongs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTotalSongs.ForeColor = System.Drawing.Color.White;
			this.LblTotalSongs.Location = new System.Drawing.Point(69, 58);
			this.LblTotalSongs.Name = "LblTotalSongs";
			this.LblTotalSongs.Size = new System.Drawing.Size(21, 22);
			this.LblTotalSongs.TabIndex = 1;
			this.LblTotalSongs.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(9, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "TOTAL DE CANCIONES";
			// 
			// PanelTagLib
			// 
			this.PanelTagLib.BackColor = System.Drawing.Color.Magenta;
			this.PanelTagLib.Controls.Add(this.button1);
			this.PanelTagLib.Controls.Add(this.label8);
			this.PanelTagLib.Controls.Add(this.LblAlbum);
			this.PanelTagLib.Controls.Add(this.LblAutora);
			this.PanelTagLib.Controls.Add(this.LblAutor);
			this.PanelTagLib.Controls.Add(this.LblTituloa);
			this.PanelTagLib.Controls.Add(this.LblCancion);
			this.PanelTagLib.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelTagLib.Location = new System.Drawing.Point(164, 50);
			this.PanelTagLib.Name = "PanelTagLib";
			this.PanelTagLib.Size = new System.Drawing.Size(673, 110);
			this.PanelTagLib.TabIndex = 4;
			this.PanelTagLib.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTagLib_Paint);
			this.PanelTagLib.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTagLib_MouseMove);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(563, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 71;
			this.button1.Text = "Aleatorio";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(112, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 18);
			this.label8.TabIndex = 69;
			this.label8.Text = "Album: ";
			// 
			// LblAlbum
			// 
			this.LblAlbum.AutoSize = true;
			this.LblAlbum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAlbum.ForeColor = System.Drawing.Color.White;
			this.LblAlbum.Location = new System.Drawing.Point(178, 72);
			this.LblAlbum.Name = "LblAlbum";
			this.LblAlbum.Size = new System.Drawing.Size(45, 16);
			this.LblAlbum.TabIndex = 70;
			this.LblAlbum.Text = "Album";
			// 
			// LblAutora
			// 
			this.LblAutora.AutoSize = true;
			this.LblAutora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAutora.ForeColor = System.Drawing.Color.Black;
			this.LblAutora.Location = new System.Drawing.Point(53, 41);
			this.LblAutora.Name = "LblAutora";
			this.LblAutora.Size = new System.Drawing.Size(120, 18);
			this.LblAutora.TabIndex = 67;
			this.LblAutora.Text = "Autor/Cantante: ";
			// 
			// LblAutor
			// 
			this.LblAutor.AutoSize = true;
			this.LblAutor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAutor.ForeColor = System.Drawing.Color.White;
			this.LblAutor.Location = new System.Drawing.Point(179, 43);
			this.LblAutor.Name = "LblAutor";
			this.LblAutor.Size = new System.Drawing.Size(95, 16);
			this.LblAutor.TabIndex = 68;
			this.LblAutor.Text = "Autor/Cantante";
			// 
			// LblTituloa
			// 
			this.LblTituloa.AutoSize = true;
			this.LblTituloa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTituloa.ForeColor = System.Drawing.Color.Black;
			this.LblTituloa.Location = new System.Drawing.Point(21, 13);
			this.LblTituloa.Name = "LblTituloa";
			this.LblTituloa.Size = new System.Drawing.Size(152, 18);
			this.LblTituloa.TabIndex = 64;
			this.LblTituloa.Text = "Titulo de la Canción: ";
			// 
			// LblCancion
			// 
			this.LblCancion.AutoSize = true;
			this.LblCancion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCancion.ForeColor = System.Drawing.Color.White;
			this.LblCancion.Location = new System.Drawing.Point(179, 15);
			this.LblCancion.Name = "LblCancion";
			this.LblCancion.Size = new System.Drawing.Size(122, 16);
			this.LblCancion.TabIndex = 63;
			this.LblCancion.Text = "Título de la Canción";
			// 
			// PanelReproductor
			// 
			this.PanelReproductor.BackColor = System.Drawing.Color.Navy;
			this.PanelReproductor.Controls.Add(this.LstCanciones);
			this.PanelReproductor.Controls.Add(this.PanelConteo);
			this.PanelReproductor.Controls.Add(this.PxEqualizador);
			this.PanelReproductor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelReproductor.Location = new System.Drawing.Point(164, 160);
			this.PanelReproductor.Name = "PanelReproductor";
			this.PanelReproductor.Size = new System.Drawing.Size(673, 232);
			this.PanelReproductor.TabIndex = 5;
			// 
			// LstCanciones
			// 
			this.LstCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.LstCanciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LstCanciones.ForeColor = System.Drawing.Color.Black;
			this.LstCanciones.FormattingEnabled = true;
			this.LstCanciones.ItemHeight = 16;
			this.LstCanciones.Location = new System.Drawing.Point(2, 0);
			this.LstCanciones.Name = "LstCanciones";
			this.LstCanciones.Size = new System.Drawing.Size(504, 228);
			this.LstCanciones.TabIndex = 0;
			this.TtMensaje.SetToolTip(this.LstCanciones, "LISTA DE REPRODUCCIÓN");
			this.LstCanciones.SelectedIndexChanged += new System.EventHandler(this.LstCanciones_SelectedIndexChanged);
			// 
			// PxEqualizador
			// 
			this.PxEqualizador.Image = global::WinReproductorMp3.Properties.Resources.ecualizador_abajo;
			this.PxEqualizador.Location = new System.Drawing.Point(3, 0);
			this.PxEqualizador.Name = "PxEqualizador";
			this.PxEqualizador.Size = new System.Drawing.Size(503, 226);
			this.PxEqualizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PxEqualizador.TabIndex = 4;
			this.PxEqualizador.TabStop = false;
			// 
			// TmTiempo
			// 
			this.TmTiempo.Tick += new System.EventHandler(this.EvtActualizarTiempo);
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.BtnSalir.BackgroundImage = global::WinReproductorMp3.Properties.Resources.closewindow_click;
			this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSalir.Location = new System.Drawing.Point(781, 8);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(44, 38);
			this.BtnSalir.TabIndex = 6;
			this.BtnSalir.TabStop = false;
			this.TtMensaje.SetToolTip(this.BtnSalir, "SALIR");
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			this.BtnSalir.MouseEnter += new System.EventHandler(this.BtnSalir_MouseEnter);
			this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 537);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.PanelReproductor);
			this.Controls.Add(this.PanelTagLib);
			this.Controls.Add(this.PanelBotones);
			this.Controls.Add(this.PanelMenu);
			this.Controls.Add(this.MsTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.MsTitulo;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MsTitulo.ResumeLayout(false);
			this.MsTitulo.PerformLayout();
			this.PanelMenu.ResumeLayout(false);
			this.PanelMenu.PerformLayout();
			this.PanelMedia.ResumeLayout(false);
			this.PanelBotones.ResumeLayout(false);
			this.PanelBotones.PerformLayout();
			this.PanelConteo.ResumeLayout(false);
			this.PanelConteo.PerformLayout();
			this.PanelTagLib.ResumeLayout(false);
			this.PanelTagLib.PerformLayout();
			this.PanelReproductor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PxEqualizador)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip MsTitulo;
		private System.Windows.Forms.ToolStripMenuItem TStripMenuItemArchivos;
		private System.Windows.Forms.ToolStripMenuItem TStripMenuItemAgregar;
		private System.Windows.Forms.ToolStripMenuItem TStripMenuSalir;
		private System.Windows.Forms.Panel PanelMenu;
		private System.Windows.Forms.Panel PanelBotones;
		private System.Windows.Forms.Panel PanelConteo;
		private System.Windows.Forms.Panel PanelTagLib;
		private System.Windows.Forms.Panel PanelReproductor;
		private System.Windows.Forms.ListBox LstCanciones;
		private System.Windows.Forms.PictureBox BtnSalir;
		private System.Windows.Forms.Panel PanelMedia;
		private System.Windows.Forms.Label LblTotalSongs;
		private System.Windows.Forms.Label label1;
		private XComponent.SliderBar.MACTrackBar MtBalance;
		private System.Windows.Forms.Label LblVol;
		private System.Windows.Forms.Label LblVolumen;
		private XComponent.SliderBar.MACTrackBar MtVolumen;
		private XComponent.SliderBar.MACTrackBar MtStatus;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer TmTiempo;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label LblTiempo;
		private System.Windows.Forms.Label LblFinal;
		private System.Windows.Forms.Label LblTTranscurrido;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LblConteo;
		private System.Windows.Forms.Label LblTituloa;
		private System.Windows.Forms.Label LblCancion;
		private System.Windows.Forms.Button BtnVolumen;
		private System.Windows.Forms.CheckBox ChkVolumen;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label LblAlbum;
		private System.Windows.Forms.Label LblAutora;
		private System.Windows.Forms.Label LblAutor;
		private System.Windows.Forms.ToolTip TtMensaje;
		private System.Windows.Forms.PictureBox PxEqualizador;
		private Controles.Botones BtnDetener;
		private Controles.Botones BtnAnterior;
		private Controles.Botones BtnPausa;
		private Controles.Botones BtnSiguiente;
		private Controles.Botones BtnPlay;
		private Controles.Botones BtnVerLista;
		private Controles.Botones BtnLimpiar;
		private Controles.Botones BtnVerRepro;
		private Controles.Botones BtnAgregar;
		private Controles.Botones BtnMedia;
		private System.Windows.Forms.Button button1;
	}
}
