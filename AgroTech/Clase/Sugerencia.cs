using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroTech.Clase
{
    internal class Sugerencia
    {
        private List<Sugerencia> sugerencias = new List<Sugerencia>();
        private static int valoresProcesados = 50;
        private static int valoressaltados = 0;


        private int sector;
        private string advertencia;
        private string tipoSensor;

        public Sugerencia()
        {
            Sector = 0;
            Advertencia = "";
            TipoSensor = "";
        }
        public Sugerencia(int sector, string advertencia, string tipoSensor)
        { 
            Sector = sector;
            Advertencia = advertencia;
            TipoSensor = tipoSensor;
        }

        public int Sector { get => sector; set => sector = value; }
        public string Advertencia { get => advertencia; set => advertencia = value; }
        public string TipoSensor { get => tipoSensor; set => tipoSensor = value; }
        internal List<Sugerencia> Sugerencias { get => sugerencias; set => sugerencias = value; }

        public void sistemaExperto()
        {
            List<Sensor> InfoSensor = new List<Sensor>();


            int datoT = 0, datoCA = 0, datoPH = 0, datoIL = 0, datoH = 0;

            for (int i = 1; i <= 3; i++)
            {
                InfoSensor = (List<Sensor>)(Acceso.InfoSensorFiltrado("Temperatura", i, "Sensor")).Skip(valoressaltados).Take(valoresProcesados).ToList();

                if(InfoSensor.Count > 0)
                {
                    foreach (Sensor sensor in InfoSensor) datoT = +sensor.Dato;

                    datoT = datoT / InfoSensor.Count();

                    if (datoT > 21) sugerencias.Add(new Sugerencia(i, "Granjero! debes disminuir la temperatura del ambiente, las fresas se dañarán pronto si seguimos con esta temperatura, " +
                            "se recomienda hacer riego en el sector.", "Temperatura"));
                    else if (datoT < 13) sugerencias.Add(new Sugerencia(i, "Granjero! debes aumentar la temperatura del ambiente, las fresas se dañarán pronto si seguimos con esta temperatura, " +
                             "se recomienda cubrir el sector para aumentar la temperatura y evitar el riego.", "Temperatura"));
                    else sugerencias.Add(new Sugerencia(i, "Temperatura perfecta.", "Temperatura"));
                }

                

                InfoSensor = (List<Sensor>)(Acceso.InfoSensorFiltrado("Humedad Suelo", i, "Sensor")).Skip(valoressaltados).Take(valoresProcesados).ToList();

                if (InfoSensor.Count > 0)
                {
                    foreach (Sensor sensor in InfoSensor) datoH = +sensor.Dato;

                    datoH = (int)((int)(datoH / InfoSensor.Count()) / 10) + 20;

                    if (datoH < 60) sugerencias.Add(new Sugerencia(i, "Aumentar la humedad con riego comun o atomizado.", "Humedad Suelo"));
                    else if (datoH > 80) sugerencias.Add(new Sugerencia(i, "Alta humedad, exponer el sector al calor.", "Humedad Suelo"));
                    else sugerencias.Add(new Sugerencia(i, "Humedad adecuada", "Humedad Suelo"));

                }


                InfoSensor = (List<Sensor>)(Acceso.InfoSensorFiltrado("PH", i, "Sensor")).Skip(valoressaltados).Take(valoresProcesados).ToList();

                if (InfoSensor.Count > 0)
                {
                    foreach (Sensor sensor in InfoSensor) datoPH = +sensor.Dato;

                    datoPH = datoPH / InfoSensor.Count();

                    if (datoPH < 5) sugerencias.Add(new Sugerencia(i, "Bajos niveles de PH, aumentar con caliza molida.", "PH"));
                    else if (datoPH > 7) sugerencias.Add(new Sugerencia(i, "Altos niveles de PH, aplicar materia organica, fertilizantes o sulfatos.", "PH"));
                    else sugerencias.Add(new Sugerencia(i, "PH adecuado para el sector", "PH"));

                }


                InfoSensor = (List<Sensor>)(Acceso.InfoSensorFiltrado("Intensidad Luminica", i, "Sensor")).Skip(valoressaltados).Take(valoresProcesados).ToList();

                if (InfoSensor.Count > 0)
                {
                    foreach (Sensor sensor in InfoSensor) datoIL = +sensor.Dato;

                    datoIL = datoIL / InfoSensor.Count();

                    if (datoIL < 14000) sugerencias.Add(new Sugerencia(i, "Poca intensidad Luminica, exponer el cultivo a la luz.", "Intensidad Luminica"));
                    else if (datoIL > 25000) sugerencias.Add(new Sugerencia(i, "Alta luminosidad, dejar de exponer el cultivo a la luz.", "Intensidad Luminica"));
                    else sugerencias.Add(new Sugerencia(i, "Intensidad Luminica adecuada en el sector", "Intensidad Luminica"));

                }


                InfoSensor = (List<Sensor>)(Acceso.InfoSensorFiltrado("Calidad Aire", i, "Sensor")).Skip(valoressaltados).Take(valoresProcesados).ToList();

                if (InfoSensor.Count > 0)
                {
                    foreach (Sensor sensor in InfoSensor) datoCA = +sensor.Dato;

                    datoCA = datoCA / InfoSensor.Count();

                    if (datoCA > 100) sugerencias.Add(new Sugerencia(i, "Alerta de calidad del aire, no exponer el sector", "Calidad Aire"));
                    else sugerencias.Add(new Sugerencia(i, "Calidad de Aire aceptable", "Calidad Aire"));
                } 

                datoT = 0;
                datoCA = 0;
                datoPH = 0;
                datoIL = 0;
                datoH = 0;
            }
            valoressaltados += 50;
        }
    }
}
