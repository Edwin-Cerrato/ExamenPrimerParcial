using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerExamenLp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precio1 = Convert.ToInt32(txtPrecioProducto1.Text);
            decimal precio2 = Convert.ToInt32(txtPrecioProducto2.Text);

            int cantidad1 = Convert.ToInt32(txtCantidad1.Text);
            int cantidad2 = Convert.ToInt32(txtCantidad2.Text);


            //Llamado de funcion
            await TotalAPagarAsync(precio1, precio2, cantidad1, cantidad2);





        }

        //FUNCIÓN ASINCRONA
        private async Task<decimal> TotalAPagarAsync(decimal pre1, decimal pre2, int cant1, int cant2)
        {
            float total = 0;
            float totalDescuento = 0;
            float tot1 = 0;
            decimal TotalPagar = (decimal)await Task.Run(() =>
            {

                total = (float)((pre1 * cant1) + (pre2 * cant2));
                totalDescuento = (float)(total * 0.15);
                tot1 = total - totalDescuento;

                return tot1;
            });
            //salida de resltados
            txtNeto.Text = Convert.ToString(total);
            txtDescuento.Text = Convert.ToString(totalDescuento);
            txtTotalPagar.Text = Convert.ToString(tot1);
            //MessageBox.Show("Su descuento es de  " + totalDescuento + "   Su total a pagar es " + tot1);
            return TotalPagar;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
