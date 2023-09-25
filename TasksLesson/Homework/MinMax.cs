namespace TasksLesson.Homework;

public class MinMax
{
    public static void Main(string[] args)
    {
        Minmax10(7, new[] { 800, 1, 0, -1, 0, 2, 3, -1, 4, 5 });
    }
	public static void Minmax1(int n, int[] num)
    {
        int min = num[0];
        int max = num[0];
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        Console.WriteLine(min + " " + max);
    }

    public static void Minmax2(int n, int[][] num)
    {
        var minimum = Enumerable.Range(0, n)
            .Select(i => num[i][0] * num[i][1])
            .Min();
        Console.WriteLine(minimum);
    }

    public static void Minmax3(int n, List<int[]> num)
    {
        var max = Enumerable.Range(0, n)
            .Select(i => num[i][0] * num[i][1])
            .Max();
        Console.WriteLine(max);
    }

    public static void Minmax4(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
                minIndex = i;
            }
        }
        Console.WriteLine(minIndex);
    }

    public static void Minmax5(int n, (int mass, int volume)[] details)
    {
        int max = 0;
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (details[i].mass / details[i].volume > max)
            {
                max = details[i].mass / details[i].volume;
                maxIndex = i;
            }
        }
        Console.WriteLine(maxIndex + " " + max);
    }

    public static void Minmax6(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (num[i] < min || i == 0)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] >= max || i == 0)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine($"First minimum: Index: {minIndex}, Number: {min}");
        Console.WriteLine($"Last maximum: Index: {maxIndex}, Number: {max}");
    }

    public static void Minmax7(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] <= min || i == 0)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max || i == 0)
            {
                max = num[i];
                maxIndex = i;
            }
        }
        Console.WriteLine($"Last minimum: Index: {minIndex}, Number: {min}");
        Console.WriteLine($"First maximum: Index: {maxIndex}, Number: {max}");
    }

    public static void Minmax8(int n, int[] num)
    {
        int min1 = num[0];
        int minIndex1 = 0;
        int min2 = num[0];
        int minIndex2 = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min1 || i == 0)
            {
                min1 = num[i];
                minIndex1 = i;
            }
            if (num[i] <= min2 || i == 0)
            {
                min2 = num[i];
                minIndex2 = i;
            }
        }

        Console.WriteLine($"First minimum: Index: {minIndex1}, Number: {min1}");
        Console.WriteLine($"Last minimum: Index: {minIndex2}, Number: {min2}");
    }

    public static void Minmax9(int n, int[] num)
    {
        int maxIndex1 = 0;
        int max1 = num[0];
        int maxIndex2 = 0;
        int max2 = num[0];

        for (int i = 1; i < n; i++)
        {
            if (num[i] > max1 || i == 0)
            {
                max1 = num[i];
                maxIndex1 = i;
            }

            if (num[i] >= max2 || i == 0)
            {
                max2 = num[i];
                maxIndex2 = i;
            }

        }

        Console.WriteLine($"First maximum: Index: {maxIndex1}, Number: {max1}");
        Console.WriteLine($"Last maximum: Index: {maxIndex2}, Number: {max2}");
    }

    public static void Minmax10(int n, int[] num)
    {
        int min = num[0];
        int minIndex = 0;
        int max = num[0];
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (num[i] < min || i == 0)
            {
                min = num[i];
                minIndex = i;
            }
            if (num[i] > max || i == 0)
            {
                max = num[i];
                maxIndex = i;
            }
        }

        if (minIndex < maxIndex)
        {
            Console.WriteLine($"First extremal: Index: {minIndex}, Number: {min}");
        }
        else
        {
            Console.WriteLine($"First extremal: Index: {maxIndex}, Number: {max}");
        }
    }
}