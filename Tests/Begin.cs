using TasksLesson.Homework;

namespace Tests;

public class Tests
{
	const float Tolerance = 0.001f;
	const float PI = 3.14f;

	[SetUp]
	public void Setup()
	{

	}

	[Test]
	public void Begin1Test()
	{
		Assert.That(Begin.Begin1(2), Is.EqualTo(8));
		Assert.That(Begin.Begin1(0), Is.EqualTo(0));
		Assert.That(Begin.Begin1(-3), Is.EqualTo(-12));
	}

	[Test]
	public void Begin2Test()
	{
		Assert.That(Begin.Begin2(2), Is.EqualTo(4));
		Assert.That(Begin.Begin2(0), Is.EqualTo(0));
		Assert.That(Begin.Begin2(-3), Is.EqualTo(9));
	}

	[Test]
	public void Begin3Test()
	{
		var result1 = Begin.Begin3(2, 3);
		var result2 = Begin.Begin3(0, 0);
		var result3 = Begin.Begin3(-2, 4);

		Assert.That(result1.area, Is.EqualTo(6));
		Assert.That(result1.perimeter, Is.EqualTo(10));
		Assert.That(result2.area, Is.EqualTo(0));
		Assert.That(result2.perimeter, Is.EqualTo(0));
		Assert.That(result3.area, Is.EqualTo(-8));
		Assert.That(result3.perimeter, Is.EqualTo(4));
	}

	[Test]
	public void Begin4Test()
	{
		Assert.That(Begin.Begin4(2), Is.EqualTo(6.28).Within(0.01));
		Assert.That(Begin.Begin4(0), Is.EqualTo(0));
		Assert.That(Begin.Begin4(-3), Is.EqualTo(-9.42).Within(0.01));
	}

	[Test]
	public void Begin5Test()
	{
		var result1 = Begin.Begin5(2);
		var result2 = Begin.Begin5(0);
		var result3 = Begin.Begin5(-3);

		Assert.That(result1.volume, Is.EqualTo(8));
		Assert.That(result1.area, Is.EqualTo(24));
		Assert.That(result2.volume, Is.EqualTo(0));
		Assert.That(result2.area, Is.EqualTo(0));
		Assert.That(result3.volume, Is.EqualTo(-27));
		Assert.That(result3.area, Is.EqualTo(54));
	}

	[Test]
    public void Begin6Test()
    {
        var result1 = Begin.Begin6(2, 3, 4);
        var result2 = Begin.Begin6(0, 0, 0);
        var result3 = Begin.Begin6(-2, 4, 1);

        Assert.That(result1.volume, Is.EqualTo(24));
        Assert.That(result1.area, Is.EqualTo(52));

        Assert.That(result2.volume, Is.EqualTo(0));
        Assert.That(result2.area, Is.EqualTo(0));

        Assert.That(result3.volume, Is.EqualTo(-8));
        Assert.That(result3.area, Is.EqualTo(-12));
    }

    [Test]
    public void Begin7Test()
    {
        var result1 = Begin.Begin7(2);
        var result2 = Begin.Begin7(0);
        var result3 = Begin.Begin7(-3);

        Assert.That(result1.length, Is.EqualTo(12.56).Within(0.01));
        Assert.That(result1.area, Is.EqualTo(12.56).Within(0.01));
        Assert.That(result2.length, Is.EqualTo(0));
        Assert.That(result2.area, Is.EqualTo(0));
        Assert.That(result3.length, Is.EqualTo(-18.84).Within(0.01));
        Assert.That(result3.area, Is.EqualTo(28.27).Within(0.01));
    }

    [Test]
    public void Begin8Test()
    {
        Assert.That(Begin.Begin8(2, 4), Is.EqualTo(3));
        Assert.That(Begin.Begin8(0, 0), Is.EqualTo(0));
        Assert.That(Begin.Begin8(-3, 5), Is.EqualTo(1));
    }

    [Test]
    public void Begin9Test()
    {
        Assert.That(Begin.Begin9(4, 9), Is.EqualTo(6));
        Assert.That(Begin.Begin9(0, 5), Is.EqualTo(0));
        Assert.That(Begin.Begin9(3, 3), Is.EqualTo(3));
    }

