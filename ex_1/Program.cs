    start:
Console.WriteLine("введите 5 значное число");
int num =Convert.ToInt32 (Console.ReadLine());
if (num < 10000 || num > 99999)
	goto start;
else
{
    int nt = num;
    int rev = 0;
    while (nt > 0)
    {
    	int x = nt % 10;
    	rev = rev * 10 + x;
    	nt = nt / 10;
    }
    if (num == rev)
	    Console.WriteLine("Палиндром");
    else
	    Console.WriteLine("НЕ Палиндром");
}