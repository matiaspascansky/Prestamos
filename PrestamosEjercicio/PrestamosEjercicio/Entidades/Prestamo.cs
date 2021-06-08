using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.Entidades
{
    public class Prestamo
    {
        private string linea;
        private double TNA;
        private int plazo;
        private double monto;
        private string usuario;
        TipoPrestamo tipo;
        private int id;

        public Prestamo(string linea, double TNA, int plazo, double monto, string usuario, TipoPrestamo tipoPre)
        {
            this.linea = linea;
            this.TNA = TNA;
            this.plazo = plazo;
            this.monto = monto;
            this.usuario = usuario;
            this.Tipo = tipoPre;
        }

        public string Linea { get => linea; set => linea = value; }
        public double TNA1 { get => TNA; set => TNA = value; }
        public int Plazo { get => plazo; set => plazo = value; }
        public double Monto { get => monto; set => monto = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public TipoPrestamo Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id;}

        public double CuotaCapital()
        {
            return this.Monto / this.Plazo;
        }

        public double CuotaInteres()
        {
            return CuotaCapital() * (TNA1 / 12 / 100);
        }

        public double Cuota()
        {
            return CuotaCapital() + CuotaInteres();
        }

        public override string ToString()
        {
            return "id: " + Id.ToString() + " tna: " + TNA.ToString() + " plazo " + Plazo.ToString() + " monto" + Monto.ToString();
        }

    }
}
