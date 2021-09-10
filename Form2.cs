using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1___Guía3_MM200149
{
    public partial class Form2 : Form
    {

        public List<Cliente> ClienteRecibe = null;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarGrid() //Funcion para llenar el datagriedview con los datos de la funcion cliente
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ClienteRecibe;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
