// Вариант 14
// Дата и время

// Базовый уровень

// 1

// Console.Write("Введите время (ЧЧ:ММ:СС): ");
// string hms = Console.ReadLine()!;
// var time = TimeSpan.Parse(hms);

// Console.WriteLine($"Результат: {time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}");

// 2

// Console.Write("Введи дату голосования (ДД.ММ.ГГГГ): ");
// var date = Console.ReadLine()!;
// var voteDate = DateTime.ParseExact(date, "dd.MM.yyyy", null);

// var now = DateTime.Now;
// var stopAggDate = voteDate.AddDays(-1);

// var daysLeft = (voteDate.Date - now.Date).TotalDays;

// Console.WriteLine($"До голосования: {daysLeft} дней");
// Console.WriteLine($"Агитация до: {stopAggDate:dd.MM.yyyy}");


// Средний уровень

// Student[] students;
// string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// Console.Write("Введите количество студентов: ");
// int studentCount = int.Parse(Console.ReadLine()!);
// students = new Student[studentCount];

// for (int i = 0; i < studentCount; i++)
// {
//     Student student = new Student();

//     Console.WriteLine($"Студент {i + 1}:");
//     student.Number = i + 1;

//     Console.Write("ФИО: ");
//     student.FullName = Console.ReadLine()!;

//     Console.Write("День рождения: ");
//     student.BirthDay = int.Parse(Console.ReadLine()!);

//     Console.Write("Месяц рождения: ");
//     student.BirthMonth = int.Parse(Console.ReadLine()!);

//     Console.Write("Год рождения: ");
//     student.BirthYear = int.Parse(Console.ReadLine()!);

//     student.Age = DateTime.Now.Year - student.BirthYear;

//     students[i] = student;
// }

// foreach (var student in students)
// {
//     DateTime birthDate = new DateTime(student.BirthYear, student.BirthMonth, student.BirthDay);
//     int dayOfWeek = ((int)birthDate.DayOfWeek == 0) ? 7 : (int)birthDate.DayOfWeek;

//     Console.WriteLine($"Имя: {student.FullName}");
//     Console.WriteLine($"День рождения: {birthDate:dd.MM.yyyy}");
//     Console.WriteLine($"День недели: {daysOfWeek[dayOfWeek - 1]} ({dayOfWeek})");
//     Console.WriteLine($"Возраст: {student.Age}");
//     Console.WriteLine();
// }

// Console.WriteLine("Студенты, которые родились в високосный год: ");
// foreach (var student in students)
// {
//     if (DateTime.IsLeapYear(student.BirthYear))
//         Console.WriteLine($"{student.FullName} ({student.BirthDay:00}.{student.BirthMonth:00}.{student.BirthYear})");
// }

// struct Student
// {
//     public int Number;
//     public string FullName;
//     public int BirthDay;
//     public int BirthMonth;
//     public int BirthYear;
//     public int Age;
// }