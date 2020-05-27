using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08CarloVitali
{
    [Serializable]
    class Restaurante
    {
        private string nombre_dueño;
        private string num_Id;
        private string horario_Atencion;
        private string mesas_exclusivas;

        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Num_Id { get => num_Id; set => num_Id = value; }
        public string Horario_Atencion { get => horario_Atencion; set => horario_Atencion = value; }
        public string Mesas_exclusivas { get => mesas_exclusivas; set => mesas_exclusivas = value; }
    }
}
