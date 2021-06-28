
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(383, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(383, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "BAJA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(383, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoles.CausesValidation = false;
            this.cmbRoles.DisplayMember = "2";
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Items.AddRange(new object[] {
            "Gestor de cancha",
            "Organizador",
            "Jugador"});
            this.cmbRoles.Location = new System.Drawing.Point(383, 305);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(132, 21);
            this.cmbRoles.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.DoubleBuffered = true;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvUsuarios.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvUsuarios.Location = new System.Drawing.Point(84, 53);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.Size = new System.Drawing.Size(183, 320);
            this.dgvUsuarios.TabIndex = 5;
            // 
            // UsuariosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosUI";
            this.Text = "UsuariosUI";
            this.Load += new System.EventHandler(this.UsuariosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbRoles;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUsuarios;
    }
}