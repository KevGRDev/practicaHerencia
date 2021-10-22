using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaHerencia
{
    class abrirCuenta
    {
        private float saldo;
        

        public abrirCuenta(float saldo) 

        {
            this.saldo = saldo;

        }

        public abrirCuenta()
        {

        }
        public float Saldo
        {
            get => saldo; set => saldo = value;
        }
        public float Abrir()
        {
            return (float)(this.saldo);
        }
    }

    
}
