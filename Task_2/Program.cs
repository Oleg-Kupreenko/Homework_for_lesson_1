// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Договоримся, что числа только целые и будут приниматься рандомно в интервале (-10; 11)
int NumberA = new Random() .Next(-10, 11);
Console.WriteLine(NumberA);
int NumberB = new Random() .Next(-10, 11);
Console.WriteLine(NumberB);
int max = 0;
int min = 0;

if (NumberA > NumberB) 
{
    max = NumberA;
    min = NumberB;
}
else 
{
    max = NumberB;
    min = NumberA;
}
Console.WriteLine("max =" + max);
Console.WriteLine("min =" + min);