// See https://aka.ms/new-console-template for more information
public static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        return 0;
    }
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return (double)sum / numbers.Length;
}