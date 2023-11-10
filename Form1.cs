using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonConDisenio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                labelCheckBox.Text = "Checkbox o Casilla de verificación";
            }
            if (checkBoxConDisenio.Checked == true)
            {
                labelCheckBox.Text = "Checkbox con Diseño";
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxConDisenio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
