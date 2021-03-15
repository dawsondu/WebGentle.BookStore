using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Models.Repository
{ 
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
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
