using System;

namespace App
{
    public class StreamProcessor
    {
        private int _state;

        public StreamProcessor(int seed) => _state = seed;

        public int handle(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 56) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new StreamProcessor(56);
            Console.WriteLine(obj.handle(56));
        }
    }
}
