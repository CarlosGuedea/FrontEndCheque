
using System.Data.SqlClient;

namespace controlSistenCheck
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form principal = new MenuPrincipal();
            principal.ShowDialog();
            this.Close();
            //Obtener los datos del front-end
            /* String Usuario = txtUsuario.Text;
             String Contraseña = txtContrasena.Text;

             try
             {
                 //Conección a la base de datos
                 SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                 //Crear la consulta
                 String Sql = "Select * from Usuario";
                 SqlCommand command = new SqlCommand(Sql, conexion);
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
                     if (Usuario == User && Clave == Contraseña)
                     {
                         // Si las credenciales son correctas, se abre una nueva ventana
                         Form principal = new MenuPrincipal();
                         principal.ShowDialog();
                         this.Close();
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
             }*/

        }
    }
}