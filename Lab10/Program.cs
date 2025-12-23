// Вариант 15
// Базовый уровень


Console.Write("Введите x: ");
var readX = int.Parse(Console.ReadLine()!);

Console.Write("Введите y: ");
var readY = int.Parse(Console.ReadLine()!);

Console.Write("Введите z: ");
var readZ = double.Parse(Console.ReadLine()!);

Division div = new(readX, readY);
ExtendedDivision extDiv = new(readX, readY, readZ);

div.Print();
div.Calculate();

extDiv.Print();
extDiv.CalculateExpression();

public class Division
{
    protected int x;
    protected int y;
    
    public Division(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public void Print() => Console.WriteLine($"x: {x}, y: {y}");
    public void Calculate() => Console.WriteLine($"{x} / {y} = {x / y}");
}

public class ExtendedDivision(int x, int y, double z) : Division(x, y)
{
    double z = z;
    
    public new void Print() => Console.WriteLine($"x: {x}, y: {y}, z: {z}");
    public void CalculateExpression() => Console.WriteLine($"x/2 + y/2 = {x / 2.0 + y / 2.0}");
}


// Средний уровень


// Console.Write("Фамилия: ");
// var lastname = Console.ReadLine()!;

// Console.Write("Оклад: ");
// var salary = int.Parse(Console.ReadLine()!);

// Console.Write("Год поступления: ");
// var year = int.Parse(Console.ReadLine()!);

// Worker worker = new(lastname, salary, year);

// worker.Print();
// worker.ShowExperience();


// Console.Write("Год рождения: ");
// var birthYear = int.Parse(Console.ReadLine()!);

// ExtendedWorker extWorker = new(lastname, salary, year, birthYear);

// extWorker.Print();
// extWorker.ShowRetirementInfo();

// public class Worker(string lastname, int salary, int year)
// {
//     protected string lastname = lastname;
//     protected int salary = salary;
//     protected int year = year;
    
//     public void Print() => Console.WriteLine($"Фамилия: {lastname}, Оклад: {salary}, Год поступления: {year}");
    
//     public void ShowExperience() => Console.WriteLine($"Стаж: {DateTime.Now.Year - year} лет");
// }

// public class ExtendedWorker(string lastname, int salary, int year, int birthYear) : Worker(lastname, salary, year)
// {
//     int birthYear = birthYear;
    
//     public new void Print() => Console.WriteLine($"Фамилия: {lastname}, Оклад: {salary}, Год поступления: {year}, Год рождения: {birthYear}");
    
//     public void ShowRetirementInfo()
//     {
//         int age = DateTime.Now.Year - birthYear;
        
//         if (age < 60) Console.WriteLine($"До 60 лет: {60 - age} лет");
//         else Console.WriteLine($"После 60 лет: {age - 60} лет");
//     }
// }