using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
    // Aula Classes e Objetos -

    // A classe permite a criação de objetos. Estrutura que combina estados(campos) e ações (metodos)
    // As ações são métodos que o objeto poderá executar
    // Os objetos são instâncias de uma classe

    /* Onde as classes suportam herança e polimorfirmos, mecanismos onde as classes
       podem estender e especializar as classes base */

    /* Instâncias de classes (objetos) são criadas usando o operador new, onde aloca memoria para uma nova
    instancia, ele chama um construtor para inicialiizar a instância e retorna uma referência à instancia
    A memoria ocupada por um objeto é recuperada automaticamente quando o objeto não está mais acessível. 
    Não é necessario nem possivel desalocar explicitamente objetos em C# */

    /* Membros: podem ser estativos ou membros da instancia. 
       Os estaticos pertemcem a classe e membros de instancia pertencem ao objeto.
       Constantes, variaveis, metodos, propriedades, construtores, etc... */

    /* Assessibilidade: Cada membro de um classe tem uma assessibilidade associada, que controla as
       regioes do texto do programa que podem acessar o mebro. Public - protected - Internal - Private */ 

    /* Herança: uma declaracao de calsse pode especificar uma classe base, herdando os mebros public -
       internal - protected da classe base. Omitir uma especificação de classe base é o mesmo que derivar do tipo objeto */


    /* Métodos: É um membro que implementa uma computacao ou acao que pode ser executada por um objeto ou classe.
       Eles podem ter uma lista de parametros que representam valores ou referencias de variaveis passando para
       o metodo e um tipo de retorno, que especifica o tipo do valor calculado e retornado pelo metodo */

    /* Exemplo d aula

    static void Main(string[] args)
    {
        Ponto p1 = new Ponto(10, 20);

        Ponto3D p2 = new Ponto(10, 20, 30);

        Ponto3D.Calcular(); //pertence a classe e não a instancia , estatico
    }

    }
}
 /*
    /* Aula variaveis e instruções - Exemplos -

        static void Declaracoes()
    {
        int a;
        int b = 2, c =3;
        const int d = 4;
        a = 1;
        Console.WriteLine(a + b + c + d);

    }
    
        static void InstrucaoIf(string[] args)
        {
            if (args.length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.length == 1)
            {
                Console.WriteLine("Um argumento");
                
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos")
                //$-> concatena/altera o texto da string no C#
            }
        }
        
        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0;
                Console.WriteLine("Nenhum argumento");
                break;

                case 1:
                Console.WriteLine("Um argumento");
                break;

                default:
                Console.WriteLine($"{numeroDeArgumentos} argumentos");
                break;
            }
        }
        
        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
    static void InstrucaoDo(string[] args)
    {
        string textos;
        do
        {
        texto = Console.ReadLine();
        Console.WriteLine(texto);
        } while (!string.IsNullOrEmpty(texto));
    }

    static void InstrucaoFor(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }

    static void InstrucaoForeach(string[] args)
    {
        foreach (string s in args) //Para cada (s)
        {
            Console.WriteLine(s);
        }
    }

    static void InstrucaoBreak(string[] args)
    {
        while (true)
        {
            string s = Console.ReadLine();

            if (string.IsNullOrEmpty(s))
            {
                break;
            }

            Console.WriteLine(s);
        }
    }
    
    Static void InstrucaoContinue(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].StartsWith("/")) //se ele começar antes do Aray. Proximo item.
            {
                continue;
            }

            Console.WriteLine(args[i]);
        }
    }
    
    static void InstrucaoReturn(string[] args) //void não retorna valores
    {
        int Somar(int a, int b)
        {
            return a + b;
        }

        Console.WriteLine(Somar (1, 2));
        Console.WriteLine(Somar (3, 4));
        Console.WriteLine(Somar (5, 6));
        return;
    }
    
    static void InstrucoestryCatchFinallyThrow(string[] args)
    {
        double Dividir(double x, double y)
        {
            if (y == 0)
            throw new DivideByZerosExection();

            return x / y;
        }

        try
        {
            if (args.Length != 2)
            {
                throw new InvalidOperationException("Informe 2 números");
            }

            double x = double.Parce(args [0]);
            double y = double.Parce(args [1]);
            Console.WriteLine(Dividir(x, y)); 
        }
        catch (InvalidOperationException e)
        {
            
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro genérico; {e.Message}");
        }
        finaly 
        {
            Console.WriteLine("Até breve!");
        }
    }
    
    static void InstrucaoUsing(string[] args)
    {
        using (System.IO.textWriter w = System.IO.File.CreatText("teste.txt")
        {
            w.WriteLine("Line 1");
            w.WriteLine("Line 2");
            w.WriteLine("Line 3");
        }  
    }

    }
}

        /* Estrutura do programa

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
}   */

     /* Aula I .NET-   

        static void Main(string[] args)
        {
          
        int numeroDeVezes = 9;
        
        for (int i = 0; i < numeroDeVezes; i++)

        {

        Console.WriteLine($"Primeira Aula de .NET {i}");
        
        } 
        }   */    