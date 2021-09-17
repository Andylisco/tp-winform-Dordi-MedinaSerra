﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using dominio;
using negocio;

namespace GestorArchivos
{
    public partial class AMB_Articulo : Form
    {

        private Articulo articulo = null;

        int NroID;
        public AMB_Articulo(int Id = 0)
        {
            InitializeComponent();

            if (Id != 0)
            {
                NroID = Id;
            }
        }
        public AMB_Articulo(Articulo articulo,int Id = 0)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            if (Id != 0)
            {
                NroID = articulo.id;
            }
        }


        private void AMB_Articulo_Load(object sender, EventArgs e)
        {
            CargaCombos();

            if (articulo != null)
            {
                          
                    txt_Codigo.Text = articulo.Codigo;
                    txt_Nombre.Text = articulo.Nombre;
                    txt_Descripcion.Text = articulo.Descripcion;
                    txt_Precio.Text = articulo.Precio.ToString("N2");
                    Categoria Cat = new Categoria();
                    Cat.id = articulo.Categoria.id;
                   // cbx_Categoria.SelectedItem = Cat;
                   // cbx_Marca.SelectedItem = articulo.Marca;
                    txt_URLImagen.Text = articulo.URLImagen;
                    CargarImagen();
                    cbx_Categoria.SelectedValue = articulo.Categoria.id;
                    cbx_Marca.SelectedValue = articulo.Marca.id;


                   
            }
        }

       private void CargaCombos()
        {
            CargaCategorias();
            CargaMarcas();

        }

        private void CargaCategorias()
        {
            CategoriaNegocio CatNeg = new CategoriaNegocio();
            try
            {
                cbx_Categoria.DataSource = CatNeg.listar();
                cbx_Categoria.ValueMember = "Id";
                cbx_Categoria.DisplayMember = "Descripcion";
                


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las opciones de Categoría por problema de conexión", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
                  
        }
        
        private void CargaMarcas()
        {
            try
            {
                MarcaNegocio MarcaNeg = new MarcaNegocio();
                cbx_Marca.DataSource = MarcaNeg.listar();
                cbx_Marca.ValueMember = "Id";
                cbx_Marca.DisplayMember = "Descripcion";

             

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las opciones de Marca por problema de conexión", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        
        }

        

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txt_Codigo.Text;
                articulo.Nombre = txt_Nombre.Text;
                articulo.Descripcion = txt_Descripcion.Text;
                articulo.Categoria = (Categoria)cbx_Categoria.SelectedItem;
                articulo.Marca = (Marca)cbx_Marca.SelectedItem;
                articulo.URLImagen = txt_URLImagen.Text;
                articulo.Precio = decimal.Parse(txt_Precio.Text);

                if (articulo.id != 0)
                {
                    negocio.Actualizar(articulo);
                    MessageBox.Show("Actualizados los datos exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
               
                
                Close();
    }           
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_URLImagen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter: 
                    { 
                    CargarImagen();
                        break;
                    }
                case Keys.Escape:
                    {
                        txt_URLImagen.Text = "";
                        break;
                    }
                
            }                            
        }
        private void txt_URLImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen();
        }
        private void CargarImagen()
        {
            if (txt_URLImagen.Text != "")
            {
                try
                {
                   
                    pbx_ImagenArticulo.Load(txt_URLImagen.Text);
                    
                }
                catch (Exception)
                {

                    pbx_ImagenArticulo.Load("https://847395.smushcdn.com/1790738/wp-content/uploads/2015/09/imagen-no-encontrada.jpg?lossy=0&strip=1&webp=1");
                }
                
            }
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 44 && e.KeyChar != 08)
                e.Handled = true;
        }

        
    }

    

}

