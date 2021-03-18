using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            var model = new BookModel()
            {
                //Language = "2"
            };  //set the default value into "English"
            var group1 = new SelectListGroup() {Name="Group1" };
            //var group2 = new SelectListGroup() {Name="Group2",Disabled=true };
            var group2 = new SelectListGroup() {Name="Group2"};
            var group3 = new SelectListGroup() {Name="Group3" };

            //ViewBag.Language = new SelectList(GetLanguage(),"Id","Text");
            ViewBag.Language = new List<SelectListItem>() 
            {
                new SelectListItem(){ Text="Hindi",Value="1",Group = group1},
                new SelectListItem(){ Text="English",Value="2",Group = group1},
                new SelectListItem(){ Text="Dutch",Value="3",Group = group2},
                new SelectListItem(){ Text="Tamil",Value="4",Group = group2},
                new SelectListItem(){ Text="Urdu",Value="5",Group = group3},
                new SelectListItem(){ Text="Chinese",Value="6",Group = group3},
            };



            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }
            ViewBag.Language = new SelectList(GetLanguage(), "Id", "Text");
            //ViewBag.IsSuccess = false;
            //ViewBag.BookId = 0;

            return View();
        }
        private List<LanguageModel> GetLanguage()
        {
            return new List<LanguageModel>()
            {
                new LanguageModel() {Id=1,Text = "Hindi" },
                new LanguageModel() {Id=2,Text = "English" },
                new LanguageModel() {Id=3,Text = "Dutch" },
            };
        }
    }
}
