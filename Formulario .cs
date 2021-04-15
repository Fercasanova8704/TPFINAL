using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL_CASANOVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Formulario = new Pacientes();
            Formulario.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Formulario2 = new Turnos();
            Formulario2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Formulario3 = new Medicos();
            Formulario3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Formulario4 = new Recepcionistas();
            Formulario4.Show();

            

        }
    }
}
