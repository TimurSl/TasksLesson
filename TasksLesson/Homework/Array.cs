namespace TasksLesson.Homework;

public class Array
{
	public static void Main(string[] args)
	{
		Console.WriteLine(Array20(Range(5), 2, 4));
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
}