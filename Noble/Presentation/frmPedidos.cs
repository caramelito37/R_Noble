using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;


namespace Presentation
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            MostrarDatosProducto();
        }
        private void MostrarDatosProducto()
        {
            DProduct daoProduct = new DProduct();
            DataTable productosData = daoProduct.MostrarDatosProducto();

            // Asignar los datos al DataGridView
            dgvProductos.DataSource = productosData;
            Estilos.Dgv.AplicarEstilosBtnAgregar(dgvProductos);


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
