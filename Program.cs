
// See https://aka.ms/new-console-template for more information


using LibraryManagement;
Book b1 = new Book { Title = "Pride and Prejudice", Author = "Jane Austin", ISBN="abc"};
Book b2 = new Book { Title = "HarryPotter", Author = "J.K.Rowling" , ISBN="8998"};
// Book b1= {"HarryPotter","J.K.Rowling","567899"};

b1.DisplayDetails();
b2.DisplayDetails();