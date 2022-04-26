using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AgroTech
{
    internal class Sensor
    {

        private string tipo;
        private int dato;
        private int sector;

        public Sensor()
        {
            this.tipo = "";
            this.dato = 0;
            this.sector = 0;
        }

        public Sensor(string tipo, int dato, int sector)
        {
            this.tipo = tipo;
            this.dato = dato;
            this.sector = sector;
        }

        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get => tipo; set => tipo = value; }

        [BsonElement("dato")]
        public int Dato { get => dato; set => dato = value; }

        [BsonElement("sector")]
        public int Sector { get => sector; set => sector = value; }

    }
}
