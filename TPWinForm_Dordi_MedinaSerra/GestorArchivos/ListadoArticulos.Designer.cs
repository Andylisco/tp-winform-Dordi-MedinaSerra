
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BORRARARTICULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOARTICULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARARTICULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbx_Seleccion_dgv = new System.Windows.Forms.PictureBox();
            this.lbl_Filtrar = new System.Windows.Forms.Label();
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
            this.pnl_Menu.Size = new System.Drawing.Size(1171, 54);
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
            // txt_Filtro
            // 
            this.txt_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Filtro.Location = new System.Drawing.Point(124, 77);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(657, 20);
            this.txt_Filtro.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_Filtro, "Escriba para filtrar por \r\ncualquiera de las columnas.");
            this.txt_Filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Filtro_KeyUp);
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.AllowUserToAddRows = false;
            this.dgv_Articulos.AllowUserToDeleteRows = false;
            this.dgv_Articulos.AllowUserToResizeColumns = false;
            this.dgv_Articulos.AllowUserToResizeRows = false;
            this.dgv_Articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Marca,
            this.Categoria,
            this.UrlImagen,
            this.Precio});
            this.dgv_Articulos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Articulos.Location = new System.Drawing.Point(6, 109);
            this.dgv_Articulos.MultiSelect = false;
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.ReadOnly = true;
            this.dgv_Articulos.Size = new System.Drawing.Size(775, 417);
            this.dgv_Articulos.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dgv_Articulos, "Click secundario para accesos rápidos.");
            this.dgv_Articulos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Articulos_CellMouseClick);
            this.dgv_Articulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Articulos_CellMouseDoubleClick);
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            this.dgv_Articulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Articulos_KeyDown);
            this.dgv_Articulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_Articulos_KeyPress);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 62;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 77;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BORRARARTICULOToolStripMenuItem,
            this.nUEVOARTICULOToolStripMenuItem,
            this.mODIFICARARTICULOToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 70);
            // 
            // BORRARARTICULOToolStripMenuItem
            // 
            this.BORRARARTICULOToolStripMenuItem.Name = "BORRARARTICULOToolStripMenuItem";
            this.BORRARARTICULOToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.BORRARARTICULOToolStripMenuItem.Text = "BORRAR ARTICULO";
            this.BORRARARTICULOToolStripMenuItem.Click += new System.EventHandler(this.BORRARARTICULOToolStripMenuItem_Click);
            // 
            // nUEVOARTICULOToolStripMenuItem
            // 
            this.nUEVOARTICULOToolStripMenuItem.Name = "nUEVOARTICULOToolStripMenuItem";
            this.nUEVOARTICULOToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nUEVOARTICULOToolStripMenuItem.Text = "NUEVO ARTICULO";
            // 
            // mODIFICARARTICULOToolStripMenuItem
            // 
            this.mODIFICARARTICULOToolStripMenuItem.Name = "mODIFICARARTICULOToolStripMenuItem";
            this.mODIFICARARTICULOToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.mODIFICARARTICULOToolStripMenuItem.Text = "MODIFICAR ARTICULO";
            this.mODIFICARARTICULOToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARARTICULOToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GestorArchivos.Properties.Resources.borrar_2;
            this.button4.Location = new System.Drawing.Point(1042, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 84);
            this.button4.TabIndex = 9;
            this.button4.Text = "BORRAR";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button4, "Eliminar Artículo seleccionado.");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BORRARARTICULOToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GestorArchivos.Properties.Resources.Modificar2;
            this.button3.Location = new System.Drawing.Point(912, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 84);
            this.button3.TabIndex = 8;
            this.button3.Text = "MODIFICAR";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button3, "Modificar Artículo seleccionado.");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::GestorArchivos.Properties.Resources.Salir;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1039, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "CERRAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.button2, "Cerrar Ventana.");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GestorArchivos.Properties.Resources.Nuevo;
            this.button1.Location = new System.Drawing.Point(787, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 84);
            this.button1.TabIndex = 6;
            this.button1.Text = " ARTICULO";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "Crear un nuevo Artículo.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_NuevoArticulo_Click);
            // 
            // pbx_Seleccion_dgv
            // 
            this.pbx_Seleccion_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Seleccion_dgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_Seleccion_dgv.Location = new System.Drawing.Point(800, 225);
            this.pbx_Seleccion_dgv.Name = "pbx_Seleccion_dgv";
            this.pbx_Seleccion_dgv.Size = new System.Drawing.Size(364, 292);
            this.pbx_Seleccion_dgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Seleccion_dgv.TabIndex = 5;
            this.pbx_Seleccion_dgv.TabStop = false;
            // 
            // lbl_Filtrar
            // 
            this.lbl_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtrar.Image = global::GestorArchivos.Properties.Resources.Filtrar2;
            this.lbl_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Filtrar.Location = new System.Drawing.Point(6, 59);
            this.lbl_Filtrar.Name = "lbl_Filtrar";
            this.lbl_Filtrar.Size = new System.Drawing.Size(112, 54);
            this.lbl_Filtrar.TabIndex = 2;
            this.lbl_Filtrar.Text = "Filtrar Grilla";
            this.lbl_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1171, 529);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbx_Seleccion_dgv);
            this.Controls.Add(this.dgv_Articulos);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_Filtrar);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "ListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BORRARARTICULOToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem nUEVOARTICULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARARTICULOToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}