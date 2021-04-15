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
    public partial class Recepcionistas : Form
    {
        public Recepcionistas()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "" || textBox1.Text == " ")
                 MessageBox.Show("Debe completar el campo");
            if (textBox2.Text == "" || textBox2.Text == " ")
                MessageBox.Show("Debe completar el campo");
            if (textBox3.Text == "" || textBox3.Text == " ")
                MessageBox.Show("Debe completar el campo");
            if (textBox4.Text == "" || textBox4.Text == " ")
                MessageBox.Show("Debe completar el campo");
            if (textBox5.Text == "" || textBox5.Text == " ")
                MessageBox.Show("Debe completar el campo");

            else
            {
                MessageBox.Show("La alta a sido dada exitosamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "  ";
            textBox2.Text = "  ";
            textBox3.Text = "  ";
            textBox4.Text = "  ";
            textBox5.Text = "  ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Recepcionistas_Load(object sender, EventArgs e)
        {

        }
    }
}
