using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealtAgency.RealAgencyLibrary.Models;
using RealtAgency.Models;

namespace RealtAgency.RealAgencyLibrary.Models
{
    [Serializable]
    // Порція - це покупець та його крітерії
    public class Portion
    {
        public Buyer Buyer { set; get; }
        public Criteria Criteria { set; get; }
    }
}
