using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del menú
    /// Contiene las acciones desde el menú
    /// </summary>
    internal interface MenuInterfaz
    {
        public void mensajeBienvenida();

        public int mostrarMenu();

        public void opciIgualdad();

        public void opcDesigualdad();

        public string pedirTexto(string texto);
    }
}
