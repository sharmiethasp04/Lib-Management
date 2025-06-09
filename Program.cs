
// See https://aka.ms/new-console-template for more information


using LibraryManagement;
// Book b1 = new Book { Title = "Pride and Prejudice", Author = "Jane Austin", ISBN="abc"};
Book b1 = new Book("HarryPotter", "J.K.Rowling", "567899", "hgf");

Magazine m1 = new Magazine("4567", "The Hindu", "45689");
Dvd d1 = new Dvd("6758", "ghjf", "fhjd");

b1.ShowInfo();
b1.DisplayDetails();
m1.ShowInfo();
m1.DisplayDetails();
d1.ShowInfo();
d1.DisplayDetails();

