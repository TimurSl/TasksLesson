namespace TasksLesson.Homework;

public class Boolean
{
	public static bool Boolean1(int a)
    {
        return a > 0;
    }

    public static bool Boolean2(int a)
    {
        return a % 2 != 0;
    }

    public static bool Boolean3(int a)
    {
        return a % 2 == 0;
    }

    public static bool Boolean4(int a, int b)
    {
        return a > 2 && b <= 3;
    }

    public static bool Boolean5(int a, int b)
    {
        return a >= 0 || b < -2;
    }

    public static bool Boolean6(int a, int b, int c)
    {
        return a < b && b < c;
    }

    public static bool Boolean7(int a, int b, int c)
    {
        return a < b && b < c;
    }

    public static bool Boolean8(int a, int b)
    {
        return a.IsOdd () && b.IsOdd ();
    }

    public static bool Boolean9(int a, int b)
    {
        return a.IsOdd () || b.IsOdd ();
    }

    public static bool Boolean10(int a, int b)
    {
        return a.IsOdd () ^ b.IsOdd ();
    }

    public static bool Boolean11(int a, int b)
    {
        return (a.IsOdd () && b.IsOdd ()) || (a.IsEven () && b.IsEven ());
    }

    public static bool Boolean12(int a, int b, int c)
    {
        return a.IsPositive () && b.IsPositive () && c.IsPositive ();
    }

    public static bool Boolean13(int a, int b, int c)
    {
        return a.IsPositive () || b.IsPositive () || c.IsPositive ();
    }

    public static bool Boolean14(int a, int b, int c)
    {
        return a.IsPositive () ^ b.IsPositive () ^ c.IsPositive ();
    }

    public static bool Boolean15(int a, int b, int c)
    {
        return (a.IsPositive () && b.IsPositive ())
               ^ (a.IsPositive () && c.IsPositive ())
               ^ (b.IsPositive () && c.IsPositive ());
    }

    public static bool Boolean16(int a)
    {
        return a < 100 && a > 9 && a.IsEven ();
    }

    public static bool Boolean17(int a)
    {
        return a < 1000 && a > 99 && a % 2 != 0;
    }

    public static bool Boolean18(int a, int b, int c)
    {
        return (a == b) || (a == c) || (b == c);
    }

    public static bool Boolean19(int a, int b, int c)
    {
        return (a > 0 && b < 0) || (a < 0 && b > 0) // a and b
            || (a > 0 && c < 0) || (a < 0 && c > 0) // a and c
            || (b > 0 && c < 0) || (b < 0 && c > 0); // b and c
    }

    public static bool Boolean20(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a != b && a != c && b != c;
    }

    public static bool Boolean21(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return a < b && b < c;
    }

    public static bool Boolean22(int abc)
    {
        int a = abc / 100;
        int b = abc / 10 % 10;
        int c = abc % 10;
        return (a < b && b < c) || (c < b && b < a);
    }

    public static bool Boolean23(int abcd)
    {
        int a = abcd / 1000;
        int b = abcd / 100 % 10;
        int c = abcd / 10 % 10;
        int d = abcd % 10;
        return a == d && b == c;
    }

    public static bool Boolean24(int a, int b, int c)
    {
        int dicriminant = (b * b) - (4 * a * c);
        return dicriminant >= 0;
    }

    public static bool Boolean25(int x, int y)
    {
        return x < 0 && y > 0;
    }

    public static bool Boolean26(int x, int y)
    {
        return x > 0 && y < 0;
    }

    public static bool Boolean27(int x, int y)
    {
        return (x < 0 && y > 0) || (x > 0 && y < 0);
    }

    public static bool Boolean28(int x, int y)
    {
        return (x > 0 && y > 0) || (x < 0 && y < 0);
    }

    public static bool Boolean29(int x, int y, int x1, int y1, int x2, int y2)
    {
        Point topLeft = new Point(x1, y1);
        Point bottomRight = new Point(x2, y2);
        Point point = new Point(x, y);

        return point.IsInside(topLeft, bottomRight);
    }

    public static bool Boolean30(int a, int b, int c)
    {
        return (a == b) && (c == b) && (c == a);
    }

    public static bool Boolean31(int a, int b, int c)
    {
        return (a == b) || (c == b) || (c == a);
    }

    public static bool Boolean32(int a, int b, int c)
    {
        return (a * a + b * b == c * c) || (c * c + b * b == a * a) || (a * a + c * c == b * b);
    }

    public static bool Boolean33(int a, int b, int c)
    {
        return (a + b) > c && (a + c) > b && (b + c) > a;
    }

    public static bool Boolean34(int x, int y)
    {
        return (x + y).IsOdd ();
    }

    public static bool Boolean35(int x1, int y1, int x2, int y2)
    {
        return (x1 + y1) % 2 == (x2 + y2) % 2;
    }

    // Тура
    public static bool Boolean36(int x1, int y1, int x2, int y2)
    {
        return (x1 == x2) || (y1 == y2);
    }

    // Король
    public static bool Boolean37(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
    }

    // Слон
    public static bool Boolean38(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
    }

    public static bool Boolean39(int x1, int y1, int x2, int y2)
    {
        return Boolean36(x1, y1, x2, y2) || Boolean38(x1, y1, x2, y2);
    }

    public static bool Boolean40(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1
               || Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2;
    }
}