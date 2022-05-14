using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroTech.Clase
{
    internal class Fresa
    {

        private string tipo;
        private string url;
        private int sector;

        public Fresa()
        {
            Tipo = "";
            url = "";
            sector = 0;
        }

        public Fresa(string tipo, string url, int sector)
        {
            Tipo = tipo;
            Url = url;
            Sector = sector;
        }

        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Tipo")]
        public string Tipo { get => tipo; set => tipo = value; }

        [BsonElement("url")]
        public string Url { get => url; set => url = value; }

        [BsonElement("sector")]
        public int Sector { get => sector; set => sector = value; }
    }
}
