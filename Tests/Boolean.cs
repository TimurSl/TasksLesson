namespace Tests;

public class Boolean
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void Boolean1()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean1(1));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean1(0));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean1(-1));
	}

	[Test]
	public void Boolean2()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean2(1));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean2(0));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean2(-1));
	}

	[Test]
	public void Boolean3()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean3(2));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean3(1));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean3(0));
	}

	[Test]
	public void Boolean4()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean4(3, 2));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean4(2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean4(2, 2));
	}

	[Test]
	public void Boolean5()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean5(0, -3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean5(-2, -2));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean5(1, -3));
	}

	[Test]
	public void Boolean6()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean6(1, 2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean6(1, 3, 2));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean6(3, 2, 1));
	}

	[Test]
	public void Boolean7()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean7(1, 2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean7(1, 3, 2));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean7(3, 2, 1));
	}

	[Test]
	public void Boolean8()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean8(1, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean8(1, 2));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean8(2, 3));
	}

	[Test]
	public void Boolean9()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean9(1, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean9(2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean9(2, 2));
	}

	[Test]
	public void Boolean10()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean10(1, 2));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean10(2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean10(2, 2));
	}

	[Test]
	public void Boolean11()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean11(1, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean11(2, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean11(2, 3));
	}

	[Test]
	public void Boolean12()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean12(1, 2, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean12(2, 3, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean12(-2, -3, 3));
	}

	[Test]
	public void Boolean13()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean13(-1, -2, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean13(-2, 3, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean13(-2, -3, -3));
	}

	[Test]
	public void Boolean14()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean14(-1, -2, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean14(-2, 3, -4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean14(-2, 3, 3));
	}

	[Test]
	public void Boolean15()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean15(-1, 2, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean15(2, 3, -4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean15(-2, -3, 3));
	}

	[Test]
	public void Boolean16()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean16(12));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean16(15));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean16(1202));
	}

	[Test]
	public void Boolean17()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean17(121));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean17(150));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean17(1202));
	}

	[Test]
	public void Boolean18()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean18(3, 3, 2));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean18(3, 2, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean18(-2, 5, 3));
	}

	[Test]
	public void Boolean19()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean19(3, -3, 2));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean19(3, 2, -3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean19(3, 5, 3));
	}

	[Test]
	public void Boolean20()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean20(123));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean20(322));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean20(222));
	}

	[Test]
	public void Boolean21()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean21(123));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean21(322));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean21(222));
	}

	[Test]
	public void Boolean22()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean22(123));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean22(321));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean22(222));
	}

	[Test]
	public void Boolean23()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean23(1221));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean23(2002));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean23(2223));
	}

	[Test]
	public void Boolean24()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean24(1, 8, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean24(2, 6, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean24(1, 2, 3));
	}

	[Test]
	public void Boolean25()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean25(-1, 8));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean25(-2, 6));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean25(1, 2));
	}

	[Test]
	public void Boolean26()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean26(1, -8));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean26(2, -6));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean26(1, 2));
	}

	[Test]
	public void Boolean27()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean27(3, 8));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean27(-2, 6));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean27(-1, -2));
	}

	[Test]
	public void Boolean28()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean28(3, 8));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean28(-2, -6));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean28(-1, 2));
	}

	[Test]
	public void Boolean29()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean29(0, 0, 5, 5, -5,-5));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean29(1, 1, 2, 2, -1, -1));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean29(1, 1, 2, 2, 1, 2));
	}

	[Test]
	public void Boolean30()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean30(3, 3, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean30(4, 4, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean30(1, 2, 3));
	}

	[Test]
	public void Boolean31()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean31(3, 6, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean31(4, 8, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean31(1, 2, 3));
	}

	[Test]
	public void Boolean32()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean32(9, 6, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean32(4, 8, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean32(9, 2, 3));
	}

	[Test]
	public void Boolean33()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean33(3, 8, 9));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean33(4, 8, 6));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean33(12, 112, 12));
	}

	[Test]
	public void Boolean34()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean34(2, 1));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean34(4, 3));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean34(1, 1));
	}

	[Test]
	public void Boolean35()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean35(2, 1, 4, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean35(6, 5, 8, 7));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean35(1, 1, 1, 2));
	}

	[Test]
	public void Boolean36()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean36(1, 1, 9, 1));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean36(2, 3, 2, 9));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean36(1, 1, 2, 2));
	}

	[Test]
	public void Boolean37()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean37(1, 1, 2, 1));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean37(2, 3, 3, 4));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean37(1, 1, 5, 2));
	}

	[Test]
	public void Boolean38()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean38(1, 1, 3, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean38(4, 3, 8, 7));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean38(1, 1, 1, 8));
	}

	[Test]
	public void Boolean39()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean39(1, 1, 3, 3));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean39(4, 3, 8, 7));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean39(1, 1, 1, 8));
	}


	[Test]
	public void Boolean40()
	{
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean40(8, 1, 6, 2));
		Assert.IsTrue(TasksLesson.Homework.Boolean.Boolean40(4, 7, 5, 5));
		Assert.IsFalse(TasksLesson.Homework.Boolean.Boolean40(1, 1, 1, 8));
	}
}