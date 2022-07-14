// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Договоримся, что числа только целые и будут приниматься рандомно в интервале (-15; 11)
int NumberA = new Random() .Next(-15, 11);
Console.Write($"{NumberA, 3} ");
int NumberB = new Random() .Next(-15, 11);
Console.Write($"{NumberB, 3} ");
int NumberC = new Random() .Next(-15, 11);
Console.WriteLine($"{NumberC, 3} ");
int max = 0;

if (NumberA > NumberB)
{
    if (NumberA > NumberC)
    {
        max = NumberA;
    }
    else 
    {
        max = NumberC;
    }
}
else 
{
    if (NumberB > NumberC)
    {
        max = NumberB;
    }
    else
    {
        max = NumberC;
    }

}
Console.WriteLine(max);