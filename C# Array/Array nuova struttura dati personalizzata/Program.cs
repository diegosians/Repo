// Array personalizzato
namespace Vettore;

internal class Program
{
    private static void Main(string[] args)
    {
//  il parametro di valore bool permette di scegliere se il nostro oggetto
//  deve avere lo stile dell'array o meno in fase di costruzione
        Vettore array = new Vettore(false);
        Vettore array1 = new Vettore(true);

        object[] messaggio = { "My phone number:", 39, 1234567890 };
        
        array.Aggiungi(messaggio);

        array.RimuoviUltimo();

        array.Spingi(3713936694);

        Console.WriteLine(array.ToString());
        // accetta qualsiasi tipo di oggetto oppure solamente un array come parametro/i
        array1.Aggiungi(true, 0.69812, 45, "Array", "con", "stile");
        array1.Scarta();
        array1.Scartane(2);
        Console.WriteLine(array1.ToString());


    }
}