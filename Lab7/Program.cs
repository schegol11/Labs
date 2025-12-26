// Вариант 3
// Структуры

// Базовый уровень

// Console.Write("Введите количество товаров: ");
// int productCount = int.Parse(Console.ReadLine()!);
// Product[] products = new Product[productCount];

// for (int i = 0; i < productCount; i++)
// {
//     Product product = new Product();
    
//     Console.WriteLine($"Товар {i + 1}:");
    
//     Console.Write("Имя продавца: ");
//     product.SallerName = Console.ReadLine()!;
    
//     Console.Write("Название товара: ");
//     product.ProductName = Console.ReadLine()!;
    
//     Console.Write("Количество: ");
//     product.Multiply = int.Parse(Console.ReadLine()!);
    
//     Console.Write("Цена: ");
//     product.Cost = int.Parse(Console.ReadLine()!);
    
//     Console.Write("День продажи: ");
//     int day = int.Parse(Console.ReadLine()!);
    
//     Console.Write("Месяц продажи: ");
//     int month = int.Parse(Console.ReadLine()!);
    
//     Console.Write("Год продажи: ");
//     int year = int.Parse(Console.ReadLine()!);
    
//     product.SellDate = new DateTime(year, month, day);
    
//     products[i] = product;
// }

// DateTime currentDate = DateTime.Now;

// foreach (var product in products)
// {
//     if ((currentDate - product.SellDate).Days < 365)
//     {
//         Console.WriteLine($"Товар, проданный менее года назад: {product.ProductName} от {product.SallerName}");
//         Console.WriteLine($"Количество: {product.Multiply}");
//         Console.WriteLine($"Цена: {product.Cost}");
//         Console.WriteLine($"Дата продажи: {product.SellDate:dd}.{product.SellDate:MM}.{product.SellDate:yyyy}");
//         Console.WriteLine();
//     }
// }

// struct Product
// {
//     public string SallerName;
//     public string ProductName;
//     public int Multiply;
//     public int Cost;
//     public DateTime SellDate;
// }

// Средний уровень


// Console.Write("Введите количество работников: ");
// int workerCount = int.Parse(Console.ReadLine()!);
// Worker[] workers = new Worker[workerCount];

// for (int i = 0; i < workerCount; i++)
// {
//     Worker worker = new Worker();
    
//     Console.WriteLine($"Работник {i + 1}:");
    
//     Console.Write("Фамилия: ");
//     worker.LastName = Console.ReadLine()!;
    
//     Console.Write("Имя: ");
//     worker.FirstName = Console.ReadLine()!;
    
//     Console.Write("Отчество: ");
//     worker.MiddleName = Console.ReadLine()!;
    
//     Console.Write("Должность: ");
//     worker.Job = Console.ReadLine()!;
    
//     Console.Write("Зарплата: ");
//     worker.Salary = int.Parse(Console.ReadLine()!);
    
//     Console.Write("День рождения: ");
//     int day = int.Parse(Console.ReadLine()!);
    
//     Console.Write("Месяц рождения: ");
//     int month = int.Parse(Console.ReadLine()!);
    
//     Console.Write("Год рождения: ");
//     int year = int.Parse(Console.ReadLine()!);
    
//     worker.BirthDate = new DateTime(year, month, day);
    
//     workers[i] = worker;
// }

// DateTime currentDate = DateTime.Now;

// int averageSalary = 0;
// foreach (var worker in workers) averageSalary += worker.Salary;
// averageSalary /= workers.Length;

// Console.WriteLine($"Средняя зарплата: {averageSalary}");
// Console.WriteLine("Сотрудники с зарплатой выше средней и возрастом до 30 лет:\n");

// foreach (var worker in workers)
// {
//     int age = currentDate.Year - worker.BirthDate.Year;
//     if (worker.BirthDate.AddYears(age) > currentDate) age--;
    
//     if (worker.Salary > averageSalary && age < 30)
//     {
//         Console.WriteLine($"ФИО: {worker.LastName} {worker.FirstName} {worker.MiddleName}");
//         Console.WriteLine($"Должность: {worker.Job}");
//         Console.WriteLine($"Зарплата: {worker.Salary}");
//         Console.WriteLine($"Дата рождения: {worker.BirthDate:dd}.{worker.BirthDate:MM}.{worker.BirthDate:yyyy}");
//         Console.WriteLine($"Возраст: {age}");
//         Console.WriteLine();
//     }
// }

// struct Worker
// {
//     public string LastName;
//     public string FirstName;
//     public string MiddleName;
//     public string Job;
//     public int Salary;
//     public DateTime BirthDate;
// }