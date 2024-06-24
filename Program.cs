using PhoneBookApp.Services;
using System;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to the Phonebook Console Application\n");
            bool continueProg = true;

            while (continueProg)
            {
                Console.WriteLine("\t\t\t\t\tMenu:");
                Console.WriteLine("1. My contacts");
                Console.WriteLine("2. Add contact");
                Console.WriteLine("3. Edit contact");
                Console.WriteLine("4. Delete contact");
                Console.WriteLine("5. Exit Program\n");

                Console.WriteLine("Choose you wanted:");
                try
                {
                    string input = Console.ReadLine();
                    int userInput = int.Parse(input);

                    switch (userInput)
                    {
                        case 1:
                            ContactServices.ShowAllContacts();
                            break;
                        case 2:
                            ContactServices.AddContact();
                            ContactServices.ShowAllContacts();
                            break;
                        case 3:
                            ContactServices.EditContact();
                            ContactServices.ShowAllContacts();
                            break;
                        case 4:
                            ContactServices.DeleteContact();
                            ContactServices.ShowAllContacts();
                            break;
                        case 5:
                            continueProg = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Enter a number from 1 to 5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value. Try again!!!");
                }
            }
        }
    }
}
