using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Logica.asientoReserva(0, 0, tnombre.Text) == true && !tnombre.Text.Equals(""))
            {
                button1.Text = tnombre.Text;
                CrearReserva(0, 0, tnombre.Text);
                MessageBox.Show("reserva Completada");
            }
            else
            {
                MessageBox.Show("No se puede hacer la reserva");
            }

        }

        private void CrearReserva( int fila, int col, string nombre) {

            var conexion = new SqlConnection("server=CURLING\\CURLING ; database=Teatro ; integrated security = true");
            conexion.Open();
            string cadena = "insert into reservaciones (fila,col, nombre) values (" + fila + "," + col + ",'" + nombre + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
         //   textBox1.Text = "";
         //   textBox2.Text = "";
            conexion.Close();
            LlenarDataGridView();


        }

        private void LlenarDataGridView()
        {
            string conexion = "server=CURLING\\CURLING ; database=Teatro ; integrated security = true"; 

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                string query = "SELECT codigo as ID, fila as Fila, col as Col, nombre as Nombre, fecha_reservacion FROM reservaciones";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Logica.inicializar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Logica.asientoReserva(0, 1, tnombre.Text) == true)
            {
                button2.Text = tnombre.Text;
                CrearReserva(0, 1, tnombre.Text);
                MessageBox.Show("reserva Completada");
            }
            else
            {
                MessageBox.Show("No se puede hacer la reserva");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Logica.asientoReserva(0, 2, tnombre.Text) == true)
            {
                button3.Text = tnombre.Text;
                CrearReserva(0, 2, tnombre.Text);
                MessageBox.Show("reserva Completada");
            }
            else
            {
                MessageBox.Show("No se puede hacer la reserva");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cancelacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 pantallacancelacion = new Form2();
            pantallacancelacion.ShowDialog();
        }
    }
}
