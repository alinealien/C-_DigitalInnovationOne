namespace DigitalInnovationOne.Herença
{
    public class Ponto
    {
        public int x, y; // _x , _y : Para indicar privado
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faz algo
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Faz algo
        }
        public virtual void CalcularDistancia3() // metodo virtual permite que uma classe filha sobreescreva a atuacao dele
        {
            //Faz algo
        }
    }
}