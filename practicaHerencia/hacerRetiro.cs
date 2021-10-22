using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaHerencia
{
    class hacerRetiro
    {
        private float retiro;


        public hacerRetiro (float retiro)

        {
            this.retiro = retiro;

        }

        public hacerRetiro()
        {

        }
        public float Retiro
        {
            get => retiro; set => retiro = value;
        }
        public float Retirar()
        {
            return (float)(1000 - this.retiro);
        }
    }


}

    
