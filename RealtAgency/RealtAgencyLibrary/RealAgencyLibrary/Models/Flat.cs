using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealtAgency.Models;

namespace RealtAgency.Models
{
    [Serializable]
    // Квартира – это  наименование + изображение + адрес + район + количество комнат + состояние + стоимость + координаты продавца
    public class Flat
    {
       
        public string Name { set; get; }
        public string Adress { set; get; }
        public string Neighbourhood { set; get; }

        public string Rooms { set; get; }
        public string Condition { set; get; }
        public string Price { set; get; }

        public Image Image { set; get; }
        public string Coords { set; get; }
      //  public List <Potencial> Potencials { private set; get; }

        public Flat( string name ="", string adress = "", string neighbourhood = "", string rooms = "", string condition = "", string price = "", string coords="", Image image = null)
        {
           
            Name = name;
            Adress = adress;
            Neighbourhood = neighbourhood;
            Rooms = rooms;
            Condition = condition;
            Price = price;
            Image = image;
            Coords = coords;
            //Potencials = potencials;
        }

        public Flat()
        {
            
        }
    }
}
