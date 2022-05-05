using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroTech
{
    public partial class Sensoriado : Form
    {
        public Sensoriado()
        {
            InitializeComponent();
            InicializaControles();
        }

        private void Sensoriado_Load(object sender, EventArgs e)
        {

        }

        private void InicializaControles()
        {
            List<string> lista = new List<string>() { " ", "Temperatura", "Calidad Aire", "Intensidad Luminica", "Humedad Suelo", "PH" };
            comboBoxTipoSensor.DataSource = lista;
        }

        private void comboBoxTipoSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow fila;
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Dato"));
            dt.Columns.Add(new DataColumn("Sector"));
            List<Sensor> listaSensor = Clase.Acceso.InfoSensor(comboBoxTipoSensor.Text, "Sensor");

            foreach (Sensor sensor in listaSensor)
            {
                fila = dt.NewRow();

                fila["Dato"] = sensor.Dato.ToString();
                fila["Sector"] = sensor.Sector.ToString();

                dt.Rows.Add(fila);
            }

            dataGridViewInfo.DataSource = dt;
        }

        private void dataGridViewInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var fila = dataGridViewInfo.SelectedRows[0];

            //if((DataRow)fila["Sector"] == 1)

            //if(dataGridViewInfo.SelectedRows[0].Equals("1"))pictureBoxSensorSector.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\IoT-e-Inteligencia-Artificial-en-la-Agricultura\\AgroTech\\Img\\FrameSector1.png");
            //else if(dataGridViewInfo.SelectedRows[1].Equals("2")) pictureBoxSensorSector.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\IoT-e-Inteligencia-Artificial-en-la-Agricultura\\AgroTech\\Img\\FrameSector2.png");
            //else if(dataGridViewInfo.SelectedRows[1].Equals("3")) pictureBoxSensorSector.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\IoT-e-Inteligencia-Artificial-en-la-Agricultura\\AgroTech\\Img\\FrameSector3.png");
        }
    }
}
