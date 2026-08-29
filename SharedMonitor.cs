using System;

namespace App
{
    public class AsyncProcessor
    {
        private int _state;

        public AsyncProcessor(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 83) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncProcessor(83);
            Console.WriteLine(obj.handle(83));
        }
    }
}
