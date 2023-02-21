
using System.Data.SqlClient;
using System.Transactions;

namespace FrontEndCheque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener los datos del front-end
            String Usuario = txtUsuario.Text;
            String Contraseña = txtConstraseña.Text;

            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=1234;Trusted_Connection=True;");
                
                
                //Crear la consulta
                String Sql = "Select * from Usuario";
                SqlCommand command = new SqlCommand(Sql,conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    String User = reader.GetString(reader.GetOrdinal("Nombre"));
                    String Clave = reader.GetString(reader.GetOrdinal("Contrasena"));

                    // Aquí se realizaría la validación de las credenciales de usuario
                    if (Usuario==User && Clave == Contraseña)
                    {
                        // Si las credenciales son correctas, se abre una nueva ventana
                        Form Form2 = new Form2();
                        Form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si las credenciales son incorrectas, se muestra un mensaje de error
                        MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
                    }
                }

                //Hacemos la verificación de las credenciales
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }

            
        }
    }
}