using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaIntregable.Properties;
namespace PracticaIntregable
{
    public partial class Form1 : Form
    {
        private int contador;
            int contador = 120;

      

        public Form1()
        {
            InitializeComponent();

          

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if() pictureBox1.Image = Resources.jabalin;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.León_2;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (timpo > 0)
            {
                pictureBox3.Image = WindowsFormsSection.Equals  Resources.Jirafa_wiki;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.pantera_negra_20501128_20200918154602;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.pantera_negra_20501128_20200918154602;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jabalin;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.León_2;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Jirafa_wiki;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jabalin;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.León_2;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Jirafa_wiki;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.pantera_negra_20501128_20200918154602;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.pantera_negra_20501128_20200918154602;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.jabalin;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Jirafa_wiki;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.León_2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            contador = 120;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            contador = contador - 1;
            lbl_Contador.Text = contador.ToString();
        }
    }
}
