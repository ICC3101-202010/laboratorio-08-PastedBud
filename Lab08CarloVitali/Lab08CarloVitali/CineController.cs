using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08CarloVitali
{
    [Serializable]
    class CineController
    {
        
        public List<Cine> cines = new List<Cine>();
        Form1 Appform;

        public void print()
        {
            
        }

        /*public CineController(Form form)
        {
            
            this.Appform = form as Form1;
        }*/
    }
}
