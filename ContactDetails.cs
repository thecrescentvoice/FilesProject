namespace FilesProject;

public class ContactDetails
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long PhoneNo { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public decimal AccountBalance { get; set; }
}