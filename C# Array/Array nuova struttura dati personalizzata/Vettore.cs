

namespace Vettore
{
public class Vettore
{
    public int Length;
    private Object[] data;
    public bool con_stile;
    public Vettore(bool con_o_senza_stile)
    {
        this.data = new Object[0];
        Length = this.data.Length;
        con_stile = con_o_senza_stile;
    }
    public Object Get(int indice_elemento)
    {
        return this.data[indice_elemento];
    }

    public Object[] Data
    {
        get { return data; }
        set { data = value; Length = data.Length; }
    }


    public void Spingi(Object obj)
    {
        Length++;
        Object[] data;
        data = this.data;
        this.data = new Object[Length];
        for (int i = 0; i < data.Length; i++)
        {
            this.data[i] = data[i];
        }
        this.data[Length - 1] = obj;
    }
    
    
    
    public void Concatena(params Array[] args )
    {   
        int indice = args.Length;
        foreach(Array array in  args)
        {
            foreach(Object obj in array)
            {
                Spingi(obj);
            }
        }
    }




    

    public void Aggiungi(params Object[] obj)
    {
        Length += obj.Length;
        Object[] data = this.data;
        this.data = new Object[Length];
        for (int i = 0; i < obj.Length; i++) { this.data[i] = obj[i]; }
        for (int i = obj.Length; i < Length; i++) { this.data[i] = data[i - obj.Length]; }
    }


    public void Rimuovi()
    {
        Length--;
        Object[] data = this.data;
        this.data = new Object[Length];
        for (int i = 0; i < Length; i++)
        {
            this.data[i] = data[i];
        }

    }

    public void Rimuovine(int n)
    {
        Length -= n;
        Object[] data = this.data;
        this.data = new Object[Length];
        for (int i = 0; i < Length; i++) 
        { 
            this.data[i] = data[i]; 
        }
    }


    public void Scartane(int indice)
    {
        if (indice != 0)
        {
            Length -= indice;
            Object[] data = this.data;
            this.data = new Object[Length];
            for (int i = indice; i < data.Length; i++)
            {
                this.data[i - indice] = data[i];
            }
        }
        else { Scarta(); }

    }

    public void Scarta()
    {
        Length--;
        Object[] data = this.data;
        this.data = new Object[Length];
        for (int i = 1; i < data.Length; i++)
        {
            this.data[i - 1] = data[i];
        }
    }



    public override String ToString()
    {
        String text = "";

        if (con_stile)
        {
            text = "[";
            for (int i = 0; i < Length; i++)
            {
                text += this.data[i];
                if (i == Length - 1) break;
                text += ", ";

            }
            text += "]";
        }
        else
        {
            for (int i = 0; i < Length; i++)
            {
                text += this.data[i];
                if (i == Length - 1) break;
                text += " ";
            }
        }
        return text;
    }
}
}