using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizador_projetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.text = string.Empty;
            if (comboBox1.Text == "AUDI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("R8");
                comboBox2.Items.Add("AUDI TT RS");
            }
            else if (comboBox1.Text == " BMW") ;
            {
                comboBox2.Text = string.Empty;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("I8");
                comboBox2.Items.Add("320I M Sport");
            }
             else if (comboBox1.Text == "Nissan") ;
            {
                comboBox2.Text = string.Empty;

                comboBox2.Items.Clear();
                comboBox2.Items.Add("GTR R35");
                comboBox2.Items.Add("350z");
            }
        }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
