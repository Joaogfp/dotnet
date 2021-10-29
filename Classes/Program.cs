using System;

namespace Classes
{
    public class Program
    {
        public int x, y;

        private int distancia;

        public Program(int x, int y)
        {
            this.x = x; //this.x referencia ao x da variavel public int x
            this.y = y; //this.y referencia ao y da variavel public int y
        }

        protected void CalcularDistancia()
        {
            //Faz alguma coisa
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa
        }

        public virtual void CalcularDistancia3() //virtual permite que uma classe filha sobreescreva sua atuação
        {
            //Faz alguma coisa
        }
    }
}
