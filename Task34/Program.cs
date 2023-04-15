// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int CreateArray()
{
  System.Console.WriteLine("Введите длину массива: ");
  int x = int.Parse(System.Console.ReadLine());
  return x;
}

int[] Array = new int[CreateArray()];

System.Console.Write("[");

for (int i = 0; i < Array.Length; i++)
{
  Array[i] = new Random().Next(100, 1000);
  System.Console.Write( Array[i] + "; ");
}

System.Console.WriteLine("]");

int Task(int[] Array)
{
  int count = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if(Array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

System.Console.WriteLine($"Количество четных чисел в массиве: {Task(Array)}");