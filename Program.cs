using System;
using System.IO;

namespace Ticket2
{
    class Program
    {
        static void Main(string[] args)
        {
             string file = "Tickets.csv";
                string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // TODO: read data from file
                        if (File.Exists(file))
                    {
                        // accumulators needed for GPA
                        
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|');
                            // display array data
                            Console.WriteLine("TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                            // add to accumulators
                            
                        }
                        sr.Close();
                        // calculate GPA
                        
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                                        // create file from data
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 6; i++)
                    {
                        // ask a question
                        Console.WriteLine("Would you like to enter a new ticket? (Y/N)?");
                        // input the responsedo
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                        // prompt for TicketID
                        Console.WriteLine("Enter the ticket ID");
                        // save the course name
                        string TicketID = Console.ReadLine();
                        // prompt for Ticket Summary
                        Console.WriteLine("Enter the ticket summary");
                        // prompt for Ticket Status
                        string summary = Console.ReadLine();
                        Console.WriteLine("Enter the ticket status");
                        string status = Console.ReadLine();
                        Console.WriteLine("Enter the priority");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Enter the submitter");
                        string submitter = Console.ReadLine();
                        Console.WriteLine("Enter who is assigned");
                        string assigned = Console.ReadLine();
                        Console.WriteLine("Enter who is watching");
                        string watching = Console.ReadLine();
                        sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{6}|{6}", TicketID, summary, status, priority, submitter, assigned, watching);
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}

