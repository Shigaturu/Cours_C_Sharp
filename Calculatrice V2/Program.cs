using System;
using System.Text.RegularExpressions;
using System.Linq;

bool done2 = false;
while (!done2)
{
    try
    {
        Console.WriteLine("Saisir l'opération ");
        string operation = Console.ReadLine();

        // Utilisez Regex pour trouver tous les opérateurs dans la chaîne
        MatchCollection operatorMatches = Regex.Matches(operation, @"[\+\-\*\/]");

        // Créez un tableau pour stocker les opérateurs
        string[] operators = new string[operatorMatches.Count];

        // Parcourez les correspondances et ajoutez-les au tableau
        for (int i = 0; i < operatorMatches.Count; i++)
        {
            operators[i] = operatorMatches[i].Value;
        }

        // Utilisez Regex pour diviser la chaîne en nombres
        string[] numbers = Regex.Split(operation, @"[\+\-\*\/]");

        // Convertissez les nombres en int
        int[] numbersInt = numbers.Select(int.Parse).ToArray();

        // Traitez le premier nombre
        int result = numbersInt[0];

        // Parcourez les opérateurs et effectuez les calculs
        for (int i = 0; i < operators.Length; i++)
        {
            int nextNumber = numbersInt[i + 1];
            string currentOperator = operators[i];

            // Effectuez le calcul en fonction de l'opérateur
            switch (currentOperator)
            {
                case "+":
                    result += nextNumber;
                    break;
                case "-":
                    result -= nextNumber;
                    break;
                case "*":
                    result *= nextNumber;
                    break;
                case "/":
                    if (nextNumber != 0) // Vérifiez la division par zéro
                        result /= nextNumber;
                    else
                        Console.WriteLine("Division par zéro n'est pas autorisée.");
                    break;
                default:
                    Console.WriteLine("Opérateur non pris en charge.");
                    break;
            }
        }

        // Affichez le résultat
        Console.WriteLine("Résultat : " + result);

        done2 = true;
    }
    catch
    {
        Console.WriteLine("Saisie incorrecte");
    }
}
