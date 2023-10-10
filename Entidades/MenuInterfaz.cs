using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Entidades
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del menú
    /// Contiene las acciones desde el menú
    /// </summary>
    internal interface MenuInterfaz
    {
        public void mensajeBienvenida();

        public int mostrarMenu();

        public string opciIgualdad();

        public string opcDesigualdad();
    }
}
