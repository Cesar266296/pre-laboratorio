using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Lboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nombre, contraseña;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cambio1 = new Form2();
            if (textBox1.Text == nombre & textBox2.Text == contraseña)
            { 
                this.Hide();
                cambio1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            contraseña = textBox2.Text;
            button1.Enabled = false;
        }
    }
}
