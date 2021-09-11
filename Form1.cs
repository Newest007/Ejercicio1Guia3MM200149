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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbcuenta.Items.Clear();
            cmbcuenta.Items.Add("Corriente");
            cmbcuenta.Items.Add("Ahorros");
            cmbcuenta.Items.Add("Plazos");
            cmbcuenta.Enabled = true;
            txtnmcuenta.Enabled = false;
            dgvfrm1.Visible = true;


        }

        private void cmbcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Opciones tipos de cuentas y automaticamente cambia el acronimo
            string TipoCuenta;

            TipoCuenta = Convert.ToString(cmbcuenta.Text);


            if(TipoCuenta == "Corriente")
            {
                txtnmcuenta.Text = "CC";
            }

            if(TipoCuenta == "Ahorros")
            {
                txtnmcuenta.Text = "CA";
            }

            if(TipoCuenta == "Plazos")
            {
                txtnmcuenta.Text = "CP";
            }

        }

        //Sirve para que el listado del gridview tenga los elementos de la clase cliente
        private List<Cliente> Clientes = new List<Cliente>();
        //Para que el cuando el gridview inice empiece sin seleccionar ningun elemento
        private int edit_indice = -1; 

        private void ActualizarGrid()
        {
            dgvfrm1.DataSource = null;
            dgvfrm1.DataSource = Clientes; //Añade los nombre de la columna en el data gried view
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clien = new Cliente();
            clien.DUI = txtdui.Text;
            clien.Nombre = txtnombre.Text;
            clien.Apellido = txtapellidos.Text;
            clien.TipoCuenta = cmbcuenta.Text;
            clien.Nit = txtnit.Text;
            //Para añadir el acronimo del tipo de cuenta añadiendo junto con el numero de cuenta
            clien.NumCuenta = txtnmcuenta.Text + txtcuenta.Text; 
            MessageBox.Show("Datos Ingresados con Éxito");

            if(edit_indice >-1)
            {
                Clientes[edit_indice] = clien;
                edit_indice = -1;
            }

            else
            {
                Clientes.Add(clien);
            }

            ActualizarGrid();
            limpiar();


        }

        private void limpiar()
        {

            txtdui.Clear();
            txtnombre.Clear();
            txtcuenta.Clear();
            cmbcuenta.Text = "";
            txtapellidos.Clear();
            txtnmcuenta.Clear();
            txtnit.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvfrm1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgvfrm1.SelectedRows[0];
            int pos = dgvfrm1.Rows.IndexOf(seleccion); //Almacena la fila en la cual se está
            edit_indice = pos; //Cambiando el nombre de la variable

            Cliente clien = Clientes[pos]; //Sirve para pasar los valores al listado del datagridview

            txtdui.Text = clien.DUI;
            txtnombre.Text = clien.Nombre;
            txtapellidos.Text = clien.Apellido;
            txtcuenta.Text = clien.TipoCuenta;
            txtnit.Text = clien.Nit;
            txtnmcuenta.Text = clien.NumCuenta;

        }
    }
}
