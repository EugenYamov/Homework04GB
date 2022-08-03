// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int userNumber = Int32.Parse(Console.ReadLine());
int sizeNumber = userNumber; // Переменная для нахождения размера массива
int number = userNumber; // Переменная для вычисления суммы элементов массива
int size = 0;

// Вычисляем требуемый размер массива

for (size = 0; sizeNumber > 0; size++)
{
    sizeNumber = sizeNumber / 10; 
}

// Создаем массив с нужным размером и записываем в него результаты вычислений

int[] result = new int[size];

for (int i = 0; number > 0; i++)
{
    result[i] = number % 10;
    number = number / 10; 
}

// Печатаем результат с помощью метода нахождения суммы элементов массива

Console.WriteLine($"Сумма цифр числа {userNumber} равна {result.Sum()}");