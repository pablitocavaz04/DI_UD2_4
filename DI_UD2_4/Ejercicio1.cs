using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_4
{

    public class Cancion
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }

        public Cancion(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
        }

        public Cancion()
        {
            this.Titulo = "";
            this.Autor = "";
        }

        public string DameTitulo() => Titulo;
        public string DameAutor() => Autor;

        public void PonTitulo(string titulo) => this.Titulo = titulo;
        public void PonAutor(string autor) => this.Autor = autor;

        public override string ToString()
        {
            return $"Cancion {{ Título = {Titulo}, Autor = {Autor} }}";
        }

        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("Bohemian Rhapsody", "Queen");
            Cancion cancion2 = new Cancion();

            cancion2.PonTitulo("Imagine");
            cancion2.PonAutor("John Lennon");

            Console.WriteLine(cancion1);
            Console.WriteLine(cancion2);
        }
    }
}
