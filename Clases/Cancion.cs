using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public  class Cancion
    {
        public int Codigo;
        public string Nombre;
        public string Genero;
        public string artista;

        public Cancion(int codigo, string nombre, string genero, string artista)
        {
            Codigo = codigo;
            Nombre = nombre;
            Genero = genero;
            this.artista = artista;
        }
    }
}
