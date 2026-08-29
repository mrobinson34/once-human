using System;

namespace App
{
    public class FastClient
    {
        private int _state;

        public FastClient(int seed) => _state = seed;

        public int collect(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 74) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new FastClient(74);
            Console.WriteLine(obj.collect(74));
        }
    }
}
