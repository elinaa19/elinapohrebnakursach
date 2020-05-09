

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
        Contora contora;
        const string filePath = "store.bin";

        public Dao(Contora contora)
        {
            this.contora = contora;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, contora);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Contora st = (Contora)serializer.Deserialize(stream);

                Copy(st.Flats, contora.Flats);
                Copy(st.Buyers, contora.Buyers);
                Copy(st.Potencials, contora.Potencials);
                Copy(st.Solds, contora.Solds);
                Copy(st.Suitables, contora.Suitables);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}