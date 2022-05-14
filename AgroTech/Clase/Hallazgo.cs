using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace AgroTech.Clase
{
    internal class Hallazgo
    {
        private static Random r = new Random();
        private string url;
        private bool deterioro;
        private int sector;

        public Hallazgo()
        {
            Url = "";
            Deterioro = false;
            Sector = 0;
        }

        public Hallazgo(string url, bool deterioro, int sector)
        {
            Url = url;
            Deterioro = deterioro;
            Sector = sector;
        }

        public string Url { get => url; set => url = value; }
        public bool Deterioro { get => deterioro; set => deterioro = value; }
        public int Sector { get => sector; set => sector = value; }

        public Hallazgo analisisImagen()
        {
            string pathpy = @"C:\desplieguevision.py";
            ScriptRuntime py = Python.CreateRuntime();
            dynamic pyPrograma = py.UseFile(pathpy);

            List<Fresa> fs = Acceso.requeImagen();
            fs.Sort((a, b) => r.Next(-1, 1));

            var dato = pyPrograma.PrediccionFresa(fs.First().Url);

            if (dato.equals("fresasmalas"))
            {
                return new Hallazgo(fs.First().Url, true, fs.First().Sector);
            }
            else return null;
        }
    }
}
