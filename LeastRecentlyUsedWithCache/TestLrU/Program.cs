using LeastRecentlyUsedCache;
using System;

namespace TestLrU
{
    class Program
    {
        static void Main(string[] args)
        {
            var lrucache = new LRUCache(5);
            lrucache.put(1, 2);
            //  lrucache.get(1);
            //Chilkat.Rest rest = new Chilkat.Rest();
            //Console.WriteLine(rest.Version);
            Console.WriteLine(lrucache.get(1));
        }
    }
}
