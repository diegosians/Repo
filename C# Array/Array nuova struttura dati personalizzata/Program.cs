// Array personalizzato
namespace MioArray;

internal class Program
{
    private static void Main(string[] args)
    {
        MioArray array = new MioArray(10);
        array.Aggiungi(456);
        array.Aggiungi(7);
        array.Aggiungi("Arancia");
        Console.Write(array.ToString());

    }
}