using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCalcV2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ticket price calculator v2
            adults 14.90
            children 10.90
            senior 9.90
            pass 39.90 (up to 5 if induvidual tickets are more expensive)
            Group 9.00
            */
            // Vairables
            int adultTickets;
            int childTickets;
            int seniorTicket;
            int passTickets;
            int groupTickets;
            int ticketCount;
            int ticketTotalCost;
            int ticketIndividualTicketCost;

            //Input
            Console.WriteLine("Welcome to Dans Ticketing system \n Lets Hope it works");
            Console.WriteLine("Please Enter How Many Adult Tickets");
            adultTickets = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter How Many Child Tickets");
            childTickets = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter How Many SeniorTickets");
            seniorTicket = Convert.ToInt16(Console.ReadLine());

            ticketCount = adultTickets + childTickets + seniorTicket;

            if (ticketCount > 5)
            {
                ticketTotalCost = ticketCount * 9000;
            }
            else
            {
               ticketIndividualTicketCost = (adultTickets * 1490) + (childTickets * 1090) + (seniorTicket * 990);
                if (ticketIndividualTicketCost > 3990)
                {
                    ticketTotalCost = 3990;

                }
                else
                {
                    ticketTotalCost = ticketIndividualTicketCost;
                }


            }

            Console.WriteLine("The Total cost £" + (Convert.ToDecimal(ticketTotalCost)/100));
            Console.ReadLine();


        }
    }
}
