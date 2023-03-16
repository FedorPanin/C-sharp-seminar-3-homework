Console.WriteLine("введите колличество кубов");
int n = Convert.ToInt32 (Console.ReadLine());
for (int i=1; i<n+1; i++)
{
	double x = Convert.ToDouble (i);
	x = Math.Pow(i, 3);
	Console.Write($"{x}, ");
}