Random o = new Random();
List<int> A = new List<int>();
List<int> B = new List<int>();
List<int> C = new List<int>();
Console.Write("Введiть N (кiлькiсть чисел): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сформована колекцiя А: ");
for (int i = 0; i < N; i++)
{
    A.Add(o.Next(1, 11));
    Console.Write("{0} ", A[i]);
}
Console.WriteLine("\nСформована колекцiя B: ");
for (int i = 0; i < N; i++)
{
    B.Add(o.Next(1, 11));
    Console.Write("{0} ", B[i]);
}
for (int i = 0; i < N; i++)
{
    C.Add(A[i] + B[i]);
}
Console.WriteLine("\nКоллекцiя C (кожен елемент дорiвнює сумi двох елементiв з колекцiй A i B): ");
foreach (int chislo in C)
{
    Console.Write("{0} ", chislo);
}
