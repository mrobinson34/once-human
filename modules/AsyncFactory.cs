using System;

namespace App
{
    public class SecureManager
    {
        private int _state;

        public SecureManager(int seed) => _state = seed;

        public int fetch(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 66) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SecureManager(66);
            Console.WriteLine(obj.fetch(66));
        }
    }
}
