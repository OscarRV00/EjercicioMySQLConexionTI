using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ConexionMySQL
{
    public partial class Form1 : Form
    {

        private MySqlConnection conexion;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El HOST es campo requerido");
                return;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El USUARIO es campo requerido");
                return;
            }
            

            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString =
                  "server=" + txtHost.Text + ";"
                  + "user id=" + txtUsuario.Text + ";"
                  + "password=" + txtContrasena.Text + ";";
                conexion.Open();
                MessageBox.Show("LA CONEXION SE REALIZO EXITOSAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al conectar" + ex.Message); 
            }

            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
