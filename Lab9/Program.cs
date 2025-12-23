// Вариант 15
// Базовый уровень


// Console.Write("Введите x: ");
// var readX = int.Parse(Console.ReadLine()!);

// Console.Write("Введите y: ");
// var readY = int.Parse(Console.ReadLine()!);

// Division div = new(readX, readY);

// div.Print();
// div.Calculate();

// public class Division
// {
//     int x;
//     int y;
    
//     public Division(int x, int y)
//     {
//         this.x = x;
//         this.y = y;
//     }
    
//     public void Print() => Console.WriteLine($"x: {x}, y: {y}");
    
//     public void Calculate() => Console.WriteLine($"{x} / {y} = {x / y}");
// }


// Средний уровень

Console.Write("Фамилия: ");
var surname = Console.ReadLine()!;

Console.Write("Оклад: ");
var salary = int.Parse(Console.ReadLine()!);

Console.Write("Год поступления: ");
var year = int.Parse(Console.ReadLine()!);

Worker worker = new(surname, salary, year);

worker.Print();
worker.ShowExperience();
worker.ShowDays();

public class Worker
{
    string surname;
    int salary;
    int year;
    
    public Worker(string surname, int salary, int year)
    {
        this.surname = surname;
        this.salary = salary;
        this.year = year;
    }
    
    public void Print() => Console.WriteLine($"Фамилия: {surname}, Оклад: {salary}, Год поступления: {year}");
    
    public void ShowExperience() => Console.WriteLine($"Стаж: {DateTime.Now.Year - year} лет");
    
    public void ShowDays()
    {
        var start = new DateTime(year, 1, 1);
        Console.WriteLine($"Дней: {(DateTime.Now - start).Days}");
    }
}