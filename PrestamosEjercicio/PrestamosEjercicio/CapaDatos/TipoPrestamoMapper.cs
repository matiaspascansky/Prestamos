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
    public class TipoPrestamoMapper
    {

        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            string json2 = WebHelper.Get("prestamotipo");
            List<TipoPrestamo> lst = MapList(json2);
            return lst;
        }

        private List<TipoPrestamo> MapList(string json2)
        {
            List<TipoPrestamo> lst = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json2);
            return lst;
        }

        private TipoPrestamo Map(string jsons)
        {
            TipoPrestamo tipoPrestamo = JsonConvert.DeserializeObject<TipoPrestamo>(jsons);
            return tipoPrestamo;
        }

        private NameValueCollection ReverseMap(TipoPrestamo tipoPrestamo)
        {
            NameValueCollection p = new NameValueCollection();
            // p.Add("id", producto.Id.ToString());
            //.Add("id")
            return p;
        }
    }
}
