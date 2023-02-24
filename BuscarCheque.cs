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
    public partial class BuscarCheque : Form
    {
        public BuscarCheque()
        {
            InitializeComponent();
        }

        private void btnCancelBuscarCheque_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BuscarCheque_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            int indiceFilaDeseada = e.RowIndex; // Cambiar por el índice de la fila deseada
            DataGridViewRow filaDeseada = dataGridView1.Rows[indiceFilaDeseada];

            string Folio_cheque = filaDeseada.Cells[0].Value.ToString();
            string Folio_beneficiario = filaDeseada.Cells[1].Value.ToString();
            string Suma = filaDeseada.Cells[2].Value.ToString();
            string Banco = filaDeseada.Cells[3].Value.ToString();
            string Lugar_Pago = filaDeseada.Cells[4].Value.ToString();
            string Fecha_Emision = filaDeseada.Cells[5].Value.ToString();
            string Lugar_Emicion = filaDeseada.Cells[6].Value.ToString();
            string Estado = filaDeseada.Cells[7].Value.ToString();
            if(Estado == "False")
            {
                Estado = "0";
            }else if(Estado == "True")
            {
                Estado = "1";
            }
            string Nombre = filaDeseada.Cells[8].Value.ToString();
            string Telefono = filaDeseada.Cells[9].Value.ToString();
            string Domicilio = filaDeseada.Cells[10].Value.ToString();
            string No_Detalle = filaDeseada.Cells[11].Value.ToString();
            string Detalle = filaDeseada.Cells[12].Value.ToString();

            if (e.ColumnIndex == 13)
            {
                try
                {
                    //Conección a la base de datos
                    SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

                    //Hacemos el llenado de la tabla
                    String Sql = "Exec sp_updateChequeyBeneficiario " + Folio_cheque + ", " + Suma + ", " + "[" + Banco + "]" + ", " + "[" + Lugar_Pago + "]" + ", " + "[" + Lugar_Emicion + "]" + ", " + "[" + Nombre + "]" + ", " + "[" + Domicilio + "]" + ", '" + Telefono + "'," + Estado + ", " + No_Detalle;
                    MessageBox.Show("Se actualizarán los datos en la base");
                    SqlCommand command = new SqlCommand(Sql, conexion);
                    command.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    //Hacer el llenado en la base de datos
                    command.ExecuteNonQuery();

                    //Limpiar los campos
                    dataGridView1.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
                }
            }else if (e.ColumnIndex == 14)
            {
                try
                {
                    //Conección a la base de datos
                    SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

                    //Hacemos el borrado de la tabla
                    String Sql = "Exec sp_BorrarRegistro " + Folio_cheque;
                    MessageBox.Show("Se borrarán los datos en la base");
                    SqlCommand command = new SqlCommand(Sql, conexion);
                    command.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    //Hacer el llenado en la base de datos
                    command.ExecuteNonQuery();

                    //Limpiar los campos
                    dataGridView1.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
                }
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            String Nombre = txtBuscarNombre.Text.ToString();
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

        private void btnBuscarDetalle_Click_1(object sender, EventArgs e)
        {
            String Detalle = txtBuscarDetalle.Text.ToString();
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

        private void btnBuscarFolio_Click_1(object sender, EventArgs e)
        {
            String Folio = txtBuscarFolio.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_BuscarChequesDeUnBeneficiarioPorFolio" + ' ' + Folio;
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

        private void btnBuscarMonto_Click_1(object sender, EventArgs e)
        {
            String Monto = txtBuscarMonto.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_BuscarChequesDeUnBeneficiarioPorMonto" + ' ' + Monto;
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

        private void btnBuscarFecha_Click_1(object sender, EventArgs e)
        {
            String Fecha = txtBuscarFecha.Text.ToString();

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Exec sp_BuscarChequesDeUnBeneficiarioPorFecha" + " '" + Fecha + "'"; //Poner entre comillas
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Borrar los datos pasados del DataGridView
                dataGridView1.Rows.Clear();

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
