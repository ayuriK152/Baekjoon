string[] input = Console.ReadLine().Split(' ');
int n = int.Parse(input[0]), w = int.Parse(input[1]), h = int.Parse(input[2]);
int diag = w * w + h * h;
for (int i = 0; i < n; i++)
{
    int s = int.Parse(Console.ReadLine());
    string result = s * s <= diag ? "DA" : "NE";
    Console.WriteLine(result);
}