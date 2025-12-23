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

// Student s1 = new()
// {
//     Number = 1,
//     FullName = "Ivanov Ivan Ivanovich",
//     BirthDay = 15,
//     BirthMonth = 5,
//     BirthYear = 2003,
//     Age = DateTime.Now.Year - 2003
// };

// Student s2 = new()
// {
//     Number = 2,
//     FullName = "Petrova Anna Sergeevna",
//     BirthDay = 22,
//     BirthMonth = 3,
//     BirthYear = 2004,
//     Age = DateTime.Now.Year - 2004
// };

// Student s3 = new()
// {
//     Number = 3,
//     FullName = "Sidorov Alexey Petrovich",
//     BirthDay = 10,
//     BirthMonth = 7,
//     BirthYear = 2002,
//     Age = DateTime.Now.Year - 2002
// };

// Student s4 = new()
// {
//     Number = 4,
//     FullName = "Kuznetsova Maria Dmitrievna",
//     BirthDay = 29,
//     BirthMonth = 2,
//     BirthYear = 2000,
//     Age = DateTime.Now.Year - 2000
// };

// Student s5 = new()
// {
//     Number = 5,
//     FullName = "Smirnov Pavel Olegovich",
//     BirthDay = 14,
//     BirthMonth = 11,
//     BirthYear = 2003,
//     Age = DateTime.Now.Year - 2003
// };

// Student[] students = { s1, s2, s3, s4, s5 };
// string[] daysOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

// foreach (var student in students)
// {
//     students[student.Number - 1].Age = DateTime.Now.Year - student.BirthYear;
//     DateTime birthDate = new DateTime(student.BirthYear, student.BirthMonth, student.BirthDay);
//     int dayOfWeek = ((int)birthDate.DayOfWeek == 0) ? 7 : (int)birthDate.DayOfWeek;
    
//     Console.WriteLine($"Имя: {student.FullName}");
//     Console.WriteLine($"День рождения: {birthDate:dd.MM.yyyy}");
//     Console.WriteLine($"День недели: {daysOfWeek[dayOfWeek - 1]} ({dayOfWeek})");
//     Console.WriteLine($"Возраст: {student.Age}");
//     Console.WriteLine();
// }

// Console.WriteLine("Студенты, которые родились в високостный год: ");
// foreach (var student in students)
// {
//     if (DateTime.IsLeapYear(student.BirthYear)) Console.WriteLine($"{student.FullName} ({student.BirthDay:00}.{student.BirthMonth:00}.{student.BirthYear})");
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
