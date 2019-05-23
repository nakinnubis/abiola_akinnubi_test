using System;
using VersionChecker;

namespace QuestionBVersionChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two software versions separated by comma to check if you have the latest version");
            var v1 = Console.ReadLine();
            var v2 = Console.ReadLine();
            var version = VersionCheck.versionChecker(v1, v2);

            if (version == -1)
            {
                Console.WriteLine($"{v1} is older");
            }
                
            else if (version == 1)
            {
                Console.WriteLine($"{v2} is older");
            }
                
            else if(version == 0)
            {

                Console.WriteLine("Version is up to date");
            }
            else {
                Console.WriteLine("Empty string");
            }
                
        }
        
    }
}
