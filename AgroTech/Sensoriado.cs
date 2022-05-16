using AgroTech.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroTech
{
    public partial class Sensoriado : Form
    {
        Sugerencia sg = new Sugerencia();
        public Sensoriado()
        {
            InitializeComponent();
            InicializaControles();
            timer1.Start();
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
            int filaDato = int.Parse(dataGridViewInfo.CurrentCell.Value.ToString());
            

            if (filaDato == 1) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector1.png"));
            else if(filaDato == 2) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector2.png"));
            else if(filaDato == 3) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector3.png"));
        }

        private void listBoxSugerencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            Sugerencia sugge = (Sugerencia)listBoxSugerencia.SelectedItem;

            if(sugge != null)
            {
                textBoxSugerencia.Text = sugge.Advertencia;

                if (sugge.Sector == 1) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector1.png"));
                else if (sugge.Sector == 2) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector2.png"));
                else if (sugge.Sector == 3) pictureBoxSensorSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector3.png"));
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sg.sistemaExperto();
            listBoxSugerencia.DataSource = null;
            listBoxSugerencia.Items.Clear();
            listBoxSugerencia.DataSource = sg.Sugerencias;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            Sugerencia sugge = (Sugerencia)listBoxSugerencia.SelectedItem;

            sg.Sugerencias.Remove(sugge);

            listBoxSugerencia.DataSource = null;
            listBoxSugerencia.Items.Clear();
            listBoxSugerencia.DataSource = sg.Sugerencias;
        }
    }
}
