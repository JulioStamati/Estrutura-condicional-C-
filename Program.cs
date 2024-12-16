using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("Por favor, digite a sua idade:");

        string input = Console.ReadLine();
        Console.WriteLine(input);
        
        int idade;

        if (int.TryParse(input, out idade))
        {
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade");
            }
            else if (idade >= 18 && idade < 60)
            {
                Console.WriteLine("Você é adulto");
            }

            else
            {
                Console.WriteLine("Você é idoso");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido");
        }
      }
    }

