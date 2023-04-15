// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов
//  массива.

// [3 7 22 2 78] -> 76


//Не понимаю в чем ошибка (как переделать синтаксис), понимаю, что само решение верно :(

double CreateArray()
{
  System.Console.WriteLine("Введите длину массива: ");
  double x;
  while (!double.TryParse(System.Console.ReadLine(), out x))
  {
    System.Console.WriteLine("Error!");
  }
  return x;
}

double[] Array = new double[CreateArray()];

System.Console.Write("[");

for (int i = 0; i < Array.Length; i++)
{
  Array[i] = new Random().Next(0, 100);
  System.Console.Write(Array[i] + "; ");
}

System.Console.WriteLine("]");

double Task(double[] Array)
{
  double min = 0;
  double max = 0;
  double Sum = 0;
  for (int i = 0; i < Array.Length -1; i++)
  {
    if(i < Array.Length - 1 && Array[i] > Array[i + 1])
    {
      max = Array[i];
      min = Array[i + 1];
    }
    else
    {
      max = Array[i + 1];
      min = Array[i];
    }
  }
  Sum = max - min;
  return Sum;
}

System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Task(Array)}");