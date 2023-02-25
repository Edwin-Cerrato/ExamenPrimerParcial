using System;
using System.Windows.Forms;

namespace PrimerExamenLp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista();
        }

        public void Lista()
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Nombre Apellido");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add("Nombre");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Apellido");
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
