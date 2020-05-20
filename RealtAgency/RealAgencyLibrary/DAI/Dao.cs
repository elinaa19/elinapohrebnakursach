

using RealtAgency.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace RealtAgency.Data
{
    public class Dao
    {
        Contora store;
        const string filePath = "store.bin";

        public Dao(Contora store)
        {
            this.store = store;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, store);
            }
        }

       public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                    Contora st = (Contora)serializer.Deserialize(stream);

                    Copy(st.Flats, store.Flats);
                    Copy(st.Buyers, store.Buyers);
                   // Copy(st.Potencials, store.Potencials);
                    //Copy(st.Solds, store.Solds);
                    //Copy(st.Suitables, store.Suitables);
                }
            

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}