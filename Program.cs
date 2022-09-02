/* Задача 34: Задайте массив заполненный случайными
 положительными трёхзначными числами.
Напишите программу, которая покажет
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);                // Заполнить массив случайных чисел
Console.WriteLine("Массив из трёхзначных чисел: ");
PrintArray(array);
int a = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
a++;

Console.WriteLine($"всего {array.Length} чисел, {a} из них чётные");

void FillArrayRandomNumbers(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        array[j] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
} 



/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму
 элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

 Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив чисел: ");
PrintArray(array);
int sum  = 0;

for (int i = 0; i < array.Length; i+=2)
   sum = sum + array[i];

Console.WriteLine($"всего {array.Length} чисел, сумма: {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        array[j] = new Random().Next(1,10);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[12];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 12);
    Console.Write(array[i] + " ");
  }

double maxValue = array[0];
double minValue = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxValue < array[i])
    {
      maxValue = array[i];
    }
        if (minValue > array[i])
    {
      minValue = array[i];
    }
  }

  double arr = maxValue - minValue;

  Console.WriteLine($"разница между между максимальным ({maxValue}) и минимальным({minValue}) элементами: {arr}");