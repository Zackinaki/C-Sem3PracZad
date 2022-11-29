Console.Clear();
Console.WriteLine("Vvedite koordinatu A v koordinatah xyz: ");
double x1=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu B v koordinatah xyz: ");
double x2=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
double z2=Convert.ToDouble(Console.ReadLine());

double result= Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.WriteLine($"Rasstoanie mezhdu tochkami v 3D prostranstve: {Math.Round(result,2)}");