    [Test]
    public void Begin10Test()
    {
        var result1 = Begin.Begin10(4, 9);
        var result2 = Begin.Begin10(0, 16);
        var result3 = Begin.Begin10(1, 25);

        Assert.That(result1.sum, Is.EqualTo(5));
        Assert.That(result1.difference, Is.EqualTo(1));
        Assert.That(result1.multiply, Is.EqualTo(6));
        Assert.That(result1.quotient, Is.EqualTo(0.666666).Within(0.0001));

        Assert.That(result2.sum, Is.EqualTo(4));
        Assert.That(result2.difference, Is.EqualTo(4));
        Assert.That(result2.multiply, Is.EqualTo(0));
        Assert.That(result2.quotient, Is.EqualTo(0));

        Assert.That(result3.sum, Is.EqualTo(6));
        Assert.That(result3.difference, Is.EqualTo(4));
        Assert.That(result3.multiply, Is.EqualTo(5));
        Assert.That(result3.quotient, Is.EqualTo(0.2).Within(0.0001));
    }

    [Test]
    public void Begin11Test()
    {
	    var result1 = Begin.Begin10(4, 9);
	    var result2 = Begin.Begin10(0, 16);
	    var result3 = Begin.Begin10(1, 25);

	    Assert.That(result1.sum, Is.EqualTo(5));
	    Assert.That(result1.difference, Is.EqualTo(1));
	    Assert.That(result1.multiply, Is.EqualTo(6));
	    Assert.That(result1.quotient, Is.EqualTo(0.666666).Within(0.0001));

	    Assert.That(result2.sum, Is.EqualTo(4));
	    Assert.That(result2.difference, Is.EqualTo(4));
	    Assert.That(result2.multiply, Is.EqualTo(0));
	    Assert.That(result2.quotient, Is.EqualTo(0));

	    Assert.That(result3.sum, Is.EqualTo(6));
	    Assert.That(result3.difference, Is.EqualTo(4));
	    Assert.That(result3.multiply, Is.EqualTo(5));
	    Assert.That(result3.quotient, Is.EqualTo(0.2).Within(0.0001));
    }

    [Test]
    public void Begin12Test()
    {
        var result1 = Begin.Begin12(3, 4);
        var result2 = Begin.Begin12(0, 5);
        var result3 = Begin.Begin12(-3, 0);

        Assert.That(result1.hypotenuse, Is.EqualTo(5));
        Assert.That(result1.perimeter, Is.EqualTo(12));

        Assert.That(result2.hypotenuse, Is.EqualTo(5));
        Assert.That(result2.perimeter, Is.EqualTo(10));

        Assert.That(result3.hypotenuse, Is.EqualTo(3));
        Assert.That(result3.perimeter, Is.EqualTo(0));
    }

    [Test]
    public void Begin13Test()
    {
        var result1 = Begin.Begin13(2, 1);

        Assert.That(Math.Round(result1.s1, 2), Is.EqualTo(12.56).Within(0.01));
        Assert.That(Math.Round(result1.s2, 2), Is.EqualTo(3.14));
        Assert.That(Math.Round(result1.s3, 2), Is.EqualTo(9.42).Within(0.01));
    }

    [Test]
    public void Begin14Test()
    {
        var result1 = Begin.Begin14(12.56f);
        var result2 = Begin.Begin14(0f);
        var result3 = Begin.Begin14(-18.84f);

        Assert.That(result1.radius, Is.EqualTo(2).Within(0.01));
        Assert.That(result1.square, Is.EqualTo(12.56).Within(0.01));
        Assert.That(result2.radius, Is.EqualTo(0));
        Assert.That(result2.square, Is.EqualTo(0));
        Assert.That(result3.radius, Is.EqualTo(-3).Within(0.01));
        Assert.That(result3.square, Is.EqualTo(28.27).Within(0.01));
    }

    [Test]
    public void Begin15Test()
    {
        var result1 = Begin.Begin15(12.56f);
        var result2 = Begin.Begin15(0f);
        var result3 = Begin.Begin15(28.27f);

        Assert.That(result1.diameter, Is.EqualTo(4).Within(0.01));
        Assert.That(result1.length, Is.EqualTo(12.56).Within(0.01));
        Assert.That(result2.diameter, Is.EqualTo(0));
        Assert.That(result2.length, Is.EqualTo(0));
        Assert.That(result3.diameter, Is.EqualTo(6).Within(0.01));
        Assert.That(result3.length, Is.EqualTo(18.84).Within(0.01));
    }

    [Test]
    public void Begin16Test()
    {
        Assert.That(Begin.Begin16(2, 5), Is.EqualTo(3));
        Assert.That(Begin.Begin16(0, 0), Is.EqualTo(0));
        Assert.That(Begin.Begin16(-3, -1), Is.EqualTo(2));
    }

