namespace exercicio2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número inteiro (N1): ");
            if (int.TryParse(Console.ReadLine(), out int n1))
            {
                Console.Write("Digite o segundo número inteiro (N2): ");
                if (int.TryParse(Console.ReadLine(), out int n2) && n2 != 0)
                {
                    int multiplicacao = 0;
                    int divisao = 0;
                    int absolutoN1 = Math.Abs(n1);
                    int absolutoN2 = Math.Abs(n2);

                    for (int i = 0; i < absolutoN2; i++)
                    {
                        multiplicacao += absolutoN1;
                    }

                    while (absolutoN1 >= absolutoN2)
                    {
                        absolutoN1 -= absolutoN2;
                        divisao++;
                    }

                    if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
                    {
                        multiplicacao = -multiplicacao;
                        divisao = -divisao;
                    }

                    Console.WriteLine($"Multiplicação inteira de N1 * N2 = {multiplicacao}");
                    Console.WriteLine($"Divisão inteira de N1 / N2 = {divisao}");
                }
                else
                {
                    Console.WriteLine("N2 não pode ser zero e deve ser um número inteiro.");
                }
            }
            else
            {
                Console.WriteLine("N1 deve ser um número inteiro.");
            }
        }
    }
}

