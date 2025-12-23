// Вариант 14
// Логические выражения

// Базовый уровень

// Console.Write("Введите A: ");
// var a = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Результат: {a % 3 != 0 && a % 10 == 0}");


// Средний уровень

// Console.WriteLine("| X | Y | Z | ¬X | ¬Z | ¬X∧Y | ¬(¬X∧Y) | X∧¬Z | ¬(¬X∧Y)∨(X∧¬Z) |");

// for (int x = 0; x <= 1; x++)
// {
//     for (int y = 0; y <= 1; y++)
//     {
//         for (int z = 0; z <= 1; z++)
//         {
//             var X = x != 0;
//             var Y = y != 0;
//             var Z = z != 0;
//             var NotXandY = !X && Y;
//             var NotNotXandY = !NotXandY;
//             var XandNotZ = X && !Z;
//             var NotNotXandYorXandNotZ = NotNotXandY || XandNotZ;

//             Console.WriteLine($"| {x, 1} | {y, 1} | {z, 1} | {Convert.ToInt32(!X), 2} | {Convert.ToInt32(!Z), 2} | {Convert.ToInt32(NotXandY), 4} | {Convert.ToInt32(NotNotXandY), 7} | {Convert.ToInt32(XandNotZ), 4} | {Convert.ToInt32(NotNotXandYorXandNotZ), 14} |");
//         }
//     }
// }

// Высокий уровень

// Не понял задание



// Вариант 9
// Условные операторы

// Базовый уровень

// Console.Write("Введите сторону a: ");
// var a = double.Parse(Console.ReadLine()!);

// Console.Write("Введите радиус r: ");
// var r = double.Parse(Console.ReadLine()!);

// var square = Math.Pow(a, 2);
// var circle = Math.PI * Math.Pow(r, 2);

// double sResult = square - circle;
// char symb = '=';

// if (sResult == 0) symb = '=';
// if (sResult < 0) symb = '<';
// if (sResult > 0) symb = '>';

// Console.WriteLine($"Площадь квадрата: {square:f1}\nПлощадь окружности: {circle:f1}\n{square} {symb} {circle:f1}");


// Средний уровень

// const int priceRub = 20;

// Console.Write("Введите продолжительность переговоров: ");
// var callDuraction = double.Parse(Console.ReadLine()!);

// Console.Write("Введите день недели: ");
// var dayOfWeek = int.Parse(Console.ReadLine()!);

// var cost = callDuraction * priceRub;

// string dayOfWeekName = "";
// double finalCost = cost;

// switch (dayOfWeek)
// {
// 	case 1:
// 		dayOfWeekName = "Понедельник";
// 		break;
// 	case 2:
// 		dayOfWeekName = "Вторник";
// 		break;
// 	case 3:
// 		dayOfWeekName = "Среда";
// 		break;
// 	case 4:
// 		dayOfWeekName = "Четверг";
// 		break;
// 	case 5:
// 		dayOfWeekName = "Пятница";
// 		break;
// 	case 6:
// 		dayOfWeekName = "Суббота";
// 		finalCost = cost - (cost / 100 * 20);
// 		break;
// 	case 7:
// 		dayOfWeekName = "Воскресенье";
// 		finalCost = cost - (cost / 100 * 20);
// 		break;
// }

// Console.WriteLine($"Результат: Цена переговоров в {dayOfWeekName} равна {finalCost}");


// Высокий уровень

// Console.Write("Введите трёхзначное число: ");
// var number = int.Parse(Console.ReadLine()!);

// var h = number / 100;
// var t = (number / 10) % 10;
// var o = number % 10;

// var sum = h + t + o;
// var mult = h * t * o;

// Console.WriteLine($"Число: {number}\n{h} + {t} + {o} = {sum} (Двухзначное: {sum >= 10 && sum <= 99})\n{h} * {t} * {o} = {mult} (Трёхзначное: {mult >= 100 && mult <= 999})");



// Оператор выбора

// Базовый уровень

// const double x1 = 9;
// const double y1 = 2;

// const double x2 = 7;
// const double y2 = -3;

// const double x3 = 0.1;
// const double y3 = 4;

// Console.WriteLine($"Результат:\nA1({x1}, {y1}) - {(x1 > 0 && y1 > 0 ? "лежит" : "не лежит")} на первой четверти\nA2({x2}, {y2}) - {(x2 > 0 && y2 > 0 ? "лежит" : "не лежит")} на первой четверти\nA3({x3}, {y3}) - {(x3 > 0 && y3 > 0 ? "лежит" : "не лежит")} на первой четверти");
