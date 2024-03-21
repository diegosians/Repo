// Questo è il mio metodo per la funzione Reverse() di una stringa

string Reverse(string str)
{
    char[] strArray = str.ToCharArray();
    str = "";
    for (int i = strArray.Length - 1; i >= 0; i--)
    {
        str += strArray[i];
    }
    return str;
}