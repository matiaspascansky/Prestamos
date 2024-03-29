﻿using PrestamosEjercicio.CapaDatos;
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

        public TransactionResult insertar(double tna, string linea, int plazo, double monto, string usuario, TipoPrestamo tipo)
        {
            Prestamo prestamo = new Prestamo(linea, tna, plazo, monto, usuario, tipo);
           // buscarRepetido(prestamo);
            return mapper.Insertar(prestamo);
        }

        private void buscarRepetido(Prestamo pres)
        {
            List<Prestamo> prestamos = mapper.TraerPorLegajo(887758);

            foreach (Prestamo p in prestamos)
            {
                if(p == pres)
                {
                    throw new PrestamoExistenteException("Prestamo ya registrado");
                }
            }
          
            
        }
    }

 
}
