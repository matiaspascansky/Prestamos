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

        public List<Prestamo> TraerPrestamos()
        {
            int id = 3;
            string json2 = WebHelper.Get("prestamo/" + id);
            List<Prestamo> lst = MapList(json2);
            return lst;
        }

        private List<Prestamo> MapList(string json2)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json2);
            return lst;
        }

        private Prestamo Map(string jsons)
        {
            Prestamo producto = JsonConvert.DeserializeObject<Prestamo>(jsons);
            return producto;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection p = new NameValueCollection();
           // p.Add("id", producto.Id.ToString());
            //.Add("id")
            return p;
        }


    }
}
