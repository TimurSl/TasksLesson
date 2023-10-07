namespace TasksLesson;

public class ArrayUtilites
{
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

	public static int[] RandomRange(int a, int b = 0)
	{
		int[] array = new int[Math.Abs(a - b)];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(Math.Min(a, b), Math.Max(a, b));
		}

		return array;
	}
}