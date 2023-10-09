int[] array = new int[10];

Random randNum = new Random();
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next();
    Console.Write("  " + array[i]);
    if (array[i] % 2 == 0)
        counter++;
}

Console.WriteLine("");
Console.WriteLine("Число четных: " + counter);