namespace TasksLesson;

public class Lesson1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Integer8(123) = " + Integer8(123));
        Console.WriteLine("Integer27(5) = " + Integer27(5));
        Console.WriteLine("Boolean39(1, 1, 2, 2) = " + Boolean39(1, 1, 2, 2));
        Console.WriteLine("If18(3, 4, 5) = ");
        If18(3, 4, 5);

        Console.WriteLine("If27(3.5) = ");
        If27(3.5f);

        Console.WriteLine("For10(3) = ");
        For10(3);

        Console.WriteLine("For25(3, 3) = ");
        For25(3, 3);

        Console.WriteLine("While10(3) = ");
        While10(3);

        Console.WriteLine("Series23(3, new float[] {1, 2, 3}) = ");
        Series23(3, new float[] {1, 2, 3});

        Console.WriteLine("Proc28(3) = " + Proc28(3));
        Console.WriteLine("Proc29(3) = " + Proc29(3));

        Console.WriteLine("Minmax23(3, new int[] {1, 2, 3}) = ");
        Minmax23(3, new int[] {1, 2, 3});

        Console.WriteLine("Minmax28(4, new int[] {1, 2, 3, 4}) = ");
        Minmax28(4, new int[] {1, 2, 3, 4});

        Console.WriteLine("Array28(new int[] {1, 2, 3, 4}) = " + Array28(new int[] {1, 2, 3, 4}));
        Console.WriteLine("Array47(new int[] {1, 2, 3, 4}) = " + Array47(new int[] {1, 2, 3, 4}));
        Console.WriteLine("Array74(new int[] {1, 2, 3, 4}) = " + Array74(new int[] {1, 2, 3, 4}));
	}

	private static int Integer8(int a)
	{
		int b = a / 10 + a % 10 * 10;
		return b;
	}

	private static int Integer27(int m)
	{
		return ((m + 4) % 7) + 1;
	}

	private static bool Boolean39(int x1, int x2, int y1, int y2)
	{
		return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1 && (x1 != x2 || y1 != y2) && (x1 + y1) % 2 == (x2 + y2) % 2;
	}

	private static void If18(int a, int b, int c)
	{
		if (a == b)
		{
			Console.Write(3);
		}
		else if (a == c)
		{
			Console.Write(2);
		}
		else
		{
			Console.Write(1);
		}

		Console.WriteLine();
	}

	private static void If27(float x)
	{
		if (x < 0)
		{
			Console.Write(0);
		}
		else if (x >= 0 && x < 1 || x >= 2 && x < 3)
		{
			Console.Write(1);
		}
		else if(x >= 1 && x < 2 || x >= 3 && x < 4)
		{
			Console.Write(-1);
		}

		Console.WriteLine();
	}

	private static void For10(int n)
	{
		double sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += 1.0 / i;
		}
		Console.Write(sum);
		Console.WriteLine();
	}

	private static void For25(float x, int n)
	{
		float x1 = x;
		float result = x;
		int i;

		for (i = 2; i <= n; ++i) {
			x1 *= -1 * x;
			result += x1 / i;
		}
		Console.Write(result + " ");
		Console.Write(Math.Log(1 + x));
		Console.WriteLine();
	}

	private static void While10(int n)
	{
		int k = 0;
		int temp = 3;

		while (temp <= n)
		{
			temp *= 3;
			++k;
		}

		Console.Write(k);
		Console.WriteLine();
	}

	private static void Series23(int n, float[] numbers)
	{
		for (int i = 1; i < n - 1; i++)
		{
			if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
			{
				Console.Write(i);
				break;
			}
			else if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])
			{
				Console.Write(i);
				break;
			}
			else if (numbers[i] > numbers[i - 1] && numbers[i] < numbers[i + 1])
			{
				Console.Write(0);
				break;
			}
			else if (numbers[i] < numbers[i - 1] && numbers[i] > numbers[i + 1])
			{
				Console.Write(0);
				break;
			}
		}

		Console.WriteLine();
	}

	private static bool Proc28(int N)
	{
		if (N <= 1)
		{
			return false;
		}
		for (int i = 2; i < N; i++)
		{
			if (N % i == 0)
			{
				return false;
			}
		}
		return true;
	}

	private static int Proc29(int K)
	{
		int count = 0;
		while (K > 0)
		{
			count++;
			K /= 10;
		}
		return count;
	}

	private static void Minmax23(int n, int[] num)
	{
		int max = num[0];
		int maxIndex = 0;
		for (int i = 1; i < n; i++)
		{
			if (num[i] > max)
			{
				max = num[i];
				maxIndex = i;
			}
		}

		int max2 = num[0];
		int maxIndex2 = 0;
		for (int i = 1; i < n; i++)
		{
			if (num[i] > max2 && i != maxIndex)
			{
				max2 = num[i];
				maxIndex2 = i;
			}
		}

		int max3 = num[0];
		int maxIndex3 = 0;
		for (int i = 1; i < n; i++)
		{
			if (num[i] > max3 && i != maxIndex && i != maxIndex2)
			{
				max3 = num[i];
				maxIndex3 = i;
			}
		}
		Console.Write(max + " " + max2 + " " + max3);
		Console.WriteLine();
	}

	private static void Minmax28(int n, int[] num)
	{
		int max = 0;
		int count = 0;
		int index = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] == 1)
			{
				count++;
			}
			else
			{
				if (count > max)
				{
					max = count;
					index = i - count;
				}
				count = 0;
			}
		}
		if (count > max)
		{
			max = count;
			index = n - count;
		}
		Console.Write(index + " " + max);
		Console.WriteLine();
	}

	private static int Array28(int[] array)
	{
		int k = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (i % 2 == 0)
			{
				if (array[i] < array[k])
				{
					k = i;
				}
			}
		}
		return array[k];
	}

	private static int Array47(int[] array)
	{
		int k = 0;
		for (int i = 0; i < array.Length - 1; i++)
		{
			if (array[i] != array[i + 1])
			{
				k++;
			}
		}
		return k;
	}

	private static string Array74(int[] array)
	{
		int minIndex = 0;
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] < array[minIndex])
			{
				minIndex = i;
			}
		}

		int maxIndex = 0;
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > array[maxIndex])
			{
				maxIndex = i;
			}
		}

		for (int i = minIndex; i < maxIndex; i++)
		{
			array[i] = 0;
		}

		string str = "";

		for (int i = 0; i < array.Length; i++)
		{
			str += array[i] + " ";
		}

		return str;
	}
}