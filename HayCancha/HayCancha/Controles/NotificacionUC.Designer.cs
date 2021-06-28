
namespace HayCancha
{
    partial class NotificacionUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLeido = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLeido
            // 
            this.btnLeido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeido.Location = new System.Drawing.Point(150, 346);
            this.btnLeido.Name = "btnLeido";
            this.btnLeido.Size = new System.Drawing.Size(75, 23);
            this.btnLeido.TabIndex = 5;
            this.btnLeido.Text = "LEÍDO";
            this.btnLeido.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!",
            "¡Tiene un nuevo partido!"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 45);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(237, 292);
            this.checkedListBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lblNotificaciones);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 47);
            this.panel1.TabIndex = 3;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotificaciones.Location = new System.Drawing.Point(5, 17);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(109, 19);
            this.lblNotificaciones.TabIndex = 0;
            this.lblNotificaciones.Text = "Notificaciones";
            // 
            // NotificacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(this.btnLeido);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.panel1);
            this.Name = "NotificacionUC";
            this.Size = new System.Drawing.Size(236, 379);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnLeido;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotificaciones;
    }
}
