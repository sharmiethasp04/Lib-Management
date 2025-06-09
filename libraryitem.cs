// See https://aka.ms/new-console-template for more information

namespace LibraryManagement;

class LibraryItem
{
    public string Id { get; set; }
    public string Title { get; set; }

    public LibraryItem(string title, string id)
    {
        Title = title;
        Id = id;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Id: {Id}");
    }

}
