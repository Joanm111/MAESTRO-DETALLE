using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestroDetalle
{
    internal class album
    {
        public int   Id { get; set; }    
        public string nombre { get; set; }
        
        public string artista { get; set; }

        public DateTime fechaSalida { get; set; }

        public  double duracion { get; set; }

        public List <Canciones>canciones { get; set; }

        public album()
        {
            canciones = new List<Canciones>();
        }

      

      

    }
}
