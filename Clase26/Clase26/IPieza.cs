using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase26
{
    public interface IPieza
    {
        double Area();
        double Perimetro();
    }
    public class Cuadrado: IPieza
    {
        public double Lado {get; set; } //propiedad auroimplentada
        
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public double Area()
        {
            return Lado * Lado;
        }
        public double Perimetro()
        {
            return Lado * 4;
        }

    }
    public class TriRec: IPieza
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double Hipotenusa { get; set; }
        public TriRec(double la, double lb)
        {
            LadoA = la;
            LadoB = lb;
            Hipotenusa = CalcHipo(la, lb);
        }
        private double CalcHipo(double la, double lb)
        {
            double res = Convert.ToDouble(Math.Sqrt((double)(la * la + lb * lb)));
            return res;
        }
        public double Area()
        {
            return LadoA * LadoB / 2;
        }
        public double Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
