using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq.Ex2
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas>? getData(string pathFile)
        {
            StreamReader r = new StreamReader(pathFile);
            string jsonString = r.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            if (lst != null)
                return lst.PenalidadesAplicadas;
            return null;
        }
    }
}
