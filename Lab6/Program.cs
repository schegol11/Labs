// Вариант 3

// Базовый уровень

// double Max(double x, double y) => x > y ? x : y;

// Console.Write("Введите a: ");
// var a = double.Parse(Console.ReadLine()!);

// Console.Write("Введите b: ");
// var b = double.Parse(Console.ReadLine()!);

// var z = Max(a, 2 * b) + Max(2 * a - b, b);
// Console.WriteLine($"Результат: {z}");


// Средний уровень

// int Sum(int number) => number / 10 + number % 10;

// for (int luckyNumber = 1000; luckyNumber <= 9999; luckyNumber++)
// {
// 	if (Sum(luckyNumber / 100) == Sum(luckyNumber % 100)) Console.WriteLine(luckyNumber);
// }


// Высокий уровень

// double SqrtK(double x, int k, int n)
// {
//     if (n == 0) return 1;
//     else
//     {
//         double prevY = SqrtK(x, k, n - 1);
//         double newY = prevY - (prevY - x / Math.Pow(prevY, k - 1)) / k;
//         return newY;
//     }
// }

// Console.Write("Введите x: ");
// var x = double.Parse(Console.ReadLine()!);

// Console.Write("Введите k: ");
// var k = int.Parse(Console.ReadLine()!);

// for (int n = 1; n <= 6; n++)
// {
//     var result = SqrtK(x, k, n);
//     Console.WriteLine($"Корень при n = {n}: {result}");
// }



// Библиотеки



// Базовый уровень

// int[,] matrix = new int[4,5];
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write($"Введите число для [{i}, {j}]: ");
//         matrix[i, j] = int.Parse(Console.ReadLine()!);
//     }
// }

// int[] sums = Lib.SumColumns(matrix);
// Console.Write($"Суммы:");

// foreach (var num in sums)
// {
// 	Console.Write($"{num} ");
// }