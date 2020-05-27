using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08CarloVitali
{
    [Serializable]
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Tienda tienda = new Tienda();
            tienda.Nombre_dueño = "Carlo";
            tienda.Num_Id = "123";
            tienda.Horario_Atencion = "8am-6pm";
            tienda.Categorias = "VideoJuegos";
            TiendaController tiendaController = new TiendaController();
            tiendaController.tiendas.Add(tienda);
            Tienda tienda1 = new Tienda();
            tienda1.Nombre_dueño = "Cris";
            tienda1.Num_Id = "456";
            tienda1.Horario_Atencion = "8am-6pm";
            tienda1.Categorias = "Libros";
            tiendaController.tiendas.Add(tienda1);
            Tienda tienda2 = new Tienda();
            tienda2.Nombre_dueño = "Raimundo";
            tienda2.Num_Id = "789";
            tienda2.Horario_Atencion = "8am-6pm";
            tienda2.Categorias = "Alcohol";
            tiendaController.tiendas.Add(tienda2);
            
            Restaurante restaurante = new Restaurante();
            restaurante.Nombre_dueño = "Pascale";
            restaurante.Num_Id = "123";
            restaurante.Horario_Atencion = "8am-6pm";
            restaurante.Mesas_exclusivas = "Si";
            RestaurantController restaurantController = new RestaurantController();
            restaurantController.restaurantes.Add(restaurante);
            Restaurante restaurante1 = new Restaurante();
            restaurante1.Nombre_dueño = "Carlos";
            restaurante1.Num_Id = "456";
            restaurante1.Horario_Atencion = "8am-6pm";
            restaurante1.Mesas_exclusivas = "Si";
            restaurantController.restaurantes.Add(restaurante1);
            Restaurante restaurante2 = new Restaurante();
            restaurante2.Nombre_dueño = "Fernando";
            restaurante2.Num_Id = "789";
            restaurante2.Horario_Atencion = "8am-6pm";
            restaurante2.Mesas_exclusivas = "No";
            restaurantController.restaurantes.Add(restaurante2);
            Recreacional recreacional = new Recreacional();
            recreacional.Nombre_dueño = "Nicolas";
            recreacional.Num_Id = "123";
            recreacional.Horario_Atencion = "8am-6pm";
            RecreacionalController recreacionalController = new RecreacionalController();
            recreacionalController.recreacionales.Add(recreacional);
            Recreacional recreacional1 = new Recreacional();
            recreacional1.Nombre_dueño = "Augusto";
            recreacional1.Num_Id = "456";
            recreacional1.Horario_Atencion = "8am-6pm";
            recreacionalController.recreacionales.Add(recreacional1);
            Recreacional recreacional2 = new Recreacional();
            recreacional2.Nombre_dueño = "Eduardo";
            recreacional2.Num_Id = "789";
            recreacional2.Horario_Atencion = "8am-6pm";
            recreacionalController.recreacionales.Add(recreacional2);
        }
    }
}
