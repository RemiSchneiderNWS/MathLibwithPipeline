using System;

namespace MathLibrary
{
    public class Math
    {
        public int addition(int value1 , int value2)
        {
            return value1 + value2;
        }

        public int multiplication(int value1, int value2)
        {
            return value1 * value2;
        }
        public int division(int value1, int value2)
        {
            if(value2 == 0)
            {
                throw new Exception("On ne peux pas diviser par zero !");
            }

            return value1 / value2;
        }
        public int soustraction(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
