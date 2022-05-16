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
using System.Diagnostics;

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
            List<Fresa> fs = Acceso.requeImagen();
            fs.Sort((a, b) => r.Next(-1, 1));

            var psi = new ProcessStartInfo();
            psi.FileName = @"G:\Python\python.exe";

            var script = @"C:\desplieguevision.py";
            var datourl = fs.First().Url;

            psi.Arguments = $"\"{script}\" \"{datourl}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            /*if (results.Contains("fresasmalas"))
            {
                return new Hallazgo(fs.First().Url, true, fs.First().Sector);
            }
            else return null;*/

            return new Hallazgo(fs.First().Url, true, fs.First().Sector);
        }
    }
}
