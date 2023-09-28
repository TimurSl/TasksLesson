namespace TasksLesson.Homework;

public class Series
{
	public static void Series1(int[] numbers)
	{
		int sum = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			sum += numbers[i];
		}

		Console.WriteLine(sum);
	}

	public static void Series2(float[] numbers)
	{
		float sum = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			sum *= numbers[i];
		}

		Console.WriteLine(sum);
	}

	public static void Series3(int[] numbers)
	{
		int sum = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			sum += numbers[i];
		}

		Console.WriteLine(sum / numbers.Length);
	}

	public static void Series4(int n, int[] numbers)
	{
		double sum = 0;
		double pro = 1;

		for (int i = 1; i <= n; i++)
		{
			sum += numbers[i];
			pro *= numbers[i];
		}

		Console.WriteLine("Сумма: {0}", sum);
		Console.WriteLine("Произведение: {0}", pro);
	}

	public static void Series5(int N, float[] numbers)
	{
		float sum = 0;
		for (int i = 0; i < N; i++)
		{
			numbers[i] = MathF.Round(numbers[i], 0);
			sum += numbers[i];
			Console.WriteLine(numbers[i]);
		}

		Console.WriteLine(sum);
	}

	public static void Series6(int N, float[] numbers)
	{
		float sum = 0;
		for (int i = 0; i < N; i++)
		{
			numbers[i] -= MathF.Round(numbers[i], 0);
			sum *= numbers[i];
			Console.WriteLine(numbers[i]);
		}

		Console.WriteLine(sum);
	}

	public static void Series7(int N, float[] numbers)
	{
		int sum = 0;
		for (int i = 0; i < N; i++)
		{
			numbers[i] = MathF.Round(numbers[i], 0);
			sum += (int) numbers[i];
			Console.WriteLine(numbers[i]);
		}

		Console.WriteLine(sum);
	}

	public static void Series8(int N, int[] numbers)
	{
		int K = 0;
		for (int i = 0; i < N; i++)
		{
			if (numbers[i].IsEven ())
			{
				K++;
				Console.WriteLine(numbers[i]);
			}
		}

		Console.WriteLine(K);
	}

	public static void Series9(int N, int[] numbers)
	{
		int K = 0;
		for (int i = 0; i < N; i++)
		{
			if (numbers[i].IsOdd ())
			{
				K++;
				Console.WriteLine(numbers[i]);
			}
		}

		Console.WriteLine(K);
	}

	public static void Series10(int N, int[] numbers)
	{
		bool positive = false;
		for (int i = 0; i < N; i++)
		{
			if (numbers[i].IsPositive ())
			{
				positive = true;
			}
		}

		Console.WriteLine(positive);
	}

	public static void Series11(int n, int k, int[] numbers)
	{
		bool status = false;
		for (int i = n; i <= n; i++)
		{
			if (numbers[i] < k)
			{
				status = true;
			}
		}

		Console.WriteLine(status);
	}

	public static void Series12(int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				Console.WriteLine(i);
				break;
			}
		}
	}

	public static void Series13(int[] numbers)
	{
		int sum = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				break;
			}

			if (numbers[i].IsPositive () && numbers[i].IsEven ())
			{
				sum += numbers[i];
			}
		}

		Console.WriteLine(sum);
	}

	public static void Series14(int[] numbers, int k)
	{
		int count = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				break;
			}

			if (numbers[i] < k)
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series15(int[] numbers, int k)
	{
		int count = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				break;
			}

			if (numbers[i] > k)
			{
				count = i;
				break;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series16(int[] numbers, int k)
	{
		int count = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				Console.WriteLine(i);
				break;
			}

			if (numbers[i] > k)
			{
				count = i;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series17(float[] numbers, float b, float n)
	{
		bool isAlreadyWritten = false;

		for (int i = 1; i <= n; i++)
		{
			if ((b <= numbers[i]) && !isAlreadyWritten)
			{
				Console.WriteLine(b);
				isAlreadyWritten = true;
			}

			Console.WriteLine(numbers[i]);
		}

		if (!isAlreadyWritten)
		{
			Console.WriteLine(b);
		}
	}

	public static void Series18(int[] numbers, int n)
	{
		var uniqueNumbers = new HashSet<int> ();
		for (int i = 0; i < n; i++)
		{
			uniqueNumbers.Add(numbers[i]);
		}

		foreach(var number in uniqueNumbers)
		{
			Console.WriteLine(number);
		}
	}

	public static void Series19(int[] numbers, int n)
	{
		int count = 0;
		for (int i = 1; i < n; i++)
		{
			if (numbers[i] < numbers[i - 1])
			{
				Console.WriteLine(numbers[i]);
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series20(int[] numbers, int n)
	{
		int count = 0;
		for (int i = 0; i < n - 1; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				Console.WriteLine(numbers[i]);
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series21(int n, float[] numbers)
	{
		bool status = false;
		for (int i = 0; i < n - 1; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				status = true;
			}
			else
			{
				status = false;
				break;
			}
		}

		Console.WriteLine(status);
	}

	public static void Series22(int n, float[] numbers)
	{
		for (int i = 0; i < n - 1; i++)
		{
			if (numbers[i] > numbers[i + 1])
			{
				Console.WriteLine(i + 1);
				break;
			}

			if (numbers[i] < numbers[i + 1])
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series23(int n, float[] numbers)
	{
		for (int i = 1; i < n - 1; i++)
		{
			bool isPeak = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
			bool isTrough = numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1];
			bool isIncreasing = numbers[i] > numbers[i - 1] && numbers[i] < numbers[i + 1];
			bool isDecreasing = numbers[i] < numbers[i - 1] && numbers[i] > numbers[i + 1];

			if (isPeak || isTrough)
			{
				Console.WriteLine(i);
				break;
			}

			if (isIncreasing || isDecreasing)
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series24(int n, int[] numbers)
	{
		int sum = 0;
		int tempsum = 0;

		for (int i = 1; i <= n; i++)
		{
			tempsum += numbers[i];
			if (numbers[i] == 0)
			{
				sum = tempsum;
				tempsum = 0;
			}
		}

		Console.WriteLine(sum);
	}

	public static void Series25(int n, int[] numbers)
	{
		int sum = 0;
		int tempsum = 0;
		int f = 0;

		for (int i = 1; i <= n; ++i)
		{
			tempsum += numbers[i];
			if (numbers[i] == 0)
			{
				if (f != 0)
				{
					sum += tempsum;
				}
				else
				{
					f = 1;
				}

				tempsum = 0;
			}
		}
	}

	public static void Series26(int n, int k, float[] numbers)
	{
		for (int i = 0; i < n; i++)
		{
			float result = 1;
			for (int j = 0; j < k; j++)
			{
				result *= numbers[i];
			}

			Console.WriteLine(result);
		}
	}

	public static void Series27(int n, float[] numbers)
	{
		for (int i = 1; i <= n; i++)
		{
			float result = 1;
			for (int j = 1; j < i; j++)
			{
				result *= numbers[i];
			}

			Console.WriteLine(result);
		}
	}

	public static void Series28(int n, float[] numbers)
	{
		for (int i = 1; i <= n; i++)
		{
			float result = 1;
			for (int j = 1; j < n - i + 1; j++)
			{
				result *= numbers[i];
			}

			Console.WriteLine(result);
		}
	}

	public static void Series29(int n, int k, int[] numbers)
	{
		int sum = 0;
		for (int i = 0; i < n * k; i++)
		{
			sum += numbers[i];
		}

		Console.WriteLine(sum);
	}

	public static void Series30(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			int sum = 0;
			for (int j = 0; j < n; j++)
			{
				sum += numbers[i];
			}

			Console.WriteLine(sum);
		}
	}

	public static void Series31(int n, int k, int kount)
	{
		int count = 0;
		for (int i = 0; i < n * k; i++)
		{
			if (kount == 2)
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series32(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] == 2)
			{
				Console.WriteLine(i);
				break;
			}

			if (numbers[i] != 2)
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series33(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] == 2)
			{
				Console.WriteLine(i);
				break;
			}

			if (numbers[i] != 2)
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series34(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] == 2)
			{
				int sum = 0;
				for (int j = 0; j < n; j++)
				{
					sum += numbers[i];
				}

				Console.WriteLine(sum);
				break;
			}

			if (numbers[i] != 2)
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series35(int n, int k, int[] numbers)
	{
		int count = 0;
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] == 0)
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series36(int n, int k, int[] numbers)
	{
		int count = 0;
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series37(int n, int k, int[] numbers)
	{
		int count = 0;
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series38(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				Console.WriteLine(1);
				break;
			}

			if (numbers[i] > numbers[i + 1])
			{
				Console.WriteLine(-1);
				break;
			}

			if (numbers[i] == numbers[i + 1])
			{
				Console.WriteLine(0);
				break;
			}
		}
	}

	public static void Series39(int n, int k, int[] numbers)
	{
		int count = 0;
		for (int i = 0; i < n * k; i++)
		{
			if (numbers[i] < numbers[i + 1])
			{
				count++;
			}
		}

		Console.WriteLine(count);
	}

	public static void Series40(int n, int k, int[] numbers)
	{
		for (int i = 0; i < n * k; i++)
		{
			if ((numbers[i] < numbers[i + 1] && numbers[i + 1] > numbers[i + 2]) ||
			    (numbers[i] > numbers[i + 1] && numbers[i + 1] < numbers[i + 2]) ||
			    (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2]))
			{
				Console.WriteLine(numbers[i]);
			}
			else
			{
				Console.WriteLine(0);
			}
		}
	}
}