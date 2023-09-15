namespace Tests;

[TestFixture]
public class Case
{
	[TestCase(1, "Понедельник")]
	[TestCase(2, "Вторник")]
	[TestCase(3, "Среда")]
	[TestCase(4, "Четверг")]
	[TestCase(5, "Пятница")]
	[TestCase(6, "Суббота")]
	[TestCase(7, "Воскресенье")]
	[TestCase(8, "Нет такого дня недели")]
	public void Case1(int day, string expectedDayName)
	{
		Assert.That(TasksLesson.Homework.Case.Case1(day), Is.EqualTo(expectedDayName));
	}

	[TestCase(1, "Плохо")]
	[TestCase(2, "Неудовлетворительно")]
	[TestCase(3, "Удовлетворительно")]
	[TestCase(4, "Хорошо")]
	[TestCase(5, "Отлично")]
	[TestCase(10, "Нет такой оценки")]
	public void Case2(int grade, string expectedGradeDescription)
	{
		Assert.That(TasksLesson.Homework.Case.Case2(grade), Is.EqualTo(expectedGradeDescription));
	}

	[TestCase(1, "Январь")]
	[TestCase(6, "Июнь")]
	[TestCase(13, "Нет такого месяца")]
	public void Case3(int month, string expectedMonthName)
	{
		Assert.That(TasksLesson.Homework.Case.Case3(month), Is.EqualTo(expectedMonthName));
	}

	[TestCase(1, "31")]
	[TestCase(2, "28")]
	[TestCase(3, "31")]
	[TestCase(4, "30")]
	[TestCase(12, "31")]
	[TestCase(13, "Нет такого месяца")]
	public void Case4(int month, string expectedDays)
	{
		Assert.That(TasksLesson.Homework.Case.Case4(month), Is.EqualTo(expectedDays));
	}

	[TestCase(3, 2, 1, ExpectedResult = "5")]
	[TestCase(3, 2, 2, ExpectedResult = "1")]
	[TestCase(3, 2, 3, ExpectedResult = "6")]
	[TestCase(4, 2, 4, ExpectedResult = "2")]
	[TestCase(3, 2, 5, ExpectedResult = "Нет такого действия")]
	[TestCase(3, 0, 4, ExpectedResult = "Нельзя делить на ноль")]
	public string Case5(int a, int b, int c)
	{
		return TasksLesson.Homework.Case.Case5(a, b, c);
	}

