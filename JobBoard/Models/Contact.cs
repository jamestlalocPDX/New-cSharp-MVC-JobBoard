namespace JobBoard.Models
{
  public class Contact
  {
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public Contact(string name, string phoneNumber, string emailAddress)
    {
      Name = name;
      PhoneNumber = phoneNumber;
      EmailAddress = emailAddress;
    }
  }
}