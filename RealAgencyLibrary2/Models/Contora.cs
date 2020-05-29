using RealtAgency.RealAgencyLibrary;
using RealtAgency.Data;
using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Drawing;

namespace RealtAgency.Models
{
    //Ріелтірська контора - це декілька колекцій : користувачів, квартир, порцій, крітерій.
    [Serializable]
    public class Contora
    {
        public List<Flat> Flats { private set; get; }
        public List<Buyer> Buyers { private set; get; }
        public List<Portion> Portions { private set; get; }
        public List <Criteria> Criterias { private set; get; }

        
        public Contora()
        {
            Flats = new List<Flat>();
            Buyers = new List<Buyer>();
            Criterias = new List<Criteria>();
            Portions = new List<Portion>();
        }
        // If any data changed.
        public bool IsDirty;

        public void FillTestData(int n)
        {
            int a = 1;
            int b = 2;
            int f;
            int i;
            // Flats
            Flats = new List<Flat>();
           var noImage = new Bitmap(Path.GetFullPath("flat.png"));
            for ( i = 0; i < n; i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;
                
                   Flats.Add(new Flat( $"Flat{i}", $"23 Serpnya st, {i}", "Shevchenko", f.ToString(), 9.ToString(), (i * 1000).ToString(), "380975667865", noImage)
                    {
                       
                       
                        Name = $"Flat{i}",
                        Adress = $"23 Serpnya st, {i}",
                        Price = (i * 1000).ToString(),
                        Rooms = f.ToString(),
                        Condition = 9.ToString(),
                        Coords = "380975667865",
                        Neighbourhood = "Shevchenko",
                        Image = noImage,


                    })  ; ;
                
            }


            // Buyers
            Buyers = new List<Buyer>();
            

            for ( i = 0; i <= n; i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;
                Buyers.Add(new Buyer($"Buyer{i}", "123"));
       
            }
            //Criterias 
            Criterias = new List<Criteria>();
            for(i = 0; i<=n;i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;
                Criterias.Add(new Criteria((i * 1000).ToString(), f.ToString(), 9.ToString(), "Shevchenko")) ;
            }
            //Portions 

            Portions = new List<Portion>();
            for (i = 0; i <= n; i++)
            {
                Portions.Add(new Portion { Buyer = Buyers[(i)], Criteria = Criterias[(i)] });
            }

        }

            public void Save()
            {
                new Dao(this).Save();
            
        }

            public void Load()
            {
                new Dao(this).Load();
                 IsDirty = false;

        }
       public void AddFlat(Flat flat)
        {
           Flats.Add(flat);
           IsDirty = false;
        }

    } 
    } 



