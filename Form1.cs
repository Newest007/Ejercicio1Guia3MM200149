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
            cmbsucursal.Items.Add("Sucursal 1");
            cmbsucursal.Items.Add("Sucursal 2");
            cmbsucursal.Items.Add("Sucursal 3");
            cmbsucursal.Items.Add("Sucursal 4");
            cmbsucursal.Items.Add("Sucursal 5");
            cmbcuenta.Enabled = true;
            txtnmcuenta.Enabled = false;
            groupBox2.Visible = false;


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
            clien.DUI = txtdui.Text + " - " + txtsegundodigdui.Text;
            clien.Nombre = txtnombre.Text;
            clien.Apellido = txtapellidos.Text;
            clien.TipoCuenta = cmbcuenta.Text;
            clien.Nit = txtprimernumnit.Text + "-" + txtsegundonumnit.Text + "-" + txttercernumnit.Text + "-" + txtcuartonumnit.Text;
            //Para añadir el acronimo del tipo de cuenta añadiendo junto con el numero de cuenta
            clien.NumCuenta = txtnmcuenta.Text + " - " + txtcuenta.Text;
            clien.MontoTotal = "$" + txtmonto.Text + ".00";
            clien.SucursalInscrito = cmbsucursal.Text;
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
            txtprimernumnit.Clear();
            txtsegundodigdui.Clear();
            txtcuartonumnit.Clear();
            txtsegundonumnit.Clear();
            txttercernumnit.Clear();
            txtmonto.Clear();
            cmbsucursal.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

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
            txtprimernumnit.Text = clien.Nit;
            txtnmcuenta.Text = clien.NumCuenta;
            txtmonto.Text = clien.MontoTotal;
            cmbsucursal.Text = clien.SucursalInscrito;

        }

        private void dgvfrm1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(edit_indice>-1)
            {
                Clientes.RemoveAt(edit_indice);
                edit_indice = -1;
                limpiar();
                ActualizarGrid();
            }

            else
            {
                MessageBox.Show("Debes dar doble click sobre el cliente a eliminar");
            }



        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcuartonumnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
