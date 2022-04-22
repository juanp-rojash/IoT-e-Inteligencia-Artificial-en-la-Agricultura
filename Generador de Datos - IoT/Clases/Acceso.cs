using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Generador_de_Datos___IoT.Clases
{
    internal class Acceso
    {

        const string nombreDB = "AgroTech";
        const string idStringConexion = "DB";

        public static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /*public static List<T> ObtenerRegistros<T>(IMongoDatabase unaDB, string nombreColeccion)
        {
            var unaColeccion = unaDB.GetCollection<T>(nombreColeccion);
            return (unaColeccion.Find(new BsonDocument()).ToList());
        }
        */

        public static void InsertarRegistro<T>(string coleccion, T registro)
        {

            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            MongoClient clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var unaColeccion = miDB.GetCollection<T>(coleccion);
            unaColeccion.InsertOne(registro);
        }
    }
}
