
internal class Program
{
    static void Main()
    {
        //scelta del numero per la resistenza
        int numero =6788;
        int resistenza = Numero.GetResistenza(numero);
   //     Console.WriteLine(resistenza);
        
        int[] array = new int[]{55, 42, 88, 42, 88, 42, 67};

    //    Console.WriteLine(Numero.GetMaxFrequente(array));
        
        int[] array1 = Numero.GetMaxFrequenti(array, 3);
        foreach(int elemento in array1){
           Console.WriteLine(elemento);
        }

    }
}

static class Numero
{
    public static int GetResistenza(int n)
    {
        int resistenza = 0;

        while (n >= 10)
        {
            string stringaNumero = n.ToString();
            char[] arrayCifreNumero = stringaNumero.ToCharArray();

            if (arrayCifreNumero.Length == 2)
            {
                int cifra1 = Convert.ToInt32(arrayCifreNumero[0].ToString());
                int cifra2 = Convert.ToInt32(arrayCifreNumero[1].ToString());
                n = cifra1 * cifra2;
                resistenza++;
            }
            else
            {
                int prodotto = 1;
                foreach (char cifraChar in arrayCifreNumero)
                {
                    int cifra = Convert.ToInt32(cifraChar.ToString());
                    prodotto *= cifra;
                }

                n = prodotto;
                resistenza++;
            }
        }

        return resistenza;
    }


    public static int GetMaxFrequente(int[] array)
    {
        Dictionary<int, int> frequenze = new Dictionary<int, int>();
    
        // Calcolo frequenze
        foreach (int elemento in array)
        {
            if (frequenze.ContainsKey(elemento))
            {
                frequenze[elemento]++;
            }
            else
            {
                frequenze[elemento] = 1;
            }
        }
    
        // Ricerca del numero più frequente
        int maxFrequenzaElemento = 0;
        int maxFrequenzaCount = 0;
    
        foreach (var coppia in frequenze)
        {
            if (coppia.Value > maxFrequenzaCount || (coppia.Value == maxFrequenzaCount && coppia.Key < maxFrequenzaElemento))
            {
                maxFrequenzaElemento = coppia.Key;
                maxFrequenzaCount = coppia.Value;
            }
        }
    
        return maxFrequenzaElemento;
    }
    
    public static int[] GetMaxFrequenti(int[] array, int k)
    {
        Dictionary<int, int> frequenze = new Dictionary<int, int>();

        // Calcolo frequenze
        foreach (int elemento in array)
        {
            if (frequenze.ContainsKey(elemento))
            {
                frequenze[elemento]++;
            }
            else
            {
                frequenze[elemento] = 1;
            }
        }
    
        
        var sortedFrequenze = frequenze.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key);

    
        var risultato = sortedFrequenze.Take(k).Select(pair => pair.Key).ToArray();

        return risultato;
    }
}

