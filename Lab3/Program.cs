// Вариант 17
// Операторы цикла с предусловием и постусловием


// Базовый уровень

// Console.Write("Введите n: ");
// var n = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Простые делители: ");

// while (n % 2 == 0)
// {
//     Console.WriteLine(2);
//     n /= 2;
// }

// for (int i = 3; i <= Math.Sqrt(n); i += 2)
// {
//     while (n % i == 0)
//     {
//         Console.WriteLine(i);
//         n /= i;
//     }
// }

// if (n > 2) Console.WriteLine(n);


// Средний уровень

// int summ = 0;
// int maxP = 5;

// for (int i = 1; i <= maxP; i++)
// {
//     Console.Write($"Учащийся {i}/{maxP}. Рост: ");
//     var rost = int.Parse(Console.ReadLine()!);
//     summ += rost;
// }

// var med = summ / (double)maxP;

// Console.WriteLine($"Средний рост учащихся: {med}");


// Высокий уровень

// Console.Write($"Введите степендию студента:  ");
// var A = double.Parse(Console.ReadLine()!);

// Console.Write($"Введите расход за месяц: ");
// var B = double.Parse(Console.ReadLine()!);

// double percent = 1.03;
// int months = 10;

// var yearA = A *months;

// double totalB = 0;
// for (int i = 0; i < months; i++) totalB += B * Math.Pow(percent, i);

// var result = totalB - yearA;

// Console.WriteLine($"Результат: {result:f2} грн");



// Оператор цикла for

// Базовый уровень

// double A = 7;
// double B = 10;
// int N = 10;

// double H = (B - A) / (N - 1);

// Console.WriteLine($"Результат:");

// for (int i = 0; i < N; i++)
// {
//     double X = A + i * H;
//     double FX = 1 - Math.Sin(X);
//     Console.WriteLine($"F({X:f2}): {FX:F2}");
// }


// Средний уровень

// Console.Write("Введите k: ");
// var k = int.Parse(Console.ReadLine()!);
// double W = 0;

// for (int i = -3; i <= k; i++)
// {
//     double denominatorSum = Math.Pow((i - 5), 2);
//     if (denominatorSum == 0) continue;

//     double sumTerm = Math.Pow(-1, i) / denominatorSum;
//     double productTerm = 1;

//     for (int n = i; n <= 2 * k; n++)
//     {
//         double numerator = Math.Pow(n, 3) - 8;
//         double denominator = n + 4;

//         if (denominator == 0 || numerator == 0) continue;
//         productTerm *= numerator / denominator;
//     }

//     W += sumTerm * productTerm;
// }

// Console.WriteLine($"W: {W}");


// Вычисление бесконечных сумм

// Console.Write("Введите x: ");
// double x = double.Parse(Console.ReadLine()!);

// Console.Write("Введите количество членов n: ");
// int n = int.Parse(Console.ReadLine()!);

// double sum = 0;
// for (int i = 0; i < n; i++)
// {
//     double f = 1;
//     var cF = 2 * i;
//     for (int j = 2; j <= cF; j++) f *= j;

//     double p = Math.Pow(x, 2 * i) / f;
//     sum += p;
// }

// Console.WriteLine($"Сумма {n} членов ряда: {sum:f2}");

// Табулирование функций


// Базовый уровень

// Console.Write("Введите начало: ");
// var start = double.Parse(Console.ReadLine()!);

// Console.Write("Введите конец: ");
// var end = double.Parse(Console.ReadLine()!);
// double step = 0.2;

// for (double x = start; x <= end; x += step)
// {
//     double y = Math.Pow(x, 2) - Math.Sin(Math.PI * x);
//     Console.WriteLine($"x: {x:f2}, y: {y:f2}");
// }


// Средний уровень

// double start = -Math.PI / 4;
// double end = 7 * Math.PI / 4;
// double step = 0.2;

// for (double x = start; x <= end; x += step)
// {
//     double y;

//     if (x < 0) y = x * x;
//     else if (x >= 0 && x <= 2.5) y = 1 + 3 * Math.Log(1 - Math.Pow(x, 3));
//     else y = Math.Cos(2.3 * x - 1);

//     Console.WriteLine($"x: {x:f2}, y: {y:f2}");
// }