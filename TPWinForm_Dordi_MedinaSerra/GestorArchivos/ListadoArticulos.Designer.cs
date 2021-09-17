
namespace GestorArchivos
{
    partial class ListadoArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_Filtrar = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BORRARARTICULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbx_Seleccion_dgv = new System.Windows.Forms.PictureBox();
            this.btn_NuevoArticulo = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Seleccion_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.pnl_Menu.Controls.Add(this.lbl_Menu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1112, 54);
            this.pnl_Menu.TabIndex = 1;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(243, 25);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "LISTADO ARTICULOS";
            // 
            // lbl_Filtrar
            // 
            this.lbl_Filtrar.AutoSize = true;
            this.lbl_Filtrar.Location = new System.Drawing.Point(13, 61);
            this.lbl_Filtrar.Name = "lbl_Filtrar";
            this.lbl_Filtrar.Size = new System.Drawing.Size(58, 13);
            this.lbl_Filtrar.TabIndex = 2;
            this.lbl_Filtrar.Text = "Filtrar Grilla";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(12, 77);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(776, 20);
            this.txt_Filtro.TabIndex = 3;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            this.txt_Filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Filtro_KeyUp);
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.AllowUserToAddRows = false;
            this.dgv_Articulos.AllowUserToDeleteRows = false;
            this.dgv_Articulos.AllowUserToResizeColumns = false;
            this.dgv_Articulos.AllowUserToResizeRows = false;
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Marca,
            this.IdCategoria,
            this.UrlImagen,
            this.Precio});
            this.dgv_Articulos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Articulos.Location = new System.Drawing.Point(13, 109);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.ReadOnly = true;
            this.dgv_Articulos.Size = new System.Drawing.Size(775, 299);
            this.dgv_Articulos.TabIndex = 4;
            this.dgv_Articulos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Articulos_CellMouseClick);
            this.dgv_Articulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Articulos_CellMouseDoubleClick);
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            this.dgv_Articulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Articulos_KeyDown);
            this.dgv_Articulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_Articulos_KeyPress);
            this.dgv_Articulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Articulos_MouseDown_1);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "IdMarca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Visible = false;
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "Categoria";
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // UrlImagen
            // 
            this.UrlImagen.DataPropertyName = "UrlImagen";
            this.UrlImagen.HeaderText = "ImagenUrl";
            this.UrlImagen.Name = "UrlImagen";
            this.UrlImagen.ReadOnly = true;
            this.UrlImagen.Visible = false;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BORRARARTICULOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 26);
            // 
            // BORRARARTICULOToolStripMenuItem
            // 
            this.BORRARARTICULOToolStripMenuItem.Name = "BORRARARTICULOToolStripMenuItem";
            this.BORRARARTICULOToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.BORRARARTICULOToolStripMenuItem.Text = "BORRAR ARTICULO";
            this.BORRARARTICULOToolStripMenuItem.Click += new System.EventHandler(this.BORRARARTICULOToolStripMenuItem_Click);
            // 
            // pbx_Seleccion_dgv
            // 
            this.pbx_Seleccion_dgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_Seleccion_dgv.Location = new System.Drawing.Point(795, 150);
            this.pbx_Seleccion_dgv.Name = "pbx_Seleccion_dgv";
            this.pbx_Seleccion_dgv.Size = new System.Drawing.Size(305, 258);
            this.pbx_Seleccion_dgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Seleccion_dgv.TabIndex = 5;
            this.pbx_Seleccion_dgv.TabStop = false;
            this.pbx_Seleccion_dgv.Click += new System.EventHandler(this.pbx_Seleccion_dgv_Click);
            // 
            // btn_NuevoArticulo
            // 
            this.btn_NuevoArticulo.Location = new System.Drawing.Point(12, 421);
            this.btn_NuevoArticulo.Name = "btn_NuevoArticulo";
            this.btn_NuevoArticulo.Size = new System.Drawing.Size(122, 35);
            this.btn_NuevoArticulo.TabIndex = 6;
            this.btn_NuevoArticulo.Text = "NUEVO ARTICULO";
            this.btn_NuevoArticulo.UseVisualStyleBackColor = true;
            this.btn_NuevoArticulo.Click += new System.EventHandler(this.btn_NuevoArticulo_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(958, 73);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(129, 61);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "CERRAR";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(140, 421);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(122, 35);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(268, 421);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(122, 35);
            this.btn_Borrar.TabIndex = 9;
            this.btn_Borrar.Text = "BORRAR";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.BORRARARTICULOToolStripMenuItem_Click);
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 468);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_NuevoArticulo);
            this.Controls.Add(this.pbx_Seleccion_dgv);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_Filtrar);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "ListadoArticulos";
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Seleccion_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Label lbl_Filtrar;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.PictureBox pbx_Seleccion_dgv;
        private System.Windows.Forms.Button btn_NuevoArticulo;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BORRARARTICULOToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Borrar;
    }
}