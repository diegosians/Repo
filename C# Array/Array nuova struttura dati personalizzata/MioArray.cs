// Array personalizzato
namespace MioArray
{

    class MioArray
    {
        public int Length;
        private Object[] data;
        public MioArray(int indice_iniziale_numero_elementi_array)
        {
            this.data = new Object[indice_iniziale_numero_elementi_array];
            Length = this.data.Length;
        }
        public Object Get(int indice_elemento){
            return this.data[indice_elemento];
        }

        public void Aggiungi(Object obj){
            Length++;
            Object[] data;
            data = this.data;
            this.data = new Object[Length];
            for(int i = 0; i<data.Length; i++)
            {
                this.data[i] = data[i];
            }
            this.data[Length - 1] = obj;
        }


        public override string ToString()
        {
            String text = "[";

            for(int i=0; i<Length; i++){
                text += this.data[i];
                if (i == Length - 1) break;
                text += ", ";
            }
            text += "]";

            return text;
        }


    }
}