namespace TasksLesson.Homework;

public class Array
{
	public static void Main(string[] args)
	{

	}

	public static bool IsLocalMinimum(int[] array, int index)
	{
		if (index == 0 || index == array.Length - 1)
		{
			return false;
		}
		return array[index] < array[index - 1] && array[index] < array[index + 1];
	}

	public static bool IsLocalMaximum(int[] array, int index)
	{
		if (index == 0 || index == array.Length - 1)
		{
			return false;
		}
		return array[index] > array[index - 1] && array[index] > array[index + 1];
	}

	public static void LogArray(int[] array)
	{
		Console.WriteLine(ArrayToString(array));
	}

	public static string ArrayToString(int[] array)
	{
		string s = "";
		for (int i = 0; i < array.Length; i++)
		{
			s += array[i] + " ";
		}

		return s;
	}

	public static int[] Range(int a, int b = 0)
	{
		int[] array = new int[Math.Abs(a - b)];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + Math.Min(a, b);
		}

		return array;
	}

	public static int[] Array1(int n)
	{
		int[] array = new int[n];
		for (int i = 0; i < n; i++)
		{
			array[i] = i * 2 + 1;
		}

		return array;
	}

	public static int[] Array2(int n)
	{
		int[] array = new int[n];
		array[0] = 2;
		for (int i = 1; i < n; i++)
		{
			array[i] = array[i - 1] * 2;
		}

		return array;
	}

	public static int[] Array3(int n, int a, int d)
	{
		int[] array = new int[n];
		for (int i = 0; i < n; i++)
		{
			array[i] = a + i * d;
		}

		return array;
	}

	public static int[] Array4(int n, int a, int d)
	{
		int[] array = new int[n];
		int pow = 1;
		for (int i = 0; i < n; i++)
		{
			pow *= d;
			array[i] = a * pow;
		}

		return array;
	}

	public static int[] Array5(int n)
	{
		int[] array = new int[n];
		array[0] = 1;
		array[1] = 1;
		for (int i = 2; i < n; i++)
		{
			array[i] = array[i - 2] + array[i - 1];
		}

		return array;
	}

	public static int[] Array6(int n, int a, int b)
	{
		int[] array = new int[n];
		array[0] = a;
		array[1] = b;

		for (int i = 2; i < n; i++)
		{
			array[i] = 0;
			for (int j = 0; j < i; ++j)
			{
				array[i] += array[j];
			}
		}

		return array;
	}

	public static int[] Array7(int n)
	{
		int[] array = Range(n).Reverse ().ToArray ();
		return array;
	}

	public static int[] Array8(int[] array)
	{
		HashSet<int> oddHashSet = new HashSet<int> ();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].IsOdd ())
			{
				oddHashSet.Add(array[i]);
			}
		}


		return oddHashSet.ToArray ();
	}

	public static int[] Array9(int[] array)
	{
		HashSet<int> evenHashSet = new HashSet<int> ();
		for (int i = array.Length - 1; i >= 0; i--)
		{
			if (array[i].IsEven ())
			{
				evenHashSet.Add(array[i]);
			}
		}


		return evenHashSet.ToArray ();
	}

	public static (int[] even, int[] odd) Array10(int[] array)
	{
		HashSet<int> evenHashSet = new HashSet<int> ();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].IsEven ())
			{
				evenHashSet.Add(array[i]);
			}
		}

		HashSet<int> oddHashSet = new HashSet<int> ();
		for (int i = array.Length - 1; i >= 0; i--)
		{
			if (array[i].IsOdd ())
			{
				oddHashSet.Add(array[i]);
			}
		}


		return (evenHashSet.ToArray (), oddHashSet.ToArray ());
	}

	public static int[] Array11(int[] array, int k)
	{
		int[] array2 = new int[array.Length / k];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = array[i * k];
		}

		return array2;
	}

	public static int[] Array12(int[] array)
	{
		int[] array2 = new int[array.Length / 2];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = array[i * 2];
		}

		return array2;
	}

	public static int[] Array13(int[] array)
	{
		List<int> list = new List<int> ();
		for (int i = array.Length - 1; i >= 0; i -= 2)
		{
			list.Add(array[i]);
		}

		return list.ToArray ();
	}

	public static int[] Array14(int[] array)
	{
		int[] arrayOdd = Array8(array).OrderBy(x => x).ToArray ();
		int[] arrayEven = Array9(array).OrderBy(x => x).ToArray ();

		List<int> arrayMerged = new List<int> ();

		arrayMerged.AddRange(arrayEven);
		arrayMerged.AddRange(arrayOdd);


		return arrayMerged.ToArray ();
	}

	public static int[] Array15(int[] array)
	{
		int[] arrayEven = Array9(array).OrderBy(x => x).Reverse ().ToArray ();
		int[] arrayOdd = Array8(array).OrderBy(x => x).ToArray ();

		List<int> listMerge = new List<int> ();

		listMerge.AddRange(arrayOdd);
		listMerge.AddRange(arrayEven);

		return listMerge.ToArray ();
	}

	public static (int[] given, int[] returned) Array16(int[] array)
	{
		List<int> list = new List<int> ();

		int n = array.Length;
		int forSize = n / 2;

		for (int i = 0; i < forSize; i++)
		{
			list.Add(array[n - i - 1]);
		}

		return (array, list.ToArray ());
	}


	public static int Array18(int[] array)
	{
		int k = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] < array[^1])
			{
				k = array[i];
				break;
			}
		}

		return k;
	}

	public static int Array19(int[] array)
	{
		int k = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] > array[0] && array[i] < array[^1])
			{
				k = i;
			}
		}

		return k;
	}

	public static int Array20(int[] array, int k, int l)
	{
		int sum = 0;
		for (int i = k - 1; i < l; i++)
		{
			sum += array[i];
		}

		return sum;
	}

	public static void Array21(int n, int k, int l)
	{
		int[] a = new int[n];
		Random rand = new Random ();

		for (int i = 0; i < n; ++i)
		{
			a[i] = rand.Next(1, 100);
		}

		int sum = 0;
		for (int i = k - 1; i < l; i++)
		{
			sum += a[i];
		}

		if (l - k + 1 != 0)
		{
			float average = (float) sum / (float) (l - k + 1);
			Console.WriteLine($"Average: {average}");
		}
		else
		{
			Console.WriteLine("Invalid range (l - k + 1 is zero)");
		}
	}

	public static int Array22(int[] array, int k, int l)
	{
		int sum = 0;

		for (int i = 0; i < array.Length; ++i)
		{
			if (i < k - 1 || i >= l)
			{
				sum += array[i];
			}
		}

		return sum;
	}

	public static double Array23(int[] array, int k, int l)
	{
		int sum = 0;
		int count = 0;

		for (int i = 0; i < array.Length; ++i)
		{
			if (i < k - 1 || i >= l)
			{
				sum += array[i];
				count++;
			}
		}

		return (double) sum / count;
	}

	public static bool Array24(int[] array)
	{
		if (array.Length <= 2)
		{
			return true;
		}

		int diff = array[1] - array[0];

		for (int i = 2; i < array.Length; i++)
		{
			if (array[i] - array[i - 1] != diff)
			{
				return false;
			}
		}

		return true;
	}

	public static int Array25(int[] array)
	{
		if (array.Length <= 2)
		{
			return 0;
		}

		int ratio = array[1] / array[0];

		for (int i = 2; i < array.Length; i++)
		{
			if (array[i] / array[i - 1] != ratio)
			{
				return 0;
			}
		}

		return ratio;
	}

	public static int Array26(int[] array)
	{
		for (int i = 1; i < array.Length; i++)
		{
			if ((array[i] > 0 && array[i - 1] > 0) || (array[i] < 0 && array[i - 1] < 0))
			{
				return 0;
			}
		}

		return System.Array.FindIndex(array,
			x => (x > 0 && array[System.Array.IndexOf(array, x) - 1] < 0) ||
			     (x < 0 && array[System.Array.IndexOf(array, x) - 1] > 0)) + 1;
	}

	public static int Array27(int[] array)
	{
		for (int i = 1; i < array.Length; i++)
		{
			if ((array[i] > 0 && array[i - 1] > 0) || (array[i] < 0 && array[i - 1] < 0))
			{
				return 0;
			}
		}

		return -1;
	}

	public static int Array28(int[] array)
	{
		if (array.Length == 0)
		{
			return -1;
		}

		int min = array[1];

		for (int i = 3; i < array.Length; i += 2)
		{
			if (array[i] < min)
			{
				min = array[i];
			}
		}

		return min;
	}

	public static int Array29(int[] array)
	{
		if (array.Length == 0)
		{
			return -1;
		}

		int max = array[0];

		for (int i = 2; i < array.Length; i += 2)
		{
			if (array[i] > max)
			{
				max = array[i];
			}
		}

		return max;
	}

	public static int[] Array30(int[] array)
	{
		int count = 0;
		int[] result = new int[array.Length];

		for (int i = 0; i < array.Length - 1; i++)
		{
			if (array[i] > array[i + 1])
			{
				result[count] = i;
				count++;
			}
		}

		System.Array.Resize(ref result, count);

		return result;
	}

	public static int[] Array31(int[] array)
	{
		int count = 0;
		int[] result = new int[array.Length];

		for (int i = array.Length - 2; i >= 0; i--)
		{
			if (array[i] > array[i + 1])
			{
				result[count] = i;
				count++;
			}
		}

		System.Array.Resize(ref result, count);

		return result;
	}

	public static int Array32(int[] array)
	{
		for (int i = 1; i < array.Length - 1; i++)
		{
			if (array[i] < array[i - 1] && array[i] < array[i + 1])
			{
				return i;
			}
		}

		return -1;
	}

	public static int Array33(int[] array)
	{
		for (int i = array.Length - 2; i > 0; i--)
		{
			if (array[i] > array[i - 1] && array[i] > array[i + 1])
			{
				return i;
			}
		}

		return -1;
	}

	public static int Array34(int[] array)
	{
		int maxLocalMin = int.MinValue;

		for (int i = 1; i < array.Length - 1; i++)
		{
			if (array[i] < array[i - 1] && array[i] < array[i + 1] && array[i] > maxLocalMin)
			{
				maxLocalMin = array[i];
			}
		}

		return maxLocalMin == int.MinValue ? -1 : maxLocalMin;
	}

	public static int Array35(int[] array)
	{
		int maxLocalMax = int.MinValue;

		for (int i = 1; i < array.Length - 1; i++)
		{
			if (array[i] > array[i - 1] && array[i] > array[i + 1] && array[i] > maxLocalMax)
			{
				maxLocalMax = array[i];
			}
		}

		return maxLocalMax == int.MinValue ? 0 : maxLocalMax;
	}

	public static int Array36(int[] array)
	{
		int maxNonLocal = int.MinValue;

		for (int i = 0; i < array.Length; i++)
		{
			if (!IsLocalMinimum(array, i) && !IsLocalMaximum(array, i) && array[i] > maxNonLocal)
			{
				maxNonLocal = array[i];
			}
		}

		return maxNonLocal == int.MinValue ? 0 : maxNonLocal;
	}


	public static int Array37(int[] array)
	{
		int count = 0;
		bool increasing = false;

		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > array[i - 1])
			{
				if (!increasing)
				{
					count++;
					increasing = true;
				}
			}
			else
			{
				increasing = false;
			}
		}

		return count;
	}

	public static int Array38(int[] array)
	{
		int count = 0;
		bool decreasing = false;

		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] < array[i - 1])
			{
				if (!decreasing)
				{
					count++;
					decreasing = true;
				}
			}
			else
			{
				decreasing = false;
			}
		}

		return count;
	}

	public static int Array39(int[] array)
	{
		int count = 0;
		bool increasing = false;
		bool decreasing = false;

		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] > array[i - 1])
			{
				if (!increasing && !decreasing)
				{
					count++;
					increasing = true;
				}

				decreasing = false;
			}
			else if (array[i] < array[i - 1])
			{
				if (!decreasing && !increasing)
				{
					count++;
					decreasing = true;
				}

				increasing = false;
			}
			else
			{
				increasing = false;
				decreasing = false;
			}
		}

		return count;
	}

	public static int Array40(int[] array, int R)
	{
		int closestElement = array[0];
		int minDifference = Math.Abs(array[0] - R);

		for (int i = 1; i < array.Length; i++)
		{
			int difference = Math.Abs(array[i] - R);

			if (difference < minDifference)
			{
				minDifference = difference;
				closestElement = array[i];
			}
		}

		return closestElement;
	}
}