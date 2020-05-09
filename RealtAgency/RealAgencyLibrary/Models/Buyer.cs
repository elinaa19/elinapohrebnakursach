using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.Models
{
    //Клиент -  имя + пароль.
    [Serializable]
    public class Buyer: User
    {
        public List<Criteria> Criterias { private set; get; }
        public List <Suitable> Suitables{ private set; get; }

    }
}
