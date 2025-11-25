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

