using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlSistenCheck
{
    public partial class CambiarCheque : Form
    {
        public CambiarCheque()
        {
            InitializeComponent();
        }

        private void btnCancelCambiarCheque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtActFolio.Clear();
            txtActBanco.Clear();
            txtActDetalle.Clear();
            txtActDomicilio.Clear();
            txtActSuma.Clear();
            txtActTelefono.Clear();
            txtActNombre.Clear();
            txtActLugarPago.Clear();
            txtActLugarEmicion.Clear();
            txtActEstado.Clear();
        }
    }
}
