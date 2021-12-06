using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary;

namespace ConsoleTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var usersData = await ResultRepositoryFactory.GetWomenResult();
            Console.WriteLine(usersData);
            Console.ReadLine();
        }
    }
}
