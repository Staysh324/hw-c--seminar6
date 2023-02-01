double InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}





bool CheckParalel(double k1, double k2)
{
    if (k1 != k2)
    {
        return true;
    }
    System.Console.WriteLine("прямые параллельны");
    return false;
}


double SearchX(double k1, double b1, double k2, double b2)
{
    double num1 = (k1 - k2);
    double num2 = -(b1 - b2);
    double picX = num2 / num1;
    return picX;
}



double k1 = InputInt("введите k1");
double b1 = InputInt("введите b1");
double k2 = InputInt("введите k2");
double b2 = InputInt("введите b2");

if (CheckParalel(k1, k2))
{
    double x = SearchX(k1, b1, k2, b2);
    double y = k2 * (x) + b2;
    System.Console.WriteLine($"точка пересечения прямых = {x:f1};{y:f1}");
}