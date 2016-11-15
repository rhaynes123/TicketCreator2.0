using System;
namespace ProblemTicketTracker
{
	class TicketCreator
	{
		static void Main(string[] args)
		{
			string cstmerName; 
			string phoneNumber;
			string emailAddress;
			string problemDescription;
			int tktNumber = new Random().Next(100000,999999);
			Console.WriteLine("Hello Please Fill In the Required Information to Create a problem ticket");
			Console.Write("Name:");
			cstmerName = Console.ReadLine();
			Console.Write("Phone Number:");
			phoneNumber = Console.ReadLine();
			Console.Write("Email Address:");
			emailAddress = Console.ReadLine();
			Console.Write("Please enter in a detailed descritpion of the issues you are experiencing: ");
			problemDescription = Console.ReadLine();
			Console.Write("\n\n");
			Console.WriteLine("Thank you for your input. A problem Ticket has been created and submitted to one of our agents.");
			Console.WriteLine("Ticket Number: TK{0}", tktNumber);
			Console.WriteLine("Name: {0}", cstmerName);
			Console.WriteLine("Phone Number: {0}", phoneNumber);
			Console.WriteLine("Email Address: {0} ", emailAddress);
			Console.WriteLine("Work Notes: {0}.\nPlease retain you ticket number and reference the number for updates. Thank you.", problemDescription);
		}
	}
}