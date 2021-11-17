
namespace HayCancha.Vistas
{
    partial class BitacoraUI
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
            this.lblBitacora = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtFechaHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ddTipoEvento = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblIngresarMensaje = new System.Windows.Forms.Label();
            this.txtIngresarMensaje = new System.Windows.Forms.TextBox();
            this.lblIngresarUsuario = new System.Windows.Forms.Label();
            this.txtIngresarUsuario = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtFechaDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.Font = new System.Drawing.Font("Impact", 22F);
            this.lblBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBitacora.Location = new System.Drawing.Point(384, 46);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(135, 37);
            this.lblBitacora.TabIndex = 9;
            this.lblBitacora.Text = "BITACORA";
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacora.ColumnHeadersHeight = 30;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.Location = new System.Drawing.Point(15, 110);
            this.dgvBitacora.Name = "dgvBitacora";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBitacora.RowTemplate.Height = 30;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(542, 190);
            this.dgvBitacora.TabIndex = 27;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvBitacora;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.BackColor = System.Drawing.Color.Gainsboro;
            this.dtFechaHasta.BorderRadius = 10;
            this.dtFechaHasta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dtFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.FormatCustom = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(66, 367);
            this.dtFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(153, 31);
            this.dtFechaHasta.TabIndex = 28;
            this.dtFechaHasta.Value = new System.DateTime(2021, 9, 6, 0, 0, 0, 0);
            // 
            // ddTipoEvento
            // 
            this.ddTipoEvento.BackColor = System.Drawing.Color.Transparent;
            this.ddTipoEvento.BorderRadius = 10;
            this.ddTipoEvento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.ddTipoEvento.ForeColor = System.Drawing.Color.Black;
            this.ddTipoEvento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ddTipoEvento.Items = new string[0];
            this.ddTipoEvento.Location = new System.Drawing.Point(248, 328);
            this.ddTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.ddTipoEvento.Name = "ddTipoEvento";
            this.ddTipoEvento.NomalColor = System.Drawing.Color.Gainsboro;
            this.ddTipoEvento.onHoverColor = System.Drawing.Color.Gainsboro;
            this.ddTipoEvento.selectedIndex = -1;
            this.ddTipoEvento.Size = new System.Drawing.Size(144, 31);
            this.ddTipoEvento.TabIndex = 29;
            this.ddTipoEvento.onItemSelected += new System.EventHandler(this.ddTipoEvento_onItemSelected);
            // 
            // lblIngresarMensaje
            // 
            this.lblIngresarMensaje.AutoSize = true;
            this.lblIngresarMensaje.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIngresarMensaje.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarMensaje.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIngresarMensaje.Location = new System.Drawing.Point(254, 374);
            this.lblIngresarMensaje.Name = "lblIngresarMensaje";
            this.lblIngresarMensaje.Size = new System.Drawing.Size(130, 14);
            this.lblIngresarMensaje.TabIndex = 33;
            this.lblIngresarMensaje.Text = "          输入消息               ";
            this.lblIngresarMensaje.Click += new System.EventHandler(this.lblIngresarMensaje_Click);
            // 
            // txtIngresarMensaje
            // 
            this.txtIngresarMensaje.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIngresarMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresarMensaje.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarMensaje.Location = new System.Drawing.Point(248, 367);
            this.txtIngresarMensaje.Multiline = true;
            this.txtIngresarMensaje.Name = "txtIngresarMensaje";
            this.txtIngresarMensaje.Size = new System.Drawing.Size(144, 31);
            this.txtIngresarMensaje.TabIndex = 32;
            this.txtIngresarMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIngresarUsuario
            // 
            this.lblIngresarUsuario.AutoSize = true;
            this.lblIngresarUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIngresarUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIngresarUsuario.Location = new System.Drawing.Point(423, 335);
            this.lblIngresarUsuario.Name = "lblIngresarUsuario";
            this.lblIngresarUsuario.Size = new System.Drawing.Size(120, 14);
            this.lblIngresarUsuario.TabIndex = 35;
            this.lblIngresarUsuario.Text = "           Set user             ";
            this.lblIngresarUsuario.Click += new System.EventHandler(this.lblIngresarUsuario_Click);
            // 
            // txtIngresarUsuario
            // 
            this.txtIngresarUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIngresarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresarUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarUsuario.Location = new System.Drawing.Point(417, 328);
            this.txtIngresarUsuario.Multiline = true;
            this.txtIngresarUsuario.Name = "txtIngresarUsuario";
            this.txtIngresarUsuario.Size = new System.Drawing.Size(132, 31);
            this.txtIngresarUsuario.TabIndex = 34;
            this.txtIngresarUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.Location = new System.Drawing.Point(417, 367);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(132, 31);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTipoEvento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTipoEvento.Location = new System.Drawing.Point(283, 335);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(64, 14);
            this.lblTipoEvento.TabIndex = 37;
            this.lblTipoEvento.Text = "Tipo evento";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.btnFiltrar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.ddTipoEvento;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.txtIngresarUsuario;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.txtIngresarMensaje;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.BackColor = System.Drawing.Color.Gainsboro;
            this.dtFechaDesde.BorderRadius = 10;
            this.dtFechaDesde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dtFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.FormatCustom = null;
            this.dtFechaDesde.Location = new System.Drawing.Point(66, 328);
            this.dtFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(153, 31);
            this.dtFechaDesde.TabIndex = 38;
            this.dtFechaDesde.Value = new System.DateTime(2021, 9, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(10, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "DESDE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(10, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "HASTA :";
            // 
            // BitacoraUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblIngresarUsuario);
            this.Controls.Add(this.txtIngresarUsuario);
            this.Controls.Add(this.lblIngresarMensaje);
            this.Controls.Add(this.txtIngresarMensaje);
            this.Controls.Add(this.ddTipoEvento);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.lblBitacora);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BitacoraUI";
            this.Text = "BitacoraUI";
            this.Load += new System.EventHandler(this.BitacoraUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaHasta;
        private Bunifu.Framework.UI.BunifuDropdown ddTipoEvento;
        private System.Windows.Forms.Label lblIngresarMensaje;
        private System.Windows.Forms.TextBox txtIngresarMensaje;
        private System.Windows.Forms.Label lblIngresarUsuario;
        private System.Windows.Forms.TextBox txtIngresarUsuario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTipoEvento;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}