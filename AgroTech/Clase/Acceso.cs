using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;

namespace AgroTech.Clase
{
    internal class Acceso
    {

        const string nombreDB = "AgroTech";
        const string idStringConexion = "DB";

        public static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<T> ObtenerRegistros<T>(IMongoDatabase unaDB, string nombreColeccion)
        {
            var unaColeccion = unaDB.GetCollection<T>(nombreColeccion);
            return (unaColeccion.Find(new BsonDocument()).ToList());
        }
        

        public static List<Sensor> InfoSensor(string nombre, string coleccion)
        {

            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            MongoClient clienteDB = new MongoClient(cadenaConexion);

            var miDB = clienteDB.GetDatabase(nombreDB);
            var coleccionProductos = miDB.GetCollection<Sensor>(coleccion);

            var filtroSensor = new BsonDocument {
                { "tipo", nombre }
            };

            var producto = coleccionProductos.Find(filtroSensor).ToList();

            return producto;

        }

    }
}
