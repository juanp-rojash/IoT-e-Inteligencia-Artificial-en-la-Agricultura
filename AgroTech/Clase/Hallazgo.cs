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

        string url;
        bool deterioro;

        public Hallazgo()
        {
            Url = "";
            Deterioro = false;
        }

        public Hallazgo(string url, bool deterioro)
        {
            Url = url;
            Deterioro = deterioro;
        }

        public string Url { get => url; set => url = value; }
        public bool Deterioro { get => deterioro; set => deterioro = value; }

        public void analisisImagen(string url)
        {
            string pathpy = Path.Combine(Application.StartupPath, "..\\desplieguevision.py");
            
            ScriptRuntime py = Python.CreateRuntime();
            dynamic pyPrograma = py.UseFile(pathpy);

            pyPrograma.PrediccionFresa(url);
        }
    }
}
