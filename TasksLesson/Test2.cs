using TasksLesson.Homework;

namespace TasksLesson;

public class Test2
{
	/*
	 Integer 26
	 Boolean 38 (що слон може зробити хід)
	 If 13
	 For 12
	 For 24
	 While 10
	 Series 27
	 Proc 35 (тільки Fact2)
	 Proc 56
	 Proc 57
	 Array 68
	 Array 110
	 Array 137*
	*/

	public static void Main(string[] args)
	{
		Series27(5, new float[] {1, 2, 3, 4, 5});
	}

	public static int Integer26(int k)
	{
		return (k % 7) + 1;
	}

	private static string IntToDayOfWeek(int day)
	{
		switch (day)
		{
			case 1:
				return "Monday";
			case 2:
				return "Tuesday";
			case 3:
				return "Wednesday";
			case 4:
				return "Thursday";
			case 5:
				return "Friday";
			case 6:
				return "Saturday";
			case 7:
				return "Sunday";
			default:
				return "Error";
		}
	}

	public static bool Boolean38(int x1, int y1, int x2, int y2)
	{
		return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
	}

	public static int If13(int a, int b, int c)
	{
		int[] array = {a, b, c};

		int max = array.Max ();
		int min = array.Min ();

		if (c > min && c < max)
		{
			return c;
		}

		if (b > min && b < max)
		{
			return b;
		}

		return a;
	}

	public static double For12(int n)
	{
		double sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum *= (1 + 0.1 * i);
		}

		return sum;
	}

	public static void For24(float x, int n)
	{
		float x1 = 1;
		float n1 = 1;
		float result = 1.0f;
		int i, k = 0;

		for (i = 2; i <= n; ++i)
		{
			k++;
			n1 *= k;
			k++;
			n1 *= k;

			x1 *= -1 * x * x;
			result += x1 / n1;
		}

		Console.WriteLine($"Result: {result}, Cos(x): {Math.Cos(x)}");
		Console.WriteLine ();
	}

	public static void While10(int n)
	{
		int k = 0;
		int temp = 3;

		while (temp <= n)
		{
			temp *= 3;
			k++;
		}

		Console.WriteLine($"Result: {k}, 3^k < n: {Math.Pow(3, k) < n}");
	}

	public static void Series27(int n, float[] numbers)
	{
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine(MathF.Pow(numbers[i], i + 1));
		}
	}

	public static int Fact2(int n) // Double Factorial
	{
		int result = 1;
		for (; n > 0; n -= 2)
		{
			result *= n;
		}

		return result;
	}

	public static void Proc35(int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(Fact2(numbers[i]));
		}
	}

	public static float Leng(Point a, Point b)
	{
		float x = a.X - b.X;
		float y = a.Y - b.Y;

		float result = MathF.Sqrt((x * x) + (y * y));

		return Math.Abs(result);
	}

	public static float Perimetr(Point a, Point b, Point c)
	{
		float ab = Leng(a, b);
		float bc = Leng(b, c);
		float ac = Leng(a, c);

		return ab + bc + ac;
	}

	public static void Proc56(Point a, Point b, Point c, Point d)
	{
		double ab = Leng(a, b);
		double ac = Leng(a, c);
		double ad = Leng(a, d);

		Console.WriteLine($"AB: {ab}, AC: {ac}, AD: {ad}");
	}


	public static void Proc57(Point a, Point b, Point c, Point d)
	{
		double abc = Perimetr(a, b, c);
		double abd = Perimetr(a, b, d);
		double acd = Perimetr(a, c, d);

		Console.WriteLine($"ABC: {abc}, ABD: {abd}, ACD: {acd}");
	}

	public static int[] Array68(int[] numbers)
	{
		int max = 0;
		int min = 0;

		for (int i = numbers.Length - 1; i >= 0; i--)
		{
			if (numbers[i] > numbers[max]) max = i;
			if (numbers[i] < numbers[min]) min = i;
		}

		if (max != min)
		{
			numbers[max] += numbers[min];
			numbers[min] = numbers[max] - numbers[min];
			numbers[max] -= numbers[min];
		}

		return numbers;
	}

	public static int[] Array110(int[] numbers)
	{
		List<int> list = new List<int>(numbers);
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i].IsEven ())
			{
				list.Insert(i + 1, numbers[i]);
			}
		}

		list.Sort ();
		return list.ToArray ();
	}

	public static void Array137(Point[] points)
	{
		double largestPerimeter = 0;
		Point[] largestTriangle = new Point[3];

		for (int i = 0; i < points.Length; i++)
		{
			for (int j = i + 1; j < points.Length; j++)
			{
				for (int k = j + 1; k < points.Length; k++)
				{
					Point[] triangle = {points[i], points[j], points[k]};
					double perimeter = Perimetr(triangle[0], triangle[1], triangle[2]);
					if (perimeter > largestPerimeter)
					{
						largestPerimeter = perimeter;
						largestTriangle = triangle;
					}
				}
			}
		}

		Console.WriteLine($"Biggest Perimeter: {largestPerimeter}");
		Console.WriteLine("Triangle Vertex:");
		foreach(var point in largestTriangle)
		{
			Console.WriteLine($"({point.X}, {point.Y})");
		}
	}
}