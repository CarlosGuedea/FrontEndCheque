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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form crearCheque = new crearCheque();
            crearCheque.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form buscar = new buscar();
            buscar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buscar = new buscar();
            buscar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form buscar = new buscar();
            buscar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form consulta = new consulta();
            consulta.Show();
            this.Close();
        }
    }
}
