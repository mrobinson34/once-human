using System;

namespace App
{
    public class FastService
    {
        private int _state;

        public FastService(int seed) => _state = seed;

        public int parse(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 95) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new FastService(95);
            Console.WriteLine(obj.parse(95));
        }
    }
}
