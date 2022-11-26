using Context;
using WebApplicationCoreWebApi.Business_Layer.Interfaces;
using WebApplicationCoreWebApi.Models;
using WebApplicationCoreWebApi.Models.RequestModels;

namespace WebApplicationCoreWebApi.Business_Layer.Implementation
{
    public class Books_DAL : IBooks_DAL
    {
        public Books_DAL()
        {
        }
        public async Task<List<Books>> Get()
        {
            using (var context = new BooksManagementContext())
            {
                var books = from b in context.Books
                            select b;
                return books.ToList();
            }

        }

        public async Task<Books> GetById(Guid guid)
        {
            try
            {
                if (guid == Guid.Empty)
                    throw new ArgumentNullException(nameof(guid));
                using (var context = new BooksManagementContext())
                    return context.Books.Where(x => x.BookId == guid).First();
            }catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> Post(BookModel books)
        {
            try
            {
                if (books == null)
                    throw new ArgumentNullException(nameof(books));
                using (var context = new BooksManagementContext())
                {
                    Books book = new Books()
                    {
                        AuthorName = books.AuthorName,
                        BookId = new Guid(),
                        BookName = books.BookName,
                    };
                    context.Books.Add(book);
                    var result = context.SaveChangesAsync();
                    return await result;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
