using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliaNahuelPrimerParcial_Tema2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Pirámides Cuadradas");
            Console.WriteLine("----------------------------------");

            int contadorPiramides = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el lado de la base (0 para salir):");
                double ladoBase = LeerDoublePositivo();

                if (ladoBase == 0)
                    break;

                Console.WriteLine("Ingrese la altura:");
                double altura = LeerDoublePositivo();

                double area = CalcularArea(ladoBase, altura);
                double volumen = CalcularVolumen(ladoBase, altura);
                double arista = CalcularArista(ladoBase, altura);

                Console.WriteLine("Área de la pirámide: " + area);
                Console.WriteLine("Volumen de la pirámide: " + volumen);
                Console.WriteLine("Arista de la pirámide: " + arista);
                Console.WriteLine("----------------------------------");

                contadorPiramides++;
            }

            Console.WriteLine("Cantidad de pirámides ingresadas: " + contadorPiramides);
        }

         static double CalcularArista(double ladoBase, double altura)
        {
            double arista = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(ladoBase, 2)) / 2;
            return arista;
        }

        static double CalcularArea(double ladoBase, double altura)
        {
            double area = ladoBase * (ladoBase + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(ladoBase, 2))) / 2;
            return area;
        }

        static double CalcularVolumen(double ladoBase, double altura)
        {
            double volumen = (Math.Pow(ladoBase, 2) * altura) / 3;
            return volumen;
        }

        static double LeerDoublePositivo()
        {
            double valor;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                    break;
                Console.WriteLine("Error: Ingrese un valor numérico positivo válido.");
            }
            return valor;
        }
    }
}

