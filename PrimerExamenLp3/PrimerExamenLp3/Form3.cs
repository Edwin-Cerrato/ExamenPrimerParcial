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


        private async void btnCalcular_Click(object sender, EventArgs e)
        {

            //Uso de ErrorProvider
            if (string.IsNullOrEmpty(txtProducto1.Text))
            {
                errorProvider1.SetError(txtProducto1, "INGRESE EL NOMBRE DEL PRODUCTO");
                txtProducto1.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtCantidad1.Text))
            {
                errorProvider1.SetError(txtCantidad1, "INGRESE LA CANTIDAD DEL PRODUCTO");
                txtCantidad1.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtPrecioProducto1.Text))
            {
                errorProvider1.SetError(txtPrecioProducto1, "INGRESE LA CANTIDAD DEL PRODUCTO");
                txtPrecioProducto1.Focus();
                return;
            }
            errorProvider1.Clear();

            //Producto 2
            if (string.IsNullOrEmpty(txtProducto2.Text))
            {
                errorProvider1.SetError(txtProducto2, "INGRESE EL NOMBRE DEL PRODUCTO");
                txtProducto2.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtCantidad2.Text))
            {
                errorProvider1.SetError(txtCantidad2, "INGRESE LA CANTIDAD DEL PRODUCTO");
                txtCantidad2.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtPrecioProducto2.Text))
            {
                errorProvider1.SetError(txtPrecioProducto2, "INGRESE LA CANTIDAD DEL PRODUCTO");
                txtPrecioProducto2.Focus();
                return;
            }
            errorProvider1.Clear();

            decimal precio1 = Convert.ToDecimal(txtPrecioProducto1.Text);
            decimal precio2 = Convert.ToDecimal(txtPrecioProducto2.Text);

            int cantidad1 = Convert.ToInt32(txtCantidad1.Text);
            int cantidad2 = Convert.ToInt32(txtCantidad2.Text);


            //Llamado de funcion
            await TotalAPagarAsync(precio1, precio2, cantidad1, cantidad2);





        }

        //FUNCIÓN ASINCRONA
        private async Task<decimal> TotalAPagarAsync(decimal pre1, decimal pre2, int cant1, int cant2)
        {
            //Definción de Variables
            float total = 0;
            float totalDescuento = 0;
            float tot1 = 0;
            decimal TotalPagar = (decimal)await Task.Run(() =>
            {
                //Calculo
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

        private void Limpiar()
        {
            txtProducto1.Clear();
            txtProducto2.Clear();
            txtCantidad1.Clear();
            txtCantidad2.Clear();
            txtPrecioProducto1.Clear();
            txtPrecioProducto2.Clear();

            txtNeto.Clear();
            txtDescuento.Clear();
            txtTotalPagar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
