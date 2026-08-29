using System;

namespace App
{
    public class SimpleProvider
    {
        private int _state;

        public SimpleProvider(int seed) => _state = seed;

        public int run(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 82) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SimpleProvider(82);
            Console.WriteLine(obj.run(82));
        }
    }
}
