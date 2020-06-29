using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoSingleton
{
    class singletonClass
    {
        private static singletonClass singletonObject;

        public int numero = 12;

        private singletonClass()
        {

        }

        public static singletonClass GetInstance 
        {
            get
            {
                if (singletonObject == null)
                {
                    singletonObject = new singletonClass();
                }
                return singletonObject;
            }
        }
    }
}
