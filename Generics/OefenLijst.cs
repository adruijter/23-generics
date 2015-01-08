using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class OefenLijst<U>
    {
        //Fields
        private U[] lijst;

        //Properties
        public U[] Lijst
        {
            get { return this.lijst; }
        }

        //Constructor
        public OefenLijst(U item)
        {
            this.lijst = new U[1];
            this.lijst[0] = item;
        }

        //Methods
        public void Add(U item)
        {
            U[] temp = new U[lijst.Length + 1];

            for (int i = 0; i < lijst.Length; i++)
            {
                temp[i] = lijst[i];
            }
            temp[temp.Length - 1] = item;
            lijst = temp;
        }

    }  
}
