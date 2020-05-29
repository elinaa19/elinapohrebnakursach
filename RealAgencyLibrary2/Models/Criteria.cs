using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.RealAgencyLibrary.Models
{
    [Serializable]
    public class Criteria
    {
        public string Price { get; set; }
        public string Rooms { set; get; }
        public string Condition { set; get; }
        public string Neighbourhood { set; get; }

        public Criteria (string price, string rooms, string condition, string neighbourhood)
        {
            Price = price;
            Rooms = rooms;
            Condition = condition;
            Neighbourhood = neighbourhood;
        }

        public Criteria()
        {

        }
       



}
}
