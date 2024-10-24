using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_4
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular() => titular;
        public void SetTitular(string titular) => this.titular = titular;
        public double GetCantidad() => cantidad;
        public void SetCantidad(double cantidad) => this.cantidad = cantidad;

        public override string ToString()
        {
            return $"Cuenta {{ Titular = {titular}, Cantidad = {cantidad} }}";
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }

        public static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Pablito", 100);
            Console.WriteLine(cuenta1);

            cuenta1.Ingresar(50);
            Console.WriteLine("Después de ingresar 50: " + cuenta1);

            cuenta1.Retirar(200);
            Console.WriteLine("Después de retirar 200: " + cuenta1);
        }
    }
}
