namespace Imitando_Dory;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Imitando Dory");
        Console.WriteLine();

        Console.WriteLine("Uma frase para ser traduzida: ");
        string Baleia = Console.ReadLine()!;

        string Frasebaleia = Baleia

        .Replace("a", "aa")
        .Replace("e", "ee")
        .Replace("i", "ii")
        .Replace("o", "oo")
        .Replace("u", "uu");

        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Frase traduzida:");
        Console.WriteLine((Frasebaleia));
    }
}
