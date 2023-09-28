namespace TasksLesson.Homework;

public class MinMax
{
	public static void Main(string[] args)
	{
		Minmax11(7, new[] {800, 1, 0, -1, 0, 2, 3, -1, 4, 5});
	}

	public static void Minmax1(int n, int[] num)
	{
		int min = num[0];
		int max = num[0];
		for (int i = 0; i < n; i++)
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
			.Min ();
		Console.WriteLine(minimum);
	}

	public static void Minmax3(int n, List<int[]> num)
	{
		var max = Enumerable.Range(0, n)
			.Select(i => num[i][0] * num[i][1])
			.Max ();
		Console.WriteLine(max);
	}

	public static void Minmax4(int n, int[] num)
	{
		int min = num[0];
		int minIndex = 0;
		for (int i = 0; i < n; i++)
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
		for (int i = 0; i < n; i++)
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
		for (int i = 0; i < n; i++)
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

		for (int i = 0; i < n; i++)
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
		for (int i = 0; i < n; i++)
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

		Console.WriteLine(minIndex < maxIndex
			? $"First extremal: Index: {minIndex}, Number: {min}"
			: $"First extremal: Index: {maxIndex}, Number: {max}");
	}

	public static void Minmax11(int n, int[] num)
	{
		int min = num[0];
		int minIndex = 0;
		int max = num[0];
		int maxIndex = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] <= min || i == 0)
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

		Console.WriteLine(minIndex > maxIndex ? minIndex : maxIndex);
	}

	public static void Minmax12(int n, int[] num)
	{
		int min = num[0];
		for (int i = 0; i < n; i++)
		{
			if ((num[i] < min && num[i] > 0) || min < 0)
			{
				min = num[i];
			}
		}

		Console.WriteLine(min);
	}

	public static void Minmax13(int n, int[] num)
	{
		int max = 0;
		int maxIndex = 0;
		for (int i = 0; i < n; i++)
		{
			if ((num[i].IsOdd () && num[i] > max) || i == 0)
			{
				max = num[i];
				maxIndex = i;
			}
		}

		Console.WriteLine(maxIndex);
	}

	public static void Minmax14(int n, int[] num, int b)
	{
		int min = num[0];
		int minIndex = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] > b && (num[i] < min || min == 0))
			{
				min = num[i];
				minIndex = i;
			}
		}

		Console.WriteLine(minIndex + " " + min);
	}

	public static void Minmax15(int n, int[] num, int b, int c)
	{
		int max = 0;
		int maxIndex = 0;
		for (int i = 0; i < n; i++)
		{
			if (b < num[i] && num[i] < c && (num[i] > max || max == 0))
			{
				max = num[i];
				maxIndex = i;
			}
		}

		Console.WriteLine(maxIndex + " " + max);
	}

	public static void Minmax16(int n, int[] num)
	{
		int min = num[0];
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] < min)
			{
				min = num[i];
				count = i;
			}
		}

		Console.WriteLine(count - 1);
	}

	public static void Minmax17(int n, int[] num)
	{
		int max = num[0];
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] >= max || i == 0)
			{
				max = num[i];
				count = i;
			}
		}

		Console.WriteLine(n - count);
	}

	public static void Minmax18(int n, int[] num)
	{
		int max = num[0];
		int count = 0;
		int resultCount = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] > max || i == 1)
			{
				max = num[i];
				count = i;
				resultCount = 0;
			}
			else if (num[i] == max)
			{
				resultCount = i - 1 - count;
			}
		}

		Console.WriteLine(resultCount - count - 1);
	}

	public static void Minmax19(int n, int[] num)
	{
		int min = num[0];
		int minCount = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] < min || i == 0)
			{
				min = num[i];
				minCount = i;
			}

			if (num[i] == min)
			{
				minCount++;
			}
		}

		Console.WriteLine(minCount);
	}

	public static void Minmax20(int n, int[] num)
	{
		int min = num[0];
		int minCount = 0;
		int max = num[0];
		int maxCount = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i] < min || i == 1)
			{
				min = num[i];
				minCount = 0;
			}

			if (num[i] > max || i == 1)
			{
				max = num[i];
				maxCount = 0;
			}

			if (num[i] == min)
			{
				minCount++;
			}
			else if (num[i] == max)
			{
				maxCount++;
			}
		}


		Console.WriteLine(minCount + maxCount);
	}

	public static void Minmax21(int n, int[] num)
	{
		int min = num[0];
		int minIndex = 0;
		int max = num[0];
		int maxIndex = 0;

		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			if (i == 1)
			{
				min = num[i];
				minIndex = 0;
				max = num[i];
				maxIndex = 0;
			}

			if (num[i] < min)
			{
				if (min != max) sum += min * minIndex;
				min = num[i];
				minIndex = 0;
			}

			if (num[i] > max)
			{
				if (max != min) sum += max * maxIndex;
				max = num[i];
				maxIndex = 0;
			}

			if (num[i] == min)
			{
				minIndex++;
			}
			else if (num[i] == max)
			{
				maxIndex++;
			}
			else
			{
				sum += num[i];
			}
		}

		Console.WriteLine(sum / (n - 2));
	}

	public static void Minmax22(int n, int[] num)
	{
		int min1 = num[0];
		int min2 = num[0];

		for (int i = 0; i < n; i++)
		{
			if (i == 1)
			{
				min1 = num[i];
				min2 = num[i];
			}

			if (num[i] < min2 && num[i] != min1)
			{
				if (num[i] < min1)
				{
					min2 = min1;
					min1 = num[i];
				}
				else min2 = num[i];
			}

			if (min1 == min2)
			{
				min2 = num[i];
			}
		}


		Console.WriteLine(min1 + " " + min2);
	}

	public static void Minmax23(int n, int[] num)
	{
		int max1 = num[0];

		int max2 = num[0];

		int max3 = num[0];

		for (int i = 0; i < n; i++)
		{
			if (i == 1)
			{
				max1 = num[i];
				max2 = num[i];
				max3 = num[i];
			}

			if (num[i] > max3 && num[i] != max1 && num[i] != max2)
			{
				if (num[i] > max2)
				{
					if (num[i] > max1)
					{
						max3 = max2;
						max2 = max1;
						max1 = num[i];
					}
					else
					{
						max3 = max2;
						max2 = num[i];
					}
				}
				else max3 = num[i];
			}

			if (max1 == max2)
			{
				max2 = num[i];
			}

			if (max3 == max1 || max3 == max2)
			{
				max3 = num[i];
			}
		}


		Console.WriteLine(max1 + " " + max2 + " " + max3);
	}

	public static void Minmax24(int n, int[] num)
	{
		int maxSum = 0;
		int previousNumber = 0;
		for (int i = 0; i < n - 1; i++)
		{
			if (i == 2)
			{
				maxSum = previousNumber + num[i];
			}

			if (num[i] + previousNumber > maxSum)
			{
				maxSum = previousNumber + num[i];
			}
		}

		Console.WriteLine(maxSum);
	}

	public static void Minmax25(int n, int[] num)
	{
		int minMultiply = 0;
		int minIndex = 0;
		int previousNumber = 0;
		for (int i = 0; i < n - 1; i++)
		{
			if (i == 2 || num[i] * previousNumber < minMultiply)
			{
				minMultiply = previousNumber * num[i];
				minIndex = i;
			}
		}

		Console.WriteLine(minIndex + " " + (minIndex - 1));
	}

	public static void Minmax26(int n, int[] num)
	{
		int max = 0;
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			if (num[i].IsEven ())
			{
				count++;
			}
			else
			{
				if (count > max)
				{
					max = count;
				}

				count = 0;
			}
		}

		if (count > max)
		{
			max = count;
		}

		Console.WriteLine(max);
	}

	public static void Minmax27(int n, int[] num)
	{
		int max = 0;

		int count = 0;
		int index = 0;


		int previousNumber = 0;

		for (int i = 0; i < n; i++)
		{
			if (previousNumber == num[i]) ++count;
			else
			{
				if (count > max)
				{
					max = count;
				}

				index = i;
				count = 1;
			}
		}

		if (count > max)
		{
			max = count;
		}

		Console.WriteLine(index + " " + max);
	}

	public static void Minmax28(int n, int[] num)
	{
		int max = 0;
		int maxIndex = 0;
		int count = 0;
		int index = 0;

		int i;
		for (i = 0; i < n; i++)
		{
			if (num[i] == 1)
			{
				count++;
				maxIndex = index;
			}
			else
			{
				if (count >= max)
				{
					max = count;
				}

				index = i + 1;
				count = 0;
			}
		}

		if (count >= max && num[i] == 0)
		{
			max = count;
			maxIndex = index;
		}

		Console.WriteLine(maxIndex + " " + max);
	}

	public static void Minmax29(int n, int[] num)
	{
		int min = num[0];
		int count = 1;
		int max = 1;

		for (int i = 0; i < n; i++)
		{
			if (i == 1 || num[i] < min)
			{
				min = num[i];
				count = 0;
				max = 0;
			}

			if (num[i] == min)
			{
				count++;
			}
			else
			{
				if (count > max)
				{
					max = count;
				}

				count = 0;
			}
		}


		if (count > max && num[n - 1] == min)
		{
			max = count;
		}

		Console.WriteLine(max);
	}

	public static void Minmax30(int n, int[] num)
	{
		int max = num[0];

		int count = 1;
		int min = 1;

		for (int i = 0; i < n; i++)
		{
			if (i == 1 || num[i] > max)
			{
				max = num[i];
				count = 0;
				min = n;
			}

			if (num[i] == max)
			{
				count++;
			}
			else
			{
				if (count < min)
				{
					min = count;
				}

				count = 0;
			}
		}

		if (count < min && num[n - 1] == max)
		{
			min = count;
		}

		Console.WriteLine(min);
	}
}