namespace FilesProject;

public class Menu
{
    public void MainMenu()
    {
        Console.WriteLine("Welcome to the contact app. Click any button to continue");
        Console.ReadLine();

        Console.WriteLine("Choose any option below:\n1 to create a contact\n2 to view your contacts\n3 to edit your contacts\n4 to delete contacts\n9 to exit app");
        int option = 0;
        while (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Invalid input, please try again");
        }

        Contact contact = new();

        switch (option)
        {
            case 1:
                ContactDetails contactDetails = new();
                Console.WriteLine("Let's create a contact for you");

                Console.WriteLine("Contact name:");
                contactDetails.Name = Console.ReadLine()!;

                Console.WriteLine("Email:");
                contactDetails.Email = Console.ReadLine()!;

                Console.WriteLine("Address:");
                contactDetails.Address = Console.ReadLine()!;

                Console.WriteLine("Phone number:");
                long phoneNo = 0;
                while (!long.TryParse(Console.ReadLine(), out phoneNo))
                {
                    Console.WriteLine("Invalid input, please try again");
                }
                contactDetails.PhoneNo = phoneNo;

                contact.CreateContact(contactDetails);
                break;

            case 2:
                contact.ViewContact();
                break;

            case 3:
                ContactDetails updatedDetails = new();
                Console.WriteLine("Enter updated name:");
                updatedDetails.Name = Console.ReadLine()!;

                Console.WriteLine("Enter updated email:");
                updatedDetails.Email = Console.ReadLine()!;

                Console.WriteLine("Enter updated address:");
                updatedDetails.Address = Console.ReadLine()!;

                Console.WriteLine("Enter updated phone number:");
                long updatedPhone = 0;
                while (!long.TryParse(Console.ReadLine(), out updatedPhone))
                {
                    Console.WriteLine("Invalid input, please try again");
                }
                updatedDetails.PhoneNo = updatedPhone;

                contact.UpdateContact(updatedDetails);
                break;

            case 4:
                contact.DeleteContact();
                break;

            case 9:
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }
    }
}