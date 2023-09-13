namespace TasksLesson.Homework;

public class Begin
{
    public const float PI = 3.14f;


	public static float Begin1(float a)
    {
        return a * 4;
    }

    public static float Begin2(float a)
    {
        return a * a;
    }

    public static (float area, float perimeter) Begin3(float a, float b)
    {
        float area = a * b;
        float perimeter = 2 * (a + b);

        return (area, perimeter);
    }

    public static float Begin4(float d)
    {
        return PI * d;
    }

    public static (float volume, float area) Begin5(float a)
    {
        float volume = a * a * a;
        float area = 6 * (a * a);

        return (volume, area);
    }

    public static (float volume, float area) Begin6(float a, float b, float c)
    {
        float volume = a * b * c;
        float area = 2 * (a * b + b * c + a * c);

        return (volume, area);
    }

    public static (float length, float area) Begin7(float R)
    {
        float length = 2 * PI * R;
        float area = PI * (R * R);

        return (length, area);
    }

    public static float Begin8(float a, float b)
    {
        return (a + b) / 2;
    }

    public static float Begin9(float a, float b)
    {
        return MathF.Sqrt(a * b);
    }

    public static (float sum, float difference, float multiply, float quotient) Begin10(float a, float b)
    {
        float squareOfA = MathF.Sqrt(a);
        float squareOfB = MathF.Sqrt(b);

        float sum = squareOfA + squareOfB;
        float difference = MathF.Abs(squareOfA - squareOfB);
        float multiply = squareOfA * squareOfB;
        float quotient = squareOfA / squareOfB;

        return (sum, difference, multiply, quotient);
    }

    public static (float sum, float difference, float multiply, float quotient) Begin11(float a, float b)
    {
        float moduleA = MathF.Abs(a);
        float moduleB = MathF.Abs(b);

        float sum = moduleA + moduleB;
        float difference = MathF.Max(moduleA, moduleB) - MathF.Max(moduleA, moduleB);
        float multiply = moduleA * moduleB;
        float quotient = moduleA / moduleB;

        return (sum, difference, multiply, quotient);
    }

    public static (float hypotenuse, float perimeter) Begin12(float a, float b)
    {
        float hypotenuse = MathF.Sqrt((a * a) + (b * b));
        float perimeter = a + b + hypotenuse;

        return (hypotenuse, perimeter);
    }

    public static (float s1, float s2, float s3) Begin13(float R1, float R2)
    {
        float S1 = PI * (R1 * R1);
        float S2 = PI * (R2 * R2);
        float S3 = S1 - S2;

        return (S1, S2, S3);
    }

    public static (float radius, float square) Begin14(float l)
    {
        float radius = l / (2 * PI);
        float square = PI * (radius * radius);

        return (radius, square);
    }

    public static (float diameter, float length) Begin15(float S)
    {
        float diameter = 2 * MathF.Sqrt(S / PI);
        float length = MathF.Sqrt(S * 4 * PI);

        return (diameter, length);
    }

    public static float Begin16(float x1, float x2)
    {
        return MathF.Abs(x2 - x1);
    }

    public static (float AC, float BC, float sum) Begin17(float A, float B, float C)
    {
        float AC = MathF.Abs(C - A);
        float BC = MathF.Abs(C - B);
        float sum = AC + BC;

        return (AC, BC, sum);
    }

    public static (float AC, float BC, float product) Begin18(float A, float B, float C)
    {
        float AC = MathF.Abs(C - A);
        float BC = MathF.Abs(C - B);
        float product = AC * BC;

        return (AC, BC, product);
    }

    public static (float perimeter, float area) Begin19(float x1, float y1, float x2, float y2)
    {
        float distance_x = MathF.Abs(x1 - x2);
        float distance_y = MathF.Abs(y1 - y2);

        float perimeter = 2 * distance_x + distance_y;
        float area = distance_x * distance_y;

        return (perimeter, area);
    }

    public static float Begin20(float x1, float y1, float x2, float y2)
    {
        float x3 = x2 - x1;
        float y3 = y2 - y1;
        return MathF.Sqrt((x3 * x3) + (y3 * y3));
    }

