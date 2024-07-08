using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*void Sum(float? prevCalc = null )
{
    string input;
    float number;
    bool isInputValid = false;
    List<float?> numbersList = new List<float?>();
    float? sum;

    Console.WriteLine("1 --- Addition ---");

    if (prevCalc.HasValue)
    {
        numbersList.Add(prevCalc);
    }

    do
    {
        Console.WriteLine("Entrez un chiffre à additionner ou '=' pour arreter");
        input = Console.ReadLine();
        isInputValid = float.TryParse(input, out number);
        if (isInputValid)
        {
            numbersList.Add(number);
        }
        else
        {
            Console.WriteLine("Entrez une donée valide.\n");
        }
    } while (input != "=");

    sum = numbersList.Sum();

    Console.WriteLine($"Le résultat est : {sum}\n");


    int menuInput;
    Console.WriteLine("--- Menu ---\n");
    Console.WriteLine("--- Continuer avec le résultat ?\n");
    Console.WriteLine("\t1 ---- Addition");
    Console.WriteLine("\t2 ---- Soustraction");
    Console.WriteLine("\t3 ---- Multiplication");
    Console.WriteLine("\t4 ---- Division");

    Console.WriteLine("Faites votre choix : ");
    menuInput = int.Parse(Console.ReadLine());

    switch (menuInput)
    {
        case 1:
            Console.Clear();
            Sum(sum);
            break;
    }
}
*/


float? Sum(float? inputNumber)
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
void Calc()
{
    float? currentResult = null;
    string input;
    string inputOperator;
    float number;
    bool isInputValid = false;


    Console.WriteLine("1 --- Addition ---");

    do
    {
        if (currentResult.HasValue)
        {
            Console.WriteLine("Quel opérateur ? (ou '=' pour arreter)");
            input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    currentResult = Sum(currentResult);
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

}

/*void Menu()
{
    int input;

    Console.WriteLine("--- Calculatrice ---\n");
    Console.WriteLine("1 ---- Addition");
    Console.WriteLine("2 ---- Soustraction");
    Console.WriteLine("3 ---- Multiplication");
    Console.WriteLine("4 ---- Division");

    Console.WriteLine("Faites votre choix : ");
    input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.Clear();
            Sum();
            break;
    }
}*/

Calc();