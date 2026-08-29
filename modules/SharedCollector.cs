using System;

namespace App
{
    public class SharedManager
    {
        private int _state;

        public SharedManager(int seed) => _state = seed;

        public int run(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 45) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedManager(45);
            Console.WriteLine(obj.run(45));
        }
    }
}
