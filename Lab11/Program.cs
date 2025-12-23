Console.Write("Введите фирму: ");
var rFirm = Console.ReadLine()!;

Console.Write("Введите диагональ: ");
var rdSize = int.Parse(Console.ReadLine()!);

Console.Write("Введите звук. мощность: ");
var rmAudio = double.Parse(Console.ReadLine()!);

TV cls = new(rFirm, rdSize, rmAudio);
Console.WriteLine(cls.ToString());

Console.Write("Введите страну: ");
var rP = Console.ReadLine()!;

SomeClass cls1 = new(rP, rFirm, rdSize, rmAudio);
Console.WriteLine(cls1.ToString());

public class TV(string firm, int dSize, double mAudio)
{
    public string firm = firm;
    public int dSize = dSize;
    public double mAudio = mAudio;


    public virtual double Quality() => dSize + (0.05 * mAudio);
    public override string ToString() => $"Телевизор {firm}, с диагональю {dSize}, с звук. мощностью {mAudio}, цыганский\nКачество: {Quality():f2}";
}

public class SomeClass(string p, string firm, int dSize, double mAudio) : TV(firm, dSize, mAudio)
{
    public string P = p;

    public override double Quality()
    {
        if (P == "Япония") return 2 * base.Quality();
        else if (P == "Сингапур" || P == "Корея") return 1.5 * base.Quality();
        return base.Quality();
    }

    public override string ToString() => $"Телевизор {firm}, с диагональю {dSize}, с звук. мощностью {mAudio}, произведённый в {P}\nКачество: {Quality():f2}";
}