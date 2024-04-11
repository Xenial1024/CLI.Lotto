using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte randomNumber, guessedNumber;
            int numberOfAttempts=0;
            while (true)
            {
                Console.Write("Wpisz liczbę od 0 do 100: "); 
                randomNumber = (byte)rnd.Next(0, 101);
                numberOfAttempts++;
                if (!byte.TryParse(Console.ReadLine(), out guessedNumber) || guessedNumber > 100)
                {
                    Console.WriteLine("Wpisano błędną wartość lub jej w ogóle nie wpisano. Spróbuj ponownie.");
                    continue;
                }
                else if (guessedNumber > randomNumber)
                    Console.WriteLine("Twoja liczba jest za duża. Wylosowana liczba to " + randomNumber + ".");
                else if (guessedNumber < randomNumber)
                    Console.WriteLine("Twoja liczba jest za mała. Wylosowana liczba to " + randomNumber + ".");
                else
                {
                    Console.WriteLine($"Gratulacje. Odgadłeś wylosowaną liczbę w {numberOfAttempts} próbach");
                    numberOfAttempts = 0;
                }
            }
        }
    }
}
