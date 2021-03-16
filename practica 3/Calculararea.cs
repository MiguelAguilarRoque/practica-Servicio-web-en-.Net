using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_3
{
    public class Calculararea
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public decimal areacuadrado (decimal basec, decimal altura)
        {
            basec = numero1;
            altura = numero2;
            return basec * altura;
        }
        public decimal areatriangulo(decimal basec, decimal altura)
        {
            basec = numero1;
            altura = numero2;
            return (basec * altura)/2;
        }
        public decimal areacirculo (decimal radio)
        {
            double pi = 3.14;
            radio = numero1 * numero1;
            radio = radio * Convert.ToDecimal(pi);
            return radio;

            
        }
    }
}