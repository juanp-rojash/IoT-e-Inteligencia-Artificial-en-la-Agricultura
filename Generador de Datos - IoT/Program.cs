using Generador_de_Datos___IoT.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Generador_de_Datos___IoT
{
    internal class Program
    {
        public enum TipoTemperatura { Frio, Templado, Caluroso };
        public static Random ran = new Random();
        public static int contador = 0, mili;
        public static TipoTemperatura opcT = TipoTemperatura.Frio;

        static void Main(string[] args)
        {
            int opc, opc1, opc2, opc3, opc4, opc5, opcS;
            bool salir = false;
            

            while (true)
            {
                Console.WriteLine("Componentes IoT \n1. Sensores de Temperatura" +
                                                  "\n2. Sensores de Calidad del Aire" +
                                                  "\n3. Sensores de Intensidad Lumínica" +
                                                  "\n4. Sensores de Humedad del Suelo" +
                                                  "\n5. Sensores de PH" +
                                                  "\n6. Salir" +
                                                  "\nIngrese el numero de su eleccion:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Sensores de Temperatura" + "\n1. LM35 \n2. SHT10 (RH) \nIngrese el numero de su eleccion:");
                        opc1 = int.Parse(Console.ReadLine());

                        if (opc1 == 1)
                        {
                            Console.WriteLine("Clima" + "\n1. Frio \n2. Templado \n3. Caluroso \nIngrese el numero de su eleccion:");
                            opcS = int.Parse(Console.ReadLine());

                            if(opcS == 1)opcT = TipoTemperatura.Frio;
                            else if(opcS == 2)opcT = TipoTemperatura.Templado;
                            else if(opcS == 3)opcT = TipoTemperatura.Caluroso;

                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoTemperatura = new Thread(GeneradorTemperatura);
                            procesoTemperatura.Start();
                        }
                        else if (opc1 == 2)
                        {
                            Console.WriteLine("Clima" + "\n1. Frio \n2. Templado \n3. Caluroso \nIngrese el numero de su eleccion:");
                            opcS = int.Parse(Console.ReadLine());
                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoRH = new Thread(GeneradorHumedadRelativa);
                            procesoRH.Start();
                        }
                        else Console.WriteLine("Opcion invalida");

                        break;
                    case 2:
                        Console.WriteLine("Sensores de Calidad del Aire" + "\n1. MQ135 \nIngrese el numero de su eleccion:");
                        opc2 = int.Parse(Console.ReadLine());

                        if(opc2 == 1)
                        {
                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoCalidadAire = new Thread(GeneradorCalidadAire);
                            procesoCalidadAire.Start();
                        }
                        else Console.WriteLine("Opcion invalida");

                        break;
                    case 3:
                        Console.WriteLine("Sensores de Intensidad Lumínica" + "\n1. TSL2561 \nIngrese el numero de su eleccion:");
                        opc3 = int.Parse(Console.ReadLine());

                        if(opc3 == 1)
                        {
                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoIntensidadLuminica = new Thread(GeneradorIntensidadLuminica);
                            procesoIntensidadLuminica.Start();
                        }
                        else Console.WriteLine("Opcion invalida");

                        break;
                    case 4:
                        Console.WriteLine("Sensores de Humedad del Suelo" + "\n1. HD-38 \nIngrese el numero de su eleccion:");
                        opc4 = int.Parse(Console.ReadLine());

                        if (opc4 == 1)
                        {
                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoHumedadSuelo = new Thread(GeneradorHumedadSuelo);
                            procesoHumedadSuelo.Start();
                        }
                        else Console.WriteLine("Opcion invalida");

                        break;
                    case 5:
                        Console.WriteLine("Sensores de PH" + "\n1. SPH BNC \nIngrese el numero de su eleccion:");
                        opc5 = int.Parse(Console.ReadLine());

                        if (opc5 == 1)
                        {
                            Console.WriteLine("Tiempo en generar datos (Milisegundos)");
                            mili = int.Parse(Console.ReadLine());

                            Thread procesoPH = new Thread(GeneradorPH);
                            procesoPH.Start();
                        }
                        else Console.WriteLine("Opcion invalida");

                        break;
                    default:
                        salir = true;
                    break;
                }

                if (salir) break;
            }
        }


        public static void GeneradorTemperatura() 
        {
            int envios = 0, dato, sector;
            string nombre = "Temperatura" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("Temperatura");

            if (opcT == TipoTemperatura.Frio)
            {
                dato = ran.Next(13, 16);
                sector = ran.Next(1, 4);

                for (int i=0; i<500; i++)
                {
                    sw.WriteLine(dato);
                    Sensor DatoSensor = new Sensor("Temperatura", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    envios++;
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if(envios == 100)
                    {
                        dato = ran.Next(13, 16);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }

                }
            }
            else if(opcT == TipoTemperatura.Templado)
            {
                dato = ran.Next(16, 21);
                sector = ran.Next(1, 4);

                for (int i = 0; i < 500; i++)
                {
                    sw.WriteLine(dato);
                    Sensor DatoSensor = new Sensor("Temperatura", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if (envios == 100)
                    {
                        dato = ran.Next(16, 21);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }
                }
            }
            else
            {
                dato = ran.Next(21, 24);
                sector = ran.Next(1, 4);

                for (int i = 0; i < 500; i++)
                {
                    sw.WriteLine(dato);
                    Sensor DatoSensor = new Sensor("Temperatura", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if (envios == 100)
                    {
                        dato = ran.Next(21, 24);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }
                }
            }

            sw.Close();
        }

        public static void GeneradorHumedadRelativa()
        {
            int envios = 0, dato, sector;
            string nombre = "Humedad Relativa" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("Humedad Relativa");

            if (opcT == TipoTemperatura.Frio)
            {
                dato = ran.Next(81, 84);
                sector = ran.Next(1, 4);

                for (int i = 0; i < 500; i++)
                {
                    sw.WriteLine(dato + "%");
                    Sensor DatoSensor = new Sensor("Humedad Relativa", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    envios++;
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if (envios == 100)
                    {
                        dato = ran.Next(81, 84);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }
                }
            }
            else if (opcT == TipoTemperatura.Templado)
            {
                dato = ran.Next(78, 80);
                sector = ran.Next(1, 4);

                for (int i = 0; i < 500; i++)
                {
                    sw.WriteLine(dato + "%");
                    Sensor DatoSensor = new Sensor("Humedad Relativa", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if (envios == 100)
                    {
                        dato = ran.Next(78, 80);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }
                }
            }
            else
            {
                dato = ran.Next(75, 77);
                sector = ran.Next(1, 4);

                for (int i = 0; i < 500; i++)
                {
                    sw.WriteLine(dato + "%");
                    Sensor DatoSensor = new Sensor("Humedad Relativa", dato, sector);
                    Acceso.InsertarRegistro("Sensor", DatoSensor);
                    //var stopwatch = Stopwatch.StartNew();
                    //Thread.Sleep(mili); //tiempo de pausa
                    //stopwatch.Stop();

                    if (envios == 100)
                    {
                        dato = ran.Next(75, 77);
                        sector = ran.Next(1, 4);
                        envios = 0;
                    }
                }
            }

            sw.Close();
        }

        public static void GeneradorCalidadAire()
        {
            int envios = 0, dato, cambio, sector;
            string nombre = "Calidad Aire" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("Calidad Aire");

            dato = ran.Next(40, 80);
            sector = ran.Next(1, 4);

            for (int i = 0; i < 500; i++)
            {
                sw.WriteLine(dato);
                Sensor DatoSensor = new Sensor("Calidad Aire", dato, sector);
                Acceso.InsertarRegistro("Sensor", DatoSensor);
                //var stopwatch = Stopwatch.StartNew();
                //Thread.Sleep(mili); //tiempo de pausa
                //stopwatch.Stop();

                if (envios == 100)
                {
                    cambio = ran.Next(0, 2);
                    sector = ran.Next(1, 4);
                    if (cambio == 0) dato += 5;
                    else dato -= 5;
                    envios = 0;
                }
            }

            sw.Close();
        }

        public static void GeneradorIntensidadLuminica()
        {
            int envios = 0, dato, sector;
            string nombre = "Intensidad Luminica" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("Intensidad Luminica");

            dato = ran.Next(1, 40001);
            sector = ran.Next(1, 4);

            for (int i = 0; i < 500; i++)
            {
                sw.WriteLine(dato + " Lux");
                Sensor DatoSensor = new Sensor("Intensidad Luminica", dato, sector);
                Acceso.InsertarRegistro("Sensor", DatoSensor);
                //var stopwatch = Stopwatch.StartNew();
                //Thread.Sleep(mili); //tiempo de pausa
                //stopwatch.Stop();

                if (envios == 20)
                {
                    dato = ran.Next(1, 40001);
                    sector = ran.Next(1, 4);
                    envios = 0;
                }
            }

            sw.Close();
        }

        public static void GeneradorHumedadSuelo()
        {
            int envios = 0, dato, sector;
            string nombre = "Humedad Suelo" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("Humedad Suelo");

            dato = ran.Next(0, 1025);
            sector = ran.Next(1, 4);

            for (int i = 0; i < 500; i++)
            {
                sw.WriteLine(dato);
                Sensor DatoSensor = new Sensor("Humedad Suelo", dato, sector);
                Acceso.InsertarRegistro("Sensor", DatoSensor);
                var stopwatch = Stopwatch.StartNew();
                Thread.Sleep(mili); //tiempo de pausa
                stopwatch.Stop();

                if (envios == 100)
                {
                    dato = ran.Next(0, 1025);
                    sector = ran.Next(1, 4);
                    envios = 0;
                }
            }

            sw.Close();
        }

        public static void GeneradorPH()
        {
            int envios = 0, dato, sector;
            string nombre = "PH" + contador++.ToString();
            StreamWriter sw = new StreamWriter("G:\\" + nombre + ".txt");
            sw.WriteLine("PH");

            dato = ran.Next(0, 15);
            sector = ran.Next(1, 4);

            for (int i = 0; i < 500; i++)
            {
                sw.WriteLine(dato);
                Sensor DatoSensor = new Sensor("PH", dato, sector);
                Acceso.InsertarRegistro("Sensor", DatoSensor);
                //var stopwatch = Stopwatch.StartNew();
                //Thread.Sleep(mili); //tiempo de pausa
                //stopwatch.Stop();

                if (envios == 100)
                {
                    dato = ran.Next(0, 15);
                    sector = ran.Next(1, 4);
                    envios = 0;
                }
            }

            sw.Close();
        }
    }
}
