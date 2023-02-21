using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrontEndCheque
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
            try
            {
                SqlConnection conexion = new SqlConnection("User=usuario ; database=Cheques ; integrated security = true");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form moidificar = new crearCheque();
            moidificar.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form cancelar = new crearCheque();
            cancelar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
