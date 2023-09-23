using Microsoft.AspNetCore.Mvc;
using YourAppNamespace.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FirstMVCApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)  //
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateAuthor()
        {
            Author author = new Author();
            return View(author);
        }

        public IActionResult SaveAuthor(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            string str = $"{pAuthor.AuthorId},{pAuthor.AuthorName},{pAuthor.DateOfBirth},{pAuthor.NoOfBooksPublished},{pAuthor.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(str);
            }
            return View(pAuthor);

        }

        public IActionResult ListAllAuthor()
        {
            String fName = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strAuthor = $"{sr.ReadLine()}";
                string[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorId = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.NoOfBooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = (data[4]);
            return author;
        }

        private readonly string _filePath = @"c:\temp\author.csv"; // Set your file's path

        [HttpGet]
        public IActionResult DeleteAuthor(int id)
        {
            var authors = ReadFromFile();
            var authorToDelete = authors.FirstOrDefault(a => a.AuthorId == id);

            if (authorToDelete != null)
            {
                authors.Remove(authorToDelete);
                WriteToFile(authors);
                return Ok("Author deleted successfully.");
            }

            return NotFound("Author not found.");
        }

        private List<Author> ReadFromFile()
        {
            var authors = new List<Author>();
            var lines = System.IO.File.ReadAllLines(_filePath);

            foreach (var line in lines)
            {
                var data = line.Split(',');
                var author = new Author
                {
                    AuthorId = int.Parse(data[0]),
                    AuthorName = data[1],
                    DateOfBirth = DateTime.Parse(data[2]),
                    NoOfBooksPublished = int.Parse(data[3]),
                    RoyaltyCompany = data[4]
                };
                authors.Add(author);
            }

            return authors;
        }

        private void WriteToFile(List<Author> authors)
        {
            var lines = authors.Select(a => $"{a.AuthorId},{a.AuthorName},{a.DateOfBirth},{a.NoOfBooksPublished},{a.RoyaltyCompany}");
           // File.WriteAllLines(_filePath, lines);
        }
    }
}
