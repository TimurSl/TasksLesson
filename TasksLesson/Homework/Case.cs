using System.Text;

namespace TasksLesson.Homework;

public class Case
{
	public static string Case1(int a)
	{
		switch (a)
		{
			case 1:
				return "Понедельник";
			case 2:
				return "Вторник";
			case 3:
				return "Среда";
			case 4:
				return "Четверг";
			case 5:
				return "Пятница";
			case 6:
				return "Суббота";
			case 7:
				return "Воскресенье";
			default:
				return "Нет такого дня недели";
		}
	}

	public static string Case2(int k)
	{
		switch (k)
		{
			case 1:
				return "Плохо";
			case 2:
				return "Неудовлетворительно";
			case 3:
				return "Удовлетворительно";
			case 4:
				return "Хорошо";
			case 5:
				return "Отлично";
			default:
				return "Нет такой оценки";
		}
	}

	public static string Case3(int a)
	{
		switch (a)
		{
			case 1:
				return "Январь";

			case 2:
				return "Февраль";

			case 3:
				return "Март";

			case 4:
				return "Апрель";

			case 5:
				return "Май";

			case 6:
				return "Июнь";

			case 7:
				return "Июль";

			case 8:
				return "Август";

			case 9:
				return "Сентябрь";

			case 10:
				return "Октябрь";

			case 11:
				return "Ноябрь";

			case 12:
				return "Декабрь";

			default:
				return "Нет такого месяца";
		}
	}

	public static string Case4(int a)
	{
		switch (a)
		{
			case 1:
				return "31";
			case 2:
				return "28";
			case 3:
				return "31";
			case 4:
				return "30";
			case 5:
				return "31";
			case 6:
				return "30";
			case 7:
				return "31";
			case 8:
				return "31";
			case 9:
				return "30";
			case 10:
				return "31";
			case 11:
				return "30";
			case 12:
				return "31";
			default:
				return "Нет такого месяца";
		}
	}

	public static string Case5(int a, int b, int c)
	{
		switch (c)
		{
			case 1:
				return (a + b).ToString ();
			case 2:
				return (a - b).ToString ();
			case 3:
				return (a * b).ToString ();
			case 4:
				if (b == 0)
				{
					return "Нельзя делить на ноль";
				}

				return (a / b).ToString ();
			default:
				return "Нет такого действия";
		}
	}

	public static double? Case6(int a, double b)
	{
		switch (a)
		{
			case 1:
				return b * 0.1;
			case 2:
				return b * 1000;
			case 3:
				return b;
			case 4:
				return b * 0.001;
			case 5:
				return b * 0.01;
			default:
				return null;
		}
	}

	public static double Case7(int a, double b)
	{
		switch (a)
		{
			case 1: // Килограммы
				return b;
			case 2: // Миллиграмы
				return b * 0.000001;
			case 3: // Граммы
				return b * 0.001;
			case 4: // Тонны
				return b * 1000;
			case 5: // Центнеры
				return b * 100;
			default:
				return -1;
		}
	}

	public static string Case8(int a, int b)
	{
		switch (a)
		{
			case 1:
				return "31" + " " + "12";
			case 2:
				return "31" + " " + "1";
			case 3:
				return "28" + " " + "2";
			case 4:
				return "31" + " " + "3";
			case 5:
				return "30" + " " + "4";
			case 6:
				return "31" + " " + "5";
			case 7:
				return "30" + " " + "6";
			case 8:
				return "31" + " " + "7";
			case 9:
				return "31" + " " + "8";
			case 10:
				return "30" + " " + "9";
			case 11:
				return "31" + " " + "10";
			case 12:
				return "30" + " " + "11";
			default:
				return "There's no such month";
		}
	}

	public static string Case9(int d, int m)
	{
		switch (m)
		{
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
				return d + 1 + " " + m;
			default:
				return "Нет такого месяца";
		}
	}

	public static string Case10(char c, int n)
	{
		string result;
		switch (c)
		{
			case 'С':
				result = n switch
				{
					0 => "С",
					1 => "З",
					-1 => "В",
					_ => "Нет такой команды"
				};

				break;
			case 'З':
				result = n switch
				{
					0 => "З",
					1 => "Ю",
					-1 => "С",
					_ => "Нет такой команды"
				};

				break;
			case 'Ю':
				result = n switch
				{
					0 => "Ю",
					1 => "В",
					-1 => "З",
					_ => "Нет такой команды"
				};

				break;
			case 'В':
				result = n switch
				{
					0 => "В",
					1 => "С",
					-1 => "Ю",
					_ => "Нет такой команды"
				};

				break;
			default:
				result = "Нет такого направления";
				break;
		}

		return result;
	}

