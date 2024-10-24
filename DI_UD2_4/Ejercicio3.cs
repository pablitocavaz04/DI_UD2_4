using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_4
{

    public class Juego
    {
        public static void Main(string[] args)
        {
            Juego partida1 = new Juego(5);
            partida1.MuestraVidasRestantes();
            partida1.Vidas--;
            partida1.MuestraVidasRestantes();

            Juego partida2 = new Juego(5);
            partida2.MuestraVidasRestantes();
            partida1.MuestraVidasRestantes();
        }

        public int Vidas { get; private set; }

        public Juego(int vidasIniciales)
        {
            this.Vidas = vidasIniciales;
        }

        public void MuestraVidasRestantes()
        {
            Console.WriteLine($"Vidas restantes: {Vidas}");
        }

    }
}
