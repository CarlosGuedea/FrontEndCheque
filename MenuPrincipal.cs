using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlSistenCheck
{
    public partial class MenuPrincipal : Form
    {
        private List<Form> hijosAbiertos = new List<Form>();
        private int closs = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void agregarChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buscar si hay un formulario hijo abierto del tipo AgregarCheque
            AgregarCheque agregarCheque = hijosAbiertos.OfType<AgregarCheque>().FirstOrDefault();

            if (agregarCheque == null)
            {
                // Si no está abierto, crear una nueva instancia
                agregarCheque = new AgregarCheque();
                agregarCheque.MdiParent = this;
                agregarCheque.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                agregarCheque.FormClosed += (s, args) => hijosAbiertos.Remove(agregarCheque);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(agregarCheque);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            agregarCheque.Focus();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                DialogResult result2 = MessageBox.Show("¿Los datos no guardados se perderan quieres continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result2 == DialogResult.OK)
                {
                    closs = 1;
                    Application.Exit();
                }
            }
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form estadoDeCuenta = hijosAbiertos.FirstOrDefault(f => f.GetType() == typeof(EstadoDeCuenta));

            if (estadoDeCuenta == null)
            {
                // Si no está abierto, crear una nueva instancia
                estadoDeCuenta = new EstadoDeCuenta();
                estadoDeCuenta.MdiParent = this;
                estadoDeCuenta.Dock = DockStyle.Fill;
                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(estadoDeCuenta);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }
            // Enfocar el formulario hijo
            estadoDeCuenta.Focus();
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.colima.tecnm.mx/";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sistemaspaez.com/control-cheques/";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCheque buscarCheque = hijosAbiertos.OfType<BuscarCheque>().FirstOrDefault();

            if (buscarCheque == null)
            {
                // Si no está abierto, crear una nueva instancia
                buscarCheque = new BuscarCheque();
                buscarCheque.MdiParent = this;
                buscarCheque.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                buscarCheque.FormClosed += (s, args) => hijosAbiertos.Remove(buscarCheque);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(buscarCheque);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            buscarCheque.Focus();
        }

        private void cambiarChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarCheque cambiarCheque = hijosAbiertos.OfType<CambiarCheque>().FirstOrDefault();

            if (cambiarCheque == null)
            {
                // Si no está abierto, crear una nueva instancia
                cambiarCheque = new CambiarCheque();
                cambiarCheque.MdiParent = this;
                cambiarCheque.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                cambiarCheque.FormClosed += (s, args) => hijosAbiertos.Remove(cambiarCheque);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(cambiarCheque);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            cambiarCheque.Focus();
        }

        private void cancelarChequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarCheque cancelarCheque = hijosAbiertos.OfType<CancelarCheque>().FirstOrDefault();

            if (cancelarCheque == null)
            {
                // Si no está abierto, crear una nueva instancia
                cancelarCheque = new CancelarCheque();
                cancelarCheque.MdiParent = this;
                cancelarCheque.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                cancelarCheque.FormClosed += (s, args) => hijosAbiertos.Remove(cancelarCheque);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(cancelarCheque);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            cancelarCheque.Focus();
        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCuenta agregarCuenta = hijosAbiertos.OfType<AgregarCuenta>().FirstOrDefault();

            if (agregarCuenta == null)
            {
                // Si no está abierto, crear una nueva instancia
                agregarCuenta = new AgregarCuenta();
                agregarCuenta.MdiParent = this;
                agregarCuenta.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                agregarCuenta.FormClosed += (s, args) => hijosAbiertos.Remove(agregarCuenta);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(agregarCuenta);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            agregarCuenta.Focus();
        }

        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depositos depositos = hijosAbiertos.OfType<Depositos>().FirstOrDefault();

            if (depositos == null)
            {
                // Si no está abierto, crear una nueva instancia
                depositos = new Depositos();
                depositos.MdiParent = this;
                depositos.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                depositos.FormClosed += (s, args) => hijosAbiertos.Remove(depositos);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(depositos);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            depositos.Focus();
        }

        private void beneficiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beneficiarios beneficiarios = hijosAbiertos.OfType<Beneficiarios>().FirstOrDefault();

            if (beneficiarios == null)
            {
                // Si no está abierto, crear una nueva instancia
                beneficiarios = new Beneficiarios();
                beneficiarios.MdiParent = this;
                beneficiarios.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                beneficiarios.FormClosed += (s, args) => hijosAbiertos.Remove(beneficiarios);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(beneficiarios);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            beneficiarios.Focus();
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheques cheque = hijosAbiertos.OfType<Cheques>().FirstOrDefault();

            if (cheque == null)
            {
                // Si no está abierto, crear una nueva instancia
                cheque = new Cheques();
                cheque.MdiParent = this;
                cheque.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                cheque.FormClosed += (s, args) => hijosAbiertos.Remove(cheque);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(cheque);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            cheque.Focus();
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closs==0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar esta ventana? \n PUEDE PERDERSE DATOS FINANCIEROS DE SU CUENTA ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancelar el evento de cierre del formulario
                }
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General general = hijosAbiertos.OfType<General>().FirstOrDefault();

            if (general == null)
            {
                // Si no está abierto, crear una nueva instancia
                general = new General();
                general.MdiParent = this;
                general.Dock = DockStyle.Fill;

                // Suscribirse al evento FormClosed para eliminar el formulario hijo de la lista cuando se cierre
                general.FormClosed += (s, args) => hijosAbiertos.Remove(general);

                // Agregar el formulario hijo a la lista de instancias abiertas
                hijosAbiertos.Add(general);
            }
            else
            {
                MessageBox.Show("Termine proceso actual para poder iniciar nueva tarea");
            }

            // Enfocar el formulario hijo
            general.Focus();
        }
    }
}
