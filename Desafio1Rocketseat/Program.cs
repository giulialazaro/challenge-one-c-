using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Exercícios práticos 1
        OnlyName();

        // Exercícios práticos 2
        NameSurname();

        // Exercícios práticos 3
        var (soma, subtraction, multiplication, division, average) = Calculate(5,5);

        Console.WriteLine($"O resultado da soma é: {soma}");
        Console.WriteLine($"O resultado da subtração é: {subtraction}");
        Console.WriteLine($"O resultado da multiplicação é: {multiplication}");
        Console.WriteLine($"O resultado da divisão é: {division}");
        Console.WriteLine($"O resultado da média é: {average}");

        // Exercícios práticos 4
        NumberOfCharacters();

        // Exercícios práticos 5
        ValidCarLicensePlate();

        // Exercícios práticos 6
        ViewDate();
    }

    static void OnlyName()
    {
        Console.Write("Insira seu nome: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    static void NameSurname()
    {
        Console.Write("Insira seu nome: ");
        string name = Console.ReadLine();


        Console.Write("Insira seu sobrenome: ");
        string surname = Console.ReadLine();

        Console.WriteLine($"{name} {surname}");
    }

    static (double soma, double subtraction, double multiplication, double division, double average) Calculate(double valor1 = 10, double valor2 = 8)
    {
        double soma = valor1 + valor2;
        double subtraction = valor1 - valor2;
        double multiplication = valor1 * valor2;
        double division = valor2 != 0 ? valor1 / valor2 : 0;
        double average = (valor1 + valor2) / 2;

        return (soma, subtraction, multiplication, division, average);
    }

    static void NumberOfCharacters()
    {
        Console.Write("Insira uma frase: ");
        string phrase = Console.ReadLine();

        string phraseTrimmed = phrase.Trim();

        string phraseNoSpaces = phraseTrimmed.Replace(" ", "");

        int numberOfCharacters = phraseNoSpaces.Length;

        Console.WriteLine($"Quantidade de caracteres (sem espaços): {numberOfCharacters}");
    }

    static void ValidCarLicensePlate()
    {
        Console.Write("Insira a placa do seu veículo: ");
        string carLicensePlate = Console.ReadLine();

        string validCarLicensePlate = @"^[a-zA-Z]{3}[0-9]{4}$";

        if (Regex.IsMatch(carLicensePlate, validCarLicensePlate))
        {
            Console.WriteLine("Verdadeiro");
        } else
        {
            Console.WriteLine("Falso");
        }
    }

    static void ViewDate()
    {
        DateTime dateNow = DateTime.Now;

        Console.WriteLine("Data completa: " + dateNow.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));

        Console.WriteLine("Data (DD/MM/YYYY): " + dateNow.ToString("dd/MM/yyyy"));

        Console.WriteLine("Hora (HH:mm): " + dateNow.ToString("HH:mm"));

        Console.WriteLine("Data com mês por extenso: " + dateNow.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}
