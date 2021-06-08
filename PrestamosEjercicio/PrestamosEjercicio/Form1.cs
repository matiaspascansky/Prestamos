using PrestamosEjercicio.CapaNegocio;
using PrestamosEjercicio.Entidades;
using PrestamosEjercicio.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PrestamosEjercicio
{
    public partial class Form1 : Form
    {
        private NegocioPrestamo negocio = new NegocioPrestamo();
        private NegocioTipoPrestamo negocioTipoPrestamo = new NegocioTipoPrestamo();
        private TipoPrestamo tipo;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPrestamos.DataSource = negocio.getAllPrestamo();
            lstTipoPrestamos.DataSource = negocioTipoPrestamo.getAllTipoPrestamo();
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = (TipoPrestamo)lstTipoPrestamos.SelectedItem;

            txtTNA.Text = tipo.TNA.ToString();
            txtLinea.Text = tipo.Linea.ToString();

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(!validarForm())
            {
                MessageBox.Show("Faltan completar datos");

            } else
            {

                string linea = txtLinea.Text;
                double tna = double.Parse(txtTNA.Text);
                double monto = double.Parse(txtMonto.Text);
                int plazo = int.Parse(txtPlazo.Text);
                string usuario = "matias";
                Prestamo p = new Prestamo(linea, tna, plazo, monto, usuario, tipo);

                txtCuotaCapital.Text = p.CuotaCapital().ToString();
                txtCuotaInteres.Text = p.CuotaInteres().ToString();
                txtCuotaTotal.Text = p.Cuota().ToString();



            }

        }

        private bool validarForm()
        {
            bool valido = false;
            if(txtLinea.Text == "" || txtMonto.Text == "" || txtPlazo.Text == "" || txtTNA.Text == "")
            {
                valido = false;
            } else
            {
                valido = true;
            }

            return valido;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtComision.Text = "";
            txtCuotaCapital.Text = "";
            txtCuotaInteres.Text = "";
            txtLinea.Text = "";
            txtMonto.Text = "";
            txtPlazo.Text = "";
            txtTNA.Text = "";
            txtCuotaTotal.Text = "";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string linea = txtLinea.Text;
                double tna = double.Parse(txtTNA.Text);
                double monto = double.Parse(txtMonto.Text);
                int plazo = int.Parse(txtPlazo.Text);
                string usuario = "matias";
               
                Prestamo p = new Prestamo(linea, tna, plazo, monto, usuario, tipo);

                TransactionResult tr = negocio.insertar(tna, linea, plazo, monto, usuario, tipo);
            } catch (PrestamoExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);

            }

        }

        private void lstPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
