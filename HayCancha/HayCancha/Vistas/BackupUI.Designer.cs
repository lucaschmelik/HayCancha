
namespace HayCancha.Vistas
{
    partial class BackupUI
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
            this.dgvBackup = new System.Windows.Forms.DataGridView();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBackup = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBackup
            // 
            this.dgvBackup.AllowUserToAddRows = false;
            this.dgvBackup.AllowUserToDeleteRows = false;
            this.dgvBackup.AllowUserToResizeColumns = false;
            this.dgvBackup.AllowUserToResizeRows = false;
            this.dgvBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBackup.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBackup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBackup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBackup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBackup.ColumnHeadersHeight = 30;
            this.dgvBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo,
            this.Ruta});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBackup.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBackup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvBackup.EnableHeadersVisualStyles = false;
            this.dgvBackup.Location = new System.Drawing.Point(33, 127);
            this.dgvBackup.Name = "dgvBackup";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBackup.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBackup.RowHeadersVisible = false;
            this.dgvBackup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBackup.RowTemplate.Height = 30;
            this.dgvBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBackup.Size = new System.Drawing.Size(511, 190);
            this.dgvBackup.TabIndex = 29;
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "ARCHIVO";
            this.Archivo.Name = "Archivo";
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "RUTA";
            this.Ruta.Name = "Ruta";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Impact", 22F);
            this.lblBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBackup.Location = new System.Drawing.Point(383, 63);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(134, 37);
            this.lblBackup.TabIndex = 28;
            this.lblBackup.Text = "RESPALDO";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvBackup;
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpProvider1.SetHelpString(this.btnBackup, "Botón para realizar un respaldo");
            this.btnBackup.Location = new System.Drawing.Point(342, 343);
            this.btnBackup.Name = "btnBackup";
            this.helpProvider1.SetShowHelp(this.btnBackup, true);
            this.btnBackup.Size = new System.Drawing.Size(92, 42);
            this.btnBackup.TabIndex = 31;
            this.btnBackup.Text = "RESPALDO";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpProvider1.SetHelpString(this.btnRestore, "Botón para restaurar el respaldo seleccionado");
            this.btnRestore.Location = new System.Drawing.Point(452, 343);
            this.btnRestore.Name = "btnRestore";
            this.helpProvider1.SetShowHelp(this.btnRestore, true);
            this.btnRestore.Size = new System.Drawing.Size(92, 42);
            this.btnRestore.TabIndex = 30;
            this.btnRestore.Text = "RESTAURAR";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 18;
            this.bunifuElipse4.TargetControl = this.btnBackup;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 18;
            this.bunifuElipse5.TargetControl = this.btnRestore;
            // 
            // BackupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dgvBackup);
            this.Controls.Add(this.lblBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupUI";
            this.Text = "BackupUI";
            this.Load += new System.EventHandler(this.BackupUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBackup;
        private System.Windows.Forms.Label lblBackup;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}