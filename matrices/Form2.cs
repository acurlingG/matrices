using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Logica.cancelar(textBox1.Text)==true)
                MessageBox.Show("reserva Cancelada");
            else MessageBox.Show("No se encontro la reserva de " + textBox1.Text); ;
        }
    }
}
