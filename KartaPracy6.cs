// zadanie 4
/*int suma = 0;
int l1 = 0;
int l2 = 0;
for (int i = 10; i < 100; i++)
{
    l1 = i % 10;
    l2 = i % 100 - l1;
    l2 /= 10;
    if (l2 >= l1 * 2)
    {
        suma++;
    }
}
Console.WriteLine(suma);*/
// zad 5
/*int ile= 0;
int suma = 0;
int l3 = 0;
int l2 = 0;
int l1 = 0;
for (int i = 100; i < 1000; i++)
{
    l1 = i % 10;
    l2 = ((i % 100) - l1) / 10;
    l3 = ((i % 1000)-l1 - l2) / 100;
    if (l3 > l1 + l2)
    {
        suma += i;
        ile++;
    }
}
Console.WriteLine(suma);
Console.WriteLine(ile);*/
// zad 6
/*int n  = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = n; i < 100; i++)
{
    if (i % 19 == 0)
    {
        suma++;
    }
}
Console.WriteLine(suma);*/
// zad 7
/*int max = 0;
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 37 == 0 && max < n)
    {
        suma+= i;
        max++;
    }
}
Console.WriteLine(suma);*/
// zad 8
/*int n = int.Parse(Console.ReadLine());
int suma = 0;
int l1 = 2;
for (int i = 0; i < n;i++)
{
    Console.WriteLine(l1);
    if (l1 >= 0)
    {
        l1 += 3;
        l1 *= -1;
    }
    else
    {
        l1 -= 3;
        l1 *= -1;
    }
    
}*/
// zad 9
/*int n = int.Parse(Console.ReadLine());
int l1 = 1;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(l1);
    l1 *= -2;
}*/
