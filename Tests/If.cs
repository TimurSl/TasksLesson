using TasksLesson.Homework;

namespace Tests;

public class If
{
	[Test]
	public void If1()
	{
		Assert.That(TasksLesson.Homework.If.If1(1), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If1(0), Is.EqualTo(0));
		Assert.That(TasksLesson.Homework.If.If1(-1), Is.EqualTo(-1));
	}

	[Test]
	public void If2()
	{
		Assert.That(TasksLesson.Homework.If.If2(1), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If2(0), Is.EqualTo(-2));
		Assert.That(TasksLesson.Homework.If.If2(-1), Is.EqualTo(-3));
	}

	[Test]
	public void If3()
	{
		Assert.That(TasksLesson.Homework.If.If3(1), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If3(-1), Is.EqualTo(-3));
		Assert.That(TasksLesson.Homework.If.If3(0), Is.EqualTo(10));
	}

	[Test]
	public void If4()
	{
		Assert.That(TasksLesson.Homework.If.If4(1, 2, 3), Is.EqualTo(3));
		Assert.That(TasksLesson.Homework.If.If4(1, 2, 0), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If4(0, 0, 0), Is.EqualTo(0));
	}

	[Test]
	public void If5()
	{
		var result = TasksLesson.Homework.If.If5(1, 2, 3);
		var result2 = TasksLesson.Homework.If.If5(1, 2, 0);
		var result3 = TasksLesson.Homework.If.If5(0, 0, 0);

		Assert.That(result.positive, Is.EqualTo(3));
		Assert.That(result.negative, Is.EqualTo(0));

		Assert.That(result2.positive, Is.EqualTo(2));
		Assert.That(result2.negative, Is.EqualTo(1));

		Assert.That(result3.positive, Is.EqualTo(0));
		Assert.That(result3.negative, Is.EqualTo(3));
	}

	[Test]
	public void If6()
	{
		Assert.That(TasksLesson.Homework.If.If6(2, 3), Is.EqualTo(3));
		Assert.That(TasksLesson.Homework.If.If6(4, 1), Is.EqualTo(4));
		Assert.That(TasksLesson.Homework.If.If6(0, -1), Is.EqualTo(0));
	}

	[Test]
	public void If7()
	{
		Assert.That(TasksLesson.Homework.If.If7(2, 3), Is.EqualTo(1));
		Assert.That(TasksLesson.Homework.If.If7(4, 1), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If7(0, -1), Is.EqualTo(2));
	}

	[Test]
	public void If8()
	{
		var result1 = TasksLesson.Homework.If.If8(1, 2);
		var result2 = TasksLesson.Homework.If.If8(2, 5);
		var result3 = TasksLesson.Homework.If.If8(0, -1);

		Assert.That(result1.bigger, Is.EqualTo(2));
		Assert.That(result1.smaller, Is.EqualTo(1));

		Assert.That(result2.bigger, Is.EqualTo(5));
		Assert.That(result2.smaller, Is.EqualTo(2));

		Assert.That(result3.bigger, Is.EqualTo(0));
		Assert.That(result3.smaller, Is.EqualTo(-1));
	}

	[Test]
	public void If9()
	{
		var result1 = TasksLesson.Homework.If.If9(1, 2);
		var result2 = TasksLesson.Homework.If.If9(2, 5);
		var result3 = TasksLesson.Homework.If.If9(0, -1);

		Assert.That(result1.a, Is.EqualTo(1));
		Assert.That(result1.b, Is.EqualTo(2));

		Assert.That(result2.a, Is.EqualTo(2));
		Assert.That(result2.b, Is.EqualTo(5));

		Assert.That(result3.a, Is.EqualTo(-1));
		Assert.That(result3.b, Is.EqualTo(0));
	}

	[Test]
	public void If10()
	{
		var result1 = TasksLesson.Homework.If.If10(2, 2);
		var result2 = TasksLesson.Homework.If.If10(2, 5);
		var result3 = TasksLesson.Homework.If.If10(0, -1);

		Assert.That(result1.a, Is.EqualTo(0));
		Assert.That(result1.b, Is.EqualTo(0));

		Assert.That(result2.a, Is.EqualTo(7));
		Assert.That(result2.b, Is.EqualTo(7));

		Assert.That(result3.a, Is.EqualTo(-1));
		Assert.That(result3.b, Is.EqualTo(-1));
	}

	[Test]
	public void If11()
	{
		var result1 = TasksLesson.Homework.If.If11(2, 2);
		var result2 = TasksLesson.Homework.If.If11(2, 5);
		var result3 = TasksLesson.Homework.If.If11(0, -1);

		Assert.That(result1.a, Is.EqualTo(0));
		Assert.That(result1.b, Is.EqualTo(0));

		Assert.That(result2.a, Is.EqualTo(5));
		Assert.That(result2.b, Is.EqualTo(5));

		Assert.That(result3.a, Is.EqualTo(0));
		Assert.That(result3.b, Is.EqualTo(0));
	}

