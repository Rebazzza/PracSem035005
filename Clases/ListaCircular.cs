using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaCircular
    {
        SoundPlayer player;
        public Nodo primero = null;
        public Nodo ultimo = null;
        public void Insertar(Cancion nuevacancion)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = nuevacancion;
            if (primero == null)
            {
                primero = nuevo;
                primero.sig = primero;
                ultimo = nuevo;
                
            }
            else
            {
                ultimo.sig = nuevo;
                nuevo.sig = primero;
                ultimo = nuevo;
                
            }

        }
        public void recorrer()
        {
            Nodo temp = primero;
            do
            {
                Console.WriteLine(temp.dato);
                
                temp = temp.sig;

            } while (temp != primero);
        }
        public void recorrer1x1()
        {
            Nodo temp = primero;
            int op=100;
            do
            {
                Console.Clear();
                Console.WriteLine("----------LISTA-CANCIONES----------");
                Console.WriteLine("Codigo: "+ temp.dato.Codigo);
                Console.WriteLine("Nombre: " + temp.dato.Nombre);
                Console.WriteLine("Artista: " + temp.dato.artista);
                player = new SoundPlayer(temp.dato.ruta);
                player.Play();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("[1]Siguiente");
                Console.WriteLine("[0]Salir ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Eliga una opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        temp = temp.sig;
                        break; 
                    
                }
            } while (op!=0);
            Console.WriteLine("Saliendo ");

        }
        public bool Eliminar(int el)
        {
            Nodo temp = primero;
            Nodo anterior = null;
            Nodo ultima = null;
            bool val = false; 
            do
            {
                if(primero.dato.Codigo == el )
                {
                    ultimo.sig = primero.sig;
                    primero = primero.sig;
                    Console.WriteLine("Canción eliminada");
                    val= true;
                }
                else if (temp.dato.Codigo == el) 
                {
                    anterior.sig = temp.sig;
                    Console.WriteLine("Canción eliminada");
                    val= true;
                }
                
                anterior = temp;
                temp = temp.sig;

            } while (temp != primero);
            return val;
            Console.ReadKey();
            
        }


    }
}
