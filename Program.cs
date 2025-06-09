
// See https://aka.ms/new-console-template for more information


using LibraryManagement;
// Book b1 = new Book { Title = "Pride and Prejudice", Author = "Jane Austin", ISBN="abc"};
try
{
    Book b1 = new Book("HarryPotter", "J.K.Rowling", "567899", "hgf");
    Magazine m1 = new Magazine("4567", "The Hindu", "45689");
    Dvd d1 = new Dvd("6758", "ghjf", "fhjd");
    b1.ShowInfo();
    b1.DisplayDetails();
    m1.ShowInfo();
    m1.DisplayDetails();
    d1.ShowInfo();
    d1.DisplayDetails();


}


catch(InvalidBookException ex)
{
    Console.WriteLine($"The error {ex.Message}");
}
Console.WriteLine("Enter the overdue days");
double overdue = Convert.ToInt32(Console.ReadLine());
if (overdue > 15)
{
    overdue = (overdue - 15) * 1;
    Console.WriteLine("Overdue fee: Rs."+overdue);
}
Console.WriteLine("Membership status: ");
string mem = Console.ReadLine();
if (mem == "S")
{
    overdue = overdue - (overdue* 0.01);
    Console.WriteLine("Discount status: " + overdue);
}