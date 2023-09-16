namespace Tests;

public class Integer
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void Integer1()
	{
		int result1 = TasksLesson.Homework.Integer.Integer1(1000);
		int result2 = TasksLesson.Homework.Integer.Integer1(10000);
		int result3 = TasksLesson.Homework.Integer.Integer1(300);

		Assert.That(result1, Is.EqualTo(10));
		Assert.That(result2, Is.EqualTo(100));
		Assert.That(result3, Is.EqualTo(3));
	}

	[Test]
	public void Integer2()
	{
		int result1 = TasksLesson.Homework.Integer.Integer2(1000);
		int result2 = TasksLesson.Homework.Integer.Integer2(10000);
		int result3 = TasksLesson.Homework.Integer.Integer2(3000);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(10));
		Assert.That(result3, Is.EqualTo(3));
	}

	[Test]
	public void Integer3()
	{
		int result1 = TasksLesson.Homework.Integer.Integer3(2048);
		int result2 = TasksLesson.Homework.Integer.Integer3(4096);
		int result3 = TasksLesson.Homework.Integer.Integer3(1024);

		Assert.That(result1, Is.EqualTo(2));
		Assert.That(result2, Is.EqualTo(4));
		Assert.That(result3, Is.EqualTo(1));
	}

	[Test]
	public void Integer4()
	{
		int result1 = TasksLesson.Homework.Integer.Integer4(10, 2);
		int result2 = TasksLesson.Homework.Integer.Integer4(10, 3);
		int result3 = TasksLesson.Homework.Integer.Integer4(10, 1);

		Assert.That(result1, Is.EqualTo(5));
		Assert.That(result2, Is.EqualTo(3));
		Assert.That(result3, Is.EqualTo(10));
	}

	[Test]
	public void Integer5()
	{
		int result1 = TasksLesson.Homework.Integer.Integer5(10, 2);
		int result2 = TasksLesson.Homework.Integer.Integer5(10, 3);
		int result3 = TasksLesson.Homework.Integer.Integer5(10, 1);

		Assert.That(result1, Is.EqualTo(0));
		Assert.That(result2, Is.EqualTo(1));
		Assert.That(result3, Is.EqualTo(0));
	}

	[Test]
	public void Integer6()
	{
		var result1 = TasksLesson.Homework.Integer.Integer6(15);
		var result2 = TasksLesson.Homework.Integer.Integer6(17);
		var result3 = TasksLesson.Homework.Integer.Integer6(39);

		Assert.That(result1.dozens, Is.EqualTo(1));
		Assert.That(result1.units, Is.EqualTo(5));

		Assert.That(result2.dozens, Is.EqualTo(1));
		Assert.That(result2.units, Is.EqualTo(7));

		Assert.That(result3.dozens, Is.EqualTo(3));
		Assert.That(result3.units, Is.EqualTo(9));
	}

	[Test]
	public void Integer7()
	{
		var result1 = TasksLesson.Homework.Integer.Integer7(15);
		var result2 = TasksLesson.Homework.Integer.Integer7(17);
		var result3 = TasksLesson.Homework.Integer.Integer7(39);

		Assert.That(result1.sum, Is.EqualTo(6));
		Assert.That(result1.multiply, Is.EqualTo(5));

		Assert.That(result2.sum, Is.EqualTo(8));
		Assert.That(result2.multiply, Is.EqualTo(7));

		Assert.That(result3.sum, Is.EqualTo(12));
		Assert.That(result3.multiply, Is.EqualTo(27));
	}

	[Test]
	public void Integer8()
	{
		int result1 = TasksLesson.Homework.Integer.Integer8(15);
		int result2 = TasksLesson.Homework.Integer.Integer8(17);
		int result3 = TasksLesson.Homework.Integer.Integer8(39);

		Assert.That(result1, Is.EqualTo(51));
		Assert.That(result2, Is.EqualTo(71));
		Assert.That(result3, Is.EqualTo(93));
	}

	[Test]
	public void Integer9()
	{
		int result1 = TasksLesson.Homework.Integer.Integer9(123);
		int result2 = TasksLesson.Homework.Integer.Integer9(456);
		int result3 = TasksLesson.Homework.Integer.Integer9(789);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(4));
		Assert.That(result3, Is.EqualTo(7));
	}

	[Test]
	public void Integer10()
	{
		var result1 = TasksLesson.Homework.Integer.Integer10(123);
		var result2 = TasksLesson.Homework.Integer.Integer10(456);
		var result3 = TasksLesson.Homework.Integer.Integer10(789);

		Assert.That(result1.b, Is.EqualTo(2));
		Assert.That(result1.c, Is.EqualTo(3));

		Assert.That(result2.b, Is.EqualTo(5));
		Assert.That(result2.c, Is.EqualTo(6));

		Assert.That(result3.b, Is.EqualTo(8));
		Assert.That(result3.c, Is.EqualTo(9));
	}

	[Test]
	public void Integer11()
	{
		var result1 = TasksLesson.Homework.Integer.Integer11(123);
		var result2 = TasksLesson.Homework.Integer.Integer11(456);
		var result3 = TasksLesson.Homework.Integer.Integer11(789);

		Assert.That(result1.sum, Is.EqualTo(6));
		Assert.That(result1.multiply, Is.EqualTo(6));

		Assert.That(result2.sum, Is.EqualTo(15));
		Assert.That(result2.multiply, Is.EqualTo(120));

		Assert.That(result3.sum, Is.EqualTo(24));
		Assert.That(result3.multiply, Is.EqualTo(504));
	}

	[Test]
	public void Integer12()
	{
		int result1 = TasksLesson.Homework.Integer.Integer12(123);
		int result2 = TasksLesson.Homework.Integer.Integer12(456);
		int result3 = TasksLesson.Homework.Integer.Integer12(789);

		Assert.That(result1, Is.EqualTo(321));
		Assert.That(result2, Is.EqualTo(654));
		Assert.That(result3, Is.EqualTo(987));
	}

	[Test]
	public void Integer13()
	{
		int result1 = TasksLesson.Homework.Integer.Integer13(123);
		int result2 = TasksLesson.Homework.Integer.Integer13(456);
		int result3 = TasksLesson.Homework.Integer.Integer13(789);

		Assert.That(result1, Is.EqualTo(231));
		Assert.That(result2, Is.EqualTo(564));
		Assert.That(result3, Is.EqualTo(897));
	}

	[Test]
	public void Integer14()
	{
		int result1 = TasksLesson.Homework.Integer.Integer14(123);
		int result2 = TasksLesson.Homework.Integer.Integer14(456);
		int result3 = TasksLesson.Homework.Integer.Integer14(789);

		Assert.That(result1, Is.EqualTo(312));
		Assert.That(result2, Is.EqualTo(645));
		Assert.That(result3, Is.EqualTo(978));
	}

	[Test]
	public void Integer15()
	{
		int result1 = TasksLesson.Homework.Integer.Integer15(123);
		int result2 = TasksLesson.Homework.Integer.Integer15(456);
		int result3 = TasksLesson.Homework.Integer.Integer15(789);

		Assert.That(result1, Is.EqualTo(213));
		Assert.That(result2, Is.EqualTo(546));
		Assert.That(result3, Is.EqualTo(879));
	}

	[Test]
	public void Integer16()
	{
		int result1 = TasksLesson.Homework.Integer.Integer16(123);
		int result2 = TasksLesson.Homework.Integer.Integer16(456);
		int result3 = TasksLesson.Homework.Integer.Integer16(789);

		Assert.That(result1, Is.EqualTo(132));
		Assert.That(result2, Is.EqualTo(465));
		Assert.That(result3, Is.EqualTo(798));
	}

	[Test]
	public void Integer17()
	{
		int result1 = TasksLesson.Homework.Integer.Integer17(1001);
		int result2 = TasksLesson.Homework.Integer.Integer17(2303);
		int result3 = TasksLesson.Homework.Integer.Integer17(3502);

		Assert.That(result1, Is.EqualTo(0));
		Assert.That(result2, Is.EqualTo(3));
		Assert.That(result3, Is.EqualTo(5));
	}

	[Test]
	public void Integer18()
	{
		int result1 = TasksLesson.Homework.Integer.Integer18(1001);
		int result2 = TasksLesson.Homework.Integer.Integer18(2303);
		int result3 = TasksLesson.Homework.Integer.Integer18(3502);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(2));
		Assert.That(result3, Is.EqualTo(3));
	}

	[Test]
	public void Integer19()
	{
		int result1 = TasksLesson.Homework.Integer.Integer19(3600);
		int result2 = TasksLesson.Homework.Integer.Integer19(7200);
		int result3 = TasksLesson.Homework.Integer.Integer19(9999);

		Assert.That(result1, Is.EqualTo(60));
		Assert.That(result2, Is.EqualTo(120));
		Assert.That(result3, Is.EqualTo(166));
	}

	[Test]
	public void Integer20()
	{
		int result1 = TasksLesson.Homework.Integer.Integer20(3600);
		int result2 = TasksLesson.Homework.Integer.Integer20(7200);
		int result3 = TasksLesson.Homework.Integer.Integer20(9999);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(2));
		Assert.That(result3, Is.EqualTo(2));
	}

	[Test]
	public void Integer21()
	{
		int result1 = TasksLesson.Homework.Integer.Integer21(61);
		int result2 = TasksLesson.Homework.Integer.Integer21(66);
		int result3 = TasksLesson.Homework.Integer.Integer21(59);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(6));
		Assert.That(result3, Is.EqualTo(59));
	}

	[Test]
	public void Integer22()
	{
		int result1 = TasksLesson.Homework.Integer.Integer22(3601);
		int result2 = TasksLesson.Homework.Integer.Integer22(7206);
		int result3 = TasksLesson.Homework.Integer.Integer22(9999);

		Assert.That(result1, Is.EqualTo(1));
		Assert.That(result2, Is.EqualTo(6));
		Assert.That(result3, Is.EqualTo(2799));
	}

	[Test]
	public void Integer23()
	{
		int result1 = TasksLesson.Homework.Integer.Integer23(3601);
		int result2 = TasksLesson.Homework.Integer.Integer23(7206);
		int result3 = TasksLesson.Homework.Integer.Integer23(9999);

		Assert.That(result1, Is.EqualTo(0));
		Assert.That(result2, Is.EqualTo(0));
		Assert.That(result3, Is.EqualTo(46));
	}

	[Test]
	public void Integer24()
	{
		int result1 = TasksLesson.Homework.Integer.Integer24(340);
		int result2 = TasksLesson.Homework.Integer.Integer24(365);
		int result3 = TasksLesson.Homework.Integer.Integer24(127);

		Assert.That(result1, Is.EqualTo(4));
		Assert.That(result2, Is.EqualTo(1));
		Assert.That(result3, Is.EqualTo(1));
	}

	[Test]
	public void Integer25()
	{
		int result1 = TasksLesson.Homework.Integer.Integer25(340);
		int result2 = TasksLesson.Homework.Integer.Integer25(365);
		int result3 = TasksLesson.Homework.Integer.Integer25(1);

		Assert.That(result1, Is.EqualTo(7));
		Assert.That(result2, Is.EqualTo(4));
		Assert.That(result3, Is.EqualTo(4));
	}

	[Test]
	public void Integer26()
	{
		int result1 = TasksLesson.Homework.Integer.Integer26(340);
		int result2 = TasksLesson.Homework.Integer.Integer26(365);
		int result3 = TasksLesson.Homework.Integer.Integer26(1);

		Assert.That(result1, Is.EqualTo(5));
		Assert.That(result2, Is.EqualTo(2));
		Assert.That(result3, Is.EqualTo(2));
	}

	[Test]
	public void Integer27()
	{
		int result1 = TasksLesson.Homework.Integer.Integer27(340);
		int result2 = TasksLesson.Homework.Integer.Integer27(365);
		int result3 = TasksLesson.Homework.Integer.Integer27(1);

		Assert.That(result1, Is.EqualTo(2));
		Assert.That(result2, Is.EqualTo(6));
		Assert.That(result3, Is.EqualTo(6));
	}

	[Test]
	public void Integer28()
	{
		int result1 = TasksLesson.Homework.Integer.Integer28(340, 4);
		int result2 = TasksLesson.Homework.Integer.Integer28(365, 2);
		int result3 = TasksLesson.Homework.Integer.Integer28(1, 6);

		Assert.That(result1, Is.EqualTo(7));
		Assert.That(result2, Is.EqualTo(2));
		Assert.That(result3, Is.EqualTo(6));
	}

	[Test]
	public void Integer29()
	{
		var result1 = TasksLesson.Homework.Integer.Integer29(10, 10, 2);
		var result2 = TasksLesson.Homework.Integer.Integer29(10, 10, 3);
		var result3 = TasksLesson.Homework.Integer.Integer29(10, 10, 1);

		Assert.That(result1.count, Is.EqualTo(25));
		Assert.That(result1.area, Is.EqualTo(0));

		Assert.That(result2.count, Is.EqualTo(9));
		Assert.That(result2.area, Is.EqualTo(19));

		Assert.That(result3.count, Is.EqualTo(100));
		Assert.That(result3.area, Is.EqualTo(0));
	}

	[Test]
	public void Integer30()
	{
		int result1 = TasksLesson.Homework.Integer.Integer30(1925);
		int result2 = TasksLesson.Homework.Integer.Integer30(2023);
		int result3 = TasksLesson.Homework.Integer.Integer30(9024);

		Assert.That(result1, Is.EqualTo(20));
		Assert.That(result2, Is.EqualTo(21));
		Assert.That(result3, Is.EqualTo(91));
	}

	[TestCase(49, ExpectedResult = false)]
	[TestCase(53, ExpectedResult = true)]
	public bool IsPrimeTest(int input)
	{
		return input.IsPrime ();
	}
}