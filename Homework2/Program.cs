//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumber(int N)
{
    int counter = Convert.ToInt32(N);
    int A = 0;
    int res = 0;
    for (int i = 0; i < counter; i++)
    {
        A = N - N % 10;
        res = res + (N - A);
        N = N / 10;
    }
    return res;
}
int sumNumber = SumNumber(N);
Console.WriteLine(sumNumber);