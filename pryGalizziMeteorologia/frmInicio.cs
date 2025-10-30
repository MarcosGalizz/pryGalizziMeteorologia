using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGalizziMeteorologia
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsConexion clsConexion = new clsConexion();
        private void krLsvTemperaturas_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexion.ConectarBD();
            clsConexion.cargarTreeView(krTvwUbicaciones);
        }

        private void krTvwUbicaciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            clsConexion.cargarListView(krLsvTemperaturas, krDtpFecha, krTvwUbicaciones.SelectedNode);
            clsConexion.actualizarStatusStrip(krSstSeleccion, krTvwUbicaciones.SelectedNode);
        }

        private void krDtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (krTvwUbicaciones.SelectedNode != null)
            {
                clsConexion.cargarListView(krLsvTemperaturas, krDtpFecha, krTvwUbicaciones.SelectedNode);
            }
        }
    }
}
