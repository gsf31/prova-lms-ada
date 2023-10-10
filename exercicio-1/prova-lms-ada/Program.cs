namespace exercicio1
{
    class Program
    {
        static void Main()
        {
            int numerosPares = 0;
            int numerosImpares = 0;
            int numerosPositivos = 0;
            int numerosNegativos = 0;

            Console.WriteLine("Digite cinco números inteiros, podendo ser positivos ou negativos:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("Zero é considerado um número neutro.");
                    }
                    else if (numero % 2 == 0)
                    {
                        Console.WriteLine($"{numero} é par.");
                        numerosPares++;
                    }
                    else
                    {
                        Console.WriteLine($"{numero} é ímpar.");
                        numerosImpares++;
                    }

                    if (numero > 0)
                    {
                        Console.WriteLine($"{numero} é positivo.");
                        numerosPositivos++;
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine($"{numero} é negativo.");
                        numerosNegativos++;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                    i--; // Repetir a entrada inválida
                }
            }

            Console.WriteLine("\nResumo:");
            Console.WriteLine($"Números pares: {numerosPares}");
            Console.WriteLine($"Números ímpares: {numerosImpares}");
            Console.WriteLine($"Números positivos: {numerosPositivos}");
            Console.WriteLine($"Números negativos: {numerosNegativos}");
        }
    }
}


