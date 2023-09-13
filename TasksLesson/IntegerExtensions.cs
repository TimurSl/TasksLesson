public static class IntegerExtensions
{
	public static bool IsPrime(this int number)
	{
		if (number == 1) return false;
		if (number == 2) return true;

		for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
		{
			if (number % i == 0) return false;
		}

		return true;
	}

	public static bool IsOdd(this int number)
	{
		return number % 2 != 0;
	}

	public static bool IsEven(this int number)
	{
		return number % 2 == 0;
	}

	public static bool IsPositive(this int number)
	{
		return number > 0;
	}

	public static bool IsNegative(this int number)
	{
		return number < 0;
	}
}