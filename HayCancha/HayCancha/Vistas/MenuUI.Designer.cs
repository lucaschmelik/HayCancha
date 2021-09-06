
using HayCancha.Servicios;

namespace HayCancha
{
    partial class MenuUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUI));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPartidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdiomaEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdiomaIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdiomaChino = new System.Windows.Forms.ToolStripMenuItem();
            this.NuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.imgPuntoNotificacion = new System.Windows.Forms.PictureBox();
            this.imgNotificacion = new System.Windows.Forms.PictureBox();
            this.lblNombreMenu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.panelMenus = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.tsmBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.ucNotificacion = new HayCancha.NotificacionUC();
            this.msMenu.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPuntoNotificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panelMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPermisos,
            this.tsmAlquiler,
            this.tsmEquipos,
            this.tsmPartidos,
            this.tsmEstadisticas,
            this.tsmReservas,
            this.tsmReportes,
            this.tsmOpciones,
            this.tsmBitacora,
            this.tsmIdioma,
            this.tsmSalir});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 9;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmPermisos
            // 
            this.tsmPermisos.Name = "tsmPermisos";
            this.tsmPermisos.Size = new System.Drawing.Size(74, 20);
            this.tsmPermisos.Tag = "5";
            this.tsmPermisos.Text = "PERMISOS";
            this.tsmPermisos.Click += new System.EventHandler(this.tsmUsuarios_Click);
            // 
            // tsmAlquiler
            // 
            this.tsmAlquiler.Name = "tsmAlquiler";
            this.tsmAlquiler.Size = new System.Drawing.Size(72, 20);
            this.tsmAlquiler.Tag = "6";
            this.tsmAlquiler.Text = "ALQUILER";
            this.tsmAlquiler.Click += new System.EventHandler(this.tsmAlquiler_Click);
            // 
            // tsmEquipos
            // 
            this.tsmEquipos.Name = "tsmEquipos";
            this.tsmEquipos.Size = new System.Drawing.Size(67, 20);
            this.tsmEquipos.Tag = "7";
            this.tsmEquipos.Text = "EQUIPOS";
            // 
            // tsmPartidos
            // 
            this.tsmPartidos.Name = "tsmPartidos";
            this.tsmPartidos.Size = new System.Drawing.Size(71, 20);
            this.tsmPartidos.Tag = "19";
            this.tsmPartidos.Text = "PARTIDOS";
            this.tsmPartidos.Click += new System.EventHandler(this.tsmPartidos_Click);
            // 
            // tsmEstadisticas
            // 
            this.tsmEstadisticas.Name = "tsmEstadisticas";
            this.tsmEstadisticas.Size = new System.Drawing.Size(92, 20);
            this.tsmEstadisticas.Tag = "8";
            this.tsmEstadisticas.Text = "ESTADISTICAS";
            // 
            // tsmReservas
            // 
            this.tsmReservas.Name = "tsmReservas";
            this.tsmReservas.Size = new System.Drawing.Size(71, 20);
            this.tsmReservas.Tag = "18";
            this.tsmReservas.Text = "RESERVAS";
            this.tsmReservas.Click += new System.EventHandler(this.tsmReservas_Click);
            // 
            // tsmReportes
            // 
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(72, 20);
            this.tsmReportes.Tag = "9";
            this.tsmReportes.Text = "REPORTES";
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(76, 20);
            this.tsmOpciones.Tag = "10";
            this.tsmOpciones.Text = "OPCIONES";
            // 
            // tsmIdioma
            // 
            this.tsmIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIdiomaEspañol,
            this.tsmIdiomaIngles,
            this.tsmIdiomaChino,
            this.NuevoToolStripMenuItem});
            this.tsmIdioma.Name = "tsmIdioma";
            this.tsmIdioma.Size = new System.Drawing.Size(61, 20);
            this.tsmIdioma.Tag = "11";
            this.tsmIdioma.Text = "IDIOMA";
            // 
            // tsmIdiomaEspañol
            // 
            this.tsmIdiomaEspañol.Image = global::HayCancha.Properties.Resources.IdiomaEspañol;
            this.tsmIdiomaEspañol.Name = "tsmIdiomaEspañol";
            this.tsmIdiomaEspañol.Size = new System.Drawing.Size(180, 22);
            this.tsmIdiomaEspañol.Text = "ESPAÑOL";
            this.tsmIdiomaEspañol.Click += new System.EventHandler(this.tsmIdiomaEspañol_Click);
            // 
            // tsmIdiomaIngles
            // 
            this.tsmIdiomaIngles.Image = global::HayCancha.Properties.Resources.IdiomaIngles;
            this.tsmIdiomaIngles.Name = "tsmIdiomaIngles";
            this.tsmIdiomaIngles.Size = new System.Drawing.Size(180, 22);
            this.tsmIdiomaIngles.Text = "INGLES";
            this.tsmIdiomaIngles.Click += new System.EventHandler(this.tsmIdiomaIngles_Click);
            // 
            // tsmIdiomaChino
            // 
            this.tsmIdiomaChino.Image = global::HayCancha.Properties.Resources.IdiomaChino;
            this.tsmIdiomaChino.Name = "tsmIdiomaChino";
            this.tsmIdiomaChino.Size = new System.Drawing.Size(180, 22);
            this.tsmIdiomaChino.Text = "CHINO";
            this.tsmIdiomaChino.Click += new System.EventHandler(this.tsmIdiomaChino_Click);
            // 
            // NuevoToolStripMenuItem
            // 
            this.NuevoToolStripMenuItem.Image = global::HayCancha.Properties.Resources.IdiomaNuevo;
            this.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem";
            this.NuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NuevoToolStripMenuItem.Text = "NUEVO";
            this.NuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(49, 20);
            this.tsmSalir.Text = "SALIR";
            this.tsmSalir.Click += new System.EventHandler(this.btnMenuSalir_Click);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.SystemColors.Info;
            this.panelPerfil.Controls.Add(this.imgPuntoNotificacion);
            this.panelPerfil.Controls.Add(this.imgNotificacion);
            this.panelPerfil.Controls.Add(this.lblNombreMenu);
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Controls.Add(this.imgPerfil);
            this.panelPerfil.Location = new System.Drawing.Point(575, 23);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(225, 429);
            this.panelPerfil.TabIndex = 11;
            // 
            // imgPuntoNotificacion
            // 
            this.imgPuntoNotificacion.BackColor = System.Drawing.Color.Red;
            this.imgPuntoNotificacion.Image = global::HayCancha.Properties.Resources.PuntoNotificacion;
            this.imgPuntoNotificacion.Location = new System.Drawing.Point(209, 14);
            this.imgPuntoNotificacion.Name = "imgPuntoNotificacion";
            this.imgPuntoNotificacion.Size = new System.Drawing.Size(12, 13);
            this.imgPuntoNotificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPuntoNotificacion.TabIndex = 2;
            this.imgPuntoNotificacion.TabStop = false;
            // 
            // imgNotificacion
            // 
            this.imgNotificacion.Image = global::HayCancha.Properties.Resources.notification;
            this.imgNotificacion.Location = new System.Drawing.Point(193, 18);
            this.imgNotificacion.Name = "imgNotificacion";
            this.imgNotificacion.Size = new System.Drawing.Size(31, 29);
            this.imgNotificacion.TabIndex = 14;
            this.imgNotificacion.TabStop = false;
            this.imgNotificacion.Click += new System.EventHandler(this.imgNotificacion_Click);
            // 
            // lblNombreMenu
            // 
            this.lblNombreMenu.BackColor = System.Drawing.SystemColors.Info;
            this.lblNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombreMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombreMenu.Enabled = false;
            this.lblNombreMenu.Font = new System.Drawing.Font("Impact", 22F);
            this.lblNombreMenu.Location = new System.Drawing.Point(16, 261);
            this.lblNombreMenu.Name = "lblNombreMenu";
            this.lblNombreMenu.ReadOnly = true;
            this.lblNombreMenu.Size = new System.Drawing.Size(196, 36);
            this.lblNombreMenu.TabIndex = 13;
            this.lblNombreMenu.Text = "Lucas";
            this.lblNombreMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Location = new System.Drawing.Point(40, 42);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(154, 145);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPerfil.TabIndex = 10;
            this.imgPerfil.TabStop = false;
            this.imgPerfil.Click += new System.EventHandler(this.imgPerfil_Click);
            // 
            // panelMenus
            // 
            this.panelMenus.Controls.Add(this.pictureBox2);
            this.panelMenus.Location = new System.Drawing.Point(4, 26);
            this.panelMenus.Name = "panelMenus";
            this.panelMenus.Size = new System.Drawing.Size(569, 422);
            this.panelMenus.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HayCancha.Properties.Resources._123;
            this.pictureBox2.Location = new System.Drawing.Point(27, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.imgPuntoNotificacion;
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.White;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(772, 3);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(18, 18);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 8;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            // 
            // tsmBitacora
            // 
            this.tsmBitacora.Name = "tsmBitacora";
            this.tsmBitacora.Size = new System.Drawing.Size(74, 20);
            this.tsmBitacora.Tag = "38";
            this.tsmBitacora.Text = "BITACORA";
            this.tsmBitacora.Click += new System.EventHandler(this.tsmBitacora_Click);
            // 
            // ucNotificacion
            // 
            this.ucNotificacion.BackColor = System.Drawing.Color.DarkGreen;
            this.ucNotificacion.IdiomaControl = 1;
            this.ucNotificacion.Location = new System.Drawing.Point(535, 64);
            this.ucNotificacion.Name = "ucNotificacion";
            this.ucNotificacion.Size = new System.Drawing.Size(236, 381);
            this.ucNotificacion.TabIndex = 0;
            this.ucNotificacion.Visible = false;
            this.ucNotificacion.Leave += new System.EventHandler(this.ucNotificacion_Leave);
            // 
            // MenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucNotificacion);
            this.Controls.Add(this.panelMenus);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.panelPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPuntoNotificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panelMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsmAlquiler;
        private System.Windows.Forms.ToolStripMenuItem tsmEquipos;
        private System.Windows.Forms.ToolStripMenuItem tsmOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem tsmReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmIdioma;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaEspañol;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaIngles;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaChino;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblNombreMenu;
        private System.Windows.Forms.Panel panelMenus;
        private System.Windows.Forms.PictureBox imgNotificacion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private NotificacionUC ucNotificacion;
        private System.Windows.Forms.PictureBox imgPuntoNotificacion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ToolStripMenuItem NuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmReservas;
        private System.Windows.Forms.ToolStripMenuItem tsmPartidos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmBitacora;
    }
}