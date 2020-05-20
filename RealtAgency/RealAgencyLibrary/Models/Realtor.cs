using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.Models
{
    // Администратор -  имя + пароль.
    [Serializable]
    public class Realtor : User
    {
        public Realtor(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }

}
