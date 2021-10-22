using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaHerencia
{
    class hacerDeposito
    {
        private float deposito;
    }

    public hacerDeposito (float deposito)

    {
        this.deposito = deposito;

    }

    public hacerDeposito()
    {

    }
    public float Deposito
    {
        get => deposito; set => deposito = value;
    }
    public float Depositar()
    {
        return (float)(1000 + this.retiro);
    }
}
