using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaHerencia
{
    class Depositos
    {
        private float depos;


        public Depositos (float depos)
        {
            this.depos = depos;
        }

        public Depositos()
        {

        }

        public float Depo
        {
            get => depos; set => depos = value;
        }


        public float Suma ()
        {
            return (float)(this.depos + 1000);
        }


    }

    
}
