// Array personalizzato


namespace MioArray
{

    class MioArray
    {
        public int Length;
        private Object[] data;
        public MioArray()
        {
            this.data = new Object[0];
            Length = this.data.Length;
        }
        public Object Get(int indice_elemento){
            return this.data[indice_elemento];
        }



        public void Push(Object obj)
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



        public void Append(Object obj)
        {
            Length++;
            Object[] data = this.data;
            this.data = new Object[Length];
            this.data[0] = obj;
            for (int i =1; i<Length; i++){
                this.data[i] = data[i-1];
            }
        }


        public void Pop()
        {
            Length--;
            Object[] data = this.data;
            this.data = new Object[Length];
            for (int i=0; i<Length; i++){
                this.data[i] = data[i];
            }
            
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