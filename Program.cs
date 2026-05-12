using FilesProject;

Menu menu = new();
menu.MainMenu();

var firstContact = new ContactDetails() { Id = 1, Name = "Mr A", Email = "mra@somemail.com", Address = "somewhere", PhoneNo = 12345678, AccountBalance = 5000 };
var secondContact = new ContactDetails() { Id = 2, Name = "Mr B", Email = "mrb@somemail.com", Address = "nowhere", PhoneNo = 87654321, AccountBalance = 97000 };
var thirdContact = new ContactDetails() { Id = 3, Name = "Mr C", Email = "mrc@somemail.com", Address = "anywhere", PhoneNo = 56781234, AccountBalance = -4000 };
var fourthContact = new ContactDetails() { Id = 4, Name = "Ms D", Email = "msd@somemail.com", Address = "Oak Street 12", PhoneNo = 67891234, AccountBalance = 2500 };
var fifthContact = new ContactDetails() { Id = 5, Name = "Dr E", Email = "dre@somemail.com", Address = "Maple Avenue", PhoneNo = 78912345, AccountBalance = 0 };
var sixthContact = new ContactDetails() { Id = 6, Name = "Mrs F", Email = "mrsf@somemail.com", Address = "Green Hills", PhoneNo = 89123456, AccountBalance = -1500 };
var seventhContact = new ContactDetails() { Id = 7, Name = "Mr G", Email = "mrg@somemail.com", Address = "Sunset Boulevard", PhoneNo = 91234567, AccountBalance = 7200 };
var eighthContact = new ContactDetails() { Id = 8, Name = "Miss H", Email = "missh@somemail.com", Address = "Riverbank Close", PhoneNo = 12345678, AccountBalance = 310000 };
var ninthContact = new ContactDetails() { Id = 9, Name = "Chief I", Email = "chiefi@somemail.com", Address = "Hilltop Estate", PhoneNo = 23456789, AccountBalance = -980 };
var tenthContact = new ContactDetails() { Id = 10, Name = "Prof J", Email = "profj@somemail.com", Address = "Palm Drive", PhoneNo = 34567890, AccountBalance = 1500000 };

var contactList = new List<ContactDetails>();
contactList.AddRange([firstContact, secondContact, thirdContact, fourthContact, fifthContact, sixthContact, seventhContact, eighthContact, ninthContact, tenthContact]);

// Find first contact with balance <= 0
var linqQuery = contactList.Find(x => x.AccountBalance <= 0);

// Find all contacts with negative balance
var anotherLinqQuery = contactList.Where(x => x.AccountBalance < 0);

// Find by Id
var findById = contactList.FirstOrDefault(x => x.Id == 1);

// View contact by Id
Console.WriteLine("\n--- View Contact by Id ---");
Console.Write("Enter Id to view: ");
int viewId = int.Parse(Console.ReadLine()!);
var contactToView = contactList.FirstOrDefault(x => x.Id == viewId);
if (contactToView is not null)
{
    Console.WriteLine($"Name: {contactToView.Name}");
    Console.WriteLine($"Email: {contactToView.Email}");
    Console.WriteLine($"Address: {contactToView.Address}");
    Console.WriteLine($"Phone: {contactToView.PhoneNo}");
    Console.WriteLine($"Balance: {contactToView.AccountBalance}");
}
else Console.WriteLine("Contact not found.");

// Update by Id
Console.WriteLine("\n--- Update Contact by Id ---");
Console.Write("Enter Id to update: ");
int updateId = int.Parse(Console.ReadLine()!);
var contactToUpdate = contactList.FirstOrDefault(x => x.Id == updateId);
if (contactToUpdate is not null)
{
    Console.Write("New Name: ");
    contactToUpdate.Name = Console.ReadLine()!;
    Console.WriteLine("Contact updated!");
}
else Console.WriteLine("Contact not found.");

// Delete by Id
Console.WriteLine("\n--- Delete Contact by Id ---");
Console.Write("Enter Id to delete: ");
int deleteId = int.Parse(Console.ReadLine()!);
var contactToDelete = contactList.FirstOrDefault(x => x.Id == deleteId);
if (contactToDelete is not null)
{
    contactList.Remove(contactToDelete);
    Console.WriteLine("Contact deleted!");
}
else Console.WriteLine("Contact not found.");

// Print all debtors
Console.WriteLine("\n--- Debtors List ---");
foreach (var contact in anotherLinqQuery)
{
    Console.WriteLine($"Name: {contact.Name}");
    Console.WriteLine($"Address: {contact.Address}");
    Console.WriteLine($"Phone no: {contact.PhoneNo}");
    Console.WriteLine($"Account balance: {contact.AccountBalance}");
    Console.WriteLine("--------------------");
}