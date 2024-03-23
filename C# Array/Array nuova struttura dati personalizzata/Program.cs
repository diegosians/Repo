// Array personalizzato
namespace Vettore;


internal class Program
{
    private static void Main(string[] args)
    {
        Vettore v = new Vettore(false);    
        Object[] array = ["ciao", "Michele", "ho", 15, "anni", "P.IVA:"];
        long[] array1 = [86334519757];

        v.Concatena(array, array1);
        Console.WriteLine(v.ToString());
        
    }
}
