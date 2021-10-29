using System;

namespace aulaDotnet
{
  class Program
  {
    static void Exercicios()
    {
      int a = 1;
      int b = 2;
      int c = 3;
      const int d = 4;
      Console.WriteLine(a + b + c + d);
    }

    static void InstrucaoIf(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("Nenhum argumento");
      }
      else if (args.Length == 1)
      {
        Console.WriteLine("Um argumento");
      }
      else
      {
        Console.WriteLine($"{args.Length} argumentos");
      }
    }

    static void InstrucaoSwitch(string[] args)
    {
      int numeroDeArgument = args.Length;
      switch (numeroDeArgument)
      {
        case 0:
          Console.WriteLine("Nenhum argumento");
          break;
        case 1:
          Console.WriteLine("Um argumento");
          break;
        case 2:
          Console.WriteLine("Dois argumentos");
          break;
        case 3:
          Console.WriteLine("3 argumentos");
          break;
        default:
          Console.WriteLine($"{numeroDeArgument} argumentos");
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
      string texto;
      do
      {
        texto = Console.ReadLine(); //guarda o que o usuário escrever na variável texto
        Console.WriteLine(texto); //imprime o que foi preenchido na variável texto
      } while (!string.IsNullOrEmpty(texto));//IsNullOrEmpty indica se é nulo ou vazio - !negativa --> enquanto o texto não for nulo ou vazio continua executando o do
    }

    static void InstrucaoFor(string[] args)
    {
        for(int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }

    static void InstrucaoForEach(string[] args)
    {
        foreach (string s in args)
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
                break;

            Console.WriteLine(s);    
        }
    }

    static void InstrucaoContinue(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].StartsWith("/"))
                continue;

            Console.WriteLine(args[i]);    
        }
    }

    static void InstrucaoReturn(string[] args)
    {
        int Soma(int a, int b, int c)
        {
            return a + b + c;
        }

        if (args.Length == 0)
        {
            return;
        }

        Console.WriteLine(Soma(1, 2, 0));
        Console.WriteLine(Soma(52, 2, 223));
        Console.WriteLine(Soma(5, 20, 30));

        return;
    }

    static void InstrucaoTryCatchFinallyThrow(string[] args)
    {
        double Dividir(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;

        }

        try
        {
            if (args.Length != 2)
            {
                throw new InvalidOperationException("Informe 2 números!");
            }

            double x = double.Parse(args[0]);
            double y = double.Parse(args[1]);
            Console.WriteLine(Dividir(x, y));
        }

        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (Exception e)
        {
            Console.WriteLine($"Erro genérico: {e.Message}");
        }

        finally
        {
            Console.WriteLine("Até logo!");
        }
    }

  }


}
