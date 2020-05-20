using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.RealAgencyLibrary.Models
{
    [Serializable]
    public class Sold
    {
        public Sold(List<Flat> flats, DateTime? t = null)
        {
            Flats = flats;
          
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }
        public List<Flat> Flats { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
