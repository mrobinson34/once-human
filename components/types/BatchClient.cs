using System;

namespace App
{
    public class SimpleParser
    {
        private int _state;

        public SimpleParser(int seed) => _state = seed;

        public int render(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 78) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SimpleParser(78);
            Console.WriteLine(obj.render(78));
        }
    }
}
