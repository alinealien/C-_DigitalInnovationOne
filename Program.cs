using System;
using DigitalInnovationOne.Exemplos;

namespace DigitalInnovationOne.Exemplos
{
    class Program
    {
        
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }    
}

     /*Aula I .NET-   static void Main(string[] args)
        {
          
        int numeroDeVezes = 9;
        
        for (int i = 0; i < numeroDeVezes; i++)

        {

        Console.WriteLine($"Primeira Aula de .NET {i}");
        
        } 
        }   */