	public static char Case11(char c, int n1, int n2)
	{
		char GetFinalDirection(char direction, int n) => direction switch
		{
			'С' => n switch
			{
				1 => 'З',
				-1 => 'В',
				2 => 'Ю',
				_ => direction
			},
			'З' => n switch
			{
				1 => 'Ю',
				-1 => 'С',
				2 => 'В',
				_ => direction
			},
			'Ю' => n switch
			{
				1 => 'В',
				-1 => 'З',
				2 => 'С',
				_ => direction
			},
			'В' => n switch
			{
				1 => 'С',
				-1 => 'Ю',
				2 => 'З',
				_ => direction
			},
			_ => direction
		};

		char final_direction = GetFinalDirection(c, n1);
		return GetFinalDirection(final_direction, n2);
	}


	public static string Case12(int n, double value)
	{
		double R = 0;
		double D = 0;
		double L = 0;
		double S = 0;
		switch (n)
		{
			case 1:
				R = Math.Round(value, 1);
				D = Math.Round(2 * R, 1);
				L = Math.Round(2 * Math.PI * R, 1);
				S = Math.Round(Math.PI * R * R, 1);
				break;
			case 2:
				D = Math.Round(value, 1);
				R = Math.Round(D / 2, 1);
				L = Math.Round(2 * Math.PI * R, 1);
				S = Math.Round(Math.PI * R * R, 1);
				break;
			case 3:
				L = Math.Round(value, 1);
				R = Math.Round(L / (2 * Math.PI), 1);
				S = Math.Round(Math.PI * R * R, 1);
				D = Math.Round(2 * R, 1);
				break;
			case 4:
				S = Math.Round(value, 1);
				R = Math.Round(Math.Sqrt(S / Math.PI), 1);
				D = Math.Round(2 * R, 1);
				L = Math.Round(2 * Math.PI * R, 1);
				break;
			default:
				return "Incorrect input";
		}

		return $"R = {R}, D = {D}, L = {L}, S = {S}";
	}

	public static string Case13(int n, double value)
	{
		double a, c, h, S;

		(a, c, h, S) = n switch
		{
			1 => (
				Math.Round(value, 2),
				Math.Round(value * Math.Sqrt(2), 2),
				Math.Round(value * Math.Sqrt(2) / 2, 2),
				Math.Round(value * Math.Sqrt(2) / 2 * value / 2, 2)
			),
			2 => (
				Math.Round(value / Math.Sqrt(2), 2),
				Math.Round(value, 2),
				Math.Round(value / 2, 2),
				Math.Round(value / 2 * value / 2, 2)),
			3 => (
				Math.Round(value * 2 / Math.Sqrt(2), 2),
				Math.Round(value * 2, 2),
				Math.Round(value, 2),
				Math.Round(value * 2 / 2, 2)
			),
			4 => (
				Math.Round(Math.Sqrt(value * 2) / Math.Sqrt(2), 2),
				Math.Round(Math.Sqrt(value * 2), 2),
				Math.Round(Math.Sqrt(value * 2) / 2, 2),
				Math.Round(value, 2)
			),
			_ => (0.0, 0.0, 0.0, 0.0)
		};

		return $"a = {a}, c = {c}, h = {h}, S = {S}";
	}

	public static string Case14(int n, double value)
	{
		double a = 0;
		double R1 = 0;
		double R2 = 0;
		double S = 0;
		switch (n)
		{
			case 1:
				a = value;
				R1 = a * Math.Sqrt(3) / 6;
				R2 = 2 * R1;
				S = a * a * Math.Sqrt(3) / 4;
				break;
			case 2:
				R1 = value;
				a = 3 * R1 / Math.Sqrt(2);
				R2 = 2 * R1;
				S = a * a * Math.Sqrt(3) / 4;
				break;
			case 3:
				R2 = value;
				R1 = R2 / 2;
				a = 3 * R1 / Math.Sqrt(2);
				S = a * a * Math.Sqrt(3) / 4;
				break;
			case 4:
				S = value;
				a = Math.Sqrt(S * 4 / Math.Sqrt(3));
				R1 = a * Math.Sqrt(3) / 6;
				R2 = 2 * R1;
				break;
			default:
				break;
		}

		return $"a = {Math.Round(a, 2)}, R1 = {Math.Round(R1, 2)}, R2 = {Math.Round(R2, 2)}, S = {Math.Round(S, 2)}";
	}

	public static string Case15(int n, int m)
	{
		var mast = n switch
		{
			1 => "пик",
			2 => "треф",
			3 => "бубен",
			4 => "червей",
			_ => String.Empty
		};

		var card = m switch
		{
			1 => "туз",
			2 => "2",
			3 => "3",
			4 => "4",
			5 => "5",
			6 => "6",
			7 => "7",
			8 => "8",
			9 => "9",
			10 => "10",
			11 => "валет",
			12 => "дама",
			13 => "король",
			_ => String.Empty
		};

		return $"{card} {mast}";
	}

