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
            NameValueCollection obj = reverseMapper(prestamo);

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


        private NameValueCollection reverseMapper(Prestamo prestamo)
        {

            NameValueCollection n = new NameValueCollection();
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString("0.00"));
            n.Add("Linea", prestamo.Linea);
            n.Add("TNA", prestamo.TNA1.ToString());
            n.Add("Cuota", prestamo.Cuota().ToString("0.00"));
            n.Add("idTipo", prestamo.Tipo.ToString());
            n.Add("Usuario", "887758");
           

      
            return n;
        }


    }
}
