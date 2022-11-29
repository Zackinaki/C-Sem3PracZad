Console.Clear();
Console.Write("Vvedite chislo N: ");

double n =Convert.ToDouble(Console.ReadLine());
for(double i=1;i<=n;i++)
Console.Write($"{Math.Pow(i,3)} ");