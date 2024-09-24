using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using jonnig;
using System.Diagnostics;

/*Jonnier Grajales Alzate
 * 24/09/2024
 Acceso a HW Y SO*/

namespace Acceso_a_HW_y_SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            string lcSeri = jonnig.Class1.ObtenerSeriales();
            MessageBox.Show(lcSeri);
        }

        private void btnCantidadUnidades_Click(object sender, EventArgs e)
        {
            string lcUnidades = jonnig.Class1.ContarUnidades();
            MessageBox.Show(lcUnidades);
        }

        private void btnInventarioGeneral_Click(object sender, EventArgs e)
        {
            string lcInventario = jonnig.Class1.InventarioSistema();
            MessageBox.Show(lcInventario);
        }

        private void btnObtenerMac_Click(object sender, EventArgs e)
        {
            string lcMac = jonnig.Class1.DireccionMac();
            MessageBox.Show(lcMac);
        }

        private void btnProcesosActivos_Click(object sender, EventArgs e)
        {
            string lcProcesos = jonnig.Class1.MostrarProcesosActivos(dgvCuadricula);
            MessageBox.Show(lcProcesos);
        }

        private void btnMatarProcesos_Click(object sender, EventArgs e)
        {
            string lcMatarProceso = jonnig.Class1.MatarProceso();
            MessageBox.Show(lcMatarProceso);
        } 
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Error al abrir el Editor del Registro: {ex.Message}");
            }
        }
    }
 
}
  
 