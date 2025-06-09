// See https://aka.ms/new-console-template for more information




namespace LibraryManagement;

class Book : LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Id{ get; set; }

    public Book(string title, string author, string isbn, string id) : base(title,id)
    {
        Title = title;
        Author = author;
        Id = id;
        // if (isbn.Length != 16)
        // {
        //     throw new InvalidBookException("ISBN must be 16 letters long");
        // }
        ISBN = isbn;
    }


    public void DisplayDetails() {
        Console.WriteLine("-----------");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Author: {Author}");
    }

}