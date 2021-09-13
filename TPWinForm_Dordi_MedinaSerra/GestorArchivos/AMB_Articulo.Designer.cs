
namespace GestorArchivos
{
    partial class AMB_Articulo
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
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_URLImagen = new System.Windows.Forms.TextBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.pbx_ImagenArticulo = new System.Windows.Forms.PictureBox();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(143)))));
            this.pnl_Menu.Controls.Add(this.lbl_Menu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(658, 83);
            this.pnl_Menu.TabIndex = 1;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(125, 25);
            this.lbl_Menu.TabIndex = 0;
            this.lbl_Menu.Text = "ARTICULO";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(75, 114);
            this.txt_Codigo.Mask = ">L00";
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.PromptChar = ' ';
            this.txt_Codigo.Size = new System.Drawing.Size(39, 20);
            this.txt_Codigo.TabIndex = 2;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(213, 114);
            this.txt_Nombre.MaxLength = 50;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(416, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(98, 155);
            this.txt_Descripcion.MaxLength = 50;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(531, 20);
            this.txt_Descripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marca";
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(90, 195);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cbx_Categoria.Sorted = true;
            this.cbx_Categoria.TabIndex = 10;
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Location = new System.Drawing.Point(297, 195);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(121, 21);
            this.cbx_Marca.Sorted = true;
            this.cbx_Marca.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(482, 195);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 13;
            this.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "URL Imagen";
            // 
            // txt_URLImagen
            // 
            this.txt_URLImagen.Location = new System.Drawing.Point(98, 231);
            this.txt_URLImagen.MaxLength = 50;
            this.txt_URLImagen.Name = "txt_URLImagen";
            this.txt_URLImagen.Size = new System.Drawing.Size(531, 20);
            this.txt_URLImagen.TabIndex = 16;
            this.txt_URLImagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_URLImagen_KeyDown);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(50, 281);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(118, 67);
            this.btn_Grabar.TabIndex = 17;
            this.btn_Grabar.Text = "GRABAR";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(125, 377);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(118, 67);
            this.btn_Cerrar.TabIndex = 18;
            this.btn_Cerrar.Text = "CERRAR";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(197, 281);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(118, 67);
            this.btn_Limpiar.TabIndex = 19;
            this.btn_Limpiar.Text = "LIMPIAR PANTALLA";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // pbx_ImagenArticulo
            // 
            this.pbx_ImagenArticulo.Location = new System.Drawing.Point(350, 257);
            this.pbx_ImagenArticulo.Name = "pbx_ImagenArticulo";
            this.pbx_ImagenArticulo.Size = new System.Drawing.Size(279, 234);
            this.pbx_ImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_ImagenArticulo.TabIndex = 20;
            this.pbx_ImagenArticulo.TabStop = false;
            // 
            // AMB_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 515);
            this.Controls.Add(this.pbx_ImagenArticulo);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.txt_URLImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.cbx_Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.pnl_Menu);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "AMB_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.AMB_Articulo_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.MaskedTextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_URLImagen;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.PictureBox pbx_ImagenArticulo;
    }
}