using System;

namespace App
{
    public class CoreClient
    {
        private int _state;

        public CoreClient(int seed) => _state = seed;

        public int load(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 62) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new CoreClient(62);
            Console.WriteLine(obj.load(62));
        }
    }
}
