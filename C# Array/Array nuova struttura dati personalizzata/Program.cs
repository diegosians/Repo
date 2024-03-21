// Array personalizzato


namespace Vettore
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //  il parametro di valore bool permette di scegliere se il nostro oggetto
            //  deve avere lo stile dell'array o meno in fase di costruzione
            Vettore array = new Vettore(false);
            Vettore array1 = new Vettore(true);

            object[] messaggio = { "My phone number:", 39, 1234567890 };
            // inizio setting manuale
            array.Aggiungi(messaggio);

            array.RimuoviUltimo();

            array.Spingi(3713936694);
            // fine setting manuale

            // inizio setting rapido
            array = new Vettore(false)
            {
                // oppure nel caso di un Vettore inizializzato in precedenza, si puo' usare array.Data = messaggio; o array.Data = ["My phone number:", 39, 1234567890]
                Data = messaggio
            };
            // fine setting rapido

            Console.WriteLine(array.ToString());
            // accetta qualsiasi tipo di oggetto oppure solamente un array come parametro/i
            array1.Aggiungi(true, 0.69812, 45, "Array", "con", "stile");
            array1.Scarta();
            array1.Scartane(2);
            // Console.WriteLine(array1.ToString()); output --> ["Array", "con", "stile"]

            // semplice modo per il reset di un oggetto array
            array1.Data = ["Array", "con", "stile"];
            array1.con_stile = true;
            Console.WriteLine(array1.ToString());

            // Vettore per assegnazione in dichiarazione
            Vettore vet = new Vettore(false) { Data = ["Ultimo", "oggetto di array", "dimostrativo"] };
            Console.Write(vet.ToString());

        }
    }
}