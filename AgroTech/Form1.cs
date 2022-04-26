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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AbrirForm(new Sensoriado());
        }

        private void buttonSensoriado_Click(object sender, EventArgs e)
        {
            AbrirForm(new Sensoriado());
        }

        private void buttonDron_Click(object sender, EventArgs e)
        {
            AbrirForm(new DronSense());
        }

        private void AbrirForm(object form)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);

            Form fnuevo = form as Form;

            fnuevo.TopLevel = false;
            fnuevo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fnuevo);
            this.panelContenedor.Tag = fnuevo;
            fnuevo.Show();
        }
    }
}
