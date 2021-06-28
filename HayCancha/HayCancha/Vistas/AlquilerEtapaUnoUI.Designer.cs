
namespace HayCancha
{
    partial class AlquilerEtapaUnoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilerEtapaUnoUI));
            this.dtpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvCancha = new System.Windows.Forms.DataGridView();
            this.ddTipoCancha = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.btnSiguienteEtapaUno = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgBuscarCancha = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarCancha)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.Gainsboro;
            this.dtpFecha.BorderRadius = 10;
            this.dtpFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.FormatCustom = null;
            this.dtpFecha.Location = new System.Drawing.Point(314, 141);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 31);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.Value = new System.DateTime(2021, 6, 11, 18, 37, 3, 0);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvCancha;
            // 
            // dgvCancha
            // 
            this.dgvCancha.AllowUserToAddRows = false;
            this.dgvCancha.AllowUserToDeleteRows = false;
            this.dgvCancha.AllowUserToResizeColumns = false;
            this.dgvCancha.AllowUserToResizeRows = false;
            this.dgvCancha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCancha.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCancha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCancha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCancha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancha.ColumnHeadersHeight = 30;
            this.dgvCancha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancha.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCancha.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvCancha.EnableHeadersVisualStyles = false;
            this.dgvCancha.Location = new System.Drawing.Point(46, 99);
            this.dgvCancha.Name = "dgvCancha";
            this.dgvCancha.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancha.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCancha.RowHeadersVisible = false;
            this.dgvCancha.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCancha.RowTemplate.Height = 30;
            this.dgvCancha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancha.Size = new System.Drawing.Size(234, 269);
            this.dgvCancha.TabIndex = 5;
            // 
            // ddTipoCancha
            // 
            this.ddTipoCancha.BackColor = System.Drawing.Color.Transparent;
            this.ddTipoCancha.BorderRadius = 10;
            this.ddTipoCancha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.ddTipoCancha.ForeColor = System.Drawing.Color.Black;
            this.ddTipoCancha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ddTipoCancha.Items = new string[0];
            this.ddTipoCancha.Location = new System.Drawing.Point(314, 195);
            this.ddTipoCancha.Margin = new System.Windows.Forms.Padding(4);
            this.ddTipoCancha.Name = "ddTipoCancha";
            this.ddTipoCancha.NomalColor = System.Drawing.Color.Gainsboro;
            this.ddTipoCancha.onHoverColor = System.Drawing.Color.Gainsboro;
            this.ddTipoCancha.selectedIndex = -1;
            this.ddTipoCancha.Size = new System.Drawing.Size(209, 35);
            this.ddTipoCancha.TabIndex = 4;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.ddTipoCancha;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Impact", 22F);
            this.lblAlquiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAlquiler.Location = new System.Drawing.Point(352, 59);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(123, 37);
            this.lblAlquiler.TabIndex = 6;
            this.lblAlquiler.Text = "ALQUILER";
            // 
            // btnSiguienteEtapaUno
            // 
            this.btnSiguienteEtapaUno.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSiguienteEtapaUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiguienteEtapaUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguienteEtapaUno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteEtapaUno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiguienteEtapaUno.Location = new System.Drawing.Point(432, 335);
            this.btnSiguienteEtapaUno.Name = "btnSiguienteEtapaUno";
            this.btnSiguienteEtapaUno.Size = new System.Drawing.Size(91, 33);
            this.btnSiguienteEtapaUno.TabIndex = 7;
            this.btnSiguienteEtapaUno.Text = "SIGUIENTE";
            this.btnSiguienteEtapaUno.UseVisualStyleBackColor = false;
            this.btnSiguienteEtapaUno.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 19;
            this.bunifuElipse3.TargetControl = this.btnSiguienteEtapaUno;
            // 
            // imgBuscarCancha
            // 
            this.imgBuscarCancha.BackColor = System.Drawing.Color.Transparent;
            this.imgBuscarCancha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBuscarCancha.Image = ((System.Drawing.Image)(resources.GetObject("imgBuscarCancha.Image")));
            this.imgBuscarCancha.ImageActive = null;
            this.imgBuscarCancha.Location = new System.Drawing.Point(397, 254);
            this.imgBuscarCancha.Name = "imgBuscarCancha";
            this.imgBuscarCancha.Size = new System.Drawing.Size(49, 40);
            this.imgBuscarCancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuscarCancha.TabIndex = 1;
            this.imgBuscarCancha.TabStop = false;
            this.imgBuscarCancha.Zoom = 10;
            // 
            // AlquilerEtapaUnoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnSiguienteEtapaUno);
            this.Controls.Add(this.lblAlquiler);
            this.Controls.Add(this.dgvCancha);
            this.Controls.Add(this.ddTipoCancha);
            this.Controls.Add(this.imgBuscarCancha);
            this.Controls.Add(this.dtpFecha);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlquilerEtapaUnoUI";
            this.Text = "AlquilerUI";
            this.Load += new System.EventHandler(this.AlquilerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarCancha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dtpFecha;
        private Bunifu.Framework.UI.BunifuImageButton imgBuscarCancha;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown ddTipoCancha;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridView dgvCancha;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Button btnSiguienteEtapaUno;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}