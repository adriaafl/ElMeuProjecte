using System;

class Program
{
    static void Main()
    {
        int contador = 0;

        for (int i = 1; i < 200; i++)
        {
            if (i % 7 == 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Hi ha " + contador + " nombres menors de 200 que són múltiples de 7.");
    }
}


