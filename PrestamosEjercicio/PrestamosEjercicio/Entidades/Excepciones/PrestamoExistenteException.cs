using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.Entidades.Excepciones
{
    public class PrestamoExistenteException : Exception
    {
        public PrestamoExistenteException(string msg) : base(msg) { }

    }
}
