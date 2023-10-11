//A ÁGUIA, caiu entre as águas Aventureiras, mas aTROPELOU o 1 2 3 ENquanto estava no chão KAYKE Brito, cuidado!!!

using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string[] palavras = ObterPalavras(frase);
        int totalPalavras = 0;
        int maiusculas = 0;
        int minusculas = 0;
        int comecaMaiuscula = 0;
        int comecaMinuscula = 0;
        bool numerosDesconsiderados = false;

        foreach (string palavra in palavras)
        {
            if (string.IsNullOrWhiteSpace(palavra))
                continue;

            if (char.IsDigit(palavra[0]))
            {
                numerosDesconsiderados = true;
                continue;
            }

            totalPalavras++;

            if (SaoTodasMaiusculas(palavra))
            {
                maiusculas++;
            }
            else if (SaoTodasMinusculas(palavra))
            {
                minusculas++;
            }
            else if (ComecaComMaiuscula(palavra))
            {
                comecaMaiuscula++;
            }
            else
            {
                comecaMinuscula++;
            }
        }

        if (numerosDesconsiderados)
        {
            Console.WriteLine("Aviso: Números não foram considerados na contagem das palavras.");
        }

        Console.WriteLine("Total de palavras: " + totalPalavras);
        Console.WriteLine("Palavras maiúsculas: " + maiusculas);
        Console.WriteLine("Palavras minúsculas: " + minusculas);
        Console.WriteLine("Palavras que começam com letra maiúscula: " + comecaMaiuscula);
        Console.WriteLine("Palavras que começam com letra minúscula: " + comecaMinuscula);
    }

    static string[] ObterPalavras(string texto)
    {
        string[] separadores = { " ", ",", ".", "!", "?", ":", ";", "(", ")", "[", "]", "{", "}", "<", ">", "\"", "'", "\t", "\n", "\r" };
        return texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
    }

    static bool SaoTodasMaiusculas(string palavra)
    {
        return palavra.All(caracter => char.IsUpper(caracter));
    }

    static bool SaoTodasMinusculas(string palavra)
    {
        return palavra.All(caracter => char.IsLower(caracter));
    }

    static bool ComecaComMaiuscula(string palavra)
    {
        if (string.IsNullOrWhiteSpace(palavra))
            return false;

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string primeiraLetra = textInfo.ToTitleCase(palavra.Substring(0, 1));
        return palavra.StartsWith(primeiraLetra);
    }
}
