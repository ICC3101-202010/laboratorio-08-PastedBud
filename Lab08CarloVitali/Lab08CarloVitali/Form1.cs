using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08CarloVitali
{
    public partial class Form1 : Form
    {
        //public delegate bool AgregarTiendaEventHandler(object source, )
        public Form1()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            pAgregar.Visible = true;
            pInfoNuevaTienda.Visible = false;
            

        }

        private void bRevisar_Click(object sender, EventArgs e)
        {

        }

        private void bLista_Click(object sender, EventArgs e)
        {

        }

        private void tAgregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pInfoNuevaTienda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bTienda_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = true;
            pInfoNuevaTienda.Visible = true;
            pInfoNuevoRestaurant.Visible = false;
        }

        private void bRestaurante_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = true;
            pInfoNuevoRestaurant.Visible = true;
            pInfoNuevaTienda.Visible = false;
        }

        private void bCine_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = true;
            
            pInfoNuevoCine.Visible = true;
        }

        private void bRecreacional_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = true;
            pInfoNuevoRecreacional.Visible = true;
        }

        private void bAgregarTienda_Click(object sender, EventArgs e)
        {
            string nombre_dueño = input_Nombre_Dueño.Text;
            string numero_identificador = input_Numero_Identificador.Text;
            string horario = input_Horario.Text;
            string categorias = input_Categorias.Text;
            Tienda tienda = new Tienda();
            tienda.Nombre_dueño = nombre_dueño;
            tienda.Num_Id = numero_identificador;
            tienda.Horario_Atencion = horario;
            tienda.Categorias = categorias;
            TiendaController tiendaController = new TiendaController();
            tiendaController.tiendas.Add(tienda);
            
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
        }

        

        private void batrasTienda_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
        }

        private void bAtrasInfoCine_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
        }

        private void bAgregarNuevoCine_Click(object sender, EventArgs e)
        {
            string nombre_dueño = input_Nombre_Dueño.Text;
            string numero_identificador = input_Numero_Identificador.Text;
            string horario = input_Horario.Text;
            string cantidad_salas = inputCantSalas.Text;
            Cine cine = new Cine();
            cine.Nombre_dueño = nombre_dueño;
            cine.Num_Id = numero_identificador;
            cine.Horario_Atencion = horario;
            cine.Num_Salas = cantidad_salas;
            CineController cineController = new CineController();
            cineController.cines.Add(cine);
            confirmacionAgregado.Text = "Haz Agregado el Nuevo Cine con Exito!";
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
        }

        

        private void bAtrasInfoRestaurant_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
        }

        private void bAgregarRestaurant_Click(object sender, EventArgs e)
        {
            string nombre_dueño = input_Nombre_Dueño.Text;
            string numero_identificador = input_Numero_Identificador.Text;
            string horario = input_Horario.Text;
            string mesas_exclusivas = inputMesa.Text;
            Restaurante restaurante = new Restaurante();
            restaurante.Nombre_dueño = nombre_dueño;
            restaurante.Num_Id = numero_identificador;
            restaurante.Horario_Atencion = horario;
            restaurante.Mesas_exclusivas = mesas_exclusivas;
            RestaurantController restaurantController = new RestaurantController();
            restaurantController.restaurantes.Add(restaurante);
            confirmacionAgregado.Text = "Haz Agregado el Nuevo Restaurant con Exito!";
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
        }

        

        private void bAtrasInfoNuevoRecreacional_Click(object sender, EventArgs e)
        {
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
        }

        private void bAgregarNuevoRecreacional_Click(object sender, EventArgs e)
        {
            string nombre_dueño = input_Nombre_Dueño.Text;
            string numero_identificador = input_Numero_Identificador.Text;
            string horario = input_Horario.Text;
            Recreacional recreacional = new Recreacional();
            recreacional.Nombre_dueño = nombre_dueño;
            recreacional.Num_Id = numero_identificador;
            recreacional.Horario_Atencion = horario;
            RecreacionalController recreacionalController = new RecreacionalController();
            recreacionalController.recreacionales.Add(recreacional);
            confirmacionAgregado.Text = "Haz Agregado el Nuevo Local Recreacional con Exito!";
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
        }

        
    }
}
