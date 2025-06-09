namespace LibraryManagement;

class Dvd : LibraryItem
{
    public string Issuenumber { get; set; }

    public Dvd(string title, string issuenumber, string id) : base(title, id)
    {
        Title = title;
        Issuenumber = issuenumber;
        Id = id;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("------------");
        Console.WriteLine($"IssueNumber: {Issuenumber}");
    }
}