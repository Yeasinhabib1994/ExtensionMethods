using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a line you want to shorten:");
            var post = Console.ReadLine();
            Console.WriteLine("input number of words in shortened line: ");
            var numberOfWords = Convert.ToInt32(Console.ReadLine());
            var shortenedPost = post.Shorten(numberOfWords);

            Console.WriteLine(shortenedPost);
        }
    }
}
