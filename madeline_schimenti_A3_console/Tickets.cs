using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madeline_schimenti_A3_console
{
    class Tickets
    {
        int counter = 0;

    public void DisplayMessage()
    {
        Console.WriteLine("Ticket Ordering System\nEnter the number of tickets to order\nor enter a zero <0> to show the summary\nor enter a negative number when you are done.");
    }

        public void CountTickets()
    {
        


        int total;
        total = 0;
        Console.Write("Enter number of tickets to order: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
               
       while( userInput >= 0)
       {
           total = total + userInput;
           Console.Write("Enter next order: ");
           userInput = Convert.ToInt32(Console.ReadLine());

           if (userInput == 0)
           {
               Console.WriteLine("Total Tickets Ordered: " + total);
           }
          
       }

       Console.WriteLine("Thank you for your order of " + total + " tickets!");
    }
    }
}
