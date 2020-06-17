using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoronavirus.Models
{
    public class EstadisticasCoVid19
    {
        public Global Global { get; set; }
        public IEnumerable<Countries> Countries { get; set; }
        public DateTime Date { get; set; }
    }

    public class Global
    {

        public int NewConfirmed { get; set; }

        public int TotalConfirmed { get; set; }

        public int MyProperty { get; set; }

        public int NewDeaths { get; set; }

        public int TotalDeaths { get; set; }

        public int NewRecovered { get; set; }

        public int TotalRecovered { get; set; }

    }

    public class Countries
    {

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string Slug { get; set; }

        public int NewConfirmed { get; set; }

        public int TotalConfirmed { get; set; }

        public int NewDeaths { get; set; }

        public int TotalDeaths { get; set; }

        public int NewRecovered { get; set; }

        public int TotalRecovered { get; set; }

        public DateTime Date { get; set; }



    }


}
