﻿using System;
using CongestionChargeGit.Persistence.Models;
using System.Collections.Generic;
using CongestionChargeGit.Contracts.Enums;
using System.Linq;



namespace CongestionChargeGit
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Transport> transportList = new List<Transport> {
                new Transport { TransportId = Guid.NewGuid(), TransportType = "Car", StartTime = new DateTime( 2008,04,24, 11, 32,00), EndTime = new DateTime(2008, 04, 24, 14, 42, 00) },
                new Transport { TransportId = Guid.NewGuid(), TransportType = "Motorbike", StartTime = new DateTime (2008, 04, 24, 17, 00, 00), EndTime =  new DateTime(2008, 04, 24, 22, 11 ,00) },
                new Transport { TransportId = Guid.NewGuid(), TransportType = "Van", StartTime = new DateTime(2008,04,25,10,23,00), EndTime =  new DateTime(2008, 04, 28, 09, 02 ,00) }
                };
            
            var choiceCommand = 7;
            var bill = new Bill();
            var transport = new Transport();
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
                        Console.WriteLine("Select the type of transport: \n 1 - Car; \n 2 - Van \n 3 - Motorbike ");
                        var choiceTransport = int.Parse(Console.ReadLine());
                        switch (choiceCommand) 
                        {
                            case 1:
                               
                            Console.WriteLine("Enter start time in   DD/MM/YYYY HH:MM  : ");
                            var startTime = Console.ReadLine();

                            Console.WriteLine("Enter end time in   DD/MM/YYYY HH:MM  : ");
                            var endTime = Console.ReadLine();


                            break;

                            case 2:

                                Console.WriteLine("Enter start time in   DD/MM/YYYY HH:MM  : ");
                                startTime = Console.ReadLine();

                                Console.WriteLine("Enter end time in   DD/MM/YYYY HH:MM  : ");
                                endTime = Console.ReadLine();


                                break;

                            case 3:

                                Console.WriteLine("Enter start time in   DD/MM/YYYY HH:MM  : ");
                                startTime = Console.ReadLine();

                                Console.WriteLine("Enter end time in   DD/MM/YYYY HH:MM  : ");
                                endTime = Console.ReadLine();


                                break;
                        }
                        break;

                    case 3:

                        var app = new CongestionCharge(transportList);
                      
                       for (var i = 0; i < transportList.Count; i++)
                        {
                            transportList[i].UpdateQuality();
                            Console.WriteLine(transportList[i]);
                        };

                        Console.WriteLine("");
                        app.UpdateQuality();
                        
                        break;

                    case 9:

                        Console.WriteLine("Good luck!!!");
                        break;
                }
            }
        }
    }
}
