using CalculadoraLogica.Entidades;
using System;

namespace CalculadoraLogica.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 101023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>



        static void Main(string[] args)
        {
            //Llamada al método que imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            bool cerrarMenu = false;

            menuInterfaz.mensajeBienvenida();

            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.Clear();

                switch(opcionSeleccionada)
                {
                    case 1:
                        Console.Write("\n\n[INFO]- Has seleccionado la opción Cerrar\n\n");
                        cerrarMenu |= true;
                        break;

                    case 2:
                        Console.Write("\n\n[INFO]- Has seleccionado la opción igualdad\n\n");
                        menuInterfaz.opciIgualdad();
                        break;

                    case 3:
                        Console.Write("\n\n[INFO]- Has seleccionado la opción desigualdad\n\n");
                        menuInterfaz.opcDesigualdad();
                        break;

                    default:
                        Console.WriteLine("[ERROR]- La opción seleccionada es incorrecta!!!!");
                        break;


                }

            }


        }

    }
}
