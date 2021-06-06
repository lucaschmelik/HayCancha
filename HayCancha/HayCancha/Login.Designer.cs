
namespace HayCancha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.imgIdiomaChino = new System.Windows.Forms.PictureBox();
            this.imgIdiomaIngles = new System.Windows.Forms.PictureBox();
            this.imgIdiomaEspañol = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.imgPelota = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaChino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaIngles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaEspañol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPelota)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsuario.Location = new System.Drawing.Point(320, 212);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContraseña.Location = new System.Drawing.Point(320, 259);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(137, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.imgIdiomaChino);
            this.panel1.Controls.Add(this.imgIdiomaIngles);
            this.panel1.Controls.Add(this.imgIdiomaEspañol);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 409);
            this.panel1.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMensaje.Location = new System.Drawing.Point(28, 242);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(163, 38);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Logueate para ingresar \r\na tu cuenta";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Impact", 22F);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBienvenida.Location = new System.Drawing.Point(25, 78);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(172, 74);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIENVENIDOS\r\nHAYCANCHA!";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Silver;
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(335, 297);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(107, 33);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(354, 194);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(341, 242);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(91, 13);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "CONTRASEÑA";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(335, 346);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 33);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // imgIdiomaChino
            // 
            this.imgIdiomaChino.Image = ((System.Drawing.Image)(resources.GetObject("imgIdiomaChino.Image")));
            this.imgIdiomaChino.Location = new System.Drawing.Point(145, 310);
            this.imgIdiomaChino.Name = "imgIdiomaChino";
            this.imgIdiomaChino.Size = new System.Drawing.Size(49, 50);
            this.imgIdiomaChino.TabIndex = 5;
            this.imgIdiomaChino.TabStop = false;
            this.imgIdiomaChino.Click += new System.EventHandler(this.imgIdiomaChino_Click);
            // 
            // imgIdiomaIngles
            // 
            this.imgIdiomaIngles.Image = ((System.Drawing.Image)(resources.GetObject("imgIdiomaIngles.Image")));
            this.imgIdiomaIngles.Location = new System.Drawing.Point(90, 310);
            this.imgIdiomaIngles.Name = "imgIdiomaIngles";
            this.imgIdiomaIngles.Size = new System.Drawing.Size(49, 50);
            this.imgIdiomaIngles.TabIndex = 4;
            this.imgIdiomaIngles.TabStop = false;
            this.imgIdiomaIngles.Click += new System.EventHandler(this.imgIdiomaIngles_Click);
            // 
            // imgIdiomaEspañol
            // 
            this.imgIdiomaEspañol.Image = ((System.Drawing.Image)(resources.GetObject("imgIdiomaEspañol.Image")));
            this.imgIdiomaEspañol.Location = new System.Drawing.Point(34, 310);
            this.imgIdiomaEspañol.Name = "imgIdiomaEspañol";
            this.imgIdiomaEspañol.Size = new System.Drawing.Size(49, 50);
            this.imgIdiomaEspañol.TabIndex = 3;
            this.imgIdiomaEspañol.TabStop = false;
            this.imgIdiomaEspañol.Click += new System.EventHandler(this.imgIdiomaEspañol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imgSalir
            // 
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(514, 4);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(30, 28);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 7;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            // 
            // imgPelota
            // 
            this.imgPelota.Image = ((System.Drawing.Image)(resources.GetObject("imgPelota.Image")));
            this.imgPelota.Location = new System.Drawing.Point(327, 49);
            this.imgPelota.Name = "imgPelota";
            this.imgPelota.Size = new System.Drawing.Size(120, 117);
            this.imgPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPelota.TabIndex = 4;
            this.imgPelota.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(549, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.imgPelota);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaChino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaIngles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdiomaEspañol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgPelota;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox imgIdiomaEspañol;
        private System.Windows.Forms.PictureBox imgIdiomaIngles;
        private System.Windows.Forms.PictureBox imgIdiomaChino;
    }
}