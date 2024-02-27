using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;//quitar borde al formulario 
                formulario.Dock = DockStyle.Fill; // acoplar al panel  y que este en todo el fondo 
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmUsuarios"] == null)
                btnPedidos.BackColor = Color.FromArgb(0, 0, 0);
            btnPedidos.ForeColor = Color.FromArgb(255, 255, 255);
            if (Application.OpenForms["frmReparaciones"] == null)
                btnProductos.BackColor = Color.FromArgb(0, 0, 0);
            if (Application.OpenForms["frmAutos"] == null)
                btnCaja.BackColor = Color.FromArgb(0, 0, 0);
            if (Application.OpenForms["frmClientes"] == null)
                btnReportes.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPedidos>();
            btnPedidos.BackColor = Color.FromArgb(252, 163, 17);
            btnPedidos.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
