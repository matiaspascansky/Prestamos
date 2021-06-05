using PrestamosEjercicio.CapaNegocio;
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
    }
}
