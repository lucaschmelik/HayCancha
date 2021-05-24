
namespace HayCancha
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLQUILERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tORNEOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.White;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(770, 0);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(21, 24);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSalir.TabIndex = 8;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.aLQUILERToolStripMenuItem,
            this.tORNEOSToolStripMenuItem,
            this.oPCIONESToolStripMenuItem,
            this.btnMenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTAToolStripMenuItem,
            this.bAJAToolStripMenuItem,
            this.mODIFICACIONToolStripMenuItem,
            this.cONSULTAToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aLTAToolStripMenuItem.Text = "ALTA";
            // 
            // bAJAToolStripMenuItem
            // 
            this.bAJAToolStripMenuItem.Name = "bAJAToolStripMenuItem";
            this.bAJAToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bAJAToolStripMenuItem.Text = "BAJA";
            // 
            // mODIFICACIONToolStripMenuItem
            // 
            this.mODIFICACIONToolStripMenuItem.Name = "mODIFICACIONToolStripMenuItem";
            this.mODIFICACIONToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mODIFICACIONToolStripMenuItem.Text = "MODIFICACION";
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // aLQUILERToolStripMenuItem
            // 
            this.aLQUILERToolStripMenuItem.Name = "aLQUILERToolStripMenuItem";
            this.aLQUILERToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aLQUILERToolStripMenuItem.Text = "ALQUILER";
            // 
            // tORNEOSToolStripMenuItem
            // 
            this.tORNEOSToolStripMenuItem.Name = "tORNEOSToolStripMenuItem";
            this.tORNEOSToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tORNEOSToolStripMenuItem.Text = "TORNEOS";
            // 
            // oPCIONESToolStripMenuItem
            // 
            this.oPCIONESToolStripMenuItem.Name = "oPCIONESToolStripMenuItem";
            this.oPCIONESToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.oPCIONESToolStripMenuItem.Text = "OPCIONES";
            // 
            // btnMenuSalir
            // 
            this.btnMenuSalir.Name = "btnMenuSalir";
            this.btnMenuSalir.Size = new System.Drawing.Size(49, 20);
            this.btnMenuSalir.Text = "SALIR";
            this.btnMenuSalir.Click += new System.EventHandler(this.btnMenuSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLQUILERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tORNEOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
    }
}