namespace FilesProject;

public class Contact
{
    public string DesktopPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    public string ContactFolder { get; set; }

    public Contact()
    {
        ContactFolder = Path.Combine(DesktopPath, "Contact Folder");
        if (!Directory.Exists(ContactFolder))
        {
            Directory.CreateDirectory(ContactFolder);
        }
    }

    public void CreateContact(ContactDetails contactDetails)
    {
        Console.WriteLine("Type the name of your contact file here:");
        string fileName = Path.Combine(ContactFolder, $"{Console.ReadLine()}.txt");

        var createFile = File.Exists(fileName) ? null : File.Create(fileName);
        if (createFile is not null) createFile.Close();

        File.WriteAllText(fileName, $"Name: {contactDetails.Name}\nPhone: {contactDetails.PhoneNo}\nEmail: {contactDetails.Email}\nAddress: {contactDetails.Address}");
        Console.WriteLine("Contact created successfully!");
    }

    public void ViewContact()
    {
        Console.WriteLine("Enter the contact file name to view:");
        string fileName = Path.Combine(ContactFolder, $"{Console.ReadLine()}.txt");
        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void UpdateContact(ContactDetails contactDetails)
    {
        Console.WriteLine("Enter the contact file name to update:");
        string fileName = Path.Combine(ContactFolder, $"{Console.ReadLine()}.txt");
        if (File.Exists(fileName))
        {
            File.WriteAllText(fileName, $"Name: {contactDetails.Name}\nPhone: {contactDetails.PhoneNo}\nEmail: {contactDetails.Email}\nAddress: {contactDetails.Address}");
            Console.WriteLine("Contact updated successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void DeleteContact()
    {
        Console.WriteLine("Enter the contact file name to delete:");
        string fileName = Path.Combine(ContactFolder, $"{Console.ReadLine()}.txt");
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}