using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlSistenCheck
{
    public partial class Depositos : Form
    {
        public Depositos()
        {
            InitializeComponent();
            MostrarCuenta();
            MostrarCapital();
        }

        private void btnCancelDeposito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Fecha = textBox2.Text.ToString();
            String Monto = textBox1.Text.ToString();
            String Cuenta = label4.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

                String Sql = "Exec sp_RegistraMonto "+" '"+ Fecha + "', " + Monto + ", " + " '"+Cuenta+"'";
                MessageBox.Show("Se registrará el deposito");
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                //Hacer el llenado en la base de datos
                command.ExecuteNonQuery();

                //Limpiar los campos
                textBox1.Clear();
                textBox2.Clear();
                
                //Mostrar capital
                MostrarCapital();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MostrarCuenta()
        {
            //Conección a la base de datos
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

            
            String Sql1 = "select No_Cuenta from Cuenta";
            SqlCommand command1 = new SqlCommand(Sql1, conexion);
            command1.CommandType = System.Data.CommandType.Text;
            conexion.Open();
            SqlDataReader auxiliar;

            //Ejecutar la consulta
            auxiliar = command1.ExecuteReader();

            //Recuperar el valor de auxiliar
            while (auxiliar.Read())
            {
                label4.Text = auxiliar["No_Cuenta"].ToString();
            }
            auxiliar.Close();
        }

        private void MostrarCapital()
        {
            //Conección a la base de datos
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


            String Sql1 = "select Capital from Cuenta";
            SqlCommand command1 = new SqlCommand(Sql1, conexion);
            command1.CommandType = System.Data.CommandType.Text;
            conexion.Open();
            SqlDataReader auxiliar;

            //Ejecutar la consulta
            auxiliar = command1.ExecuteReader();

            //Recuperar el valor de auxiliar
            while (auxiliar.Read())
            {
                label6.Text = auxiliar["Capital"].ToString();
            }
            auxiliar.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }

}