	[Test]
	public void If12()
	{
		Assert.That(TasksLesson.Homework.If.If12(2, 3, 4), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If12(4, 1, 5), Is.EqualTo(1));
		Assert.That(TasksLesson.Homework.If.If12(0, -1, -125), Is.EqualTo(-125));
	}

	[Test]
	public void If13()
	{
		Assert.That(TasksLesson.Homework.If.If13(2, 3, 4), Is.EqualTo(3));
		Assert.That(TasksLesson.Homework.If.If13(4, 1, 5), Is.EqualTo(4));
		Assert.That(TasksLesson.Homework.If.If13(0, -1, -125), Is.EqualTo(-1));
	}

	[Test]
	public void If14()
	{
		var result1 = TasksLesson.Homework.If.If14(1, 2, 3);
		var result2 = TasksLesson.Homework.If.If14(0, 1, 2);
		var result3 = TasksLesson.Homework.If.If14(5, 6, 78);

		Assert.That(result1.min, Is.EqualTo(1));
		Assert.That(result1.max, Is.EqualTo(3));

		Assert.That(result2.min, Is.EqualTo(0));
		Assert.That(result2.max, Is.EqualTo(2));

		Assert.That(result3.min, Is.EqualTo(5));
		Assert.That(result3.max, Is.EqualTo(78));
	}

	[Test]
	public void If15()
	{
		Assert.That(TasksLesson.Homework.If.If15(2, 3, 4), Is.EqualTo(7));
		Assert.That(TasksLesson.Homework.If.If15(4, 1, 5), Is.EqualTo(9));
		Assert.That(TasksLesson.Homework.If.If15(0, -1, -125), Is.EqualTo(-1));
	}

	[Test]
	public void If16()
	{
		var result1 = TasksLesson.Homework.If.If16(1, 2, 3);
		var result2 = TasksLesson.Homework.If.If16(0, 1, 2);
		var result3 = TasksLesson.Homework.If.If16(5, 78, 6);

		Assert.That(result1.a, Is.EqualTo(2));
		Assert.That(result1.b, Is.EqualTo(4));
		Assert.That(result1.c, Is.EqualTo(6));

		Assert.That(result2.a, Is.EqualTo(0));
		Assert.That(result2.b, Is.EqualTo(2));
		Assert.That(result2.c, Is.EqualTo(4));

		Assert.That(result3.a, Is.EqualTo(-5));
		Assert.That(result3.b, Is.EqualTo(-78));
		Assert.That(result3.c, Is.EqualTo(-6));
	}

	[Test]
	public void If17()
	{
		var result1 = TasksLesson.Homework.If.If17(1, 2, 3);
		var result2 = TasksLesson.Homework.If.If17(2, 1, 0);
		var result3 = TasksLesson.Homework.If.If17(5, 78, 6);

		Assert.That(result1.a, Is.EqualTo(2));
		Assert.That(result1.b, Is.EqualTo(4));
		Assert.That(result1.c, Is.EqualTo(6));

		Assert.That(result2.a, Is.EqualTo(4));
		Assert.That(result2.b, Is.EqualTo(2));
		Assert.That(result2.c, Is.EqualTo(0));

		Assert.That(result3.a, Is.EqualTo(-5));
		Assert.That(result3.b, Is.EqualTo(-78));
		Assert.That(result3.c, Is.EqualTo(-6));
	}

	[Test]
	public void If18()
	{
		Assert.That(TasksLesson.Homework.If.If18(2, 3, 2), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If18(4, 5, 5), Is.EqualTo(1));
		Assert.That(TasksLesson.Homework.If.If18(0, -1, -125), Is.EqualTo(0));
	}

	[Test]
	public void If19()
	{
		Assert.That(TasksLesson.Homework.If.If19(2, 3, 2, 2), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If19(4, 5, 5, 5), Is.EqualTo(1));
		Assert.That(TasksLesson.Homework.If.If19(0, -1, -125, 2), Is.EqualTo(0));
	}

	[Test]
	public void If20()
	{
		var result1 = TasksLesson.Homework.If.If20(2, 3, 5);
		var result2 = TasksLesson.Homework.If.If20(2, 5, 1);
		var result3 = TasksLesson.Homework.If.If20(0, -1, 4);

		Assert.That(result1.point, Is.EqualTo('B'));
		Assert.That(result1.distance, Is.EqualTo(1));

		Assert.That(result2.point, Is.EqualTo('C'));
		Assert.That(result2.distance, Is.EqualTo(1));

		Assert.That(result3.point, Is.EqualTo('B'));
		Assert.That(result3.distance, Is.EqualTo(1));
	}

	[Test]
	public void If21()
	{
		Assert.That(TasksLesson.Homework.If.If21(0, 0), Is.EqualTo(0));
		Assert.That(TasksLesson.Homework.If.If21(1, 0), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If21(-1, 1), Is.EqualTo(3));
	}

