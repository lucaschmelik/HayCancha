
namespace HayCancha
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuariosAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuariosBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuariosModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuariosConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEquipos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.tsmIdiomaEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdiomaIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIdiomaChino = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuarios,
            this.tsmAlquiler,
            this.tsmEquipos,
            this.tsmEstadisticas,
            this.tsmReportes,
            this.tsmOpciones,
            this.tsmIdioma,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuariosAlta,
            this.tsmUsuariosBaja,
            this.tsmUsuariosModificacion,
            this.tsmUsuariosConsulta});
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(74, 20);
            this.tsmUsuarios.Text = "USUARIOS";
            // 
            // tsmUsuariosAlta
            // 
            this.tsmUsuariosAlta.Name = "tsmUsuariosAlta";
            this.tsmUsuariosAlta.Size = new System.Drawing.Size(159, 22);
            this.tsmUsuariosAlta.Text = "ALTA";
            // 
            // tsmUsuariosBaja
            // 
            this.tsmUsuariosBaja.Name = "tsmUsuariosBaja";
            this.tsmUsuariosBaja.Size = new System.Drawing.Size(159, 22);
            this.tsmUsuariosBaja.Text = "BAJA";
            // 
            // tsmUsuariosModificacion
            // 
            this.tsmUsuariosModificacion.Name = "tsmUsuariosModificacion";
            this.tsmUsuariosModificacion.Size = new System.Drawing.Size(159, 22);
            this.tsmUsuariosModificacion.Text = "MODIFICACION";
            // 
            // tsmUsuariosConsulta
            // 
            this.tsmUsuariosConsulta.Name = "tsmUsuariosConsulta";
            this.tsmUsuariosConsulta.Size = new System.Drawing.Size(159, 22);
            this.tsmUsuariosConsulta.Text = "CONSULTA";
            // 
            // tsmAlquiler
            // 
            this.tsmAlquiler.Name = "tsmAlquiler";
            this.tsmAlquiler.Size = new System.Drawing.Size(72, 20);
            this.tsmAlquiler.Text = "ALQUILER";
            // 
            // tsmEquipos
            // 
            this.tsmEquipos.Name = "tsmEquipos";
            this.tsmEquipos.Size = new System.Drawing.Size(67, 20);
            this.tsmEquipos.Text = "EQUIPOS";
            // 
            // tsmEstadisticas
            // 
            this.tsmEstadisticas.Name = "tsmEstadisticas";
            this.tsmEstadisticas.Size = new System.Drawing.Size(92, 20);
            this.tsmEstadisticas.Text = "ESTADISTICAS";
            // 
            // tsmReportes
            // 
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(72, 20);
            this.tsmReportes.Text = "REPORTES";
            // 
            // tsmOpciones
            // 
            this.tsmOpciones.Name = "tsmOpciones";
            this.tsmOpciones.Size = new System.Drawing.Size(76, 20);
            this.tsmOpciones.Text = "OPCIONES";
            // 
            // tsmIdioma
            // 
            this.tsmIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIdiomaEspañol,
            this.tsmIdiomaIngles,
            this.tsmIdiomaChino});
            this.tsmIdioma.Name = "tsmIdioma";
            this.tsmIdioma.Size = new System.Drawing.Size(61, 20);
            this.tsmIdioma.Text = "IDIOMA";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(49, 20);
            this.tsmSalir.Text = "SALIR";
            this.tsmSalir.Click += new System.EventHandler(this.btnMenuSalir_Click);
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.White;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(770, 0);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(21, 24);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 8;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmAlquiler;
        private System.Windows.Forms.ToolStripMenuItem tsmEquipos;
        private System.Windows.Forms.ToolStripMenuItem tsmOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuariosAlta;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuariosBaja;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuariosModificacion;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuariosConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem tsmReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmIdioma;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaEspañol;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaIngles;
        private System.Windows.Forms.ToolStripMenuItem tsmIdiomaChino;
    }
}