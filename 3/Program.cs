//найти в массиве второй максимум

int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int[] CreateArray(int len, int minsize, int maxsize)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minsize, maxsize);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ",");
    }
    System.Console.WriteLine(array[array.Length - 1]);
}



int SearchMax2(int[]array, int max, int max2)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
    if (array[i]>max2&&array[i]<max)
    {
        max2=array[i];
    }
    }
    return max2;
}


int len = InputInt("введите размер массива");
int minsize = InputInt("введите минимальный порог значений массива");
int maxsize = InputInt("введите максимальный порог элементов массива");
int[] array = CreateArray(len, minsize, maxsize);
System.Console.WriteLine("сгенерированный массив:");
PrintArray(array);
int max2 = minsize;
int max = array[0];
max2 = SearchMax2(array,max,max2);
System.Console.WriteLine($"второе максимальное число массива = {max2}");