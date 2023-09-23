﻿using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YourAppNamespace.Models;

namespace FirstMVCApp.Controllers
{
    public class AuthorController1 : Controller
    {
        // GET: AuthorController1
        public ActionResult Index()  //ActionResult renders HTML page
        {
            Dictionary<int,Author> list =AuthorRepository.GetAuthorDictionary();
            if(list != null && list.Count>0)
            {
                return View("AuthorList",list.Values.ToList());
            }
            return View();
        }

        // GET: AuthorController1/Details/5
        public ActionResult Details(int id)
        {
            Author author=AuthorRepository.FindAuthorById(id);
            if(author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }

        // GET: AuthorController1/Create
        public ActionResult Create()  //when Create action gets called it invoke both methods(method overloading). 
        {
            Author author = new Author();
            return View(author);
        }

        // POST: AuthorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));  //redirects to Index action
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController1/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if (author != null)
            {
                return View(author);
            }
            return View();
        }

        // POST: AuthorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.UpdateAuthorToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController1/Delete/5
        public ActionResult Delete(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if (author != null)
            {
                return View(author);
            }
            return View(author);
        }

        // POST: AuthorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
