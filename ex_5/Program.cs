Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int nt = n;
int rev = 0;
while (nt > 0)
	{
		int x = nt % 10;
		rev = rev * 10 + x;
		nt = nt / 10;
	}
//	Console.WriteLine(rev);
if (n == rev)
	Console.WriteLine("Палиндром");
else
	Console.WriteLine("НЕ Палиндром");