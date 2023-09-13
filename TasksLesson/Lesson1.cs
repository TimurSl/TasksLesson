namespace TasksLesson;

public class Lesson1
{
	public static void Main(string[] args)
	{
		foreach(int i in Array74(new []{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }))
		{
            Console.Write(i + " ");
		}

		Console.WriteLine();
	}

	private static int Integer8(int ab)
	{
		int a = ab / 10;
		int b = (ab % 10) * 10;
		return b + a;
	}

	private static int Integer27(int m)
	{
		return ((m + 4) % 7) + 1;
	}

	private static bool Boolean39(int x1, int x2, int y1, int y2)
	{
		int xDistance = Math.Abs(x1 - x2);
		int yDistance = Math.Abs(y1 - y2);
		bool xyNotIdentical = (x1 != x2) || (y1 != y2);
		bool sumModuloIdentical = (x1 + y1) % 2 == (x2 + y2) % 2;

		bool result = xDistance <= 1 && yDistance <= 1 && xyNotIdentical && sumModuloIdentical;
		return result;
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

		Console.WriteLine ();
	}

	private static int If27(float x)
	{
		if (x < 0)
		{
			return 0;
		}
		else if (x >= 0 && x < 1 || x >= 2 && x < 3)
		{
			return 1;
		}
		else if (x >= 1 && x < 2 || x >= 3 && x < 4)
		{
			return -1;
		}

		return 0;
	}

	private static void For10(int n)
	{
		double sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += 1.0 / i;
		}

		Console.Write(sum);
		Console.WriteLine ();
	}

	private static void For25(float x, int n)
	{
		float x1 = x;
		float result = x;
		int i;

		for (i = 2; i <= n; ++i)
		{
			x1 *= -1 * x;
			result += x1 / i;
		}

		Console.Write(result + " ");
		Console.Write(Math.Log(1 + x));
		Console.WriteLine ();
	}

	private static int While10(int n)
	{
		int k = 0;
		int temp = 3;

		while (temp < n)
		{
			temp *= 3;
			++k;
		}

		return k;
	}

	private static int Series23(int n, float[] numbers)
	{
		for (int i = 1; i < n - 1; i++)
		{
			if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
			{
				return i;
			}
			else if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])
			{
				return i;
			}

			return 0;
		}

		return 0;
	}


	private static int Proc28(int[] numbers)
	{
		int primesAmount = 0;

		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i].IsPrime ())
			{
				primesAmount++;
			}
		}

		return primesAmount;
	}

	private static int Proc29(int[] numbers)
	{
        int digitsAmount = 0;

		for (int i = 0; i < numbers.Length; i++)
		{
			digitsAmount += DigitN (numbers[i]);
		}

		return digitsAmount;
	}

	private static int DigitN(int k)
	{
		int count = 0;
		while (k > 0)
		{
			k /= 10;
			count++;
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
		Console.WriteLine ();
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
		Console.WriteLine ();
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
			if (!array.Contains(array[i]))
			{
				k++;
			}
		}

		return k;
	}

	private static int[] Array74(int[] array)
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

		for (int i = minIndex + 1; i < maxIndex; i++)
		{
			array[i] = 0;
		}
		int tempMin = minIndex;

		tempMin = Math.Min(minIndex, maxIndex);
		maxIndex = Math.Max(minIndex, maxIndex);

		minIndex = tempMin;

		for (int i = minIndex + 1; i < maxIndex; i++)
		{
			array[i] = 0;
		}

		return array;

	}
}

