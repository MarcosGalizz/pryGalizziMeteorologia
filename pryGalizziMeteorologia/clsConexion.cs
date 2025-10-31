using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGalizziMeteorologia
{
    internal class clsConexion
    {
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BaseDeDatos/Meteorologia.accdb";

        OleDbConnection coneccionBaseDatos;

        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = Path.GetFileName(coneccionBaseDatos.DataSource);

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }

        public void cargarTreeView(KryptonTreeView tvLocalidades)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandText = "SELECT IdProvincia, Nombre FROM Provincias";
            Dictionary<int, TreeNode> nodosProvincia = new Dictionary<int, TreeNode>();
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            while (lectorDataReader.Read())
            {
                int idProv = Convert.ToInt32(lectorDataReader["IdProvincia"]);
                string nombreProv = lectorDataReader["Nombre"].ToString();

                TreeNode nodoProv = new TreeNode(nombreProv);
                nodoProv.Tag = idProv;
                tvLocalidades.Nodes.Add(nodoProv);

                nodosProvincia.Add(idProv, nodoProv);
            }
            lectorDataReader.Close();
            comandoBaseDatos.CommandText = "SELECT IdLocalidad, Nombre, IdProvincia FROM Localidades";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            while (lectorDataReader.Read())
            {
                int idProv = Convert.ToInt32(lectorDataReader["IdProvincia"]);
                int idLoc = Convert.ToInt32(lectorDataReader["IdLocalidad"]);
                string nombreLoc = lectorDataReader["Nombre"].ToString();

                if (nodosProvincia.ContainsKey(idProv))
                {
                    TreeNode nodoLoc = new TreeNode(nombreLoc);
                    nodoLoc.Tag = idLoc;
                    nodosProvincia[idProv].Nodes.Add(nodoLoc);
                }
            }

            tvLocalidades.ExpandAll();
        }

        public void cargarListView(KryptonListView lvTemperaturas, KryptonDateTimePicker dtpFecha, TreeNode nodoSeleccionado)
        {
            try
            {
                DateTime fecha = dtpFecha.Value.Date;
                lvTemperaturas.Items.Clear();

                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;

                if (nodoSeleccionado.Parent == null)
                {
                    int idProvincia = Convert.ToInt32(nodoSeleccionado.Tag);
                    comandoBaseDatos.CommandText = @"
                SELECT L.Nombre AS Localidad, T.TempMin, T.TempMax
                FROM Temperaturas AS T
                INNER JOIN Localidades AS L ON T.IdLocalidad = L.IdLocalidad
                WHERE L.IdProvincia = @IdProvincia AND T.Fecha = @Fecha";
                    comandoBaseDatos.Parameters.AddWithValue("@IdProvincia", idProvincia);
                    comandoBaseDatos.Parameters.AddWithValue("@Fecha", fecha);
                }
                else 
                {
                    int idLocalidad = Convert.ToInt32(nodoSeleccionado.Tag);
                    comandoBaseDatos.CommandText = @"
                SELECT L.Nombre AS Localidad, T.TempMin, T.TempMax
                FROM Temperaturas AS T
                INNER JOIN Localidades AS L ON T.IdLocalidad = L.IdLocalidad
                WHERE T.IdLocalidad = @IdLocalidad AND T.Fecha = @Fecha";
                    comandoBaseDatos.Parameters.AddWithValue("@IdLocalidad", idLocalidad);
                    comandoBaseDatos.Parameters.AddWithValue("@Fecha", fecha);
                }

                lectorDataReader = comandoBaseDatos.ExecuteReader();

                while (lectorDataReader.Read())
                {
                    string tempMin = lectorDataReader["TempMin"].ToString();
                    string tempMax = lectorDataReader["TempMax"].ToString();

                    ListViewItem item = new ListViewItem(tempMin);
                    item.SubItems.Add(tempMax);
                    lvTemperaturas.Items.Add(item);
                }

                lectorDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar temperaturas: " + ex.Message);
            }
        }

        public void actualizarStatusStrip(StatusStrip status, TreeNode nodoSeleccionado)
        {
            string provincia = "";
            string localidad = "";

            if (nodoSeleccionado.Parent == null)
            {
                provincia = nodoSeleccionado.Text;
                localidad = "-";
            }
            else
            {
                provincia = nodoSeleccionado.Parent.Text;
                localidad = nodoSeleccionado.Text;
            }

            status.Items.Clear();
            status.Items.Add("Provincia: " + provincia);
            status.Items.Add(" | Localidad: " + localidad);
        }

    }
}
