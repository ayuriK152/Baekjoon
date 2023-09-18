string[] input = Console.ReadLine().Split(' ');
int d = int.Parse(input[0]), h = int.Parse(input[1]), w = int.Parse(input[2]);
int actualH = (int)(h * d / Math.Sqrt(h * h + w * w));
int actualW = (int)(w * d / Math.Sqrt(h * h + w * w));
Console.Write($"{actualH} {actualW}");