int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}



void PullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"задайте {i} элемени массива: ");
        string? num = Console.ReadLine();
        int elementofmass = Convert.ToInt32(num);
        array[i] = elementofmass;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
}

int SumPositive(int[] array)
{
    int positiveNum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0)
        {
            positiveNum += 1;
        }
    }
    return positiveNum;
}

int len = InputInt("введите размер массива");
int[] array = new int[len];
PullArray(array);
System.Console.WriteLine("заданный массив");
PrintArray(array);
int sumpos = SumPositive(array);
System.Console.WriteLine($"количество введенных положительных чисел: {sumpos}");