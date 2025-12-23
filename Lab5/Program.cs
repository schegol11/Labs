// Вариант 5
// Символьный тип данных

// Базовый уровень

// char[] chars = new char[15];

// Console.WriteLine("Введите 15 символов: ");

// for (int i = 0; i < 15; i++) chars[i] = char.Parse(Console.ReadLine()!);

// Console.WriteLine("Результат: ");

// for (int i = 0; i < 15; i++)
// {
//     chars[i] = char.IsUpper(chars[i]) ? char.ToLower(chars[i]) : char.IsLower(chars[i]) ? char.ToUpper(chars[i]) : chars[i];
//     Console.Write(chars[i]);
// }


// Средний уровень

// string[] words = {"hello", "world", "kotlin", "work", "sky", "book", "make", "cake"};
// foreach (string word in words) if (word.Contains('k')) Console.WriteLine(word);


// Высокий уровень

// char[] chars = new char[16];

// Console.WriteLine("Введите 16 символов: ");
// for (int i = 0; i < chars.Length; i++) chars[i] = char.Parse(Console.ReadLine()!);

// char max = '0';

// foreach (char c in chars) if (char.IsDigit(c) && c > max) max = c;

// Console.WriteLine($"Максимальная цифра: {max}");



// Строковый тип данных


// Базовый уровень

// string word = "Dobranoc";
// word = word + '«';
// word = word + '»';

// Console.WriteLine($"Слово с символами: {word}");


// Средний уровень

// string someString = "Some string";
// someString = someString + $"{someString.Length}";

// Console.WriteLine($"Строка с её длинной: {someString}");