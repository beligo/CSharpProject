int n, m, s = 0;
Console.Write("Введите значение M: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение N: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 1 == 0)
        s = s + i;

}
Console.WriteLine(s);