using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.Entidades
{
    [DataContract]
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
        [DataMember]
        public string Linea { get => linea; set => linea = value; }
        [DataMember]
        public double TNA { get => tna; set => tna = value; }
        [DataMember]
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "ID: " + Id + " TNA: " + TNA + " Linea: " + Linea;
        }
    }
}