    [Test]
    public void Begin17Test()
    {
        var result1 = Begin.Begin17(1, 5, 3);
        var result2 = Begin.Begin17(0, 0, 0);
        var result3 = Begin.Begin17(-2, -4, -1);

        Assert.That(result1.AC, Is.EqualTo(2));
        Assert.That(result1.BC, Is.EqualTo(2));
        Assert.That(result1.sum, Is.EqualTo(4));

        Assert.That(result2.AC, Is.EqualTo(0));
        Assert.That(result2.BC, Is.EqualTo(0));
        Assert.That(result2.sum, Is.EqualTo(0));

        Assert.That(result3.AC, Is.EqualTo(1));
        Assert.That(result3.BC, Is.EqualTo(3));
        Assert.That(result3.sum, Is.EqualTo(4));
    }

    [Test]
    public void Begin18Test()
    {
        var result1 = Begin.Begin18(1, 5, 3);
        var result2 = Begin.Begin18(0, 0, 0);
        var result3 = Begin.Begin18(-2, -4, -1);

        Assert.That(result1.AC, Is.EqualTo(2));
        Assert.That(result1.BC, Is.EqualTo(2));
        Assert.That(result1.product, Is.EqualTo(4));

        Assert.That(result2.AC, Is.EqualTo(0));
        Assert.That(result2.BC, Is.EqualTo(0));
        Assert.That(result2.product, Is.EqualTo(0));

        Assert.That(result3.AC, Is.EqualTo(1));
        Assert.That(result3.BC, Is.EqualTo(3));
        Assert.That(result3.product, Is.EqualTo(3));
    }

    [Test]
    public void Begin19Test()
    {
        var result1 = Begin.Begin19(1, 5, 3, 7);
        var result2 = Begin.Begin19(0, 0, 0, 0);
        var result3 = Begin.Begin19(2, 2, 2, 2);

        Assert.That(result1.perimeter, Is.EqualTo(6));
        Assert.That(result1.area, Is.EqualTo(4));

        Assert.That(result2.perimeter, Is.EqualTo(0));
        Assert.That(result2.area, Is.EqualTo(0));

        Assert.That(result3.perimeter, Is.EqualTo(0));
        Assert.That(result3.area, Is.EqualTo(0));
    }

    [Test]
    public void Begin20Test()
    {
        Assert.That(Begin.Begin20(0, 0, 0, 0), Is.EqualTo(0));
        Assert.That(Begin.Begin20(1, 1, 1, 1), Is.EqualTo(0));
        Assert.That(MathF.Round(Begin.Begin20(0, 1, 1, 0), 0), Is.EqualTo(1));
        Assert.That(MathF.Round(Begin.Begin20(2, 3, 6, 9), 0), Is.EqualTo(7));
    }

    [Test]
    public void Begin21Test()
    {
        var result1 = Begin.Begin21(0, 0, 0, 0, 0, 0);
        var result2 = Begin.Begin21(1, 0, 1, 0, 1, 0);
        var result3 = Begin.Begin21(2, 3, 4, 5, 6, 7);

        Assert.That(result1.perimeter, Is.EqualTo(0));
        Assert.That(result1.square, Is.EqualTo(0));

        Assert.That(result2.perimeter, Is.EqualTo(0));
        Assert.That(result2.square, Is.EqualTo(0).Within(0));

        Assert.That(MathF.Round(result3.perimeter), Is.EqualTo(6));
        Assert.That(result3.square, Is.EqualTo(0));
    }

    [Test]
    public void Begin22Test()
    {
        var result1 = Begin.Begin22("Hello", "World");
        var result2 = Begin.Begin22("123", "456");
        var result3 = Begin.Begin22("OpenAI", "GPT-3");

        Assert.That(result1.a, Is.EqualTo("World"));
        Assert.That(result1.b, Is.EqualTo("Hello"));

        Assert.That(result2.a, Is.EqualTo("456"));
        Assert.That(result2.b, Is.EqualTo("123"));

        Assert.That(result3.a, Is.EqualTo("GPT-3"));
        Assert.That(result3.b, Is.EqualTo("OpenAI"));
    }

    [Test]
    public void Begin23Test()
    {
        var result1 = Begin.Begin23("Hello", "World", "OpenAI");
        var result2 = Begin.Begin23("123", "456", "789");
        var result3 = Begin.Begin23("One", "Two", "Three");

        Assert.That(result1.a, Is.EqualTo("World"));
        Assert.That(result1.b, Is.EqualTo("OpenAI"));
        Assert.That(result1.c, Is.EqualTo("Hello"));

        Assert.That(result2.a, Is.EqualTo("456"));
        Assert.That(result2.b, Is.EqualTo("789"));
        Assert.That(result2.c, Is.EqualTo("123"));

        Assert.That(result3.a, Is.EqualTo("Two"));
        Assert.That(result3.b, Is.EqualTo("Three"));
        Assert.That(result3.c, Is.EqualTo("One"));
    }

