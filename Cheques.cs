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
    public partial class Cheques : Form
    {
        public Cheques()
        {
            InitializeComponent();
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
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
                String Sql1 = "Select * from Cheque";
                SqlCommand command1 = new SqlCommand(Sql1, conexion);
                command1.CommandType = System.Data.CommandType.Text;
                conexion.Open();
                SqlDataReader auxiliar;

                //Ejecutar la consulta
                auxiliar = command1.ExecuteReader();

                //Recuperar el valor de auxiliar
                while (auxiliar.Read())
                {
                    dataGridView1.Rows.Add(auxiliar["Folio"].ToString(), auxiliar["Suma"].ToString(), auxiliar["Banco"].ToString(), auxiliar["Lugar_Pago"].ToString(), auxiliar["Fecha_Emision"].ToString(), auxiliar["Lugar_Emision"].ToString(), auxiliar["Estado"].ToString(), auxiliar["Detalle"].ToString());
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
