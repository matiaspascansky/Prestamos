using PrestamosEjercicio.CapaDatos;
using PrestamosEjercicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.CapaNegocio
{
    public class NegocioPrestamo
    {
        private List<Prestamo> prestamos;
        private PrestamoMapper mapper;


        public NegocioPrestamo()
        {
            prestamos = new List<Prestamo>();
            mapper = new PrestamoMapper();
        }
        
        public List<Prestamo> getAllPrestamo()
        {
            return mapper.TraerPrestamos();
        }

    }

 
}
