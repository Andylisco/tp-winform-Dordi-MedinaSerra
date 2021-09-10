﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorArchivos.Clases;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace GestorArchivos
{
    public partial class ListadoArticulos : Form
    {
        List<Articulo> LISTAGLOBAL = new List<Articulo>();
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                lista = ArtNeg.listar();
                LISTAGLOBAL = lista;
                dgv_Articulos.DataSource = lista;
                        
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        private void txt_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Filtro.Text == "")
            {
                dgv_Articulos.DataSource = LISTAGLOBAL;
                return;
            }
            List<Articulo> ListaFiltra = LISTAGLOBAL;
            //ListaFiltra = ListaFiltra.Where(x => x.id == int.Parse(txt_Filtro.Text)).ToList();
            ListaFiltra = ListaFiltra.Where(x => (x.id.ToString().Contains(txt_Filtro.Text.Trim())) 
                                            | (x.Codigo.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper())) 
                                            | (x.Descripcion.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            | (x.Nombre.ToUpper().Contains(txt_Filtro.Text.Trim().ToUpper()))
                                            | (x.Precio.ToString().Contains(txt_Filtro.Text.Trim()))).ToList();
            dgv_Articulos.DataSource = ListaFiltra;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            string URLImangen = (string)dgv_Articulos.CurrentRow.Cells["URLImagen"].Value;
            cargarImagen(URLImangen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pb_Seleccion_dgv.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_Seleccion_dgv.Load("https://847395.smushcdn.com/1790738/wp-content/uploads/2015/09/imagen-no-encontrada.jpg?lossy=0&strip=1&webp=1");
            }
        }

        private void dgv_Articulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void dgv_Articulos_KeyDown(object sender, KeyEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void dgv_Articulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_Articulos.CurrentRow.Selected = true;
        }

        private void bORRARARTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