    [Test]
    public void Begin24Test()
    {
        var result1 = Begin.Begin24("Hello", "World", "OpenAI");
        var result2 = Begin.Begin24("123", "456", "789");
        var result3 = Begin.Begin24("One", "Two", "Three");

        Assert.That(result1.a, Is.EqualTo("OpenAI"));
        Assert.That(result1.b, Is.EqualTo("Hello"));
        Assert.That(result1.c, Is.EqualTo("World"));

        Assert.That(result2.a, Is.EqualTo("789"));
        Assert.That(result2.b, Is.EqualTo("123"));
        Assert.That(result2.c, Is.EqualTo("456"));

        Assert.That(result3.a, Is.EqualTo("Three"));
        Assert.That(result3.b, Is.EqualTo("One"));
        Assert.That(result3.c, Is.EqualTo("Two"));
    }

    [Test]
    public void Begin25Test()
    {
        Assert.That(Begin.Begin25(0), Is.EqualTo(-7));
        Assert.That(Begin.Begin25(1), Is.EqualTo(-34));
        Assert.That(Begin.Begin25(-1), Is.EqualTo(-34));
    }

    [Test]
    public void Begin26Test()
    {
        Assert.That(Begin.Begin26(2), Is.EqualTo(4441));
        Assert.That(Begin.Begin26(3), Is.EqualTo(2));
        Assert.That(Begin.Begin26(4), Is.EqualTo(3755));
    }

    [Test]
    public void Begin27Test()
    {
        var result1 = Begin.Begin27(2);
        var result2 = Begin.Begin27(0);
        var result3 = Begin.Begin27(-3);

        Assert.That(result1.a2, Is.EqualTo(4));
        Assert.That(result1.a4, Is.EqualTo(256));
        Assert.That(result1.a8, Is.EqualTo(256));

        Assert.That(result2.a2, Is.EqualTo(0));
        Assert.That(result2.a4, Is.EqualTo(0));
        Assert.That(result2.a8, Is.EqualTo(0));

        Assert.That(result3.a2, Is.EqualTo(9));
        Assert.That(result3.a4, Is.EqualTo(6561));
        Assert.That(result3.a8, Is.EqualTo(6561));
    }

    [Test]
    public void Begin28Test()
    {
        var result1 = Begin.Begin28(2);
        var result2 = Begin.Begin28(0);
        var result3 = Begin.Begin28(-3);

        Assert.That(result1.a2, Is.EqualTo(4));
        Assert.That(result1.a3, Is.EqualTo(8));
        Assert.That(result1.a5, Is.EqualTo(32));
        Assert.That(result1.a10, Is.EqualTo(64));
        Assert.That(result1.a15, Is.EqualTo(2048));

        Assert.That(result2.a2, Is.EqualTo(0));
        Assert.That(result2.a3, Is.EqualTo(0));
        Assert.That(result2.a5, Is.EqualTo(0));
        Assert.That(result2.a10, Is.EqualTo(0));
        Assert.That(result2.a15, Is.EqualTo(0));

        Assert.That(result3.a2, Is.EqualTo(9));
        Assert.That(result3.a3, Is.EqualTo(-27));
        Assert.That(result3.a5, Is.EqualTo(-243));
        Assert.That(result3.a10, Is.EqualTo(729));
        Assert.That(result3.a15, Is.EqualTo(-177147));
    }

    [Test]
    public void Begin29Test()
    {
        Assert.That(Begin.Begin29(0), Is.EqualTo(0));
        Assert.That(MathF.Round(Begin.Begin29(180), 2), Is.EqualTo(PI));
        Assert.That(MathF.Round(Begin.Begin29(-90), 2), Is.EqualTo(-3.14 / 2).Within(0.0001));
    }

    [Test]
    public void Begin30Test()
    {
        Assert.That(Begin.Begin30(0), Is.EqualTo(0));
        Assert.That(Begin.Begin30(3.14f), Is.EqualTo(180).Within(1.0001));
        Assert.That(Begin.Begin30(-3.14f / 2f), Is.EqualTo(-90).Within(1.0001));
    }

    [Test]
    public void Begin31Test()
    {
        Assert.That(Begin.Begin31(32), Is.EqualTo(0));
        Assert.That(Begin.Begin31(100), Is.EqualTo(37.777).Within(0.001));
        Assert.That(Begin.Begin31(-10), Is.EqualTo(-23.333).Within(0.001));
    }

