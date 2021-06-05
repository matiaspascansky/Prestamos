using PrestamosEjercicio.CapaNegocio;
using PrestamosEjercicio.Entidades;
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


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTipoPrestamos.DataSource = negocioTipoPrestamo.getAllTipoPrestamo();
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tipo = (TipoPrestamo)lstTipoPrestamos.SelectedItem;

            txtTNA.Text = tipo.TNA.ToString();
            txtLinea.Text = tipo.Linea.ToString();

        }
    }
}
