using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealtAgency.Models;

namespace RealtAgency.Models
{
    //Покупець - це ім'я + пароль.
    [Serializable]
    public class Buyer: User
    {

       
        public List<Criteria> YourFlats;


        public Buyer(string name, string password)
        {
            Name = name;
            Password = password;
            YourFlats = new List<Criteria> ();
        }
    }
}
