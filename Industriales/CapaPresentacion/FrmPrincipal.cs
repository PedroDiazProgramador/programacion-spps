using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVenta V = new FrmVenta();
            V.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCliente FClientes = new FrmCliente();
            FClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProducto FProductos = new FrmProducto();
            FProductos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrar programa");
        }
    }
}
