namespace LibraryManagement;

class Magazine : LibraryItem
{
    public string Issuenumber { get; set; }

    public Magazine(string title, string issuenumber, string id) : base(title, id)
    {
        Title = title;
        Issuenumber = issuenumber;
        Id = id;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"IssueNumber: {Issuenumber}");
    }
}