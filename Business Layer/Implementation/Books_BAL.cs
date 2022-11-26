using WebApplicationCoreWebApi.Business_Layer.Interfaces;
using WebApplicationCoreWebApi.Models;
using WebApplicationCoreWebApi.Models.RequestModels;

namespace WebApplicationCoreWebApi.Business_Layer.Implementation
{
    public class Books_BAL: IBooks_BAL
    {
        private readonly IBooks_DAL _books_DAL;
        public Books_BAL(IBooks_DAL books_DAL)
        {
            _books_DAL = books_DAL;
        }
        public async Task<List<Books>> Get()
        {
            return await _books_DAL.Get();
        }

        public Task<Books> GetById(Guid guid)
        {
            return  _books_DAL.GetById(guid);
        }

        public async Task<int> Post(BookModel books)
        {
            return await _books_DAL.Post(books);
        }
    }
}
