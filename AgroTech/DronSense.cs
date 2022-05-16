using AgroTech.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroTech
{
    public partial class DronSense : Form
    {
        List<Hallazgo> noticia = new List<Hallazgo>();
        public DronSense()
        {
            InitializeComponent();
            iniciarControles();

        }

        private void iniciarControles()
        {
            Hallazgo hz = new Hallazgo();
            Hallazgo hzprueba = new Hallazgo();

            var timer = new System.Timers.Timer(TimeSpan.FromMinutes(0.5).TotalMilliseconds); // se ejecutara cada 1 minutos
            timer.Elapsed += (sender, e) =>
            {
                hzprueba = hz.analisisImagen();
                if (hzprueba.Equals(null) == false)
                {
                    MessageBox.Show(hzprueba.Url + " -- " + hzprueba.Deterioro + " -- " + hzprueba.Sector);
                    noticia.Add(hzprueba);
                    listBoxHallazgo.DataSource = noticia;

                }
            };
            timer.Start();
        }

        private void listBoxHallazgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hallazgo hz = listBoxHallazgo.SelectedItem as Hallazgo;

            WebRequest request = WebRequest.Create(hz.Url);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBoxFresa.Image = Bitmap.FromStream(str);
                }
            }
            
            if (hz.Sector == 1) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector1.png"));
            else if (hz.Sector == 2) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector2.png"));
            else if (hz.Sector == 3) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector3.png"));
        }

    }
}
