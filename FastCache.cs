using System;

namespace App
{
    public class FastBuffer
    {
        private int _state;

        public FastBuffer(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 61) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new FastBuffer(61);
            Console.WriteLine(obj.decode(61));
        }
    }
}
