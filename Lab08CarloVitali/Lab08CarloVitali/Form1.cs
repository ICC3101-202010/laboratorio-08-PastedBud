using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08CarloVitali
{
    
    public partial class Form1 : Form
    {
        List<Cine> cines = new List<Cine>();
        List<Restaurante> restaurantes = new List<Restaurante>();
        List<Recreacional> recreacionales = new List<Recreacional>();
        List<Tienda> tiendas = new List<Tienda>();
        //public delegate bool AgregarTiendaEventHandler(object source, )
        public Form1()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            pAgregar.Visible = true;
            input_Nombre_Dueño.Text = "";
            input_Numero_Identificador.Text = "";
            input_Horario.Text = "";
            input_Categorias.Text = "";
            inputMesa.Text = "";
            inputCantSalas.Text = "";
            pInfoNuevaTienda.Visible = false;
            

        }

        private void bRevisar_Click(object sender, EventArgs e)
        {

        }

        private void bLista_Click(object sender, EventArgs e)
        {
            Lista.Text = "";
            pLista.Visible = true;
            Tienda tienda = new Tienda();
            tienda.Nombre_dueño = "Carlo";
            tienda.Num_Id = "123";
            tienda.Horario_Atencion = "8am-6pm";
            tienda.Categorias = "VideoJuegos";
            //TiendaController tiendaController = new TiendaController();
            tiendas.Add(tienda);
            Tienda tienda1 = new Tienda();
            tienda1.Nombre_dueño = "Cris";
            tienda1.Num_Id = "456";
            tienda1.Horario_Atencion = "8am-6pm";
            tienda1.Categorias = "Libros";
            tiendas.Add(tienda1);
            Tienda tienda2 = new Tienda();
            tienda2.Nombre_dueño = "Raimundo";
            tienda2.Num_Id = "789";
            tienda2.Horario_Atencion = "8am-6pm";
            tienda2.Categorias = "Alcohol";
            tiendas.Add(tienda2);

            Restaurante restaurante = new Restaurante();
            restaurante.Nombre_dueño = "Pascale";
            restaurante.Num_Id = "123";
            restaurante.Horario_Atencion = "8am-6pm";
            restaurante.Mesas_exclusivas = "Si";
            //RestaurantController restaurantController = new RestaurantController();
            restaurantes.Add(restaurante);
            Restaurante restaurante1 = new Restaurante();
            restaurante1.Nombre_dueño = "Carlos";
            restaurante1.Num_Id = "456";
            restaurante1.Horario_Atencion = "8am-6pm";
            restaurante1.Mesas_exclusivas = "Si";
            restaurantes.Add(restaurante1);
            Restaurante restaurante2 = new Restaurante();
            restaurante2.Nombre_dueño = "Fernando";
            restaurante2.Num_Id = "789";
            restaurante2.Horario_Atencion = "8am-6pm";
            restaurante2.Mesas_exclusivas = "No";
            restaurantes.Add(restaurante2);
            Recreacional recreacional = new Recreacional();
            recreacional.Nombre_dueño = "Nicolas";
            recreacional.Num_Id = "123";
            recreacional.Horario_Atencion = "8am-6pm";
            //RecreacionalController recreacionalController = new RecreacionalController();
            recreacionales.Add(recreacional);
            Recreacional recreacional1 = new Recreacional();
            recreacional1.Nombre_dueño = "Augusto";
            recreacional1.Num_Id = "456";
            recreacional1.Horario_Atencion = "8am-6pm";
            recreacionales.Add(recreacional1);
            Recreacional recreacional2 = new Recreacional();
            recreacional2.Nombre_dueño = "Eduardo";
            recreacional2.Num_Id = "789";
            recreacional2.Horario_Atencion = "8am-6pm";
            recreacionales.Add(recreacional2);
            Cine cine = new Cine();
            cine.Nombre_dueño = "Lorena";
            cine.Num_Id = "123";
            cine.Horario_Atencion = "8am-6pm";
            cine.Num_Salas = "5";
            //CineController cineController = new CineController();
            cines.Add(cine);
            Cine cine1 = new Cine();
            cine1.Nombre_dueño = "Vanessa";
            cine1.Num_Id = "456";
            cine1.Horario_Atencion = "8am-6pm";
            cine1.Num_Salas = "6";
            cines.Add(cine1);
            Cine cine2 = new Cine();
            cine2.Nombre_dueño = "Monica";
            cine2.Num_Id = "789";
            cine2.Horario_Atencion = "8am-6pm";
            cine2.Num_Salas = "8";
            cines.Add(cine2);
            foreach (Tienda cine3 in tiendas)
            {
                Lista.Text += ( "Nombre Dueño: " + cine3.Nombre_dueño +"    Numero de Id: " + cine3.Num_Id + "    Horario de Atencion: " + cine3.Horario_Atencion + "    Categorias Tienda: " + cine3.Categorias );
                Lista.Text += "                                                                                                                                                          ";
            
            }
            foreach (Cine cine3 in cines)
            {
                Lista.Text += ("Nombre Dueño: " + cine3.Nombre_dueño + "    Numero de Id: " + cine3.Num_Id + "    Horario de Atencion: " + cine3.Horario_Atencion + "    Cantidad Salas: " + cine3.Num_Salas);
                Lista.Text += "                                                                                                                                                 ";

            }
            foreach (Restaurante cine3 in restaurantes)
            {
                Lista.Text += ("Nombre Dueño: " + cine3.Nombre_dueño + "    Numero de Id: " + cine3.Num_Id + "    Horario de Atencion: " + cine3.Horario_Atencion + "    Posee Mesas Exclusivas: " + cine3.Mesas_exclusivas);
                Lista.Text += "                                                                                                                                                                       ";

            }
            foreach (Recreacional cine3 in recreacionales)
            {
                Lista.Text += ("Nombre Dueño: " + cine3.Nombre_dueño + "    Numero de Id: " + cine3.Num_Id + "    Horario de Atencion: " + cine3.Horario_Atencion );
                Lista.Text += "                                                                                                                                                 ";
                
            }


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
            //TiendaController tiendaController = new TiendaController();
            tiendas.Add(tienda);
            MessageBox.Show("Haz Agregado la Nueva Tienda con Exito!");
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
            

            /*
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Tiendas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tiendaController);
            stream.Close();
            */
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
            //CineController cineController = new CineController();
            cines.Add(cine);
            MessageBox.Show("Haz Agregado el Nuevo Cine con Exito!");
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;

            Local local = new Local();
            local.ListaCines(cine);
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
            //RestaurantController restaurantController = new RestaurantController();
            restaurantes.Add(restaurante);
            MessageBox.Show("Haz Agregado el Nuevo Restaurant con Exito!");
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;

            /*IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Restaurantes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, restaurantController);
            stream.Close();
            */
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
            //RecreacionalController recreacionalController = new RecreacionalController();
            recreacionales.Add(recreacional);
            MessageBox.Show("Haz Agregado el Nuevo Local Recreacional con Exito!");
            confirmacionAgregado.Visible = true;
            Thread.Sleep(1000);
            confirmacionAgregado.Visible = false;
            pAgregar.Visible = false;
            pInfoNuevoLocal.Visible = false;
            pInfoNuevoCine.Visible = false;
            pInfoNuevaTienda.Visible = false;
            pInfoNuevoRestaurant.Visible = false;
            pInfoNuevoRecreacional.Visible = false;
            /*
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Recreacionales.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, recreacionalController);
            stream.Close();
            */
        }

        private void bAtrasLista_Click(object sender, EventArgs e)
        {
            pLista.Visible = false;
        }
    }
}
