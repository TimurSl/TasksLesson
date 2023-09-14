namespace TasksLesson.Homework;

public class Point
{
	public float X { get; set; }
	public float Y { get; set; }

	public Point(float x, float y)
	{
		X = x;
		Y = y;
	}

	public static float Distance(Point p1, Point p2)
	{
		return MathF.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
	}

	public static bool operator >(Point p1, Point p2)
	{
		return p1.X > p2.X && p1.Y > p2.Y;
	}

	public static bool operator <(Point p1, Point p2)
	{
		return p1.X < p2.X && p1.Y < p2.Y;
	}

	public static bool operator ==(Point p1, Point p2)
	{
		return p1.X == p2.X && p1.Y == p2.Y;
	}

	public static bool operator !=(Point p1, Point p2)
	{
		return !(p1 == p2);
	}
}

public static class PointExtensions
{
	public static bool IsInside(this Point point, Point topLeft, Point bottomRight)
	{
		return point < topLeft && point > bottomRight;
	}
}