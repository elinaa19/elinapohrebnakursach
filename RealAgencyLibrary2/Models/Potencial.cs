using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.RealAgencyLibrary.Models
{
    [Serializable]
    public class Potencial
    {
        public Portion Portion { private set; get; }
        public Flat Flat { private set; get; }

    }
}
