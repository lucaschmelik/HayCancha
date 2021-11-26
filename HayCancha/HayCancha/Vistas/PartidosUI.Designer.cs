
namespace HayCancha.Vistas
{
    partial class PartidosUI
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
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPartidos = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpProvider1.SetHelpString(this.btnRechazar, "Botón para rechazar el partido seleccionado");
            this.btnRechazar.Location = new System.Drawing.Point(442, 351);
            this.btnRechazar.Name = "btnRechazar";
            this.helpProvider1.SetShowHelp(this.btnRechazar, true);
            this.btnRechazar.Size = new System.Drawing.Size(91, 33);
            this.btnRechazar.TabIndex = 19;
            this.btnRechazar.Text = "RECHAZAR";
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpProvider1.SetHelpString(this.btnAceptar, "Botón para autorizar el partido seleccionado");
            this.btnAceptar.Location = new System.Drawing.Point(336, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.helpProvider1.SetShowHelp(this.btnAceptar, true);
            this.btnAceptar.Size = new System.Drawing.Size(91, 33);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPartidos
            // 
            this.lblPartidos.AutoSize = true;
            this.lblPartidos.Font = new System.Drawing.Font("Impact", 22F);
            this.lblPartidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartidos.Location = new System.Drawing.Point(374, 39);
            this.lblPartidos.Name = "lblPartidos";
            this.lblPartidos.Size = new System.Drawing.Size(134, 37);
            this.lblPartidos.TabIndex = 17;
            this.lblPartidos.Text = "PARTIDOS";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AllowUserToResizeColumns = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReservas.ColumnHeadersHeight = 30;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.Location = new System.Drawing.Point(36, 114);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservas.RowTemplate.Height = 30;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(497, 211);
            this.dgvReservas.TabIndex = 16;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.dgvReservas;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.btnAceptar;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnRechazar;
            // 
            // PartidosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPartidos);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartidosUI";
            this.Text = "PartidosUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPartidos;
        private System.Windows.Forms.DataGridView dgvReservas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}