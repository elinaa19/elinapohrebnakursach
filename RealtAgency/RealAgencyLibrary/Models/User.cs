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
        // абстрактный пользователь от которого наследуются  риелтор и клиент: имя + пароль

        public string Name { set; get; }
        public string Password { set; get; }
    }
}
