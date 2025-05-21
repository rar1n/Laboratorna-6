Random o = new Random();
List<int> chisla1 = new List<int>();
Console.Write("Введiть N (кiлькiсть чисел): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сформована колекцiя: ");
for (int i = 0; i < N; i++)
{
    chisla1.Add(o.Next(-5, 6));
    Console.Write("{0} ", chisla1[i]);
}
Console.WriteLine("\nКолекцiя пiсля видалення негативних чисел: ");
for (int i = chisla1.Count - 1; i >= 0; i--)
{
    if (chisla1[i] < 0)
    {
        chisla1.RemoveAt(i);
    }
}
foreach (int chislo in chisla1)
{
    Console.Write("{0} ", chislo);
}