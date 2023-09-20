namespace TasksLesson.Homework;

public class For
{
	public static void Main(string[] args)
	{
		For25(8, 3);
	}

	public static void For4(int a)
	{
		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine(i * a);
		}
	}

	public static void For5(int a)
	{
		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine((i * a) / 10);
		}
	}

	public static void For6(int a)
	{
		for (int i = 12; i <= 20; i++)
		{
			Console.WriteLine((i * a) / 10);
		}
	}

	public static int For7(int a, int b)
	{
		int sum = 0;
		for (int i = a; i <= b; i++)
		{
			sum += i;
		}

		return sum;
	}

	public static int For8(int a, int b)
	{
		int sum = 1;
		for (int i = a; i <= b; i++)
		{
			sum *= i;
		}

		return sum;
	}

	public static int For9(int a, int b)
	{
		int sum = 0;
		for (int i = a; i <= b; i++)
		{
			sum += i * i;
		}

		return sum;
	}

	public static double For10(int n)
	{
		double sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += 1.0 / i;
		}

		return sum;
	}

	public static int For11(int n)
	{
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += (i * i) + ((i + 1) * (i + 1));
		}

		return sum;
	}

	public static double For12(int n)
	{
		double sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum *= (1 + 1.0 / i);
		}

		return sum;
	}

	public static double For13(int n)
	{
		double sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += (1.0 / i) * Math.Pow(-1, i);
		}

		return sum;
	}

	public static int For14(int n)
	{
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += (2 * i - 1);
			Console.WriteLine(sum);
		}

		return sum;
	}

	public static double For15(double a, int n)
	{
		double sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum *= a;
		}

		return sum;
	}

	public static void For16(double a, int n)
	{
		for (int i = 1; i <= n; i++)
		{
			Console.WriteLine(Math.Pow(a, i));
		}
	}

	public static double For17(double a, int n)
	{
		double sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum += Math.Pow(a, i);
		}

		return sum;
	}

	public static double For18(double a, int n)
	{
		double sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum += Math.Pow(a, i) * Math.Pow(-1, i);
		}

		return sum;
	}

	public static int For19(int n)
	{
		int sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum *= i;
		}

		return sum;
	}

	public static int For20(int n)
	{
		int sum = 1;
		for (int i = 1; i <= n; i++)
		{
			sum += Factorial(i);
		}

		return sum;
	}

	static int Factorial(int n)
	{
		if (n == 1 || n == 0) return 1;

		int result = 1;
		for (int i = 1; i <= n; i++)
		{
			result *= i;
		}

		return result;
	}

	public static int For21(int n)
	{
		int sum = 1;
		for (int i = 0; i < n; i++)
		{
			sum += 1 / Factorial(i);
		}

		return sum;
	}

	public static double For22(double x, int n)
	{
		double sum = 1 + x;
		for (int i = 0; i < x; i++)
		{
			sum += Math.Pow(x, n) / (Factorial(n));
		}

		return sum;
	}

	public static (double expected, double actual) For23(int x, int n)
	{
		double s = x;
		int k = 1;
		for (int i = 0; i < n + 1; i++)
		{
			k *= (2 * i + 1);
			s += (Math.Pow(-1, i) * Math.Pow(x, (2 * i + 1))) / k;
		}

		return (Math.Sin(x), s);
	}

	public static void For24(float x, int n)
	{
		float x1 = 1;
		float n1 = 1;
		float result = 1.0f;
		int i, k = 0;

		for (i = 2; i <= n; ++i)
		{
			++k;
			n1 *= k;
			++k;
			n1 *= k;

			x1 *= -1 * x * x;
			result += x1 / n1;
		}

		Console.WriteLine(result);
		Console.WriteLine(Math.Cos(x));
	}

	public static void For25(float x, int n)
	{
		float x1 = x;
		float result = x;
		int i;

		for (i = 2; i <= n; ++i)
		{
			x1 *= -1 * x;
			result += x1 / i;
		}

		Console.WriteLine(result);
		Console.WriteLine(Math.Log(1 + x));
	}

	public static void For26(float x, int n)
	{
		float x1 = x;
		float result = x;
		int i, k = 1;

		for (i = 2; i <= n; ++i)
		{
			k += 2;
			x1 *= -1 * x * x;
			result += x1 / k;
		}

		Console.WriteLine(result);
		Console.WriteLine(Math.Atan(x));
	}

	public static void For27(float x, int n)
	{
		float result;
		float b;
		float c;
		float pow;

		b = pow = 1;
		c = x;
		result = x;

		for (int i = 1; i <= n; i++)
		{
			c = c * x * x;
			pow = pow * (2 * i - 1);
			b = b * (i * 2 + 1) * (i * 2);
			result += (pow * c) / b;
			b = b / (i * 2 + 1);
		}

		Console.WriteLine(result);
		Console.WriteLine(Math.Asin(x));
	}

	public static void For28(float x, int n)
	{
		float tempVar1 = 1;
		float tempVar2 = 1;
		float result = 1;
		float pow = 1;

		for (int i = 1; i < n; ++i)
		{
			tempVar1 *= 2 * i - 3;
			tempVar2 *= 2 * i;
			pow *= (-1) * x;
			result += tempVar1 * pow / tempVar2;
		}

		Console.WriteLine(result);
		Console.WriteLine(Math.Asin(x));
	}

	public static void For29(int n, float a, float b)
	{
		float h = (b - a) / n;
		Console.WriteLine(h);

		for (int i = 0; i <= n; ++i)
		{
			Console.WriteLine(a + i * h);
		}
	}

	public static void For30(int n, float a, float b)
	{
		float h = (b - a) / n;
		Console.WriteLine(h);

		for (int i = 0; i <= n; ++i)
		{
			Console.WriteLine(1 - MathF.Sin(a + i * h));
		}
	}

	public static void For31(int n)
	{
		float a = 2;
		Console.WriteLine(a);
		for (int i = 1; i < n; i++)
		{
			a = 2 + 1 / a;
			Console.WriteLine(a);
		}
	}

	public static void For32(int n)
	{
		float a = 1;
		Console.WriteLine(a);
		for (int i = 1; i < n; i++)
		{
			a = (a + 1) / i;
			Console.WriteLine(a);
		}
	}

	public static void For33(int n)
	{
		int a = 1;
		int b = 1;
		Console.WriteLine(a);
		Console.WriteLine(b);
		for (int i = 2; i < n; i++)
		{
			int c = a + b;
			a = b;
			b = c;
			Console.WriteLine(c);
		}
	}

	public static void For34(int n)
	{
		float a = 1;
		float b = 2;
		Console.WriteLine(a);
		Console.WriteLine(b);
		for (int i = 2; i < n; i++)
		{
			float c = (a + 2 * b) / 3;
			a = b;
			b = c;
			Console.WriteLine(c);
		}
	}

	public static void For35(int n)
	{
		int a1 = 1;
		int a2 = 2;
		int a3 = 3;
		Console.WriteLine(a1);
		Console.WriteLine(a2);
		Console.WriteLine(a3);
		for (int i = 3; i < n; i++)
		{
			int a = a3 + a2 - 2 * a1;
			a1 = a2;
			a2 = a3;
			a3 = a;
			Console.WriteLine(a);
		}
	}

	public static void For36(int n, int k)
	{
		int i, i2;
		float sum = 0, nk;
		for (i = 1; i <= n; ++i)
		{
			nk = i;
			for (i2 = 1; i2 <= k; ++i2) nk *= i;
			sum += nk;
		}

		Console.WriteLine(sum);
	}

	public static void For37(int n)
	{
		float sum = 0;
		for (int i = 1; i <= n; i++)
		{
			float temp = 1;
			for (int j = 1; j <= i; j++)
			{
				temp *= j;
			}

			sum += temp;
		}

		Console.WriteLine(sum);
	}

	public static void For38(int n)
	{
		float sum = 0;
		for (int i = 1; i <= n; i++)
		{
			float temp = 1;
			for (int j = 1; j <= i; j++)
			{
				temp *= j;
			}

			sum += temp;
		}

		Console.WriteLine(sum);
	}

	public static void For39(int a, int b)
	{
		for (int i = a; i <= b; i++)
		{
			for (int j = 0; j < i; j++)
			{
				Console.WriteLine(i);
			}
		}
	}

	public static void For40(int a, int b)
	{
		for (int i = a; i <= b; i++)
		{
			for (int j = 0; j < i - a + 1; j++)
			{
				Console.WriteLine(i);
			}
		}
	}
}