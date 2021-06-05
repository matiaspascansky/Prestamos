using PrestamosEjercicio.CapaDatos;
using PrestamosEjercicio.Entidades;
using PrestamosEjercicio.Entidades.Excepciones;
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

        public TransactionResult insertar(int id, double tna, string linea, int plazo, int idCliente, double monto, string usuario, TipoPrestamo tipo)
        {
            Prestamo prestamo = new Prestamo(linea, tna, plazo, monto, usuario, id, tipo);
            buscarRepetido(id);
            return mapper.Insertar(prestamo);
        }

        private void buscarRepetido(int id)
        {
            Prestamo p = mapper.TraerPorCodigo(id);

            if (p == null)
            {
                throw new PrestamoExistenteException("Prestamo ya registrado");
            }
        }
    }

 
}
