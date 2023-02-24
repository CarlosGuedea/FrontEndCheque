using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlSistenCheck
{
    public partial class EstadoDeCuenta : Form
    {
        public EstadoDeCuenta()
        {
            InitializeComponent();
        }

        private void btnCancelEstadoCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

                //Crear la consulta
                String Sql1 = "Select * from Movimientos";
                SqlCommand command1 = new SqlCommand(Sql1, conexion);
                command1.CommandType = System.Data.CommandType.Text;
                conexion.Open();
                SqlDataReader auxiliar;

                //Ejecutar la consulta
                auxiliar = command1.ExecuteReader();

                //Recuperar el valor de auxiliar
                while (auxiliar.Read())
                {
                    dataGridView1.Rows.Add(auxiliar["No_movimiento"].ToString(), auxiliar["Fecha"].ToString(), auxiliar["Monto"].ToString());
                }
                auxiliar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }
    }
}
