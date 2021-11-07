using System;
using CongestionChargeGit.Persistence.Models; 



namespace CongestionChargeGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var choiceCommand = 7;
            var bill = new Bill();
            while (choiceCommand != 9)
            {
                Console.WriteLine("Your choice : ");
                Console.WriteLine("1 - Calculate Fee");
                Console.WriteLine("3 - Calculation Example");
                Console.WriteLine("9 - Exit");


                choiceCommand = int.Parse(Console.ReadLine());
                switch (choiceCommand)
                {
                    case 1:
                        Console.WriteLine("Select the type of transport: \n 1 - Car; \n 2 - Large Vehicles \n 3 - Motorbike ");
                        var choiceTransport = Console.ReadLine();

                        Console.WriteLine("Enter start time in   DD/MM/YYYY HH:MM  : ");
                        var startTime = Console.ReadLine();

                        Console.WriteLine("Enter end timein   DD/MM/YYYY HH:MM  : ");
                        var endTime = DateTime.Parse(Console.ReadLine());

                        /*                            if(endTime < startTime)
                                                        {
                                                        Console.WriteLine("End time cannot be before start time!!!");
                                                        }
                        */
                        break;
                    case 3:
                        Console.WriteLine("3");
                        bill.Example();
                        break;

                    case 9:
                        Console.WriteLine("Good luck!!!");
                        break;
                }
            }
        }
    }
}
