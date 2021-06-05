using PrestamosEjercicio.CapaDatos;
using PrestamosEjercicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.CapaNegocio
{
    public class NegocioTipoPrestamo
    {
        private List<TipoPrestamo> prestamos;
        private TipoPrestamoMapper mapper;

        public NegocioTipoPrestamo()
        {
            prestamos = new List<TipoPrestamo>();
            mapper = new TipoPrestamoMapper();
        }

        public List<TipoPrestamo> getAllTipoPrestamo()
        {
            return mapper.TraerTiposPrestamo();
        }
    }
}
