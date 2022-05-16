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
        Hallazgo hz = new Hallazgo();
        public DronSense()
        {
            InitializeComponent();
            hz.solicitudRepetida();
            timer2.Start();

        }

        private void listBoxHallazgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hallazgo seleccion = (Hallazgo)listBoxHallazgo.SelectedItem;

            if(seleccion != null)
            {
                WebRequest request = WebRequest.Create(seleccion.Url);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBoxFresa.Image = Bitmap.FromStream(str);
                    }
                }

                if (seleccion.Sector == 1) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector1.png"));
                else if (seleccion.Sector == 2) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector2.png"));
                else if (seleccion.Sector == 3) pictureBoxDronSector.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Img\\FrameSector3.png"));
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            listBoxHallazgo.DataSource = null;
            listBoxHallazgo.Items.Clear();
            listBoxHallazgo.DataSource = hz.Noticia;
        }
    }
}
