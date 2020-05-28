using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace Lab08CarloVitali
{
    [Serializable]
    class Local
    {
        
        public void ListaCines(Cine cine)
        {
            CineController cineController = new CineController();
            Cine cine3 = new Cine();
            cine3.Nombre_dueño = "Lorena";
            cine3.Num_Id = "123";
            cine3.Horario_Atencion = "8am-6pm";
            cine3.Num_Salas = "5";
            cineController.cines.Add(cine3);
            Cine cine1 = new Cine();
            cine1.Nombre_dueño = "Vanessa";
            cine1.Num_Id = "456";
            cine1.Horario_Atencion = "8am-6pm";
            cine1.Num_Salas = "6";
            cineController.cines.Add(cine1);
            Cine cine2 = new Cine();
            cine2.Nombre_dueño = "Monica";
            cine2.Num_Id = "789";
            cine2.Horario_Atencion = "8am-6pm";
            cine2.Num_Salas = "8";
            cineController.cines.Add(cine2);
        }
    }
}
