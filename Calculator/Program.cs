namespace Calculator;
class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator!");
        int firstNumber = AskNumber();
        int secondNumber = AskNumber();

        char operatorSigne = SelectOperator();
        

        switch (operatorSigne)
        {   
            case '+':
                Addition(firstNumber, secondNumber); break;
            case '-':
                Soustraction(firstNumber, secondNumber); break;
            case '*':
                Multiplication(firstNumber, secondNumber); break;
            case '/':
                Division(firstNumber, secondNumber); break;
        }
    }

    public static void Addition(int num01, int num02)
    {
        Console.WriteLine($"{num01} + {num02} = {num01 + num02}");
    }

    public static void Soustraction(int num01, int num02)
    {
        Console.WriteLine($"{num01} - {num02} = {num01 - num02}");
    }

    public static void Multiplication(int num01, int num02)
    {
        Console.WriteLine($"{num01} * {num02} = {num01 * num02}");
    }

    public static void Division(int num01, int num02)
    {
        try
        {
            Console.WriteLine($"{num01} / {num02} = {num01 / num02}");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Division par 0 détecté ; retour de 0 par défaut");
        }
    }

    public static int AskNumber()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Please enter a number:");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number... Try again ...");
            }
        }
    }

    public static char SelectOperator()
    {
        while (true)
        {
            Console.WriteLine("Please enter an operator (+, -, *, /):");
            string? input = Console.ReadLine();

            try
            {
                if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
                    throw new ArgumentException("Vous devez entrer un seul caractère.");

                char op = input[0];
                if (op != '+' && op != '-' && op != '*' && op != '/')
                    throw new ArgumentOutOfRangeException(nameof(input), op, "Opérateur non reconnu.");

                return op;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erreur : {ex.Message} Réessayez.");
            }
        }
    }
}