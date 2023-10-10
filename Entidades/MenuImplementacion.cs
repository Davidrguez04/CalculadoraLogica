using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Entidades
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL MENU
    /// 101023 - David RA
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mensaje = "Bienvenido a tu Calculadora Lógica";
            Console.WriteLine("\n\n\t\t\t\t" + mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t--------------------------------");
            Console.WriteLine("\t\t\t\t|\tMenú:            ");
            Console.WriteLine("\t\t\t\t|                     ");
            Console.WriteLine("\t\t\t\t|1.-Cerrar                     ");
            Console.WriteLine("\t\t\t\t|2.-Igualdad                     ");
            Console.WriteLine("\t\t\t\t|3.-Desigualdad          ");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public string opciIgualdad()
        {
            bool esIgual;
           

            Console.WriteLine("Introduzca la primera expresión: ");
            string pExpresion=Console.ReadLine();

            Console.WriteLine("Introduzca la segunda expresión: ");
            string sExpresion = Console.ReadLine();

            if(pExpresion==sExpresion)
            {
                esIgual = true;
            }
            else
            {
                esIgual = false;
            }

            Console.WriteLine("Resultado de la igualdad: "+esIgual);

            return pExpresion;

        }

        public string opcDesigualdad()
        {
            bool esDesigual;
           

            Console.WriteLine("Introduzca la primera expresión: ");
            string ppExpresion = Console.ReadLine();

            Console.WriteLine("Introduzca la segunda expresión: ");
            string ssExpresion = Console.ReadLine();

            if (ppExpresion == ssExpresion)
            {
                esDesigual = false;
            }
            else
            {
                esDesigual = true;
            }

            Console.WriteLine("Resultado de la igualdad: " + esDesigual);

            return ppExpresion;
        }
    }
}
