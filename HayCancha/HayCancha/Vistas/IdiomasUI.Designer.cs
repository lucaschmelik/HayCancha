
namespace HayCancha.Vistas
{
    partial class IdiomasUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblIngresarIdioma = new System.Windows.Forms.Label();
            this.txtIngresarIdioma = new System.Windows.Forms.TextBox();
            this.btnRegistrarIdioma = new System.Windows.Forms.Button();
            this.dgvIdiomas = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ddIdiomasPersonalizados = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnActualizarIdioma = new System.Windows.Forms.Button();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgOk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Impact", 22F);
            this.lblIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdioma.Location = new System.Drawing.Point(400, 49);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(105, 37);
            this.lblIdioma.TabIndex = 8;
            this.lblIdioma.Text = "IDIOMA";
            // 
            // lblIngresarIdioma
            // 
            this.lblIngresarIdioma.AutoSize = true;
            this.lblIngresarIdioma.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIngresarIdioma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarIdioma.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIngresarIdioma.Location = new System.Drawing.Point(36, 96);
            this.lblIngresarIdioma.Name = "lblIngresarIdioma";
            this.lblIngresarIdioma.Size = new System.Drawing.Size(155, 14);
            this.lblIngresarIdioma.TabIndex = 25;
            this.lblIngresarIdioma.Text = "Ingresar nombre del idioma ...";
            this.lblIngresarIdioma.Click += new System.EventHandler(this.lblIngresarIdioma_Click);
            // 
            // txtIngresarIdioma
            // 
            this.txtIngresarIdioma.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIngresarIdioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngresarIdioma.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarIdioma.Location = new System.Drawing.Point(27, 92);
            this.txtIngresarIdioma.Multiline = true;
            this.txtIngresarIdioma.Name = "txtIngresarIdioma";
            this.txtIngresarIdioma.Size = new System.Drawing.Size(164, 23);
            this.txtIngresarIdioma.TabIndex = 19;
            this.txtIngresarIdioma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngresarIdioma.TextChanged += new System.EventHandler(this.txtIngresarIdioma_TextChanged);
            // 
            // btnRegistrarIdioma
            // 
            this.btnRegistrarIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarIdioma.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarIdioma.Location = new System.Drawing.Point(453, 341);
            this.btnRegistrarIdioma.Name = "btnRegistrarIdioma";
            this.btnRegistrarIdioma.Size = new System.Drawing.Size(92, 42);
            this.btnRegistrarIdioma.TabIndex = 18;
            this.btnRegistrarIdioma.Text = "REGISTRAR";
            this.btnRegistrarIdioma.UseVisualStyleBackColor = true;
            this.btnRegistrarIdioma.Click += new System.EventHandler(this.btnRegistrarIdioma_Click);
            // 
            // dgvIdiomas
            // 
            this.dgvIdiomas.AllowUserToAddRows = false;
            this.dgvIdiomas.AllowUserToDeleteRows = false;
            this.dgvIdiomas.AllowUserToResizeColumns = false;
            this.dgvIdiomas.AllowUserToResizeRows = false;
            this.dgvIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIdiomas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvIdiomas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIdiomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIdiomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdiomas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIdiomas.ColumnHeadersHeight = 30;
            this.dgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIdiomas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIdiomas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvIdiomas.EnableHeadersVisualStyles = false;
            this.dgvIdiomas.Location = new System.Drawing.Point(12, 134);
            this.dgvIdiomas.Name = "dgvIdiomas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIdiomas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIdiomas.RowHeadersVisible = false;
            this.dgvIdiomas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIdiomas.RowTemplate.Height = 30;
            this.dgvIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIdiomas.Size = new System.Drawing.Size(533, 175);
            this.dgvIdiomas.TabIndex = 26;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dgvIdiomas;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 2;
            this.bunifuElipse2.TargetControl = this.txtIngresarIdioma;
            // 
            // ddIdiomasPersonalizados
            // 
            this.ddIdiomasPersonalizados.BackColor = System.Drawing.Color.Transparent;
            this.ddIdiomasPersonalizados.BorderRadius = 3;
            this.ddIdiomasPersonalizados.ForeColor = System.Drawing.Color.Black;
            this.ddIdiomasPersonalizados.Items = new string[0];
            this.ddIdiomasPersonalizados.Location = new System.Drawing.Point(15, 345);
            this.ddIdiomasPersonalizados.Name = "ddIdiomasPersonalizados";
            this.ddIdiomasPersonalizados.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIdiomasPersonalizados.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ddIdiomasPersonalizados.selectedIndex = -1;
            this.ddIdiomasPersonalizados.Size = new System.Drawing.Size(217, 35);
            this.ddIdiomasPersonalizados.TabIndex = 27;
            this.ddIdiomasPersonalizados.onItemSelected += new System.EventHandler(this.ddlIdiomasPersonalizados_onItemSelected);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.ddIdiomasPersonalizados;
            // 
            // btnActualizarIdioma
            // 
            this.btnActualizarIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarIdioma.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarIdioma.Location = new System.Drawing.Point(343, 341);
            this.btnActualizarIdioma.Name = "btnActualizarIdioma";
            this.btnActualizarIdioma.Size = new System.Drawing.Size(92, 42);
            this.btnActualizarIdioma.TabIndex = 29;
            this.btnActualizarIdioma.Text = "ACTUALIZAR";
            this.btnActualizarIdioma.UseVisualStyleBackColor = true;
            this.btnActualizarIdioma.Click += new System.EventHandler(this.btnActualizarIdioma_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 18;
            this.bunifuElipse4.TargetControl = this.btnActualizarIdioma;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 18;
            this.bunifuElipse5.TargetControl = this.btnRegistrarIdioma;
            // 
            // imgOk
            // 
            this.imgOk.Image = global::HayCancha.Properties.Resources.ok;
            this.imgOk.Location = new System.Drawing.Point(245, 345);
            this.imgOk.Name = "imgOk";
            this.imgOk.Size = new System.Drawing.Size(32, 35);
            this.imgOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOk.TabIndex = 30;
            this.imgOk.TabStop = false;
            this.imgOk.Click += new System.EventHandler(this.imgOk_Click);
            // 
            // IdiomasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.imgOk);
            this.Controls.Add(this.btnActualizarIdioma);
            this.Controls.Add(this.ddIdiomasPersonalizados);
            this.Controls.Add(this.dgvIdiomas);
            this.Controls.Add(this.lblIngresarIdioma);
            this.Controls.Add(this.txtIngresarIdioma);
            this.Controls.Add(this.btnRegistrarIdioma);
            this.Controls.Add(this.lblIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdiomasUI";
            this.Text = "IdiomasUI";
            this.Load += new System.EventHandler(this.IdiomasUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblIngresarIdioma;
        private System.Windows.Forms.TextBox txtIngresarIdioma;
        private System.Windows.Forms.Button btnRegistrarIdioma;
        private System.Windows.Forms.DataGridView dgvIdiomas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDropdown ddIdiomasPersonalizados;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button btnActualizarIdioma;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.PictureBox imgOk;
    }
}