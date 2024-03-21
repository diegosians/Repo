// Array personalizzato
namespace Vettore;

internal class Program
{
    private static void Main(string[] args)
    {
//  il parametro di valore bool permette di scegliere se il nostro oggetto
//  deve avere lo stile dell'array o meno in fase di costruzione
        MioArray array = new MioArray(false);
        
        Object[] messaggio = {"My phone number:", 39, 3713936694};
        
        array.Aggiungi(messaggio);

        array.RimuoviUltimo();

        array.Spingi(3394172276);

        Console.WriteLine(array.ToString());

    }
}