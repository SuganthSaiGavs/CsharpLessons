using LibraryA;


Book book = new Book();
book.Title = "To Kill A Mocking Bird";
book.Author = "Harper lee";
book.Genre = "Social";
book.BookPrice = 250;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookmarkPage(125);

Console.WriteLine(book.GetCurrentPage());

Calculator calculator = new Calculator();
int addResult = calculator.Add(10, 20);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multiply(10, 20);
Console.WriteLine(multiplyResult);
int divideResult = calculator.Divide(10, 20);
Console.WriteLine(divideResult);

