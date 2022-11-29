Console.Clear();
Console.WriteLine("Vvedite patizhnachnoe chislo: ");
int n=Convert.ToInt32(Console.ReadLine());
int a=n/1000;
//Console.WriteLine(a);
int b=n%10;
//Console.WriteLine(b);
int c=(n/10)%10+b*10;

//Console.WriteLine(c);

if(c==a)
Console.WriteLine("Chislo avlatsa Palindromom");
else
Console.WriteLine("Chislo ne avlatsa Palindromom");