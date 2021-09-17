
namespace GestorArchivos
{
    partial class MenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.mt_Menu = new System.Windows.Forms.MenuStrip();
            this.aMBArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Menu.SuspendLayout();
            this.mt_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.pnl_Menu.Controls.Add(this.lbl_Menu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 24);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(851, 83);
            this.pnl_Menu.TabIndex = 0;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(203, 25);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "MENU PRINCIPAL";
            // 
            // mt_Menu
            // 
            this.mt_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aMBArticulosToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mt_Menu.Location = new System.Drawing.Point(0, 0);
            this.mt_Menu.Name = "mt_Menu";
            this.mt_Menu.Size = new System.Drawing.Size(851, 24);
            this.mt_Menu.TabIndex = 1;
            this.mt_Menu.Text = "menuStrip1";
            // 
            // aMBArticulosToolStripMenuItem
            // 
            this.aMBArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoArticuloToolStripMenuItem});
            this.aMBArticulosToolStripMenuItem.Name = "aMBArticulosToolStripMenuItem";
            this.aMBArticulosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aMBArticulosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aMBArticulosToolStripMenuItem.Text = "&Articulo";
            // 
            // crearNuevoArticuloToolStripMenuItem
            // 
            this.crearNuevoArticuloToolStripMenuItem.Name = "crearNuevoArticuloToolStripMenuItem";
            this.crearNuevoArticuloToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.crearNuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.crearNuevoArticuloToolStripMenuItem.Text = "Crear &Nuevo Articulo";
            this.crearNuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoArticuloToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorCodigoToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.listadosToolStripMenuItem.Text = "&Listados ";
            this.listadosToolStripMenuItem.Click += new System.EventHandler(this.listadosToolStripMenuItem_Click);
            // 
            // buscarPorCodigoToolStripMenuItem
            // 
            this.buscarPorCodigoToolStripMenuItem.Name = "buscarPorCodigoToolStripMenuItem";
            this.buscarPorCodigoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.buscarPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.buscarPorCodigoToolStripMenuItem.Text = "&Lista Articulos";
            this.buscarPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.buscarPorCodigoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 517);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.mt_Menu);
            this.MainMenuStrip = this.mt_Menu;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.mt_Menu.ResumeLayout(false);
            this.mt_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.MenuStrip mt_Menu;
        private System.Windows.Forms.ToolStripMenuItem aMBArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

