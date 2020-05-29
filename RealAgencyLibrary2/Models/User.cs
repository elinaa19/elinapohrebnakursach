using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.Models
{
    [Serializable]
    public abstract class User
    {
        // Абстрактний користувач від якого наслідується рвелтор та користувач: ім'я + пароль

        public string Name { set; get; }
        public string Password { set; get; }

      

}
}
