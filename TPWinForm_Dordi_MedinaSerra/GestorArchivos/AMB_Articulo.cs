using System;
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
        int NroID;
        public AMB_Articulo(int Id = 0)
        {
            InitializeComponent();

            if (Id != 0)
            {
                NroID = Id;
            }
        }


        private void AMB_Articulo_Load(object sender, EventArgs e)
        {
            CargaCombos();

            if (NroID != 0)
            {
               ArticuloNegocio ArtNeg = new ArticuloNegocio();
                Articulo Art;
                
                Art = ArtNeg.listar(NroID);
                                
                
                txt_Codigo.Text = Art.Codigo;
                txt_Nombre.Text = Art.Nombre;
                txt_Descripcion.Text = Art.Descripcion;
                txt_Precio.Text = Art.Precio.ToString("N2");
                Categoria Cat = new Categoria();
                Cat.id = Art.Categoria.id;
                cbx_Categoria.SelectedItem = Cat;
                cbx_Marca.SelectedItem = Art.Marca;
                txt_URLImagen.Text = Art.URLImagen;

                CargarImagen();

                btn_Grabar.Text = "ACTUALIZAR DATOS";
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
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                
                nuevo.Codigo = txt_Codigo.Text;
                nuevo.Nombre = txt_Nombre.Text;
                nuevo.Descripcion = txt_Descripcion.Text;
                nuevo.Categoria = (Categoria)cbx_Categoria.SelectedItem;
                nuevo.Marca = (Marca)cbx_Marca.SelectedItem;
                nuevo.URLImagen = txt_URLImagen.Text;
                nuevo.Precio = decimal.Parse(txt_Precio.Text.Replace(".", ","));
                
                if (btn_Grabar.Text == "GRABAR")
                {
                    negocio.agregar(nuevo);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {
                    negocio.Actualizar(NroID,nuevo);
                    MessageBox.Show("Actualizados los datos exitosamente");
                    
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
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 08)
                e.Handled = true;
        }

        
    }

    

}

