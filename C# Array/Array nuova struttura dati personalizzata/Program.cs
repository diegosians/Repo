// Array personalizzato
namespace MioArray;

internal class Program
{
    private static void Main(string[] args)
    {
        MioArray array = new MioArray();
        array.Push(7);
        array.Push("Arancia");
        array.Push(true);
        array.Push("Senape");
        array.Append(false);
        array.Append("$");

        array.Pop();
        array.Pop();
        array.Pop();

        Console.Write(array.ToString());

    }
}
