using Newtonsoft.Json;
using PrestamosEjercicio.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosEjercicio.CapaDatos
{
    public class PrestamoMapper
    {

        public List<Prestamo> TraerPrestamos(int registro = 887758)
        {
            string json2 = WebHelper.Get("prestamo/" + registro);
            List<Prestamo> lst = MapList(json2);
            return lst;
        }

        public List<Prestamo> TraerPorLegajo(int legajo = 887758)
        {
            string jsons = WebHelper.Get("prestamo/" + legajo.ToString());
            List<Prestamo> lst = MapList(jsons);
            return lst;
        }

        public TransactionResult Insertar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);

            string json = WebHelper.Post("prestamo", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;

        }
        private List<Prestamo> MapList(string json2)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json2);
            return lst;
        }

        private Prestamo Map(string jsons)
        {
            Prestamo prestamo = JsonConvert.DeserializeObject<Prestamo>(jsons);
            return prestamo;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection p = new NameValueCollection();
            p.Add("TNA", prestamo.TNA1.ToString("0.00"));
            p.Add("Plazo", prestamo.Plazo.ToString());
            p.Add("idTipo", prestamo.Tipo.Id.ToString());
            p.Add("Monto", prestamo.Monto.ToString("0.00"));
            p.Add("Cuota", prestamo.Cuota().ToString("0.00"));
            p.Add("Usuario", "887758");
            p.Add("Linea", prestamo.Linea.ToString());


            return p;
        }


    }
}
