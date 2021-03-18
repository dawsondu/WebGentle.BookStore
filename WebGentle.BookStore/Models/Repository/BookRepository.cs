using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Models.Repository
{ 
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreateOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdateOn = DateTime.UtcNow

            };
           await _context.Books.AddAsync(newBook);
           await _context.SaveChangesAsync();
            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allooks = await _context.Books.ToListAsync();
            if (allooks?.Any() == true)
            {
                foreach (var book in allooks)
                {
                    books.Add(new BookModel() { 
                     Author =book.Author,
                     Category = book.Category,
                     Description = book.Description,
                     Id = book.Id,
                     Language = book.Language,
                     Title = book.Title,
                     TotalPages = book.TotalPages
                    });
                }

            }
            return books;
        }
        public async Task<BookModel>GetBookById(int id)
        {
            var book =await _context.Books.FindAsync(id);
            if (book != null)
            {
                var bookDetails = new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    Language = book.Language,
                    Title = book.Title,
                    TotalPages = book.TotalPages
                };
                return bookDetails;
            }
            return null;

             
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
                 
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1, Title="MVC",Author="Nitish", Description="This is a book about MVC",Category="Action",Language="English", TotalPages=1245},
                new BookModel(){ Id=2, Title="Dot Net Core",Author="Nitish", Description="This is a book about dot net Core", Category="Drama",Language="Chinese", TotalPages=1003},
                new BookModel(){ Id=3, Title="C#",Author="Monika",  Description="This is a book about C Sharp",Category="Tech",Language="Irish",TotalPages = 562},
                new BookModel(){ Id=4, Title="Java",Author="WebGentle",Description="This is a book about Java",Category="Tech",Language="India",TotalPages = 145},
                new BookModel(){ Id=5, Title="Php",Author="WebGentle",Description="This is a book about PHP" ,Category="Action",Language="English",TotalPages = 568},
                new BookModel(){ Id=6, Title="JSP",Author="WebGentle",Description="This is a book about JSP",Category="Tech",Language="Janpan",TotalPages = 689},
            };
        }
    }
}
