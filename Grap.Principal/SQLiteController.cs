using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data;


namespace Grap.Principal
{
    class SQLiteController
    {
        SQLiteConnection cn;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        SQLiteDataAdapter da;
        DataTable dt;

        public SQLiteController()
        {
            try
            {
                cn = new SQLiteConnection("Data Source=C:\\db\\dbgraph.db;Version=3");
                cn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }
        public string insertar( string code, string name, string image)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SQLiteCommand("Insert into Clients (Code,Name,Image) values('" + code + "','" + name + "','" + image + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public void cargarPersonas(DataGridView dgv)
        {
            try
            {
                da = new SQLiteDataAdapter("Select * from Clients", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }
        public void llenarConsulta( TextBox TxtCode, TextBox TxtName, TextBox TxtImage)
        {
            try
            {
                cmd = new SQLiteCommand("Select * from Clients where Code=" + TxtCode + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TxtCode.Text = dr["Code"].ToString();
                    TxtName.Text = dr["Name"].ToString();
                    TxtImage.Text = dr["Image"].ToString();

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public int Registrado(int code)
        {
            int contador = 0;
            try
            {
                cmd = new SQLiteCommand("Select * from Clients where Code=" + code + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public string atualizar(string code, string name, string image)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SQLiteCommand("Update Clients set Code ='" + code + "' ,Name='" + name + "'Image='" + image + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }
    }
}
