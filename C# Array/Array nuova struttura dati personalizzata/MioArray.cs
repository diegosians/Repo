// Array personalizzato


namespace MioArray
{
    class MioArray
    {
        public int Length;
        private Object[] data;
        public bool con_stile;
        public MioArray(bool con_o_senza_stile)             // Qui è il costruttore
        {
            this.data = new Object[0];
            Length = this.data.Length;
            con_stile = con_o_senza_stile;
        }
        public Object Get(int indice_elemento){
            return this.data[indice_elemento];
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
        public void Aggiungi(params Object[] obj)
        {
            Length += obj.Length;
            Object[] data = this.data;
            this.data = new Object[Length];
            for(int i=0; i<obj.Length; i++){this.data[i] = obj[i];}
            for (int i =obj.Length; i<Length; i++){this.data[i] = data[i-obj.Length];}
        }
        public void Aggiungi<Object>(Object[] arg)
        {
            Length += arg.Length;
            object[] data = this.data;
            this.data = new object[Length];
//          assegnazione dei molteplici oggetti all'array 
            for(int i = 0; i<arg.Length; i++)
            {
#pragma warning disable CS8601 // Possibile assegnazione di riferimento Null.
                this.data[i] = arg[i];
#pragma warning restore CS8601 // Possibile assegnazione di riferimento Null.
            }
            
            for (int i = arg.Length; i < Length; i++)
            {
                this.data[i] = data[i - arg.Length];
            }
        }


        public void RimuoviUltimo()
        {
            Length--;
            Object[] data = this.data;
            this.data = new Object[Length];
            for (int i=0; i<Length; i++)
            {
                this.data[i] = data[i];
            }
            
        }

        // questa funzione rimuove il primo elemento dell'array
        public void Scartane(int indice)
        {
            if(indice!=0)
            {
                Length -= indice;
                Object[] data = this.data;
                this.data = new Object[Length];
                for (int i = indice; i < data.Length; i++)
                {
                    this.data[i-indice] = data[i];
                }      
            }
            else{ Scarta(); }

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