namespace TasksLesson.Homework;

public class While
{
	public static void While1(int a, int b)
    {
        while (a >= b)
        {
            a -= b;
        }
        Console.WriteLine(a);
    }

    public static void While2(int a, int b)
    {
        int count = 0;
        while (a >= b)
        {
            a -= b;
            count++;
        }
        Console.WriteLine(count);
    }

    public static void While3(uint n, uint k)
    {
        int num = 0;
        while (n >= k) {
            n -= k;
            num++;
        }
        Console.WriteLine(num);
    }

    public static void While4(uint a)
    {
        while (a > 0) a -= 3;

        if (a == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    public static void While5(uint n)
    {
        int k = 0;

        while (n > 1)
        {
            n /= 2;
            k++;
        }

        if (n == 1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    public static void While6(int n)
    {
        float result = 1;

        while (n >= 2)
        {
            result *= n;
            n -= 2;
        }

        Console.WriteLine(result);
    }

    public static void While7(int n)
    {
        int k = 1;

        while (k * k <= n)
            k++;

        Console.WriteLine(k);
    }

    public static void While8(int n)
    {
        int k = 1;

        while (k * k <= n)
            k++;

        Console.WriteLine(k - 1);
    }

    public static void While9(int n)
    {
        int k = 1;
        int temp = 3;

        while (temp <= n)
        {
            temp *= 3;
            k++;
        }

        Console.WriteLine(k);
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

        Console.WriteLine(k);
    }

    public static void While11(int n)
    {
        int k = 0;
        int sum = 0;

        while (sum < n)
        {
            k++;
            sum += k;
        }

        Console.WriteLine(k);
        Console.WriteLine(sum);
    }

    public static void While12(int n)
    {
        int sum = 0;
        int k = 0;

        while (sum <= n)
        {
            sum += k + 1;
            k++;
        }

        sum -= k + 1;
        Console.WriteLine(k - 1);
        Console.WriteLine(sum);
    }

    public static void While13(int a)
    {
        double k = 1;
        double sum = 0;

        while (sum < a)
        {
            sum += 1.0 / k;
            k++;
        }
        Console.WriteLine(k);
        Console.WriteLine(sum);
    }

    public static void While14(int a)
    {
        double sum = 0;
        int k = 0;

        while(sum < a)
        {
            k++;
            sum += (double) 1 / k;
        }
        Console.WriteLine("Число K становится равным {0}, а сумма равна {1}", k, sum);
    }

    public static void While15(int k)
    {
        double s = 1000;
        double p = 10;

        while (s <= 1100)
        {
            k++;
            s += s * p / 100;
        }

        Console.WriteLine($"K = {k}, S = {s}");
    }

    public static void While16(int p)
    {
        int k = 1;
        double s = 10;
        double sum = 10;

        while (sum <= 200)
        {
            k++;
            s += s * p / 100;
            sum += s;
        }

        Console.WriteLine($"K = {k}, S = {sum}");
    }

    public static void While17(int n)
    {
        while (n > 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }
    }

    public static void While18(int n)
    {
        int sum = 0;
        int count = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
            count++;
        }

        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }


    public static void While19(int n)
    {
        int result = 0;
        int tenMult = 1;

        while (n > 0)
        {
            int rest = n % 10;
            result += tenMult * rest;
            n /= 10;
            tenMult *= 10;
        }
        Console.WriteLine(result);
    }

    public static void While20(int n)
    {
        bool isTwoInNumber = false;

        while (n > 0)
        {
            int reminder = n % 10;
            if (reminder == 2)
            {
                isTwoInNumber = true;
                break;
            }

            n /= 10;
        }
        Console.WriteLine(isTwoInNumber);
    }

    public static void While21(int n)
    {
        bool isOdd = false;

        while (n > 0)
        {
            int reminder = n % 10;
            if (reminder % 2 != 0)
            {
                isOdd = true;
                break;
            }

            n /= 10;
        }
        Console.WriteLine(isOdd);
    }

    public static void While22(int n)
    {
        bool isPrime = true;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime);
    }

    public static void While23(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        Console.WriteLine(a);
    }

    public static void While24(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        bool isFibonacci = false;

        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            if (f3 == n)
            {
                isFibonacci = true;
                break;
            }
        }
        Console.WriteLine(isFibonacci);
    }

    public static void While25(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;

        while (f3 <= n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        Console.WriteLine(f3);
    }

    public static void While26(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;

        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        Console.WriteLine($"Fk-1 = {f1}");
        Console.WriteLine($"Fk+1 = {f3}");
    }

    public static void While27(int n)
    {
        int f1 = 1;
        int f2 = 1;
        int f3 = 0;
        int k = 2;

        while (f3 < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            k++;
        }
        Console.WriteLine(k);
    }

    public static void While28(double e)
    {
        double a1 = 2;
        double a2 = 2 + 1 / a1;
        int k = 2;

        while (Math.Abs(a2 - a1) >= e)
        {
            a1 = a2;
            a2 = 2 + 1 / a1;
            k++;
        }
        Console.WriteLine($"K = {k}");
        Console.WriteLine($"A1 = {a1}");
        Console.WriteLine($"A2 = {a2}");
    }

    public static void While29(double e)
    {
        double a1 = 1;
        double a2 = 2;
        double a3 = (a1 + 2 * a2) / 3;
        int k = 3;

        while (Math.Abs(a3 - a2) >= e)
        {
            a1 = a2;
            a2 = a3;
            a3 = (a1 + 2 * a2) / 3;
            k++;
        }
        Console.WriteLine($"K = {k}");
        Console.WriteLine($"A1 = {a1}");
        Console.WriteLine($"A2 = {a2}");
        Console.WriteLine($"A3 = {a3}");
    }
    public static void While30(int a, int b, int c)
    {
        int count = 0;
        int a1 = a;
        int b1 = b;

        while (a1 >= c && b1 >= c)
        {
            a1 -= c;
            b1 -= c;
            count++;
        }
        Console.WriteLine(count);
    }
}