// Вариант 23
// Одномерные массивы


// Базовый уровень

// int[] nums = new int[10];

// for (int i = 0; i < nums.Length; i++)
// {
// 	Console.Write($"Введите {i}-е число для массива: ");
// 	var readNum = int.Parse(Console.ReadLine()!);

// 	nums[i] = readNum;
// }

// Console.WriteLine($"Нынешний массив: ");

// foreach (var num in nums) Console.Write($"{num} ");
// Console.WriteLine();

// int firstNum = nums[0];
// int lastNum = nums[nums.Length - 1];

// nums[0] = lastNum;
// nums[nums.Length - 1] = firstNum;

// Console.WriteLine($"Нынешний массив: ");

// foreach (var num in nums) Console.Write($"{num} ");


// Средний уровень

// double[] arrayX = new double[9];
// for (int i = 0; i < arrayX.Length; i++)
// {
//     Console.Write($"Введите {i}-й элемент массива X: ");
//     arrayX[i] = double.Parse(Console.ReadLine()!);
// }

// double[] arrayY = new double[7];
// for (int i = 0; i < arrayY.Length; i++)
// {
//     Console.Write($"Введите {i}-й элемент массива Y: ");
//     arrayY[i] = double.Parse(Console.ReadLine()!);
// }

// double[] arrayZ = new double[arrayX.Length + arrayY.Length];
// for (int i = 0; i < arrayX.Length; i++) arrayZ[i] = arrayX[i];
// for (int i = 0; i < arrayY.Length; i++) arrayZ[arrayX.Length + i] = arrayY[i];

// Array.Sort(arrayZ);

// Console.WriteLine("Масств Z:");
// foreach (var num in arrayZ) Console.Write($"{num} ");



// Двумерные массивы


// Базовый уровень

// Random random = new();

// int n = 4, m = 5;
// double[,] A = new double[n, m];

// double sum = 0;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         A[i, j] = Math.Round(random.NextDouble() * 100, 2);
//         sum += A[i, j];
//     }
// }

// double average = sum / (n * m);

// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//     	if (A[i, j] > average) count++;
//     }
// }

// Console.WriteLine($"Среднее арифметическое в A: {average:F2}");
// Console.WriteLine($"Элементов больше среднего арифметического: {count}");


// Средний уровень

// int[,] matrix = {
//     {2, 3, 5},
//     {4, 6, 8},
//     {7, 9, 10}
// };

// int[] matrixCollumns = new int[matrix.GetLength(1)];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++)
// 	{
// 		var indexSumm = i + j;
// 		var number = matrix[i, j];
// 		var isMult = (indexSumm != 0) && (number % indexSumm == 0);

// 		if (isMult) matrixCollumns[j]++;

// 		Console.WriteLine($"Столбец: {j}, сумма индексов: {indexSumm}, число: {number}, {(isMult ? "кратен" : "не кратен")}");
// 	}
// }

// Console.WriteLine();

// int min = 0;
// for (int j = 1; j < matrixCollumns.Length; j++)
// {
//     if (matrixCollumns[j] < matrixCollumns[min])
//         min = j;
// }

// Console.WriteLine($"Столбец с минимальным количеством: {min} (кратных: {matrixCollumns[min]})");


// Высокий уровень


// int[,] A = new int[5, 5];

// for (int i = 0; i < A.GetLength(0); i++)
// {
//     for (int j = 0; j < A.GetLength(1); j++)
//     {
//         if (i == 2 || j == 2) A[i, j] = 1;
//         else A[i, j] = 0;
//     }
// }

// for (int i = 0; i < A.GetLength(0); i++)
// {
//     for (int j = 0; j < A.GetLength(1); j++) Console.Write($"{A[i, j]} ");
//     Console.WriteLine();
// }