// Вариант 3
// Структуры

// Базовый уровень


// Product laptop = new()
// {
//     SallerName = "Ivan",
//     ProductName = "Laptop",
//     Multiply = 1,
//     Cost = 25000,
//     SellDate = new DateTime(2024, 5, 11)
// };

// Product phone = new()
// {
//     SallerName = "Michail",
//     ProductName = "Phone",
//     Multiply = 2,
//     Cost = 7500,
//     SellDate = new DateTime(2021, 4, 4)
// };

// Product pc = new()
// {
//     SallerName = "Petr",
//     ProductName = "PC",
//     Multiply = 1,
//     Cost = 15400,
//     SellDate = new DateTime(2025, 1, 15)
// };

// Product microphone = new()
// {
//     SallerName = "Oleg",
//     ProductName = "Microphone",
//     Multiply = 1,
//     Cost = 2500,
//     SellDate = new DateTime(2024, 12, 15)
// };

// Product[] products = { laptop, phone, pc, microphone };
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


Worker w1 = new()
{
    LastName = "Ivanov",
    FirstName = "Ivan",
    MiddleName = "Ivanovich",
    Job = "Developer",
    Salary = 85000,
    BirthDate = new DateTime(1998, 5, 15)
};

Worker w2 = new()
{
    LastName = "Petrov",
    FirstName = "Petr",
    MiddleName = "Petrovich",
    Job = "Tester",
    Salary = 55000,
    BirthDate = new DateTime(1990, 3, 22)
};

Worker w3 = new()
{
    LastName = "Sidorova",
    FirstName = "Anna",
    MiddleName = "Sergeevna",
    Job = "Designer",
    Salary = 75000,
    BirthDate = new DateTime(1995, 7, 10)
};

Worker w4 = new()
{
    LastName = "Kozlov",
    FirstName = "Alex",
    MiddleName = "Alexeevich",
    Job = "Manager",
    Salary = 80000,
    BirthDate = new DateTime(1999, 11, 30)
};

Worker w5 = new()
{
    LastName = "Smirnova",
    FirstName = "Maria",
    MiddleName = "Dmitrievna",
    Job = "Analyst",
    Salary = 90000,
    BirthDate = new DateTime(1997, 2, 14)
};

Worker[] workers = { w1, w2, w3, w4, w5 };
DateTime currentDate = DateTime.Now;


int averageSalary = 0;
foreach (var worker in workers) averageSalary += worker.Salary;

averageSalary /= workers.Length;

Console.WriteLine($"Средняя зарплата: {averageSalary}");
Console.WriteLine("Сотрудники с зарплатой выше средней и возрастом до 30 лет:\n");

foreach (var worker in workers)
{
    if (worker.Salary > averageSalary && (currentDate.Year - worker.BirthDate.Year) < 30)
    {
        Console.WriteLine($"ФИО: {worker.LastName} {worker.FirstName} {worker.MiddleName}");
        Console.WriteLine($"Должность: {worker.Job}");
        Console.WriteLine($"Зарплата: {worker.Salary}");
        Console.WriteLine($"Дата рождения: {worker.BirthDate:dd}.{worker.BirthDate:MM}.{worker.BirthDate:yyyy}");
        Console.WriteLine($"Возраст: {currentDate.Year - worker.BirthDate.Year}");
        Console.WriteLine();
    }
}

struct Worker
{
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public string Job;
    public int Salary;
    public DateTime BirthDate;
}