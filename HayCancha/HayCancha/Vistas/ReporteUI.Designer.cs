
namespace HayCancha.Vistas
{
    partial class ReporteUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.ddIReporte = new Bunifu.Framework.UI.BunifuDropdown();
            this.rdbCanchas = new System.Windows.Forms.RadioButton();
            this.rdbJugadores = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtFechaHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.Location = new System.Drawing.Point(398, 348);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 31);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Impact", 22F);
            this.lblReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReportes.Location = new System.Drawing.Point(382, 42);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(134, 37);
            this.lblReportes.TabIndex = 32;
            this.lblReportes.Text = "REPORTES";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 18;
            this.bunifuElipse4.TargetControl = this.btnGenerarPDF;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarPDF.Location = new System.Drawing.Point(398, 311);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(126, 31);
            this.btnGenerarPDF.TabIndex = 43;
            this.btnGenerarPDF.Text = "GENERAR PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 18;
            this.bunifuElipse5.TargetControl = this.btnConsultar;
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToResizeColumns = false;
            this.dgvReporte.AllowUserToResizeRows = false;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReporte.ColumnHeadersHeight = 45;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.Location = new System.Drawing.Point(31, 107);
            this.dgvReporte.MultiSelect = false;
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReporte.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReporte.RowTemplate.Height = 30;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.Size = new System.Drawing.Size(493, 130);
            this.dgvReporte.TabIndex = 37;
            // 
            // ddIReporte
            // 
            this.ddIReporte.BackColor = System.Drawing.Color.Transparent;
            this.ddIReporte.BorderRadius = 3;
            this.ddIReporte.ForeColor = System.Drawing.Color.Black;
            this.ddIReporte.Items = new string[0];
            this.ddIReporte.Location = new System.Drawing.Point(31, 254);
            this.ddIReporte.Name = "ddIReporte";
            this.ddIReporte.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIReporte.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIReporte.selectedIndex = -1;
            this.ddIReporte.Size = new System.Drawing.Size(493, 35);
            this.ddIReporte.TabIndex = 38;
            // 
            // rdbCanchas
            // 
            this.rdbCanchas.AutoSize = true;
            this.rdbCanchas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbCanchas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.rdbCanchas.Location = new System.Drawing.Point(266, 353);
            this.rdbCanchas.Name = "rdbCanchas";
            this.rdbCanchas.Size = new System.Drawing.Size(95, 21);
            this.rdbCanchas.TabIndex = 39;
            this.rdbCanchas.Text = "CANCHAS";
            this.rdbCanchas.UseVisualStyleBackColor = true;
            this.rdbCanchas.CheckedChanged += new System.EventHandler(this.rdbCanchas_CheckedChanged);
            // 
            // rdbJugadores
            // 
            this.rdbJugadores.AutoSize = true;
            this.rdbJugadores.Checked = true;
            this.rdbJugadores.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.rdbJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.rdbJugadores.Location = new System.Drawing.Point(266, 323);
            this.rdbJugadores.Name = "rdbJugadores";
            this.rdbJugadores.Size = new System.Drawing.Size(108, 21);
            this.rdbJugadores.TabIndex = 41;
            this.rdbJugadores.TabStop = true;
            this.rdbJugadores.Text = "JUGADORES";
            this.rdbJugadores.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(17, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "HASTA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(17, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "DESDE :";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.BackColor = System.Drawing.Color.Gainsboro;
            this.dtFechaDesde.BorderRadius = 10;
            this.dtFechaDesde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dtFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.FormatCustom = null;
            this.dtFechaDesde.Location = new System.Drawing.Point(73, 311);
            this.dtFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(153, 31);
            this.dtFechaDesde.TabIndex = 44;
            this.dtFechaDesde.Value = new System.DateTime(2021, 9, 7, 0, 0, 0, 0);
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.BackColor = System.Drawing.Color.Gainsboro;
            this.dtFechaHasta.BorderRadius = 10;
            this.dtFechaHasta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.dtFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.FormatCustom = null;
            this.dtFechaHasta.Location = new System.Drawing.Point(73, 350);
            this.dtFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(153, 31);
            this.dtFechaHasta.TabIndex = 43;
            this.dtFechaHasta.Value = new System.DateTime(2021, 9, 6, 0, 0, 0, 0);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.ddIReporte;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 12;
            this.bunifuElipse3.TargetControl = this.dgvReporte;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ReporteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbJugadores);
            this.Controls.Add(this.rdbCanchas);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.ddIReporte);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteUI";
            this.Text = "ReporteUI";
            this.Load += new System.EventHandler(this.ReporteUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblReportes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.DataGridView dgvReporte;
        private Bunifu.Framework.UI.BunifuDropdown ddIReporte;
        private System.Windows.Forms.RadioButton rdbCanchas;
        private System.Windows.Forms.RadioButton rdbJugadores;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaDesde;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaHasta;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}