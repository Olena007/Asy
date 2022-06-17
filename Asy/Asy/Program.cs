using System;
using System.Threading.Tasks;

namespace Asy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Tasks tasks = new Models.Tasks();

            tasks.Both().Wait();
        }
    }
}
