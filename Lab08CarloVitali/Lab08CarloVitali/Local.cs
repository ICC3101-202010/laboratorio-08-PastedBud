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
        public void Serializar(CineController cineController)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Cines.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, cineController);
            stream.Close();
        }
    }
}
