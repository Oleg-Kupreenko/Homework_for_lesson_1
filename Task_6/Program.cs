// Напишите программу, которая на входе принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Договоримся, что число целое и будет приниматься рандомно в интервале (1; 25)
int NumberA = new Random() .Next(1, 25);
Console.WriteLine(NumberA);
double NumberB = (NumberA / 2);
Console.WriteLine(NumberB);
if (NumberA == NumberB * 2)
{
    Console.WriteLine ("Да");
}

else
    {
        Console.WriteLine ("нет");
    }

