using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasWindowsForms
{
    class CAreas
    {
        
        public static decimal Cuadrado(decimal lado) 
        {
            return (lado * lado);
           
        }

        public static decimal Triangulo(decimal b, decimal h)
        {
            return (b * h)/2;
            
        }

        public static decimal Rectangulo(decimal b, decimal h)
        {
            return (b * h);
            
        }

        public static decimal Paralelogramo(decimal b, decimal h)
        {
            return (b * h);
            
        }
        public static decimal Rombo(decimal D, decimal d)
        {
            return (D * d)/2;
            
        }

        public static decimal Circulo(decimal radio)
        {
            return (decimal)(Math.PI * Math.Pow((double)radio, 2));
            
        }

    }
}