    public static (float perimeter, float square) Begin21(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        Point p1 = new Point(x1, y1);
        Point p2 = new Point(x2, y2);
        Point p3 = new Point(x3, y3);

        float distance_a = Point.Distance(p1, p2);
        float distance_b = Point.Distance(p2, p3);
        float distance_c = Point.Distance(p3, p1);

        float perimeter = (distance_a + distance_b + distance_c) / 2;
        float square = MathF.Sqrt(perimeter * (perimeter - distance_a) * (perimeter - distance_b) *
                                  (perimeter - distance_c));

        return (perimeter, square);
    }

    public static (string a, string b) Begin22(string a, string b)
    {
        (a, b) = (b, a);

        return (a, b);
    }

    public static (string a, string b, string c) Begin23(string a, string b, string c)
    {
        (a, b, c) = (b, c, a);

        return (a, b, c);
    }

    public static (string a, string b, string c) Begin24(string a, string b, string c)
    {
        (a, b, c) = (c, a, b);

        return (a, b, c);
    }

    public static float Begin25(float x)
    {
        return ((3 * x) * (3 * x)) - ((6 * x) * (6 * x)) - 7;
    }

    public static float Begin26(float x)
    {
        return MathF.Pow(4 * (x - 3), 6) - MathF.Pow(7 * (x - 3), 3) + 2;
    }

    public static (float a2, float a4, float a8) Begin27(float a)
    {
        float temp = a;

        temp = temp * temp;
        float a2 = temp;
        temp = temp * temp;
        float a4 = temp * temp;
        temp = temp * temp;
        float a8 = temp;

        return (a2, a4, a8);
    }

    public static (float a2, float a3, float a5, float a10, float a15) Begin28(float a)
    {
        float temp1 = a;

        float temp2 = temp1 * temp1;
        float a2 = temp2;

        temp1 = temp1 * temp2;
        float a3 = temp1;

        temp2 = temp1 * temp2;
        float a5 = temp2;

        temp1 = temp1 * temp1;
        float a10 = temp1;

        temp1 = temp1 * temp2;
        float a15 = temp1;

        return (a2, a3, a5, a10, a15);
    }

    public static float Begin29(float a)
    {
        float radians = a * MathF.PI / 180;
        return radians;
    }

    public static float Begin30(float a)
    {
        float degrees = a * 180 / MathF.PI;
        return degrees;
    }

    public static float Begin31(float a)
    {
        return (a - 32) * 5 / 9;
    }

    public static float Begin32(float a)
    {
        return  (a * 9 / 5) + 32;
    }

    public static (float kg1, float yKg) Begin33(int x, int a, int y)
    {
        float kg1 = a / x;
        float kgY = kg1 * y;

        return (kg1, kgY);
    }

    public static (float chocolatePricePerKG, float irisPricePerKG, float difference) Begin34(float chocolateMass, float chocolatePrice, float irisMass, float irisPrice)
    {
        float chocolatePricePerKg = chocolatePrice / chocolateMass;
        float irisPricePerKg = irisPrice / irisMass;

        float difference = chocolatePricePerKg / irisPricePerKg;

        return (chocolatePricePerKg, irisPricePerKg, difference);
    }

    public static float Begin35(float V, float U, float T1, float T2)
    {
        float S = V * T1 + (V - U) * T2;
        return S;
    }

    public static float Begin36(float V1, float V2, float S, float T)
    {
        return S + V1 * T + V2 * T;
    }

    public static float Begin37(float V1, float V2, float S, float T)
    {
        return MathF.Abs(S - (V1 * T + V2 * T));
    }

    public static float Begin38(float a, float b)
    {
        return -1 * b / a;
    }

    public static (double bigger, double smaller) Begin39(double a, double b, double c)
    {
        double d = Math.Pow(b, 2) - 4 * a * c;
        double x1 = ((-1f) * b + Math.Sqrt(d)) / (2f * a);
        double x2 = ((-1f) * b - Math.Sqrt(d)) / (2f * a);

        double bigger = Math.Max(x1, x2);
        double smaller = Math.Min(x1, x2);

        return (bigger, smaller);
    }

    public static (double x, double y) Begin40(double a1, double a2, double b1, double b2, double c1, double c2, double d, double x, double y)
    {
        d = a1 * b2 - b1 * a2;
        x = (c1 * b2 - c2 * b1) / d;
        y = (a1 * c2 - a2 * c1) / d;

        return (x, y);
    }
}