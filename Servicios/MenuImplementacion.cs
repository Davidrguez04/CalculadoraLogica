using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
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

        public void opciIgualdad()
        {
            bool esIgual;
           
            string pExpresion=pedirTexto("Introduzca la primera expresión: ");
           
            string sExpresion = pedirTexto("Introduzca la segunda expresión: ");

            if(pExpresion==sExpresion)
            {
                esIgual = true;
            }
            else
            {
                esIgual = false;
            }

            Console.WriteLine("Resultado de la igualdad: "+esIgual);

           

        }

        public void opcDesigualdad()
        {
            bool esDesigual;
           
            string ppExpresion = pedirTexto("Introduzca la primera expresión: ");

            string ssExpresion = pedirTexto("Introduzca la segunda expresión: ");

            if (ppExpresion == ssExpresion)
            {
                esDesigual = false;
            }
            else
            {
                esDesigual = true;
            }

            Console.WriteLine("Resultado de la igualdad: " + esDesigual);

            
        }
        public string pedirTexto(string mensaje)
        {
            string texto;
            
            Console.WriteLine(mensaje);
            texto = Console.ReadLine();

            return texto;
        }
    }
}
