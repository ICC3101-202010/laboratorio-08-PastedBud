using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08CarloVitali
{
    [Serializable]
    class Recreacional
    {
        private string nombre_dueño;
        private string num_Id;
        private string horario_Atencion;


        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Num_Id { get => num_Id; set => num_Id = value; }
        public string Horario_Atencion { get => horario_Atencion; set => horario_Atencion = value; }
    }
}
