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
    public partial class Form1 : Form
    {
        public Form1()
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


        }

        private void cmbcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Opciones tipos de cuentas
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
    }
}
