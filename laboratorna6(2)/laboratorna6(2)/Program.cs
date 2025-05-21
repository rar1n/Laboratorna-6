Random o = new Random();
List<int> chisla2 = new List<int>();
Console.Write("Введiть N (кiлькiсть чисел): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сформована колекцiя: ");
for (int i = 0; i < N; i++)
{
    chisla2.Add(o.Next(5, 51));
    Console.Write("{0} ", chisla2[i]);
}
for (int i = chisla2.Count - 1; i >= 0; i--)
{
    if (chisla2[i] % 2 != 0)
    {
        chisla2.Insert(i, -1);
        break;
    }
}
Console.WriteLine("\nКолекцiя пiсля вставки -1 перед останнiм непарним числом: ");
foreach (int chislo in chisla2)
{
    Console.Write("{0} ", chislo);
}