// See https://aka.ms/new-console-template for more information


namespace LibraryManagement;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    
    // void Book (title="Life of Pi",author="sp",isbn="ISBN")
    // {
    //     title=Title;
    //     author=Author;
    //     isbn=ISBN;
    // }

    public void DisplayDetails() {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
    }

}