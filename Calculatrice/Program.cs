using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

// addition function
float? Add(float? inputNumber)
{
    bool isInputValid = false;
    float number;
    float? result = 0;
    do
    {
        Console.WriteLine("Entrez un chiffre à additionner");
        
        isInputValid = float.TryParse(Console.ReadLine(), out number);
        if (isInputValid)
        {
            result = inputNumber + number;
        }
        else
        {
            Console.WriteLine("Entrez une donnée valide.\n");
        }
    } while (!isInputValid);
    Console.WriteLine($"Résultat actuel : {result}");

    return result;
}

// substraction function
float? Sub(float? inputNumber)
{
    bool isInputValid = false;
    float number;
    float? result = 0;
    do
    {
        Console.WriteLine("Entrez un chiffre à soustraire");

        isInputValid = float.TryParse(Console.ReadLine(), out number);
        if (isInputValid)
        {
            result = inputNumber - number;
        }
        else
        {
            Console.WriteLine("Entrez une donnée valide.\n");
        }
    } while (!isInputValid);
    Console.WriteLine($"Résultat actuel : {result}");

    return result;
}

// multiplication function
float? Mult(float? inputNumber)
{
    bool isInputValid = false;
    float number;
    float? result = 0;
    do
    {
        Console.WriteLine("Entrez un chiffre à multiplier");

        isInputValid = float.TryParse(Console.ReadLine(), out number);
        if (isInputValid)
        {
            result = inputNumber * number;
        }
        else
        {
            Console.WriteLine("Entrez une donnée valide.\n");
        }
    } while (!isInputValid);
    Console.WriteLine($"Résultat actuel : {result}");

    return result;
}

// division function
float? Div(float? inputNumber)
{
    bool isInputValid = false;
    float number;
    float? result = 0;
    do
    {
        Console.WriteLine("Entrez un chiffre à diviser");

        isInputValid = float.TryParse(Console.ReadLine(), out number);
        if (isInputValid && number != 0)
        {
            result = inputNumber / number;
        }
        else
        {
            Console.WriteLine("Entrez une donnée valide.\n");
        }
    } while (!isInputValid || number == 0);
    Console.WriteLine($"Résultat actuel : {result} \n");

    return result;
}

// main function calling the others to do the operations
void Calc()
{
    float? currentResult = null;
    string input;
    string inputOperator;
    float number;
    bool isInputValid = false;


    Console.WriteLine("--- Calculator ---");

    do
    {
        if (currentResult.HasValue)
        {
            Console.WriteLine("Quel opérateur ? (ou '=' pour arreter)");
            input = Console.ReadLine();

            // select which operator to use
            switch (input)
            {
                case "+":
                    currentResult = Add(currentResult);
                    break;

                case "-":
                    currentResult = Sub(currentResult);
                    break;
                case "*":
                    currentResult = Mult(currentResult);
                    break;
                case "/":
                    currentResult = Div(currentResult);
                    break;
                case "=":
                    break;
                default:
                    Console.WriteLine("veuillez entrer un opérateur valide");
                    break;
            }
        }
        // verify if a value is already saved
        else
        {
            Console.WriteLine("Entrez un chiffre à additionner (ou '=' pour arreter)");
            input = Console.ReadLine();
            isInputValid = float.TryParse(input, out number);
            if (isInputValid)
            {
                currentResult = number;
            }
            else if (input != "=")
            {
                Console.WriteLine("Entrez une donnée valide.\n");
            }

        }
    } while (input != "=");

    Console.WriteLine($"Le résultat de votre opération est {currentResult}");

};

Calc();