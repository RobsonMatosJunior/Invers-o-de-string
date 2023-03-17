using System;

class Program
{
    static void Main()
    {
        // Definir a string a ser invertida
        string str = "Exemplo";

        // Converter a string em um array de caracteres
        char[] charArray = str.ToCharArray();

        // Inverter o array de caracteres
        for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
        }

        // Converter o array de caracteres de volta para uma string
        string reversedStr = new string(charArray);

        // Imprimir a string invertida
        Console.WriteLine(reversedStr);
    }
}