int[] fib = new int[46];
fib[1] = 1;
fib[2] = 1;
for (int i = 3; i < 46; i++)
    fib[i] = fib[i - 2] + fib[i - 1];
int k = int.Parse(Console.ReadLine());
Console.Write($"{fib[k - 1]} {fib[k]}");