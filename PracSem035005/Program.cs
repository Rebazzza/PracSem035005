using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace PracSem035005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListaCircular ls = new ListaCircular();
            Cancion C1 = new Cancion(1201,"Ghost Town","Rap","Kanye West" );
            Cancion C2 = new Cancion(1202, "Die Hard", "Rap", "Kendrick Lamar");
            Cancion C3 = new Cancion(1203, "She", "Hip-Hop", "Tyler, The Creator");
            int op = 100, cont = 1203 ;
            ls.Insertar(C1);
            ls.Insertar(C2);
            ls.Insertar(C3);

            do 
            {
                Console.Clear();
                Console.WriteLine("----------LISTA-CANCIONES----------");
                Console.WriteLine("[1]Mostrar lista");
                Console.WriteLine("[2]Agregar Canciones");
                Console.WriteLine("[3]Eliminar Canciones");
                Console.WriteLine("[0]Salir");
                Console.WriteLine("-----------------------------------");
                Console.Write("Eliga una opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: ls.recorrer1x1(); 
                        break;
                    case 2:
                        Console.Clear();
                        
                        Console.WriteLine("--------------AGREGAR--------------");
                        cont++;
                        Console.WriteLine("Ingrese el nombre de la canción: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el género de la canción: ");
                        string gen = Console.ReadLine();
                        Console.WriteLine("Ingrese el/la artista de la canción: ");
                        string artista = Console.ReadLine();
                        Cancion nc = new Cancion(cont,nombre,gen,artista);
                        ls.Insertar(nc);
                        Console.WriteLine("Canción ingresada.");
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 03:
                        Console.WriteLine("-------------ELIMINAR--------------");
                        Console.WriteLine("Ingrese codigo de la canción a elminar: ");
                        int eli = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------");
                        if (ls.Eliminar(eli) == false )
                        {
                            Console.WriteLine("Canción no encontrada.");

                        }
                        Console.WriteLine("-----------------------------------");
                        Console.ReadKey();

                        break;
                }
            } while (op!=0);
            Console.WriteLine("Saliendo....");

            Console.WriteLine();
            
            Console.ReadKey();

        }
    }
}
