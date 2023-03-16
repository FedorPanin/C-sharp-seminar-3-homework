Console.WriteLine("Ведите координату x1");
Double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координату y1");
Double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координату z1");
Double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координату x2");
Double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координату y2");
Double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координату z2");
Double z2 = Convert.ToDouble(Console.ReadLine());

Double dist = 0;

dist = (Double)Math.Sqrt((Math.Pow((x2-x1),2)) + (Math.Pow((y2-y1),2)) + (Math.Pow((z2-z1),2)));

Console.WriteLine(dist);