	[Test]
	public void If22()
	{
		Assert.That(TasksLesson.Homework.If.If22(0, 0), Is.EqualTo(0));
		Assert.That(TasksLesson.Homework.If.If22(1, 1), Is.EqualTo(1));
		Assert.That(TasksLesson.Homework.If.If22(-1, 1), Is.EqualTo(2));
		Assert.That(TasksLesson.Homework.If.If22(-1, -1), Is.EqualTo(3));
		Assert.That(TasksLesson.Homework.If.If22(1, -1), Is.EqualTo(4));
	}

	[Test]
	public void If23()
	{
		var x1 = 0;
		var y1 = 2;
		var x2 = 2;
		var y2 = 2;
		var x3 = 0;
		var y3 = 0;
		var expectedResult = new Point(2, 0);

		var result = TasksLesson.Homework.If.If23(x1, y1, x2, y2, x3, y3);

		Assert.That(result.X, Is.EqualTo(expectedResult.X));
        Assert.That(result.Y, Is.EqualTo(expectedResult.Y));
	}

	[Test]
	public void If24()
	{
		Assert.That(TasksLesson.Homework.If.If24(1), Is.EqualTo(2 * (float) Math.Sin(1)));
		Assert.That(TasksLesson.Homework.If.If24(-1), Is.EqualTo(7));
	}

	[Test]
	public void If25()
	{
		float x1 = 3;
		float x2 = -3;
		float x3 = 0;

		float result1 = TasksLesson.Homework.If.If25(x1);
		float result2 = TasksLesson.Homework.If.If25(x2);
		float result3 = TasksLesson.Homework.If.If25(x3);

		float expected1 = 2* x1;
		float expected2 = 2* x2;
		float expected3 = -3 * x3;

		Assert.That(result1, Is.EqualTo(expected1));
		Assert.That(result2, Is.EqualTo(expected2));
		Assert.That(result3, Is.EqualTo(expected3));
	}

	[Test]
	public void If26()
	{
		//expected output is -x when x <= 0
		Assert.That(TasksLesson.Homework.If.If26(-1), Is.EqualTo(1));

		//expected output is x*x when 0 < x < 2
		Assert.That(TasksLesson.Homework.If.If26(1), Is.EqualTo(1));

		//expected output is 4 when x >= 2
		Assert.That(TasksLesson.Homework.If.If26(2), Is.EqualTo(4));
	}

	[Test]
	public void If27()
	{
		var result1 = TasksLesson.Homework.If.If27(-1);
		var result2 = TasksLesson.Homework.If.If27(0.5f);
		var result3 = TasksLesson.Homework.If.If27(1.5f);
		var result4 = TasksLesson.Homework.If.If27(2.5f);
		var result5 = TasksLesson.Homework.If.If27(4.5f);

		Assert.That(result1, Is.EqualTo(0));
		Assert.That(result2, Is.EqualTo(1));
		Assert.That(result3, Is.EqualTo(-1));
		Assert.That(result4, Is.EqualTo(1));
		Assert.That(result5, Is.EqualTo(1));
	}

	[Test]
	public void If28()
	{
		// Leap year
		var result1 = TasksLesson.Homework.If.If28(2000); // using a year that is a multiple of 400
		Assert.That(result1, Is.EqualTo(366));

		// Leap year
		var result2 = TasksLesson.Homework.If.If28(2016); // using a year that is a multiple of 4 but not 100
		Assert.That(result2, Is.EqualTo(366));

		// Non-leap year
		var result3 = TasksLesson.Homework.If.If28(2100); // using a year that is a multiple of 100 but not 400
		Assert.That(result3, Is.EqualTo(365));

		// Non-leap year
		var result4 = TasksLesson.Homework.If.If28(2001); // using a year that is not a multiple of 4
		Assert.That(result4, Is.EqualTo(365));
	}

	[Test]
	public void If29()
	{
		string result1 = TasksLesson.Homework.If.If29(10);
		string result2 = TasksLesson.Homework.If.If29(-10);
		string result3 = TasksLesson.Homework.If.If29(0);

		Assert.That(result1, Is.EqualTo("положительное четное число"));
		Assert.That(result2, Is.EqualTo("отрицательное четное число"));
		Assert.That(result3, Is.EqualTo("нулевое число"));
	}

	[Test]
	public void If30()
	{
		var result = TasksLesson.Homework.If.If30(2);
		Assert.That(result, Is.EqualTo("четное однозначное число"));

		var result1 = TasksLesson.Homework.If.If30(3);
		Assert.That(result1, Is.EqualTo("нечетное однозначное число"));

		var result2 = TasksLesson.Homework.If.If30(22);
		Assert.That(result2, Is.EqualTo("четное двузначное число"));

		var result3 = TasksLesson.Homework.If.If30(33);
		Assert.That(result3, Is.EqualTo("нечетное двузначное число"));

		var result4 = TasksLesson.Homework.If.If30(202);
		Assert.That(result4, Is.EqualTo("четное трехзначное число"));

		var result5 = TasksLesson.Homework.If.If30(303);
		Assert.That(result5, Is.EqualTo("нечетное трехзначное число"));
	}
}