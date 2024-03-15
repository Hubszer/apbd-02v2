// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAvg(int[] numb)
{
    int sum = 0;
    foreach (var num in numb)
    {
        sum += num;
    }

    return (double)sum / numb.Length;
}

int[] numbers = {1,2,3,4};
double avg = GetAvg(numbers);
Console.WriteLine(avg);
Console.WriteLine(avg);


static int FindMax(int[] numb)
{
    int max = numb[0];
    for (int i = 0; i < numb.Length; i++)
    {
        if (numb[i] > max)
        {
            max = numb[i];
        }
    }
}

int fMax = FindMax(numbers)
Console.WriteLine(fMax);