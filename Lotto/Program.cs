using System;

namespace Lotto
{
    class Program
    {
        static void Main()
        {
            Random rnd = new();
            byte randomNumber;
            randomNumber = (byte)rnd.Next(0, 101);
            int numberOfAttempts=0;

            while (true)
            {
                Console.Write("Wpisz liczbę od 0 do 100: "); 
                numberOfAttempts++;
                if (!byte.TryParse(Console.ReadLine(), out byte guessedNumber) || guessedNumber > 100)
                {
                    Console.WriteLine("Wpisano błędną wartość lub jej w ogóle nie wpisano. Spróbuj ponownie.");
                    continue;
                }
                else if (guessedNumber > randomNumber)
                    Console.WriteLine("Twoja liczba jest za duża.");
                else if (guessedNumber < randomNumber)
                    Console.WriteLine("Twoja liczba jest za mała.");
                else
                {
                    Console.WriteLine($"Gratulacje. Odgadłeś wylosowaną liczbę w {numberOfAttempts} próbach.");
                    break;
                }
            }
        }
    }
}
