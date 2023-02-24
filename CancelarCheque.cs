using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlSistenCheck
{
    public partial class CancelarCheque : Form
    {
        public CancelarCheque()
        {
            InitializeComponent();
        }

        private void btnCancelCancelarCheque_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
