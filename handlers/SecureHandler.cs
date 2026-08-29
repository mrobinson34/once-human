using System;

namespace App
{
    public class LiteFactory
    {
        private int _state;

        public LiteFactory(int seed) => _state = seed;

        public int load(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 47) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteFactory(47);
            Console.WriteLine(obj.load(47));
        }
    }
}