	[TestCase(1, 10, 1)]
	[TestCase(2, 0.001, 1)]
	[TestCase(3, 123, 123)]
	[TestCase(4, 1000, 1)]
	[TestCase(5, 100, 1)]
	public void Case6_Correct(int a, double b, double expected)
	{
		double? result = TasksLesson.Homework.Case.Case6(a, b);
		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void Case6_ShouldReturnNull_WhenInvalidCaseProvided()
	{
		// Act
		double? result = TasksLesson.Homework.Case.Case6(0, 123);

		// Assert
		Assert.IsNull(result);
	}

	[TestCase(1, 100, ExpectedResult = 100.0)]
	[TestCase(2, 1000, ExpectedResult = 0.001)]
	[TestCase(3, 100, ExpectedResult = 0.1)]
	[TestCase(4, 100, ExpectedResult = 100000)]
	[TestCase(5, 100, ExpectedResult = 10000)]
	[TestCase(6, 100, ExpectedResult = -1)]
	public double Case7(int a, double b)
	{
		return TasksLesson.Homework.Case.Case7(a, b);
	}

	[TestCase(1, 2, ExpectedResult = "31 12")]
	[TestCase(2, 2, ExpectedResult = "31 1")]
	[TestCase(3, 2, ExpectedResult = "28 2")]
	[TestCase(4, 2, ExpectedResult = "31 3")]
	[TestCase(5, 2, ExpectedResult = "30 4")]
	[TestCase(6, 2, ExpectedResult = "31 5")]
	// Add more test cases as needed
	public string Case8(int a, int b)
	{
		return TasksLesson.Homework.Case.Case8(a, b);
	}

	[TestCase(1, 1, ExpectedResult = "2 1")]
	[TestCase(2, 2, ExpectedResult = "3 2")]
	[TestCase(3, 3, ExpectedResult = "4 3")]
	[TestCase(4, 4, ExpectedResult = "5 4")]
	[TestCase(5, 5, ExpectedResult = "6 5")]
	[TestCase(6, 6, ExpectedResult = "7 6")]
	[TestCase(7, 7, ExpectedResult = "8 7")]
	[TestCase(8, 8, ExpectedResult = "9 8")]
	[TestCase(9, 9, ExpectedResult = "10 9")]
	[TestCase(10, 10, ExpectedResult = "11 10")]
	[TestCase(11, 11, ExpectedResult = "12 11")]
	[TestCase(12, 12, ExpectedResult = "13 12")]
	[TestCase(13, 13, ExpectedResult = "Нет такого месяца")]
	public string Case9(int d, int m)
	{
		return TasksLesson.Homework.Case.Case9(d, m);
	}

	[TestCase('С', 0, ExpectedResult = "С")]
	[TestCase('С', 1, ExpectedResult = "З")]
	[TestCase('С', -1, ExpectedResult = "В")]
	[TestCase('С', 100, ExpectedResult = "Нет такой команды")]
	[TestCase('З', 0, ExpectedResult = "З")]
	[TestCase('З', 1, ExpectedResult = "Ю")]
	[TestCase('З', -1, ExpectedResult = "С")]
	[TestCase('З', 100, ExpectedResult = "Нет такой команды")]
	[TestCase('Ю', 0, ExpectedResult = "Ю")]
	[TestCase('Ю', 1, ExpectedResult = "В")]
	[TestCase('Ю', -1, ExpectedResult = "З")]
	[TestCase('Ю', 100, ExpectedResult = "Нет такой команды")]
	[TestCase('В', 0, ExpectedResult = "В")]
	[TestCase('В', 1, ExpectedResult = "С")]
	[TestCase('В', -1, ExpectedResult = "Ю")]
	[TestCase('В', 100, ExpectedResult = "Нет такой команды")]
	[TestCase('X', 0, ExpectedResult = "Нет такого направления")]
	public string Case10(char a, int b)
	{
		return TasksLesson.Homework.Case.Case10(a, b);
	}

	[TestCase('С', 1, -1, ExpectedResult = 'С')]
	[TestCase('З', -1, 2, ExpectedResult = 'Ю')]
	public char Case11(char a, int b, int c)
	{
		return TasksLesson.Homework.Case.Case11(a, b, c);
	}

	[TestCase(1, 1, ExpectedResult = "R = 1, D = 2, L = 6,3, S = 3,1")]
	[TestCase(2, 2, ExpectedResult = "R = 1, D = 2, L = 6,3, S = 3,1")]
	[TestCase(3, 6.2832, ExpectedResult = "R = 1, D = 2, L = 6,3, S = 3,1")]
	[TestCase(4, 3.1416, ExpectedResult = "R = 1, D = 2, L = 6,3, S = 3,1")]
	[TestCase(5, 1, ExpectedResult = "Incorrect input")]
	public string Case12(int a, double b)
	{
		return TasksLesson.Homework.Case.Case12(a, b);
	}

	[TestCase(1, 1.0, ExpectedResult = "a = 1, c = 1,41, h = 0,71, S = 0,35")]
	[TestCase(2, 1.0, ExpectedResult = "a = 0,71, c = 1, h = 0,5, S = 0,25")]
	[TestCase(3, 1.0, ExpectedResult = "a = 1,41, c = 2, h = 1, S = 1")]
	[TestCase(4, 1.0, ExpectedResult = "a = 1, c = 1,41, h = 0,71, S = 1")]
	[TestCase(5, 1.0, ExpectedResult = "a = 0, c = 0, h = 0, S = 0")]
	public string Case13(int n, double value)
	{
		return TasksLesson.Homework.Case.Case13(n, value);
	}

	[TestCase(1, 100, ExpectedResult = "a = 100, R1 = 28,87, R2 = 57,74, S = 4330,13")]
	[TestCase(2, 100, ExpectedResult = "a = 212,13, R1 = 100, R2 = 200, S = 19485,57")]
	public string Case14(int n, double value)
	{
		return TasksLesson.Homework.Case.Case14(n, value);
	}

	[TestCase(1, 1, ExpectedResult = "туз пик")]
	[TestCase(2, 2, ExpectedResult = "2 треф")]
	[TestCase(3, 3, ExpectedResult = "3 бубен")]
	[TestCase(4, 4, ExpectedResult = "4 червей")]
	public string Case15(int suit, int value)
	{
		return TasksLesson.Homework.Case.Case15(suit, value);
	}

	[TestCase(1, ExpectedResult = "Неверный год")]
	[TestCase(2, ExpectedResult = "Неверный год")]
	[TestCase(20, ExpectedResult = "двадцать лет")]
	[TestCase(30, ExpectedResult = "тридцать лет")]
	[TestCase(35, ExpectedResult = "тридцать пять лет")]
	[TestCase(41, ExpectedResult = "сорок один год")]
	[TestCase(46, ExpectedResult = "сорок шесть лет")]
	[TestCase(69, ExpectedResult = "шестьдесят девять лет")]
	[TestCase(70, ExpectedResult = "Неверный год")]
	public string Case16(int n)
	{
		return TasksLesson.Homework.Case.Case16(n);
	}

	[TestCase(1, ExpectedResult = "одно учебное задание")]
	[TestCase(4, ExpectedResult = "четыре учебных задания")]
	[TestCase(6, ExpectedResult = "шесть учебных заданий")]
	[TestCase(21, ExpectedResult = "двадцать одно учебное задание")]
	[TestCase(45, ExpectedResult = "Invalid number учебных заданий")]
	public string Case17(int n)
	{
		var result = TasksLesson.Homework.Case.Case17(n);
		return result;
	}

	[TestCase(123, "сто двадцать три")]
	[TestCase(567, "пятьсот шестьдесят семь")]
	[TestCase(999, "девятьсот девяносто девять")]
	[TestCase(100, "сто")]
	[TestCase(50, "Неверное число")]
	public void Case18(int input, string expectedResult)
	{
		string result = TasksLesson.Homework.Case.Case18(input);

		Assert.That(result, Is.EqualTo(expectedResult));
	}

	[TestCase(1972, ExpectedResult = "год черной крысы")]
	[TestCase(1925, ExpectedResult = "год зеленой коровы")]
	[TestCase(1935, ExpectedResult = "год зеленой свиньи")]
	[TestCase(1924, ExpectedResult = "год зеленой крысы")]
	[TestCase(2043, ExpectedResult = "год черной свиньи")]
	public string Case19(int a)
	{
		return TasksLesson.Homework.Case.Case19(a);
	}

	[TestCase(1, 19, ExpectedResult = "Козерог")]
	[TestCase(1, 20, ExpectedResult = "Водолей")]
	[TestCase(2, 18, ExpectedResult = "Водолей")]
	[TestCase(2, 19, ExpectedResult = "Рыбы")]
	[TestCase(3, 20, ExpectedResult = "Рыбы")]
	[TestCase(3, 21, ExpectedResult = "Овен")]
	[TestCase(4, 19, ExpectedResult = "Овен")]
	[TestCase(4, 20, ExpectedResult = "Телец")]
	[TestCase(5, 20, ExpectedResult = "Телец")]
	[TestCase(6, 21, ExpectedResult = "Близнецы")]
	[TestCase(7, 22, ExpectedResult = "Рак")]
	[TestCase(8, 23, ExpectedResult = "Дева")]
	[TestCase(11, 22, ExpectedResult = "Скорпион")]
	[TestCase(12, 21, ExpectedResult = "Стрелец")]
	public string Case20(int month, int day)
	{
		return TasksLesson.Homework.Case.Case20(month, day);
	}
}