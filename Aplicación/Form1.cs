using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo CancionActual = null;
        ListaCircular ls = new ListaCircular();
        SoundPlayer player;
        bool val = false;
        private void button2_Click(object sender, EventArgs e)
        {
            CancionActual = CancionActual.sig;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
            ls.Insertar(new Cancion { codigo = 1202, nombre = "Ghost Town", genero = "Rap", artista = "Kanye West", ruta = "C:\\Users\\ma5ti\\Downloads\\Ghost Town.wav", img= "C:\\Users\\ma5ti\\OneDrive\\Documentos\\600x600bb (2).jpg" });
            ls.Insertar(new Cancion { codigo = 1202, nombre = "Die Hard", genero = "Rap", artista = "Kendrick Lamar", ruta = "C:\\Users\\ma5ti\\Downloads\\Kendrick Lamar - Die Hard ft. Blxst & Amanda Reifer (Official Audio).wav", img = "C:\\Users\\ma5ti\\OneDrive\\Documentos\\22UMGIM52376.rgb.jpg" });
            ls.Insertar(new Cancion { codigo = 1203, nombre = "She", genero = "Hip-Hop", artista = "Tyler, The Creator", ruta = " C:\\Users\\ma5ti\\Downloads\\Tyler, The Creator - She (Feat. Frank Ocean) - Goblin (HQ).wav" , img = "C:\\Users\\ma5ti\\OneDrive\\Documentos\\600x600bb (1).jpg" });
            ls.Insertar(new Cancion { codigo = 1203, nombre = "Cool", genero = "Pop", artista = "Daniel Caesar", ruta = "C:\\Users\\ma5ti\\Downloads\\Daniel Caesar - Cool (Lyric Video).wav" , img = "C:\\Users\\ma5ti\\OneDrive\\Documentos\\600x600bb.jpg" });
            CancionActual = ls.primero;
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            CancionActual = CancionActual.sig;
            player = new SoundPlayer(CancionActual.dato.ruta);
            player.Play();
            label1.Text = CancionActual.dato.nombre;
            label2.Text = CancionActual.dato.artista;
            pictureBox1.Image = Image.FromFile(CancionActual.dato.img);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CancionActual = CancionActual.ant;
            label1.Text = CancionActual.dato.nombre;
            label2.Text = CancionActual.dato.artista;

            player = new SoundPlayer(CancionActual.dato.ruta);
            player.Play();

            pictureBox1.Image = Image.FromFile(CancionActual.dato.img);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            player = new SoundPlayer(CancionActual.dato.ruta);
            player.Play();
            label1.Text =  CancionActual.dato.nombre;
            label2.Text =  CancionActual.dato.artista;
            pictureBox1.Image = Image.FromFile(CancionActual.dato.img);
            player.Stop();
            if (val)
            {
                player.Stop();
                val = false;
            }
            else
            {
                player.Play();
                    val =true;
            }
              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
