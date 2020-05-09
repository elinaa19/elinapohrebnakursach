
using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtAgency.Data
{
    class Dao1
    {
        private readonly Contora contora;
        const string FLATS = "flats.txt";

        public Dao1(Contora contora)
        {
            this.contora = contora;
        }

        public void Save()
        {
            SaveProducts();
            SaveBuyers();
            //SaveOrders();
        }

        private void SaveProducts()
        {
            using (var wr = new StreamWriter(FLATS))
            {
                wr.WriteLine(contora.Flats.Count);
                foreach (var p in contora.Flats)
                {
                    wr.WriteLine(p.Id);
                    wr.WriteLine(p.Name);
                    wr.WriteLine(p.Adress);
                    wr.WriteLine(p.Price);
                    wr.WriteLine(p.Rooms);
                    wr.WriteLine(p.Condition);
                    wr.WriteLine(p.Coords);
                }
            }
        }

        private void SaveBuyers()
        {
            using (var wr = new StreamWriter("buyers.txt"))
            {
                wr.WriteLine(contora.Buyers.Count);
                foreach (var b in contora.Buyers)
                {
                    wr.WriteLine(b.Name);
                    wr.WriteLine(b.Password);
                }
            }
        }

      /*  private void SaveOrders()
        {
            using (var wr = new StreamWriter("orders.txt"))
            {
                wr.WriteLine(store.Orders.Count);
                foreach (var o in store.Orders)
                {
                    wr.WriteLine(o.Buyer.Name);
                    wr.WriteLine(o.DateTime);

                    wr.WriteLine(o.Portions.Count);
                    foreach (var p in o.Portions)
                    {
                        wr.WriteLine(p.Amount);
                        wr.WriteLine(p.Product.Id);
                    }
                }
            }
        }

    */

        public void Load()
        {
            LoadProducts();
            LoadBuyers();
            //LoadOrders();
        }

        private void LoadProducts()
        {
            using (var rd = new StreamReader(FLATS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                contora.Flats.Clear();
                for (int i = 0; i < n; i++)
                {
                    contora.Flats.Add(new Flat
                    {
                        Id = Convert.ToInt32(rd.ReadLine()),
                        Name = rd.ReadLine(),
                        Price = Convert.ToInt32(rd.ReadLine()),
                        Adress = rd.ReadLine(),
                        Rooms = Convert.ToInt32(rd.ReadLine()),
                        Condition = Convert.ToInt32(rd.ReadLine()),
                        Coords = rd.ReadLine()
                    }) ;
                }
            }
        }

        private void LoadBuyers()
        {
            using (var rd = new StreamReader("buyers.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                contora.Buyers.Clear();
                for (int i = 0; i < n; i++)
                {
                    contora.Buyers.Add(new Buyer
                    {
                        Name = rd.ReadLine(),
                        Password = rd.ReadLine(),
                    });
                }
            }
        }

     /*   private void LoadOrders()
        {
            using (var rd = new StreamReader("orders.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                contora.Orders.Clear();
                for (int i = 0; i < n; i++)
                {
                    var name = rd.ReadLine();
                    var time = Convert.ToDateTime(rd.ReadLine());
                    var ps = ReadPortions(rd);
                    store.Orders.Add(new Order(ps, GetBuyerByName(name), time));
                }
            }
        }
        */
        private Buyer GetBuyerByName(string name) =>
            contora.Buyers.Single(b => b.Name == name);

        /*private List<Portion> ReadPortions(StreamReader rd)
        {
            int n = Convert.ToInt32(rd.ReadLine());
            var ps = new List<Portion>();
            for (int i = 0; i < n; i++)
            {
                var amount = Convert.ToDouble(rd.ReadLine());
                var productId = Convert.ToInt32(rd.ReadLine());
                ps.Add(new Portion
                {
                    Amount = amount,
                    Product = GetProductById(productId)
                });
            }
            return ps;
        }*/

        private Flat GetProductById(int flatId) =>
            contora.Flats.Single(p => p.Id == flatId);
    }
}