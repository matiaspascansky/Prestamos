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

        public List<Prestamo> TraerPrestamos(int registro = 1)
        {
            string json2 = WebHelper.Get("prestamo/" + registro);
            List<Prestamo> lst = MapList(json2);
            return lst;
        }

        public Prestamo TraerPorCodigo(int codigo)
        {
            string jsons = WebHelper.Get("prestamo/" + codigo.ToString());
            Prestamo p = JsonConvert.DeserializeObject<Prestamo>(jsons);
            return p;
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
            p.Add("id", prestamo.Id.ToString());
            p.Add("Linea", prestamo.Linea.ToString());
            p.Add("TNA", prestamo.TNA1.ToString());
            p.Add("Plazo", prestamo.Plazo.ToString());
            p.Add("idTipo", prestamo.Plazo.ToString());

            return p;
        }


    }
}
