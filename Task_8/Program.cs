// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Договоримся, что число N целое и будет приниматься рандомно в интервале (1; 20)
int N = new Random() .Next(1, 20);
int M = 1;
Console.WriteLine(N);
while (M < N)
{
    if (M % 2 == 0)
    Console.Write($"{M, 2} ");
    M = M + 1;
}
