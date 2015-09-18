using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_A3_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tickets tickets = new Tickets();

            tickets.DisplayMessage();

            tickets.CountTickets();



            Console.ReadLine();
        }
    }
}
