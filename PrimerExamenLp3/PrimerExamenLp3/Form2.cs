using System;
using System.Windows.Forms;

namespace PrimerExamenLp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //definicion e inicializacion de Capital
            float capital = 200000;
            float interesMensual = 0;


            for (int i = 1; i < 13; i++)
            {
                interesMensual = (float)(capital * 0.015 * i);

                capital += interesMensual;

                //listBox.Items.Add("MES " + i + "   " + capital);

                listBox.Items.Add("MES " + i + "INTERES OBTENIDO " + interesMensual + "TOTAL ACUMULADO" + capital);

            }



        }
    }
}
