using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08CarloVitali
{
    [Serializable]
    class Cine
    {
        private string nombre_dueño;
        private string num_Id;
        private string horario_Atencion;
        private string num_Salas;


        /*public Cine(string nombre_dueño, string num_Id, string horario_Atencion, string num_Salas )
        {
            this.Nombre_dueño = nombre_dueño;
            this.Num_Id = num_Id;
            this.Horario_Atencion = horario_Atencion;
            this.Num_Salas = num_Salas;
        }*/

        public string Nombre_dueño { get => nombre_dueño; set => nombre_dueño = value; }
        public string Num_Id { get => num_Id; set => num_Id = value; }
        public string Horario_Atencion { get => horario_Atencion; set => horario_Atencion = value; }
        public string Num_Salas { get => num_Salas; set => num_Salas = value; }
    }
}