    [Test]
    public void Begin32Test()
    {
        Assert.That(Begin.Begin32(0), Is.EqualTo(32));
        Assert.That(Begin.Begin32(37.777f), Is.EqualTo(100).Within(1.001));
        Assert.That(Begin.Begin32(-23.333f), Is.EqualTo(-10).Within(1.001));
    }

    [Test]
    public void Begin33Test()
    {
        var result1 = Begin.Begin33(2, 10, 3);
        var result2 = Begin.Begin33(1, 5, 1);
        var result3 = Begin.Begin33(5, 0, 4);

        Assert.That(result1.kg1, Is.EqualTo(5));
        Assert.That(result1.yKg, Is.EqualTo(15));

        Assert.That(result2.kg1, Is.EqualTo(5));
        Assert.That(result2.yKg, Is.EqualTo(5));

        Assert.That(result3.kg1, Is.EqualTo(0));
        Assert.That(result3.yKg, Is.EqualTo(0));
    }

    [Test]
    public void Begin34Test()
    {
        var result1 = Begin.Begin34(1, 2, 3, 6);
        var result2 = Begin.Begin34(2, 1, 6, 8);

        Assert.That(result1.chocolatePricePerKG, Is.EqualTo(2));
        Assert.That(result1.irisPricePerKG, Is.EqualTo(2));
        Assert.That(result1.difference, Is.EqualTo(1));

        Assert.That(result2.chocolatePricePerKG, Is.EqualTo(0.5f));
        Assert.That(MathF.Round(result2.irisPricePerKG, 1), Is.EqualTo(1.3f));
        Assert.That(result2.difference, Is.EqualTo(0.375));
    }

    [Test]
    public void Begin35Test()
    {
        Assert.That(Begin.Begin35(10, 5, 2, 3), Is.EqualTo(35));
        Assert.That(Begin.Begin35(5, 10, 3, 2), Is.EqualTo(5));
        Assert.That(Begin.Begin35(0, 0, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void Begin36Test()
    {
        Assert.That(Begin.Begin36(5, 10, 2, 3), Is.EqualTo(47));
        Assert.That(Begin.Begin36(10, 5, 3, 2), Is.EqualTo(33));
        Assert.That(Begin.Begin36(0, 0, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void Begin37Test()
    {
        Assert.That(Begin.Begin37(5, 10, 2, 3), Is.EqualTo(43));
        Assert.That(Begin.Begin37(10, 5, 3, 2), Is.EqualTo(27));
        Assert.That(Begin.Begin37(0, 0, 0, 0), Is.EqualTo(0));
    }

    [Test]
    public void Begin38Test()
    {
        Assert.That(Begin.Begin38(2, 5), Is.EqualTo(-2.5));
        Assert.That(Begin.Begin38(1, 10), Is.EqualTo(-10));
        Assert.That(Begin.Begin38(-3, 1), Is.EqualTo(0.3333).Within(0.0001));
    }

    [Test]
    public void Begin39Test()
    {
        var result1 = Begin.Begin39(1, -5, 6);
        var result2 = Begin.Begin39(1, -7, 9);
        var result3 = Begin.Begin39(1, -9, 11);

        Assert.That(result1.bigger, Is.EqualTo(3));
        Assert.That(result1.smaller, Is.EqualTo(2));

        Assert.That(result2.bigger, Is.EqualTo(5).Within(0.4f));
        Assert.That(result2.smaller, Is.EqualTo(1.6).Within(0.5f));

        Assert.That(result3.bigger, Is.EqualTo(7).Within(0.6f));
        Assert.That(result3.smaller, Is.EqualTo(1.5).Within(0.1f));
    }

    [Test]
    public void Begin40Test()
    {
        double x, y;
        x = y = 0;

        var result1 = Begin.Begin40(2, -5, 6, 1, -2, 3, 0, x, y);
        var result2 = Begin.Begin40(3, -5, 7, 1, -2, 4, 0, x, y);
        var result3 = Begin.Begin40(1, 1, 1, 2, 2, 2, 1, x, y);

        Assert.That(result1.x, Is.EqualTo(-0.625));
        Assert.That(result1.y, Is.EqualTo(-0.125));

        Assert.That(result2.x, Is.EqualTo(-0.7).Within(0.1));
        Assert.That(result2.y, Is.EqualTo(0.05).Within(0.005));

        Assert.That(result3.x, Is.EqualTo(2));
        Assert.That(result3.y, Is.EqualTo(0));
    }
}