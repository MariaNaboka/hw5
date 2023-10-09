int[] array = new int[10];
int min = 0;
int max = 20;

Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(min, max);
    Console.Write(" " + array[i]);
}

int minElement = array[0];
int maxElement = array[array.Length - 1];
for (int i = 0; i < array.Length; i++)
{
    if (minElement > array[i]) minElement = array[i];
    if (maxElement < array[i]) maxElement = array[i];
}

Console.WriteLine("");
String result = Convert.ToString( maxElement - minElement);
Console.WriteLine("Разница: " + result);