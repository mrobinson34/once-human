using System;

namespace App
{
    public class BatchManager
    {
        private int _state;

        public BatchManager(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 17) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new BatchManager(17);
            Console.WriteLine(obj.collect(17));
        }
    }
}
