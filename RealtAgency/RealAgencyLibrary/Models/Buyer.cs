using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealtAgency.Models;

namespace RealtAgency.Models
{
    //Клиент -  имя + пароль.
    [Serializable]
    public class Buyer: User
    {
        public List<Criteria> Criterias { private set; get; }
        public List <Suitable> Suitables{ private set; get; }

        public Buyer(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
