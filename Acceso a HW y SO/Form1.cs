using System;
using System.Windows.Forms;
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
            if (MessageBox.Show("¿Estás seguro de que deseas matar todos los procesos?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCuadricula.Rows)
                {
                    try
                    {
                        if (row.Cells["ProcessID"].Value != null)
                        {
                            int nIdProceso = Convert.ToInt32(row.Cells["ProcessID"].Value);
                            Process proceso = Process.GetProcessById(nIdProceso);

                            if (proceso != null && !proceso.HasExited)
                            {
                                proceso.Kill();
                            }
                        }
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show($"Error: El proceso con ID {row.Cells["ProcessID"].Value} no existe.");
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show($"Error: El proceso con ID {row.Cells["ProcessID"].Value} ya ha sido cerrado.");
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
                        MessageBox.Show($"Error: No tienes permiso para matar el proceso con ID {row.Cells["ProcessID"].Value}.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al matar el proceso con ID {row.Cells["ProcessID"].Value}: {ex.Message}");
                    }
                } 
                jonnig.Class1.MostrarProcesosActivos(dgvCuadricula);
            }
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
  
 