	public static string Case16(int n)
	{
		if (n < 20 || n > 69)
		{
			return "Неверный год";
		}

		string[] ones = {"", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
		string[] tens = {"двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят"};

		var resultBuilder = new StringBuilder(tens[(n - 20) / 10]);
		if (n % 10 != 0)
		{
			resultBuilder.Append(" " + ones[n % 10]);
		}

		var lastDigit = n % 10;
		resultBuilder.Append(lastDigit switch
		{
			1 => " год",
			>= 2 and <= 4 => " года",
			_ => " лет"
		});

		return resultBuilder.ToString ();
	}

	public static string Case17(int n)
	{
		string amount = n switch
		{
			1 => "одно",
			2 => "два",
			3 => "три",
			4 => "четыре",
			5 => "пять",
			6 => "шесть",
			7 => "семь",
			8 => "восемь",
			9 => "девять",
			10 => "десять",
			11 => "одиннадцать",
			12 => "двенадцать",
			13 => "тринадцать",
			14 => "четырнадцать",
			15 => "пятнадцать",
			16 => "шестнадцать",
			17 => "семнадцать",
			18 => "восемнадцать",
			19 => "девятнадцать",
			20 => "двадцать",
			21 => "двадцать одно",
			22 => "двадцать два",
			23 => "двадцать три",
			24 => "двадцать четыре",
			25 => "двадцать пять",
			26 => "двадцать шесть",
			27 => "двадцать семь",
			28 => "двадцать восемь",
			29 => "двадцать девять",
			30 => "тридцать",
			31 => "тридцать одно",
			32 => "тридцать два",
			33 => "тридцать три",
			34 => "тридцать четыре",
			35 => "тридцать пять",
			36 => "тридцать шесть",
			37 => "тридцать семь",
			38 => "тридцать восемь",
			39 => "тридцать девять",
			40 => "сорок",
			_ => "Invalid number"
		};

		string result = amount + " ";

		var lastDigit = n % 10;

		result += lastDigit switch
		{
			0 => "учебных задание",
			1 => "учебное задание",
			>= 2 and <= 4 => "учебных задания",
			_ => "учебных заданий"
		};

		return result;
	}

	public static string Case18(int n)
	{
		if (n < 100 || n > 999)
		{
			return "Неверное число";
		}

		string[] ones = {"", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
		string[] tens =
		{
			"десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят",
			"девяносто"
		};
		string[] hundreds =
			{"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот"};

		string result = hundreds[n / 100];
		if (n % 100 != 0)
		{
			result += " " + tens[(n % 100) / 10 - 1];
		}

		if (n % 10 != 0)
		{
			result += " " + ones[n % 10];
		}

		return result.Trim ();
	}

	public static string Case19(int n)
	{
		string result = "год ";

		result += (n % 10) switch
		{
			0 or 1 => "бел",
			2 or 3 => "черн",
			4 or 5 => "зелен",
			6 or 7 => "красн",
			8 or 9 => "жёлт",
			_ => ""
		};

		result += ((n + 1) % 5) switch
		{
			0 or 1 or 2 or 3 or 4 or 5 or 9 or 10 or 11 => "ой ",
			6 or 7 or 8 => "ого ",
			_ => ""
		};

		result += ((n + 8) % 12) switch
		{
			0 => "крысы",
			1 => "коровы",
			2 => "лошади",
			3 => "овцы",
			4 => "обезьяны",
			5 => "змеи",
			6 => "тигра",
			7 => "зайца",
			8 => "дракона",
			9 => "курицы",
			10 => "собаки",
			11 => "свиньи",
			_ => ""
		};

		return result;
	}


	public static string Case20(int m, int d)
	{
		string result = "";

		result = m switch
		{
			1 => (d > 19) ? "Водолей" : "Козерог",
			2 => (d > 18) ? "Рыбы" : "Водолей",
			3 => (d > 20) ? "Овен" : "Рыбы",
			4 => (d > 19) ? "Телец" : "Овен",
			5 => (d > 20) ? "Близнецы" : "Телец",
			6 => (d > 21) ? "Рак" : "Близнецы",
			7 => (d > 22) ? "Лев" : "Рак",
			8 => (d > 22) ? "Дева" : "Лев",
			9 => (d > 22) ? "Весы" : "Дева",
			10 => (d > 22) ? "Скорпион" : "Весы",
			11 => (d > 22) ? "Стрелец" : "Скорпион",
			12 => (d > 21) ? "Козерог" : "Стрелец",
			_ => "Invalid month"
		};

		return result;
	}
}