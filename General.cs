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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear1_Click(object sender, EventArgs e)
        {
            String Nombre = textBox1.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_BuscarChequesDeUnBeneficiarioPorNombre" + ' ' + Nombre;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio_cheque"].ToString(), reader["Folio_beneficiario"].ToString(), reader["Suma"].ToString(), reader["Banco"].ToString(), reader["Lugar_Pago"].ToString(), reader["Fecha_Emision"].ToString(), reader["Lugar_Emision"].ToString(), reader["Estado"].ToString(), reader["Nombre"].ToString(), reader["Telefono"].ToString(), reader["Domicilio"].ToString(), reader["No_Detalle"].ToString(), reader["Detalle"].ToString());

                }

                //Hacemos la verificación de las credenciales

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            String Detalle = textBox2.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_BuscarChequesDeUnBeneficiarioPorDetalle" + ' ' + Detalle;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio_cheque"].ToString(), reader["Folio_beneficiario"].ToString(), reader["Suma"].ToString(), reader["Banco"].ToString(), reader["Lugar_Pago"].ToString(), reader["Fecha_Emision"].ToString(), reader["Lugar_Emision"].ToString(), reader["Estado"].ToString(), reader["Nombre"].ToString(), reader["Telefono"].ToString(), reader["Domicilio"].ToString(), reader["No_Detalle"].ToString(), reader["Detalle"].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear3_Click(object sender, EventArgs e)
        {
            String Folio1 = textBox3.Text.ToString();
            String Folio2 = textBox6.Text.ToString();

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_ReporteFolio" + " " + Folio1 + ", " + Folio2;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio_cheque"].ToString(), reader["Folio_beneficiario"].ToString(), reader["Suma"].ToString(), reader["Banco"].ToString(), reader["Lugar_Pago"].ToString(), reader["Fecha_Emision"].ToString(), reader["Lugar_Emision"].ToString(), reader["Estado"].ToString(), reader["Nombre"].ToString(), reader["Telefono"].ToString(), reader["Domicilio"].ToString(), reader["No_Detalle"].ToString(), reader["Detalle"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void btnCrear4_Click(object sender, EventArgs e)
        {
            String Monto1 = textBox4.Text.ToString();
            String Monto2 = textBox7.Text.ToString();

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_ReporteMonto" + " " + Monto1 + ", " + Monto2;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio_cheque"].ToString(), reader["Folio_beneficiario"].ToString(), reader["Suma"].ToString(), reader["Banco"].ToString(), reader["Lugar_Pago"].ToString(), reader["Fecha_Emision"].ToString(), reader["Lugar_Emision"].ToString(), reader["Estado"].ToString(), reader["Nombre"].ToString(), reader["Telefono"].ToString(), reader["Domicilio"].ToString(), reader["No_Detalle"].ToString(), reader["Detalle"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void btnCrear5_Click(object sender, EventArgs e)
        {
            String Fecha1 = textBox5.Text.ToString();
            String Fecha2 = textBox8.Text.ToString();

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_ReporteFecha" + " '" + Fecha1 + "', '" + Fecha2 + "'";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio_cheque"].ToString(), reader["Folio_beneficiario"].ToString(), reader["Suma"].ToString(), reader["Banco"].ToString(), reader["Lugar_Pago"].ToString(), reader["Fecha_Emision"].ToString(), reader["Lugar_Emision"].ToString(), reader["Estado"].ToString(), reader["Nombre"].ToString(), reader["Telefono"].ToString(), reader["Domicilio"].ToString(), reader["No_Detalle"].ToString(), reader["Detalle"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }
    }
}
