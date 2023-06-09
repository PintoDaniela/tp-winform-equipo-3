﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // para poder mover la ventana

using Negocio;
using Dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionForms
{
    public partial class InicioForm : Form
    {
       
        // para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        string imagenDefault = "https://c.pxhere.com/images/47/83/d6e362ca869395f9db5b5a3d0659-1675158.png!d";
        //para el indice de imagen
        int indiceImagen;

        public InicioForm()
        {
            //Load();
            InitializeComponent();
            cargar();
        }
        private void EsconderColumnas()
        {
            DgvListaPrincipal.Columns["Id"].Visible = false;
            DgvListaPrincipal.Columns["Descripcion"].Visible = false;
        }

        private void PicBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaItemsForm ventana = new AltaItemsForm();
            //ventana.ShowDialog();
            ventana.FormClosed += new FormClosedEventHandler(Ventana_FormClosed);
            ventana.Show();
        }


        //Se carga el listado que se muestra en el dgv:
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DgvListaPrincipal.DataSource = negocio.listar();
                DgvListaPrincipal.Columns["Precio"].DefaultCellStyle.Format = "0.00##";
                EsconderColumnas();
                if (DgvListaPrincipal.Rows.Count > 0)
                {
                    DgvListaPrincipal.Rows[0].Selected = true;
                    int idArticulo = Convert.ToInt32(DgvListaPrincipal.SelectedRows[0].Cells["Id"].Value);
                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    CargarImagen(imagenNegocio.listar(idArticulo)[0].ToString());
                   
                    indiceImagen = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarImagen(string ruta)
        {
            picImagen.LoadCompleted += (sender, e) =>
            {
                if (e.Error != null)
                {
                    picImagen.ImageLocation = imagenDefault;
                }
            };

            picImagen.ImageLocation = ruta;
        }
        private void Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar();
        }

  

        private void InicioForm_Load(object sender, EventArgs e)
        {
            cargar();

            //Se agregan las opciones del desplegable al cargar el form:
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Codigo");
        }

        private void DgvListaPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            if (DgvListaPrincipal.CurrentRow != null) // verifica si la fila actual es nula
            {
                int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
                txtMostrarDescripcion.Text = DgvListaPrincipal.CurrentRow.Cells["Descripcion"].Value.ToString();
                List<Imagen> imagenesRelacionadas = imagenNegocio.listar(idArticulo);

                if (imagenesRelacionadas.Count > 0)
                {
                    CargarImagen(imagenesRelacionadas[0].ImagenUrl);
                    indiceImagen = 0;
                }
                else
                {                   //Si no hay imágenes cargadas, se muestra el placeholder:
                    CargarImagen(imagenDefault);
                }
            }
            else
            {
                // Si la fila actual es nula, selecciona la primera fila
                if (DgvListaPrincipal.Rows.Count > 0)
                {
                    DgvListaPrincipal.Rows[0].Selected = true;
                }
            }
        }


        private void btnAtrasImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
            if (indiceImagen != 0)
            {
                indiceImagen--;
                CargarImagen(imagenNegocio.listar(idArticulo)[indiceImagen].ToString());
            }
        }

        private void btnAdelanteImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            int idArticulo = Convert.ToInt32(DgvListaPrincipal.CurrentRow.Cells["Id"].Value.ToString());
            int indiceMaximo = imagenNegocio.listar(idArticulo).Count - 1;
           
            if(indiceImagen != indiceMaximo && indiceMaximo>=0)
            {
                indiceImagen++;
                CargarImagen(imagenNegocio.listar(idArticulo)[indiceImagen].ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   
            
            //Envio el objeto articulo desde la fila seleccionada en la DGV
            Articulo art=(Articulo)DgvListaPrincipal.CurrentRow.DataBoundItem;
            AltaItemsForm ventana = new AltaItemsForm(art);
            ventana.ShowDialog();
        }

        //Sólo baja física porque la tabla de articulos de la DB no tiene campo bool para estado activo o no activo.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioImg = new ImagenNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgvListaPrincipal.CurrentRow.DataBoundItem;
                    int idArticulo = seleccionado.Id;
                    negocio.Eliminar(idArticulo);
                    

                    //Vuelvo a cargar el dgv para actualizar los datos.
                    cargar();

                    //Al eliminar el artículo, se borran las imágenes del mismo de la tabla de imágenes.
                    negocioImg.Vaciar(idArticulo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //Mostrar u ocultar el submenú del fintro con el botón Filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            Action toggleSubMenuFiltro = () => submenuFiltro.Visible = !submenuFiltro.Visible;
            toggleSubMenuFiltro();

            int alturaFiltro = submenuFiltro.Height;
            if (submenuFiltro.Visible)
            {
                panelAgregarCategoria.Location = new Point(panelAgregarCategoria.Location.X, panelAgregarCategoria.Location.Y + alturaFiltro);
            }
            else
            { 
                panelAgregarCategoria.Location = new Point(panelAgregarCategoria.Location.X, panelAgregarCategoria.Location.Y - alturaFiltro);
                //Se reestablece DGV cuando se minimiza la opcion de "Filtrar"
                cargar();
            }
        }

        //Setear las opciones que aparecen en el despregable de criterio según la opción elegida.
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
           
            try
            {
                if(txtFiltro.Text == "")
                {
                    DgvListaPrincipal.DataSource = negocio.listar();
                    return;
                }
                if (validarFiltro())
                    return;
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                if (campo == "Precio")
                {
                    decimal.Parse(txtFiltro.Text);
                }
                string filtro = txtFiltro.Text.ToString();

                //Se carga la DGV con los resultados del filtro aplicado.
                DgvListaPrincipal.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos.");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("El valor ingresado debe ser numérico.");
                    return true;
                }
                if (!(separaPorPunto(txtFiltro.Text)))
                {
                    MessageBox.Show("Por favor, use el punto para separar los decimales.");
                    return true;
                }
            }
            return false;
        }

         private bool soloNumeros(string cadena)
         {            
            try
            {
                decimal.Parse(cadena);
                return true;
            }
            catch
            {
                return false;
            }
         }

        private bool separaPorPunto(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (caracter == ',')
                    return false;
            }
            return true;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormCategoriaMarca ventana = new FormCategoriaMarca("Categoria");
            ventana.Show();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FormCategoriaMarca ventana = new FormCategoriaMarca("Marca");
            ventana.Show();
        }
    }
}
