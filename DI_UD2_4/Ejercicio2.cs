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

        // Constructor con parámetros
        public Cancion(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
        }

        // Constructor predeterminado
        public Cancion()
        {
            this.Titulo = "";
            this.Autor = "";
        }

        public string DameTitulo()
        {
            return Titulo;
        }

        public string DameAutor()
        {
            return Autor;
        }

        public void PonTitulo(string titulo)
        {
            this.Titulo = titulo;
        }

        public void PonAutor(string autor)
        {
            this.Autor = autor;
        }

        public override string ToString()
        {
            return $"Cancion {{ Título = {Titulo}, Autor = {Autor} }}";
        }
    }
}
