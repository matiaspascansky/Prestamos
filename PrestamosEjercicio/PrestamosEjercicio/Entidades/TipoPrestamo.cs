using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.Entidades
{
    public class TipoPrestamo
    {
        private string linea;
        private double tna;
        private int id;

        public TipoPrestamo(string linea, double tna, int id)
        {
            this.linea = linea;
            this.id = id;
            this.tna = tna;
        }

        public string Linea { get => linea; set => linea = value; }
        public double TNA { get => tna; set => tna = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "ID: " + Id + " TNA: " + TNA + " Linea: " + Linea;
        }
    }
}
