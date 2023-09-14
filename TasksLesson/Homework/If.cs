namespace TasksLesson.Homework;

public class If
{
	public static int If1(int a)
	{
		if (a > 0)
		{
			a += 1;
		}

		return a;
	}

	public static int If2(int a)
	{
		if (a > 0)
		{
			a += 1;
		}
		else
		{
			a -= 2;
		}

		return a;
	}

	public static int If3(int a)
	{
		if (a > 0)
		{
			a += 1;
		}
		else if (a < 0)
		{
			a -= 2;
		}
		else
		{
			a = 10;
		}

		return a;
	}

	public static int If4(int a, int b, int c)
	{
		int positive = 0;

		if (a.IsPositive ())
		{
			positive += 1;
		}

		if (b.IsPositive ())
		{
			positive += 1;
		}

		if (c.IsPositive ())
		{
			positive += 1;
		}

		return positive;
	}

	public static (int positive, int negative) If5(int a, int b, int c)
	{
		int positive = 0;
		int negative = 0;
		if (a.IsPositive ())
		{
			positive += 1;
		}
		else
		{
			negative += 1;
		}

		if (b.IsPositive ())
		{
			positive += 1;
		}
		else
		{
			negative += 1;
		}

		if (c.IsPositive ())
		{
			positive += 1;
		}
		else
		{
			negative += 1;
		}

		return (positive, negative);
	}

	public static int If6(int a, int b)
	{
		return a > b ? a : b;
	}

	public static int If7(int a, int b)
	{
		return a < b ? 1 : 2;
	}

	public static (int bigger, int smaller) If8(int a, int b)
	{
		if (a > b)
		{
			return (a, b);
		}

		return (b, a);
	}

	public static (int a, int b) If9(int a, int b)
	{
		if (a > b)
		{
			(a, b) = (b, a);
		}

		return (a, b);
	}

	public static (int a, int b) If10(int a, int b)
	{
		if (a != b)
		{
			int sum = a + b;
			a = sum;
			b = sum;
		}
		else
		{
			a = 0;
			b = 0;
		}

		return (a, b);
	}

	public static (int a, int b) If11(int a, int b)
	{
		int max = Math.Max(a, b);
		if (a != b)
		{
			a = max;
			b = max;
		}
		else
		{
			a = 0;
			b = 0;
		}

		return (a, b);
	}

	public static int If12(int a, int b, int c)
	{
		if (a > b && a > c)
		{
			return a;
		}

		if (b > a && b > c)
		{
			return b;
		}

		return c;
	}

	public static int If13(int a, int b, int c)
	{
		int max = new[] {a, b, c}.Max ();
		int min = new[] {a, b, c}.Min ();

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

	public static (int min, int max) If14(int a, int b, int c)
	{
		int max = new[] {a, b, c}.Max ();
		int min = new[] {a, b, c}.Min ();

		return (min, max);
	}

	public static int If15(int a, int b, int c)
	{
		int max = new[] {a, b, c}.Max ();
		int max2 = new[] {a, b, c}.Where(x => x != max).Max ();

		int sum = max + max2;

		return sum;
	}

	public static (float a, float b, float c) If16(float a, float b, float c)
	{
		if (a < b && b < c)
		{
			a *= 2;
			b *= 2;
			c *= 2;
		}
		else
		{
			a = -a;
			b = -b;
			c = -c;
		}

		return (a, b, c);
	}

	public static (float a, float b, float c) If17(float a, float b, float c)
	{
		if (a < b && b < c || a > b && b > c)
		{
			a *= 2;
			b *= 2;
			c *= 2;
		}
		else
		{
			a = -a;
			b = -b;
			c = -c;
		}

		return (a, b, c);
	}

	public static int If18(int a, int b, int c)
	{
		if (a == b)
		{
			return 3;
		}

		if (a == c)
		{
			return 2;
		}

		if (b == c)
		{
			return 1;
		}

		return 0;
	}

	public static int If19(int a, int b, int c, int d)
	{
		if (a == b && a == c)
		{
			return 4;
		}

		if (a == b && a == d)
		{
			return 3;
		}

		if (a == c && a == d)
		{
			return 2;
		}

		if (b == c && b == d)
		{
			return 1;
		}

		return 0;
	}

	public static (char point, int distance) If20(int a, int b, int c)
	{
		int distanceB = Math.Abs(a - b);
		int distanceC = Math.Abs(a - c);
		if (distanceB < distanceC)
		{
			return ('B', distanceB);
		}

		return ('C', distanceC);
	}

	public static int If21(int x, int y)
	{
		if (x == 0)
		{
			return 1;
		}

		if (y == 0)
		{
			return 2;
		}

		return 3;
	}

	public static int If22(int x, int y)
	{
		if (x == 0 && y == 0)
		{
			return 0;
		}

		if (x > 0 && y > 0)
		{
			return 1;
		}

		if (x < 0 && y > 0)
		{
			return 2;
		}

		if (x < 0 && y < 0)
		{
			return 3;
		}

		return 4;
	}

	public static Point If23(int x1, int y1, int x2, int y2, int x3, int y3)
	{
		Point point1 = new Point(x1, y1);
		Point point2 = new Point(x2, y2);
		Point point3 = new Point(x3, y3);

		Point resultPoint = new Point(0, 0);

		if (point1.X == point2.X)
		{
			resultPoint.X = point3.X;
		}
		else if (point1.X == point3.X)
		{
			resultPoint.X = point2.X;
		}
		else
		{
			resultPoint.X = point1.X;
		}

		if (point1.Y == point2.Y)
		{
			resultPoint.Y = point3.Y;
		}
		else if (point1.Y == point3.Y)
		{
			resultPoint.Y = point2.Y;
		}
		else
		{
			resultPoint.Y = point1.Y;
		}

		return resultPoint;
	}

	public static float If24(float x)
	{
		float result = 0;
		if (x > 0)
		{
			result = 2 * (float) Math.Sin(x);
		}
		else
		{
			result = 6 - x;
		}

		return result;
	}

	public static float If25(float x)
	{
		if (x < -2 || x > 2)
		{
			return 2 * x;
		}

		return -3 * x;
	}

	public static float If26(float x)
	{
		if (x <= 0)
		{
			return -x;
		}
		else if (x > 0 && x < 2)
		{
			return x * x;
		}
		else
		{
			return 4;
		}
	}

	public static float If27(float x)
	{
		if (x < 0)
		{
			return 0;
		}

		if (x >= 0 && x < 1 || x >= 2 && x < 3)
		{
			return 1;
		}

		if (x >= 1 && x < 2 || x >= 3 && x < 4)
		{
			return -1;
		}

		return 0;
	}

	public static int If28(int year)
	{
		if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
		{
			return 366;
		}
		else
		{
			return 365;
		}
	}

	public static string If29(int a)
	{
		string result = "";

		if (a == 0)
		{
			result = "нулевое число";
		}
		else
		{
			if (a < 0)
			{
				result += "отрицательное ";
			}
			else
			{
				result += "положительное ";
			}


			if (a.IsEven ())
			{
				result += "четное число";
			}
			else
			{
				result += "нечетное число";
			}
		}

		return result;
	}

	public static string If30(int a)
	{
		string result = "";

		if (a.IsEven ())
		{
			result += "четное ";
		}
		else
		{
			result += "нечетное ";
		}

		if (a < 10)
		{
			result += "однозначное число";
		}
		else if (a < 100)
		{
			result += "двузначное число";
		}
		else
		{
			result += "трехзначное число";
		}

		return result;
	}
}