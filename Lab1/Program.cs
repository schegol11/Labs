
// Вариант 20
// Арифметические выражения

// Базовый уровень
// Console.Write("Введите k: ");
// var k = double.Parse(Console.ReadLine()!);

// Console.Write("Введите y: ");
// var y = double.Parse(Console.ReadLine()!);

// Console.Write("Введите x: ");
// var x = double.Parse(Console.ReadLine()!);

// var e = Math.Exp(k + y);
// var tg = Math.Tan(x * Math.PI / 180);
// var ry = Math.Sqrt(y);

// var u = e + tg * ry;

// Console.WriteLine();
// Console.WriteLine($"Результат: {u}");


// Средний уровень
// Console.Write("Введите t: ");
// var t = double.Parse(Console.ReadLine()!);

// Console.Write("Введите l: ");
// var l = double.Parse(Console.ReadLine()!);

// Console.Write("Введите y: ");
// var y = double.Parse(Console.ReadLine()!);

// var K = ((2 * (Math.Pow(t, 2))) + (3 * l) + 7.2) / (Math.Log(y) + Math.Exp(2 * l));

// Console.WriteLine($"Результат: {K:f2}");


// Высокий уровень
// Console.Write("Введите a: ");
// var a = double.Parse(Console.ReadLine()!);

// Console.Write("Введите b: ");
// var b = double.Parse(Console.ReadLine()!);

// Console.Write("Введите c: ");
// var c = double.Parse(Console.ReadLine()!);

// Console.Write("Введите y: ");
// var y = double.Parse(Console.ReadLine()!);

// Console.Write("Введите x: ");
// var x = double.Parse(Console.ReadLine()!);

// var tg = Math.Pow(Math.Tan(y), 3);
// var sin = Math.Pow(Math.Sin(x), 5);

// var u = (tg + sin * Math.Sqrt(b - c)) / (Math.Sqrt(a - b + c));

// Console.WriteLine($"Результат: {u}");



// Программирование линейных алгоритмов

// Базовый уровень
// Console.Write("Введите индуктивность: ");
// var l = double.Parse(Console.ReadLine()!);

// Console.Write("Введите силу тока: ");
// var i = double.Parse(Console.ReadLine()!);

// var w = 1.0/2.0 * l * Math.Pow(i, 2);

// Console.WriteLine($"Результат: {w}");


// Средний уровень
// Console.Write("Введите x: ");
// var x = double.Parse(Console.ReadLine()!);

// const double p = 1.6;

// var a = Math.Log(x);
// var b = Math.Pow(x, 4) + Math.Log10(Math.Pow(p, 3));
// var y = Math.Pow(Math.Sin(a * x), 3) + Math.Sqrt(b) * Math.Cos(Math.Pow(x, 2));

// Console.WriteLine($"Результат:\n\na: {a}\nb: {b}\ny: {y:f2}");


// Высокий уровень
// Console.Write("Введите V1: ");
// var v1 = double.Parse(Console.ReadLine()!);

// Console.Write("Введите V2: ");
// var v2 = double.Parse(Console.ReadLine()!);

// Console.Write("Введите V3: ");
// var v3 = double.Parse(Console.ReadLine()!);

// var r1 = Math.Pow(3 * v1 / (4 * Math.PI), 1.0 / 3.0);
// var r2 = Math.Pow(3 * v2 / (4 * Math.PI), 1.0 / 3.0);
// var r3 = Math.Pow(3 * v3 / (4 * Math.PI), 1.0 / 3.0);

// var z = (r1 + r2 + r3) / 3;

// Console.WriteLine($"Результат: {z:f2}");


// Вариант 3.34
// Целочисленная арифметика

// int result = 564;
// var b = result / 100;
// var c = (result / 10) % 10;
// var a = result % 10;

// var x = (a * 100) + (b * 10) + c;

// Console.WriteLine($"x: {x}");