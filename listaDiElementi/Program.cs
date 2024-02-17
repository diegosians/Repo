internal class Program
{
    private static void Main(string[] args)
    {
        List<string> listaDiAnimali = new List<string>() { "Gatto", "Cavallo", "Cane", "Pappagallo", "Serpente" };

        foreach (string valore in listaDiAnimali)
        {
            Console.WriteLine(valore);
        }

        

        string sommaListaDiAnimali = Program.GetSommaStringheLista(listaDiAnimali);
        Console.WriteLine(sommaListaDiAnimali);



    }

    internal static string GetSommaStringheLista(List<string> lista){
        string variabile= "";
        int i =0;
        foreach(string elemento in lista){
            
            variabile += lista[i];
            i++;

        }
        return variabile;
    }

}