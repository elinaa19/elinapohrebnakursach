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
        public List<Portion> Portions { private set; get; }
        public List <Criteria> Criterias { private set; get; }

        
        public Contora()
        {
            Flats = new List<Flat>();
            Buyers = new List<Buyer>();
           // Potencials = new List<Potencial>();
           // Solds = new List<Sold>();
           // Suitables = new List<Suitable>();
            Criterias = new List<Criteria>();
            Portions = new List<Portion>();
        }
       
        public void FillTestData(int n)
        {
            int a = 1;
            int b = 2;
            int f;
            int i;
            // Flats
            Flats = new List<Flat>();
            for ( i = 0; i < n; i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;
                
                   Flats.Add(new Flat( $"Flat{i}", $"23 Serpnya st, {i}", "Shevchenko", f.ToString(), 9.ToString(), (i * 1000).ToString(), "380975667865")
                    {
                       
                       
                        Name = $"Flat{i}",
                        Adress = $"23 Serpnya st, {i}",
                        Price = (i * 1000).ToString(),
                        Rooms = f.ToString(),
                        Condition = 9.ToString(),
                        Coords = "380975667865",
                        Neighbourhood = "Shevchenko",
                        Image = null,


                    })  ; ;
                
            }


            // Buyers
            Buyers = new List<Buyer>();
            

            for ( i = 0; i <= n; i++)
            {
               Buyers.Add(new Buyer($"Buyer{i}", "123"));
       
            }
            //Criterias 
            Criterias = new List<Criteria>();
            for(i = 0; i<=n;i++)
            {
                if (i % 2 == 0) f = a;
                else f = b;
                Criterias.Add(new Criteria()
                {
                    Price = (i * 1000).ToString(),
                    Rooms = f.ToString(),
                    Condition = 9.ToString(),
                    Neighbourhood = "Shevchenko"
                }) ;
            }
            //Portions 

            Portions = new List<Portion>();
            for (i = 0; i <= n; i++)
            {
                Portions.Add(new Portion { Buyer = Buyers[(i)], Criteria = Criterias[(i)] });
            }

            // Potencials

           // Potencials = new List<Potencial>();
           
            
            
           

             


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



