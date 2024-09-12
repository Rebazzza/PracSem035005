using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public  class Cancion
    {
    
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string artista { get; set; }
        public string ruta { get; set; }
        public string img { get; set; }


        public override string ToString()
        {
            return "Nombre: " + nombre + " /Genero: " + genero + " /Año: " + artista + " /Artista: " + ruta;
        }
    }
}
