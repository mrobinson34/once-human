using System;

namespace App
{
    public class HybridHandler
    {
        private int _state;

        public HybridHandler(int seed) => _state = seed;

        public int encode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 90) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridHandler(90);
            Console.WriteLine(obj.encode(90));
        }
    }
}
