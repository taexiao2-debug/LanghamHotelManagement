
/*
 * Project Name: LANGHAM Hotel Management System
 * Author Name: [Your Name]
 * Date: 04/11/2026
 * Application Purpose: Console-based hotel management system
 * for managing rooms, customers and room allocations.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assessment2Task2
{
    // Custom Class - Room
    public class Room
    {
        public int RoomNo { get; set; }
        public bool IsAllocated { get; set; }
    }

    // Custom Class - Customer
    public class Customer
    {
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; } = "";
    }

    // Custom Class - RoomAllocation
    public class RoomlAllocaltion
    {
        public int AllocatedRoomNo { get; set; }
        public Customer AllocatedCustomer { get; set; } = new Customer();
    }

    // Custom Main Class - Program
    class Program
    {
        // Variables declaration and initialization
        public static Room[] listofRooms = Array.Empty<Room>();
        public static int[] listOfRoomlAllocaltions = Array.Empty<int>();
        public static string filePath = "";

        // Main function
        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            filePath = Path.Combine(folderPath, "HotelManagement.txt");

            char ans = 'N';

            do
            {
                Console.Clear();

                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("                 LANGHAM HOTEL MANAGEMENT SYSTEM");
                Console.WriteLine("                            MENU");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("1. Add Rooms");
                Console.WriteLine("2. Display Rooms");
                Console.WriteLine("3. Allocate Rooms");
                Console.WriteLine("4. De-Allocate Rooms");
                Console.WriteLine("5. Display Room Allocation Details");
                Console.WriteLine("6. Billing");
                Console.WriteLine("7. Save the Room Allocations To a File");
                Console.WriteLine("8. Show the Room Allocations From a File");
                Console.WriteLine("9. Exit");
                // Add new option 0 for Backup
                Console.WriteLine("***********************************************************************************");

                Console.Write("Enter Your Choice Number Here: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // Adding Rooms function
                        Console.WriteLine("Add Rooms feature is under development.");
                        break;

                    case 2:
                        // Display Rooms function
                        Console.WriteLine("Display Rooms feature is under development.");
                        break;

                    case 3:
                        // Allocate Room To Customer function
                        Console.WriteLine("Allocate Rooms feature is under development.");
                        break;

                    case 4:
                        // De-Allocate Room From Customer function
                        Console.WriteLine("De-Allocate Rooms feature is under development.");
                        break;

                    case 5:
                        // Display Room Allocations function
                        Console.WriteLine("Display Room Allocation Details feature is under development.");
                        break;

                    case 6:
                        // Billing function
                        Console.WriteLine("Billing Feature is Under Construction and will be added soon...!!!");
                        break;

                    case 7:
                        // SaveRoomAllocationsToFile
                        Console.WriteLine("Save Room Allocations feature is under development.");
                        break;

                    case 8:
                        // Show Room Allocations From File
                        Console.WriteLine("Show Room Allocations From File feature is under development.");
                        break;

                    case 9:
                        // Exit Application
                        Console.WriteLine("Thank you for using LANGHAM Hotel Management System.");
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.Write("\nWould You Like To Continue(Y/N): ");

                string input = Console.ReadLine() ?? "N";

                ans = input.Length > 0 ? input[0] : 'N';

            } while (ans == 'y' || ans == 'Y');

            Console.WriteLine("Thank you for using LANGHAM Hotel Management System.");
            Console.WriteLine("Program closed successfully.");
        }
    }
}
