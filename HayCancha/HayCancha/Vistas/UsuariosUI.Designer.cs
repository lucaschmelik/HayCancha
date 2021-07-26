
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosUI));
            this.btnActualizarPermisos = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.ddIUsuarios = new Bunifu.Framework.UI.BunifuDropdown();
            this.dgvPatentes = new System.Windows.Forms.DataGridView();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAgregarPatente = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCrearFamilia = new System.Windows.Forms.Button();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.trvPermisos = new System.Windows.Forms.TreeView();
            this.btnAgregarFamilia = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSacar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntAsignarPermiso = new System.Windows.Forms.Button();
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMostrarFamilia = new System.Windows.Forms.Button();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarPermisos
            // 
            this.btnActualizarPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarPermisos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarPermisos.Location = new System.Drawing.Point(361, 344);
            this.btnActualizarPermisos.Name = "btnActualizarPermisos";
            this.btnActualizarPermisos.Size = new System.Drawing.Size(177, 42);
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
            this.lblPermisos.Location = new System.Drawing.Point(382, 42);
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
            this.ddIUsuarios.Location = new System.Drawing.Point(361, 103);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPatentes.ColumnHeadersHeight = 30;
            this.dgvPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatentes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPatentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvPatentes.EnableHeadersVisualStyles = false;
            this.dgvPatentes.Location = new System.Drawing.Point(187, 103);
            this.dgvPatentes.MultiSelect = false;
            this.dgvPatentes.Name = "dgvPatentes";
            this.dgvPatentes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPatentes.RowHeadersVisible = false;
            this.dgvPatentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatentes.RowTemplate.Height = 30;
            this.dgvPatentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatentes.Size = new System.Drawing.Size(137, 130);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFamilias.ColumnHeadersHeight = 30;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamilias.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFamilias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvFamilias.EnableHeadersVisualStyles = false;
            this.dgvFamilias.Location = new System.Drawing.Point(30, 103);
            this.dgvFamilias.MultiSelect = false;
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFamilias.RowHeadersVisible = false;
            this.dgvFamilias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFamilias.RowTemplate.Height = 30;
            this.dgvFamilias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilias.Size = new System.Drawing.Size(137, 130);
            this.dgvFamilias.TabIndex = 35;
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
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.dgvPatentes;
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPatente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPatente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPatente.Image")));
            this.btnAgregarPatente.ImageActive = null;
            this.btnAgregarPatente.Location = new System.Drawing.Point(241, 239);
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
            this.btnCrearFamilia.Location = new System.Drawing.Point(361, 296);
            this.btnCrearFamilia.Name = "btnCrearFamilia";
            this.btnCrearFamilia.Size = new System.Drawing.Size(177, 42);
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
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.trvPermisos;
            // 
            // trvPermisos
            // 
            this.trvPermisos.BackColor = System.Drawing.Color.Gainsboro;
            this.trvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvPermisos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.trvPermisos.Location = new System.Drawing.Point(30, 280);
            this.trvPermisos.Name = "trvPermisos";
            this.trvPermisos.Size = new System.Drawing.Size(294, 121);
            this.trvPermisos.TabIndex = 40;
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFamilia.Image")));
            this.btnAgregarFamilia.ImageActive = null;
            this.btnAgregarFamilia.Location = new System.Drawing.Point(83, 239);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(28, 30);
            this.btnAgregarFamilia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarFamilia.TabIndex = 39;
            this.btnAgregarFamilia.TabStop = false;
            this.btnAgregarFamilia.Zoom = 10;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.Image = ((System.Drawing.Image)(resources.GetObject("btnSacar.Image")));
            this.btnSacar.ImageActive = null;
            this.btnSacar.Location = new System.Drawing.Point(167, 239);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(21, 31);
            this.btnSacar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSacar.TabIndex = 30;
            this.btnSacar.TabStop = false;
            this.btnSacar.Zoom = 10;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // bntAsignarPermiso
            // 
            this.bntAsignarPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAsignarPermiso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAsignarPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntAsignarPermiso.Location = new System.Drawing.Point(361, 144);
            this.bntAsignarPermiso.Name = "bntAsignarPermiso";
            this.bntAsignarPermiso.Size = new System.Drawing.Size(177, 42);
            this.bntAsignarPermiso.TabIndex = 41;
            this.bntAsignarPermiso.Text = "ASIGNAR PERMISO";
            this.bntAsignarPermiso.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 15;
            this.bunifuElipse7.TargetControl = this.bntAsignarPermiso;
            // 
            // btnMostrarFamilia
            // 
            this.btnMostrarFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarFamilia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarFamilia.Location = new System.Drawing.Point(361, 192);
            this.btnMostrarFamilia.Name = "btnMostrarFamilia";
            this.btnMostrarFamilia.Size = new System.Drawing.Size(177, 42);
            this.btnMostrarFamilia.TabIndex = 42;
            this.btnMostrarFamilia.Text = "MOSTRAR FAMILIA";
            this.btnMostrarFamilia.UseVisualStyleBackColor = true;
            this.btnMostrarFamilia.Click += new System.EventHandler(this.btnMostrarFamilia_Click);
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 15;
            this.bunifuElipse8.TargetControl = this.btnMostrarFamilia;
            // 
            // UsuariosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnMostrarFamilia);
            this.Controls.Add(this.bntAsignarPermiso);
            this.Controls.Add(this.trvPermisos);
            this.Controls.Add(this.btnAgregarFamilia);
            this.Controls.Add(this.btnCrearFamilia);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSacar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizarPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarPatente;
        private Bunifu.Framework.UI.BunifuDropdown ddIUsuarios;
        private System.Windows.Forms.DataGridView dgvPatentes;
        private System.Windows.Forms.DataGridView dgvFamilias;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Button btnCrearFamilia;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregarFamilia;
        private System.Windows.Forms.TreeView trvPermisos;
        private Bunifu.Framework.UI.BunifuImageButton btnSacar;
        private System.Windows.Forms.Button bntAsignarPermiso;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.Button btnMostrarFamilia;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
    }
}