using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;
using WebGentle.BookStore.Models.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        
        private  readonly BookRepository _bookRepository = null;
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();

            return View(data);
        }
        [Route("book-detail/{id}",Name="bookdetailsRoute")] //重新命名路由，将"/getbook/1",改名为"/book-detail/1"
        public async Task<ViewResult> GetBook( int id )
        {
            var data =await  _bookRepository.GetBookById(id);

            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }
        public IActionResult AddNewBook()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddNewBook(bool isSuccess = false,int bookId=0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
           int id = await  _bookRepository.AddNewBook(bookModel);
            if(id>0)
            {
                return RedirectToAction(nameof(AddNewBook),new { isSuccess = true ,bookId = id});
            }
            return View();
        }
    }
}
