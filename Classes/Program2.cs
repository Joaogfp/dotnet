using System;

namespace Classes
{
    public class Program2 : Program
    {
        public int z;

        public Program2(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa
        }

        public override void CalcularDistancia3()//override sobreescreve o método CalcularDistancia3
        {
            //Faz outra coisa
        }
    }
}
