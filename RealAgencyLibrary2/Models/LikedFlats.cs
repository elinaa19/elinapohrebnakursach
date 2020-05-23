//using ProductStore.DAL;
using RealtAgency.Data;
using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealtAgency.RealAgencyLibrary.Models
{
    [Serializable]
    public class LikedFlats
    {
        public List <Flat> Flats { private set; get; }
        public List <Buyer> Buyers { private set; get; }

    }
}