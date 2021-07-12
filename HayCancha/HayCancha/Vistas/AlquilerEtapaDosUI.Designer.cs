
namespace HayCancha
{
    partial class AlquilerEtapaDosUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilerEtapaDosUI));
            this.lblJugadores = new System.Windows.Forms.Label();
            this.btnEnviarAutorizarEtapaDos = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvEncontrado = new System.Windows.Forms.DataGridView();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvSeleccionado = new System.Windows.Forms.DataGridView();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblBuscarJugadorEtapaDos = new System.Windows.Forms.Label();
            this.lblContadorJugadores = new System.Windows.Forms.Label();
            this.btnSacar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncontrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Font = new System.Drawing.Font("Impact", 22F);
            this.lblJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJugadores.Location = new System.Drawing.Point(352, 59);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(152, 37);
            this.lblJugadores.TabIndex = 7;
            this.lblJugadores.Text = "JUGADORES";
            // 
            // btnEnviarAutorizarEtapaDos
            // 
            this.btnEnviarAutorizarEtapaDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarAutorizarEtapaDos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarAutorizarEtapaDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviarAutorizarEtapaDos.Location = new System.Drawing.Point(443, 325);
            this.btnEnviarAutorizarEtapaDos.Name = "btnEnviarAutorizarEtapaDos";
            this.btnEnviarAutorizarEtapaDos.Size = new System.Drawing.Size(103, 42);
            this.btnEnviarAutorizarEtapaDos.TabIndex = 8;
            this.btnEnviarAutorizarEtapaDos.Text = "ENVIAR A AUTORIZAR";
            this.btnEnviarAutorizarEtapaDos.UseVisualStyleBackColor = true;
            this.btnEnviarAutorizarEtapaDos.Click += new System.EventHandler(this.btnEnviarAutorizar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 19;
            this.bunifuElipse1.TargetControl = this.btnEnviarAutorizarEtapaDos;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 11F);
            this.txtBuscar.Location = new System.Drawing.Point(30, 102);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 22);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.dgvEncontrado;
            // 
            // dgvEncontrado
            // 
            this.dgvEncontrado.AllowUserToAddRows = false;
            this.dgvEncontrado.AllowUserToDeleteRows = false;
            this.dgvEncontrado.AllowUserToResizeColumns = false;
            this.dgvEncontrado.AllowUserToResizeRows = false;
            this.dgvEncontrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncontrado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEncontrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEncontrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEncontrado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncontrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncontrado.ColumnHeadersHeight = 30;
            this.dgvEncontrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncontrado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEncontrado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvEncontrado.EnableHeadersVisualStyles = false;
            this.dgvEncontrado.Location = new System.Drawing.Point(30, 143);
            this.dgvEncontrado.MultiSelect = false;
            this.dgvEncontrado.Name = "dgvEncontrado";
            this.dgvEncontrado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncontrado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEncontrado.RowHeadersVisible = false;
            this.dgvEncontrado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEncontrado.RowTemplate.Height = 30;
            this.dgvEncontrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncontrado.Size = new System.Drawing.Size(144, 224);
            this.dgvEncontrado.TabIndex = 37;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.dgvSeleccionado;
            // 
            // dgvSeleccionado
            // 
            this.dgvSeleccionado.AllowUserToAddRows = false;
            this.dgvSeleccionado.AllowUserToDeleteRows = false;
            this.dgvSeleccionado.AllowUserToResizeColumns = false;
            this.dgvSeleccionado.AllowUserToResizeRows = false;
            this.dgvSeleccionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccionado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeleccionado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSeleccionado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeleccionado.ColumnHeadersHeight = 30;
            this.dgvSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeleccionado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSeleccionado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSeleccionado.EnableHeadersVisualStyles = false;
            this.dgvSeleccionado.Location = new System.Drawing.Point(252, 143);
            this.dgvSeleccionado.MultiSelect = false;
            this.dgvSeleccionado.Name = "dgvSeleccionado";
            this.dgvSeleccionado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSeleccionado.RowHeadersVisible = false;
            this.dgvSeleccionado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeleccionado.RowTemplate.Height = 30;
            this.dgvSeleccionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionado.Size = new System.Drawing.Size(144, 224);
            this.dgvSeleccionado.TabIndex = 38;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 2;
            this.bunifuElipse4.TargetControl = this.txtBuscar;
            // 
            // lblBuscarJugadorEtapaDos
            // 
            this.lblBuscarJugadorEtapaDos.AutoSize = true;
            this.lblBuscarJugadorEtapaDos.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBuscarJugadorEtapaDos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblBuscarJugadorEtapaDos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBuscarJugadorEtapaDos.Location = new System.Drawing.Point(53, 105);
            this.lblBuscarJugadorEtapaDos.Name = "lblBuscarJugadorEtapaDos";
            this.lblBuscarJugadorEtapaDos.Size = new System.Drawing.Size(102, 15);
            this.lblBuscarJugadorEtapaDos.TabIndex = 17;
            this.lblBuscarJugadorEtapaDos.Text = "Buscar jugador ...";
            this.lblBuscarJugadorEtapaDos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblBuscar_MouseClick);
            // 
            // lblContadorJugadores
            // 
            this.lblContadorJugadores.AutoSize = true;
            this.lblContadorJugadores.Font = new System.Drawing.Font("Impact", 15F);
            this.lblContadorJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblContadorJugadores.Location = new System.Drawing.Point(345, 373);
            this.lblContadorJugadores.Name = "lblContadorJugadores";
            this.lblContadorJugadores.Size = new System.Drawing.Size(50, 25);
            this.lblContadorJugadores.TabIndex = 39;
            this.lblContadorJugadores.Text = "0 / 0";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.Image = ((System.Drawing.Image)(resources.GetObject("btnSacar.Image")));
            this.btnSacar.ImageActive = null;
            this.btnSacar.Location = new System.Drawing.Point(200, 231);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(28, 26);
            this.btnSacar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSacar.TabIndex = 14;
            this.btnSacar.TabStop = false;
            this.btnSacar.Zoom = 10;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageActive = null;
            this.btnAgregar.Location = new System.Drawing.Point(200, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 26);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Zoom = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // imgBuscar
            // 
            this.imgBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBuscar.Image = global::HayCancha.Properties.Resources.Buscar;
            this.imgBuscar.Location = new System.Drawing.Point(180, 102);
            this.imgBuscar.Name = "imgBuscar";
            this.imgBuscar.Size = new System.Drawing.Size(27, 22);
            this.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuscar.TabIndex = 12;
            this.imgBuscar.TabStop = false;
            this.imgBuscar.Click += new System.EventHandler(this.imgBuscar_Click);
            // 
            // AlquilerEtapaDosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.lblContadorJugadores);
            this.Controls.Add(this.dgvSeleccionado);
            this.Controls.Add(this.dgvEncontrado);
            this.Controls.Add(this.lblBuscarJugadorEtapaDos);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.imgBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEnviarAutorizarEtapaDos);
            this.Controls.Add(this.lblJugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlquilerEtapaDosUI";
            this.Text = "AlquilerEtapaDosUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncontrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.Button btnEnviarAutorizarEtapaDos;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox imgBuscar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnSacar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Label lblBuscarJugadorEtapaDos;
        private System.Windows.Forms.DataGridView dgvEncontrado;
        private System.Windows.Forms.DataGridView dgvSeleccionado;
        private System.Windows.Forms.Label lblContadorJugadores;
    }
}