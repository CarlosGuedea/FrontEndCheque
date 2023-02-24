using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace controlSistenCheck
{
    public partial class AgregarCheque : Form
    {
        public AgregarCheque()
        {
            InitializeComponent();
            llenacombobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtBeneficiario.Clear();
            txtMonto.Clear();
            cbxDetalles.SelectedIndex = -1;
            cbxBanco.SelectedIndex = -1; // Establecer en valor null el ComboBox de Banco
            cbxPaisCobro.SelectedIndex = -1; // Establecer en valor null el ComboBox de País de Cobro
            cbxPaisEmicion.SelectedIndex = -1; // Establecer en valor null el ComboBox de País de Emisión
            txtFecha.Text = string.Empty;
        }

        private void AgregarCheque_Load(object sender, EventArgs e)
        {

        }

        private void btnAcepCheq_Click(object sender, EventArgs e)
        {
            String Monto = txtMonto.Text.ToString();
            String Banco = cbxBanco.Text;
            String Pais_Emision = cbxPaisEmicion.Text;
            String Fecha_Emision = txtFecha.Text.ToString();
            String Pais_Cobro = cbxPaisCobro.Text;
            String Beneficiario = txtBeneficiario.Text.ToString();
            String Domicilio = txtDomicilio.Text.ToString();
            String Telefono = txtTelefono.Text.ToString();
            String Detalle = cbxDetalles.Text;

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

                //Crear la consulta
                String Sql1 = "Select No_Detalle from Detalle_Cheque where Detalle = " + "'" + Detalle + "'";
                SqlCommand command1 = new SqlCommand(Sql1, conexion);
                command1.CommandType = System.Data.CommandType.Text;
                conexion.Open();
                SqlDataReader auxiliar;

                //Ejecutar la consulta
                auxiliar = command1.ExecuteReader();

                //Recuperar el valor de auxiliar
                while (auxiliar.Read())
                {
                    Detalle = auxiliar["No_Detalle"].ToString();
                }
                auxiliar.Close();

                //Hacemos el llenado de la tabla
                String Sql = "Exec sp_ChequeyBeneficiario " + Monto+ ", "+ "[" + Banco + "]" + ", " + "[" + Pais_Emision + "]" + ", " +"'"+Fecha_Emision + "'" + ", " +"["+Pais_Cobro + "]" + ", " +"["+Beneficiario + "]" + ", " +"[" +Domicilio + "]" + ", "+Telefono+","+ Detalle;
                MessageBox.Show(Sql);
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;

                //Hacer el llenado en la base de datos
                command.ExecuteNonQuery();

                btnClear_Click(sender, new EventArgs());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void cbxDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        public void llenacombobox()
        {
            //Conección a la base de datos
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Detalle from Detalle_Cheque", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "Detalle_Cheque");

            //Llenar el combobox
            cbxDetalles.DataSource = ds.Tables[0].DefaultView;
            cbxDetalles.ValueMember = "Detalle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Detalle = textBox1.Text.ToString();
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Insert into Detalle_Cheque values ('" + ' ' + Detalle + "')"; ;
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                //Insertar en la base de datos
                command.ExecuteNonQuery();

                //Borrar los datos pasados del DataGridView
                textBox1.Clear();

                //Recargar el combobox
                llenacombobox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }
    }
}
