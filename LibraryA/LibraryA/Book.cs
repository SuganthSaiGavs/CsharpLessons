namespace LibraryA
{  /// <summary>
/// cant able to run this code
/// we can have multiple libraraies = but only one exceutable project in the solution(LibraryA)
/// reference to librarayA is added to client app(runnable)-- right click on dependenies
/// </summary>
    public class Book
    {
        public String Title=String.Empty;
        public String Genre=String.Empty;
        public String Author=String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public Book()
        {
            Console.WriteLine("Book obj is created");
        }

        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }

        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No: {pageNo} Bookmarked");
        }

        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }



    }
}