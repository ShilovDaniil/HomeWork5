// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
  Array[i] = new Random().Next(-100, 200);
  System.Console.Write(Array[i] + "; ");
}

System.Console.WriteLine("]");

int Task(int[] Array)
{
  int Sum = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (i % 2 != 0)
    {
      Sum += Array[i];
    }
  }
  return Sum;
}

System.Console.WriteLine($"Сумма элементов на нечетных позициях: {Task(Array)}");