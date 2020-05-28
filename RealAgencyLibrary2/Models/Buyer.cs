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

        //  public string Price { get; set; }
        //  public string Rooms { set; get; }
        //  public string Condition { set; get; }
        //    public string Neighbourhood { set; get; }
        public List<Criteria> YourFlats;


        public Buyer(string name, string password/*, string price, string rooms, string condition, string neighbourhood*/)
        {
            Name = name;
            Password = password;
            //  Price = price;
            //   Rooms = rooms;
            //   Condition = condition;
            //   Neighbourhood = neighbourhood;
            YourFlats = new List<Criteria> ();
        }
    }
}
