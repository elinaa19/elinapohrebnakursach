//using RealtAgency.RealAgencyLibrary.DAL;
using RealtAgency.Data;
using RealtAgency.RealAgencyLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealtAgency.Data;

namespace RealtAgency.Models
{

    // Риэлтерская контора — это несколько коллекций: пользователей, квартир, подходящих квартир, проданных квартир, подходящих пользователей

    [Serializable]
    public class Contora
    {
        public List<Flat> Flats { private set; get; }
        public List<Buyer> Buyers { private set; get; }
        public List<Potencial> Potencials { private set; get; }
        public List<Sold> Solds { private set; get; }
        public List<Suitable> Suitables { private set; get; }


        public Contora()
        {
            Flats = new List<Flat>();
            Buyers = new List<Buyer>();
            Potencials = new List<Potencial>();
            Solds = new List<Sold>();
            Suitables = new List<Suitable>();
        }

        public void FillTestData(int n)
        {
            int a = 1;
            int b = 2;
            int f;
            // Products
            Flats.Clear();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;


                for (int j = 10; j < n + 1000; j += 3)
                {
                    Flats.Add(new Flat()
                    {
                        Id = i,
                        Name = $"Flat{i}",
                        Adress = $"23 Serpnya st, {j}",
                        Price = i * 10000,
                        Rooms = f,
                        Condition = 9,
                        Coords = "380975667865"

                    }); ;
                }
            }


            // Buyers
            Buyers.Clear();
            for (int i = 1; i <= n; i++)
            {
                Buyers.Add(new Buyer { Name = $"Buyer{i}", Password = "123" });
            }

            /*         // Orders
                         Orders.Clear();
                         const int m = 5;
                         for (int i = 0; i < n - m; i++)
                         {
                             var ps = new List<Portion>();
                             for (int j = 0; j < m; j++)
                             {
                                 ps.Add(new Portion { Product = Products[i + j], Amount = j });
                             }
                             Orders.Add(new Order(ps, Buyers[i], DateTime.Now + TimeSpan.FromDays(i)));
                         }
                         // Supplies
                         // ...
                     */
        }

            public void Save()
            {
                new Dao(this).Save();
            }

            public void Load()
            {
                new Dao(this).Load();
            }

        }
    } 



