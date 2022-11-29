Console.Write("Vvedite chislo N(chislo kustov): ");
int n =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite kol-vo agod na kazhdom kustu: ");
int[] a = new int[n];
for (int i = 0; i < n; i++)
    a[i] = int.Parse(Console.ReadLine());

    int b=0;
    if(a[1]>a[n-2])
    b=a[0]+a[n-1]+a[1];
    else
    b=a[0]+a[n-1]+a[n-2];

    for(int i=1;i<n-1;i++)
    {
    if(a[i-1]+a[i]+a[i+1]>b)
    b=a[i-1]+a[i]+a[i+1];
    }

    Console.WriteLine($"Max chislo agod sobrano: {b}");
