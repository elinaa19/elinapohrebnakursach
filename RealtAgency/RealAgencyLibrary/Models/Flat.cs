using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.Models
{
    [Serializable]
    // Квартира – это  наименование + изображение + адрес + район + количество комнат + состояние + стоимость + координаты продавца
    public class Flat
    {
       
        public string Name { set; get; }
        public int Id { set; get; }

       //разобраться с картинкой и как ее правильно разместить через OpenFileDialog и PictureBox
        public string Adress { set; get; }
        public string Neighbourhood { set; get; }

        public string Rooms { set; get; }
        public string Condition { set; get; }
        public string Price { set; get; }

 
        public string Coords { set; get; }
        public List <Potencial> Potencials { private set; get; }



    }
}
