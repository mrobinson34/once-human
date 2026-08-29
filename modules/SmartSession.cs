using System;

namespace App
{
    public class AsyncService
    {
        private int _state;

        public AsyncService(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 23) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncService(23);
            Console.WriteLine(obj.collect(23));
        }
    }
}
