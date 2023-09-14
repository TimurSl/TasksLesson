namespace TasksLesson.Homework;

public class Integer
{
	public static int Integer1(int l)
	{
		return l / 100;
	}

	public static int Integer2(int m)
	{
		return m / 1000;
	}

	public static int Integer3(int a)
	{
		return a / 1024;
	}

	public static int Integer4(int a, int b)
	{
		if (a > b)
		{
			return a / b;
		}

		return 0;
	}

	public static int Integer5(int a, int b)
	{
		return a % b;
	}

	public static (int dozens, int units) Integer6(int ab)
	{
		int dozens = ab / 10;
		int units = ab % 10;
		return (dozens, units);
	}

	public static (int sum, int multiply) Integer7(int ab)
	{
		int a = ab / 10;
		int b = ab % 10;
		int sum = a + b;
		int multiply = a * b;
		return (sum, multiply);
	}

	public static int Integer8(int ab)
	{
		int ba = (ab / 10) + (ab % 10) * 10;
		return ba;
	}

	public static int Integer9(int abc)
	{
		return abc / 100;
	}

	public static (int b, int c) Integer10(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
        int c = abc % 10;
		return (b, c);
	}

	public static (int sum, int multiply) Integer11(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;

		int sum = a + b + c;
		int multiply = a * b * c;

		return (sum, multiply);
	}

	public static int Integer12(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;
		return c * 100 + b * 10 + a;
	}

	public static int Integer13(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;
		return b * 100 + c * 10 + a;
	}

	public static int Integer14(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;
		return c * 100 + a * 10 + b;
	}

	public static int Integer15(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;
		return b * 100 + a * 10 + c;
	}

	public static int Integer16(int abc)
	{
		int a = abc / 100;
		int b = abc / 10 % 10;
		int c = abc % 10;
		return a * 100 + c * 10 + b;
	}

	public static int Integer17(int abc)
	{
		return (abc % 1000) / 100;
	}

	public static int Integer18(int abc)
	{
		return (abc % 10000) / 1000;
	}

	public static int Integer19(int m)
	{
		return m / 60;
	}

	public static int Integer20(int m)
	{
		return m / 60 / 60;
	}

	public static int Integer21(int m)
	{
		return m % 60;
	}

	public static int Integer22(int m)
	{
		return m % 3600;
	}

	public static int Integer23(int m)
	{
		return m % 3600 / 60;
	}

	public static int Integer24(int m)
	{
		return m % 7;
	}

	public static int Integer25(int m)
	{
		return (m % 7) + 3;
	}

	public static int Integer26(int m)
	{
		return (m % 7) + 1;
	}

	public static int Integer27(int m)
	{
		return ((m + 4) % 7) + 1;
	}

	public static int Integer28(int a, int b)
	{
		return ((a + b - 2) % 7) + 1;
	}

	public static (int count, int area) Integer29(int a, int b, int c)
	{
		int count = (a / c) * (b / c);
		int area = a * b - count * c * c;
		return (count, area);
	}

	public static int Integer30(int a)
	{
		return a / 100 + 1;
	}
}