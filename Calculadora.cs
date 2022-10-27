using System;

namespace PI
{
    class Calculadora
    {
        public static double pi = 3.14; // static para ser chamado sem instanciar o objeto
        public static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * r*r*r;
        }
    }
}
