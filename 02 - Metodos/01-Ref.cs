namespace DigitalInnovationOne.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)
        { // o metodo cria o temp do tipo inteiro. troca os valores de x e y. Não afeta no metodo.
          // ref: recebe por referencia e não como valor ( int x, int y). 
          // Com o ref o que for modificado dentro do metodo afetara no que for chamado
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}
    
}