int[] array = new int[5];
int min = 0;
int max = 20;

Random randNum = new Random();
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(min, max);
    Console.Write("  " + array[i]);
    if (array[i] % 2 != 0)
        counter = counter + array[i];
}

Console.WriteLine("");
Console.WriteLine("Сумма нечетных: " + counter);