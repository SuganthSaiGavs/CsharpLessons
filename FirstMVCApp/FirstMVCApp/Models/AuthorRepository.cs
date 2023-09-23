using System.Text;
using YourAppNamespace.Models;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int,Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\author.csv";
            Dictionary<int,Author> list = new Dictionary<int,Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
             using(StreamReader sr= new StreamReader(fName))
                {
                    string strAuthor=$"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorId, author); 
                        while(!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data=strAuthor.Split(",");
                            if(data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorId, author);  
                            }

                        }
                    }
                }  
            }
            return list;
        }

        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorId = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.NoOfBooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = (data[4]);
            return author;
        }

        /*private static AuthorRepository StringToAuthor(String[] data,Author author)
        {

        }*/

        /*public static Author FindAuthorById(int id)
        {



        }*/
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            string strAuthor=$"{pAuthor.AuthorId},{pAuthor.AuthorName},{pAuthor.DateOfBirth},{pAuthor.NoOfBooksPublished},{pAuthor.RoyaltyCompany}";
            using (StreamWriter sw =new  StreamWriter(fName,true)) 
            {
                sw.WriteLine(strAuthor);
            }

            
        }

        public static Author FindAuthorById(int id)
        {
            Dictionary<int,Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {
                author=list.FirstOrDefault(x=>(x.Key == id)).Value;
            }
            return author;
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);

           
                foreach (Author author in list.Values)
                {
                    if (author.AuthorId != id)
                    {
                        sbAuthors.Append($"{author.AuthorId},{author.AuthorName},{author.DateOfBirth},{author.NoOfBooksPublished},{author.RoyaltyCompany}{Environment.NewLine}");
                       
                    }
                }
                File.WriteAllText(fName, sbAuthors.ToString());
            



        }

        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))  //StreamWriter to update into file
            {
                foreach (Author author in list.Values)
                {
                    if (author.AuthorId != pAuthor.AuthorId)
                        strAuthor = $"{author.AuthorId},{author.AuthorName},{author.DateOfBirth},{author.NoOfBooksPublished},{author.RoyaltyCompany}";  //new object(author values) is created
                    else
                        strAuthor = $"{pAuthor.AuthorId},{pAuthor.AuthorName},{pAuthor.DateOfBirth},{pAuthor.NoOfBooksPublished},{pAuthor.RoyaltyCompany}"; //it changes in the already exists object.
                    sw.WriteLine(strAuthor);
                }
            }
        }


    }
}
