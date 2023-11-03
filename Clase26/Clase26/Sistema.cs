using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase26
{
    internal class Sistema
    {
        private string manufactura;
        private string sistOp;
        public string modelo;
        private int costo;

        public Sistema(string m, string so, string mod, int c) 
        {
            manufactura = m;
            sistOp = so;
            modelo = mod;
            costo = c;
        }
        public string Manufactura
        {
            get { return manufactura; }
        }
        public string SistOp
        {
            get { return sistOp; }
        }
        public int Costo
        {
            get { return costo; }
        }

        public void Imprimir()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Manufactura: " + Manufactura);
            Console.WriteLine("SO:          " + SistOp);
            Console.WriteLine("Modelo:      " + modelo);
            Console.WriteLine("Costo:       " + Costo);
            Console.WriteLine("-----------------------");
        }
    }
}
