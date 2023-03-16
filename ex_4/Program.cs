Console.WriteLine("укажите количество осей координат в пространстве от 1 до 3");
int space = Convert.ToInt32(Console.ReadLine());
if (space == 1)
{
	Console.WriteLine("укажите координату x точки 1");
	Double x1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату x точки 2");
	Double x2 = Convert.ToDouble(Console.ReadLine());
	Double dist = 0;
	dist = x2 - x1;
	dist = Math.Abs(dist);
	Console.WriteLine(dist);
}
if (space == 2)
{
    Console.WriteLine("укажите координату x точки 1");
    Double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("укажите координату y точки 1");
    Double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("укажите координату x точки 2");
    Double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("укажите координату y точки 2");
    Double y2 = Convert.ToDouble(Console.ReadLine());
    Double dist = 0;
    dist = (double)Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
    Console.WriteLine(dist);
}
if (space ==3)
{
	Console.WriteLine("укажите координату x точки 1");
	Double x1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату y точки 1");
	Double y1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату z точки 1");
	Double z1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату x точки 2");
	Double x2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату y точки 2");
	Double y2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("укажите координату z точки 2");
	Double z2 = Convert.ToDouble(Console.ReadLine());
	
	Double dist = 0; 
	dist = (double)Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
	Console.WriteLine(dist);
}					