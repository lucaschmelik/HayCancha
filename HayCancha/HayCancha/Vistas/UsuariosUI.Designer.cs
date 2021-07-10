
namespace HayCancha
{
    partial class UsuariosUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosUI));
            this.btnActualizarPermisos = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.ddIUsuarios = new Bunifu.Framework.UI.BunifuDropdown();
            this.dgvPatentes = new System.Windows.Forms.DataGridView();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.dgvSeleccionadas = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSacar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarPatente = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCrearFamilia = new System.Windows.Forms.Button();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnTodas = new System.Windows.Forms.Button();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAgregarFamilia = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarPermisos
            // 
            this.btnActualizarPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarPermisos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarPermisos.Location = new System.Drawing.Point(465, 359);
            this.btnActualizarPermisos.Name = "btnActualizarPermisos";
            this.btnActualizarPermisos.Size = new System.Drawing.Size(92, 42);
            this.btnActualizarPermisos.TabIndex = 28;
            this.btnActualizarPermisos.Text = "ACTUALIZAR";
            this.btnActualizarPermisos.UseVisualStyleBackColor = true;
            this.btnActualizarPermisos.Click += new System.EventHandler(this.btnActualizarPermisos_Click);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Impact", 22F);
            this.lblPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPermisos.Location = new System.Drawing.Point(406, 43);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(139, 37);
            this.lblPermisos.TabIndex = 27;
            this.lblPermisos.Text = "PERMISOS";
            // 
            // ddIUsuarios
            // 
            this.ddIUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.ddIUsuarios.BorderRadius = 3;
            this.ddIUsuarios.ForeColor = System.Drawing.Color.Black;
            this.ddIUsuarios.Items = new string[0];
            this.ddIUsuarios.Location = new System.Drawing.Point(30, 54);
            this.ddIUsuarios.Name = "ddIUsuarios";
            this.ddIUsuarios.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIUsuarios.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIUsuarios.selectedIndex = -1;
            this.ddIUsuarios.Size = new System.Drawing.Size(177, 35);
            this.ddIUsuarios.TabIndex = 33;
            this.ddIUsuarios.onItemSelected += new System.EventHandler(this.ddIUsuarios_onItemSelected);
            // 
            // dgvPatentes
            // 
            this.dgvPatentes.AllowUserToAddRows = false;
            this.dgvPatentes.AllowUserToDeleteRows = false;
            this.dgvPatentes.AllowUserToResizeColumns = false;
            this.dgvPatentes.AllowUserToResizeRows = false;
            this.dgvPatentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatentes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPatentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPatentes.ColumnHeadersHeight = 30;
            this.dgvPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatentes.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPatentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPatentes.EnableHeadersVisualStyles = false;
            this.dgvPatentes.Location = new System.Drawing.Point(30, 247);
            this.dgvPatentes.MultiSelect = false;
            this.dgvPatentes.Name = "dgvPatentes";
            this.dgvPatentes.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPatentes.RowHeadersVisible = false;
            this.dgvPatentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatentes.RowTemplate.Height = 30;
            this.dgvPatentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatentes.Size = new System.Drawing.Size(177, 130);
            this.dgvPatentes.TabIndex = 34;
            // 
            // dgvFamilias
            // 
            this.dgvFamilias.AllowUserToAddRows = false;
            this.dgvFamilias.AllowUserToDeleteRows = false;
            this.dgvFamilias.AllowUserToResizeColumns = false;
            this.dgvFamilias.AllowUserToResizeRows = false;
            this.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamilias.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFamilias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFamilias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvFamilias.ColumnHeadersHeight = 30;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamilias.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvFamilias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvFamilias.EnableHeadersVisualStyles = false;
            this.dgvFamilias.Location = new System.Drawing.Point(30, 106);
            this.dgvFamilias.MultiSelect = false;
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvFamilias.RowHeadersVisible = false;
            this.dgvFamilias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFamilias.RowTemplate.Height = 30;
            this.dgvFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilias.Size = new System.Drawing.Size(177, 130);
            this.dgvFamilias.TabIndex = 35;
            this.dgvFamilias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilias_CellClick);
            // 
            // dgvSeleccionadas
            // 
            this.dgvSeleccionadas.AllowUserToAddRows = false;
            this.dgvSeleccionadas.AllowUserToDeleteRows = false;
            this.dgvSeleccionadas.AllowUserToResizeColumns = false;
            this.dgvSeleccionadas.AllowUserToResizeRows = false;
            this.dgvSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccionadas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSeleccionadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeleccionadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSeleccionadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvSeleccionadas.ColumnHeadersHeight = 30;
            this.dgvSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeleccionadas.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvSeleccionadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSeleccionadas.EnableHeadersVisualStyles = false;
            this.dgvSeleccionadas.Location = new System.Drawing.Point(266, 106);
            this.dgvSeleccionadas.MultiSelect = false;
            this.dgvSeleccionadas.Name = "dgvSeleccionadas";
            this.dgvSeleccionadas.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeleccionadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvSeleccionadas.RowHeadersVisible = false;
            this.dgvSeleccionadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSeleccionadas.RowTemplate.Height = 30;
            this.dgvSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionadas.Size = new System.Drawing.Size(177, 298);
            this.dgvSeleccionadas.TabIndex = 36;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnActualizarPermisos;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.dgvFamilias;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.dgvSeleccionadas;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.dgvPatentes;
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.Image = global::HayCancha.Properties.Resources.eliminar1;
            this.btnSacar.ImageActive = null;
            this.btnSacar.Location = new System.Drawing.Point(221, 237);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(28, 26);
            this.btnSacar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSacar.TabIndex = 30;
            this.btnSacar.TabStop = false;
            this.btnSacar.Zoom = 10;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPatente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPatente.Image")));
            this.btnAgregarPatente.ImageActive = null;
            this.btnAgregarPatente.Location = new System.Drawing.Point(221, 269);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(28, 30);
            this.btnAgregarPatente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarPatente.TabIndex = 29;
            this.btnAgregarPatente.TabStop = false;
            this.btnAgregarPatente.Zoom = 10;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // btnCrearFamilia
            // 
            this.btnCrearFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearFamilia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearFamilia.Location = new System.Drawing.Point(465, 296);
            this.btnCrearFamilia.Name = "btnCrearFamilia";
            this.btnCrearFamilia.Size = new System.Drawing.Size(92, 42);
            this.btnCrearFamilia.TabIndex = 37;
            this.btnCrearFamilia.Text = "CREAR";
            this.btnCrearFamilia.UseVisualStyleBackColor = true;
            this.btnCrearFamilia.Click += new System.EventHandler(this.btnCrearFamilia_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.btnCrearFamilia;
            // 
            // btnTodas
            // 
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
            this.btnTodas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTodas.Location = new System.Drawing.Point(159, 379);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(48, 25);
            this.btnTodas.TabIndex = 38;
            this.btnTodas.Text = "TODAS";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 15;
            this.bunifuElipse6.TargetControl = this.btnTodas;
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFamilia.Image")));
            this.btnAgregarFamilia.ImageActive = null;
            this.btnAgregarFamilia.Location = new System.Drawing.Point(221, 201);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(28, 30);
            this.btnAgregarFamilia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarFamilia.TabIndex = 39;
            this.btnAgregarFamilia.TabStop = false;
            this.btnAgregarFamilia.Zoom = 10;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // UsuariosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnAgregarFamilia);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnCrearFamilia);
            this.Controls.Add(this.dgvSeleccionadas);
            this.Controls.Add(this.dgvFamilias);
            this.Controls.Add(this.dgvPatentes);
            this.Controls.Add(this.ddIUsuarios);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregarPatente);
            this.Controls.Add(this.btnActualizarPermisos);
            this.Controls.Add(this.lblPermisos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosUI";
            this.Text = "UsuariosUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizarPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private Bunifu.Framework.UI.BunifuImageButton btnSacar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarPatente;
        private Bunifu.Framework.UI.BunifuDropdown ddIUsuarios;
        private System.Windows.Forms.DataGridView dgvPatentes;
        private System.Windows.Forms.DataGridView dgvFamilias;
        private System.Windows.Forms.DataGridView dgvSeleccionadas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Button btnCrearFamilia;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Button btnTodas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarFamilia;
    }
}