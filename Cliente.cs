using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1___Guía3_MM200149
{
    public class Cliente
    {
        string dui;
        string nombre;
        string apellido;
        string tipocuenta;
        string nit;
        string numcuenta;
        

        public string DUI
        {
            get { return dui; }
            set { dui = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string TipoCuenta
        {
            get { return tipocuenta; }
            set { tipocuenta = value; }
        }

        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }

        public string NumCuenta
        {
            get { return numcuenta; }
            set { numcuenta = value; }
        }





    }
}
