// задача 2

void ex1(int number1, number2)
{
    if (number1 > number2)

    {
       Console.WriteLine($"{number1} greater than {number2}");
    }
    else if (number2 > number1)
    {
       Console.WriteLine($"{number2} greater than {number1}");
    }
    else
    {
    Console.WriteLine("numders are equal");
    }
}

// задача 4

void ex2(int number1, int number2, int number3)
{
    int[] array = {mumber1, number2, number3};
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"max = {max}");
}

// задача 6

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
  {
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
  }
else
  {
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
  }
