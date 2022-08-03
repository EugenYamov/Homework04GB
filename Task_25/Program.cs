// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int A = Int32.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Int32.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
}

Console.WriteLine($"Число {A} в степени {B} = {result}");
