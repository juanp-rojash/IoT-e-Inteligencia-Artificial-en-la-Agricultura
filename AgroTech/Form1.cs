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

        Form f1 = new Sensoriado();
        Form f2 = new DronSense();

        public Form1()
        {
            InitializeComponent();
            AbrirForm(f1);
        }

        private void buttonSensoriado_Click(object sender, EventArgs e)
        {
            AbrirForm(f1);
        }

        private void buttonDron_Click(object sender, EventArgs e)
        {
            AbrirForm(f2);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
